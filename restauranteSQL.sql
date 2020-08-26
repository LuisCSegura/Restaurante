CREATE TABLE usuarios(
	id serial,
	codigo varchar(6) NOT NULL,
	cedula varchar(12) NOT NULL,
	nombre varchar (100)NOT NULL,
	contrasenna varchar(100)NOT NULL,
	tipo int default 0,
	activo boolean default true,
	CONSTRAINT pk_usuario PRIMARY KEY(id),
	CONSTRAINT unq_nom_usu UNIQUE(nombre)
);

CREATE TABLE comidas(
	id serial,
	codigo varchar(10) NOT NULL,
	nombre varchar(20) NOT NULL,
	categoria varchar(20) NOT NULL,
	descripcion varchar(100) NOT NULL,
	precio numeric DEFAULT 0,
	activo boolean default true,
	
	CONSTRAINT pk_comidas PRIMARY KEY(id),
	CONSTRAINT unq_cod_com UNIQUE(codigo)
	
);


CREATE TABLE bebidas(
	id serial,
	codigo varchar(10) NOT NULL,
	nombre varchar(20) NOT NULL,
	categoria varchar(20) NOT NULL,
	descripcion varchar(100) NOT NULL,
	precio numeric DEFAULT 0,
	activo boolean default true,
	
	CONSTRAINT pk_bebidas PRIMARY KEY(id),
	CONSTRAINT unq_cod_beb UNIQUE(codigo)
	
);

CREATE TABLE secciones(
	id serial,
	numero int not null,
	cantidad_mesas int DEFAULT 6,
	id_salonero int NOT NULL,
	activo boolean DEFAULT true,
	CONSTRAINT pk_seccion PRIMARY KEY(id),
	CONSTRAINT unq_num_sec UNIQUE(numero),
	CONSTRAINT fk_usu_sec FOREIGN KEY(id_salonero)REFERENCES usuarios(id)
);

CREATE TABLE mesas(
	id serial,
	numero int NOT NULL,
	id_seccion int NOT NULL,
	activo boolean DEFAULT true,
	CONSTRAINT pk_mesa PRIMARY KEY(id),
	CONSTRAINT unq_numsec_mes UNIQUE(id_seccion,numero),
	CONSTRAINT fk_sec_mes FOREIGN KEY(id_seccion)REFERENCES secciones(id)
);

CREATE TABLE comandas(
	id serial,
	id_salonero int NOT NULL,
	id_mesa int NOT NULL,
	tiempo timestamp without time zone NOT NULL,
	pagado boolean DEFAULT false,
	fecha date default NOW(),
	CONSTRAINT pk_comanda PRIMARY KEY(id),
	CONSTRAINT fk_sal_com FOREIGN KEY(id_salonero)REFERENCES usuarios(id),
	CONSTRAINT fk_mes_com FOREIGN KEY(id_mesa)REFERENCES mesas(id)
);
CREATE TABLE ordenes_comida(
	id serial,
	cantidad int DEFAULT 1,
	id_comida int NOT NULL,
	id_comanda int NOT NULL,
	preparado boolean DEFAULT false,
	tiempo_servicio timestamp without time zone NOT NULL,
	CONSTRAINT pk_ordcom PRIMARY KEY(id),
	CONSTRAINT fk_comi_ordcom FOREIGN KEY(id_comida)REFERENCES comidas(id),
	CONSTRAINT fk_coma_ordcom FOREIGN KEY(id_comanda)REFERENCES comandas(id)
);
CREATE TABLE ordenes_bebida(
	id serial,
	cantidad int DEFAULT 1,
	id_bebida int NOT NULL,
	id_comanda int NOT NULL,
	preparado boolean DEFAULT false,
	tiempo_servicio timestamp without time zone NOT NULL,
	CONSTRAINT pk_ordbeb PRIMARY KEY(id),
	CONSTRAINT fk_beb_ordbeb FOREIGN KEY(id_bebida)REFERENCES bebidas(id),
	CONSTRAINT fk_coma_ordbeb FOREIGN KEY(id_comanda)REFERENCES comandas(id)
);


CREATE TABLE reservas(
	id serial,
	cedula varchar(12) NOT NULL,
	nombre varchar (100)NOT NULL,
	fecha date,
	fecha_reserva date NOT NULL,
	hora varchar (100) NOT NULL,
	telefono varchar(20) NOT NULL,
	cant_personas int NOT NULL,
	id_seccion int NOT NULL,
	id_mesa int NOT NULL,
	seccion varchar(20) NOT NULL,
	mesa varchar(20) NOT NULL,
	estado varchar(20) NOT NULL,
	activo boolean DEFAULT true,

CONSTRAINT pk_reser PRIMARY KEY(id),
CONSTRAINT fk_sec_reser FOREIGN KEY(id_seccion)REFERENCES secciones(id),
CONSTRAINT fk_mesa_reser FOREIGN KEY(id_mesa)REFERENCES mesas(id)	
);
CREATE TABLE facturas(
	id serial,
	numero serial,
	fecha timestamp without time zone NOT NULL,
	id_comanda int NOT NULL,
	total_sin_impuesto numeric DEFAULT 0,
	total numeric DEFAULT 0,
	CONSTRAINT pk_factura PRIMARY KEY(id),
	CONSTRAINT fk_fac_com FOREIGN KEY(id_comanda)REFERENCES comandas(id)
);
CREATE TABLE detalles_facturas(
	id serial,
	orden_refer int NOT NULL,
	detalle text NOT NULL,
	precio numeric DEFAULT 0,
	id_factura int NOT NULL,
	CONSTRAINT pk_detfac PRIMARY KEY(id),
	CONSTRAINT fk_detfac_fact FOREIGN KEY(id_factura)REFERENCES facturas(id)
);

INSERT INTO usuarios(codigo,cedula,nombre,contrasenna) VALUES('ADMIN','208090758','Luis Carlos Segura','sele2014');

INSERT INTO ordenes_comida(cantidad,id_comida,id_comanda,preparado)VALUES();

SELECT c.id,c.codigo,c.nombre,c.categoria,c.descripcion, c.precio FROM ordenes_comida as oc
INNER JOIN comidas as c ON c.id=oc.id_comida
WHERE oc.id=1;

SELECT id,EXTRACT(YEAR FROM tiempo)AS anno,
EXTRACT(MONTH FROM tiempo)AS mes,
EXTRACT(DAY FROM tiempo)AS dia,
EXTRACT(HOUR FROM tiempo)AS hora,
EXTRACT(MINUTE FROM tiempo)AS minuto
FROM comandas WHERE id_mesa=1 AND pagado=false;


UPDATE ordenes_comida SET cantidad,preparado;
UPDATE mesas SET activo=false WHERE id_seccion=3;
DELETE FROM secciones WHERE id=1
