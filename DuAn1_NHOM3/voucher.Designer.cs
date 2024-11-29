namespace PRL
{
    partial class voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voucher));
            groupBox1 = new GroupBox();
            btn_lammoi = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            dtpkNKT = new DateTimePicker();
            dtpkNgayapdung = new DateTimePicker();
            lblNgayketthuc = new Label();
            tbcMota = new TextBox();
            tbxDieuKien = new TextBox();
            tbxMavc = new TextBox();
            lblMota = new Label();
            lblDieuKien = new Label();
            lblNAP = new Label();
            lblMaVC = new Label();
            groupBox2 = new GroupBox();
            btn_timkiem = new Button();
            label11 = new Label();
            txt_search = new TextBox();
            groupBox3 = new GroupBox();
            dgvDataVC = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(dtpkNKT);
            groupBox1.Controls.Add(dtpkNgayapdung);
            groupBox1.Controls.Add(lblNgayketthuc);
            groupBox1.Controls.Add(tbcMota);
            groupBox1.Controls.Add(tbxDieuKien);
            groupBox1.Controls.Add(tbxMavc);
            groupBox1.Controls.Add(lblMota);
            groupBox1.Controls.Add(lblDieuKien);
            groupBox1.Controls.Add(lblNAP);
            groupBox1.Controls.Add(lblMaVC);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(767, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(411, 662);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Voucher";
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(284, 433);
            btn_lammoi.Margin = new Padding(3, 2, 3, 2);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(112, 35);
            btn_lammoi.TabIndex = 26;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(153, 433);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(95, 35);
            btn_sua.TabIndex = 25;
            btn_sua.Text = "Sửa ";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(23, 433);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(95, 35);
            btn_them.TabIndex = 24;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // dtpkNKT
            // 
            dtpkNKT.CustomFormat = "dd/mm/yyyy";
            dtpkNKT.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkNKT.Location = new Point(133, 288);
            dtpkNKT.Margin = new Padding(3, 2, 3, 2);
            dtpkNKT.Name = "dtpkNKT";
            dtpkNKT.Size = new Size(243, 23);
            dtpkNKT.TabIndex = 23;
            // 
            // dtpkNgayapdung
            // 
            dtpkNgayapdung.CustomFormat = "dd/mm/yyyy";
            dtpkNgayapdung.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkNgayapdung.Location = new Point(133, 230);
            dtpkNgayapdung.Margin = new Padding(3, 2, 3, 2);
            dtpkNgayapdung.Name = "dtpkNgayapdung";
            dtpkNgayapdung.Size = new Size(243, 23);
            dtpkNgayapdung.TabIndex = 22;
            // 
            // lblNgayketthuc
            // 
            lblNgayketthuc.AutoSize = true;
            lblNgayketthuc.BackColor = Color.Transparent;
            lblNgayketthuc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayketthuc.Location = new Point(18, 293);
            lblNgayketthuc.Name = "lblNgayketthuc";
            lblNgayketthuc.Size = new Size(95, 17);
            lblNgayketthuc.TabIndex = 21;
            lblNgayketthuc.Text = "Ngày kết thúc";
            // 
            // tbcMota
            // 
            tbcMota.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbcMota.Location = new Point(133, 350);
            tbcMota.Margin = new Padding(3, 2, 3, 2);
            tbcMota.Multiline = true;
            tbcMota.Name = "tbcMota";
            tbcMota.Size = new Size(243, 22);
            tbcMota.TabIndex = 20;
            // 
            // tbxDieuKien
            // 
            tbxDieuKien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDieuKien.Location = new Point(133, 164);
            tbxDieuKien.Margin = new Padding(3, 2, 3, 2);
            tbxDieuKien.Name = "tbxDieuKien";
            tbxDieuKien.Size = new Size(243, 23);
            tbxDieuKien.TabIndex = 19;
            // 
            // tbxMavc
            // 
            tbxMavc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMavc.Location = new Point(133, 104);
            tbxMavc.Margin = new Padding(3, 2, 3, 2);
            tbxMavc.Name = "tbxMavc";
            tbxMavc.Size = new Size(243, 23);
            tbxMavc.TabIndex = 18;
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.BackColor = Color.Transparent;
            lblMota.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMota.Location = new Point(64, 352);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(43, 17);
            lblMota.TabIndex = 17;
            lblMota.Text = "Mô tả";
            // 
            // lblDieuKien
            // 
            lblDieuKien.AutoSize = true;
            lblDieuKien.BackColor = Color.Transparent;
            lblDieuKien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieuKien.Location = new Point(30, 164);
            lblDieuKien.Name = "lblDieuKien";
            lblDieuKien.Size = new Size(77, 17);
            lblDieuKien.TabIndex = 16;
            lblDieuKien.Text = "% giảm giá";
            // 
            // lblNAP
            // 
            lblNAP.AutoSize = true;
            lblNAP.BackColor = Color.Transparent;
            lblNAP.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNAP.Location = new Point(18, 233);
            lblNAP.Name = "lblNAP";
            lblNAP.Size = new Size(97, 17);
            lblNAP.TabIndex = 15;
            lblNAP.Text = "Ngày áp dụng";
            // 
            // lblMaVC
            // 
            lblMaVC.AutoSize = true;
            lblMaVC.BackColor = Color.Transparent;
            lblMaVC.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaVC.Location = new Point(30, 106);
            lblMaVC.Name = "lblMaVC";
            lblMaVC.Size = new Size(84, 17);
            lblMaVC.TabIndex = 14;
            lblMaVC.Text = "Mã Voucher";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(btn_timkiem);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txt_search);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(767, 107);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ Lọc";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_timkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timkiem.Location = new Point(286, 51);
            btn_timkiem.Margin = new Padding(3, 2, 3, 2);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.RightToLeft = RightToLeft.No;
            btn_timkiem.Size = new Size(86, 27);
            btn_timkiem.TabIndex = 10;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.TextAlign = ContentAlignment.MiddleRight;
            btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(25, 32);
            label11.Name = "label11";
            label11.Size = new Size(84, 17);
            label11.TabIndex = 9;
            label11.Text = "Mã Voucher";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(25, 51);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(198, 23);
            txt_search.TabIndex = 8;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(dgvDataVC);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 107);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(767, 538);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Voucher";
            // 
            // dgvDataVC
            // 
            dgvDataVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataVC.BackgroundColor = Color.WhiteSmoke;
            dgvDataVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataVC.Dock = DockStyle.Fill;
            dgvDataVC.Location = new Point(3, 18);
            dgvDataVC.Margin = new Padding(3, 2, 3, 2);
            dgvDataVC.Name = "dgvDataVC";
            dgvDataVC.RowHeadersWidth = 51;
            dgvDataVC.RowTemplate.Height = 29;
            dgvDataVC.Size = new Size(761, 518);
            dgvDataVC.TabIndex = 0;
            dgvDataVC.CellClick += dgvDataVC_CellClick;
            dgvDataVC.CellContentClick += dgvDataVC_CellContentClick;
            // 
            // voucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 662);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "voucher";
            Text = "bh";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker dtpkNKT;
        private DateTimePicker dtpkNgayapdung;
        private Label lblNgayketthuc;
        private TextBox tbcMota;
        private TextBox tbxDieuKien;
        private TextBox tbxMavc;
        private Label lblMota;
        private Label lblDieuKien;
        private Label lblNAP;
        private Label lblMaVC;
        private Button btn_timkiem;
        private Label label11;
        private TextBox txt_search;
        private DataGridView dgvDataVC;
        private Button btn_lammoi;
        private Button btn_sua;
        private Button btn_them;
    }
}