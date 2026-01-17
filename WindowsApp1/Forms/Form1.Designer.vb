<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrdsForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.nudStock = New System.Windows.Forms.NumericUpDown()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(246, 159)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(116, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(27, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 16)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nombre:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(27, 75)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(49, 16)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Precio:"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(27, 114)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(44, 16)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock:"
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(395, 39)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(606, 245)
        Me.dgvProducts.TabIndex = 7
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(95, 39)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(267, 24)
        Me.cmbName.TabIndex = 8
        '
        'nudStock
        '
        Me.nudStock.Location = New System.Drawing.Point(95, 114)
        Me.nudStock.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudStock.Name = "nudStock"
        Me.nudStock.Size = New System.Drawing.Size(267, 22)
        Me.nudStock.TabIndex = 9
        '
        'nudPrice
        '
        Me.nudPrice.Location = New System.Drawing.Point(95, 75)
        Me.nudPrice.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(267, 22)
        Me.nudPrice.TabIndex = 10
        '
        'PrdsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 324)
        Me.Controls.Add(Me.nudPrice)
        Me.Controls.Add(Me.nudStock)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "PrdsForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Productos"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents nudPrice As NumericUpDown
End Class
