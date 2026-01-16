Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Server=localhost;Database=TiendaDB;Trusted_Connection=True;"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNOMbre.Text <> "" Then
            Dim sql As String = "INSERT INTO Productos (Nombre, Precio, Stock) VALUES ('" & txtNOMbre.Text & "', " & TextBox2.Text & ", " & TextBox3.Text & ")"
            Dim conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(sql, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Registro exitoso")
        Else
            MsgBox("Error en los datos")
        End If
    End Sub

End Class
