namespace PRL
{
    partial class nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhanvien));
            groupBox3 = new GroupBox();
            dtgView_nhanvien = new DataGridView();
            groupBox2 = new GroupBox();
            btn_loc = new Button();
            txt_search = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txt_matkhau = new TextBox();
            label12 = new Label();
            txt_taikhoan = new TextBox();
            label11 = new Label();
            txt_manhanvien = new TextBox();
            label10 = new Label();
            cmbx_trangthai = new ComboBox();
            rbtn_nu = new RadioButton();
            rbtn_nam = new RadioButton();
            txt_gmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            cmbx_chucvu = new ComboBox();
            label4 = new Label();
            dtp_ngaydangky = new DateTimePicker();
            txt_sdt = new TextBox();
            btn_lammoi = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            label5 = new Label();
            txt_diachi = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_tennhanvien = new TextBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_nhanvien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(dtgView_nhanvien);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(471, 118);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(707, 544);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Nhân Viên";
            // 
            // dtgView_nhanvien
            // 
            dtgView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_nhanvien.BackgroundColor = Color.Wheat;
            dtgView_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_nhanvien.Dock = DockStyle.Fill;
            dtgView_nhanvien.Location = new Point(3, 18);
            dtgView_nhanvien.Margin = new Padding(3, 2, 3, 2);
            dtgView_nhanvien.Name = "dtgView_nhanvien";
            dtgView_nhanvien.RowHeadersWidth = 51;
            dtgView_nhanvien.RowTemplate.Height = 29;
            dtgView_nhanvien.Size = new Size(701, 524);
            dtgView_nhanvien.TabIndex = 0;
            dtgView_nhanvien.CellClick += dtgView_nhanvien_CellClick_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Wheat;
            groupBox2.Controls.Add(btn_loc);
            groupBox2.Controls.Add(txt_search);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(471, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(707, 118);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ Lọc";
            // 
            // btn_loc
            // 
            btn_loc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_loc.Location = new Point(354, 53);
            btn_loc.Margin = new Padding(3, 2, 3, 2);
            btn_loc.Name = "btn_loc";
            btn_loc.Size = new Size(97, 32);
            btn_loc.TabIndex = 18;
            btn_loc.Text = "Lọc";
            btn_loc.UseVisualStyleBackColor = true;
            btn_loc.Click += btn_loc_Click;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(85, 59);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(222, 23);
            txt_search.TabIndex = 3;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(85, 34);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 2;
            label7.Text = "Tên Nhân Viên";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Wheat;
            groupBox1.Controls.Add(txt_matkhau);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_taikhoan);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_manhanvien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbx_trangthai);
            groupBox1.Controls.Add(rbtn_nu);
            groupBox1.Controls.Add(rbtn_nam);
            groupBox1.Controls.Add(txt_gmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbx_chucvu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtp_ngaydangky);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_diachi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_tennhanvien);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(471, 662);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_matkhau.Location = new Point(162, 568);
            txt_matkhau.Margin = new Padding(3, 2, 3, 2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(262, 23);
            txt_matkhau.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(69, 571);
            label12.Name = "label12";
            label12.Size = new Size(68, 17);
            label12.TabIndex = 44;
            label12.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_taikhoan.Location = new Point(162, 522);
            txt_taikhoan.Margin = new Padding(3, 2, 3, 2);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(262, 23);
            txt_taikhoan.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(66, 524);
            label11.Name = "label11";
            label11.Size = new Size(73, 17);
            label11.TabIndex = 42;
            label11.Text = "Tài Khoản";
            // 
            // txt_manhanvien
            // 
            txt_manhanvien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_manhanvien.Location = new Point(162, 34);
            txt_manhanvien.Margin = new Padding(3, 2, 3, 2);
            txt_manhanvien.Name = "txt_manhanvien";
            txt_manhanvien.Size = new Size(262, 23);
            txt_manhanvien.TabIndex = 41;
            txt_manhanvien.TextChanged += txt_manhanvien_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(35, 36);
            label10.Name = "label10";
            label10.Size = new Size(97, 17);
            label10.TabIndex = 40;
            label10.Text = "Mã Nhân Viên";
            // 
            // cmbx_trangthai
            // 
            cmbx_trangthai.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbx_trangthai.FormattingEnabled = true;
            cmbx_trangthai.Location = new Point(162, 470);
            cmbx_trangthai.Margin = new Padding(3, 2, 3, 2);
            cmbx_trangthai.Name = "cmbx_trangthai";
            cmbx_trangthai.Size = new Size(233, 25);
            cmbx_trangthai.TabIndex = 39;
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nu.Location = new Point(299, 139);
            rbtn_nu.Margin = new Padding(3, 2, 3, 2);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(44, 21);
            rbtn_nu.TabIndex = 38;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nữ";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nam.Location = new Point(162, 139);
            rbtn_nam.Margin = new Padding(3, 2, 3, 2);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(55, 21);
            rbtn_nam.TabIndex = 37;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // txt_gmail
            // 
            txt_gmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gmail.Location = new Point(162, 310);
            txt_gmail.Margin = new Padding(3, 2, 3, 2);
            txt_gmail.Name = "txt_gmail";
            txt_gmail.Size = new Size(262, 23);
            txt_gmail.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(93, 312);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 11;
            label9.Text = "Gmail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(65, 476);
            label8.Name = "label8";
            label8.Size = new Size(78, 17);
            label8.TabIndex = 35;
            label8.Text = "Trạng Thái";
            // 
            // cmbx_chucvu
            // 
            cmbx_chucvu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbx_chucvu.FormattingEnabled = true;
            cmbx_chucvu.Location = new Point(162, 254);
            cmbx_chucvu.Margin = new Padding(3, 2, 3, 2);
            cmbx_chucvu.Name = "cmbx_chucvu";
            cmbx_chucvu.Size = new Size(233, 25);
            cmbx_chucvu.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 195);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 33;
            label4.Text = "Ngày Sinh";
            // 
            // dtp_ngaydangky
            // 
            dtp_ngaydangky.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_ngaydangky.Location = new Point(162, 195);
            dtp_ngaydangky.Margin = new Padding(3, 2, 3, 2);
            dtp_ngaydangky.Name = "dtp_ngaydangky";
            dtp_ngaydangky.Size = new Size(233, 23);
            dtp_ngaydangky.TabIndex = 32;
            dtp_ngaydangky.Value = new DateTime(2024, 7, 16, 22, 59, 26, 0);
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sdt.Location = new Point(162, 356);
            txt_sdt.Margin = new Padding(3, 2, 3, 2);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(262, 23);
            txt_sdt.TabIndex = 18;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(312, 608);
            btn_lammoi.Margin = new Padding(3, 2, 3, 2);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(112, 35);
            btn_lammoi.TabIndex = 17;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(181, 608);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(95, 35);
            btn_sua.TabIndex = 16;
            btn_sua.Text = "Sửa ";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(48, 608);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(95, 35);
            btn_them.TabIndex = 14;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 256);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 12;
            label5.Text = "Chức Vụ";
            // 
            // txt_diachi
            // 
            txt_diachi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_diachi.Location = new Point(162, 416);
            txt_diachi.Margin = new Padding(3, 2, 3, 2);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(262, 23);
            txt_diachi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(83, 418);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 9;
            label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 358);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 8;
            label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 139);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 4;
            label2.Text = "Giới Tính";
            // 
            // txt_tennhanvien
            // 
            txt_tennhanvien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tennhanvien.Location = new Point(162, 88);
            txt_tennhanvien.Margin = new Padding(3, 2, 3, 2);
            txt_tennhanvien.Name = "txt_tennhanvien";
            txt_tennhanvien.Size = new Size(262, 23);
            txt_tennhanvien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 91);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân Viên";
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 662);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "nhanvien";
            Text = "nhanvien";
            Load += nhanvien_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_nhanvien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btn_loc;
        private TextBox txt_search;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txt_gmail;
        private Label label9;
        private Label label8;
        private ComboBox cmbx_chucvu;
        private Label label4;
        private DateTimePicker dtp_ngaydangky;
        private TextBox txt_sdt;
        private Button btn_lammoi;
        private Button btn_sua;
        private Button btn_them;
        private Label label5;
        private TextBox txt_diachi;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txt_tennhanvien;
        private Label label1;
        private RadioButton rbtn_nu;
        private RadioButton rbtn_nam;
        private DataGridView dtgView_nhanvien;
        private ComboBox cmbx_trangthai;
        private TextBox txt_manhanvien;
        private Label label10;
        private TextBox txt_matkhau;
        private Label label12;
        private TextBox txt_taikhoan;
        private Label label11;
    }
}