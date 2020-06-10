create database Gestion_Employe

create table Service (
	Code varchar(20) primary key,
	libellé varchar(50)
)

create table Employe (
	Matricule varchar(20) primary key,
	Nom varchar(50), 
	Prénom varchar(50), 
	Date_naissance Date, 
	grade varchar(50), 
	échelle varchar(50), 
	code_service varchar(20) foreign key references Service(Code)
) 

create table Conge (
	Matricule varchar(20) foreign key references Employe(Matricule), 
	Date_congé Date, 
	Type_congé varchar(20),
	Durée int
)

	select * from Conge