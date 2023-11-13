using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_banhang
{
    public partial class F_QuanLy : Form
    {
        public F_QuanLy()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel.Controls.Add(f);
            this.panel.Tag = f;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new F_NhanVien());
            
         
         
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new F_NCC());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new F_HDN());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new F_sanpham());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new F_KhachHang());
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            loadform(new F_hoadonxuat());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Đăng Xuất?", "hi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void F_QuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}
