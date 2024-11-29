namespace DuAn1_NHOM6
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            panel_left = new Panel();
            btn_thietlap = new Button();
            btn_khachhang = new Button();
            btn_nhanvien = new Button();
            btn_thongke = new Button();
            btn_voucher = new Button();
            btn_sanpham = new Button();
            btn_hoadon = new Button();
            btn_banhang = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            lblten = new Label();
            lblquyen = new Label();
            label1 = new Label();
            panel_body = new Panel();
            pictureBox2 = new PictureBox();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.Black;
            panel_left.Controls.Add(btn_thietlap);
            panel_left.Controls.Add(btn_khachhang);
            panel_left.Controls.Add(btn_nhanvien);
            panel_left.Controls.Add(btn_thongke);
            panel_left.Controls.Add(btn_voucher);
            panel_left.Controls.Add(btn_sanpham);
            panel_left.Controls.Add(btn_hoadon);
            panel_left.Controls.Add(btn_banhang);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Margin = new Padding(3, 2, 3, 2);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(186, 620);
            panel_left.TabIndex = 0;
            // 
            // btn_thietlap
            // 
            btn_thietlap.BackColor = Color.Black;
            btn_thietlap.Dock = DockStyle.Top;
            btn_thietlap.FlatAppearance.BorderSize = 0;
            btn_thietlap.FlatStyle = FlatStyle.Flat;
            btn_thietlap.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thietlap.ForeColor = SystemColors.Control;
            btn_thietlap.Image = PRL.Properties.Resources.banhxe;
            btn_thietlap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thietlap.Location = new Point(0, 544);
            btn_thietlap.Margin = new Padding(3, 2, 3, 2);
            btn_thietlap.Name = "btn_thietlap";
            btn_thietlap.Size = new Size(186, 58);
            btn_thietlap.TabIndex = 7;
            btn_thietlap.Text = "Đăng Xuất";
            btn_thietlap.UseVisualStyleBackColor = false;
            btn_thietlap.Click += btn_thietlap_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.BackColor = Color.Black;
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.FlatAppearance.BorderSize = 0;
            btn_khachhang.FlatStyle = FlatStyle.Flat;
            btn_khachhang.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khachhang.ForeColor = SystemColors.Control;
            btn_khachhang.Image = PRL.Properties.Resources.multiple_users_silhouette;
            btn_khachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khachhang.Location = new Point(0, 486);
            btn_khachhang.Margin = new Padding(3, 2, 3, 2);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(186, 58);
            btn_khachhang.TabIndex = 6;
            btn_khachhang.Text = "Khách Hàng";
            btn_khachhang.UseVisualStyleBackColor = false;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.BackColor = Color.Black;
            btn_nhanvien.Dock = DockStyle.Top;
            btn_nhanvien.FlatAppearance.BorderSize = 0;
            btn_nhanvien.FlatStyle = FlatStyle.Flat;
            btn_nhanvien.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.ForeColor = SystemColors.Control;
            btn_nhanvien.Image = PRL.Properties.Resources.user__1_;
            btn_nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nhanvien.Location = new Point(0, 428);
            btn_nhanvien.Margin = new Padding(3, 2, 3, 2);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(186, 58);
            btn_nhanvien.TabIndex = 5;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = false;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.BackColor = Color.Black;
            btn_thongke.Dock = DockStyle.Top;
            btn_thongke.FlatAppearance.BorderSize = 0;
            btn_thongke.FlatStyle = FlatStyle.Flat;
            btn_thongke.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongke.ForeColor = SystemColors.Control;
            btn_thongke.Image = PRL.Properties.Resources.icons8_sales_50;
            btn_thongke.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongke.Location = new Point(0, 370);
            btn_thongke.Margin = new Padding(3, 2, 3, 2);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(186, 58);
            btn_thongke.TabIndex = 4;
            btn_thongke.Text = "Thông Kê";
            btn_thongke.UseVisualStyleBackColor = false;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // btn_voucher
            // 
            btn_voucher.BackColor = Color.Black;
            btn_voucher.Dock = DockStyle.Top;
            btn_voucher.FlatAppearance.BorderSize = 0;
            btn_voucher.FlatStyle = FlatStyle.Flat;
            btn_voucher.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_voucher.ForeColor = SystemColors.Control;
            btn_voucher.Image = PRL.Properties.Resources.discount;
            btn_voucher.ImageAlign = ContentAlignment.MiddleLeft;
            btn_voucher.Location = new Point(0, 312);
            btn_voucher.Margin = new Padding(3, 2, 3, 2);
            btn_voucher.Name = "btn_voucher";
            btn_voucher.Size = new Size(186, 58);
            btn_voucher.TabIndex = 3;
            btn_voucher.Text = "Voucher";
            btn_voucher.UseVisualStyleBackColor = false;
            btn_voucher.Click += button3_Click;
            // 
            // btn_sanpham
            // 
            btn_sanpham.BackColor = Color.Black;
            btn_sanpham.Dock = DockStyle.Top;
            btn_sanpham.FlatAppearance.BorderSize = 0;
            btn_sanpham.FlatStyle = FlatStyle.Flat;
            btn_sanpham.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.ForeColor = SystemColors.Control;
            btn_sanpham.Image = PRL.Properties.Resources.package;
            btn_sanpham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sanpham.Location = new Point(0, 254);
            btn_sanpham.Margin = new Padding(3, 2, 3, 2);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(186, 58);
            btn_sanpham.TabIndex = 2;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = false;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.BackColor = Color.Black;
            btn_hoadon.Dock = DockStyle.Top;
            btn_hoadon.FlatAppearance.BorderSize = 0;
            btn_hoadon.FlatStyle = FlatStyle.Flat;
            btn_hoadon.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.ForeColor = SystemColors.Control;
            btn_hoadon.Image = PRL.Properties.Resources.bill;
            btn_hoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoadon.Location = new Point(0, 196);
            btn_hoadon.Margin = new Padding(3, 2, 3, 2);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(186, 58);
            btn_hoadon.TabIndex = 1;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.BackColor = Color.Black;
            btn_banhang.Dock = DockStyle.Top;
            btn_banhang.FlatAppearance.BorderSize = 0;
            btn_banhang.FlatStyle = FlatStyle.Flat;
            btn_banhang.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_banhang.ForeColor = SystemColors.Control;
            btn_banhang.Image = (Image)resources.GetObject("btn_banhang.Image");
            btn_banhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_banhang.Location = new Point(0, 138);
            btn_banhang.Margin = new Padding(3, 2, 3, 2);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(186, 58);
            btn_banhang.TabIndex = 0;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = false;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(165, 215, 250);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.LightCoral;
            panel_top.BackgroundImage = (Image)resources.GetObject("panel_top.BackgroundImage");
            panel_top.Controls.Add(lblten);
            panel_top.Controls.Add(lblquyen);
            panel_top.Controls.Add(label1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(186, 0);
            panel_top.Margin = new Padding(3, 2, 3, 2);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1083, 76);
            panel_top.TabIndex = 1;
            // 
            // lblten
            // 
            lblten.AutoSize = true;
            lblten.BackColor = Color.Black;
            lblten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblten.ForeColor = SystemColors.Control;
            lblten.Location = new Point(621, 28);
            lblten.Name = "lblten";
            lblten.Size = new Size(36, 20);
            lblten.TabIndex = 13;
            lblten.Text = "Tên";
            // 
            // lblquyen
            // 
            lblquyen.AutoSize = true;
            lblquyen.BackColor = Color.Black;
            lblquyen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblquyen.ForeColor = SystemColors.Control;
            lblquyen.Location = new Point(354, 28);
            lblquyen.Name = "lblquyen";
            lblquyen.Size = new Size(55, 20);
            lblquyen.TabIndex = 12;
            lblquyen.Text = "Quyền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panel_body
            // 
            panel_body.BackColor = SystemColors.Control;
            panel_body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_body.Controls.Add(pictureBox2);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(186, 76);
            panel_body.Margin = new Padding(3, 2, 3, 2);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1083, 544);
            panel_body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1083, 544);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 620);
            Controls.Add(panel_body);
            Controls.Add(panel_top);
            Controls.Add(panel_left);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "home";
            Text = "home";
            FormClosed += home_FormClosed;
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_top;
        private PictureBox pictureBox1;
        private Button button7;
        private Button btn_banhang;
        private Button btn_nhanvien;
        private Button btn_thongke;
        private Button btn_voucher;
        private Button btn_sanpham;
        private Button btn_hoadon;
        private Button btn_khachhang;
        private Label label1;
        private Button btn_thietlap;
        private Panel panel_body;
        private PictureBox pictureBox2;
        private Label lblten;
        private Label lblquyen;
    }
}