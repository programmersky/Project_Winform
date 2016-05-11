using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_to_do
{
    class ThoiGianBieu
    {
        private DateTime TGB_Thoigian;
        private string CongViec, GhiNho;     

        public string CongViec1
        {
            get
            {
                return CongViec;
            }

            set
            {
                CongViec = value;
            }
        }

        public string GhiNho1
        {
            get
            {
                return GhiNho;
            }

            set
            {
                GhiNho = value;
            }
        }

        public DateTime TGB_Thoigian1
        {
            get
            {
                return TGB_Thoigian;
            }

            set
            {
                TGB_Thoigian = value;
            }
        }
    }
}
