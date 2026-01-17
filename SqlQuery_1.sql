
use master

IF EXISTS(SELECT * from sys.databases WHERE name='TiendaDB')  
BEGIN 
    drop database TiendaDB
END 
go

create database TiendaDB
go

use TiendaDB
go




CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Precio DECIMAL(18, 2),
    Stock INT
);
go

CREATE PROCEDURE sp_GestionarInventario
    @Nombre VARCHAR(100),
    @Precio DECIMAL(18,2),
    @Stock INT,
    @Mensaje VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Validaciones
        IF (@Nombre IS NULL OR LTRIM(RTRIM(@Nombre)) = '')
            THROW 50001, 'El nombre no puede estar vacío', 1;

        IF (@Precio <= 0)
            THROW 50002, 'El precio debe ser mayor a 0', 1;

        IF (@Stock < 0)
            THROW 50003, 'El stock no puede ser negativo', 1;

        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1 FROM Productos WHERE Nombre = @Nombre)
        BEGIN
            UPDATE Productos
            SET 
                Precio = @Precio,
                Stock = Stock + @Stock
            WHERE Nombre = @Nombre;

            SET @Mensaje = 'Producto actualizado correctamente';
        END
        ELSE
        BEGIN
            INSERT INTO Productos (Nombre, Precio, Stock)
            VALUES (@Nombre, @Precio, @Stock);

            SET @Mensaje = 'Producto registrado correctamente';
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END;
GO

CREATE PROCEDURE sp_ListarProductos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        Nombre,
        Precio,
        Stock
    FROM Productos;
END;
GO


CREATE PROCEDURE sp_ListarNombresProductos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT Nombre
    FROM Productos;
END;
GO



