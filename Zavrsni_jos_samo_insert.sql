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
Portion int not null,
Calories_consumed decimal(18,2) not null,
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



