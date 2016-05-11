using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phát_Wifi_Hẹn_giờ_tắt_máy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
               fr3.ShowDialog();
        }      
        private void button6_Click(object sender, EventArgs e)
        {
            Form5 fr5= new Form5();
            fr5.ShowDialog();
        }

        private void btnnetwork_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }
    }
}
