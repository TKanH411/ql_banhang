using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_banhang
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            try
            {

                conn.Open();
                MessageBox.Show("ket noi thanh cong");
                //string taikhoan = txttk.Text;
                //string matkhau = txtmk.Text;
                //string sql = "Select * from QL_taikhoan  where taikhoan ='" + txttk.Text + "' and matkhau='" + txtmk.Text + "'";
                //SqlCommand cmd = new SqlCommand(sql, con);
                //SqlDataReader dta = cmd.ExecuteReader();
                //if (dta.Read() == true)
                //{
                //    MessageBox.Show("Đănng Nhập Thành Công");
                //    F_QuanLy form = new F_QuanLy();
                //    form.ShowDialog();
                //    txttk.Clear();
                //    txtmk.Clear();

                //}
                //else
                //{
                //    MessageBox.Show("Đănng Nhập Thất Bại");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_DangKy frm = new F_DangKy();
            frm.ShowDialog();

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            try
            {

                con.Open();
                MessageBox.Show("ket noi thanh cong");
                string taikhoan = txttk.Text;
                string matkhau = txtmk.Text;
                string sql = "Select * from ql_dangnhap  where taikhoan ='" + txttk.Text + "' and matkhau='" + txtmk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đănng Nhập Thành Công");
                    F_QuanLy form = new F_QuanLy();
                    form.ShowDialog();
                    txttk.Clear();
                    txtmk.Clear();

                }
                else
                {
                    MessageBox.Show("Đănng Nhập Thất Bại");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
