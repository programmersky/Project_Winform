using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_to_do
{
   
    class MucTieu
    {
        private string MT_MucTieu;
        private DateTime MT_ThoiGian;
        public MucTieu() { }
        public MucTieu(string muctieu, DateTime time)
        {
            MT_MucTieu = muctieu;
           
            MT_ThoiGian = time;
        }
            
        public string MT_MucTieu1
        {
            get
            {
                return MT_MucTieu;
            }

            set
            {
                MT_MucTieu = value;
            }
        }

        public DateTime MT_ThoiGian1
        {
            get
            {
                return MT_ThoiGian;
            }

            set
            {
                MT_ThoiGian = value;
            }
        }
    }
}
