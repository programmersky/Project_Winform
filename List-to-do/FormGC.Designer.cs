namespace List_to_do
{
    partial class FormGC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGC));
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnX = new DevExpress.XtraEditors.SimpleButton();
            this.btnHT = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowNote = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoNote = new DevExpress.XtraEditors.SimpleButton();
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
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnX
            // 
            this.btnX.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Appearance.Options.UseFont = true;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnX.Location = new System.Drawing.Point(204, 322);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(149, 69);
            this.btnX.TabIndex = 5;
            // 
            // btnHT
            // 
            this.btnHT.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHT.Appearance.Options.UseFont = true;
            this.btnHT.Image = ((System.Drawing.Image)(resources.GetObject("btnHT.Image")));
            this.btnHT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHT.Location = new System.Drawing.Point(12, 322);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(153, 69);
            this.btnHT.TabIndex = 4;
            // 
            // btnShowNote
            // 
            this.btnShowNote.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNote.Appearance.Options.UseFont = true;
            this.btnShowNote.Location = new System.Drawing.Point(12, 222);
            this.btnShowNote.Name = "btnShowNote";
            this.btnShowNote.Size = new System.Drawing.Size(341, 69);
            this.btnShowNote.TabIndex = 3;
            this.btnShowNote.Text = "Show Note";
            // 
            // btnTaoNote
            // 
            this.btnTaoNote.Appearance.Font = new System.Drawing.Font("Sanseriffic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoNote.Appearance.Options.UseFont = true;
            this.btnTaoNote.Location = new System.Drawing.Point(12, 120);
            this.btnTaoNote.Name = "btnTaoNote";
            this.btnTaoNote.Size = new System.Drawing.Size(341, 69);
            this.btnTaoNote.TabIndex = 2;
            this.btnTaoNote.Text = "Create Note";
            // 
            // FormGC
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 481);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnShowNote);
            this.Controls.Add(this.btnTaoNote);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTE";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnX;
        private DevExpress.XtraEditors.SimpleButton btnHT;
        private DevExpress.XtraEditors.SimpleButton btnShowNote;
        private DevExpress.XtraEditors.SimpleButton btnTaoNote;
    }
}