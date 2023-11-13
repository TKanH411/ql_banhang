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
using System.Xml;

namespace ql_banhang
{
    public partial class F_sanpham : Form
    {
        public F_sanpham()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        
        public void Hienthi_DL()
        {
            conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            try
            {
                conn.Open();
                string str_ht = "select * from ql_sanpham";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_sanpham.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        public void Clear_From()
        {
            cbmncc.Text = "";
          
            cbtncc.Text = "";
            cbsoluong.Text = "";
            cbtsp.Text = "";
            cbmsp.Text = "";
            cbsoluong.Text = "";
            cbgianhap.Text = "";

        }



     

        private void them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            if (cbmsp.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmsp.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_sanpham values('" + cbmsp.Text + "','" + cbtsp.Text + "','" + cbmncc.Text + "','" + cbtncc.Text + "','" + cbsoluong.Text + "','" + cbngaynhap.Text + "','" + cbgianhap.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    cbmsp.Focus();
                    Hienthi_DL();
                }
                catch
                {
                    MessageBox.Show("Lỗi    !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            conn.Close();
        }

        //private void F_sanpham_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'qL_banhangDataSet8.ql_hoadonnhap' table. You can move, or remove it, as needed.
        //    this.ql_hoadonnhapTableAdapter.Fill(this.QL_banhangDataSet8.ql_hoadonnhap);
        //    // TODO: This line of code loads data into the 'qL_banhangDataSet2.ql_ncc' table. You can move, or remove it, as needed.
        //    this.ql_nccTableAdapter1.Fill(this.QL_banhangDataSet2.ql_ncc);
        //    // TODO: This line of code loads data into the 'qL_banhangDataSet.ql_ncc' table. You can move, or remove it, as needed.
        //    this.ql_nccTableAdapter.Fill(this.qL_banhangDataSet.ql_ncc);
        //    Clear_From();
        //    Hienthi_DL();
        //}

        private void dgv_sanpham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbmsp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmsp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbmncc.Text = dgv_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbtncc.Text = dgv_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbsoluong.Text = dgv_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbngaynhap.Text = dgv_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbgianhap.Text = dgv_sanpham.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            if (cbmsp.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmsp.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_sanpham set tensp='" + cbtsp.Text + "',mancc='" + cbmncc.Text + "',tenncc='" + cbtncc.Text + "',soluong='"+cbsoluong.Text+"',ngaynhap='" + cbngaynhap.Text + "',gianhap='" + cbgianhap.Text + "'where masp='" + cbmsp.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    cbmsp.Focus();
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
            conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
            if (cbmsp.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmsp.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_sanpham where masp='" + cbmsp.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        
                        cbmsp.Focus();
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
                conn = new SqlConnection("Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true");
                conn.Open();
                if (txtkey.Text == "")
                {
                    Hienthi_DL();
                }
                else
                {
                    string sql_search = "select * from ql_sanpham where masp like '%" + txtkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_sanpham.DataSource = dt;
                    txtkey.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void F_sanpham_Load(object sender, EventArgs e)
        {
            Hienthi_DL();

        }
    }
}
