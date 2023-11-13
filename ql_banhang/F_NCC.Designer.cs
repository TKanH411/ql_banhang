namespace ql_banhang
{
    partial class F_NCC
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dong = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmncc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkey
            // 
            this.txtkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkey.Location = new System.Drawing.Point(733, 52);
            this.txtkey.Margin = new System.Windows.Forms.Padding(2);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(90, 20);
            this.txtkey.TabIndex = 17;
            // 
            // timkiem
            // 
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(673, 53);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(56, 19);
            this.timkiem.TabIndex = 16;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ncc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(377, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(468, 380);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.diachi,
            this.ghichu});
            this.dgv_ncc.Location = new System.Drawing.Point(5, 18);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.Size = new System.Drawing.Size(441, 357);
            this.dgv_ncc.TabIndex = 0;
            this.dgv_ncc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ncc_RowEnter);
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
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            // 
            // dong
            // 
            this.dong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dong.Location = new System.Drawing.Point(260, 410);
            this.dong.Margin = new System.Windows.Forms.Padding(2);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(104, 46);
            this.dong.TabIndex = 14;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = false;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(83, 410);
            this.xoa.Margin = new System.Windows.Forms.Padding(2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(102, 47);
            this.xoa.TabIndex = 13;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(260, 347);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(102, 47);
            this.sua.TabIndex = 12;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ControlDark;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(84, 347);
            this.them.Margin = new System.Windows.Forms.Padding(2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(101, 47);
            this.them.TabIndex = 11;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenncc);
            this.groupBox1.Controls.Add(this.txtmncc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(298, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(130, 155);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(144, 20);
            this.txtghichu.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(130, 111);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(144, 20);
            this.txtdiachi.TabIndex = 7;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(130, 78);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(2);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(144, 20);
            this.txttenncc.TabIndex = 6;
            // 
            // txtmncc
            // 
            this.txtmncc.Location = new System.Drawing.Point(130, 47);
            this.txtmncc.Margin = new System.Windows.Forms.Padding(2);
            this.txtmncc.Name = "txtmncc";
            this.txtmncc.Size = new System.Drawing.Size(76, 20);
            this.txtmncc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(303, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // F_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1073, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_NCC";
            this.Load += new System.EventHandler(this.F_NCC_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Label label1;
    }
}

