namespace ql_banhang
{
    partial class F_KhachHang
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
            this.timkiem = new System.Windows.Forms.Button();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.dong = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttekh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(599, 101);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(66, 24);
            this.timkiem.TabIndex = 17;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(686, 104);
            this.txtkey.Margin = new System.Windows.Forms.Padding(2);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(100, 20);
            this.txtkey.TabIndex = 12;
            // 
            // dong
            // 
            this.dong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dong.Location = new System.Drawing.Point(156, 295);
            this.dong.Margin = new System.Windows.Forms.Padding(2);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(76, 43);
            this.dong.TabIndex = 16;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = false;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(32, 295);
            this.xoa.Margin = new System.Windows.Forms.Padding(2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(77, 43);
            this.xoa.TabIndex = 15;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(156, 239);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(76, 43);
            this.sua.TabIndex = 14;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ControlDark;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(32, 239);
            this.them.Margin = new System.Windows.Forms.Padding(2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(77, 43);
            this.them.TabIndex = 13;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_khachhang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(377, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(571, 351);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgv_khachhang.Location = new System.Drawing.Point(0, 18);
            this.dgv_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.Size = new System.Drawing.Size(555, 322);
            this.dgv_khachhang.TabIndex = 0;
            this.dgv_khachhang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "makh";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenkh";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diachi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sdt";
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.dong);
            this.groupBox1.Controls.Add(this.txttekh);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(303, 353);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(142, 129);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(157, 21);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(142, 181);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(157, 21);
            this.txtsdt.TabIndex = 8;
            // 
            // txttekh
            // 
            this.txttekh.Location = new System.Drawing.Point(142, 83);
            this.txttekh.Margin = new System.Windows.Forms.Padding(2);
            this.txttekh.Name = "txttekh";
            this.txttekh.Size = new System.Drawing.Size(157, 21);
            this.txttekh.TabIndex = 5;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(142, 41);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(2);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(113, 21);
            this.txtmakh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // F_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1064, 513);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "F_KhachHang";
            this.Load += new System.EventHandler(this.F_KhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttekh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}