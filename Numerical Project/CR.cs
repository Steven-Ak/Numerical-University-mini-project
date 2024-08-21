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
    public partial class CR : Form
    {
        public CR()
        {
            InitializeComponent();
        }

        private void CR_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x00 = Convert.ToDouble(txt11.Text);
            double x01 = Convert.ToDouble(txt12.Text);
            double x02 = Convert.ToDouble(txt13.Text);
            double x03 = Convert.ToDouble(txtB1.Text);

            double x10 = Convert.ToDouble(txt21.Text);
            double x11 = Convert.ToDouble(txt22.Text);
            double x12 = Convert.ToDouble(txt23.Text);
            double x13 = Convert.ToDouble(txtB2.Text);

            double x20 = Convert.ToDouble(txt31.Text);
            double x21 = Convert.ToDouble(txt32.Text);
            double x22 = Convert.ToDouble(txt33.Text);
            double x23 = Convert.ToDouble(txtB3.Text);

            double x000 = x00, x001 = x01, x002 = x02, x003 = x03;
            double x110 = x10, x111 = x11, x112 = x12, x113 = x13;
            double x220 = x20, x221 = x21, x222 = x22, x223 = x23;

            // calculate deter A 
            double DA = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));

            // calculate deter A1
            // replace the first col with result 
            x00 = x03; x10 = x13; x20 = x23;
            double DA1 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            

            // calculate deter A2
            // replace the second col with result 
            x00 = x000; x10 = x110; x20 = x220;
            x01 = x03; x11 = x13; x21 = x23;
            double DA2 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            

            // calculate deter A3
            // replace the third col with result 
            x01 = x001; x11 = x111; x21 = x221;
            x02 = x03; x12 = x13; x22 = x23;
            double DA3 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            

            //calculate x
            double x1 = DA1 / DA; double x2 = DA2 / DA; double x3 = DA3 / DA;
            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();
            txtX3.Text = x3.ToString();
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
    }
}
