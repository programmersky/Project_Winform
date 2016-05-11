using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace NoiChhu
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            Rank rk = new Rank();
            rk.tencao = txtten.Text;
        }

        private void btnbatdau_Click(object sender, EventArgs e)
        {                     
            noichu fr2 = new noichu();
            fr2.hoten = txtten.Text; 
            this.Hide();
            fr2.ShowDialog();
            this.Close();
        }
        private void txtten_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
        }

        private void điểmCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chơi thế này này :D ");
        }
    }
}
