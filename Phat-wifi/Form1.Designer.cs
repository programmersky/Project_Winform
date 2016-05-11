namespace Phát_Wifi_Hẹn_giờ_tắt_máy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnphat = new System.Windows.Forms.Button();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.btndung = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntrogiup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnphat
            // 
            this.btnphat.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnphat.Location = new System.Drawing.Point(169, 173);
            this.btnphat.Name = "btnphat";
            this.btnphat.Size = new System.Drawing.Size(142, 47);
            this.btnphat.TabIndex = 3;
            this.btnphat.Text = "Start";
            this.btnphat.UseMnemonic = false;
            this.btnphat.UseVisualStyleBackColor = true;
            this.btnphat.Click += new System.EventHandler(this.btnphat_Click);
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkiemtra.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnkiemtra.Location = new System.Drawing.Point(12, 173);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(141, 47);
            this.btnkiemtra.TabIndex = 3;
            this.btnkiemtra.Text = "Test";
            this.btnkiemtra.UseMnemonic = false;
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // btndung
            // 
            this.btndung.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndung.ForeColor = System.Drawing.Color.DarkCyan;
            this.btndung.Location = new System.Drawing.Point(329, 173);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(142, 47);
            this.btndung.TabIndex = 3;
            this.btndung.Text = "Stop";
            this.btndung.UseMnemonic = false;
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(147, 89);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(197, 29);
            this.txtpass.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.Window;
            this.txtname.Location = new System.Drawing.Point(147, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(197, 29);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(96, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name\'s Wifi";
            // 
            // btntrogiup
            // 
            this.btntrogiup.BackColor = System.Drawing.Color.AliceBlue;
            this.btntrogiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrogiup.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrogiup.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btntrogiup.Location = new System.Drawing.Point(368, 15);
            this.btntrogiup.Name = "btntrogiup";
            this.btntrogiup.Size = new System.Drawing.Size(79, 34);
            this.btntrogiup.TabIndex = 5;
            this.btntrogiup.Text = "Help";
            this.btntrogiup.UseVisualStyleBackColor = false;
            this.btntrogiup.Click += new System.EventHandler(this.btntrogiup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btntrogiup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(459, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wifi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(483, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.btnphat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phát Wifi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnphat;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntrogiup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
    }
}

