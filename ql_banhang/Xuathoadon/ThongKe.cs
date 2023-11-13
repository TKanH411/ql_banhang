using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_banhang.Xuathoadon
{
    public class ThongKe
    {
       
        
        public string Ten { get; set; }
        public int SoLuongMua { get; set; }
        public int GIA { get; set; }
        public bool Giamgia { get; set; }
        public double TinhTien
        {
            get
            {
                if (Giamgia == true)
                    return SoLuongMua * GIA * 0.90;
                else
                    return SoLuongMua * GIA;
            }
        }
    }
}
