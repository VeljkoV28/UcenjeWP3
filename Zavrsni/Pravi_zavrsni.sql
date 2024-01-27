Use master;
go
Drop database if exists Dnevnik_kalorija;
go
create database Dnevnik_kalorija;
go
use Dnevnik_kalorija;
go

Create table Users(
Sifra int not null primary key identity(1,1),
Username varchar(50) not null,
Height_In_CM int not null,
Current_weight_KG int not null,
);
-- unijeti korisnika za FK, unijeti 
Create table Calorie_Diaries(
Sifra int not null primary key identity(1,1),
Type_of_Activity varchar(200) not null,
Calories_burned int not null,
User_ int,
);
Create table Meals(
Sifra int not null primary key identity(1,1),
Name_ varchar (250) not null,
Portion int not null,
Calories_consumed int not null,
User_ int,
);
Create table Food(
Sifra int not null primary key identity(1,1),
Food_name varchar(250) not null,
Calories_per_100g decimal(18,2) not null,
Meal int,
);
alter table Calorie_Diaries add foreign key (User_) references Users(Sifra);
alter table Meals add foreign key (User_) references Users(Sifra);
alter table Food add foreign key (Meal) references Meals(Sifra);



 Insert into Users (Username, Height_In_CM, Current_weight_KG) values
 ('Veljko2805', 168, 67),
 ('Jopa_01' , 175, 85),
 ('Matko2501' , 172, 79),
 ('Petrich1712' , 166, 58),
 ('Zitarica2801' , 158, 55),
 ('Lega_Sokol' , 180, 80),
 ('Jure123' , 200, 120);
 

 Insert into Calorie_Diaries (Type_of_Activity) values
 ('Tri Sata hodanja, jedan sat trcanja, sedam sati spavanja, osam sati provedeno na poslu' ),
 ('dva sata hodanja, dva sata treniranja u gymu i osam sati spavanja, devet sati rada na skeli'),
 ('Hodanje jedan sat, Spavanje jedanaest sati, Igranje nogomet dva sata'),
 ('Spavanje osam sati, dva i pol sata trcanja, dva sata treniranja kickboxa, osam sati rada'),
 ('Voznja biciklom dva sata, cetri sata plesnog treninga, sest sati rada, pet sati sna') ,
 ('sest sati sna, jedan sat voznje biciklom, dva i pol sata treninga u teretani, devet sati rada u fitness centru'),
 ('sedam sati sna, jedan sat hodanja, jedan sat trcanja na inclinu lvl jedanest, jedan sat treniranja u teretani,');

 Insert into Calorie_Diaries (Calories_burned) values
 (900),
 (1500),
 (2000),
 (1000),
 (1700),
 (2150),
 (1200);

 Insert into Meals (Name_, Portion, Calories_consumed) values
 ('Breast fried, ', 3, 540),
 ('French fries', 1, 198),
 ('Pizza', 4, 976),
 ('Calzone', 454),
 ('Ice cream', 2, 548),
 ('Deep fried hake', 3, 510),
 ('Pizza', 1, 976);

 Insert into Food (Food_name, Calories_per_100g) values
 ('Breast fried', 180),
 ('Deep fried hake', 170),
 ('Ice cream', 274),
 ('Tartar', 350),
 ('Kinder bueno', 488),
 ('Breast, raw', 165),
 ('French fries', 198),
 ('Gouda cheese', 400),
 ('Calzone', 227),
 ('Pizza', 976);
