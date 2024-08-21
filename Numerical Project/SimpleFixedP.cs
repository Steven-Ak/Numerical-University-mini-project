using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace Numerical_Project
{

    public partial class SimpleFixedP : Form
    {
        double xii = 0;
        double xip1 = 0;
        double eerror = 0;
        int counter = 0;
        public SimpleFixedP()
        {
            InitializeComponent();
        }

        private void SimpleFixedP_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        double f(double xx)
        {
            try
            {
                string s = txtFn.Text;
                double result;
                result = Eval.Execute<double>(txtFn.Text.ToString(), new { x = xx });
                return (Math.Round(result, 3));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }

            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double xii = Convert.ToDouble(txtXi.Text);
            double Err = Convert.ToDouble(txtError.Text);

            do
            {
                xip1 = f(xii);
                dataGridView1.Rows.Add(counter.ToString(),
                    Math.Round(xii, 3).ToString(),
                    Math.Round(xip1, 3).ToString(),
                    Math.Round(eerror, 3).ToString(), " ");

                eerror = Math.Abs((xip1 - xii) / xip1) * 100;
                xii = xip1;
                counter++;

            } while (eerror >= (Err / 100) * 100);
            xip1 = f(xii);
            dataGridView1.Rows.Add(counter.ToString(),
                Math.Round(xii, 3).ToString(),
                Math.Round(xip1, 3).ToString(),
                Math.Round(eerror, 3).ToString(), " ");

            txtRoot.Text = xip1.ToString();
            txt_Ferror.Text = Math.Round(eerror, 3).ToString();

        
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFn.Text = "";
            txtXi.Text = "";
            txtRoot.Text = "";
            txt_Ferror.Text = " ";
            txtError.Text = "";

            dataGridView1.Rows.Clear();

            xip1 = 0;
            xii = 0;
            eerror = 0;
            counter = 0;
        }
    }
 
}
