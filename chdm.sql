create database QLCHDM
use QLCHDM

create table khachhang(
	makh char(10) not null primary key,
	hovaten nvarchar(50) not null,
	diachi nvarchar(100) not null,
	sdt nvarchar(12) not null,
)
create table nhanvien(
	manv char(10) primary key,
	hovaten nvarchar(50),
	sdt nvarchar(12),
	ngayvl date,
	hsluong decimal
)
create table sanpham(
	masp char(10) not null primary key,
	tensp nvarchar(50),
	Soluong int,
	gia decimal,
	ngaynhap date
)
create table hoadon(
	sohd int not null primary key,
	ngayhd date not null,
	makh char(10) not null,
	manv char(10) not null,
)

ALTER TABLE hoadon
ADD CONSTRAINT fk_nhanvien
  FOREIGN KEY (manv)
  REFERENCES nhanvien (manv);
ALTER TABLE hoadon
ADD CONSTRAINT fk_khachhang
  FOREIGN KEY (makh)
  REFERENCES khachhang (makh);
	
drop table cthd
create table cthd(
	sohd int not null,
	masp char(10) not null,
	soluong int
)
alter table cthd add constraint pk_cthd primary key(sohd,masp)
ALTER TABLE cthd
ADD CONSTRAINT fk_hoadon
  FOREIGN KEY (sohd)
  REFERENCES hoadon (sohd);
ALTER TABLE cthd
ADD CONSTRAINT fk_sanpham
  FOREIGN KEY (masp)
  REFERENCES sanpham (masp);



insert into khachhang values ('kh1',N'Trần văn a',N'32/28 Tăng Nhơn phú A',039659856)
insert into khachhang values ('kh2',N'Trần văn b',N'32/28 Tăng Nhơn phú b',039669856)
insert into khachhang values ('kh3',N'Trần văn c',N'30/128 Tăng Nhơn phú A',039679856)
insert into khachhang values ('kh4',N'Trần văn d',N'21/280 Tăng Nhơn phú A',039689856)
insert into khachhang values ('kh5',N'Trần văn e',N'36/15 Tăng Nhơn phú A',039699856)

insert into nhanvien values('nv1',N'Nguyễn Văn A','0321021021','10/10/2021',3000000)
insert into nhanvien values('nv2',N'Nguyễn Văn B','0323021021','11/10/2021',3000000)

insert into sanpham values('sp1',N'Tivi samsung',3,10000000,'02/02/2021')
insert into sanpham values('sp2',N'Tủ lạnh samsung',3,20000000,'02/02/2021')
insert into sanpham values('sp3',N'samsung galaxy 6s plus',3,8000000,'02/02/2021')
insert into sanpham values('sp4',N'Tivi banasonic',3,9000000,'02/02/2021')
insert into sanpham values('sp5',N'Máy giặt aqua',3,8000000,'02/02/2021')
insert into sanpham values('sp6',N'laptop dell core i5',3,2000000,'02/02/2021')
insert into sanpham values('sp7',N'Macbook pro',3,4000000,'02/02/2021')

insert into hoadon values(1,'02/02/2021','kh1','nv1')
insert into hoadon values(2,'04/10/2021','kh1','nv1')
insert into hoadon values(3,'05/02/2021','kh1','nv2')
insert into hoadon values(4,'06/02/2021','kh1','nv1')
insert into hoadon values(5,'07/02/2021','kh1','nv1')
insert into hoadon values(6,'08/11/2021','kh2','nv1')
insert into hoadon values(7,'09/21/2021','kh3','nv2')
insert into hoadon values(8,'12/02/2021','kh4','nv2')
insert into hoadon values(9,'02/20/2021','kh1','nv2')
insert into hoadon values(10,'01/02/2021','kh1','nv2')
insert into hoadon values(11,'09/02/2021','kh1','nv2')
insert into hoadon values(12,'02/02/2021','kh1','nv1')

insert into cthd values(1,'sp3',1)
insert into cthd values(2,'sp2',1)
insert into cthd values(2,'sp7',1)
insert into cthd values(3,'sp3',1)
insert into cthd values(3,'sp4',1)
insert into cthd values(1,'sp2',1)

select * from hoadon

create table _user(
	tendangnhap char(20) not null primary key,
	matkhau char(20) not null
)

insert into _user values('a','1')
insert into _user values('admin','123456789')
insert into _user values('user','12345')
