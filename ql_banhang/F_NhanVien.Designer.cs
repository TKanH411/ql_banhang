namespace ql_banhang
{
    partial class F_NhanVien
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
            this.txtkey = new System.Windows.Forms.TextBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(704, 88);
            this.txtkey.Margin = new System.Windows.Forms.Padding(2);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(94, 20);
            this.txtkey.TabIndex = 18;
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(628, 83);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(69, 28);
            this.timkiem.TabIndex = 17;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // dong
            // 
            this.dong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dong.Location = new System.Drawing.Point(163, 354);
            this.dong.Margin = new System.Windows.Forms.Padding(2);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(92, 34);
            this.dong.TabIndex = 16;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = false;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(15, 348);
            this.xoa.Margin = new System.Windows.Forms.Padding(2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(95, 40);
            this.xoa.TabIndex = 15;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(163, 306);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(92, 38);
            this.sua.TabIndex = 14;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ControlDark;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(13, 306);
            this.them.Margin = new System.Windows.Forms.Padding(2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 38);
            this.them.TabIndex = 13;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_nhanvien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(392, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(556, 404);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgv_nhanvien.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_nhanvien.Location = new System.Drawing.Point(4, 20);
            this.dgv_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.Height = 24;
            this.dgv_nhanvien.Size = new System.Drawing.Size(552, 372);
            this.dgv_nhanvien.TabIndex = 0;
            this.dgv_nhanvien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manv";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tennv";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioitinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaysinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "diachi";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dienthoai";
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datengaysinh);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.dong);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.txtgioitinh);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(308, 401);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(120, 162);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(150, 23);
            this.datengaysinh.TabIndex = 17;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(120, 258);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(150, 23);
            this.txtdienthoai.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(120, 210);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(150, 23);
            this.txtdiachi.TabIndex = 10;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(120, 117);
            this.txtgioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(150, 23);
            this.txtgioitinh.TabIndex = 8;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(120, 78);
            this.txttennv.Margin = new System.Windows.Forms.Padding(2);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(150, 23);
            this.txttennv.TabIndex = 7;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(120, 37);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(150, 23);
            this.txtmanv.TabIndex = 6;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // F_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 530);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "F_NhanVien";
            this.Load += new System.EventHandler(this.F_NhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker datengaysinh;
    }
}