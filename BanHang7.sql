
GO
USE QuanLyBanHang0121;
GO
-- Bảng MauSac
CREATE TABLE MauSac (
    MaMauSP NVARCHAR(10) NOT NULL PRIMARY KEY,
    MauSac NVARCHAR(50) NULL
);

-- Bảng KichCo
CREATE TABLE KichCo (
    MaKichCoSP NVARCHAR(10) NOT NULL PRIMARY KEY,
    KichCo NVARCHAR(50) NULL
);

-- Bảng ThuongHieu
CREATE TABLE ThuongHieu (
    MaThuongHieu NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenThuongHieu NVARCHAR(255) NULL
);

-- Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaVoucher NVARCHAR(10) NOT NULL PRIMARY KEY,
    GiamGia DECIMAL(5, 2) NOT NULL, 
    NgayBatDau DATETIME NULL,
    NgayKetThuc DATETIME NULL,
    MoTaVoucher NVARCHAR(255) NULL
);

-- Bảng ChucVu
CREATE TABLE ChucVu (
    MaChucVu NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenChucVu NVARCHAR(30) NULL
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien NVARCHAR(10) NOT NULL PRIMARY KEY,
    Ten NVARCHAR(255) NULL,
    GioiTinh BIT NULL,
    NgaySinh DATETIME NULL,
    SDT NVARCHAR(15) NULL,
    Email NVARCHAR(255) NULL,
    DiaChi NVARCHAR(255) NULL,
    TrangThai INT NULL,
    MaChucVu NVARCHAR(10) NULL,
    TaiKhoan NVARCHAR(50) NULL,
    MatKhau NVARCHAR(50) NULL,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

-- Bảng SanPham
CREATE TABLE SanPham (
    MaSanPham NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenSanPham NVARCHAR(255) NULL,
    GiaBan DECIMAL(18,2) NULL,
    MaMauSP NVARCHAR(10) NULL,
    MaKichCoSP NVARCHAR(10) NULL,
    ChatLieu NVARCHAR(255) NULL,
    NgayNhap DATETIME NULL,
    HinhAnh NVARCHAR(MAX) NULL,
    SoLuongTon INT NULL,
    MaThuongHieu NVARCHAR(10) NULL,
    TrangThai INT NULL,
    FOREIGN KEY (MaMauSP) REFERENCES MauSac(MaMauSP),
    FOREIGN KEY (MaKichCoSP) REFERENCES KichCo(MaKichCoSP),
    FOREIGN KEY (MaThuongHieu) REFERENCES ThuongHieu(MaThuongHieu)
);

-- Bảng KhachHang
CREATE TABLE KhachHang (
    SDT NVARCHAR(15) NOT NULL PRIMARY KEY,
    TenKhachHang NVARCHAR(255) NULL,
    NgayDangKy DATETIME NULL,
    DiaChi NVARCHAR(255) NULL,
    Email NVARCHAR(255) NULL,
    GioiTinh BIT NULL,
    TrangThai NVARCHAR(50) NULL,
    HinhAnh NVARCHAR(255) NULL,
    GhiChu NVARCHAR(255) NULL
);

-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon NVARCHAR(10) NOT NULL PRIMARY KEY,
    NgayLapHoaDon DATETIME NULL,
    TongTien DECIMAL(18,2) NULL,
    TrangThai INT NULL,
    SDT NVARCHAR(15) NULL,
    MaNhanVien NVARCHAR(10) NULL,
    MaVoucher NVARCHAR(10) NULL,
    FOREIGN KEY (SDT) REFERENCES KhachHang(SDT),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaVoucher) REFERENCES KhuyenMai(MaVoucher)
);

-- Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD NVARCHAR(10) NOT NULL,
    MaSP NVARCHAR(10) NOT NULL,
    SoLuong INT NULL,
    GiaBan DECIMAL(18,2) NULL,
    ThanhTien DECIMAL(18,2) NULL,
    PRIMARY KEY (MaHD, MaSP),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSanPham)
);

-- Thêm dữ liệu vào bảng MauSac
INSERT INTO MauSac (MaMauSP, MauSac) VALUES
('M001', N'Đỏ'),
('M002', N'Xanh'),
('M003', N'Vàng'),
('M004', N'Đen'),
('M005', N'Trắng'),
('M006', N'Hồng'),
('M007', N'Tím'),
('M008', N'Nâu'),
('M009', N'Xám'),
('M010', N'Cam'),
('M011', N'Xanh lá cây'),
('M012', N'Be'),
('M013', N'Xanh dương'),
('M014', N'Bạc'),
('M015', N'Vàng nhạt');

-- Thêm dữ liệu vào bảng KichCo
INSERT INTO KichCo (MaKichCoSP, KichCo) VALUES
('K01', N'30'),
('K02', N'31'),
('K03', N'32'),
('K04', N'33'),
('K05', N'34'),
('K06', N'35'),
('K07', N'36'),
('K08', N'37'),
('K09', N'38'),
('K10', N'39'),
('K11', N'40'),
('K12', N'41'),
('K13', N'42'),
('K14', N'43'),
('K15', N'44'),
('K16', N'45');

-- Thêm dữ liệu vào bảng ThuongHieu
INSERT INTO ThuongHieu (MaThuongHieu, TenThuongHieu) VALUES
('TH001', N'Nike'),
('TH002', N'Adidas'),
('TH003', N'Puma'),
('TH004', N'Reebok'),
('TH005', N'New Balance'),
('TH006', N'Asics'),
('TH007', N'Under Armour'),
('TH008', N'Vans'),
('TH009', N'Converse'),
('TH010', N'Skechers');

-- Thêm dữ liệu vào bảng KhuyenMai
INSERT INTO KhuyenMai (MaVoucher, GiamGia, NgayBatDau, NgayKetThuc, MoTaVoucher) VALUES
('VC001', 5.00, '2024-01-01', '2025-12-01', N'Giảm 5% cho hóa đơn từ 1 triệu'),
('VC002', 10.00, '2024-07-01', '2025-12-01', N'Giảm 10% cho hóa đơn từ 3 triệu'),
('VC003', 15.00, '2024-07-01', '2025-12-01', N'Giảm 15% cho hóa đơn từ 6 triệu'),
('VC004', 20.00, '2024-07-01', '2025-12-01', N'Giảm 20% cho hóa đơn từ 10 triệu'),
('VC005', 25.00, '2024-07-01', '2025-12-01', N'Giảm 25% cho hóa đơn từ 15 triệu'),
('VC006', 30.00, '2024-07-01', '2025-12-01', N'Giảm 30% cho hóa đơn từ 25 triệu');
-- Thêm dữ liệu vào bảng ChucVu
INSERT INTO ChucVu (MaChucVu, TenChucVu) VALUES
('CV01', N'Quản lý'),
('CV02', N'Nhân viên bán hàng');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, Ten, GioiTinh, NgaySinh, SDT, Email, DiaChi, TrangThai, MaChucVu, TaiKhoan, MatKhau) VALUES
('NV01', N'Nguyễn Đăng Nhẫn', 1, '2005-09-25', '0383212289', N'nhan@gmail.com', N'Chương Mỹ', 1, 'CV01', N'admin', N'1'),
('NV02', N'Nguyễn Minh Sang', 1, '2005-10-16', '0912311205', N'sang@gmail.com', N'Quốc Oai', 1, 'CV02', N'nv1', N'1'),
('NV03', N'Nguyễn Tiến', 1, '2005-08-20', '0974988673', N'tien@gmail.com', N'Ba Vì', 1, 'CV02', N'nv2', N'1'),
('NV04', N'Nguyến Tuấn Dũng', 1, '2005-11-30', '0337496175', N'dung@gmail.com', N'Thanh Hoá', 1, 'CV02', N'nv3', N'1'),
('NV05', N'Nguyễn Thanh Bình', 1, '2005-02-10', '0971814676', N'binh@gmail.com', N'Tuyên Quang', 1, 'CV02', N'nv4', N'1');

-- Thêm dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan, MaMauSP, MaKichCoSP, ChatLieu, NgayNhap, HinhAnh, SoLuongTon, MaThuongHieu, TrangThai) 
VALUES
('SP001', N'Giày Chạy Bộ Nike Air Zoom', 2500000, 'M001', 'K13', N'Vải lưới', '2023-01-10', 'nike_air_zoom.jpg', 50, 'TH001', 1),
('SP002', N'Giày Thể Thao Adidas Ultraboost', 3000000, 'M002', 'K14', N'Vải dệt kim', '2023-02-15', 'adidas_ultraboost.jpg', 30, 'TH002', 1),
('SP003', N'Giày Chạy Bộ Puma Speed', 2200000, 'M003', 'K15', N'Da tổng hợp', '2023-03-20', 'puma_speed.jpg', 20, 'TH003', 1),
('SP004', N'Giày Thể Thao Reebok Classic', 1800000, 'M004', 'K12', N'Da thật', '2023-04-25', 'reebok_classic.jpg', 15, 'TH004', 2),
('SP005', N'Giày Chạy Bộ New Balance 1080', 2700000, 'M005', 'K13', N'Vải lưới', '2023-05-30', 'nb_1080.jpg', 25, 'TH005', 1),
('SP006', N'Giày Thể Thao Asics Gel-Kayano', 3200000, 'M006', 'K14', N'Vải dệt kim', '2023-06-10', 'asics_gel_kayano.jpg', 10, 'TH006', 1),
('SP007', N'Giày Chạy Bộ Under Armour HOVR', 2800000, 'M007', 'K15', N'Da tổng hợp', '2023-07-15', 'ua_hovr.jpg', 18, 'TH007', 2),
('SP008', N'Giày Thể Thao Vans Old Skool', 1600000, 'M008', 'K12', N'Da lộn', '2023-08-20', 'vans_old_skool.jpg', 40, 'TH008', 1),
('SP009', N'Giày Thể Thao Converse Chuck Taylor', 1900000, 'M009', 'K13', N'Vải canvas', '2023-09-25', 'converse_chuck_taylor.jpg', 35, 'TH009', 1),
('SP010', N'Giày Thể Thao Skechers Go Run', 2100000, 'M010', 'K14', N'Vải lưới', '2023-10-30', 'skechers_go_run.jpg', 22, 'TH010', 2);

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (SDT, TenKhachHang, NgayDangKy, DiaChi, Email, GioiTinh, TrangThai, HinhAnh, GhiChu) VALUES
('0', N'Khách Vãng Lai', '1999-01-01', N'Sao Hoả', 'x@gmail.com', 0, 'Hoạt động', '', ''),
('0963794271', N'Nguyễn Đăng Nhẫn', '2005-09-25', N'Chương Mỹ', 'a@gmail.com', 1, 'Hoạt động', 'a.jpg', 'VIP'),
('0912311205', N'Minh Sang', '2005-10-16', N'Quốc Oai', 'b@gmail.com', 1, 'Hoạt động', 'a.jpg', 'VIP'),
('0912345678', N'Nguyễn Tiến', '2005-08-20', N'Ba Vì', 'c@gmail.com', 1, 'Hoạt động', 'a.jpg', 'VIP'),
('0912326819', N'Tuấn Dũng', '2005-11-30', N'Thanh Hoá', 'd@gmail.com', 1, 'Hoạt động', 'a.jpg', 'VIP'),
('0912345677', N'Thanh Bình', '2005-02-10', N'Tuyên Quang', 'e@gmail.com', 1, 'Hoạt động', 'b.jpg', 'VIP'),
('0971814676', N'Nguyễn Tấn Phát', '2005-02-10', N'Tuyên Quang', 'e@gmail.com', 1, 'Hoạt động', 'b.jpg', 'VIP');

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaHoaDon, NgayLapHoaDon, TongTien, TrangThai, SDT, MaNhanVien, MaVoucher, TienKhachDua) VALUES
('HD01', '2024-07-10', 1000000, 1, '0963794271', 'NV01', 'VC01', null),
('HD02', '2024-07-11', 2000000, 2, '0912311205', 'NV02', 'VC02', null);

-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, GiaBan, ThanhTien) VALUES
('HD01', 'SP001', 1, 1000000, 1000000),
('HD02', 'SP002', 1, 2000000, 2000000);



