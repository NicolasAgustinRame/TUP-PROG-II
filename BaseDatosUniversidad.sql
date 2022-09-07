create database BaseDatosUniversidad 

use BaseDatosUniversidad

--Tabla Asignatura
create table Asignaturas
(codAsignatura int IDENTITY (1,1),
nombre varchar (100),
constraint pk_asignaturas PRIMARY KEY (codAsignatura))

--Tabla Carreras
create table Carreras 
(codCarrera int IDENTITY (1,1),
nombreTitulo varchar (100),
constraint pk_carreras PRIMARY KEY (codCarrera))

--Tabla Detalle Carreras
create table DetallesCarreras 
(codDetalleCarrera int identity (1,1),
anioCursado int,
cuatrimestre int,
codAsignatura int,
codCarrera int, 
constraint pk_DetCarreras Primary Key (codDetalleCarrera),
constraint fk_Asig_DetCarrera FOREIGN KEY (codAsignatura) references Asignaturas (codAsignatura),
constraint fk_Carrera_DetCarrera FOREIGN KEY (codCarrera) references Carreras (codCarrera))

--Inserts Asignaturas
insert into Asignaturas values ('Programaci�n I')
insert into Asignaturas values ('Laboratorio de Computaci�n I')
insert into Asignaturas values ('Ingl�s I')
insert into Asignaturas values ('SPD')
insert into Asignaturas values ('Matem�tica')

insert into Asignaturas values ('Programaci�n II')
insert into Asignaturas values ('Laboratorio de Computaci�n II')
insert into Asignaturas values ('Ingl�s II')
insert into Asignaturas values ('Arquitectura y Sistemas Operativos')
insert into Asignaturas values ('Estadistica')
insert into Asignaturas values ('Metodologia de Investigacion')

insert into Asignaturas values ('Programaci�n III')
insert into Asignaturas values ('Laboratorio de Computaci�n III')
insert into Asignaturas values ('Organizacion Empresarial')
insert into Asignaturas values ('Elementos de Investigacion Operativa')
insert into Asignaturas values ('Organizacion Contable de la Empresa')

insert into Asignaturas values ('Dise�o y Administracion de Base de Datos')
insert into Asignaturas values ('Laboratorio de Computacion IV')
insert into Asignaturas values ('Legislacion')
insert into Asignaturas values ('Metodologia de Sistemas I')
insert into Asignaturas values ('Practica Profesional')

--Procedimientos Almacenados 
create proc SP_CONSULTAR_ASIGNATURAS
as 
select codAsignatura, nombre from Asignaturas Order by 2

create proc SP_ADD_CARRERA
@nombreTitulo varchar (100),
@new_codCarrera int output 
as
begin
insert into Carreras(nombreTitulo)values (@nombreTitulo);
	set  @new_codCarrera = scope_identity();
end

create proc SP_ADD_DET
@anioCursado int,
@cuatrimestre int,
@codAsignatura int,
@codCarrera int
as
begin
insert into DetallesCarreras(anioCursado, cuatrimestre, codAsignatura, codCarrera)
	values (@anioCursado, @cuatrimestre, @codAsignatura, @codCarrera)
end

create proc SP_CONSULTAR_CARRERA
as
begin
	select codCarrera, nombreTitulo from carreras
	order by codCarrera
end

create proc SP_MOSTRAR_INFO
as 
select c.nombreTitulo as 'Carrera', a.nombre as Materia, dc.anioCursado  as 'A�o_Cursado', dc.cuatrimestre as Cuatrimestre
from DetallesCarreras dc join Carreras c on dc.codCarrera = c.codCarrera
		join Asignaturas a on dc.codAsignatura = a.codAsignatura

create proc SP_BajaLogica
@codAsignatura BIGINT
as
begin 
Update Asignaturas SET activa = 0
Where codAsignatura=@codAsignatura
end