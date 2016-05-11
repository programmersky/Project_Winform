using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace List_to_do
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            FormChinh fr = new FormChinh();
            this.Hide();
            fr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            FormChinh frc = new FormChinh();
            this.Hide();
            frc.ShowDialog();
        }
    }
}