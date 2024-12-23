CREATE DATABASE QLPKham1;
USE QLPKham1;

/* 
Created     17/12/2024
Modified    17/12/2024
Project     
Model       
Company     
Author      
Version     
Database    MS SQL 2005 
*/

CREATE TABLE BenhNhan (
    MaBenhNhan CHAR(50) NOT NULL,
    TenBenhNhan NVARCHAR(100) NULL,
    SoDienThoai VARCHAR(20) NULL,
    Avatar VARBINARY(MAX) NULL,
    PRIMARY KEY (MaBenhNhan)
);
GO
CREATE TABLE LichHen (
    MaLichHen CHAR(50) NOT NULL,
    NgayHenTT DATETIME NULL,
    NgayHenGN DATETIME NULL,
    MaBenhNhan CHAR(50) NOT NULL,
	Ghichu NVARCHAR (1000),
    PRIMARY KEY (MaLichHen),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan)
);
GO
CREATE TABLE HoaDon (
    MaHoaDon CHAR(50) NOT NULL,
    GhiChu NVARCHAR(100) NULL,
    MaBenhNhan CHAR(50) NOT NULL,
    PRIMARY KEY (MaHoaDon),
    FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan (MaBenhNhan)
);
GO
CREATE TABLE ToaThuoc (
    MaToa CHAR(50) NOT NULL,
    LieuLuon NVARCHAR(1000) NULL,
    SoLuong INT CHECK (SoLuong > 0) NULL,
    MaHoaDon CHAR(50) NOT NULL,
    PRIMARY KEY (MaToa),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon (MaHoaDon)
);
GO
CREATE TABLE Thuoc_ (
    MaThuoc CHAR(50) NOT NULL,
    TenThuoc NVARCHAR(100) NULL,
    Gia DECIMAL(18, 2) CHECK (Gia > 0) NULL,
    MaToa CHAR(50) NOT NULL,
    PRIMARY KEY (MaThuoc),
    FOREIGN KEY (MaToa) REFERENCES ToaThuoc (MaToa)
);
GO
CREATE TABLE DichVu (
    MaDichVu CHAR(50) NOT NULL,
    TenDichVu NVARCHAR(100) NULL,
    Gia DECIMAL(18, 2) CHECK (Gia > 0) NULL,
    MaHoaDon CHAR(50) NOT NULL,
    PRIMARY KEY (MaDichVu),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon (MaHoaDon)
);
GO
CREATE TABLE DoanhThu (
    MaDoanhThu CHAR(50) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    NgayHoaDon DATETIME,
    Gia DECIMAL
);
go
INSERT INTO DoanhThu (MaDoanhThu, TenDichVu, NgayHoaDon, Gia)
SELECT 
    NEWID(), 
    dv.TenDichVu,
    lh.NgayHenGN,  
    dv.Gia
FROM HoaDon h
JOIN DichVu dv ON h.MaDichVu = dv.MaDichVu
JOIN LichHen lh ON lh.MaBenhNhan = h.MaBenhNhan;
go
-- Insert data
INSERT INTO BenhNhan (MaBenhNhan, TenBenhNhan, SoDienThoai, Avatar)
VALUES 
('BN001', N'Nguyen Van A', '0123456789', NULL),
('BN002', N'Tran Thi B', '0987654321', NULL),
('BN003', N'Le Van C', '0912345678', NULL);
GO
INSERT INTO HoaDon (MaHoaDon, GhiChu, MaBenhNhan)
VALUES 
('HD001', N'Hóa đơn 1', 'BN001'),
('HD002', N'Hóa đơn 2', 'BN002'),
('HD003', N'Hóa đơn 3', 'BN003');
GO
INSERT INTO LichHen (MaLichHen, NgayHenTT, NgayHenGN, GhiChu, MaBenhNhan )
VALUES 
('LH001', '2024-12-18 10:00:00', '2024-12-17 10:00:00',N'Bệnh nhân cũ', 'BN001'),
('LH002', '2024-12-19 11:00:00', '2024-12-18 11:00:00',N'Người quen', 'BN002'),
('LH003', '2024-12-20 09:00:00', '2024-12-19 09:00:00',N'Bệnh nhân cũ', 'BN003');
GO
INSERT INTO ToaThuoc (MaToa, LieuLuon, SoLuong, MaHoaDon)
VALUES 
('TT001', N'2 viên/ngày sau ăn', 10, 'HD001'),
('TT002', N'1 viên/ngày sáng sớm', 5, 'HD002'),
('TT003', N'3 viên/ngày trước ăn', 15, 'HD003');
GO
INSERT INTO Thuoc_ (MaThuoc, TenThuoc, Gia, MaToa)
VALUES 
('TH001', N'Paracetamol', 5000, 'TT001'),
('TH002', N'Ibuprofen', 7000, 'TT002'),
('TH003', N'Vitamin C', 3000, 'TT003');
GO
INSERT INTO DichVu (MaDichVu, TenDichVu, Gia, MaHoaDon)
VALUES 
('DV001', N'Lấy tủy', 150000, 'HD001'),
('DV002', N'Trám Răng', 200000, 'HD002'),
('DV003', N'Nhổ Răng', 300000, 'HD003');
Go
-- thêm avatar
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\bacsix.png', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN001';
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\basixBN.jpg', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN002';
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\basixBN2.png', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN003';
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\bnhan4.jpg', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN004';
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\bnhan5.jpg', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN005';
UPDATE BenhNhan
SET Avatar = (SELECT * FROM OPENROWSET(BULK N'D:\VISUAL STUDIO\HocWindowsForm\PICTURE\bnhan6.jpg', SINGLE_BLOB) AS ImageData)
WHERE MaBenhNhan = 'BN006';


-- đổi ghi chú hóa đơn 1 2 3
UPDATE HoaDon
SET GhiChu = N'Khách đã thanh toán 1 nửa'
WHERE MaHoaDon = 'HD001';
GO 
UPDATE HoaDon
SET GhiChu = N'Thằng này nhìn mặt hơi ghét '
WHERE MaHoaDon = 'HD002';
GO
UPDATE HoaDon	
SET GhiChu = N'Thuốc hiện đang hết hàng nên đợi hàng về giao'
WHERE MaHoaDon = 'HD003';
GO

-- thêm bệnh nhân 
INSERT INTO BenhNhan (MaBenhNhan, TenBenhNhan, SoDienThoai, Avatar)
VALUES 
('BN004', N'Pham Thi D', '0934567890', NULL),
('BN005', N'Nguyen Van E', '0967890123', NULL),
('BN006', N'Tran Van F', '0978901234', NULL);
GO


-- thêm địa chỉ vô bảng bệnh nhân, thêm dữ liệu địa chỉ
ALTER TABLE BenhNhan
ADD DiaChi NVARCHAR(255);
update BenhNhan
set DiaChi = N'Linh Đông, Thủ Đức, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN001'
update BenhNhan
set DiaChi = N'17A Tô Ngọc Vân, Thủ Đức, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN002'
update BenhNhan
set DiaChi = N'488A/10B Phạm Văn Đồng, Thủ Đức, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN003'
update BenhNhan
set DiaChi = N'101 Quang Trung, Gò Vấp, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN004'
update BenhNhan
set DiaChi = N'4011/10B/10/11/2A Linh Tây, Thủ Đức, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN005'
update BenhNhan
set DiaChi = N'124 Lê Văn Việt, Quận 9, Tp Hồ Chí Minh'
where BenhNhan.MaBenhNhan = 'BN006'


--bỏ quan hệ
ALTER TABLE DichVu
DROP CONSTRAINT FK__DichVu__MaHoaDon__59FA5E80;
GO
--bỏ cột
ALTER TABLE DichVu
DROP COLUMN MaHoaDon;
GO
--thêm cột cho hóa đơn
ALTER TABLE HoaDon
ADD MaDichVu CHAR(50) NULL;
GO
--thêm dữ liệu các dịch vụ
INSERT INTO DichVu (MaDichVu, TenDichVu, Gia)
VALUES 
('DV004', N'Thiết kế răng sứ', 100000),
('DV005', N'Chữa sâu răng', 120000),
('DV006', N'Hỗ trợ điều trị', 150000),
('DV007', N'Khám tổng quát', 200000),
('DV008', N'Chụp X-quang', 180000);
GO

select * from dbo.DoanhThu

--thêm dữ liệu cho hóa đơn
INSERT INTO HoaDon (MaHoaDon, GhiChu, MaBenhNhan, MaDichVu)
VALUES 
('HD004', N'Khách thiếu nợ khách hứa trả', 'BN004', 'DV004'),
('HD005', N'Nhớ liên hệ khách để bổ sung thuốc', 'BN005', 'DV005'),
('HD006', N'Khách hàng cần dịch vụ thường xuyên', 'BN006', 'DV006');
GO
--add mã dịch vụ cho các hóa đơn
UPDATE HoaDon
SET MaDichVu = 'DV001'
WHERE MaHoaDon = 'HD001';

UPDATE HoaDon
SET MaDichVu = 'DV002'
WHERE MaHoaDon = 'HD002';

UPDATE HoaDon
SET MaDichVu = 'DV003'
WHERE MaHoaDon = 'HD003';
GO
-- thêm dữ liệu lịch hẹn
INSERT INTO LichHen (MaLichHen, NgayHenTT, NgayHenGN, MaBenhNhan, Ghichu)
VALUES ('LH004', '2024-12-25 10:00:00', '2024-12-24 10:00:00', 'BN004', N'Bệnh nhân chuyển lịch');

INSERT INTO LichHen (MaLichHen, NgayHenTT, NgayHenGN, MaBenhNhan, Ghichu)
VALUES ('LH005', '2024-12-26 11:00:00', '2024-12-25 11:00:00', 'BN005', N'Bệnh nhân này giàu');

INSERT INTO LichHen (MaLichHen, NgayHenTT, NgayHenGN, MaBenhNhan, Ghichu)
VALUES ('LH006', '2024-12-27 09:00:00', '2024-12-26 09:00:00', 'BN006', N'Đã liên hệ bệnh nhân nhưng chưa phản hồi');


-- thêm dữ liệu cho thuốc
INSERT INTO Thuoc_ (MaThuoc, TenThuoc, Gia, MaToa)
VALUES 
('TH004', N'Amoxicillin', 50000, 'TT004'),
('TH005', N'Acetaminophen', 50000, 'TT005'),
('TH006', N'Diclofena', 50000, 'TT006');

-- Thêm toa thuốc vào bảng ToaThuoc
INSERT INTO ToaThuoc (MaToa, LieuLuon, SoLuong, MaHoaDon)
VALUES 
('TT004', N'2 viên/ngày sau ăn', 20, 'HD004'),
('TT005', N'1 viên/ngày sáng sớm', 15, 'HD005'),
('TT006', N'3 viên/ngày trước ăn', 25, 'HD006');

-- thêm mã dịch vụ khi đặt hẹn
ALTER TABLE LichHen
ADD MaDichVu NVARCHAR(50);
-- thêm dữ liệu dịch vụ cho lịch hẹn
update LichHen
set MaDichVu = 'DV001'
where MaLichHen = 'LH001'
update LichHen
set MaDichVu = 'DV002'
where MaLichHen = 'LH002'
update LichHen
set MaDichVu = 'DV003'
where MaLichHen = 'LH003'
update LichHen
set MaDichVu = 'DV004'
where MaLichHen = 'LH004'
update LichHen
set MaDichVu = 'DV005'
where MaLichHen = 'LH005'
update LichHen
set MaDichVu = 'DV006'
where MaLichHen = 'LH006'



