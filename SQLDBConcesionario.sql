create database concesionarioWH
use concesionarioWH
create table Tipo_Vehiculo
(
    id int primary key,
    nombre varchar(25)
)
create proc addTipoVehiculo
(
    @id int,
    @nombre varchar(25)
)
as insert into Tipo_Vehiculo values(@id, @nombre)
select * from contrato
exec delete_contrato '2'
exec addTipoVehiculo '1','Camion'

create proc updateTipo_Vehiculo
(
    @id int,
    @nombre varchar(25)
)
as update Tipo_Vehiculo set nombre=@nombre
where id=@id

create proc deleteTipo_Vehiculo
(
    @id int
)
as delete from Tipo_Vehiculo where id = @id
exec deleteTipo_Vehiculo '1'
select * from Vehiculo


create table tip_conductor
(
 id int primary key,
 tipo_conductor varchar(30)
)

create proc addtipconductor
(
 @id int,
 @tipo_conductor varchar(30)
)
as insert into tip_conductor values (@id, @tipo_conductor)
exec addtip_conductor 19162, motocicleta

create proc updateaddtipconductor
(
    @id int,
    @tipo_conductor varchar(30)
)
as update tip_conductor set tipo_conductor = @tipo_conductor
where id=@id

create proc deleteaddtip_conductor
(
    @id int
)
as delete from tip_conductor where id = @id
/*...............*/



create table Vehiculo
(
    id int primary key,
    marca varchar(25) unique,
    modelo varchar(25) not null,
    placa varchar(6) not null,
    anio int not null,
    id_tv int not null,
    constraint rel_a_tipovehi foreign key (id_tv) references Tipo_Vehiculo (id)
)
create proc addVehiculo
(
    @id int,
    @marca varchar(25),
    @modelo varchar(25),
    @placa varchar(6),
    @anio int,
    @id_tv int
)
as insert into Vehiculo values (@id, @marca, @modelo, @placa, @anio, @id_tv)
exec addVehiculo 2,'Chevy','CX3','asd123',2019,1
select * from Vehiculo

create proc update_addVehiculo
(
    @id int,
    @marca varchar(25),
	@modelo varchar (25),
	@placa varchar (6),
	@anio int,
	@id_tv int
)
as update Vehiculo set marca=@marca, modelo=@modelo, placa=@placa, anio=@anio, id_tv=@id_tv 
where id=@id

create proc delete_addVehiculo
(
    @id int
)
as delete Vehiculo where id=@id
exec delete_addVehiculo '1'


create proc delete_vehiculo
(
    @id int
)
as delete from tip_conductor where id = @id
/*..............*/




create table conductor 
(
	id  int primary key,
	nombre varchar(30),
	tipo_licencia varchar(20),
	id_vehiculo int,
	id_tipo_conductor int
	constraint rela_id_vehiculos foreign key (id_vehiculo) references Vehiculo (id),
	constraint rela_id_tipo_conductor foreign key (id_tipo_conductor) references tip_conductor (id)
)

create proc as_conductor
(
	@id int,
	@nombre varchar(30),
	@tipo_licencia varchar(20),
	@id_vehiculo int,
	@id_tipo_conductor int
)
as insert into conductor values (@id, @nombre, @tipo_licencia, @id_vehiculo, @id_tipo_conductor)
exec as_conductor 14, Juan, completa, 2,19162
select *from conductor

create proc update_Conductor
(
    @id int,
    @nombre varchar(25),
	@tipo_licencia varchar (25),
	@id_vehiculo int,
	@id_tipo_conductor int
)
as update conductor set nombre = @nombre, tipo_licencia = @tipo_licencia, id_vehiculo = @id_vehiculo, id_tipo_conductor = @id_tipo_conductor
where id=@id

create proc delete_Conductor
(
    @id int
)
as delete conductor where id=@id
/*.....................*/





create table contrato
(
id int primary key,
id_conductor int,
id_vehiculo int, 
constraint rel_a_conductor foreign key (id_conductor) references conductor (id),
constraint rel_a_vehiculo foreign key (id_vehiculo) references vehiculo (id),
)

create proc ascontrato
(
@id int,
@id_conductor int,
@id_vehiculo int
)
as insert into contrato values (@id, @id_conductor, @id_vehiculo)
exec ascontrato 10, 14, 2
select *from contrato

create proc update_contrato
(
@id int,
@id_conductor int,
@id_vehiculo int
)
as update contrato set id_conductor = @id_conductor, id_vehiculo = @id_vehiculo
where id = @id

create proc delete_contrato
(
    @id int
)
as delete contrato where id=@id
/*..............*/






create table ruta
(
 id int primary key,
 estacion varchar(30),
 id_vehiculo int
 constraint rel_a_vehiculo2 foreign key (id_vehiculo) references vehiculo (id)
)
select * from ruta

create proc pro_ruta
(
 @id int,
 @estacion varchar(30),
 @id_vehiculo int
)
as insert into ruta values (@id, @estacion, @id_vehiculo)
exec pro_ruta 11111,Berrio,2

create proc update_ruta
(
@id int,
@estacion varchar(30),
@id_vehiculo int
)
as update ruta set estacion = @estacion, id_vehiculo = @id_vehiculo
where id = @id

create proc delete_ruta
(
@id int
)
as delete ruta where id = @id








create table tip_conductor
(
 id int primary key,
 tipo_conductor varchar(30)
)

create proc addtip_conductor
(
 @id int,
 @tipo_conductor varchar(30)
)
as insert into tip_conductor values (@id, @tipo_conductor)
exec addtip_conductor 19162, motocicleta
