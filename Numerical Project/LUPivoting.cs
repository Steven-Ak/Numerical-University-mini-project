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
    public partial class LUPivoting : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;

        public LUPivoting()
        {
            InitializeComponent();
        }

        private void LUPivoting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x11 = Convert.ToDouble(txt11.Text);
            double x12 = Convert.ToDouble(txt12.Text);
            double x13 = Convert.ToDouble(txt13.Text);
            double xB1 = Convert.ToDouble(txtB1.Text);



            double x21 = Convert.ToDouble(txt21.Text);
            double x22 = Convert.ToDouble(txt22.Text);
            double x23 = Convert.ToDouble(txt23.Text);
            double xB2 = Convert.ToDouble(txtB2.Text);

            double x31 = Convert.ToDouble(txt31.Text);
            double x32 = Convert.ToDouble(txt32.Text);
            double x33 = Convert.ToDouble(txt33.Text);
            double xB3 = Convert.ToDouble(txtB3.Text);



            double b1 = xB1; double b2 = xB2; double b3 = xB3;


            m21 = x21 / x11;
            m31 = x31 / x11;

            x21 = x21 - (m21 * x11); x22 = x22 - (m21 * x12);
            x23 = x23 - (m21 * x13); xB2 = xB2 - (m21 * xB1);

            x21 = Math.Round(x21, 3);
            x23 = Math.Round(x23, 3);

            x31 = x31 - (m31 * x11); x32 = x32 - (m31 * x12);
            x33 = x33 - (m31 * x13); xB3 = xB3 - (m31 * xB1);

            x31 = Math.Round(x31, 3);
            x33 = Math.Round(x33, 3);

            m32 = x32 / x22;
            m32 = Math.Round(m32, 3);

            x31 = x31 - (m32 * x21); x32 = x32 - (m32 * x22);
            x33 = x33 - (m32 * x23); xB3 = xB3 - (m32 * xB2);


            double u11 = x11; double u12 = x12; double u13 = x13;
            double u21 = x21; double u22 = x22; double u23 = x23;
            double u31 = x31; double u32 = x32; double u33 = x33;


            double l11 = 1; double l12 = 0; double l13 = 0;
            double l21 = m21; double l22 = 1; double l23 = 0;
            double l31 = m31; double l32 = m32; double l33 = 1;


            double c1 = b1 / l11;
            double c2 = (b2 - (l21) * c1) / l22;
            double c3 = (b3 - ((l31 * c1) + (l32 * c2))) / l33;
            c1 = Math.Round(c1, 3);
            c2 = Math.Round(c2, 3);
            c3 = Math.Round(c3, 3);


            txtC1.Text = c1.ToString();
            txtC2.Text = c2.ToString();
            txtC3.Text = c3.ToString();

            double x3 = c3 / u33;
            double x2 = (c2 - (u23 * x3)) / u22;
            double x1 = (c1 - (u12 * x2) - (u13 * x3)) / u11;
            x1 = Math.Round(x1, 3);
            x2 = Math.Round(x2, 3);
            x3 = Math.Round(x3, 3);




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
