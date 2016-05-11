using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Game_FixBuG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int h = 250, x = 600, y = 400, sound = 1, check = 1, Diem = 0,kt=2;
        SoundPlayer nn = new SoundPlayer("sound.wav");
        SoundPlayer fal = new SoundPlayer("mogame.wav");

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {      
          MessageBox.Show("Game hết sức nhảm nhí!!!\n\n Mang Tính Chất Giải Trí Sau Những Lúc Code Căng Thẳng!!!\n\n Vì đã giết được bọn BUG\n\n Chúc Bạn có những phút giây thư giãn ~^^~","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void time_Tick(object sender, EventArgs e)
        {           
            kt--;
            if (kt == 0)
            {
                SoundPlayer ov = new SoundPlayer("ov.wav");
                ov.Play();
                time.Enabled = false;
                DialogResult tl = new DialogResult();
               tl = MessageBox.Show("DEADLINE : Bạn đã sửa thành công "+Diem.ToString()+"BUG"+"\n\n Bạn có muốn thể hiện bản lĩnh FIX tiếp không ?","GAME OVER",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(tl == DialogResult.Yes)
                {
                    this.Close();                   
                }else {
                    this.Close();
                    Application.Exit();
                       }
               
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fal.Play();
        }
        // Tắt Âm
        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nn.Stop();
        }
        // Bật Âm
        private void bậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nn.PlayLooping();
        }
       
        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.pBBug.Location = new Point(x/2,y/2);
            this.pBBug.Size = new Size(h, h);
            this.Location = new Point(0, 0);
            this.Size = new Size(1300,720);
            nn.PlayLooping();
        }
        // Tạo số ngẫu nhiên
        public int ngaunhien(int a, int b)
        {
            Random nn = new Random();
            return nn.Next(a, b);
        }
        // FIX BUG
        private void pBBug_Click(object sender, EventArgs e)
        {
            kt = 2;
            Diem++;
            time.Enabled = true;
            Random n1 = new Random();
            Random n2 = new Random();
            this.pBBug.Location = new Point(ngaunhien(n2.Next(0,720),n1.Next(750,1200)),ngaunhien(n1.Next(0,300),n2.Next(310,650)));
            h -=20;
            if (h < 25)
            {
                h -= 2;
            }                             
            this.pBBug.Size = new Size(h, h);     
        }

    }
}
