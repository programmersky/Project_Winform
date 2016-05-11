namespace AIPlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiemthi = new System.Windows.Forms.TextBox();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.txttinchi = new System.Windows.Forms.TextBox();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lbtthongtin = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.lsvbangdiem = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm TB ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm Thi ";
            // 
            // txtdiemthi
            // 
            this.txtdiemthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemthi.Location = new System.Drawing.Point(298, 50);
            this.txtdiemthi.Name = "txtdiemthi";
            this.txtdiemthi.Size = new System.Drawing.Size(87, 26);
            this.txtdiemthi.TabIndex = 1;
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemtb.Location = new System.Drawing.Point(100, 50);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(77, 26);
            this.txtdiemtb.TabIndex = 1;
            // 
            // txttinchi
            // 
            this.txttinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttinchi.Location = new System.Drawing.Point(309, 7);
            this.txttinchi.Name = "txttinchi";
            this.txttinchi.Size = new System.Drawing.Size(76, 26);
            this.txttinchi.TabIndex = 1;
            // 
            // txttenmon
            // 
            this.txttenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenmon.Location = new System.Drawing.Point(66, 7);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(111, 26);
            this.txttenmon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Tín Chỉ ";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(5, 90);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(148, 57);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntinh
            // 
            this.btntinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.ForeColor = System.Drawing.SystemColors.Window;
            this.btntinh.Location = new System.Drawing.Point(608, 109);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(109, 38);
            this.btntinh.TabIndex = 4;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = false;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(546, 72);
            this.txtketqua.Multiline = true;
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(216, 31);
            this.txtketqua.TabIndex = 8;
            // 
            // lbtthongtin
            // 
            this.lbtthongtin.AutoSize = true;
            this.lbtthongtin.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtthongtin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtthongtin.Location = new System.Drawing.Point(444, 7);
            this.lbtthongtin.Name = "lbtthongtin";
            this.lbtthongtin.Size = new System.Drawing.Size(90, 19);
            this.lbtthongtin.TabIndex = 9;
            this.lbtthongtin.Text = "Thông Tiin";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnam.Location = new System.Drawing.Point(542, 34);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(37, 19);
            this.lblnam.TabIndex = 11;
            this.lblnam.Text = "năm";
            // 
            // lsvbangdiem
            // 
            this.lsvbangdiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvbangdiem.FullRowSelect = true;
            this.lsvbangdiem.GridLines = true;
            this.lsvbangdiem.Location = new System.Drawing.Point(5, 153);
            this.lsvbangdiem.Name = "lsvbangdiem";
            this.lsvbangdiem.Size = new System.Drawing.Size(751, 224);
            this.lsvbangdiem.TabIndex = 12;
            this.lsvbangdiem.UseCompatibleStateImageBehavior = false;
            this.lsvbangdiem.View = System.Windows.Forms.View.Details;
            this.lsvbangdiem.DoubleClick += new System.EventHandler(this.lsvbangdiem_DoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sửa TT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvbangdiem);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.lbtthongtin);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenmon);
            this.Controls.Add(this.txttinchi);
            this.Controls.Add(this.txtdiemtb);
            this.Controls.Add(this.txtdiemthi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Thông Tin: Môn/Tín chỉ/Điểm số";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiemthi;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.TextBox txttinchi;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lbtthongtin;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.ListView lsvbangdiem;
        private System.Windows.Forms.Button button1;
    }
}