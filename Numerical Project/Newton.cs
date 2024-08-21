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
    public partial class Newton : Form
    {

        double Xnew = 0;
        double xii = 0;
        double eerrorr = 0;
        int counter = 0;
        public Newton()
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

        double Fdash(double xx)
        {
            try
            {
                string w = txtFdash.Text;
                double result;
                result = Eval.Execute<double>(txtFdash.Text.ToString(), new { x = xx });
                return (Math.Round(result, 4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }
        }

        private void Newton_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txtXi.Text);
            Newto(x0);

            txt_Ferror.Text = Math.Round(eerrorr, 3).ToString();
        }

        void Newto(double x)
        {
            if (counter == 0)
            {
                xii = x;
                dataGridView1.Rows.Add(counter.ToString(),
                    Math.Round(xii, 4).ToString(),
                    Math.Round(f(xii), 4).ToString(),
                    Math.Round(Fdash(xii)).ToString(), " ");
                counter++; Newto(xii);
            }
            else
            {
                xii = x;
                Xnew = xii - (f(xii) / Fdash(xii));
                eerrorr = Math.Abs((Xnew - xii) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew, 4).ToString(), Math.Round(f(Xnew), 5).ToString(), Math.Round(Fdash(Xnew), 5).ToString(), Math.Round(eerrorr, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txtError.Text);
                if (eerrorr > Err)
                    Newto(Xnew);
            }
            txtRoot.Text = Math.Round(Xnew, 4).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtFn.Text = "";
            txtFdash.Text = "";
            txtXi.Text = "";
            txtRoot.Text = "";
            txt_Ferror.Text = "";

            dataGridView1.Rows.Clear();
            counter = 0;
            xii = 0;
            Xnew = 0;
            eerrorr = 0;
        }
    }
}
