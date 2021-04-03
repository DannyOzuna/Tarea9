/*CREATE TABLE vacunados(
    id INT PRIMARY KEY IDENTITY,
    cedula varchar(11) UNIQUE NOT NULL,
    nombre varchar(30) not NULL,
    apellido VARCHAR(30) not null,
    telefono varchar(30) not null, 
    email varchar(30) not NULL,
    tipo_sangre int not NULL, 
    provincia int not null,
    direccion text,
    latitud varchar(50),
    longitud varchar(50),
    covid BIT,
    justificacion text
)*/

select * from vacunados

insert into vacunados values ('40230021186', 'DANNY', 'OZUNA VASQUEZ', '809-797-6812', 'danny@gamil.com', 2, 1, 'Anacaona', '2345', '7686', 0, 'Quiero terminal con esto');