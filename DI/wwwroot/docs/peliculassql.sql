CREATE DATABASE PRUEBAS

USE PRUEBAS

CREATE TABLE PELICULAS(
	ID INT,
	NOMBRE NVARCHAR(50),
	DIRECTOR NVARCHAR(50),
	CLASIFICACION NVARCHAR(50)
);

INSERT INTO PELICULAS VALUES(1, 'El sexto sentido', 'M. Night Shyamalan', 'Drama');
INSERT INTO PELICULAS VALUES(2, 'Pulp Fictiono', 'Tarantino', 'Acci�n');
INSERT INTO PELICULAS VALUES(3, 'Todo sobre mi madr', 'Almodobarn', 'Drama');
INSERT INTO PELICULAS VALUES(4, '300', 'Zack Snyde', 'Acci�n');
INSERT INTO PELICULAS VALUES(5, 'El silencio de los corderos', 'Jonathan Demme', 'Drama');
INSERT INTO PELICULAS VALUES(6, 'Forrest Gum', 'Robert Zemeckis', 'Comedia');
INSERT INTO PELICULAS VALUES(7, 'Las Hurdes', 'Luis Bu�uel', 'Documental');

SELECT * FROM PELICULAS