using System;
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
    public partial class Rank : System.Windows.Forms.Form
    {
        public Rank()
        {
            InitializeComponent();
        }
        public string diemcao,tencao;
        private void Rank_Load(object sender, EventArgs e)
        {
            lsvrank.Columns.Add("Tên", 150);
            lsvrank.Columns.Add("Điểm", 150);
        }
    }
}
