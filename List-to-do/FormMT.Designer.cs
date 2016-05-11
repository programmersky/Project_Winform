namespace List_to_do
{
    partial class FormMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMT));
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoTg = new DevExpress.XtraEditors.SimpleButton();
            this.btnHT = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowTg = new DevExpress.XtraEditors.SimpleButton();
            this.btnX = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Sanseriffic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnTaoTg
            // 
            this.btnTaoTg.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTg.Appearance.Options.UseFont = true;
            this.btnTaoTg.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTg.Image")));
            this.btnTaoTg.Location = new System.Drawing.Point(12, 110);
            this.btnTaoTg.Name = "btnTaoTg";
            this.btnTaoTg.Size = new System.Drawing.Size(341, 69);
            this.btnTaoTg.TabIndex = 1;
            this.btnTaoTg.Text = "Create Target";
            this.btnTaoTg.Click += new System.EventHandler(this.btnTaoTg_Click);
            // 
            // btnHT
            // 
            this.btnHT.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHT.Appearance.Options.UseFont = true;
            this.btnHT.Image = ((System.Drawing.Image)(resources.GetObject("btnHT.Image")));
            this.btnHT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHT.Location = new System.Drawing.Point(12, 316);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(153, 69);
            this.btnHT.TabIndex = 3;
            // 
            // btnShowTg
            // 
            this.btnShowTg.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTg.Appearance.Options.UseFont = true;
            this.btnShowTg.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTg.Image")));
            this.btnShowTg.Location = new System.Drawing.Point(12, 218);
            this.btnShowTg.Name = "btnShowTg";
            this.btnShowTg.Size = new System.Drawing.Size(341, 69);
            this.btnShowTg.TabIndex = 2;
            this.btnShowTg.Text = "Show Targeted";
            this.btnShowTg.Click += new System.EventHandler(this.btnShowTg_Click);
            // 
            // btnX
            // 
            this.btnX.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Appearance.Options.UseFont = true;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(204, 316);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(149, 69);
            this.btnX.TabIndex = 4;
            // 
            // FormMT
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 481);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnShowTg);
            this.Controls.Add(this.btnTaoTg);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TARGET";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnTaoTg;
        private DevExpress.XtraEditors.SimpleButton btnHT;
        private DevExpress.XtraEditors.SimpleButton btnShowTg;
        private DevExpress.XtraEditors.SimpleButton btnX;
    }
}