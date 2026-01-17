Option Strict On
Option Explicit On

Imports System.Data.SqlClient

''' <summary>
''' Capa de Acceso a Datos para la entidad Producto
''' </summary>
Public Class ProductoDAL

    Private ReadOnly connectionString As String =
        "Server=localhost;Database=TiendaDB;Trusted_Connection=True;"

    ''' <summary>
    ''' Inserta o actualiza un producto utilizando el Stored Procedure
    ''' </summary>
    Public Function GuardarProducto(nombre As String, precio As Decimal, stock As Integer) As String
        Dim mensaje As String = String.Empty

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("sp_GestionarInventario", conn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Stock", stock)

                Dim paramMsg As New SqlParameter("@Mensaje", SqlDbType.VarChar, 200)
                paramMsg.Direction = ParameterDirection.Output
                cmd.Parameters.Add(paramMsg)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    mensaje = paramMsg.Value.ToString()
                Catch ex As SqlException
                    mensaje = "Error de base de datos: " & ex.Message
                Catch ex As Exception
                    mensaje = "Error inesperado: " & ex.Message
                End Try
            End Using
        End Using

        Return mensaje
    End Function
    ''' <summary>
    ''' Obtiene la lista completa de productos
    ''' </summary>
    Public Function ListarProductos() As DataTable
        Dim tabla As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("sp_ListarProductos", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Try
                    conn.Open()
                    tabla.Load(cmd.ExecuteReader())
                Catch ex As SqlException
                    Throw New Exception("Error al listar productos (SQL): " & ex.Message)
                Catch ex As Exception
                    Throw New Exception("Error inesperado al listar productos: " & ex.Message)
                End Try
            End Using
        End Using

        Return tabla
    End Function

    ''' <summary>
    ''' Obtiene los nombres de los productos usando el Stored Procedure sp_ListarNombresProductos
    ''' </summary>
    Public Function ListarNombresProductos() As DataTable
        Dim tabla As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("sp_ListarNombresProductos", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Try
                    conn.Open()
                    tabla.Load(cmd.ExecuteReader())
                Catch ex As SqlException
                    Throw New Exception("Error al listar nombres (SQL): " & ex.Message)
                Catch ex As Exception
                    Throw New Exception("Error inesperado al listar nombres: " & ex.Message)
                End Try
            End Using
        End Using

        Return tabla
    End Function

End Class




