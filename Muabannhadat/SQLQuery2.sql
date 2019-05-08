-- Insert Tỉnh
insert into Tinh values(N'Hà Nội')
insert into Tinh values(N'TPHCM')
insert into Tinh values(N'Hải Phòng')
-- Insert Quận
insert into Quan values(N'TPHCM', N'Quận 1')
insert into Quan values(N'TPHCM', N'Quận 2')
insert into Quan values(N'TPHCM', N'Quận 3')
insert into Quan values(N'TPHCM', N'Quận 4')
insert into Quan values(N'TPHCM', N'Quận 5')
insert into Quan values(N'TPHCM', N'Quận 6')
insert into Quan values(N'TPHCM', N'Quận 7')
insert into Quan values(N'TPHCM', N'Quận 9')
-- Insert Đường
insert into Duong values(N'TPHCM', N'Quận 9', N'Ngô Quyền')
insert into Duong values(N'TPHCM', N'Quận 9', N'Trường Chinh')
insert into Duong values(N'TPHCM', N'Quận 9', N'Văn Hiển')
insert into Duong values(N'TPHCM', N'Quận 9', N'Lý Thường Kiệt')
insert into Duong values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng')
-- Insert Số nhà
insert into Sonha values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng', 1)
insert into Sonha values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng', 2)
insert into Sonha values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng', 3)
insert into Sonha values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng', 4)
insert into Sonha values(N'TPHCM', N'Quận 9', N'Trần Duy Hưng', 5)
---
select * from Taikhoan where username = 'a'
--
-- Insert dự án
insert into DuAn values(6, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)
insert into DuAn values(7, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)
insert into DuAn values(8, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)
insert into DuAn values(9, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)
insert into DuAn values(10, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)
insert into DuAn values(11, N'Bãi Tắm C', N'A', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 1)

select * from TinBDS
-- Insert Tin BĐS 
insert into TinBDS values ('tt', 'a', 'a', GETDATE(), 'a')
insert into TinBDS values ('t1', 'a11', 'ba', GETDATE(), 'a')
insert into TinBDS values ('ttbb', 'aea', 'a', GETDATE(), 'a')
insert into TinBDS values ('tt', 'a4', 'a', GETDATE(), 'a')
insert into TinBDS values ('tt', 'a5', 'a', GETDATE(), 'a')
insert into TinBDS values ('tt', 'a6', 'a', GETDATE(), 'a')
insert into TinBDS values ('tt', 'a2', 'a', GETDATE(), 'a')
-- Insert Tài khoản
insert into Taikhoan values ( 'a', 'a', N'Ríp hàng', 'Nam', 'a@gmail.com', '1100', N'Intel', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 4)
insert into Taikhoan values ( 'aa', '1', N'Ríp hàng', 'Nam', 'a@gmail.com', '1100', N'Intel', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 4)
insert into Taikhoan values ( 'aaa', '1', N'Ríp hàng', 'Nam', 'a@gmail.com', '1100', N'Intel', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 4)
insert into Taikhoan values ( 'aaaa', '1', N'Ríp hàng', 'Nam', 'a@gmail.com', '1100', N'Intel', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 4)
-- Procedure đăng nhập
alter proc usp_login
@username varchar(50), @password varchar(50)
as
begin
	select * 
	from Taikhoan 
	where username = @username and password = @password
end
go

-- Insert Dịch vụ đăng
insert into Dichvudang values (2, N'Hiển thị nỗi bật', 10000, 2)
insert into Dichvudang values (2, N'Miễn phí', 10000, 2)
-- Procedure Cập nhật tài khoản
alter proc usp_capnhattaikhoan
@username varchar(50), @ten nvarchar(50), @tenct nvarchar(50), @gioitinh nvarchar(50), @email varchar(50), @sdt varchar(50)
as
begin
	update Taikhoan
	set ten = @ten, tenct = @tenct, gioitinh = @gioitinh, email = @email, sdt = @sdt
	where username = @username
end
go

-- Function đếm số lượng tin đăng
alter function usf_demtindang ()
returns int
as
begin
	declare @ketqua int = 0
	select @ketqua = COUNT(*) from Tindang

	return @ketqua
end
go

-- Function trả về giá cao nhất của BĐS thuộc TPHCM, Quận 9, Lê Văn Việt
create function usf_maxgia()
returns float
as
begin
	declare @ketqua float = 0
	select @ketqua = MAX(gia)
	from BDS
	where tentinh = N'TPHCM' and tenquan = N'Quận 9' and tenduong = N'Lê Văn Việt'

	return @ketqua
end
go

--
select * from Tinh
select * from BDS
select * from Dichvudang
select * from Quan where tentinh = N'TPHCM'
select * from Duong where tentinh = N'TPHCM' and tenquan = N'Quận 9'
select * from Sonha where tentinh = N'TPHCM' and tenquan = N'Quận 9' and tenduong = N'Man Thiện'

-- Procedure Insert tin đăng
alter proc usp_inserttindang
@tieude nvarchar(50), @loaitin nvarchar(50), @username varchar(50),
@tenbds nvarchar(50), @loaibds nvarchar(50), @mota nvarchar(400), @gia float, @dientich int, @sdt varchar(50),
@email varchar(50), @sophong int, @block nvarchar(50), @maduan int, @tentinh nvarchar(50), @tenquan nvarchar(50),
@tenduong nvarchar(50), @sonha int, @tendichvu nvarchar(50)
as
begin
	insert into Tindang  values (@tieude, @loaitin, 1, GETDATE(), @username)
	declare @idtin int
	select @idtin = a.id from Tindang a where a.ten = @tieude
	insert into BDS values (@idtin, @tenbds, @loaibds, @mota, @gia, @dientich, @sdt, @email, @sophong, @block, @maduan, @tentinh, @tenquan, @tenduong, @sonha )
	declare @madichvu int
	select @madichvu = a.id from Dichvudang a where a.ten = @tendichvu
	insert into R_co values(@idtin, @madichvu)
end
go


select * from Tindang
select * from R_co
delete from R_co

delete from Tindang where tentk = 'a'
insert into Tindang  values (N'Anh Sai rồi', N'@loaitin', 1, GETDATE(), 'a')

select * from Tindang
insert into Tindang  values (N'a', N'@loaitin', 1, GETDATE(), 'a')
declare @idtin int
select @idtin = a.id from Tindang a where a.ten = N'a'
print @idtin

select * from DuAn
insert into DuAn values (3, N'c', N'MR c', N'TPHCM', N'Quận 9', N'Lê Văn Việt', 4)

exec usp_inserttindang @tieude = N'Ngu quá' , @loaitin = N'Bán' , @username = 'a' ,
@tenbds = N'Căn Hộ' , @loaibds = N'a' , @mota = N'Ngu người' , @gia = 10 , @dientich = 1 , @sdt = '44' ,
@email = 'a' , @sophong = 1 , @block = 'a' , @maduan = 1 , @tentinh = N'TPHCM' , @tenquan = N'Quận 9' ,
@tenduong = N'Ngô Quyền', @sonha = 1, @tendichvu = N'Miễn phí'

select * from Tindang
select * from BDS
select * from R_co
select * from Dichvudang
delete from Tindang
delete from R_co

select * from Tindang
select * from Tindang a, BDS b where a.id = b.matin
select * from DuAn

select * from Tindang -- ten, loai tin, ngay dang
select * from BDS -- mota, gia, dien tich, sdt, email, tentinh, tenquan, tenduong, sonha

select * from Tindang a, BDS b where a.id = b.matin and a.ten like N'%a%'
select * from Tindang

alter trigger utg_updatetaikhoan
on Taikhoan
for update, insert
as
begin
	if exists(select * from inserted i where i.gioitinh not in (N'Nam', N'Nữ'))
	begin
		raiserror('Nhập không đúng giới tính', 16, 1)
		rollback tran
	end
	
	declare @emailtemp varchar(50)
	select @emailtemp = i.email  from inserted i

	update BDS
	set email = @emailtemp
	where matin in (select tin.id from inserted i, Tindang tin, BDS b where i.username = tin.tentk and tin.id = b.matin)
end
go
