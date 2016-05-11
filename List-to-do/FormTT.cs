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
    public partial class FormTT : DevExpress.XtraEditors.XtraForm
    {
        public FormTT()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormChinh frChinh = new FormChinh();
            this.Close();
            frChinh.ShowDialog();
        }
    }
}