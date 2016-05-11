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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer soundP = new SoundPlayer("mogame.wav");
            soundP.Play();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            btnHD.Hide();
            btnLH.Hide();
            btnS.Hide();
            simpleButton1.Hide();       
        }

        private void pBhinhnen_Click(object sender, EventArgs e)
        {
            pBhinhnen.Hide();
            SoundPlayer s = new SoundPlayer("nen.wav");
            s.Play();
        }

     
    

        private void Form2_Click(object sender, EventArgs e)
        {

            dem++;
            if (dem == 1)
            {
                label1.Show();
            }
            if (dem == 2)
            {
                label2.Show();
            }
            if (dem == 3)
            {
                label3.Show();
            }

            if(dem>=4)
            {
                btnHD.Show();

                btnLH.Show();

                btnS.Show();
                simpleButton1.Show();
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1. Bạn dùng chuột click vào Bug hiện trên màn hình để sửa nó !" + "\n\n 2. Vì Bug rất đông nên khi một Bug được fix sẽ lại xuất hiện các Bug khác." + "\n\n 3. Bạn phải bắt thật nhanh và thật chính xác trước khi tới Deadline" + "\n\n !!! Game sẽ ngày càng khó hi vọng bạn sẽ phá đảo được nó :D", "Cách chơi vô cùng đơn giản",MessageBoxButtons.OK);
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/messages/skyngoclove");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
