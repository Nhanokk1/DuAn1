﻿using BUS.Services;
using DAL.DomainClass;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class sanpham : Form
    {
        public SanPhamServices service;
        public MauSacServices servicesMS;
        public KichCoServices servicesKC;
        public ThuongHieuServices servicesTH;
        public string idWhenClick;
        public event Action OnMauSacUpdated;
        public event Action OnKichCoUpdated;
        public event Action OnThuongHieuUpdated;
        public sanpham()
        {
            InitializeComponent();
            service = new SanPhamServices();
            servicesMS = new MauSacServices();
            servicesKC = new KichCoServices();
            servicesTH = new ThuongHieuServices();
            LoadGird();
            LoadMauSac();
            LoadKichCo();
            LoadThuongHieu();
            LoadTrangThai();
            OnMauSacUpdated += UpdateMauSac;
            OnKichCoUpdated += UpdateKichCo;
            OnThuongHieuUpdated += UpdateThuongHieu;
            RefreshForm();
        }
        public void LoadGird()
        {
            dtgView_sp.ColumnCount = 10;
            dtgView_sp.Columns[0].Name = "Mã Sản Phẩm";
            dtgView_sp.Columns[1].Name = "Tên Sản Phẩm";
            dtgView_sp.Columns[2].Name = "Màu Sắc";
            dtgView_sp.Columns[3].Name = "Chất Liệu";
            dtgView_sp.Columns[4].Name = "Giá Tiền";
            dtgView_sp.Columns[5].Name = "Ngày Nhập";
            dtgView_sp.Columns[6].Name = "Số Lượng";
            dtgView_sp.Columns[7].Name = "Kích Thước";
            dtgView_sp.Columns[8].Name = "Thương Hiệu";
            dtgView_sp.Columns[9].Name = "Trạng Thái";
            dtgView_sp.Rows.Clear();


            foreach (var sp in service.GetSanPhams())
            {
                dtgView_sp.Rows.Add(sp.MaSanPham, sp.TenSanPham, servicesMS.GetMauSacById(sp.MaMauSp).MauSac1, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, servicesKC.GetKichCoById(sp.MaKichCoSp).KichCo1, servicesTH.GetThuongHieuById(sp.MaThuongHieu).TenThuongHieu, ConvertTrangThai(sp.TrangThai));
            }
        }
        private void RefreshForm()
        {
            // Xóa các trường văn bản
            txt_masanpham.Text = string.Empty;
            txt_tensanpham.Text = string.Empty;
            txt_chatlieu.Text = string.Empty;
            txt_giatien.Text = "0";
            txt_soluong.Text = string.Empty;

            dtp_ngaynhap.Value = DateTime.Now;

            // Đặt lại giá trị mặc định cho các combo box
            cmbx_kichthuoc.SelectedIndex = -1;
            cmbx_thuonghieu.SelectedIndex = -1;
            cmbx_mausac.SelectedIndex = -1;
            cmbx_trangthai.SelectedIndex = -1;

            // Tải lại dữ liệu lên DataGridView
            LoadGird();
        }
        public string ConvertTrangThai(int? trangThai)
        {
            string status = string.Empty;
            switch (trangThai)
            {
                case 1:
                    status = "Kinh Doanh";
                    break;
                case 2:
                    status = "Ngưng Kinh Doanh";
                    break;
                default:
                    break;
            }
            return status;

        }
        public void FillData()
        {
            var sp = service.GetSanPhams().Find(x => x.MaSanPham.ToString() == idWhenClick);
            if (sp != null)
            {
                txt_masanpham.Text = sp.MaSanPham;
                txt_tensanpham.Text = sp.TenSanPham;
                cmbx_mausac.SelectedValue = sp.MaMauSp;
                txt_giatien.Text = sp.GiaBan.ToString();
                txt_chatlieu.Text = sp.ChatLieu;
                dtp_ngaynhap.Text = sp.NgayNhap.ToString();
                txt_soluong.Text = sp.SoLuongTon.ToString();
                cmbx_kichthuoc.SelectedValue = sp.MaKichCoSp;
                cmbx_thuonghieu.SelectedValue = sp.MaThuongHieu;
                cmbx_trangthai.Text = ConvertTrangThai(sp.TrangThai);
            }
        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexSo(txt_giatien.Text))
            {
                MessageBox.Show("Giá tiền của sản phẩm không chứa chữ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSo(txt_soluong.Text))
            {
                MessageBox.Show("Số lượng của sản phẩm không chứa chữ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSoAm(txt_giatien.Text))
            {
                MessageBox.Show("Giá tiền của sản phẩm không chứa số âm");
                return;
            }
            if (!regexServices.RegexSoAm(txt_soluong.Text))
            {
                MessageBox.Show("Số lượng của sản phẩm không chứa số âm");
                return;
            }
            if (!regexServices.RegexChu(txt_tensanpham.Text))
            {
                MessageBox.Show("Tên sản phẩm không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexChu(txt_chatlieu.Text))
            {
                MessageBox.Show("Chất liệu không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexMaSanPham(txt_masanpham.Text))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ, Mời nhập lại");
                return;
            }
            if (service.GetSanPhams().Any(kc => kc.MaSanPham.ToLower() == txt_masanpham.Text.ToLower()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng nhập mã khác.");
                return;
            }


            SanPham sp = new SanPham
            {
                MaSanPham = txt_masanpham.Text,
                TenSanPham = txt_tensanpham.Text,
                MaMauSp = (string)cmbx_mausac.SelectedValue,
                GiaBan = decimal.Parse(txt_giatien.Text),
                ChatLieu = txt_chatlieu.Text,
                NgayNhap = DateTime.Parse(dtp_ngaynhap.Text),
                SoLuongTon = int.Parse(txt_soluong.Text),
                MaKichCoSp = (string)cmbx_kichthuoc.SelectedValue,
                MaThuongHieu = (string)cmbx_thuonghieu.SelectedValue,
                TrangThai = (int)cmbx_trangthai.SelectedValue
            };
            MessageBox.Show(service.Them(sp));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sp = service.GetSanPhams().Find(x => x.MaSanPham == idWhenClick);
            if (sp != null)
            {
                RegexServices regexServices = new RegexServices();
                if (!regexServices.RegexSo(txt_giatien.Text))
                {
                    MessageBox.Show("Giá tiền của sản phẩm không chứa chữ, Mời nhập lại");
                    return;
                }
                if (!regexServices.RegexSo(txt_soluong.Text))
                {
                    MessageBox.Show("Số lượng của sản phẩm không chứa chữ, Mời nhập lại");
                    return;
                }
                if (!regexServices.RegexSoAm(txt_giatien.Text))
                {
                    MessageBox.Show("Giá tiền của sản phẩm không chứa số âm");
                    return;
                }
                if (!regexServices.RegexSoAm(txt_soluong.Text))
                {
                    MessageBox.Show("Số lượng của sản phẩm không chứa số âm");
                    return;
                }
                if (!regexServices.RegexChu(txt_tensanpham.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được chứa số, Mời nhập lại");
                    return;
                }
                if (!regexServices.RegexChu(txt_chatlieu.Text))
                {
                    MessageBox.Show("Chất liệu không được chứa số, Mời nhập lại");
                    return;
                }
                if (!regexServices.RegexMaSanPham(txt_masanpham.Text))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ, Mời nhập lại");
                    return;
                }
                if (!sp.MaSanPham.Equals(txt_masanpham.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Không thể thay đổi mã sản phẩm.");
                    return;
                }


                sp.MaSanPham = txt_masanpham.Text;
                sp.TenSanPham = txt_tensanpham.Text;
                sp.MaMauSp = (string)cmbx_mausac.SelectedValue;
                sp.GiaBan = decimal.Parse(txt_giatien.Text);
                sp.ChatLieu = txt_chatlieu.Text;
                sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
                sp.SoLuongTon = int.Parse(txt_soluong.Text);
                sp.MaKichCoSp = (string)cmbx_kichthuoc.SelectedValue;
                sp.MaThuongHieu = (string)cmbx_thuonghieu.SelectedValue;
                sp.TrangThai = (int)cmbx_trangthai.SelectedValue; // Lưu trạng thái
                MessageBox.Show(service.Sua(sp));
                LoadGird();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masanpham.Clear();
            txt_tensanpham.Clear();
            cmbx_mausac.SelectedIndex = -1; // Đặt lại giá trị của combobox Màu Sắc
            txt_giatien.Clear();
            txt_chatlieu.Clear();
            dtp_ngaynhap.Value = DateTime.Now; // Đặt lại giá trị ngày nhập về ngày hiện tại
            txt_soluong.Clear();
            cmbx_kichthuoc.SelectedIndex = -1; // Đặt lại giá trị của combobox Kích Thước
            cmbx_thuonghieu.SelectedIndex = -1; // Đặt lại giá trị của combobox Thương Hiệu
            cmbx_trangthai.SelectedIndex = -1;
        }

        private void dtgView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị tìm kiếm từ textbox
            string searchTerm = txt_search.Text.Trim();

            // Nếu giá trị tìm kiếm rỗng, hiển thị tất cả sản phẩm
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadGird();
                return;
            }

            // Lấy tất cả sản phẩm
            var allSanPhams = service.GetSanPhams();

            // Tìm kiếm sản phẩm dựa trên mã sản phẩm hoặc tên sản phẩm
            var filteredSanPhams = allSanPhams
                .Where(sp => sp.MaSanPham.Contains(searchTerm) || sp.TenSanPham.Contains(searchTerm))
                .ToList();

            // Xóa tất cả các dòng hiện tại trong DataGridView
            dtgView_sp.Rows.Clear();

            // Thêm các dòng tìm thấy vào DataGridView
            foreach (var sp in filteredSanPhams)
            {
                dtgView_sp.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    servicesMS.GetMauSacById(sp.MaMauSp).MauSac1,
                    sp.ChatLieu,
                    sp.GiaBan,
                    sp.NgayNhap,
                    sp.SoLuongTon,
                    servicesKC.GetKichCoById(sp.MaKichCoSp).KichCo1,
                    servicesTH.GetThuongHieuById(sp.MaThuongHieu).TenThuongHieu,
                    ConvertTrangThai(sp.TrangThai)
                );
            }
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {

        }

        private void sanpham_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtgView_sp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetSanPhams().Count)
            {
                return;
            }
            idWhenClick = dtgView_sp.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }
        private void LoadMauSac()
        {
            var mauSacs = servicesMS.GetMauSacs();
            cmbx_mausac.DataSource = mauSacs;
            cmbx_mausac.DisplayMember = "MauSac1";
            cmbx_mausac.ValueMember = "MaMauSp";
        }

        private void LoadKichCo()
        {
            var kichCos = servicesKC.GetKichCos();
            cmbx_kichthuoc.DataSource = kichCos;
            cmbx_kichthuoc.DisplayMember = "KichCo1";
            cmbx_kichthuoc.ValueMember = "MaKichCoSp";
        }
        private void LoadThuongHieu()
        {
            var thuongHieus = servicesTH.GetThuongHieus();
            cmbx_thuonghieu.DataSource = thuongHieus;
            cmbx_thuonghieu.DisplayMember = "TenThuongHieu";
            cmbx_thuonghieu.ValueMember = "MaThuongHieu";
        }
        private void LoadTrangThai()
        {
            var trangThaiItems = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, string>(1, "Kinh Doanh"),
            new KeyValuePair<int, string>(2, "Ngưng Kinh Doanh")
        };

            cmbx_trangthai.DataSource = trangThaiItems;
            cmbx_trangthai.DisplayMember = "Value";
            cmbx_trangthai.ValueMember = "Key";
            cmbx_trangthai.SelectedIndex = 0; // Mặc định chọn trạng thái đầu tiên
        }
        public void UpdateMauSac()
        {
            LoadMauSac();
        }

        public void UpdateKichCo()
        {
            LoadKichCo();
        }

        public void UpdateThuongHieu()
        {
            LoadThuongHieu();
        }

        private void btn_themms_Click(object sender, EventArgs e)
        {
            //mausac mauSac = new mausac();
            //mauSac.ShowDialog();
            mausac mauSac = new mausac();
            mauSac.FormClosed += (s, args) => OnMauSacUpdated?.Invoke();
            mauSac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kichco kichCo = new kichco();
            //kichCo.ShowDialog();
            kichco kichCo = new kichco();
            kichCo.FormClosed += (s, args) => OnKichCoUpdated?.Invoke();
            kichCo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //thuonghieu thuongHieu = new thuonghieu();
            //thuongHieu.ShowDialog();
            thuonghieu thuongHieu = new thuonghieu();
            thuongHieu.FormClosed += (s, args) => OnThuongHieuUpdated?.Invoke();
            thuongHieu.ShowDialog();
        }
        private void LoadFilteredData()
        {
            // Lấy giá trị từ các ComboBox
            string selectedMauSac = cmbx_mausac.SelectedValue != null ? cmbx_mausac.SelectedValue.ToString() : null;
            string selectedKichThuoc = cmbx_kichthuoc.SelectedValue != null ? cmbx_kichthuoc.SelectedValue.ToString() : null;
            string selectedThuongHieu = cmbx_thuonghieu.SelectedValue != null ? cmbx_thuonghieu.SelectedValue.ToString() : null;

            // Lấy tất cả sản phẩm
            var allSanPhams = service.GetSanPhams();

            // Lọc sản phẩm theo các tiêu chí đã chọn
            var filteredSanPhams = allSanPhams
                .Where(sp => (selectedMauSac == null || sp.MaMauSp == selectedMauSac) &&
                             (selectedKichThuoc == null || sp.MaKichCoSp == selectedKichThuoc) &&
                             (selectedThuongHieu == null || sp.MaThuongHieu == selectedThuongHieu))
                .ToList();

            // Hiển thị danh sách sản phẩm đã lọc trong DataGridView
            dtgView_sp.Rows.Clear();
            foreach (var sp in filteredSanPhams)
            {
                dtgView_sp.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    servicesMS.GetMauSacById(sp.MaMauSp).MauSac1,
                    sp.ChatLieu,
                    sp.GiaBan,
                    sp.NgayNhap,
                    sp.SoLuongTon,
                    servicesKC.GetKichCoById(sp.MaKichCoSp).KichCo1,
                    servicesTH.GetThuongHieuById(sp.MaThuongHieu).TenThuongHieu,
                    ConvertTrangThai(sp.TrangThai)
                );
            }
        }

        private void cmbx_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadFilteredData();
        }

        private void cmbx_kichthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadFilteredData();
        }

        private void cmbx_thuonghieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadFilteredData();
        }

    private void cmbx_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
