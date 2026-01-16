# Reto Técnico: Refactorización y Lógica en DB (.NET & SQL Server)
## Escenario
Contamos con un módulo básico de inventario que no cumple con los estándares de seguridad, arquitectura y escalabilidad de la empresa. Tu misión es tomar este código inicial y transformarlo en una solución profesional.

### Stack y Herramientas
Lenguaje: VB.NET (.NET Framework 4.x).

Base de Datos: SQL Server.

IDE: Visual Studio (2019 o superior recomendado).

Control de Versiones: Git / GitHub.

## El Reto
1. **Base de Datos (SQL Server)**
Se te proporciona el script de creación de la tabla Productos en [SqlQuery_1.sql](./SqlQuery_1.sql). Debes evolucionarlo creando un Stored Procedure llamado sp_GestionarInventario que:

    - Centralice la lógica: Si el producto ya existe (por nombre), debe actualizar su precio y sumar el nuevo stock al actual. Si no existe, debe crearlo.

    - Validaciones: Asegurar que el nombre no sea nulo, el precio sea mayor a 0 y el stock no sea negativo.

    - Transaccionalidad: El SP debe garantizar la integridad de los datos mediante el uso de TRANSACTION.

    - Feedback: Debe retornar un mensaje de confirmación o error al usuario.

2. **Aplicación (VB.NET)**
Debes refactorizar el código base en [Form1.vb](./WindowsApp1/Form1.vb) cumpliendo estos puntos:

    - Arquitectura: Separar el acceso a datos de la interfaz (nada de SQL directamente en el botón).

    - Seguridad: Eliminar la vulnerabilidad de SQL Injection mediante el uso de parámetros.

    - Manejo de Recursos: Asegurar el cierre de conexiones mediante bloques Using.

    - Experiencia de Usuario: * Añadir un DataGridView que se refresque automáticamente al guardar.

    - Plus de lógica visual: Si un producto tiene un stock menor a 5, la fila en el grid debe resaltarse en color rojo.

3. **Generealidades**

    - Buenas prácticas: Asegúrate de que el código sea limpio, bien comentado y siga las convenciones de nomenclatura.
    - Documentación: Proporciona un README.md con instrucciones claras para ejecutar el proyecto y cualquier consideración especial.
    - Convención de commits: Usa mensajes de commit claros y descriptivos en tu repositorio Git/GitHub.

## Instrucciones de Entrega
1. Haz un Fork de este repositorio.

2. Crea una rama de trabajo: feature/tu-nombre-apellido.

3. Implementa la solución (asegúrate de incluir el archivo .sql con el Stored Procedure).

4. Sube tus cambios con mensajes de commit claros.

5. Abre un Pull Request (PR) hacia la rama principal detallando los cambios realizados y cualquier decisión técnica importante.

## Criterios de Evaluación
+ Orden y Limpieza: Uso de nombres de variables claros (no más TextBox2).

+ Dominio de SQL: Uso correcto de tipos de datos y lógica de transacciones.

+ Separación de Responsabilidades: El formulario no debe conocer los detalles de la conexión SQL.

+ Manejo de Errores: Implementación de Try...Catch para evitar cierres inesperados.
