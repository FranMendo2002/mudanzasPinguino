drop database if exists Mudanzas_Pinguino;
create database Mudanzas_Pinguino;
use Mudanzas_Pinguino;

create table cliente(
idCliente int auto_increment,
DNI int,
nombre varchar(20),
apellido varchar(20),
telefono int,
telefonoL int,
email varchar(40),
direccionOrigen varchar(40),
constraint pk_cliente primary key(idCliente)
)engine=innoDB;

create table notapedido(
idNota int,
cliente int,
fechaPosible date,
horaPosible time,
direccionDestino varchar(40),
fechaE date,
constraint pk_notapedido primary key(idNota),
constraint fk_cliente foreign key(cliente) references cliente(idCliente)
)engine=innoDB;

create table detallepedido(
idDetalle int,
idNota int,
muebles int,
camiones int,
fletes int,
empleados int,
fechaMud date,
constraint pk_detallepedido primary key(idDetalle),
constraint fk_notapedido foreign key(idNota) references notapedido(idNota) on delete cascade
)engine=innoDB;

/*create table costos(
tipoT int,
distancia int,
monto float,
)engine=innoDB*/

create table presupuesto(
idPresupuesto int,
idNota int,
precio float,
fecha date,
fechaVen date,
montoRes float,
estado varchar(20),
constraint pk_presupuesto primary key(idPresupuesto),
constraint fk_detallepedido foreign key(idNota) references detallepedido(idDetalle) on delete cascade
)engine=innoDB;

create table notareserva(
idReserva int,
idPresupuesto int,
montoRes float,
estado varchar(20),
fechaE date,
constraint pk_notareserva primary key(idReserva),
constraint fk_presupuesto foreign key(idPresupuesto) references presupuesto(idPresupuesto) on delete cascade
)engine=innoDB;

create table recibos(
idRecibo int auto_increment,
idPresupuesto int,
idReserva int,
constraint pk_recibos primary key(idRecibo),
constraint fk_Rpresupuesto foreign key(idPresupuesto) references presupuesto(idPresupuesto) on delete cascade,
constraint fk_notareserva foreign key(idReserva) references notareserva(idReserva) on delete cascade
)engine=innoDB;

create table Servicios(
idServicio int,
Fecha date,
Hora time,
idPresupuesto int,
cliente int,
direccionOrigen varchar(40),
direccionFinal varchar(40),
Estado varchar(15),
constraint pk_Servicios primary key(idServicio),
constraint fk_Spresupuesto foreign key(idPresupuesto) references presupuesto(idPresupuesto) on delete cascade,
constraint fk_Scliente foreign key(cliente) references cliente(idCliente)
)engine=innoDB;

create table Empleados(
idEmpleado int,
Nombre varchar(20),
Apellido varchar(20),
Telefono int,
Especialidad varchar(20),
constraint pk_Empleados primary key(idEmpleado)
)engine=innoDB;

create table Camiones(
idCamion int,
Patente varchar(10),
Marca varchar(20),
Modelo varchar(20),
taraDisponible float,
constraint pk_Camiones primary key(idCamion)
)engine=innoDB;

create table serviciorecursos(
idServicio int,
idEmpleado int,
idCamion int,
constraint fk_SRservicios foreign key(idServicio) references Servicios(idServicio) on delete cascade,
constraint fk_SRempleado foreign key(idEmpleado) references Empleados(idEmpleado),
constraint fk_SRcamion foreign key(idCamion) references Camiones(idCamion)
)engine=innoDB;

create table cheques(
idCheque int,
cliente int,
monto float,
montoEscrito char(60),
fechaE date,
fechaP date,
constraint pk_cheques primary key(idCheque),
constraint fk_Chcliente foreign key(cliente) references cliente(idCliente)
)engine=innoDB;

create table Danios(
idDanios int,
idCheque int,
idServicios int,
Descripcion varchar(60),
constraint pk_Danios primary key(idDanios),
constraint fk_cheque foreign key(idCheque) references cheques(idCheque) on delete cascade,
constraint fk_Servicios foreign key(idServicios) references Servicios(idServicio) on delete cascade
)engine=innoDB;

create table Users(
idUsuario int,
Usuario char(15),
contrasenia char(10),
constraint pk_Usuario primary key(idUsuario)
)engine=innoDB;

insert into Users values
(1, "Administracion", "1234"),
(2, "Recepcion", "5678");

insert into cliente values
(5000, 23450110, 'Mateo', 'Alvaro', 115683126098, 73409189, 'alvaromateo@hotmail.com', 'Av. Alvear 2185'),
("", 44548235, 'Daniel', 'Samuel', 115412345678, null, 'danisamuel@gmail.com', 'Caracas 2387'),
("", 35145875, 'Adrian', 'Gonzalez', 155409876543, 10293847, 'ad_gonzalez@gmail.com', 'Av. San Martin 3574'),
("", 40452117, 'Carolina', 'Sosa', 23450987, 12093487, 'carososa@gmail.com', 'Av. Alvarez Jonte 3589'),
("", 31563498, 'Javier', 'Larusso', 155355556666, null, 'javierlarusso@gmail.com', 'Cesar Diaz 4053'),
("", 40217896, 'Micaela', 'Fernandez', 88889999, 12121212, 'micaelafer@hotmail.com', 'Alfredo R. Bufano 1268'),
("", 29457256, 'Jacob', 'Valle', 1195403452897, null, 'jvalle@gmail.com', 'Magariños Cervantes'),
("", 25678459, 'Facundo', 'de la Fuente', 14309872, null, 'facudlf@hotmail.com', 'Andres Lamas 4526'),
("", 11222333, 'Juan', 'Chaco', 1150505050, null, 'jchaco@gmail.com', 'Tinogasta 340');

insert into notapedido values
(1,5000,"20/4/17","12:20","las casuelas 212","20/4/17"),
(2,5008,"2021-04-15", "13:00", "Tinogasta 5050", "2021-04-10");


insert into detallepedido values
(1, 1, 4, 1, 2, 1, "20/5/17"),
(2, 2, 20, 2, 0, 2, "2021-05-26");

insert into presupuesto values
(1, 1, 30000, "2020-04-17", "2020-05-01", 1000, "Finalizado"),
(2, 2, 20000, "2021-04-15", "2021-04-30", 1000, "Finalizado");
/*(3, 3, 40000, "2021-06-20", "2021-07-05", 1000, "Finalizado")*/

insert into notareserva values
(1, 1, 1000, "Cancelada", "2020-04-20"),
(2, 2, 1000, "Cancelada", "2020-04-25");

insert into recibos values
(1, null, 1),
(2, null, 2);

insert into servicios values
(1, "2020-05-17", "15:00", 1, 5005, "Campana 1080", "San Blas 4567", "Finalizado"),
(2, "2021-05-26", "11:00", 2, 5008, "Tinogasta 340", "Tinogasta 5050", "Finalizado");
/*(3, "2021-07-21", "12:30", 3, 5009, "Cuenca 1400", "Argerich 2600", "Finalizado")*/

insert into recibos values
(3, 1, null),
(4, 2, null);

insert into danios values
(1, null, 1, "Se rompió una pata de 80 cm de una mesa de madera"),
(2, null, 2, "Se rompió un jarrón de cerámica");

insert into cheques values
(0, null, null, null, null, null),
(1, 5005, 2000, "Dos mil", "2020-05-17", "2020-05-20"),
(2, 5008, 1000, "Mil", "2021-05-26", "2021-05-29");

update danios set idCheque = 1 where danios.idServicios=1;
update danios set idCheque = 2 where danios.idServicios=2;

insert into empleados values (0, null, null, null, null);
insert into empleados values (1,"Pepe","Argento",1156453455,"recepcionista");
insert into empleados values (2,"Guido","Kaczka",1111122222,"conductor");
insert into empleados values (3,"Lucas","Monolio",1133333233,"cargador");
insert into empleados values (4,"Franco","Tara",1144444414,"cargador");
insert into empleados values (5,"Paco","Andro",1155555555,"conductor");
insert into empleados values (6,"Pablo","Rodriguez",1166666666,"cargador");
insert into empleados values (7,"Tadeo","Do'reis",1177777777,"conductor");
insert into empleados values (8,"Alexis","Jimenez",1188888888,"cargador");
insert into empleados values (9,"Braian","Duarte",1199999999,"conductor");

/* se toma en cuenta que los conductores tienen licencia y cumple ambos trabajos cargador y conductor*/
insert into Camiones values (0, null, null, null, null);
insert into Camiones values (1,"AAA 111 VD","Isuzu","NLR 3TON",25);
insert into Camiones values (2,"AAA 222 VD","Toyota","Hino",35);
insert into Camiones values (3,"AAA 333 VD","Toyota","Dyna",28);
insert into Camiones values (4,"AAA 444 VD","Iveco","Eurostar",29);
insert into Camiones values (5,"AAA 555 VD","Volkswagen","Saveiro",15);
insert into Camiones values (6,"AAA 666 VD","Renault","Kangoo",10);

