namespace NoiChhu
{
    partial class noichu
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.txtplayer = new System.Windows.Forms.TextBox();
            this.prBchaytime = new System.Windows.Forms.ProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lbldiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(159, 7);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(104, 42);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Điểm";
            // 
            // txtpc
            // 
            this.txtpc.Enabled = false;
            this.txtpc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpc.Location = new System.Drawing.Point(12, 106);
            this.txtpc.Multiline = true;
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(293, 39);
            this.txtpc.TabIndex = 2;
            // 
            // txtplayer
            // 
            this.txtplayer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayer.Location = new System.Drawing.Point(85, 188);
            this.txtplayer.Name = "txtplayer";
            this.txtplayer.Size = new System.Drawing.Size(293, 39);
            this.txtplayer.TabIndex = 2;
            this.txtplayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtplayer_KeyUp);
            // 
            // prBchaytime
            // 
            this.prBchaytime.Location = new System.Drawing.Point(3, 71);
            this.prBchaytime.Name = "prBchaytime";
            this.prBchaytime.Size = new System.Drawing.Size(375, 12);
            this.prBchaytime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prBchaytime.TabIndex = 4;
            this.prBchaytime.Value = 100;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiem.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbldiem.Location = new System.Drawing.Point(260, 15);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(155, 33);
            this.lbldiem.TabIndex = 5;
            this.lbldiem.Text = "showdiem";
            this.lbldiem.Click += new System.EventHandler(this.lbldiem_Click);
            // 
            // noichu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 356);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.prBchaytime);
            this.Controls.Add(this.txtplayer);
            this.Controls.Add(this.txtpc);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "noichu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nối Chữ";
            this.Load += new System.EventHandler(this.noichu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.TextBox txtplayer;
        private System.Windows.Forms.ProgressBar prBchaytime;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lbldiem;
    }
}