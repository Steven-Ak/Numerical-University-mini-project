using System;
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
    public partial class GEPivoting : Form
    {
        public GEPivoting()
        {
            InitializeComponent();
        }

        private void GEPivoting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double[,] matrixA = new double[3, 3];
            double[] vectorB = new double[3];

            // Read matrix A coefficients
            matrixA[0, 0] = Convert.ToDouble(txt11.Text);
            matrixA[0, 1] = Convert.ToDouble(txt12.Text);
            matrixA[0, 2] = Convert.ToDouble(txt13.Text);

            matrixA[1, 0] = Convert.ToDouble(txt21.Text);
            matrixA[1, 1] = Convert.ToDouble(txt22.Text);
            matrixA[1, 2] = Convert.ToDouble(txt23.Text);

            matrixA[2, 0] = Convert.ToDouble(txt31.Text);
            matrixA[2, 1] = Convert.ToDouble(txt32.Text);
            matrixA[2, 2] = Convert.ToDouble(txt33.Text);

            // Read constants vector B
            vectorB[0] = Convert.ToDouble(txtB1.Text);
            vectorB[1] = Convert.ToDouble(txtB2.Text);
            vectorB[2] = Convert.ToDouble(txtB3.Text);

            // Perform Gaussian elimination with partial pivoting
            GaussianElimination(matrixA, vectorB);

            // Back substitution
            double[] solution = BackSubstitution(matrixA, vectorB);

            // Display the solution
            txtX1.Text = solution[0].ToString();
            txtX2.Text = solution[1].ToString();
            txtX3.Text = solution[2].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);

        }

        private void GaussianElimination(double[,] matrixA, double[] vectorB)
        {
            int n = vectorB.Length;

            for (int i = 0; i < n; i++)
            {
                // Partial pivoting
                int maxIndex = i;
                double maxValue = matrixA[i, i];
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matrixA[k, i]) > Math.Abs(maxValue))
                    {
                        maxIndex = k;
                        maxValue = matrixA[k, i];
                    }
                }

                // Swap rows
                if (maxIndex != i)
                {
                    for (int k = i; k < n; k++)
                    {
                        double temp = matrixA[i, k];
                        matrixA[i, k] = matrixA[maxIndex, k];
                        matrixA[maxIndex, k] = temp;
                    }
                    double tempB = vectorB[i];
                    vectorB[i] = vectorB[maxIndex];
                    vectorB[maxIndex] = tempB;
                }

                // Forward elimination
                for (int j = i + 1; j < n; j++)
                {
                    double factor = matrixA[j, i] / matrixA[i, i];
                    vectorB[j] -= factor * vectorB[i];
                    for (int k = i; k < n; k++)
                    {
                        matrixA[j, k] -= factor * matrixA[i, k];
                    }
                }
            }
        }

        private double[] BackSubstitution(double[,] matrixA, double[] vectorB)
        {
            int n = vectorB.Length;
            double[] solution = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                solution[i] = vectorB[i];
                for (int j = i + 1; j < n; j++)
                {
                    solution[i] -= matrixA[i, j] * solution[j];
                }
                solution[i] /= matrixA[i, i];
            }

            return solution;
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
    }
}
