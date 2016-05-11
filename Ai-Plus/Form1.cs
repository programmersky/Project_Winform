using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnki1.Checked = true;
        }
        private void btnoke1_Click(object sender, EventArgs e)
        {
            if ((txthoten.Text == ""))
            {
                MessageBox.Show("Vui Lòng Nhập Thông Tin Tên");
            }
            else {
                Form2 frm2 = new Form2();
                frm2.hoten = txthoten.Text;
                frm2.blki1 = false;
                frm2.blkisau = false;                
                if (rbtnki1.Checked == true)
                {
                    frm2.namhoc = "Kì Đầu";
                    frm2.blki1 = true;
                }
                else
                {
                    if (rbtnkisau.Checked == true)
                    {
                        frm2.namhoc = "Kì Sau";
                        frm2.blkisau = true;
                    }                    
                }
                frm2.ShowDialog();
                this.Close();
            }

        }
     
        private void linkfb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
            System.Diagnostics.Process.Start("https://www.facebook.com/messages/skyngoclove");
        }      
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Một ứng dụng đơn giản - Hy vọng sẽ giúp được các bạn tính điểm trong học kì!");
        }
       
    }
}
