namespace Numerical_Project
{
    partial class Newton
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
            this.lblNewton = new System.Windows.Forms.Label();
            this.txtFn = new ReaLTaiizor.Controls.NightTextBox();
            this.lblFn = new System.Windows.Forms.Label();
            this.lblFdash = new System.Windows.Forms.Label();
            this.txtFdash = new ReaLTaiizor.Controls.NightTextBox();
            this.btnCalc = new ReaLTaiizor.Controls.AirButton();
            this.btnClear = new ReaLTaiizor.Controls.AirButton();
            this.lblRoot = new System.Windows.Forms.Label();
            this.txtRoot = new ReaLTaiizor.Controls.NightTextBox();
            this.txt_Ferror = new ReaLTaiizor.Controls.NightTextBox();
            this.lbl_Ferror = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxdashxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtXi = new ReaLTaiizor.Controls.NightTextBox();
            this.txtError = new ReaLTaiizor.Controls.NightTextBox();
            this.x0 = new System.Windows.Forms.Label();
            this.eerror = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblNewton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 69);
            this.panel1.TabIndex = 1;
            // 
            // lblNewton
            // 
            this.lblNewton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewton.AutoSize = true;
            this.lblNewton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewton.Location = new System.Drawing.Point(793, 18);
            this.lblNewton.Name = "lblNewton";
            this.lblNewton.Size = new System.Drawing.Size(121, 38);
            this.lblNewton.TabIndex = 0;
            this.lblNewton.Text = "Newton";
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
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.BackColor = System.Drawing.Color.Transparent;
            this.lblFn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(12, 82);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(89, 48);
            this.lblFn.TabIndex = 4;
            this.lblFn.Text = "F(X)";
            // 
            // lblFdash
            // 
            this.lblFdash.AutoSize = true;
            this.lblFdash.BackColor = System.Drawing.Color.Transparent;
            this.lblFdash.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdash.Location = new System.Drawing.Point(12, 238);
            this.lblFdash.Name = "lblFdash";
            this.lblFdash.Size = new System.Drawing.Size(100, 48);
            this.lblFdash.TabIndex = 5;
            this.lblFdash.Text = "F\'(X)";
            // 
            // txtFdash
            // 
            this.txtFdash.ActiveBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtFdash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtFdash.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.txtFdash.ColorBordersOnEnter = true;
            this.txtFdash.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtFdash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFdash.ForeColor = System.Drawing.Color.White;
            this.txtFdash.Image = null;
            this.txtFdash.Location = new System.Drawing.Point(20, 288);
            this.txtFdash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFdash.MaxLength = 32767;
            this.txtFdash.Multiline = false;
            this.txtFdash.Name = "txtFdash";
            this.txtFdash.ReadOnly = false;
            this.txtFdash.ShortcutsEnabled = true;
            this.txtFdash.ShowBottomBorder = true;
            this.txtFdash.ShowTopBorder = true;
            this.txtFdash.Size = new System.Drawing.Size(484, 64);
            this.txtFdash.TabIndex = 9;
            this.txtFdash.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFdash.UseSystemPasswordChar = false;
            this.txtFdash.Watermark = "";
            this.txtFdash.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = null;
            this.btnCalc.Location = new System.Drawing.Point(12, 677);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.NoRounding = false;
            this.btnCalc.Size = new System.Drawing.Size(205, 81);
            this.btnCalc.TabIndex = 12;
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
            this.btnClear.Location = new System.Drawing.Point(260, 677);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.NoRounding = false;
            this.btnClear.Size = new System.Drawing.Size(205, 81);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Transparent = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.BackColor = System.Drawing.Color.Transparent;
            this.lblRoot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.Location = new System.Drawing.Point(540, 606);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(121, 48);
            this.lblRoot.TabIndex = 14;
            this.lblRoot.Text = "Root :";
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
            this.txtRoot.TabIndex = 15;
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
            this.txt_Ferror.TabIndex = 16;
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
            this.lbl_Ferror.Location = new System.Drawing.Point(915, 606);
            this.lbl_Ferror.Name = "lbl_Ferror";
            this.lbl_Ferror.Size = new System.Drawing.Size(213, 48);
            this.lbl_Ferror.TabIndex = 17;
            this.lbl_Ferror.Text = "Final Error :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.xi,
            this.fxxi,
            this.fxdashxi,
            this.error});
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(704, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 366);
            this.dataGridView1.TabIndex = 18;
            // 
            // iter
            // 
            this.iter.FillWeight = 120F;
            this.iter.HeaderText = "Iter";
            this.iter.MinimumWidth = 8;
            this.iter.Name = "iter";
            this.iter.Width = 60;
            // 
            // xi
            // 
            this.xi.FillWeight = 110F;
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
            // fxdashxi
            // 
            this.fxdashxi.HeaderText = "Fx\'(Xi)";
            this.fxdashxi.MinimumWidth = 8;
            this.fxdashxi.Name = "fxdashxi";
            this.fxdashxi.Width = 60;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.MinimumWidth = 8;
            this.error.Name = "error";
            this.error.Width = 60;
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
            this.txtXi.Location = new System.Drawing.Point(121, 420);
            this.txtXi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXi.MaxLength = 32767;
            this.txtXi.Multiline = false;
            this.txtXi.Name = "txtXi";
            this.txtXi.ReadOnly = false;
            this.txtXi.ShortcutsEnabled = true;
            this.txtXi.ShowBottomBorder = true;
            this.txtXi.ShowTopBorder = true;
            this.txtXi.Size = new System.Drawing.Size(132, 64);
            this.txtXi.TabIndex = 19;
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
            this.txtError.Location = new System.Drawing.Point(121, 536);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError.MaxLength = 32767;
            this.txtError.Multiline = false;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = false;
            this.txtError.ShortcutsEnabled = true;
            this.txtError.ShowBottomBorder = true;
            this.txtError.ShowTopBorder = true;
            this.txtError.Size = new System.Drawing.Size(132, 64);
            this.txtError.TabIndex = 20;
            this.txtError.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtError.UseSystemPasswordChar = false;
            this.txtError.Watermark = "";
            this.txtError.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // x0
            // 
            this.x0.AutoSize = true;
            this.x0.BackColor = System.Drawing.Color.Transparent;
            this.x0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0.Location = new System.Drawing.Point(12, 420);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(54, 48);
            this.x0.TabIndex = 21;
            this.x0.Text = "Xi";
            // 
            // eerror
            // 
            this.eerror.AutoSize = true;
            this.eerror.BackColor = System.Drawing.Color.Transparent;
            this.eerror.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eerror.Location = new System.Drawing.Point(12, 536);
            this.eerror.Name = "eerror";
            this.eerror.Size = new System.Drawing.Size(103, 48);
            this.eerror.TabIndex = 22;
            this.eerror.Text = "Error";
            // 
            // Newton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1701, 1040);
            this.Controls.Add(this.eerror);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Ferror);
            this.Controls.Add(this.txt_Ferror);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtFdash);
            this.Controls.Add(this.lblFdash);
            this.Controls.Add(this.lblFn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Newton";
            this.Text = "Newton";
            this.Load += new System.EventHandler(this.Newton_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewton;
        private ReaLTaiizor.Controls.NightTextBox txtFn;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblFdash;
        private ReaLTaiizor.Controls.NightTextBox txtFdash;
        private ReaLTaiizor.Controls.AirButton btnCalc;
        private ReaLTaiizor.Controls.AirButton btnClear;
        private System.Windows.Forms.Label lblRoot;
        private ReaLTaiizor.Controls.NightTextBox txtRoot;
        private ReaLTaiizor.Controls.NightTextBox txt_Ferror;
        private System.Windows.Forms.Label lbl_Ferror;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxdashxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private ReaLTaiizor.Controls.NightTextBox txtXi;
        private ReaLTaiizor.Controls.NightTextBox txtError;
        private System.Windows.Forms.Label x0;
        private System.Windows.Forms.Label eerror;
    }
}