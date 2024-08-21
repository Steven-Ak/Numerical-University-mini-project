namespace Numerical_Project
{
    partial class Bisection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBisection = new System.Windows.Forms.Label();
            this.lblFn = new System.Windows.Forms.Label();
            this.txtFn = new ReaLTaiizor.Controls.NightTextBox();
            this.lblXl = new System.Windows.Forms.Label();
            this.lblXu = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.txtXl = new ReaLTaiizor.Controls.NightTextBox();
            this.txtXu = new ReaLTaiizor.Controls.NightTextBox();
            this.txtError = new ReaLTaiizor.Controls.NightTextBox();
            this.btnCalc = new ReaLTaiizor.Controls.AirButton();
            this.btnClear = new ReaLTaiizor.Controls.AirButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRoot = new ReaLTaiizor.Controls.NightTextBox();
            this.txt_Ferror = new ReaLTaiizor.Controls.NightTextBox();
            this.lbl_Ferror = new System.Windows.Forms.Label();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblBisection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 55);
            this.panel1.TabIndex = 0;
            // 
            // lblBisection
            // 
            this.lblBisection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBisection.AutoSize = true;
            this.lblBisection.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBisection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBisection.Location = new System.Drawing.Point(705, 14);
            this.lblBisection.Name = "lblBisection";
            this.lblBisection.Size = new System.Drawing.Size(118, 32);
            this.lblBisection.TabIndex = 0;
            this.lblBisection.Text = "Bisection";
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.BackColor = System.Drawing.Color.Transparent;
            this.lblFn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(11, 66);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(141, 41);
            this.lblFn.TabIndex = 1;
            this.lblFn.Text = "Function";
            // 
            // txtFn
            // 
            this.txtFn.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtFn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtFn.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtFn.ColorBordersOnEnter = true;
            this.txtFn.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtFn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.ForeColor = System.Drawing.Color.White;
            this.txtFn.Image = null;
            this.txtFn.Location = new System.Drawing.Point(11, 107);
            this.txtFn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFn.MaxLength = 32767;
            this.txtFn.Multiline = false;
            this.txtFn.Name = "txtFn";
            this.txtFn.ReadOnly = false;
            this.txtFn.ShortcutsEnabled = true;
            this.txtFn.ShowBottomBorder = true;
            this.txtFn.ShowTopBorder = true;
            this.txtFn.Size = new System.Drawing.Size(437, 59);
            this.txtFn.TabIndex = 2;
            this.txtFn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFn.UseSystemPasswordChar = false;
            this.txtFn.Watermark = "";
            this.txtFn.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // lblXl
            // 
            this.lblXl.AutoSize = true;
            this.lblXl.BackColor = System.Drawing.Color.Transparent;
            this.lblXl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXl.Location = new System.Drawing.Point(4, 190);
            this.lblXl.Name = "lblXl";
            this.lblXl.Size = new System.Drawing.Size(47, 41);
            this.lblXl.TabIndex = 4;
            this.lblXl.Text = "Xl";
            // 
            // lblXu
            // 
            this.lblXu.AutoSize = true;
            this.lblXu.BackColor = System.Drawing.Color.Transparent;
            this.lblXu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXu.Location = new System.Drawing.Point(4, 278);
            this.lblXu.Name = "lblXu";
            this.lblXu.Size = new System.Drawing.Size(56, 41);
            this.lblXu.TabIndex = 5;
            this.lblXu.Text = "Xu";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(4, 362);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(88, 41);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.BackColor = System.Drawing.Color.Transparent;
            this.lblRoot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.Location = new System.Drawing.Point(480, 485);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(101, 41);
            this.lblRoot.TabIndex = 7;
            this.lblRoot.Text = "Root :";
            // 
            // txtXl
            // 
            this.txtXl.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtXl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXl.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXl.ColorBordersOnEnter = true;
            this.txtXl.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtXl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXl.ForeColor = System.Drawing.Color.White;
            this.txtXl.Image = null;
            this.txtXl.Location = new System.Drawing.Point(100, 190);
            this.txtXl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXl.MaxLength = 32767;
            this.txtXl.Multiline = false;
            this.txtXl.Name = "txtXl";
            this.txtXl.ReadOnly = false;
            this.txtXl.ShortcutsEnabled = true;
            this.txtXl.ShowBottomBorder = true;
            this.txtXl.ShowTopBorder = true;
            this.txtXl.Size = new System.Drawing.Size(117, 59);
            this.txtXl.TabIndex = 8;
            this.txtXl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXl.UseSystemPasswordChar = false;
            this.txtXl.Watermark = "";
            this.txtXl.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // txtXu
            // 
            this.txtXu.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtXu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXu.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXu.ColorBordersOnEnter = true;
            this.txtXu.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtXu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXu.ForeColor = System.Drawing.Color.White;
            this.txtXu.Image = null;
            this.txtXu.Location = new System.Drawing.Point(100, 278);
            this.txtXu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXu.MaxLength = 32767;
            this.txtXu.Multiline = false;
            this.txtXu.Name = "txtXu";
            this.txtXu.ReadOnly = false;
            this.txtXu.ShortcutsEnabled = true;
            this.txtXu.ShowBottomBorder = true;
            this.txtXu.ShowTopBorder = true;
            this.txtXu.Size = new System.Drawing.Size(117, 59);
            this.txtXu.TabIndex = 9;
            this.txtXu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXu.UseSystemPasswordChar = false;
            this.txtXu.Watermark = "";
            this.txtXu.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // txtError
            // 
            this.txtError.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtError.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtError.ColorBordersOnEnter = true;
            this.txtError.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.White;
            this.txtError.Image = null;
            this.txtError.Location = new System.Drawing.Point(100, 362);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = false;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.ShortcutsEnabled = true;
            this.txtError.ShowBottomBorder = true;
            this.txtError.ShowTopBorder = true;
            this.txtError.Size = new System.Drawing.Size(117, 59);
            this.txtError.TabIndex = 10;
            this.txtError.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.UseSystemPasswordChar = false;
            this.txtError.Watermark = "";
            this.txtError.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = null;
            this.btnCalc.Location = new System.Drawing.Point(18, 469);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.NoRounding = false;
            this.btnCalc.Size = new System.Drawing.Size(182, 65);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.Transparent = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(223, 469);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.NoRounding = false;
            this.btnClear.Size = new System.Drawing.Size(182, 65);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Transparent = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.xl,
            this.fxxl,
            this.xu,
            this.fxxu,
            this.xr,
            this.fxxr,
            this.error});
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(626, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(728, 293);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtRoot
            // 
            this.txtRoot.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtRoot.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtRoot.ColorBordersOnEnter = true;
            this.txtRoot.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtRoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoot.ForeColor = System.Drawing.Color.White;
            this.txtRoot.Image = null;
            this.txtRoot.Location = new System.Drawing.Point(636, 482);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoot.MaxLength = 32767;
            this.txtRoot.Multiline = false;
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.ReadOnly = false;
            this.txtRoot.ShortcutsEnabled = true;
            this.txtRoot.ShowBottomBorder = true;
            this.txtRoot.ShowTopBorder = true;
            this.txtRoot.Size = new System.Drawing.Size(117, 59);
            this.txtRoot.TabIndex = 14;
            this.txtRoot.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRoot.UseSystemPasswordChar = false;
            this.txtRoot.Watermark = "";
            this.txtRoot.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // txt_Ferror
            // 
            this.txt_Ferror.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txt_Ferror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txt_Ferror.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txt_Ferror.ColorBordersOnEnter = true;
            this.txt_Ferror.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txt_Ferror.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ferror.ForeColor = System.Drawing.Color.White;
            this.txt_Ferror.Image = null;
            this.txt_Ferror.Location = new System.Drawing.Point(1051, 482);
            this.txt_Ferror.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ferror.MaxLength = 32767;
            this.txt_Ferror.Multiline = false;
            this.txt_Ferror.Name = "txt_Ferror";
            this.txt_Ferror.ReadOnly = false;
            this.txt_Ferror.ShortcutsEnabled = true;
            this.txt_Ferror.ShowBottomBorder = true;
            this.txt_Ferror.ShowTopBorder = true;
            this.txt_Ferror.Size = new System.Drawing.Size(117, 59);
            this.txt_Ferror.TabIndex = 15;
            this.txt_Ferror.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Ferror.UseSystemPasswordChar = false;
            this.txt_Ferror.Watermark = "";
            this.txt_Ferror.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // lbl_Ferror
            // 
            this.lbl_Ferror.AutoSize = true;
            this.lbl_Ferror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ferror.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ferror.Location = new System.Drawing.Point(813, 485);
            this.lbl_Ferror.Name = "lbl_Ferror";
            this.lbl_Ferror.Size = new System.Drawing.Size(180, 41);
            this.lbl_Ferror.TabIndex = 16;
            this.lbl_Ferror.Text = "Final Error :";
            // 
            // iter
            // 
            this.iter.FillWeight = 120F;
            this.iter.HeaderText = "Iter";
            this.iter.MinimumWidth = 8;
            this.iter.Name = "iter";
            this.iter.Width = 60;
            // 
            // xl
            // 
            this.xl.HeaderText = "Xl";
            this.xl.MinimumWidth = 8;
            this.xl.Name = "xl";
            this.xl.Width = 60;
            // 
            // fxxl
            // 
            this.fxxl.HeaderText = "Fx(Xl)";
            this.fxxl.MinimumWidth = 8;
            this.fxxl.Name = "fxxl";
            this.fxxl.Width = 60;
            // 
            // xu
            // 
            this.xu.HeaderText = "Xu";
            this.xu.MinimumWidth = 8;
            this.xu.Name = "xu";
            this.xu.Width = 60;
            // 
            // fxxu
            // 
            this.fxxu.HeaderText = "Fx(Xu)";
            this.fxxu.MinimumWidth = 8;
            this.fxxu.Name = "fxxu";
            this.fxxu.Width = 60;
            // 
            // xr
            // 
            this.xr.HeaderText = "Xr";
            this.xr.MinimumWidth = 8;
            this.xr.Name = "xr";
            this.xr.Width = 60;
            // 
            // fxxr
            // 
            this.fxxr.HeaderText = "Fx(Xr)";
            this.fxxr.MinimumWidth = 8;
            this.fxxr.Name = "fxxr";
            this.fxxr.Width = 60;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 8;
            this.error.Name = "error";
            this.error.Width = 60;
            // 
            // Bisection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1512, 832);
            this.Controls.Add(this.lbl_Ferror);
            this.Controls.Add(this.txt_Ferror);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtXu);
            this.Controls.Add(this.txtXl);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblXu);
            this.Controls.Add(this.lblXl);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblFn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bisection";
            this.Text = "Bisection";
            this.Load += new System.EventHandler(this.Bisection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBisection;
        private System.Windows.Forms.Label lblFn;
        private ReaLTaiizor.Controls.NightTextBox txtFn;
        private System.Windows.Forms.Label lblXl;
        private System.Windows.Forms.Label lblXu;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRoot;
        private ReaLTaiizor.Controls.NightTextBox txtXl;
        private ReaLTaiizor.Controls.NightTextBox txtXu;
        private ReaLTaiizor.Controls.NightTextBox txtError;
        private ReaLTaiizor.Controls.AirButton btnCalc;
        private ReaLTaiizor.Controls.AirButton btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.NightTextBox txtRoot;
        private ReaLTaiizor.Controls.NightTextBox txt_Ferror;
        private System.Windows.Forms.Label lbl_Ferror;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xl;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn xu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}