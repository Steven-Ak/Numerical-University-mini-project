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
    public partial class Form1 : Form
    {
        Methods methods;
        Bisection bisection;
        FalsePostion falsePostion;
        SimpleFixedP simpleFixed;
        Newton newton;
        Secant secant;

        Matricies matricies;
        GE ge;
        LU lu;
        GJ gj;
        CR cr;
        GEPivoting gePivoting;
        LUPivoting luPivoting;
        GJPivoting gjPivoting;
        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        bool menuExpand2 = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer1.Height += 10;
                if(menuContainer1.Height >= 271)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer1.Height -= 10;
                if (menuContainer1.Height <= 50)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
                {
                    
                }
            }

          
        }

        private void Method_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            if (methods == null)
            {
                methods = new Methods();
                methods.FormClosed += Methods_FormClosed;
                methods.MdiParent = this;
                methods.Dock = DockStyle.Fill;
                methods.Show();
            }
            else
            {
                methods.Activate();
            }
        }

        private void Methods_FormClosed(object sender, FormClosedEventArgs e)
        {
            methods = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
            if (matricies == null)
            {
                matricies = new Matricies();
                matricies.FormClosed += Matricies_FormClosed;
                matricies.MdiParent = this;
                matricies.Dock = DockStyle.Fill;
                matricies.Show();
            }
            else
            {
                matricies.Activate();
            }
        }

        private void Matricies_FormClosed(object sender, FormClosedEventArgs e)
        {
            matricies = null;
        }

        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 354)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 50)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
                {

                }
            }
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 53)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 170)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBisection_Click(object sender, EventArgs e)
        {
            if (bisection == null)
            {
                bisection = new Bisection();
                bisection.FormClosed += Bisection_FormClosed;
                bisection.MdiParent = this;
                bisection.Dock = DockStyle.Fill;
                bisection.Show();
            }
            else
            {
                bisection.Activate();
            }
        }

        private void Bisection_FormClosed(object sender, FormClosedEventArgs e)
        {
            bisection = null;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            if (falsePostion == null)
            {
                falsePostion = new FalsePostion();
                falsePostion.FormClosed += FalsePostion_FormClosed;
                falsePostion.MdiParent = this;
                falsePostion.Dock = DockStyle.Fill;
                falsePostion.Show();
            }
            else
            {
                falsePostion.Activate();
            }
        }

        private void FalsePostion_FormClosed(object sender, FormClosedEventArgs e)
        {
            falsePostion = null;
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            if (simpleFixed == null)
            {
                simpleFixed = new SimpleFixedP();
                simpleFixed.FormClosed += SimpleFixed_FormClosed;
                simpleFixed.MdiParent = this;
                simpleFixed.Dock = DockStyle.Fill;
                simpleFixed.Show();
            }
            else
            {
                simpleFixed.Activate();
            }
        }

        private void SimpleFixed_FormClosed(object sender, FormClosedEventArgs e)
        {
            simpleFixed = null;
        }

        private void btnNewton_Click(object sender, EventArgs e)
        {
            if (newton == null)
            {
                newton = new Newton();
                newton.FormClosed += Newton_FormClosed;
                newton.MdiParent = this;
                newton.Dock = DockStyle.Fill;
                newton.Show();
            }
            else
            {
                newton.Activate();
            }
        }

        private void Newton_FormClosed(object sender, FormClosedEventArgs e)
        {
            newton = null;
        }

        private void btnSecant_Click(object sender, EventArgs e)
        {
            if (secant == null)
            {
                secant = new Secant();
                secant.FormClosed += Secant_FormClosed;
                secant.MdiParent = this;
                secant.Dock = DockStyle.Fill;
                secant.Show();
            }
            else
            {
                secant.Activate();
            }
        }

        private void Secant_FormClosed(object sender, FormClosedEventArgs e)
        {
            secant = null;
        }

        private void btnGE_Click(object sender, EventArgs e)
        {
            if (ge == null)
            {
                ge = new GE();
                ge.FormClosed += Ge_FormClosed;
                ge.MdiParent = this;
                ge.Dock = DockStyle.Fill;
                ge.Show();
            }
            else
            {
                ge.Activate();
            }
        }

        private void Ge_FormClosed(object sender, FormClosedEventArgs e)
        {
            ge = null;
        }

        private void btnLU_Click(object sender, EventArgs e)
        {
            if (lu == null)
            {
                lu = new LU();
                lu.FormClosed += Lu_FormClosed;
                lu.MdiParent = this;
                lu.Dock = DockStyle.Fill;
                lu.Show();
            }
            else
            {
                lu.Activate();
            }
        }

        private void Lu_FormClosed(object sender, FormClosedEventArgs e)
        {
            lu = null;
        }

        private void btnGJ_Click(object sender, EventArgs e)
        {
            if (gj == null)
            {
                gj = new GJ();
                gj.FormClosed += Gj_FormClosed;
                gj.MdiParent = this;
                gj.Dock = DockStyle.Fill;
                gj.Show();
            }
            else
            {
                gj.Activate();
            }
        }

        private void Gj_FormClosed(object sender, FormClosedEventArgs e)
        {
            gj = null;
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            if (cr == null)
            {
                cr = new CR();
                cr.FormClosed += Cr_FormClosed;
                cr.MdiParent = this;
                cr.Dock = DockStyle.Fill;
                cr.Show();
            }
            else
            {
                cr.Activate();
            }
        }

        private void Cr_FormClosed(object sender, FormClosedEventArgs e)
        {
            cr = null;
        }

        private void btnGEPiv_Click(object sender, EventArgs e)
        {
            if (gePivoting == null)
            {
                gePivoting = new GEPivoting();
                gePivoting.FormClosed += GePivoting_FormClosed;
                gePivoting.MdiParent = this;
                gePivoting.Dock = DockStyle.Fill;
                gePivoting.Show();
            }
            else
            {
                gePivoting.Activate();
            }
        }

        private void GePivoting_FormClosed(object sender, FormClosedEventArgs e)
        {
            gePivoting = null;
        }

        private void btnLUPiv_Click(object sender, EventArgs e)
        {
            if (luPivoting == null)
            {
                luPivoting = new LUPivoting();
                luPivoting.FormClosed += LuPivoting_FormClosed; ;
                luPivoting.MdiParent = this;
                luPivoting.Dock = DockStyle.Fill;
                luPivoting.Show();
            }
            else
            {
                luPivoting.Activate();
            }
        }

        private void LuPivoting_FormClosed(object sender, FormClosedEventArgs e)
        {
            luPivoting = null;
        }

        private void btnGJPiv_Click(object sender, EventArgs e)
        {
            if (gjPivoting == null)
            {
                gjPivoting = new GJPivoting();
                gjPivoting.FormClosed += GjPivoting_FormClosed; ;
                gjPivoting.MdiParent = this;
                gjPivoting.Dock = DockStyle.Fill;
                gjPivoting.Show();
            }
            else
            {
                gjPivoting.Activate();
            }
        }

        private void GjPivoting_FormClosed(object sender, FormClosedEventArgs e)
        {
            gjPivoting = null;
        }
    }
}
