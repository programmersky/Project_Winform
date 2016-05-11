namespace List_to_do
{
    partial class FormTaoTg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTg));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNDMT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(312, 92);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To Build Up Target,\r\n  To Build Up A Life";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 178);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(16, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Target";
            // 
            // txtNDMT
            // 
            this.txtNDMT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDMT.Location = new System.Drawing.Point(71, 131);
            this.txtNDMT.Multiline = true;
            this.txtNDMT.Name = "txtNDMT";
            this.txtNDMT.Size = new System.Drawing.Size(235, 193);
            this.txtNDMT.TabIndex = 4;
            this.txtNDMT.Click += new System.EventHandler(this.txtNDMT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time\r\n";
            // 
            // dtptime
            // 
            this.dtptime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptime.Location = new System.Drawing.Point(16, 356);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(321, 29);
            this.dtptime.TabIndex = 7;
            // 
            // btnTao
            // 
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.Location = new System.Drawing.Point(202, 424);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(135, 45);
            this.btnTao.TabIndex = 8;
            this.btnTao.Text = "Create";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(25, 424);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 45);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Cancel";
            // 
            // FormTaoTg
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 481);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNDMT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTaoTg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Target";
            this.Load += new System.EventHandler(this.FormTaoTg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtNDMT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptime;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}