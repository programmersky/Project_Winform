using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_to_do
{
    class GhiChu
    {
        private string TieuDe, NoiDung;
        private DateTime ThongBao;

        public string TieuDe1
        {
            get
            {
                return TieuDe;
            }

            set
            {
                TieuDe = value;
            }
        }

        public string NoiDung1
        {
            get
            {
                return NoiDung;
            }

            set
            {
                NoiDung = value;
            }
        }

        public DateTime ThongBao1
        {
            get
            {
                return ThongBao;
            }

            set
            {
                ThongBao = value;
            }
        }
    }
}
