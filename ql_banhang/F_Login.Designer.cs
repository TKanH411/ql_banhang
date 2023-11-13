namespace ql_banhang
{
    partial class F_Login
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.banhangDataSet1 = new ql_banhang.banhangDataSet();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banhangDataSet1)).BeginInit();
            this.grbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 267);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(382, 8);
            this.pnlBottom.TabIndex = 20;
            // 
            // banhangDataSet1
            // 
            this.banhangDataSet1.DataSetName = "banhangDataSet";
            this.banhangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbContent
            // 
            this.grbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grbContent.BackgroundImage = global::ql_banhang.Properties.Resources._3;
            this.grbContent.Controls.Add(this.label1);
            this.grbContent.Controls.Add(this.btnCancel);
            this.grbContent.Controls.Add(this.btnLogin);
            this.grbContent.Controls.Add(this.txtmk);
            this.grbContent.Controls.Add(this.txttk);
            this.grbContent.Controls.Add(this.label2);
            this.grbContent.Controls.Add(this.label3);
            this.grbContent.Location = new System.Drawing.Point(2, 0);
            this.grbContent.Margin = new System.Windows.Forms.Padding(2);
            this.grbContent.Name = "grbContent";
            this.grbContent.Padding = new System.Windows.Forms.Padding(2);
            this.grbContent.Size = new System.Drawing.Size(377, 277);
            this.grbContent.TabIndex = 21;
            this.grbContent.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập Hệ Thông";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(201, 184);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.Location = new System.Drawing.Point(89, 184);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtmk
            // 
            this.txtmk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmk.Location = new System.Drawing.Point(138, 120);
            this.txtmk.Margin = new System.Windows.Forms.Padding(2);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(188, 20);
            this.txtmk.TabIndex = 5;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttk.Location = new System.Drawing.Point(138, 86);
            this.txttk.Margin = new System.Windows.Forms.Padding(2);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(188, 20);
            this.txttk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 275);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.pnlBottom);
            this.Name = "F_Login";
            this.Text = "F_Login";
            ((System.ComponentModel.ISupportInitialize)(this.banhangDataSet1)).EndInit();
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label1;
        private banhangDataSet banhangDataSet1;
    }
}