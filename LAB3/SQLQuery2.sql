GO
CREATE INDEX IX_PhieuDatPhong_Ngay ON
PhieuDatPhong(NgayNhan,NgayTraDuKien,TrangThai);
CREATE INDEX IX_CTDat_Phong ON ChiTietDatPhong(SoPhong,SoPhieuDat);
CREATE INDEX IX_PhieuSDDV_DatPhong ON
PhieuSuDungDV(SoPhieuDat,SoPhong,NgaySuDung);
GO
INSERT INTO NhanVien(MaNV,HoTen,VaiTro,SoDienThoai) VALUES
('NV01',N'Nguyễn Thu Hà',N'Lễ tân','0901000001'),
('NV02',N'Trần Minh An',N'Phục vụ phòng','0901000002'),
('NV03',N'Lê Hoàng Nam',N'Thanh toán','0901000003');
INSERT INTO KhuVuc(MaKhuVuc,TenKhuVuc) VALUES ('A',N'Khu A'),('B',N'Khu B');
INSERT INTO Phong(SoPhong,MaKhuVuc,SoNguoiToiDa,DonGiaNgay,TrangThai)
VALUES
('A101','A',2,600000,N'Trống'),('A102','A',3,800000,N'Trống'),('B201','B',4,1200000,N'Trống');
INSERT INTO LoaiTienNghi(MaLoaiTN,TenLoaiTN) VALUES ('TV',N'Ti vi'),('TL',N'Tủ
lạnh'),('DT',N'Điện thoại');
INSERT INTO TienNghi(MaTienNghi,MaLoaiTN,SoThuTu,TinhTrangHienTai) VALUES
('TV01','TV',1,N'Tốt'),('TV02','TV',2,N'Tốt'),('TL01','TL',1,N'Tốt');
INSERT INTO DichVu(MaDV,TenDV,DonViTinh,DonGia) VALUES
('DV01',N'Ăn sáng',N'Suất',120000),('DV02',N'Tắm
hơi',N'Lượt',250000),('DV03',N'Karaoke',N'Giờ',300000);
INSERT INTO QuyDinhDenBu(MaQuyDinh,MaLoaiTN,MucDoThietHai,MucDenBu)
VALUES
('QD01','TV',N'Hư hỏng nhẹ',500000),('QD02','TV',N'Mất',5000000),('QD03','TL',N'Hư hỏng
nhẹ',400000),('QD04','TL',N'Mất',4000000);