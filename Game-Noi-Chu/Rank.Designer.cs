namespace NoiChhu
{
    partial class Rank
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
            this.lsvrank = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvrank
            // 
            this.lsvrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvrank.FullRowSelect = true;
            this.lsvrank.GridLines = true;
            this.lsvrank.Location = new System.Drawing.Point(12, 30);
            this.lsvrank.Name = "lsvrank";
            this.lsvrank.Size = new System.Drawing.Size(411, 273);
            this.lsvrank.TabIndex = 0;
            this.lsvrank.UseCompatibleStateImageBehavior = false;
            this.lsvrank.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 333);
            this.Controls.Add(this.lsvrank);
            this.Name = "Rank";
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.Rank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvrank;
    }
}