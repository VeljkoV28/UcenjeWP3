create database Dnevnik_kalorija;
go
use Dnevnik_kalorija;
go

Create table Users(
Sifra int not null primary key identity(1,1),
Username varchar(50) not null,
Height_In_CM int not null,
Current_weight_KG int not null,
Calorie_Diary int null,
Obrok int null);
-- unijeti korisnika za FK, unijeti 
Create table Calorie_Diaries(
Sifra int not null primary key identity(1,1),
Activity varchar(200) not null,
User_ int null,
);



--