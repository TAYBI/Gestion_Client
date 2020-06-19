create database Gestion_Employe
drop database Gestion_Employe

create table Service (
	Code varchar(20) primary key,
	libell� varchar(50)
)

create table Employe (
	Matricule varchar(20) primary key,
	Nom varchar(50), 
	Pr�nom varchar(50), 
	Date_naissance Date, 
	grade varchar(50), 
	�chelle varchar(50), 
	code_service varchar(20) foreign key references Service(Code)
) 

create table Conge (
	Matricule varchar(20) foreign key references Employe(Matricule), 
	Date_cong� Date, 
	Type_cong� varchar(20),
	Dur�e int
)

create table Parametres_dates(
	date1 date,
	date2 date
)
