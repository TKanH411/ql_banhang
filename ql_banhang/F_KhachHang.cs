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
    public partial class F_KhachHang : Form
    {
        public F_KhachHang()
        {
            InitializeComponent();
        }

        string strconn = "Server=DTHANH0411\\SQLEXPRESS;Database=QLbanhang;Integrated Security = true";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public void Clear_From()
        {
            txtmakh.Clear();
            txttekh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }
        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_khachhang";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_khachhang.DataSource = dt;

            }
            catch (Exception ex)

            {
                MessageBox.Show("xinchaooo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_khachhang values('" + txtmakh.Text + "','" + txttekh.Text + "','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmakh.Focus();
                    Hienthi_DL();
                }
                catch
                {
                    MessageBox.Show("Lỗi    !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            Clear_From();
            Hienthi_DL();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_khachhang set tenkh='" + txttekh.Text + "',diachi='" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "'where makh='" + txtmakh.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmakh.Focus();
                    Hienthi_DL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_khachhang where makh='" + txtmakh.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        Clear_From();
                        txtmakh.Focus();
                        Hienthi_DL();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                if (txtkey.Text == "")
                {
                    Hienthi_DL();
                }
                else
                {
                    string sql_search = "select * from ql_khachhang where makh like '%" + txtkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_khachhang.DataSource = dt;
                    txtkey.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void dgv_khachhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dgv_khachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttekh.Text = dgv_khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdiachi.Text = dgv_khachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsdt.Text = dgv_khachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            F_hoadonxuat frm = new F_hoadonxuat();
            frm.ShowDialog();
        }


    }
}


