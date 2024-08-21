﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Project
{
    public partial class GJ : Form
    {
        public GJ()
        {
            InitializeComponent();
        }

        private void GJ_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double[,] matrix = { { Convert.ToDouble(txt11.Text), Convert.ToDouble(txt12.Text), Convert.ToDouble(txt13.Text) },
                                 { Convert.ToDouble(txt21.Text), Convert.ToDouble(txt22.Text), Convert.ToDouble(txt23.Text) },
                                 { Convert.ToDouble(txt31.Text), Convert.ToDouble(txt32.Text), Convert.ToDouble(txt33.Text) } };

            double[] constants = { Convert.ToDouble(txtB1.Text), Convert.ToDouble(txtB2.Text), Convert.ToDouble(txtB3.Text) };

            GaussJordan gaussJordan = new GaussJordan(matrix, constants);
            double[] solution = gaussJordan.Solve();

            txtX1.Text = solution[0].ToString();
            txtX2.Text = solution[1].ToString();
            txtX3.Text = solution[2].ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl); 
                }
            }
        }
        public class GaussJordan
        {
            private double[,] matrix;
            private double[] constants;
            private int n;

            public GaussJordan(double[,] matrix, double[] constants)
            {
                this.matrix = matrix;
                this.constants = constants;
                this.n = matrix.GetLength(0);
            }

            public double[] Solve()
            {
                for (int i = 0; i < n; i++)
                {
                    // Find the maximum element in the current column
                    int maxRow = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[maxRow, i]))
                        {
                            maxRow = j;
                        }
                    }

                    // Swap rows if necessary
                    if (maxRow != i)
                    {
                        SwapRows(i, maxRow);
                    }

                    // Eliminate the current column
                    for (int j = i + 1; j < n; j++)
                    {
                        double factor = matrix[j, i] / matrix[i, i];
                        for (int k = i; k < n; k++)
                        {
                            matrix[j, k] -= factor * matrix[i, k];
                        }
                        constants[j] -= factor * constants[i];
                    }
                }

                // Back-substitute to find the solution
                double[] solution = new double[n];
                for (int i = n - 1; i >= 0; i--)
                {
                    solution[i] = constants[i] / matrix[i, i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        constants[j] -= matrix[j, i] * solution[i];
                    }
                }

                return solution;
            }

            private void SwapRows(int i, int j)
            {
                double[] temp = new double[n];
                for (int k = 0; k < n; k++)
                {
                    temp[k] = matrix[i, k];
                    matrix[i, k] = matrix[j, k];
                    matrix[j, k] = temp[k];
                }
                double tempConst = constants[i];
                constants[i] = constants[j];
                constants[j] = tempConst;
            }
        }
    }

}
