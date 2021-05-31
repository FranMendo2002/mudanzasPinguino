<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDatosPresupuesto
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoReserva = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(135, 37)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(194, 24)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Registrar presupuesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Monto de reserva"
        '
        'txtMontoReserva
        '
        Me.txtMontoReserva.Location = New System.Drawing.Point(187, 174)
        Me.txtMontoReserva.Name = "txtMontoReserva"
        Me.txtMontoReserva.Size = New System.Drawing.Size(86, 20)
        Me.txtMontoReserva.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(187, 108)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(86, 20)
        Me.txtPrecio.TabIndex = 21
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(144, 111)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 22
        Me.lblPrecio.Text = "Precio"
        '
        'formDatosPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 336)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMontoReserva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "formDatosPresupuesto"
        Me.Text = "Datos presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoReserva As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
End Class
