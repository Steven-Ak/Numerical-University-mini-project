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
    public partial class Secant : Form
    {

        double Xold = 0;
        double xii = 0;
        double eerrorr = 0;
        int counter = 0;
        double xnew = 0;

        public Secant()
        {
            InitializeComponent();
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

        private void Secant_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double xol = Convert.ToDouble(txtXiminus1.Text);
            double x0 = Convert.ToDouble(txtXi.Text);
            Secan(xol, x0);
            txt_Ferror.Text = Math.Round(eerrorr, 3).ToString();
        }

        void Secan(double xol, double x0)
        {

            if (counter == 0)
            {
                Xold = xol;
                xii = x0;
                dataGridView1.Rows.Add(counter.ToString(), Xold.ToString(), Math.Round(f(Xold), 4).ToString(), xi.ToString(), Math.Round(f(xii), 4).ToString(), " ");
                counter++; Secan(Xold, xii);
            }
            else
            {
                Xold = xol;
                xii = x0;
                xnew = xii - ((f(xii) * (Xold - xii)) / (f(Xold) - f(xii)));
                eerrorr = Math.Abs((xnew - xii) / xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xii, 4).ToString(), Math.Round(f(xii), 4).ToString(), Math.Round(xnew, 4).ToString(), Math.Round(f(xnew), 4).ToString(), Math.Round(eerrorr, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txtError.Text);
                if (eerrorr > Err)
                    Secan(xii, xnew);
            }
            txtRoot.Text = Math.Round(xnew, 4).ToString();
            txt_Ferror.Text = Math.Round(eerrorr, 4).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            txt_Ferror.Text = "";
            txtFn.Text = "";
            txtRoot.Text = "";
            txtXi.Text = "";
            txtXiminus1.Text = "";

            dataGridView1.Rows.Clear();

            xnew = 0;
            xii = 0;
            eerrorr = 0;
            counter = 0;
        }
    }
}
