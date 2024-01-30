Use master;
go
Drop database if exists Dnevnik_kalorija;
go
create database Dnevnik_kalorija;
go
use Dnevnik_kalorija;
go

Create table Korisnici(
Sifra int not null primary key identity(1,1),
Korisnicko_ime varchar(50) not null,
Visina_u_CM int not null,
Trenutna_tezina_KG int not null,
Zeljena_tezina_KG int not null,
);
-- unijeti korisnika za FK, unijeti 
Create table Dnevnik_kalorija(
Sifra int not null primary key identity(1,1),
Vrsta_aktivnosti varchar(1000) not null,
Potroseno_kalorija int not null,
Korisnik int not null,
);
Create table Obroci(
Sifra int not null primary key identity(1,1),
Hrana int not null,
Porcija int not null,
Uneseno_kalorija int not null,
Korisnik_ int not null,
);
Create table Hrana(
Sifra int not null primary key identity(1,1),
Naziv_hrane varchar(250) not null,
Kalorije_na_100g decimal(18,2) not null,
Obrok int,
);
alter table Dnevnik_kalorija add foreign key (Korisnik) references Korisnici(Sifra);
alter table Obroci add foreign key (Korisnik_) references Korisnici(Sifra);
alter table Hrana add foreign key (Obrok) references Obroci(Sifra);



 Insert into Korisnici (Korisnicko_ime, Visina_u_CM , Trenutna_tezina_KG, Zeljena_tezina_KG) values
 ('Veljko2805', 168, 67, 64), --1
 ('Jopa_01' , 175, 85, 78), --2
 ('Matko2501' , 172, 79, 70), --3
 ('Petrich1712' , 166, 58, 53), --4
 ('Zitarica2801' , 158, 55, 51), --5
 ('Lega_Sokol' , 180, 80, 75), --6
 ('Jure123' , 200, 120, 110) --7
 

 Insert into Dnevnik_kalorija (Vrsta_aktivnosti, Potroseno_kalorija, Korisnik) values
 ('Tri Sata hodanja, jedan sat trcanja, sedam sati spavanja, osam sati provedeno na poslu', 900, 1 ),
 ('dva sata hodanja, dva sata treniranja u gymu i osam sati spavanja, devet sati rada na skeli', 1500, 2),
 ('Hodanje jedan sat, Spavanje jedanaest sati, Igranje nogomet dva sata', 2000, 3),
 ('Spavanje osam sati, dva i pol sata trcanja, dva sata treniranja kickboxa, osam sati rada', 1000, 4),
 ('Voznja biciklom dva sata, cetri sata plesnog treninga, sest sati rada, pet sati sna', 1700, 5) ,
 ('sest sati sna, jedan sat voznje biciklom, dva i pol sata treninga u teretani, devet sati rada u fitness centru', 2150, 6),
 ('sedam sati sna, jedan sat hodanja, jedan sat trcanja na inclinu lvl jedanest, jedan sat treniranja u teretani',1200, 7);

 
 Insert into Obroci (Hrana, Porcija, Uneseno_kalorija, Korisnik_) values
 (1, 3, 540, 1),
 (7, 1, 198, 2),
 (9, 4, 976, 3),
 (8, 1, 454, 4),
 (2, 2, 548, 5),
 (9, 1, 976, 6),
 (8, 2, 800, 7);

 Insert into Hrana (Naziv_hrane, Kalorije_na_100g) values
 --1
 ('Pohana pileca prsa', 180),
 --2
 ('Sladoled', 274),
 --3
 ('Tartar', 350),
 --4
 ('Kinder bueno', 488),
 --5
 ('Pileca prsa na zaru', 165),
 --6
 ('Pomfrit', 198),
 --7
 ('Gouda sir', 400),
 --8
 ('Preklopljena pizza', 227),
 --9
 ('Pizza', 976);
