insert into factura ( idEmpleado, total,fecha,cliente)
values (1,180,'2018-05-08','juansito');

insert into factura ( idEmpleado, total,fecha,cliente)
values (1,30,'2015-10-5','carlito');

insert into factura ( idEmpleado, total,fecha,cliente)
values (1,70,'2016-08-18','michelin');

insert into factura ( idEmpleado, total,fecha,cliente)
values (1,60,'2017-11-18','arley');

insert into factura ( idEmpleado, total,fecha,cliente)
values (1,160,'2019-11-18','geovanni');

select * from producto
UPDATE producto set imagen = '/Content/images/MenuPizzas/menupizza1.jpg' 

ALTER TABLE producto ADD imagen Varchar (150);
ALTER TABLE producto DROP column imagen

insert into categoria (nombre,descripcion)
values ('Bebida','liquido que se ingiere');
insert into producto (idCategoria,Nombre,precio,tamaño)
values (2,'gaseosa',30,1);
insert into producto (idCategoria,Nombre,precio,tamaño)
values (2,'gaseosa',50,2);
insert into producto (idCategoria,Nombre,precio,tamaño)
values (2,'gaseosa',80,3);

insert into facturaDetalle (idProducto,idFactura,cantidadVendido,precioProducto,total)
values (1,1,1.00,180.00,180);

insert into facturaDetalle (idProducto,idFactura,cantidadVendido,precioProducto,total)
values (2,2,1,30,30);

insert into facturaDetalle (idProducto,idFactura,cantidadVendido,precioProducto,total)
values (3,3,1,70,70);

insert into facturaDetalle (idProducto,idFactura,cantidadVendido,precioProducto,total)
values (4,4,1,60,60);

insert into facturaDetalle (idProducto,idFactura,cantidadVendido,precioProducto,total)
values (5,5,1,160,160);

insert into ingredientes ( Nombre,precio,stock)
values ('Chiltoma', 5, 30);
insert into ingredientes ( Nombre,precio,stock)
values ('Tomate', 12, 30);
insert into ingredientes (Nombre,precio,stock)
values ('Piña', 30, 50);
insert into ingredientes ( Nombre,precio,stock)
values ('Huevo', 5, 25);
insert into ingredientes (Nombre,precio,stock)
values ('Levadura', 40, 50);
insert into ingredientes ( Nombre,precio,stock)
values ('Harina', 30, 50);
insert into ingredientes ( Nombre,precio,stock)
values ('Queso', 45, 50);
insert into ingredientes ( Nombre,precio,stock)
values ('Hongos', 40, 50);
insert into ingredientes (Nombre,precio,stock)
values ('Salami', 40, 50);
insert into ingredientes (Nombre,precio,stock)
values ('Peperoni', 70, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Cebolla', 15, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Jamon', 80, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Aceituna', 100, 20);
select * from ingredientes
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,10,2,40)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,2,2,24)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,11,2,24)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,1,2,10)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,12,2,160)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,9,2,80)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(4,9,2,200)

insert into ingredientes (Nombre,precio,stock)
values ('Salchicha Especial', 100, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Salchicha De Pollo', 100, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Cebolla Picada', 10, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Chorizo Mexicano', 50, 20);
insert into ingredientes (Nombre,precio,stock)
values ('Jalapeño', 10, 20);


insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(5,10,2,40)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(5,14,2,200)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(5,15,2,200)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(5,13,2,10)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(5,16,2,160)


insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(3,7,2,90)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(3,12,2,160)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(8,10,2,160)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(6,10,2,140)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(6,17,2,160)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(6,18,2,160)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(6,1,2,160)
insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(6,13,2,160)
select * from ingredientes
select * from crearProducto
select * from producto where idCategoria=1










insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,1,2,10)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,2,1,12)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,3,1,30)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,4,6,30)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,5,1,40)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,6,1,30)

insert into crearProducto (idProducto,idIngrediente,cantidadIngrediente,precioIngrediente) 
values(1,7,1,30)

select * from producto