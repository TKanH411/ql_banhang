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
    public partial class F_NCC : Form
    {
        string strconn = ("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        public F_NCC()
        {
            InitializeComponent();
        }
        public void Clear_From()
        {
            txtmncc.Clear();
            txttenncc.Clear();
            txtdiachi.Clear();
            txtghichu.Clear();
        }
        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_ncc";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_ncc.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        private void F_NCC_Load(object sender, EventArgs e)
        {
              Hienthi_DL();
            Clear_From();
        }

        private void them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmncc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmncc.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_ncc values('" + txtmncc.Text + "','" + txttenncc.Text + "','" + txtdiachi.Text + "','" + txtghichu.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmncc.Focus();
                    Hienthi_DL();
                }
                catch
                {
                    MessageBox.Show("Lỗi    !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void dgv_ncc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmncc.Text = dgv_ncc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenncc.Text = dgv_ncc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdiachi.Text = dgv_ncc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtghichu.Text = dgv_ncc.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmncc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmncc.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_ncc set tenncc='" + txttenncc.Text + "',diachi='" + txtdiachi.Text + "',ghichu='" + txtghichu.Text + "'where mancc='" + txtmncc.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmncc.Focus();
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
            if (txtmncc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmncc.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_ncc where mancc='" + txtmncc.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        Clear_From();
                        txtmncc.Focus();
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
                    string sql_search = "select * from ql_ncc where mancc like '%" + txtkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_ncc.DataSource = dt;
                    txtkey.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
    }
}
