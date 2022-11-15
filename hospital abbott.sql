create database HOSPITAL;
create table doctor (
id_doc int,
apellido varchar(15),
Nro_matricula int,
Nro_depto int,
nombre varchar(15),
 PRIMARY KEY (id_doc)
);
create table paciente (
id_pac int,
apellido varchar(15),
direccion varchar(20),
sexo varchar(15),
nombre varchar(15),
cuil int,
PRIMARY KEY(id_pac)
);
create table departamento (
id_dep int,
ubicacion varchar(15),
medico varchar (25),
camas_disp int,
camas_ocu int,
PRIMARY KEY(id_dep)
);
create table medicamento (
id_med int,
provedor varchar(20),
tipo varchar(20),
vencimiento date,
nombre varchar(15),
PRIMARY KEY(id_med)
);
create table citas (
id_cit int,
fecha date,
paciente varchar(20),
horario int,
PRIMARY KEY(id_cit)
);
