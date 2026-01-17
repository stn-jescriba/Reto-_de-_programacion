Option Strict On
Option Explicit On

Imports System.Data.SqlClient
Imports System.Drawing

Public Class PrdsForm

    Private ReadOnly productoDAL As New ProductoDAL()

    ' =========================
    ' EVENTOS
    ' =========================

    Private Sub PrdsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        CargarNombres()
    End Sub


    Private Sub CargarNombres()
        cmbName.DataSource = productoDAL.ListarNombresProductos()
        cmbName.DisplayMember = "Nombre"
        cmbName.ValueMember = "Nombre"
        cmbName.SelectedIndex = -1
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Obtener y limpiar el nombre del producto
            Dim nombre As String = cmbName.Text.Trim()

            ' Obtener valores numéricos directamente desde los NumericUpDown
            Dim precio As Decimal = nudPrice.Value
            Dim stock As Integer = CInt(nudStock.Value)

            ' =========================
            ' VALIDACIONES DE UI
            ' =========================

            ' Validar nombre
            If nombre = String.Empty Then
                MessageBox.Show("El nombre no puede estar vacío")
                Exit Sub
            End If

            ' Validar precio
            If precio <= 0 Then
                MessageBox.Show("El precio debe ser mayor a 0")
                Exit Sub
            End If

            ' Validar stock
            If stock < 0 Then
                MessageBox.Show("El stock no puede ser negativo")
                Exit Sub
            End If


            ' Llamada a la capa DAL (no hay SQL en la UI)
            Dim resultado As String = productoDAL.GuardarProducto(nombre, precio, stock)
            MessageBox.Show(resultado)



            ' Refrescar el DataGridView automáticamente
            CargarProductos()

            ' Limpiar campos para una nueva operación
            LimpiarCampos()

        Catch ex As Exception
            ' Manejo de errores inesperados
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    ' Evento que se ejecuta al hacer clic en una celda del DataGridView
    ' Permite cargar los datos del producto seleccionado en los controles del formulario
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        ' Validar que el clic se haya realizado sobre una fila válida

        If e.RowIndex >= 0 Then

            ' Obtener la fila seleccionada
            Dim fila As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            ' Cargar los valores de la fila en los campos de entrada
            cmbName.Text = fila.Cells("Nombre").Value.ToString()
            nudPrice.Text = fila.Cells("Precio").Value.ToString()
            nudStock.Text = fila.Cells("Stock").Value.ToString()

        End If
    End Sub


    ' =========================
    ' MÉTODOS PRIVADOS
    ' =========================

    Private Sub CargarProductos()
        dgvProducts.DataSource = ProductoDAL.ListarProductos()
        PintarStockBajo()
    End Sub

    Private Sub PintarStockBajo()
        For Each fila As DataGridViewRow In dgvProducts.Rows
            If fila.Cells("Stock").Value IsNot Nothing AndAlso
               Convert.ToInt32(fila.Cells("Stock").Value) < 5 Then

                fila.DefaultCellStyle.BackColor = Color.LightCoral
            Else
                fila.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub LimpiarCampos()
        cmbName.SelectedIndex = -1
        nudPrice.Value = nudPrice.Minimum
        nudStock.Value = nudStock.Minimum
        cmbName.Focus()
    End Sub

End Class
