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
    public partial class F_HDN : Form
    {

        string strconn = ("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        public F_HDN()
        {
            InitializeComponent();
        }
        public void Clear_From()
        {
            txtmhd.Clear();
            txtmsp.Clear();
            txttsp.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            cbmncc.Text = "";
            cbtncc.Text = "";

        }
        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_hoadonnhap";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hoadonnhap.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmhd.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà hoa don!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhd.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_hoadonnhap values('" + txtmhd.Text + "','" + cbmncc.Text + "','" + cbtncc.Text + "', '" + dtngaylap.Text + "','" + txtmsp.Text + "','" + txttsp.Text + "','" + txtsoluong.Text + "','" + txtdongia.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmhd.Focus();
                    Hienthi_DL();
                }
                catch
                {
                    MessageBox.Show("Lỗi    !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmhd.Text == "")
            {
                MessageBox.Show("Chưa nhập mã hoa don!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhd.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_hoadonnhap set mancc='" + cbmncc.Text + "',tenncc='" + cbtncc.Text + "',ngaylaphd='" + dtngaylap.Text + "',masp='" + txtmsp.Text + "',tensp='" + txttsp.Text + "',soluong='" + txtsoluong.Text + "',dongia='" + txtdongia.Text + "'where mahdn='" + txtmhd.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmhd.Focus();
                    Hienthi_DL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmhd.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhd.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_hoadonnhap where mahdn='" + txtmhd.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        Clear_From();
                        txtmhd.Focus();
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

        private void thoat_Click(object sender, EventArgs e)
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
                    string sql_search = "select * from ql_hoadonnhap where mahdn like '%" + txtkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_hoadonnhap.DataSource = dt;
                    txtkey.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }



        ////private void F_HDN_Load(object sender, EventArgs e)
        ////{
        ////    // TODO: This line of code loads data into the 'qL_banhangDataSet7.ql_sanpham' table. You can move, or remove it, as needed.
        ////    this.ql_sanphamTableAdapter2.Fill(this.qL_banhangDataSet7.ql_sanpham);
        ////    // TODO: This line of code loads data into the 'qL_banhangDataSet6.ql_sanpham' table. You can move, or remove it, as needed.
        ////    this.ql_sanphamTableAdapter1.Fill(this.qL_banhangDataSet6.ql_sanpham);
        ////    // TODO: This line of code loads data into the 'qL_banhang.ql_ncc' table. You can move, or remove it, as needed.
        ////    this.ql_nccTableAdapter2.Fill(this.qL_banhang.ql_ncc);
        ////    // TODO: This line of code loads data into the 'qL_banhangDataSet5.ql_ncc' table. You can move, or remove it, as needed.
        ////    this.ql_nccTableAdapter1.Fill(this.qL_banhangDataSet5.ql_ncc);
        ////    Hienthi_DL();
        ////    Clear_From();
        ////}

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ql_nccTableAdapter.FillBy(this.qL_banhangDataSet.ql_ncc);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgv_hoadonnhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmhd.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmncc.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbtncc.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtngaylap.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmsp.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[4].Value.ToString();
            txttsp.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtsoluong.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdongia.Text = dgv_hoadonnhap.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void F_HDN_Load(object sender, EventArgs e)
        {

        }
    }
}

