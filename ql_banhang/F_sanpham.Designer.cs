namespace ql_banhang
{
    partial class F_sanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbgianhap = new System.Windows.Forms.ComboBox();
            this.qlhoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_banhangDataSet8 = new ql_banhang.QL_banhangDataSet8();
            this.cbngaynhap = new System.Windows.Forms.ComboBox();
            this.cbsoluong = new System.Windows.Forms.ComboBox();
            this.cbtsp = new System.Windows.Forms.ComboBox();
            this.cbmsp = new System.Windows.Forms.ComboBox();
            this.cbmncc = new System.Windows.Forms.ComboBox();
            this.cbtncc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qlnccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_banhangDataSet = new ql_banhang.QL_banhangDataSet();
            this.ql_nccTableAdapter = new ql_banhang.QL_banhangDataSetTableAdapters.ql_nccTableAdapter();
            this.qL_banhangDataSet2 = new ql_banhang.QL_banhangDataSet2();
            this.qlnccBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ql_nccTableAdapter1 = new ql_banhang.QL_banhangDataSet2TableAdapters.ql_nccTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ql_hoadonnhapTableAdapter = new ql_banhang.QL_banhangDataSet8TableAdapters.ql_hoadonnhapTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhoadonnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnccBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkey
            // 
            this.txtkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkey.Location = new System.Drawing.Point(868, 18);
            this.txtkey.Margin = new System.Windows.Forms.Padding(2);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(104, 20);
            this.txtkey.TabIndex = 24;
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(808, 19);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(56, 19);
            this.timkiem.TabIndex = 23;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // dong
            // 
            this.dong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dong.Location = new System.Drawing.Point(181, 375);
            this.dong.Margin = new System.Windows.Forms.Padding(2);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(85, 42);
            this.dong.TabIndex = 22;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = false;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xoa.Location = new System.Drawing.Point(32, 375);
            this.xoa.Margin = new System.Windows.Forms.Padding(2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(88, 42);
            this.xoa.TabIndex = 21;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sua.Location = new System.Drawing.Point(181, 326);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(85, 45);
            this.sua.TabIndex = 20;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ControlDark;
            this.them.Location = new System.Drawing.Point(32, 326);
            this.them.Margin = new System.Windows.Forms.Padding(2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(88, 45);
            this.them.TabIndex = 19;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_sanpham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(354, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(681, 460);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sản Phẩm";
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.mancc,
            this.tenncc,
            this.soluong,
            this.ngaynhap,
            this.gianhap});
            this.dgv_sanpham.Location = new System.Drawing.Point(0, 18);
            this.dgv_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.RowTemplate.Height = 24;
            this.dgv_sanpham.Size = new System.Drawing.Size(681, 438);
            this.dgv_sanpham.TabIndex = 0;
            this.dgv_sanpham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_RowEnter);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.Name = "tensp";
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã Nhà Cung Cấp";
            this.mancc.Name = "mancc";
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Tên Nhà Cung Cấp";
            this.tenncc.Name = "tenncc";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.Name = "gianhap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbgianhap);
            this.groupBox1.Controls.Add(this.cbngaynhap);
            this.groupBox1.Controls.Add(this.cbsoluong);
            this.groupBox1.Controls.Add(this.cbtsp);
            this.groupBox1.Controls.Add(this.cbmsp);
            this.groupBox1.Controls.Add(this.cbmncc);
            this.groupBox1.Controls.Add(this.dong);
            this.groupBox1.Controls.Add(this.cbtncc);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(296, 447);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // cbgianhap
            // 
            this.cbgianhap.DataSource = this.qlhoadonnhapBindingSource;
            this.cbgianhap.DisplayMember = "dongia";
            this.cbgianhap.FormattingEnabled = true;
            this.cbgianhap.Location = new System.Drawing.Point(120, 264);
            this.cbgianhap.Name = "cbgianhap";
            this.cbgianhap.Size = new System.Drawing.Size(160, 21);
            this.cbgianhap.TabIndex = 27;
            // 
            // qlhoadonnhapBindingSource
            // 
            this.qlhoadonnhapBindingSource.DataMember = "ql_hoadonnhap";
            this.qlhoadonnhapBindingSource.DataSource = this.qL_banhangDataSet8;
            // 
            // qL_banhangDataSet8
            // 
            this.qL_banhangDataSet8.DataSetName = "QL_banhangDataSet8";
            this.qL_banhangDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbngaynhap
            // 
            this.cbngaynhap.DataSource = this.qlhoadonnhapBindingSource;
            this.cbngaynhap.DisplayMember = "ngaylaphd";
            this.cbngaynhap.FormattingEnabled = true;
            this.cbngaynhap.Location = new System.Drawing.Point(120, 219);
            this.cbngaynhap.Name = "cbngaynhap";
            this.cbngaynhap.Size = new System.Drawing.Size(160, 21);
            this.cbngaynhap.TabIndex = 26;
            // 
            // cbsoluong
            // 
            this.cbsoluong.DataSource = this.qlhoadonnhapBindingSource;
            this.cbsoluong.DisplayMember = "soluong";
            this.cbsoluong.FormattingEnabled = true;
            this.cbsoluong.Location = new System.Drawing.Point(120, 179);
            this.cbsoluong.Name = "cbsoluong";
            this.cbsoluong.Size = new System.Drawing.Size(160, 21);
            this.cbsoluong.TabIndex = 25;
            // 
            // cbtsp
            // 
            this.cbtsp.DataSource = this.qlhoadonnhapBindingSource;
            this.cbtsp.DisplayMember = "tensp";
            this.cbtsp.FormattingEnabled = true;
            this.cbtsp.Location = new System.Drawing.Point(120, 64);
            this.cbtsp.Name = "cbtsp";
            this.cbtsp.Size = new System.Drawing.Size(121, 21);
            this.cbtsp.TabIndex = 24;
            // 
            // cbmsp
            // 
            this.cbmsp.DataSource = this.qlhoadonnhapBindingSource;
            this.cbmsp.DisplayMember = "masp";
            this.cbmsp.FormattingEnabled = true;
            this.cbmsp.Location = new System.Drawing.Point(120, 29);
            this.cbmsp.Name = "cbmsp";
            this.cbmsp.Size = new System.Drawing.Size(121, 21);
            this.cbmsp.TabIndex = 23;
            // 
            // cbmncc
            // 
            this.cbmncc.DataSource = this.qlhoadonnhapBindingSource;
            this.cbmncc.DisplayMember = "mancc";
            this.cbmncc.FormattingEnabled = true;
            this.cbmncc.Location = new System.Drawing.Point(120, 109);
            this.cbmncc.Name = "cbmncc";
            this.cbmncc.Size = new System.Drawing.Size(160, 21);
            this.cbmncc.TabIndex = 10;
            // 
            // cbtncc
            // 
            this.cbtncc.DataSource = this.qlhoadonnhapBindingSource;
            this.cbtncc.DisplayMember = "tenncc";
            this.cbtncc.FormattingEnabled = true;
            this.cbtncc.ItemHeight = 13;
            this.cbtncc.Location = new System.Drawing.Point(120, 142);
            this.cbtncc.Name = "cbtncc";
            this.cbtncc.Size = new System.Drawing.Size(160, 21);
            this.cbtncc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // qlnccBindingSource
            // 
            this.qlnccBindingSource.DataMember = "ql_ncc";
            this.qlnccBindingSource.DataSource = this.qL_banhangDataSet;
            // 
            // qL_banhangDataSet
            // 
            this.qL_banhangDataSet.DataSetName = "QL_banhangDataSet";
            this.qL_banhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ql_nccTableAdapter
            // 
            this.ql_nccTableAdapter.ClearBeforeFill = true;
            // 
            // qL_banhangDataSet2
            // 
            this.qL_banhangDataSet2.DataSetName = "QL_banhangDataSet2";
            this.qL_banhangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlnccBindingSource1
            // 
            this.qlnccBindingSource1.DataMember = "ql_ncc";
            this.qlnccBindingSource1.DataSource = this.qL_banhangDataSet2;
            // 
            // ql_nccTableAdapter1
            // 
            this.ql_nccTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(316, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // ql_hoadonnhapTableAdapter
            // 
            this.ql_hoadonnhapTableAdapter.ClearBeforeFill = true;
            // 
            // F_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1088, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_sanpham";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.F_sanpham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhoadonnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_banhangDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnccBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtncc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QL_banhangDataSet qL_banhangDataSet;
        private System.Windows.Forms.BindingSource qlnccBindingSource;
        private QL_banhangDataSetTableAdapters.ql_nccTableAdapter ql_nccTableAdapter;
        private QL_banhangDataSet2 qL_banhangDataSet2;
        private System.Windows.Forms.BindingSource qlnccBindingSource1;
        private QL_banhangDataSet2TableAdapters.ql_nccTableAdapter ql_nccTableAdapter1;
        private System.Windows.Forms.ComboBox cbmncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtsp;
        private System.Windows.Forms.ComboBox cbmsp;
        private QL_banhangDataSet8 qL_banhangDataSet8;
        private System.Windows.Forms.BindingSource qlhoadonnhapBindingSource;
        private QL_banhangDataSet8TableAdapters.ql_hoadonnhapTableAdapter ql_hoadonnhapTableAdapter;
        private System.Windows.Forms.ComboBox cbsoluong;
        private System.Windows.Forms.ComboBox cbgianhap;
        private System.Windows.Forms.ComboBox cbngaynhap;
    }
}