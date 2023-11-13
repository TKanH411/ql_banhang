using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_banhang.Xuathoadon
{
    internal class khachhang1
    {
        
        List<ThongKe> dsKH = new List<ThongKe>();
        public List<ThongKe> Sp
        {
            get { return dsKH; }
        }
        public void Mua(ThongKe kh)
        {
            dsKH.Add(kh);
        }
        public int TongSoSanPham
        {
            get
            {
                return dsKH.Count;
            }
        }
        public int TongSoSanPhamGiamGia
        {
            get
            {
                int sosv = 0;
                foreach (ThongKe kh in dsKH)
                    if (kh.Giamgia == true)
                        sosv++;
                return sosv;
            }
        }
        public double ThanhTien
        {
            get
            {
                double sum = 0;
                foreach (ThongKe kh in dsKH)
                    sum += kh.TinhTien;
                return sum;
            }
        }
    }
}
