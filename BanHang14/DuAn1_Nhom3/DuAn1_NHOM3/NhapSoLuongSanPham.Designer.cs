namespace PRL
{
    partial class NhapSoLuongSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapSoLuongSanPham));
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 26);
            label1.Name = "label1";
            label1.Size = new Size(372, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập số lượng sản phẩm muốn mua";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(47, 70);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 35);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // NhapSoLuongSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(496, 134);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhapSoLuongSanPham";
            Text = "NhapSoLuongSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}