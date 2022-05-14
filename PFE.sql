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

--table Nationalit�
Create table Nationalit�(
    Idcon	varchar(300),
    Country varchar(300)
)

--Table de Infirmiers
create table Infirmiers(
CIN varchar(8) primary key ,
Nom varchar(40),
Pr�nom varchar(50),
date_Naissance date,
lieu_Naissance varchar(60),
Massar varchar(10),
Photo varbinary(max),
sex char foreign key references sexe(sex),
Idcon varchar(300) foreign key references Nationalit�(Idcon)
 )

-----------------------------------------------------------------------
-----------------------------------------------------------------------

--Table Coordonn�es
create table Coordonn�es(
CIN varchar(8) foreign key references Infirmiers(CIN),
T�l�phone varchar(10),
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

--Table Scolarit�
create table Scolarit�(
    CIN varchar(8) foreign key references Infirmiers(CIN),
    Ann�e_bac date ,
	option_lable varchar(100) foreign key references Options(option_lable),
	Idcon varchar(300) foreign key references Nationalit�(Idcon),
	Mention_lable varchar(100) foreign key references Mention_bac(Mention_lable),
	primary key(CIN)
)

-----------------------------------------------------------------------
-----------------------------------------------------------------------

--Table Fili�re
create table Fili�re (
     idF int primary key,
	 Fili�re_lable varchar(100)
)

--Table Option Fili�re

create table Option_Fili�re(
     idO int primary key,
	 Option_lable varchar(100)
)

--Table Semestre
create table Semestre(
     idS int primary key,
     S_label varchar(2)
)








