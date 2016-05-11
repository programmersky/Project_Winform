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
    public partial class FormChinh : DevExpress.XtraEditors.XtraForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        // Tạo mảng chứa các Mục Tiêu , Ghi Chú , TimeTble
        
        List<GhiChu> DsGhiChu = new List<GhiChu>();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Close();
        }

        private void btnTGB_Click(object sender, EventArgs e)
        {
            FormTT frtt = new FormTT();
            frtt.Show();
            this.Hide();
        }

        private void btnMT_Click(object sender, EventArgs e)
        {
            FormMT frmt = new FormMT();
            frmt.Show();
            this.Hide();
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            FormGC frgc = new FormGC();
            frgc.Show();
            this.Hide();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
    }
}