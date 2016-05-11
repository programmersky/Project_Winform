namespace Game_FixBuG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pBhinhnen = new System.Windows.Forms.PictureBox();
            this.btnS = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnLH = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBhinhnen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBhinhnen
            // 
            this.pBhinhnen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBhinhnen.Image = ((System.Drawing.Image)(resources.GetObject("pBhinhnen.Image")));
            this.pBhinhnen.Location = new System.Drawing.Point(0, 0);
            this.pBhinhnen.Name = "pBhinhnen";
            this.pBhinhnen.Size = new System.Drawing.Size(605, 414);
            this.pBhinhnen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBhinhnen.TabIndex = 0;
            this.pBhinhnen.TabStop = false;
            this.pBhinhnen.Click += new System.EventHandler(this.pBhinhnen_Click);
            // 
            // btnS
            // 
            this.btnS.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Appearance.Options.UseFont = true;
            this.btnS.Image = ((System.Drawing.Image)(resources.GetObject("btnS.Image")));
            this.btnS.Location = new System.Drawing.Point(182, 228);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(221, 55);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "</Start Debug>";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Những chương trình đã bị phá hủy bởi rất nhiều BUG.";
            // 
            // btnHD
            // 
            this.btnHD.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.Appearance.Options.UseFont = true;
            this.btnHD.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.Image")));
            this.btnHD.Location = new System.Drawing.Point(316, 338);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(221, 54);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "Hướng Dẫn";
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnLH
            // 
            this.btnLH.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLH.Appearance.Options.UseFont = true;
            this.btnLH.Image = ((System.Drawing.Image)(resources.GetObject("btnLH.Image")));
            this.btnLH.Location = new System.Drawing.Point(30, 338);
            this.btnLH.Name = "btnLH";
            this.btnLH.Size = new System.Drawing.Size(221, 54);
            this.btnLH.TabIndex = 3;
            this.btnLH.Text = "Liên Hệ";
            this.btnLH.Click += new System.EventHandler(this.btnLH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "  Chúng thật sự là nỗi khiếp sợ của DEV khi sắp Deadline.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = " Hãy giúp DEV bằng cách FIXBUG.";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(182, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 42);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Exit";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(605, 414);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLH);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.pBhinhnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pBhinhnen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBhinhnen;
        private DevExpress.XtraEditors.SimpleButton btnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnHD;
        private DevExpress.XtraEditors.SimpleButton btnLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}