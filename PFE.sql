create database Gestion_de_infirmier
go
use  Gestion_de_infirmier
go 
--Table de Admine
create table admine(
Username varchar(100) primary key,
Password varchar(7))
-----------------------------------------------------------------------
insert into admine values('elbalghy','admine')
-----------------------------------------------------------------------
--table sexe
create table sexe(
sex char primary key 
) 

--table Nationalité
Create table Nationalité(
    Idcon	varchar(300),
    Country varchar(300)
)

--Table de Infirmiers
create table Infirmiers(
CIN varchar(8) primary key ,
Nom varchar(40),
Prénom varchar(50),
date_Naissance date,
lieu_Naissance varchar(60),
Massar varchar(10),
Photo varbinary(max),
sex char foreign key references sexe(sex),
Idcon varchar(300) foreign key references Nationalité(Idcon)
 )

-----------------------------------------------------------------------
-----------------------------------------------------------------------

--Table Coordonnées
create table Coordonnées(
CIN varchar(8) foreign key references Infirmiers(CIN),
Téléphone varchar(10),
Email varchar(100),
Address varchar(100),primary key(CIN)) 
ON UPDATE CASCADE
ON DELETE CASCADE

--Table Options
create table Options (
     option_lable varchar(100) ,
	 )

--Table Mention_bac
create table Mention_bac(
     Mention_lable varchar(100))

--Table Scolarité
create table Scolarité(
    CIN varchar(8) foreign key references Infirmiers(CIN),
    Année_bac date ,
	option_lable varchar(100) foreign key references Options(option_lable),
	Idcon varchar(300) foreign key references Nationalité(Idcon),
	Mention_lable varchar(100) foreign key references Mention_bac(Mention_lable),
	primary key(CIN)
)

-----------------------------------------------------------------------
-----------------------------------------------------------------------

--Table Filiére
create table Filiére (
     idF int primary key,
	 Filiére_lable varchar(100)
)

--Table Option Filiére

create table Option_Filiére(
     idO int primary key,
	 Option_lable varchar(100)
)

--Table Semestre
create table Semestre(
     idS int primary key,
     S_label varchar(2)
)








