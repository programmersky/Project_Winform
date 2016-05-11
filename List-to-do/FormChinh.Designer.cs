namespace List_to_do
{
    partial class FormChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnMT = new DevExpress.XtraEditors.SimpleButton();
            this.btnGC = new DevExpress.XtraEditors.SimpleButton();
            this.btnTGB = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back\r\n";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMT
            // 
            this.btnMT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMT.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnMT.Appearance.Options.UseFont = true;
            this.btnMT.Appearance.Options.UseForeColor = true;
            this.btnMT.Image = ((System.Drawing.Image)(resources.GetObject("btnMT.Image")));
            this.btnMT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMT.Location = new System.Drawing.Point(12, 125);
            this.btnMT.Name = "btnMT";
            this.btnMT.Size = new System.Drawing.Size(333, 80);
            this.btnMT.TabIndex = 1;
            this.btnMT.Text = "TarGet";
            this.btnMT.Click += new System.EventHandler(this.btnMT_Click);
            // 
            // btnGC
            // 
            this.btnGC.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGC.Appearance.Options.UseFont = true;
            this.btnGC.Image = ((System.Drawing.Image)(resources.GetObject("btnGC.Image")));
            this.btnGC.Location = new System.Drawing.Point(12, 237);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(333, 75);
            this.btnGC.TabIndex = 2;
            this.btnGC.Text = "Note";
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnTGB
            // 
            this.btnTGB.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTGB.Appearance.Options.UseFont = true;
            this.btnTGB.Image = ((System.Drawing.Image)(resources.GetObject("btnTGB.Image")));
            this.btnTGB.Location = new System.Drawing.Point(12, 347);
            this.btnTGB.Name = "btnTGB";
            this.btnTGB.Size = new System.Drawing.Size(333, 75);
            this.btnTGB.TabIndex = 3;
            this.btnTGB.Text = "TimeTable";
            this.btnTGB.Click += new System.EventHandler(this.btnTGB_Click);
            // 
            // FormChinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 481);
            this.Controls.Add(this.btnTGB);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnMT);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnMT;
        private DevExpress.XtraEditors.SimpleButton btnGC;
        private DevExpress.XtraEditors.SimpleButton btnTGB;
    }
}