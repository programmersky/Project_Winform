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
    public partial class FormMT : DevExpress.XtraEditors.XtraForm
    {
        public FormMT()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormChinh frmChinh = new FormChinh();
            this.Close();
            frmChinh.Show();
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FormChinh frChinh = new FormChinh();
            this.Close();
            frChinh.ShowDialog();
        }
       
        private void btnTaoTg_Click(object sender, EventArgs e)
        {
            
            FormTaoTg frtao = new FormTaoTg();
            frtao.ShowDialog();
            
        }

        private void btnShowTg_Click(object sender, EventArgs e)
        {
            MucTieu MT = new MucTieu();          
            string strMT = MT.MT_MucTieu1;
            string time = MT.MT_ThoiGian1.ToString();
            MessageBox.Show(strMT + time);
        }
    }
}