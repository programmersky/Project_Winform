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
    public partial class FormTaoTg : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTg()
        {
            InitializeComponent();
        }
        List<MucTieu> DsMucTieu = new List<MucTieu>();
        MucTieu MT;
        string str =
                       " \nMục tiêu SMART (Thông minh) là gì?" +
                       "\nS.M.A.R.T là tên viết tắt các chữ đầu của 5 bước:" +
                       "\nVà để có một mục tiêu thông minh thì khi đặt mục tiêu bạn phải hội đủ 5 yếu tố sau." +
                        "\nS - Specific : Cụ thể, dễ hiểu." +
                        "\nM - Measurable : Đo lường được" +
                        "\nA - Attainable : Có thể đạt được" +
                        "\nR - Relevant : Thực tế" +
                        "\nT - Time - Bound : Thời gian hoàn thành";
        private void FormTaoTg_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNDMT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(str, " 5 Bước Đặt Mục Tiêu. Hãy Đọc Nó Thật Kĩ ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            MT = new MucTieu(txtNDMT.Text, dtptime.Value);
            // Thêm vào danh sách mục tiêu
            DsMucTieu.Add(MT);
            
        }
    }
}