## Módulo de Inventario – VB.NET & SQL Server
#
implementamos un módulo de gestión de inventario desarrollado en VB.NET (.NET Framework 4.x) con SQL Server




## Arquitectura

La aplicación sigue una separación clara de responsabilidades:

# UI (Windows Forms)
Encargada exclusivamente de la interacción con el usuario y validaciones básicas.

# DAL (Data Access Layer)
Responsable del acceso a datos mediante Stored Procedures, sin exponer lógica SQL en la interfaz.

# Base de Datos (SQL Server)
Centraliza la lógica de negocio relacionada con el inventario a través de Stored Procedures transaccionales.




## Tecnologías Utilizadas

VB.NET (.NET Framework 4.x)

Windows Forms

SQL Server

ADO.NET

Visual Studio 2022

Git / GitHub


## Base de Datos

# Productos

Id      INT (PK, Identity)
Nombre  VARCHAR(100)
Precio  DECIMAL(18,2)
Stock   INT

# Stored Procedures Implementados

# sp_GestionarInventario

- Inserta o actualiza productos según su nombre

- Suma el stock si el producto ya existe

- Valida:

        Nombre no vacío

        Precio mayor a 0

        Stock no negativo

        Maneja transacciones (BEGIN TRANSACTION)

        Devuelve mensajes de confirmación o error

# sp_ListarProductos

Devuelve la lista completa de productos para el DataGridView

# sp_ListarNombresProductos

Devuelve los nombres únicos de productos para el ComboBox





## Detalles y Funcionalidades Especiales

# Múltiples formas de selección de productos

    El usuario puede seleccionar un producto:

    Desde el ComboBox de nombres, o

    Directamente haciendo clic en una fila del DataGridView

    Al seleccionar un producto desde el grid, los datos se cargan automáticamente en los controles de edición (nombre, precio y stock).

# Controles numéricos

    Se utilizan controles NumericUpDown para:

        Precio

        Stock

    Esto garantiza:

        Entrada numérica válida

        Mejor control de rangos mínimos y máximos