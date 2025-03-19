CREATE DATABASE VentasDB;
USE VentasDB;
CREATE TABLE Categoria (
    CodigoCategoria INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL
);
CREATE TABLE Producto (
    CodigoProducto INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    CodigoCategoria INT,
    FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(CodigoCategoria)
);
CREATE TABLE Venta (
    CodigoVenta INT PRIMARY KEY AUTO_INCREMENT,
    Fecha DATE NOT NULL,
    CodigoProducto INT,
    FOREIGN KEY (CodigoProducto) REFERENCES Producto(CodigoProducto)
);
INSERT INTO Categoria (Nombre) VALUES ('Electrónica'), 
    ('Ropa'), 
    ('Hogar')
    ('Deportes'), 
    ('Juguetes'), 
    ('Alimentos'), 
    ('Muebles'), 
    ('Tecnología');;

INSERT INTO Producto (Nombre, CodigoCategoria) VALUES
    ('Televisor', 1),
    ('Celular', 1),
    ('Pantalón', 2),
    ('Mesa', 3);
    ('Pelota de fútbol', 4),
    ('Bicicleta', 4),
    ('Muñeca', 5),
    ('Lego', 5),
    ('Cereal', 6),
    ('Arroz', 6),
    ('Sofá', 7),
    ('Silla', 7),
    ('Mouse Gaming', 8),
    ('Laptop', 8);

INSERT INTO Venta (Fecha, CodigoProducto) VALUES
    ('2019-06-15', 1),
    ('2020-03-20', 2),
    ('2019-11-05', 3),
    ('2021-07-10', 4);
    ('2021-06-25', 5), 
    ('2021-05-15', 6), 
    ('2021-07-01', 7), 
    ('2021-08-10', 8), 
    ('2019-10-10', 9), 
    ('2020-02-01', 10), 
    ('2020-12-15', 11), 
    ('2021-03-10', 12), 
    ('2021-06-05', 13), 
    ('2020-07-18', 14); 

SELECT c.Nombre AS Categoria
FROM Venta v
JOIN Producto p ON v.CodigoProducto = p.CodigoProducto
JOIN Categoria c ON p.CodigoCategoria = c.CodigoCategoria
ORDER BY v.Fecha DESC
LIMIT 1;
