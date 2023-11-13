using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_banhang
{
    public partial class F_DangKy : Form
    {
        public F_DangKy()
        {
            InitializeComponent();
        }
        string strconn = "Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public void Clear_form()
        {
            txttk.Clear();
            txtmk.Clear();
            txtnlmk.Clear();
        
        }
        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_dangnhap";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();

            
        
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txttk.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Tài Khoản!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttk.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_dangnhap values('" + txttk.Text + "','" + txtmk.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng Ký Thành Công!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_form();
                    txttk.Focus();
                    Hienthi_DL();

                }
                catch
                {
                    MessageBox.Show("Loi ket noi!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            conn.Close();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_DangKy_Load(object sender, EventArgs e)
        {

        }
    }
 }
