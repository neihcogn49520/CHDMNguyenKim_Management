create database QuanLiDienMay
use QuanLiDienMay


create table khachhang(
	makh char(10) not null primary key,
	hovaten nvarchar(50) not null,
	diachi nvarchar(100) not null,
	sdt nvarchar(12) not null,
)

create table nhanvien(
	manv char(10) not null primary key,
	hovaten nvarchar(50),
	ngaysinh date not null,
	diachi nvarchar(40) not null,
	sdt nvarchar(12),
	ngayvl date,
	hsluong decimal,
)

CREATE TABLE nhacungcap(
	mancc CHAR(10) NOT NULL PRIMARY KEY,
	tenncc NVARCHAR(50) NOT NULL
)

CREATE TABLE loaisanpham(
	malsp CHAR(10) NOT NULL PRIMARY KEY,
	tenlsp NVARCHAR(50) NOT NULL
)

create table sanpham(
	masp char(10) not null primary key,
	tensp nvarchar(50),
	Soluong int,
	giaban DECIMAL NOT NULL,
	giamua DECIMAL NOT NULL,
	malsp CHAR(10) NOT NULL,
	mancc CHAR(10) NOT NULL,
	FOREIGN KEY (malsp) REFERENCES loaisanpham,
	FOREIGN KEY (mancc) REFERENCES nhacungcap
)

create table hoadon(
	sohd int not null primary key,
	manv char(10) not null,
	makh char(10) not null,
	ngayhd date not null,
	thanhtienhd decimal null,
	FOREIGN KEY (manv) REFERENCES nhanvien,
	FOREIGN KEY (makh) REFERENCES khachhang
)
go

create table cthd(
	sohd int not null,
	masp char(10) not null,
	dongia decimal NULL,
	thanhtien DECIMAL NULL,
	soluong INT,
	PRIMARY KEY(masp, sohd),
	FOREIGN KEY(masp) REFERENCES sanpham,
	FOREIGN KEY(sohd) REFERENCES hoadon
)
go



INSERT INTO khachhang VALUES ('KH1',N'Trần văn a',N'32/28 Tăng Nhơn phú A','039659856')
INSERT INTO khachhang VALUES ('KH2',N'Trần văn b',N'32/28 Tăng Nhơn phú b','039669856')
INSERT INTO khachhang VALUES ('KH3',N'Trần văn c',N'30/128 Tăng Nhơn phú A','039679856')
INSERT INTO khachhang VALUES ('KH4',N'Trần văn d',N'21/280 Tăng Nhơn phú A','039689856')
INSERT INTO khachhang VALUES ('KH5',N'Trần văn e',N'36/15 Tăng Nhơn phú A','039699856')

INSERT INTO nhanvien VALUES('NV1',N'Nguyễn Văn A','2001/02/02',N'HÀ NỘI','0321021021','2021/09/03',3000000)
INSERT INTO nhanvien VALUES('NV2',N'Nguyễn Văn B','1998/08/03',N'HẢI PHÒNG','0323021021','2021/10/10',3000000)

INSERT INTO loaisanpham VALUES('L1',N'TIVI')
INSERT INTO loaisanpham VALUES('L2',N'TỦ LẠNH')
INSERT INTO loaisanpham VALUES('L3',N'MÁY GIẶT')
INSERT INTO loaisanpham VALUES('L4',N'LAPTOP')

INSERT INTO nhacungcap VALUES('NCC1',N'ĐIỆN MÁY NGUYỄN KIM')
INSERT INTO nhacungcap VALUES('NCC2',N'MÁY TÍNH PHONG VŨ')

INSERT INTO sanpham VALUES('SP1',N'DELL VOSTRO 5515',20,16000000,21990000,'L4','NCC2')
INSERT INTO sanpham VALUES('SP2',N'LENOVO YOGA SLIM 7',60,18000000,22990000,'L4','NCC2')
INSERT INTO sanpham VALUES('SP3',N'MSI MODERN 14',20,13000000,17990000,'L4','NCC2')
INSERT INTO sanpham VALUES('SP4',N'ACER NITRO 5',10,20000000,30990000,'L4','NCC2')
INSERT INTO sanpham VALUES('SP5',N'DELL LATITUDE',30,18000000,20990000,'L4','NCC2')
INSERT INTO sanpham VALUES('SP6',N'ANDROID TIVI TCL 40 INCH',20,8000000,10990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP7',N'ANDROID TIVI SONY 4K 43INCH',20,13000000,16990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP8',N'GOOGLE TIVI SONY 4K 55INCH',10,27000000,30990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP9',N'GOOGLE TIVI SONY 4K 40INCH',30,21000000,25990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP14',N'SAMSUNG INVERTER 208 LÍT',20,8000000,10990000,'L2','NCC1')
INSERT INTO sanpham VALUES('SP15',N'TOSHIBA INVERTER 180 LÍT',20,4000000,6990000,'L2','NCC1')
INSERT INTO sanpham VALUES('SP16',N'SHARP INTERVER 224 LÍT',10,7000000,10990000,'L2','NCC1')
INSERT INTO sanpham VALUES('SP17',N'SHARP INTERVER 180 LÍT',30,5000000,8990000,'L2','NCC1')
INSERT INTO sanpham VALUES('SP10',N'TOSHIBA 7.2KG',20,4000000,8990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP11',N'AQUA 10KG',20,10000000,14990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP12',N'SAMSUNG INTERVER 9.5KG',10,8000000,11990000,'L1','NCC1')
INSERT INTO sanpham VALUES('SP13',N'TOSHIBA 9.2KG',30,8000000,11990000,'L1','NCC1')


INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(1,'NV1','KH1','2021-12-01')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(2,'NV1','KH2','2021-12-02')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(3,'NV1','KH3','2021-12-03')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(4,'NV2','KH4','2021-12-04')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(5,'NV2','KH1','2021-12-05')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(6,'NV2','KH2','2021-12-06')
INSERT INTO hoadon(sohd, manv, makh, ngayhd) VALUES(7,'NV2','KH4','2021-12-07')

INSERT INTO cthd(sohd, masp, soluong) VALUES(1,'SP1',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(1,'SP2',2)
INSERT INTO cthd(sohd, masp, soluong) VALUES(1,'SP3',2)
INSERT INTO cthd(sohd, masp, soluong) VALUES(1,'SP4',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(2,'SP5',5)
INSERT INTO cthd(sohd, masp, soluong) VALUES(2,'SP6',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(3,'SP7',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(4,'SP9',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(4,'SP10',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(4,'SP11',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(4,'SP12',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(5,'SP12',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(6,'SP9', 1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(6,'SP12',5)
INSERT INTO cthd(sohd, masp, soluong) VALUES(7,'SP10',1)
INSERT INTO cthd(sohd, masp, soluong) VALUES(7,'SP13',3)
GO

select * from cthd
select * from hoadon
go
--------STORE PROCEDURE-----------

-- Câu 1: Tìm kiếm loại SANPHAM với tham số đầu vào là Loại sản phẩm (@tenlsp)
CREATE PROC TIMKIEMTHEOLSP @TENLSP NVARCHAR(50)
AS
SELECT B.tensp
FROM loaisanpham A, sanpham B
WHERE A.tenlsp = @TENLSP and a.malsp = b.malsp
GO

EXEC TIMKIEMTHEOLSP N'TỦ LẠNH'
GO
-- Câu 2: Tính tiền tổng các HOADON của khách hàng(@MAKH)
CREATE PROC TongTienHDKH @MAKH CHAR(10)
AS
SELECT @MAKH AS MAKH, SUM(A.GIABAN * B.SOLUONG) AS TONGTIENHD
FROM SANPHAM A, CTHD B, HOADON C
WHERE A.masp = B.masp AND B.sohd = C.sohd AND C.makh = @MAKH
GROUP BY C.makh
GO

EXEC TongTienHDKH 'KH1'
GO

-- Câu 3: Tìm ra sản phẩm được mua nhiều nhất (Tính theo số lượng)

CREATE PROC sp_TimSpMuaNhieuNhat
AS
	SELECT Table1.masp AS N'Mã sản phẩm', Table1.TENSP AS N'Tên sản phẩm', MAX(SL) AS N'Số lượng đã bán'
	FROM 
	(
		SELECT SANPHAM.MASP, TENSP, SUM(cthd.soluong) AS SL
		FROM CTHD, SANPHAM
		WHERE SANPHAM.MASP = CTHD.MASP
		GROUP BY SANPHAM.MASP, TENSP		
	) AS Table1
	WHERE SL = 
	(
		SELECT MAX(SL) AS sl
		FROM 
		(
			SELECT MASP, SUM(soluong) AS SL
			FROM CTHD 
			GROUP BY MASP
		) AS B
	)
	GROUP BY Table1.MASP, Table1.TENSP	
GO 

EXEC sp_TimSpMuaNhieuNhat
GO

-- Câu 4: Kiểm tra số lượng tồn trong kho theo loại sản phẩm với tham số đầu vào là mã loại sản phẩm (@MALSPS)
CREATE PROC TONGSANPHAMTHEOLOAI @MALSPS CHAR(10)
AS
SELECT TOP 1 A.MALSP,A.TENLSP, SUM(B.SOLUONG) AS SOLUONGTON 
FROM LOAISANPHAM A, SANPHAM B
WHERE B.MALSP = @MALSPS AND A.MALSP = B.MALSP
GROUP BY A.MALSP, A.TENLSP
GO

EXEC TONGSANPHAMTHEOLOAI 'L1'
GO

--------TRIGGER----------

-- Câu 1: Ngày bán hàng của một nhân viên phải lớn hơn hoặc bằng ngày nhân viên đó vào làm.
CREATE TRIGGER tg_NHAPNGAYBANM
ON HOADON
FOR INSERT
AS
IF(SELECT NGAYHD FROM inserted) >= (SELECT NGAYVL FROM NHANVIEN A,inserted B WHERE A.MANV = B.MANV)
PRINT N'NHẬP THÀNH CÔNG'
ELSE
	BEGIN
		PRINT N'NHẬP NGÀY BÁN LỚN HƠN NGÀY VÀO LÀM CỦA NHÂN VIÊN'
		ROLLBACK TRAN
	END
GO
--Câu 2: Set thành tiền hóa đơn khi thêm chi tiết hóa đơn
CREATE TRIGGER TR_SetThanhTienHD ON dbo.CTHD FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @SoHD INT
    SELECT @SoHD = Inserted.SOHD FROM Inserted
	UPDATE HOADON SET thanhtienhd = (SELECT SUM(CTHD.thanhtien) FROM dbo.CTHD, Inserted WHERE CTHD.SOHD = @SoHD)
					FROM CTHD
					WHERE HOADON.SOHD = CTHD.SOHD AND CTHD.SOHD = @SoHD
END
GO 


--Câu 2: Kiểm tra giá bán nhập vào phải lớn hơn 0
create trigger tg_kiemtragiaban
on sanpham
for insert
as 
if(select GIABAN from inserted)>0
print N'NHẬP THÀNH CÔNG'
else 
begin 
	print N'Nhập thất bại (GIÁ BÁN PHẢI LỚN HƠN 0)'
	rollback tran
end
GO

-- Update thành tiền cthd khi thêm mới sp, vd tăng số lượng, thành tiền của sản phẩm sẽ tự tính
CREATE TRIGGER TR_UpdateThanhTienCTHD ON CTHD FOR INSERT, UPDATE 
AS 
BEGIN 
	DECLARE @SoLuongBan INT
	DECLARE @MaSP VARCHAR(10)
	
	SELECT @MaSP = Inserted.MASP FROM INSERTED
	SELECT @SoLuongBan = Inserted.SOLUONG FROM Inserted	 

	
	DECLARE @SOHD INT
	SELECT @SOHD = Inserted.SOHD FROM Inserted
	
	-- Update gia san pham
	UPDATE CTHD SET dongia = GIABAN 
				FROM SANPHAM 
				WHERE @MaSP = SANPHAM.MASP AND @SOHD = SOHD AND SANPHAM.MASP = CTHD.MASP
	-- Update thanh tien san pham
	UPDATE CTHD SET thanhtien = @SoLuongBan * dongia 
				WHERE SOHD = @SOHD AND MASP = @MaSP 	

END
GO

--Câu 4: Kiểm tra nhân viên xin vào làm đủ 18 tuổi
CREATE TRIGGER TR_NgayVL ON dbo.NHANVIEN FOR  INSERT, UPDATE 
AS 
BEGIN 
	DECLARE @NgaySinh DATE
	DECLARE @NgayVL DATE
    SELECT @NgaySinh = INSERTED.ngaysinh, @NgayVL = Inserted.NGAYVL FROM INSERTED, dbo.nhanvien WHERE nhanvien.manv = Inserted.manv

	IF ((YEAR(@NgayVL) - YEAR(@NgaySinh)) < 18)
	BEGIN
		IF (((YEAR(@NgayVL) - YEAR(@NgaySinh)) = 17) AND (DAY(@NgayVL) - DAY(@NgaySinh)) > 0)
			
			ROLLBACK TRAN
		ELSE IF (YEAR(@NgayVL) - YEAR(@NgaySinh) < 17)
			ROLLBACK TRAN
	END 	
END 
GO



-- Set lại thành tiền hóa đơn khi xóa chi tiết hóa đơn
CREATE TRIGGER TR_DeleteThanhTienHD ON dbo.CTHD FOR DELETE
AS
BEGIN
	DECLARE @SoHD INT
    SELECT @SoHD = Deleted.SOHD FROM Deleted
	UPDATE HOADON SET THANHTIENHD = (SELECT SUM(CTHD.thanhtien) FROM dbo.CTHD, Deleted WHERE CTHD.SOHD = @SoHD)
					FROM CTHD 
					WHERE HOADON.SOHD = CTHD.SOHD AND CTHD.SOHD = @SoHD
END
GO


