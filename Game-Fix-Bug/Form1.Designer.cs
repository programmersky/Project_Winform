namespace Game_FixBuG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBBug = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.độKhóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungBìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAmThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.bậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBug)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OldLace;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pBBug
            // 
            this.pBBug.BackColor = System.Drawing.Color.White;
            this.pBBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBBug.BackgroundImage")));
            this.pBBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBBug.Image = ((System.Drawing.Image)(resources.GetObject("pBBug.Image")));
            this.pBBug.InitialImage = null;
            this.pBBug.Location = new System.Drawing.Point(321, 200);
            this.pBBug.Margin = new System.Windows.Forms.Padding(4);
            this.pBBug.Name = "pBBug";
            this.pBBug.Size = new System.Drawing.Size(106, 92);
            this.pBBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBug.TabIndex = 1;
            this.pBBug.TabStop = false;
            this.pBBug.Click += new System.EventHandler(this.pBBug_Click);
            // 
            // time
            // 
            this.time.Interval = 700;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độKhóToolStripMenuItem,
            this.MenuAmThanh,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // độKhóToolStripMenuItem
            // 
            this.độKhóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dễToolStripMenuItem,
            this.trungBìnhToolStripMenuItem,
            this.khóToolStripMenuItem});
            this.độKhóToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.độKhóToolStripMenuItem.Name = "độKhóToolStripMenuItem";
            this.độKhóToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.độKhóToolStripMenuItem.Text = "Mức Độ";
            // 
            // dễToolStripMenuItem
            // 
            this.dễToolStripMenuItem.Name = "dễToolStripMenuItem";
            this.dễToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.dễToolStripMenuItem.Text = "Dễ";
            // 
            // trungBìnhToolStripMenuItem
            // 
            this.trungBìnhToolStripMenuItem.Name = "trungBìnhToolStripMenuItem";
            this.trungBìnhToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.trungBìnhToolStripMenuItem.Text = "Trung Bình";
            // 
            // khóToolStripMenuItem
            // 
            this.khóToolStripMenuItem.Name = "khóToolStripMenuItem";
            this.khóToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.khóToolStripMenuItem.Text = "Khó";
            // 
            // MenuAmThanh
            // 
            this.MenuAmThanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bậtToolStripMenuItem,
            this.tắtToolStripMenuItem});
            this.MenuAmThanh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAmThanh.Name = "MenuAmThanh";
            this.MenuAmThanh.Size = new System.Drawing.Size(88, 24);
            this.MenuAmThanh.Text = "Âm Thanh";
            // 
            // bậtToolStripMenuItem
            // 
            this.bậtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bậtToolStripMenuItem.Image")));
            this.bậtToolStripMenuItem.Name = "bậtToolStripMenuItem";
            this.bậtToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.bậtToolStripMenuItem.Text = "Bật";
            this.bậtToolStripMenuItem.Click += new System.EventHandler(this.bậtToolStripMenuItem_Click);
            // 
            // tắtToolStripMenuItem
            // 
            this.tắtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tắtToolStripMenuItem.Image")));
            this.tắtToolStripMenuItem.Name = "tắtToolStripMenuItem";
            this.tắtToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.tắtToolStripMenuItem.Text = "Tắt";
            this.tắtToolStripMenuItem.Click += new System.EventHandler(this.tắtToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pBBug);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBug)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBBug;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem độKhóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dễToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungBìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAmThanh;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtToolStripMenuItem;
    }
}

