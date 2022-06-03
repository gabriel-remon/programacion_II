-- agregar un registro de un cliente
INSERT INTO Clientes(nombre,direccion) VALUES('JUAN','La de tu hermana')

--leer un cliente

SELECT nombre FROM Clientes


--leer todos los campos 

SELECT * FROM Clientes

--leer todas las columnas de un clientes

SELECT * FROM Clientes WHERE id = 4 OR id =1

--modificar un cliente por el id

UPDATE Clientes SET nombre = 'juanito' WHERE id=1000

--eliminar todos clientes 
DELETE FROM Clientes

--eliminar un solo cliente 

DELETE FROM Clientes WHERE id=1

--eliminar por condiciones 

DELETE FROM Clientes WHERE nombre LIKE '%a%' --elimina todos los clientes que tengan una 'a' en el nombre
DELETE FROM Clientes WHERE nombre LIKE '_a%' --elimina a todos los clientes que tengan una 'a' como segunda letra