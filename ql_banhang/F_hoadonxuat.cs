using ql_banhang.Properties;
using ql_banhang.Xuathoadon;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ql_banhang
{
    public partial class F_hoadonxuat : Form

    {
        private List<ThongKe> thongke = new List<ThongKe>();
        khachhang1 database = new khachhang1();
        public F_hoadonxuat()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            ThongKe kh = new ThongKe();


            thongke.Add(kh);
            dgv_ttsp.DataSource = null;
            dgv_ttsp.DataSource = thongke;
            kh.Ten = cbTen.Text;
            kh.SoLuongMua = int.Parse(txtSoluong.Text);
            kh.Giamgia = chkGiamgia.Checked;
            kh.GIA = int.Parse(gia.Text);
            database.Mua(kh);
            lblThanhTien.Text = kh.TinhTien + "";






        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            cbTen.Text = "";
            txtSoluong.Text = "";
            chkGiamgia.Checked = false;
            lblThanhTien.Text = "";
            cbTen.Focus();



        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            txtTongSoSP.Text = database.TongSoSanPham + "";
            txtTongSoSPgiamgia.Text = database.TongSoSanPhamGiamGia + "";
            txtThanhTien.Text = database.ThanhTien + "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
               "Bạn Muốn Thoát?", "HỎi thoát?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)
                Close();
        }





        //////private void F_hoadonxuat_Load(object sender, EventArgs e)
        //////{
        //////    // TODO: This line of code loads data into the 'qL_banhangDataSet11.ql_hoadonxuat' table. You can move, or remove it, as needed.
        //////    this.ql_hoadonxuatTableAdapter1.Fill(this.qL_banhangDataSet11.ql_hoadonxuat);
        //////    // TODO: This line of code loads data into the 'qL_banhangDataSet.ql_hoadonxuat' table. You can move, or remove it, as needed.

        //////    // TODO: This line of code loads data into the 'qL_banhangDataSet10.ql_khachhang' table. You can move, or remove it, as needed.
        //////    this.ql_khachhangTableAdapter.Fill(this.qL_banhangDataSet10.ql_khachhang);
        //////    // TODO: This line of code loads data into the 'qL_banhangDataSet9.ql_sanpham' table. You can move, or remove it, as needed.
        //////    this.ql_sanphamTableAdapter.Fill(this.qL_banhangDataSet9.ql_sanpham);
        //////    Hienthi_DL();
        //////    Clear_From();

        //////}
        string strconn = "Server=DTHANH0411\\SQLEXPRESS;Database=QL_banhang;Integrated Security = true";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;


        public void Hienthi_DL()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string str_ht = "select * from ql_hoadonxuat";
                da = new SqlDataAdapter(str_ht, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hoadonxuat.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        public void Clear_From()
        {
            txtmhdx.Clear();
            txtThanhTien.Clear();
            txtTongSoSP.Clear();
            txtTongSoSPgiamgia.Clear();
            cbmkh.Text = "";
            cbTen.Text = "";
            dtngaylap.Text = "";


        }
        private void them_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            if (txtmhdx.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhdx.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_insert = "Insert into ql_hoadonxuat values('" + txtmhdx.Text + "','" + cbmkh.Text + "','" + cbtkh.Text + "','" + dtngaylap.Text + "','" + txtTongSoSP.Text + "','" + txtTongSoSPgiamgia.Text + "','" + txtThanhTien.Text + "')";
                    cmd = new SqlCommand(sql_insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmhdx.Focus();
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
            if (txtmhdx.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhdx.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_update = "update ql_hoadonxuat set makh='" + cbmkh.Text + "',tenkh='" + cbtkh.Text + "',ngaylaphd='" + dtngaylap.Text + "',tongsosp='" + txtTongSoSP.Text + "',sospgg='" + txtTongSoSPgiamgia.Text + "',thanhtien='" + txtThanhTien.Text + "'where mahdx='" + txtmhdx.Text + "'";
                    cmd = new SqlCommand(sql_update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_From();
                    txtmhdx.Focus();
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
            if (txtmhdx.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmhdx.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql_del = "Delete from ql_hoadonxuat where mahdx='" + txtmhdx.Text + "'";
                    cmd = new SqlCommand(sql_del, conn);
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        Clear_From();
                        txtmhdx.Focus();
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

        private void dgv_hoadonxuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmhdx.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmkh.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbtkh.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtngaylap.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTongSoSP.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTongSoSPgiamgia.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtThanhTien.Text = dgv_hoadonxuat.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                if (cbkey.Text == "")
                {
                    Hienthi_DL();
                }
                else
                {
                    string sql_search = "select * from ql_hoadonxuat where mahdx like '%" + cbkey.Text + "%'";
                    da = new SqlDataAdapter(sql_search, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv_hoadonxuat.DataSource = dt;

                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void moi_Click(object sender, EventArgs e)
        {
            txtmhdx.Text = "";
            cbmkh.Text = "";
            cbtkh.Text = "";
            dtngaylap.Text = "";
            txtTongSoSP.Text = "";
            txtTongSoSPgiamgia.Text = "";
            txtThanhTien.Text = "";


        }
        private void btIn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image image = Resources._2;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("Ngày Xuất: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Hóa Đơn Xuất", new Font("Arial", 30, FontStyle.Regular), Brushes.Red, new Point(270, 130));
            e.Graphics.DrawString("Tên Khách hàng: " + cbtkh.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 225));
            e.Graphics.DrawString("Mã Khách Hàng: " + cbmkh.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Mã Hóa Đơn Xuất: " + txtmhdx.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 170));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 285));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 285));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 285));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 285));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));

            int Y = 315;
            foreach (var i in thongke)
            {
                e.Graphics.DrawString(i.Ten, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, Y));
                e.Graphics.DrawString(i.SoLuongMua.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, Y));
                e.Graphics.DrawString(i.GIA.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, Y));
                e.Graphics.DrawString(i.TinhTien.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, Y));
                Y += 30;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 500));

            e.Graphics.DrawString("Tổng Sản Phẩm:      " + txtTongSoSP.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 500 + 30));
            e.Graphics.DrawString("Tổng Sản Phẩm Giảm Giá: " + txtTongSoSPgiamgia.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 500 + 60));
            e.Graphics.DrawString("Tổng Tiền:  " + txtThanhTien.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 500 + 90));

        }
        private void F_hoadonxuat_Load(object sender, EventArgs e)
        {

        }
    }
}
