namespace PRL
{
    partial class banhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banhang));
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            lbl_TienAddVoucher = new Label();
            label3 = new Label();
            cmbx_hoadoncho = new ComboBox();
            btn_huy = new Button();
            btn_thanhtoan = new Button();
            lblTienThua = new Label();
            label11 = new Label();
            txt_tienkhachdua = new TextBox();
            label9 = new Label();
            lblTongTien = new Label();
            lbl = new Label();
            txt_maVoucher = new TextBox();
            label6 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            btn_TaoHoaDon = new Button();
            txt_tenkhachhang = new TextBox();
            label2 = new Label();
            txt_SDT = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgView_hoadon = new DataGridView();
            groupBox4 = new GroupBox();
            btn_timkiem = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            cbb_size = new ComboBox();
            cbb_mausac = new ComboBox();
            cbb_hang = new ComboBox();
            txt_search = new TextBox();
            dtgView_danhsachsanpham = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_hoadon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_danhsachsanpham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Wheat;
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(339, 663);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đơn Hàng";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Snow;
            groupBox6.Controls.Add(lbl_TienAddVoucher);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(cmbx_hoadoncho);
            groupBox6.Controls.Add(btn_huy);
            groupBox6.Controls.Add(btn_thanhtoan);
            groupBox6.Controls.Add(lblTienThua);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(txt_tienkhachdua);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(lblTongTien);
            groupBox6.Controls.Add(lbl);
            groupBox6.Controls.Add(txt_maVoucher);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label4);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox6.Location = new Point(3, 221);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(333, 440);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thông Tin Hóa Đơn";
            // 
            // lbl_TienAddVoucher
            // 
            lbl_TienAddVoucher.AutoSize = true;
            lbl_TienAddVoucher.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TienAddVoucher.Location = new Point(152, 223);
            lbl_TienAddVoucher.Name = "lbl_TienAddVoucher";
            lbl_TienAddVoucher.Size = new Size(30, 24);
            lbl_TienAddVoucher.TabIndex = 20;
            lbl_TienAddVoucher.Text = "....";
            lbl_TienAddVoucher.Click += lbl_TienAddVoucher_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 227);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 19;
            label3.Text = "Tổng Hóa Đơn ";
            // 
            // cmbx_hoadoncho
            // 
            cmbx_hoadoncho.FormattingEnabled = true;
            cmbx_hoadoncho.Location = new Point(25, 59);
            cmbx_hoadoncho.Margin = new Padding(3, 2, 3, 2);
            cmbx_hoadoncho.Name = "cmbx_hoadoncho";
            cmbx_hoadoncho.Size = new Size(204, 25);
            cmbx_hoadoncho.TabIndex = 18;
            cmbx_hoadoncho.SelectedIndexChanged += cmbx_hoadoncho_SelectedIndexChanged;
            // 
            // btn_huy
            // 
            btn_huy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_huy.ImageAlign = ContentAlignment.MiddleLeft;
            btn_huy.Location = new Point(180, 378);
            btn_huy.Margin = new Padding(3, 2, 3, 2);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(116, 33);
            btn_huy.TabIndex = 17;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thanhtoan.Location = new Point(21, 378);
            btn_thanhtoan.Margin = new Padding(3, 2, 3, 2);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(121, 33);
            btn_thanhtoan.TabIndex = 16;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTienThua.Location = new Point(129, 334);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(35, 24);
            lblTienThua.TabIndex = 15;
            lblTienThua.Text = ".....";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(25, 334);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 14;
            label11.Text = "Tiền Thừa";
            // 
            // txt_tienkhachdua
            // 
            txt_tienkhachdua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tienkhachdua.Location = new Point(28, 287);
            txt_tienkhachdua.Margin = new Padding(3, 2, 3, 2);
            txt_tienkhachdua.Name = "txt_tienkhachdua";
            txt_tienkhachdua.Size = new Size(204, 26);
            txt_tienkhachdua.TabIndex = 13;
            txt_tienkhachdua.TextChanged += txt_tienkhachdua_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(28, 265);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 12;
            label9.Text = "Tiền Khách Đưa";
            label9.Click += label9_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTien.Location = new Point(124, 184);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(25, 24);
            lblTongTien.TabIndex = 11;
            lblTongTien.Text = "...";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(21, 188);
            lbl.Name = "lbl";
            lbl.Size = new Size(79, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Tổng Tiền";
            // 
            // txt_maVoucher
            // 
            txt_maVoucher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_maVoucher.Location = new Point(25, 120);
            txt_maVoucher.Margin = new Padding(3, 2, 3, 2);
            txt_maVoucher.Name = "txt_maVoucher";
            txt_maVoucher.Size = new Size(204, 26);
            txt_maVoucher.TabIndex = 9;
            txt_maVoucher.TextChanged += txt_maVoucher_TextChanged;
            txt_maVoucher.KeyDown += txt_maVoucher_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 98);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 8;
            label6.Text = "Voucher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 37);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã Hóa Đơn";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Snow;
            groupBox5.Controls.Add(btn_TaoHoaDon);
            groupBox5.Controls.Add(txt_tenkhachhang);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txt_SDT);
            groupBox5.Controls.Add(label1);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox5.Location = new Point(3, 21);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(333, 200);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông Tin Khách Hàng";
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TaoHoaDon.Location = new Point(82, 158);
            btn_TaoHoaDon.Margin = new Padding(3, 2, 3, 2);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(157, 27);
            btn_TaoHoaDon.TabIndex = 4;
            btn_TaoHoaDon.Text = "Tạo Hóa Đơn";
            btn_TaoHoaDon.UseVisualStyleBackColor = true;
            btn_TaoHoaDon.Click += button2_Click;
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenkhachhang.Location = new Point(25, 107);
            txt_tenkhachhang.Margin = new Padding(3, 2, 3, 2);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.Size = new Size(204, 26);
            txt_tenkhachhang.TabIndex = 3;
            txt_tenkhachhang.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng";
            label2.Click += label2_Click_1;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(25, 53);
            txt_SDT.Margin = new Padding(3, 2, 3, 2);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(204, 26);
            txt_SDT.TabIndex = 1;
            txt_SDT.KeyDown += txt_SDT_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "SĐT";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dtgView_hoadon);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(339, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(926, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chờ";
            // 
            // dtgView_hoadon
            // 
            dtgView_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_hoadon.BackgroundColor = Color.Wheat;
            dtgView_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_hoadon.Dock = DockStyle.Fill;
            dtgView_hoadon.Location = new Point(3, 19);
            dtgView_hoadon.Margin = new Padding(3, 2, 3, 2);
            dtgView_hoadon.Name = "dtgView_hoadon";
            dtgView_hoadon.RowHeadersWidth = 51;
            dtgView_hoadon.RowTemplate.Height = 29;
            dtgView_hoadon.Size = new Size(920, 259);
            dtgView_hoadon.TabIndex = 0;
            dtgView_hoadon.CellContentClick += dtgView_hoadon_CellContentClick;
            dtgView_hoadon.CellDoubleClick += dtgView_hoadon_CellDoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(btn_timkiem);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cbb_size);
            groupBox4.Controls.Add(cbb_mausac);
            groupBox4.Controls.Add(cbb_hang);
            groupBox4.Controls.Add(txt_search);
            groupBox4.Controls.Add(dtgView_danhsachsanpham);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(339, 280);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(926, 387);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Sách Sản Phẩm";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Image = Properties.Resources.Search3;
            btn_timkiem.Location = new Point(214, 31);
            btn_timkiem.Margin = new Padding(3, 2, 3, 2);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(77, 37);
            btn_timkiem.TabIndex = 17;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(729, 36);
            label14.Name = "label14";
            label14.Size = new Size(37, 18);
            label14.TabIndex = 11;
            label14.Text = "Size";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(505, 36);
            label13.Name = "label13";
            label13.Size = new Size(67, 18);
            label13.TabIndex = 10;
            label13.Text = "Màu Sắc";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 36);
            label12.Name = "label12";
            label12.Size = new Size(43, 18);
            label12.TabIndex = 9;
            label12.Text = "Hãng";
            // 
            // cbb_size
            // 
            cbb_size.FormattingEnabled = true;
            cbb_size.Location = new Point(773, 34);
            cbb_size.Margin = new Padding(3, 2, 3, 2);
            cbb_size.Name = "cbb_size";
            cbb_size.Size = new Size(133, 25);
            cbb_size.TabIndex = 6;
            cbb_size.DropDown += cbb_size_DropDown;
            cbb_size.SelectedIndexChanged += cbb_size_SelectedIndexChanged;
            // 
            // cbb_mausac
            // 
            cbb_mausac.FormattingEnabled = true;
            cbb_mausac.Location = new Point(580, 34);
            cbb_mausac.Margin = new Padding(3, 2, 3, 2);
            cbb_mausac.Name = "cbb_mausac";
            cbb_mausac.Size = new Size(133, 25);
            cbb_mausac.TabIndex = 5;
            cbb_mausac.DropDown += cbb_mausac_DropDown;
            cbb_mausac.SelectedIndexChanged += cbb_mausac_SelectedIndexChanged;
            // 
            // cbb_hang
            // 
            cbb_hang.FormattingEnabled = true;
            cbb_hang.Location = new Point(368, 34);
            cbb_hang.Margin = new Padding(3, 2, 3, 2);
            cbb_hang.Name = "cbb_hang";
            cbb_hang.Size = new Size(133, 25);
            cbb_hang.TabIndex = 4;
            cbb_hang.DropDown += cbb_hang_DropDown;
            cbb_hang.SelectedIndexChanged += cbb_hang_SelectedIndexChanged;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(24, 34);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(174, 24);
            txt_search.TabIndex = 3;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // dtgView_danhsachsanpham
            // 
            dtgView_danhsachsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_danhsachsanpham.BackgroundColor = Color.Wheat;
            dtgView_danhsachsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_danhsachsanpham.Dock = DockStyle.Bottom;
            dtgView_danhsachsanpham.Location = new Point(3, 85);
            dtgView_danhsachsanpham.Margin = new Padding(3, 2, 3, 2);
            dtgView_danhsachsanpham.Name = "dtgView_danhsachsanpham";
            dtgView_danhsachsanpham.RowHeadersWidth = 51;
            dtgView_danhsachsanpham.RowTemplate.Height = 29;
            dtgView_danhsachsanpham.Size = new Size(920, 300);
            dtgView_danhsachsanpham.TabIndex = 2;
            dtgView_danhsachsanpham.CellClick += dtgView_danhsachsanpham_CellClick;
            dtgView_danhsachsanpham.CellDoubleClick += dtgView_danhsachsanpham_CellDoubleClick;
            // 
            // banhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 663);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "banhang";
            Text = "banhang";
            Load += banhang_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_hoadon).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_danhsachsanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgView_hoadon;
        private GroupBox groupBox4;
        private TextBox txt_search;
        private DataGridView dtgView_danhsachsanpham;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button btn_TaoHoaDon;
        private TextBox txt_tenkhachhang;
        private Label label2;
        private TextBox txt_SDT;
        private Label label1;
        private TextBox txt_tienkhachdua;
        private Label label9;
        private Label lblTongTien;
        private Label lbl;
        private TextBox txt_maVoucher;
        private Label label6;
        private Label label4;
        private Label lblTienThua;
        private Label label11;
        private Button btn_huy;
        private Button btn_thanhtoan;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox cbb_size;
        private ComboBox cbb_mausac;
        private ComboBox cbb_hang;
        private Button btn_timkiem;
        private ComboBox cmbx_hoadoncho;
        private Label label3;
        private Label lbl_TienAddVoucher;
    }
}