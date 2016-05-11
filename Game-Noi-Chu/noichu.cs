using System;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiChhu
{
    public partial class noichu : System.Windows.Forms.Form
    {
        public noichu()
        {
            InitializeComponent();
        }
        public int i;
        public double tong = 0;
        public string hoten;
        private void noichu_Load(object sender, EventArgs e)
        {
            lbldiem.Text = "0";

            Form fr1 = new Form();

            if (hoten == "Hiền")
            {
                txtpc.Text = "Hiền Béo ";
                txtplayer.Text = "Béo ";
                txtplayer.Select(txtplayer.Text.Length, 1);
            }
            else {
                string Str1 = hoten.Substring(0, 1);
                Str1 = Str1.ToLower();
                string trunggianten = hoten.Remove(0, 1);
                //txtplayer.Focus();
                time.Interval = 100;
                this.time.Enabled = false;
                //Tìm từ đầu tiên
                string tukhoa = Str1 + trunggianten;
                var stream = new System.IO.StreamReader("InPut.txt");
                var contents = stream.ReadToEnd();
                var index = contents.IndexOf(tukhoa);
                stream.Close();
                if (index == -1)
                {
                    MessageBox.Show("Tên của bạn kì quá rồi. Xem lại coi", "Lỗi Tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fr1.ShowDialog();
                    this.Close();
                }
                else
                {
                    StreamReader file = new StreamReader("InPut.txt");
                    while (!file.EndOfStream)
                    {
                        string tam = file.ReadLine();
                        if (tam.StartsWith(tukhoa) == true)
                        {
                            //string khongcan = file.ReadLine();
                            string can = file.ReadLine();
                            string[] arrListStr = can.Split(' ');
                            //  string hien = arrListStr[1];
                            txtpc.Text = hoten + " " + arrListStr[1];
                            txtplayer.Text = arrListStr[1] + " ";
                            txtplayer.Select(txtplayer.Text.Length, 1);
                            break;
                        }
                    }
                }

            }
        }
        private void txtplayer_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                i = 101;
                this.time.Enabled = true;
                if (i < 0)
                {
                    DialogResult DR = MessageBox.Show("Chơi lại không ?", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == DR)
                    {
                        Form fr1 = new Form();
                        noichu fr2 = new noichu();
                        fr2.Close();
                        fr1.Show();

                    }
                    if (DialogResult.Cancel == DR)
                    {
                        this.Close();
                    }
                }
                else {
                    prBchaytime.Value = i;
                }
            }
            this.time.Enabled = true;
            string pl = txtplayer.Text;
            try
            {
                string[] arrpl = pl.Split(' ');
                string tukhoa = arrpl[1];
                var stream = new System.IO.StreamReader("InPut.txt");
                var contents = stream.ReadToEnd();
                var index = contents.IndexOf(tukhoa);
                stream.Close();
                if (index == -1)
                {
                    MessageBox.Show("ThuaCuộc");

                }
                else
                {
                    StreamReader file = new StreamReader("InPut.txt");
                    while (!file.EndOfStream)
                    {
                        try
                        {
                            string tam = file.ReadLine();
                            if (tam.StartsWith(tukhoa) == true)
                            {
                                //string khongcan = file.ReadLine();
                                string can = file.ReadLine();
                                string[] arrListStr = can.Split(' ');
                                //  string hien = arrListStr[1];
                                txtpc.Text = tukhoa + " " + arrListStr[1];
                                txtplayer.Text = arrListStr[1] + " ";
                                txtplayer.Select(txtplayer.Text.Length, 1);
                                tong = tong + 1;
                                lbldiem.Text = tong.ToString();
                                break;
                            }
                        }
                        catch
                        {
                            MessageBox.Show(" Youuuuuu WINNNNNNNN");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(" Bạn đã thua !");
            }
            if (i < 0)
            {
                MessageBox.Show("Thua rồi", "HeHe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void time_Tick(object sender, EventArgs e)
        {
            //i--;
            //        if (i < 0)
            //        {
            //            
            //            {DialogResult DR = MessageBox.Show("Chơi lại không ?", "Game Over", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //            if (DialogResult.OK == DR)
            //                Form fr1 = new Form();
            //                noichu fr2 = new noichu();
            //                fr2.Close();
            //                fr1.Show();

            //            }
            //            if (DialogResult.Cancel == DR)
            //            {
            //                this.Close();
            //            }           
            //    }
            //        else {
            //            prBchaytime.Value = i;
            //        }
            //    }
            //}
        }

        private void lbldiem_Click(object sender, EventArgs e)
        {

        }
    }
}