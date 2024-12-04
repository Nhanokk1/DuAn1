namespace DuAn1_NHOM3
{
    partial class dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            label2 = new Label();
            txt_matkhau = new TextBox();
            label1 = new Label();
            txt_taikhoan = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_thoat
            // 
            btn_thoat.FlatAppearance.BorderSize = 0;
            btn_thoat.FlatStyle = FlatStyle.System;
            btn_thoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thoat.Location = new Point(316, 325);
            btn_thoat.Margin = new Padding(3, 2, 3, 2);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(113, 31);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Đăng Ký";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.FlatAppearance.BorderSize = 0;
            btn_dangnhap.FlatStyle = FlatStyle.System;
            btn_dangnhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangnhap.Location = new Point(188, 325);
            btn_dangnhap.Margin = new Padding(3, 2, 3, 2);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(113, 31);
            btn_dangnhap.TabIndex = 3;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(188, 232);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_matkhau.Location = new Point(188, 266);
            txt_matkhau.Margin = new Padding(3, 2, 3, 2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.Size = new Size(222, 29);
            txt_matkhau.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(184, 157);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_taikhoan.Location = new Point(184, 191);
            txt_taikhoan.Margin = new Padding(3, 2, 3, 2);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(222, 29);
            txt_taikhoan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(645, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(959, 522);
            Controls.Add(pictureBox1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_dangnhap);
            Controls.Add(label2);
            Controls.Add(txt_matkhau);
            Controls.Add(label1);
            Controls.Add(txt_taikhoan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "dangnhap";
            Text = " Phần Mềm Bán Giày Sneaker";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_thoat;
        private Button btn_dangnhap;
        private Label label2;
        private TextBox txt_matkhau;
        private Label label1;
        private TextBox txt_taikhoan;
        private PictureBox pictureBox1;
    }
}
