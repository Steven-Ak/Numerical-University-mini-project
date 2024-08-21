namespace Numerical_Project
{
    partial class Secant
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
            this.lblSecant = new System.Windows.Forms.Label();
            this.lblFn = new System.Windows.Forms.Label();
            this.txtFn = new ReaLTaiizor.Controls.NightTextBox();
            this.txtXiminus1 = new ReaLTaiizor.Controls.NightTextBox();
            this.lblXiminus1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximinus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxximinus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalc = new ReaLTaiizor.Controls.AirButton();
            this.btnClear = new ReaLTaiizor.Controls.AirButton();
            this.txtXi = new ReaLTaiizor.Controls.NightTextBox();
            this.txtError = new ReaLTaiizor.Controls.NightTextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.lbl_Ferror = new System.Windows.Forms.Label();
            this.txtRoot = new ReaLTaiizor.Controls.NightTextBox();
            this.txt_Ferror = new ReaLTaiizor.Controls.NightTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblSecant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 69);
            this.panel1.TabIndex = 1;
            // 
            // lblSecant
            // 
            this.lblSecant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecant.AutoSize = true;
            this.lblSecant.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecant.Location = new System.Drawing.Point(793, 18);
            this.lblSecant.Name = "lblSecant";
            this.lblSecant.Size = new System.Drawing.Size(104, 38);
            this.lblSecant.TabIndex = 0;
            this.lblSecant.Text = "Secant";
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.BackColor = System.Drawing.Color.Transparent;
            this.lblFn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(12, 82);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(168, 48);
            this.lblFn.TabIndex = 2;
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
            this.txtFn.Location = new System.Drawing.Point(12, 134);
            this.txtFn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFn.MaxLength = 32767;
            this.txtFn.Multiline = false;
            this.txtFn.Name = "txtFn";
            this.txtFn.ReadOnly = false;
            this.txtFn.ShortcutsEnabled = true;
            this.txtFn.ShowBottomBorder = true;
            this.txtFn.ShowTopBorder = true;
            this.txtFn.Size = new System.Drawing.Size(492, 64);
            this.txtFn.TabIndex = 3;
            this.txtFn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFn.UseSystemPasswordChar = false;
            this.txtFn.Watermark = "";
            this.txtFn.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // txtXiminus1
            // 
            this.txtXiminus1.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtXiminus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXiminus1.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXiminus1.ColorBordersOnEnter = true;
            this.txtXiminus1.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtXiminus1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXiminus1.ForeColor = System.Drawing.Color.White;
            this.txtXiminus1.Image = null;
            this.txtXiminus1.Location = new System.Drawing.Point(112, 238);
            this.txtXiminus1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXiminus1.MaxLength = 32767;
            this.txtXiminus1.Multiline = false;
            this.txtXiminus1.Name = "txtXiminus1";
            this.txtXiminus1.ReadOnly = false;
            this.txtXiminus1.ShortcutsEnabled = true;
            this.txtXiminus1.ShowBottomBorder = true;
            this.txtXiminus1.ShowTopBorder = true;
            this.txtXiminus1.Size = new System.Drawing.Size(132, 64);
            this.txtXiminus1.TabIndex = 9;
            this.txtXiminus1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXiminus1.UseSystemPasswordChar = false;
            this.txtXiminus1.Watermark = "";
            this.txtXiminus1.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // lblXiminus1
            // 
            this.lblXiminus1.AutoSize = true;
            this.lblXiminus1.BackColor = System.Drawing.Color.Transparent;
            this.lblXiminus1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXiminus1.Location = new System.Drawing.Point(4, 238);
            this.lblXiminus1.Name = "lblXiminus1";
            this.lblXiminus1.Size = new System.Drawing.Size(90, 48);
            this.lblXiminus1.TabIndex = 10;
            this.lblXiminus1.Text = "Xi-1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.ximinus1,
            this.fxximinus1,
            this.xi,
            this.fxxi,
            this.error});
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(704, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 366);
            this.dataGridView1.TabIndex = 14;
            // 
            // iter
            // 
            this.iter.FillWeight = 120F;
            this.iter.HeaderText = "Iter";
            this.iter.MinimumWidth = 8;
            this.iter.Name = "iter";
            this.iter.Width = 60;
            // 
            // ximinus1
            // 
            this.ximinus1.HeaderText = "Xi-1";
            this.ximinus1.MinimumWidth = 8;
            this.ximinus1.Name = "ximinus1";
            this.ximinus1.Width = 60;
            // 
            // fxximinus1
            // 
            this.fxximinus1.FillWeight = 110F;
            this.fxximinus1.HeaderText = "Fx(Xi-1)";
            this.fxximinus1.MinimumWidth = 8;
            this.fxximinus1.Name = "fxximinus1";
            this.fxximinus1.Width = 60;
            // 
            // xi
            // 
            this.xi.HeaderText = "Xi";
            this.xi.MinimumWidth = 8;
            this.xi.Name = "xi";
            this.xi.Width = 60;
            // 
            // fxxi
            // 
            this.fxxi.HeaderText = "Fx(Xi)";
            this.fxxi.MinimumWidth = 8;
            this.fxxi.Name = "fxxi";
            this.fxxi.Width = 60;
            // 
            // error
            // 
            this.error.FillWeight = 110F;
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 8;
            this.error.Name = "error";
            this.error.Width = 60;
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = null;
            this.btnCalc.Location = new System.Drawing.Point(20, 586);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.NoRounding = false;
            this.btnCalc.Size = new System.Drawing.Size(205, 81);
            this.btnCalc.TabIndex = 15;
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
            this.btnClear.Location = new System.Drawing.Point(251, 586);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.NoRounding = false;
            this.btnClear.Size = new System.Drawing.Size(205, 81);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.Transparent = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtXi
            // 
            this.txtXi.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtXi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXi.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtXi.ColorBordersOnEnter = true;
            this.txtXi.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtXi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXi.ForeColor = System.Drawing.Color.White;
            this.txtXi.Image = null;
            this.txtXi.Location = new System.Drawing.Point(112, 348);
            this.txtXi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXi.MaxLength = 32767;
            this.txtXi.Multiline = false;
            this.txtXi.Name = "txtXi";
            this.txtXi.ReadOnly = false;
            this.txtXi.ShortcutsEnabled = true;
            this.txtXi.ShowBottomBorder = true;
            this.txtXi.ShowTopBorder = true;
            this.txtXi.Size = new System.Drawing.Size(132, 64);
            this.txtXi.TabIndex = 17;
            this.txtXi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXi.UseSystemPasswordChar = false;
            this.txtXi.Watermark = "";
            this.txtXi.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
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
            this.txtError.Location = new System.Drawing.Point(112, 452);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = false;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.ShortcutsEnabled = true;
            this.txtError.ShowBottomBorder = true;
            this.txtError.ShowTopBorder = true;
            this.txtError.Size = new System.Drawing.Size(132, 64);
            this.txtError.TabIndex = 18;
            this.txtError.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.UseSystemPasswordChar = false;
            this.txtError.Watermark = "";
            this.txtError.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.BackColor = System.Drawing.Color.Transparent;
            this.lblXi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXi.Location = new System.Drawing.Point(4, 348);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(54, 48);
            this.lblXi.TabIndex = 19;
            this.lblXi.Text = "Xi";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(4, 452);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(103, 48);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Error";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.BackColor = System.Drawing.Color.Transparent;
            this.lblRoot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.Location = new System.Drawing.Point(540, 606);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(121, 48);
            this.lblRoot.TabIndex = 21;
            this.lblRoot.Text = "Root :";
            // 
            // lbl_Ferror
            // 
            this.lbl_Ferror.AutoSize = true;
            this.lbl_Ferror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ferror.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ferror.Location = new System.Drawing.Point(915, 606);
            this.lbl_Ferror.Name = "lbl_Ferror";
            this.lbl_Ferror.Size = new System.Drawing.Size(213, 48);
            this.lbl_Ferror.TabIndex = 22;
            this.lbl_Ferror.Text = "Final Error :";
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
            this.txtRoot.Location = new System.Drawing.Point(716, 602);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoot.MaxLength = 32767;
            this.txtRoot.Multiline = false;
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.ReadOnly = false;
            this.txtRoot.ShortcutsEnabled = true;
            this.txtRoot.ShowBottomBorder = true;
            this.txtRoot.ShowTopBorder = true;
            this.txtRoot.Size = new System.Drawing.Size(132, 64);
            this.txtRoot.TabIndex = 23;
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
            this.txt_Ferror.Location = new System.Drawing.Point(1182, 602);
            this.txt_Ferror.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ferror.MaxLength = 32767;
            this.txt_Ferror.Multiline = false;
            this.txt_Ferror.Name = "txt_Ferror";
            this.txt_Ferror.ReadOnly = false;
            this.txt_Ferror.ShortcutsEnabled = true;
            this.txt_Ferror.ShowBottomBorder = true;
            this.txt_Ferror.ShowTopBorder = true;
            this.txt_Ferror.Size = new System.Drawing.Size(132, 64);
            this.txt_Ferror.TabIndex = 24;
            this.txt_Ferror.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Ferror.UseSystemPasswordChar = false;
            this.txt_Ferror.Watermark = "";
            this.txt_Ferror.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // Secant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1701, 1040);
            this.Controls.Add(this.txt_Ferror);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.lbl_Ferror);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblXiminus1);
            this.Controls.Add(this.txtXiminus1);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblFn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Secant";
            this.Text = "Secant";
            this.Load += new System.EventHandler(this.Secant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSecant;
        private System.Windows.Forms.Label lblFn;
        private ReaLTaiizor.Controls.NightTextBox txtFn;
        private ReaLTaiizor.Controls.NightTextBox txtXiminus1;
        private System.Windows.Forms.Label lblXiminus1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.AirButton btnCalc;
        private ReaLTaiizor.Controls.AirButton btnClear;
        private ReaLTaiizor.Controls.NightTextBox txtXi;
        private ReaLTaiizor.Controls.NightTextBox txtError;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Label lbl_Ferror;
        private ReaLTaiizor.Controls.NightTextBox txtRoot;
        private ReaLTaiizor.Controls.NightTextBox txt_Ferror;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximinus1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxximinus1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}