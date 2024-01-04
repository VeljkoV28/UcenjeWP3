use master;
go
drop database if exists Frizerski_salon;
go
create database Frizerski_salon;
go
use Frizerski_Salon

Create table Djelatnice(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
IBAN varchar(50) not null,
Broj_moba varchar(50) not null
);

Create table Korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
Broj_moba varchar(50) not null,
djelatnik int not null
);

Create table Usluge(
sifra int not null primary key identity(1,1),
vrsta varchar (50) not null
);

Create Table Posjete(
sifra int not null primary key identity(1,1),
Vrijeme_usluge datetime,
Djelatnik int not null,
Korisnik int not null,
Usluga int not null
);



alter table Posjete add foreign key (Djelatnik) references Djelatnice(sifra);
alter table Posjete add foreign key (Korisnik) references Korisnici(sifra);
alter table Posjete add foreign key (Usluga) references Usluge(sifra);
alter table Korisnici add foreign key (djelatnik) references Djelatnice(sifra);
