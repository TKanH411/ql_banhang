using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_banhang
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        public int i = -1;
        public int j = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbform.Location = new Point(lbform.Location.X, lbform.Location.Y + i);
            if (lbform.Location.Y <= 30)
            {
                i = 1;
            }
            if (lbform.Location.Y >= 60) i = -1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbleff.Location = new Point(lbleff.Location.X - j, lbleff.Location.Y);
            lblright.Location = new Point(lblright.Location.X + j, lblright.Location.Y);
            if (lbleff.Location.X <= -100) pictureBox1.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login frm = new F_Login();
            frm.ShowDialog();
        }

   

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Bán Hàng  \n";

            tt += "\n ";

            tt += " ____ APP Thanh Tao____ ";
            tt += "\n";
            tt += "\nSinh viên thực hiện : - NDT";
            tt += "\n\n";
            tt += "Email : duythanh2924@gmail.com  \n\n";
            tt += "Số điện thoại:0965668723 ";
            tt += "\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }

       

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DangkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DangKy frm = new F_DangKy ();
            frm.ShowDialog();

        }
    }
}
