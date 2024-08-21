using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace Numerical_Project
{
    public partial class FalsePostion : Form
    {
        double xolder = 0;
        double xrr = 0;
        double eerror = 0;
        int counter = 0;
        public FalsePostion()
        {
            InitializeComponent();
        }

        private void FalsePostion_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        double f(double xx)
        {
            try
            {
                string w = txtFn.Text;
                double result;
                result = Eval.Execute<double>(txtFn.Text.ToString(), new { x = xx });
                return (Math.Round(result, 4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(txtXl.Text);
            double xu = Convert.ToDouble(txtXu.Text);
            double Err = Convert.ToDouble(txtError.Text);

            if (f(xl) * f(xu) < 0)
            {
                do
                {
                    xrr = xu - ((f(xu) * (xl - xu)) / (f(xl) - f(xu)));
                    eerror = Math.Abs((xrr - xolder) / xrr) * 100;
                    xolder = xrr;

                    if (counter == 0) { dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 4).ToString(), f(xl).ToString(), Math.Round(xu, 4).ToString(), f(xu).ToString(), Math.Round(xrr, 4).ToString(), f(xrr).ToString(), " "); }
                    else { dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 4).ToString(), f(xl).ToString(), Math.Round(xu, 4).ToString(), f(xu).ToString(), Math.Round(xrr, 4).ToString(), f(xrr).ToString(), Math.Round(eerror, 4).ToString()); }

                    counter++;

                    if (f(xl) * f(xrr) < 0)
                    {
                        xu = xrr;
                    }
                    else if (f(xl) * f(xrr) > 0)
                    {
                        xl = xrr;
                    }
                } while (eerror > (Err / 100) * 100);

                txtRoot.Text = xrr.ToString();
                txt_Ferror.Text = Math.Round(eerror, 3).ToString();

            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFn.Text = "";
            txtXu.Text = "";
            txtXl.Text = "";
            txtRoot.Text = "";
            txtError.Text = "";
            txt_Ferror.Text = "";

            dataGridView1.Rows.Clear();

            xolder = 0;
            xrr = 0;
            eerror = 0;
            counter = 0;
        }
    }
}
