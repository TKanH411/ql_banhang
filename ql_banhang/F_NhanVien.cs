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
    public partial class F_NhanVien : Form
    {
        string strconn = "Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void Clear_form()
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtgioitinh.Clear();
            txtdiachi.Clear();
            txtdienthoai.Clear();
        }
        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_nhanvien";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_nhanvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("xinchaooo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        public F_NhanVien()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chua nhap ma nhan vien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_nhanvien values('" + txtmanv.Text + "','" + txttennv.Text + "','" + txtgioitinh.Text + "','" + datengaysinh.Text + "','" + txtdienthoai.Text + "','" + txtdiachi.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_form();
                    txtmanv.Focus();
                    Hienthi_DL();

                }
                catch
                {
                    MessageBox.Show("Loi ket noi!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            conn.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chua nhap ma nhan vien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_nhanvien set tennv='" + txttennv.Text + "',gioitinh='" + txtgioitinh.Text + "',ngaysinh='" + datengaysinh.Text + "',diachi='" + txtdiachi.Text + "',dienthoai='" + txtdienthoai.Text + "'where manv='" + txtmanv.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sua thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_form();
                    txtmanv.Focus();
                    Hienthi_DL();

                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chua nhap ma nhan vien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_nhanvien where manv='" + txtmanv.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Ban co chac chan muon xoa khong!", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        Clear_form();
                        txtmanv.Focus();
                        Hienthi_DL();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi ket noi!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string sql_search = "select * from ql_nhanvien where manv like '%" + txtkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_nhanvien.DataSource = dt;
                    txtkey.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Loi ket noi!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void dgv_nhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennv.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgioitinh.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            datengaysinh.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdiachi.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdienthoai.Text = dgv_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void F_NhanVien_Load(object sender, EventArgs e)
        {
            Hienthi_DL();
            Clear_form();
        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
