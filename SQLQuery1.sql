create database UAS_21312027;

use UAS_21312027;

create table tbl_pasien(
NoPasien char(5) primary key,
NamaPasien Varchar(25),
AlamatPasien varchar(100)
);

insert into tbl_pasien values(
12345,
'Muhammad',
'Lampung')


create table tbl_history(
NoPasien char(5),
Keterangan varchar(20));

create procedure sp_simpan
@nopasien char (5),
@namapasien varchar (25),
@alamatpasien varchar(25)
as
begin
insert into tbl_pasien values 
(@nopasien, 
@namapasien,
@alamatpasien
);end;

create procedure SP_Ubah
@nopasien char(5),
@namapasien varchar(25),
@alamatpasien varchar(25)
as
begin
update tbl_pasien set 
 NoPasien =  @nopasien, 
 NamaPasien = @namapasien,
 AlamatPasien = @alamatpasien
 where NoPasien = @nopasien
;end;

create procedure SP_Hapus
@nopasien char(5)
as
begin
delete from tbl_pasien where 
(NoPasien = @nopasien
);end;

create procedure SP_Cari
@namapasien varchar(25)
as 
begin 
select * from tbl_pasien
where NamaPasien like '%' +@namapasien + '%';
end;

create trigger AfterInsert_Pasien
on tbl_history
after insert
as begin
declare 
@NoPasien char(5), Keterangan varchar(20)
select @NoPasien=NoPasien
 from inserted
 update tbl_history set NoPasien=@NoPasien, Keterangan ='Berhasil'
 where tbl_pasien.NoPasien = @NoPasien;end;