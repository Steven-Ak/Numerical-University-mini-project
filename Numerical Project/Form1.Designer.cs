namespace Numerical_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMethods = new System.Windows.Forms.Panel();
            this.Method = new ReaLTaiizor.Controls.Button();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.btnBisection = new ReaLTaiizor.Controls.Button();
            this.panel5 = new ReaLTaiizor.Controls.Panel();
            this.btnFalse = new ReaLTaiizor.Controls.Button();
            this.panel6 = new ReaLTaiizor.Controls.Panel();
            this.btnSimple = new ReaLTaiizor.Controls.Button();
            this.panel7 = new ReaLTaiizor.Controls.Panel();
            this.btnNewton = new ReaLTaiizor.Controls.Button();
            this.panel8 = new ReaLTaiizor.Controls.Panel();
            this.btnSecant = new ReaLTaiizor.Controls.Button();
            this.menuContainer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMatricies = new ReaLTaiizor.Controls.Panel();
            this.button2 = new ReaLTaiizor.Controls.Button();
            this.panel9 = new ReaLTaiizor.Controls.Panel();
            this.btnGE = new ReaLTaiizor.Controls.Button();
            this.panel11 = new ReaLTaiizor.Controls.Panel();
            this.btnLU = new ReaLTaiizor.Controls.Button();
            this.panel12 = new ReaLTaiizor.Controls.Panel();
            this.btnGJ = new ReaLTaiizor.Controls.Button();
            this.panel13 = new ReaLTaiizor.Controls.Panel();
            this.btnCR = new ReaLTaiizor.Controls.Button();
            this.panel14 = new ReaLTaiizor.Controls.Panel();
            this.btnGEPiv = new ReaLTaiizor.Controls.Button();
            this.panel10 = new ReaLTaiizor.Controls.Panel();
            this.btnLUPiv = new ReaLTaiizor.Controls.Button();
            this.panel15 = new ReaLTaiizor.Controls.Panel();
            this.btnGJPiv = new ReaLTaiizor.Controls.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition2 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.menuContainer1.SuspendLayout();
            this.pnMethods.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuContainer2.SuspendLayout();
            this.pnMatricies.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numerical Analysis";
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = global::Numerical_Project.Properties.Resources.Bulleted_List__2_;
            this.btnHam.Location = new System.Drawing.Point(0, 0);
            this.btnHam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(39, 44);
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1468, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.menuContainer1);
            this.sidebar.Controls.Add(this.menuContainer2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Location = new System.Drawing.Point(0, 44);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(266, 996);
            this.sidebar.TabIndex = 1;
            // 
            // menuContainer1
            // 
            this.menuContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer1.Controls.Add(this.pnMethods);
            this.menuContainer1.Controls.Add(this.panel4);
            this.menuContainer1.Controls.Add(this.panel5);
            this.menuContainer1.Controls.Add(this.panel6);
            this.menuContainer1.Controls.Add(this.panel7);
            this.menuContainer1.Controls.Add(this.panel8);
            this.menuContainer1.Location = new System.Drawing.Point(3, 2);
            this.menuContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuContainer1.Name = "menuContainer1";
            this.menuContainer1.Size = new System.Drawing.Size(271, 62);
            this.menuContainer1.TabIndex = 6;
            // 
            // pnMethods
            // 
            this.pnMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnMethods.Controls.Add(this.Method);
            this.pnMethods.Location = new System.Drawing.Point(3, 2);
            this.pnMethods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMethods.Name = "pnMethods";
            this.pnMethods.Size = new System.Drawing.Size(271, 64);
            this.pnMethods.TabIndex = 2;
            // 
            // Method
            // 
            this.Method.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Method.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Method.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Method.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Method.Image = global::Numerical_Project.Properties.Resources.icons8_mind_map_38__1_;
            this.Method.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Method.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Method.Location = new System.Drawing.Point(0, -41);
            this.Method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Method.Name = "Method";
            this.Method.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Method.Size = new System.Drawing.Size(303, 145);
            this.Method.TabIndex = 3;
            this.Method.Text = "Methods";
            this.Method.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Method.Click += new System.EventHandler(this.Method_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel4.Controls.Add(this.btnBisection);
            this.panel4.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(3, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Size = new System.Drawing.Size(271, 64);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 6;
            this.panel4.Text = "panel4";
            // 
            // btnBisection
            // 
            this.btnBisection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBisection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBisection.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBisection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBisection.Image = null;
            this.btnBisection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBisection.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBisection.Location = new System.Drawing.Point(0, -56);
            this.btnBisection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBisection.Name = "btnBisection";
            this.btnBisection.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBisection.Size = new System.Drawing.Size(285, 178);
            this.btnBisection.TabIndex = 4;
            this.btnBisection.Text = "Bisection";
            this.btnBisection.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBisection.Click += new System.EventHandler(this.btnBisection_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel5.Controls.Add(this.btnFalse);
            this.panel5.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel5.Location = new System.Drawing.Point(3, 138);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Size = new System.Drawing.Size(271, 64);
            this.panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel5.TabIndex = 6;
            this.panel5.Text = "panel5";
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalse.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnFalse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.Image = null;
            this.btnFalse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFalse.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnFalse.Location = new System.Drawing.Point(0, -56);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFalse.Size = new System.Drawing.Size(285, 178);
            this.btnFalse.TabIndex = 4;
            this.btnFalse.Text = "False Position";
            this.btnFalse.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel6.Controls.Add(this.btnSimple);
            this.panel6.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel6.Location = new System.Drawing.Point(3, 206);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Size = new System.Drawing.Size(271, 64);
            this.panel6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel6.TabIndex = 7;
            this.panel6.Text = "panel6";
            // 
            // btnSimple
            // 
            this.btnSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimple.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSimple.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimple.Image = null;
            this.btnSimple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimple.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSimple.Location = new System.Drawing.Point(0, -56);
            this.btnSimple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSimple.Size = new System.Drawing.Size(285, 178);
            this.btnSimple.TabIndex = 4;
            this.btnSimple.Text = "Simple Fixed Point";
            this.btnSimple.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel7.Controls.Add(this.btnNewton);
            this.panel7.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel7.Location = new System.Drawing.Point(3, 274);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Size = new System.Drawing.Size(271, 64);
            this.panel7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel7.TabIndex = 8;
            this.panel7.Text = "panel7";
            // 
            // btnNewton
            // 
            this.btnNewton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnNewton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnNewton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewton.Image = null;
            this.btnNewton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnNewton.Location = new System.Drawing.Point(0, -56);
            this.btnNewton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewton.Size = new System.Drawing.Size(285, 178);
            this.btnNewton.TabIndex = 4;
            this.btnNewton.Text = "Newton";
            this.btnNewton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNewton.Click += new System.EventHandler(this.btnNewton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel8.Controls.Add(this.btnSecant);
            this.panel8.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel8.Location = new System.Drawing.Point(3, 342);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Size = new System.Drawing.Size(271, 64);
            this.panel8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel8.TabIndex = 9;
            this.panel8.Text = "panel8";
            // 
            // btnSecant
            // 
            this.btnSecant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSecant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecant.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSecant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecant.Image = null;
            this.btnSecant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecant.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSecant.Location = new System.Drawing.Point(0, -56);
            this.btnSecant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecant.Name = "btnSecant";
            this.btnSecant.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSecant.Size = new System.Drawing.Size(285, 178);
            this.btnSecant.TabIndex = 4;
            this.btnSecant.Text = "Secant";
            this.btnSecant.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSecant.Click += new System.EventHandler(this.btnSecant_Click);
            // 
            // menuContainer2
            // 
            this.menuContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer2.Controls.Add(this.pnMatricies);
            this.menuContainer2.Controls.Add(this.panel9);
            this.menuContainer2.Controls.Add(this.panel11);
            this.menuContainer2.Controls.Add(this.panel12);
            this.menuContainer2.Controls.Add(this.panel13);
            this.menuContainer2.Controls.Add(this.panel14);
            this.menuContainer2.Controls.Add(this.panel10);
            this.menuContainer2.Controls.Add(this.panel15);
            this.menuContainer2.Location = new System.Drawing.Point(3, 68);
            this.menuContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuContainer2.Name = "menuContainer2";
            this.menuContainer2.Size = new System.Drawing.Size(271, 62);
            this.menuContainer2.TabIndex = 7;
            // 
            // pnMatricies
            // 
            this.pnMatricies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnMatricies.Controls.Add(this.button2);
            this.pnMatricies.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnMatricies.Location = new System.Drawing.Point(3, 2);
            this.pnMatricies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMatricies.Name = "pnMatricies";
            this.pnMatricies.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMatricies.Size = new System.Drawing.Size(271, 64);
            this.pnMatricies.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnMatricies.TabIndex = 5;
            this.pnMatricies.Text = "panel3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Numerical_Project.Properties.Resources.icons8_algebra_38;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Location = new System.Drawing.Point(0, -56);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Size = new System.Drawing.Size(285, 178);
            this.button2.TabIndex = 4;
            this.button2.Text = "Matricies";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel9.Controls.Add(this.btnGE);
            this.panel9.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel9.Location = new System.Drawing.Point(3, 70);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Size = new System.Drawing.Size(271, 64);
            this.panel9.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel9.TabIndex = 6;
            this.panel9.Text = "panel9";
            // 
            // btnGE
            // 
            this.btnGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGE.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGE.Image = null;
            this.btnGE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGE.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGE.Location = new System.Drawing.Point(0, -58);
            this.btnGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGE.Name = "btnGE";
            this.btnGE.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGE.Size = new System.Drawing.Size(271, 178);
            this.btnGE.TabIndex = 4;
            this.btnGE.Text = "Gaussian Elimination";
            this.btnGE.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGE.Click += new System.EventHandler(this.btnGE_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel11.Controls.Add(this.btnLU);
            this.panel11.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel11.Location = new System.Drawing.Point(3, 138);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Size = new System.Drawing.Size(271, 64);
            this.panel11.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel11.TabIndex = 8;
            this.panel11.Text = "panel11";
            // 
            // btnLU
            // 
            this.btnLU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLU.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLU.Image = null;
            this.btnLU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLU.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLU.Location = new System.Drawing.Point(0, -58);
            this.btnLU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLU.Name = "btnLU";
            this.btnLU.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLU.Size = new System.Drawing.Size(271, 178);
            this.btnLU.TabIndex = 4;
            this.btnLU.Text = "LU Decomposition";
            this.btnLU.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel12.Controls.Add(this.btnGJ);
            this.panel12.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel12.Location = new System.Drawing.Point(3, 206);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Size = new System.Drawing.Size(271, 64);
            this.panel12.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel12.TabIndex = 9;
            this.panel12.Text = "panel12";
            // 
            // btnGJ
            // 
            this.btnGJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGJ.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGJ.Image = null;
            this.btnGJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGJ.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJ.Location = new System.Drawing.Point(0, -58);
            this.btnGJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGJ.Name = "btnGJ";
            this.btnGJ.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGJ.Size = new System.Drawing.Size(271, 178);
            this.btnGJ.TabIndex = 4;
            this.btnGJ.Text = "Gauss Jordan";
            this.btnGJ.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGJ.Click += new System.EventHandler(this.btnGJ_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel13.Controls.Add(this.btnCR);
            this.panel13.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel13.Location = new System.Drawing.Point(3, 274);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Size = new System.Drawing.Size(271, 64);
            this.panel13.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel13.TabIndex = 10;
            this.panel13.Text = "panel13";
            // 
            // btnCR
            // 
            this.btnCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCR.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCR.Image = null;
            this.btnCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCR.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCR.Location = new System.Drawing.Point(0, -58);
            this.btnCR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCR.Name = "btnCR";
            this.btnCR.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCR.Size = new System.Drawing.Size(271, 178);
            this.btnCR.TabIndex = 4;
            this.btnCR.Text = "Cramer\'s Rule";
            this.btnCR.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCR.Click += new System.EventHandler(this.btnCR_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel14.Controls.Add(this.btnGEPiv);
            this.panel14.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel14.Location = new System.Drawing.Point(3, 342);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Size = new System.Drawing.Size(271, 64);
            this.panel14.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel14.TabIndex = 8;
            this.panel14.Text = "panel14";
            // 
            // btnGEPiv
            // 
            this.btnGEPiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGEPiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGEPiv.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGEPiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGEPiv.Image = null;
            this.btnGEPiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGEPiv.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGEPiv.Location = new System.Drawing.Point(0, -58);
            this.btnGEPiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGEPiv.Name = "btnGEPiv";
            this.btnGEPiv.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGEPiv.Size = new System.Drawing.Size(271, 178);
            this.btnGEPiv.TabIndex = 4;
            this.btnGEPiv.Text = "Gaussian Elimination with Pivoting";
            this.btnGEPiv.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGEPiv.Click += new System.EventHandler(this.btnGEPiv_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel10.Controls.Add(this.btnLUPiv);
            this.panel10.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel10.Location = new System.Drawing.Point(3, 410);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Size = new System.Drawing.Size(271, 64);
            this.panel10.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel10.TabIndex = 7;
            this.panel10.Text = "panel10";
            // 
            // btnLUPiv
            // 
            this.btnLUPiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLUPiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLUPiv.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLUPiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUPiv.Image = null;
            this.btnLUPiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLUPiv.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLUPiv.Location = new System.Drawing.Point(-3, -58);
            this.btnLUPiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLUPiv.Name = "btnLUPiv";
            this.btnLUPiv.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLUPiv.Size = new System.Drawing.Size(274, 178);
            this.btnLUPiv.TabIndex = 4;
            this.btnLUPiv.Text = "LU Decomposition with Pivoting";
            this.btnLUPiv.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLUPiv.Click += new System.EventHandler(this.btnLUPiv_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel15.Controls.Add(this.btnGJPiv);
            this.panel15.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel15.Location = new System.Drawing.Point(3, 478);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Size = new System.Drawing.Size(271, 64);
            this.panel15.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel15.TabIndex = 8;
            this.panel15.Text = "panel15";
            // 
            // btnGJPiv
            // 
            this.btnGJPiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJPiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGJPiv.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJPiv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGJPiv.Image = null;
            this.btnGJPiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGJPiv.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGJPiv.Location = new System.Drawing.Point(-3, -58);
            this.btnGJPiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGJPiv.Name = "btnGJPiv";
            this.btnGJPiv.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGJPiv.Size = new System.Drawing.Size(274, 178);
            this.btnGJPiv.TabIndex = 4;
            this.btnGJPiv.Text = "Gauss Jordan with Pivoting";
            this.btnGJPiv.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGJPiv.Click += new System.EventHandler(this.btnGJPiv_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 15;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // menuTransition2
            // 
            this.menuTransition2.Interval = 15;
            this.menuTransition2.Tick += new System.EventHandler(this.menuTransition2_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 15;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1040);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.menuContainer1.ResumeLayout(false);
            this.pnMethods.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.menuContainer2.ResumeLayout(false);
            this.pnMatricies.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Panel pnMatricies;
        private System.Windows.Forms.FlowLayoutPanel menuContainer2;
        private ReaLTaiizor.Controls.Panel panel9;
        private ReaLTaiizor.Controls.Button btnGE;
        private ReaLTaiizor.Controls.Panel panel10;
        private ReaLTaiizor.Controls.Button btnLUPiv;
        private ReaLTaiizor.Controls.Panel panel11;
        private ReaLTaiizor.Controls.Button btnLU;
        private ReaLTaiizor.Controls.Panel panel12;
        private ReaLTaiizor.Controls.Button btnGJ;
        private ReaLTaiizor.Controls.Panel panel13;
        private ReaLTaiizor.Controls.Button btnCR;
        private ReaLTaiizor.Controls.Panel panel14;
        private ReaLTaiizor.Controls.Button btnGEPiv;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer menuTransition2;
        private ReaLTaiizor.Controls.Panel panel15;
        private ReaLTaiizor.Controls.Button btnGJPiv;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.FlowLayoutPanel menuContainer1;
        private System.Windows.Forms.Panel pnMethods;
        private ReaLTaiizor.Controls.Button Method;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.Button btnBisection;
        private ReaLTaiizor.Controls.Panel panel5;
        private ReaLTaiizor.Controls.Button btnFalse;
        private ReaLTaiizor.Controls.Panel panel6;
        private ReaLTaiizor.Controls.Button btnSimple;
        private ReaLTaiizor.Controls.Panel panel7;
        private ReaLTaiizor.Controls.Button btnNewton;
        private ReaLTaiizor.Controls.Panel panel8;
        private ReaLTaiizor.Controls.Button btnSecant;
    }
}

