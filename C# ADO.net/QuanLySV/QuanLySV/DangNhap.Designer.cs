namespace QuanLySV
{
    partial class DangNhap
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
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.rbtSinhVien = new System.Windows.Forms.RadioButton();
            this.cbLuuTaiKhoan = new System.Windows.Forms.CheckBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(34, 35);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(105, 25);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(34, 88);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(99, 25);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(167, 36);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(214, 26);
            this.tbTaiKhoan.TabIndex = 2;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(167, 89);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(214, 26);
            this.tbMatKhau.TabIndex = 3;
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Location = new System.Drawing.Point(206, 312);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(79, 24);
            this.rbtAdmin.TabIndex = 4;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "Admin";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtSinhVien
            // 
            this.rbtSinhVien.AutoSize = true;
            this.rbtSinhVien.Location = new System.Drawing.Point(318, 312);
            this.rbtSinhVien.Name = "rbtSinhVien";
            this.rbtSinhVien.Size = new System.Drawing.Size(98, 24);
            this.rbtSinhVien.TabIndex = 5;
            this.rbtSinhVien.TabStop = true;
            this.rbtSinhVien.Text = "Sinh viên";
            this.rbtSinhVien.UseVisualStyleBackColor = true;
            // 
            // cbLuuTaiKhoan
            // 
            this.cbLuuTaiKhoan.AutoSize = true;
            this.cbLuuTaiKhoan.Location = new System.Drawing.Point(250, 130);
            this.cbLuuTaiKhoan.Name = "cbLuuTaiKhoan";
            this.cbLuuTaiKhoan.Size = new System.Drawing.Size(131, 24);
            this.cbLuuTaiKhoan.TabIndex = 6;
            this.cbLuuTaiKhoan.Text = "Lưu tài khoản";
            this.cbLuuTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Red;
            this.btThoat.Location = new System.Drawing.Point(268, 237);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(148, 55);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.Red;
            this.btDangNhap.Location = new System.Drawing.Point(80, 237);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(148, 55);
            this.btDangNhap.TabIndex = 8;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loại tài khoản:";
            // 
            // cbHienMatKhau
            // 
            this.cbHienMatKhau.AutoSize = true;
            this.cbHienMatKhau.Location = new System.Drawing.Point(62, 130);
            this.cbHienMatKhau.Name = "cbHienMatKhau";
            this.cbHienMatKhau.Size = new System.Drawing.Size(159, 24);
            this.cbHienMatKhau.TabIndex = 10;
            this.cbHienMatKhau.Text = "Hiển thị mật khẩu";
            this.cbHienMatKhau.UseVisualStyleBackColor = true;
            this.cbHienMatKhau.CheckedChanged += new System.EventHandler(this.cbHienMatKhau_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tbTaiKhoan);
            this.groupBox.Controls.Add(this.cbHienMatKhau);
            this.groupBox.Controls.Add(this.lbTaiKhoan);
            this.groupBox.Controls.Add(this.lbMatKhau);
            this.groupBox.Controls.Add(this.tbMatKhau);
            this.groupBox.Controls.Add(this.cbLuuTaiKhoan);
            this.groupBox.Location = new System.Drawing.Point(18, 40);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(430, 175);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nhập tài khoản và mật khẩu";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(476, 357);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.rbtSinhVien);
            this.Controls.Add(this.rbtAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.RadioButton rbtAdmin;
        private System.Windows.Forms.RadioButton rbtSinhVien;
        private System.Windows.Forms.CheckBox cbLuuTaiKhoan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHienMatKhau;
        private System.Windows.Forms.GroupBox groupBox;
    }
}