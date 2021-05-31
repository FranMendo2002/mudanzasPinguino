<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formDatosDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtMuebles = New System.Windows.Forms.TextBox()
        Me.lblMuebles = New System.Windows.Forms.Label()
        Me.lblFletes = New System.Windows.Forms.Label()
        Me.txtCamiones = New System.Windows.Forms.TextBox()
        Me.txtFletes = New System.Windows.Forms.TextBox()
        Me.lblCamiones = New System.Windows.Forms.Label()
        Me.txtEmpleados = New System.Windows.Forms.TextBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.txtNotaPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtimeFechaMud = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaMud = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(157, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(235, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registrar detalle de pedido"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(190, 310)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(142, 40)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtMuebles
        '
        Me.txtMuebles.Location = New System.Drawing.Point(405, 183)
        Me.txtMuebles.Name = "txtMuebles"
        Me.txtMuebles.Size = New System.Drawing.Size(31, 20)
        Me.txtMuebles.TabIndex = 10
        '
        'lblMuebles
        '
        Me.lblMuebles.AutoSize = True
        Me.lblMuebles.Location = New System.Drawing.Point(352, 186)
        Me.lblMuebles.Name = "lblMuebles"
        Me.lblMuebles.Size = New System.Drawing.Size(47, 13)
        Me.lblMuebles.TabIndex = 3
        Me.lblMuebles.Text = "Muebles"
        '
        'lblFletes
        '
        Me.lblFletes.AutoSize = True
        Me.lblFletes.Location = New System.Drawing.Point(120, 252)
        Me.lblFletes.Name = "lblFletes"
        Me.lblFletes.Size = New System.Drawing.Size(35, 13)
        Me.lblFletes.TabIndex = 4
        Me.lblFletes.Text = "Fletes"
        '
        'txtCamiones
        '
        Me.txtCamiones.Location = New System.Drawing.Point(161, 123)
        Me.txtCamiones.Name = "txtCamiones"
        Me.txtCamiones.Size = New System.Drawing.Size(31, 20)
        Me.txtCamiones.TabIndex = 5
        '
        'txtFletes
        '
        Me.txtFletes.Location = New System.Drawing.Point(161, 249)
        Me.txtFletes.Name = "txtFletes"
        Me.txtFletes.Size = New System.Drawing.Size(31, 20)
        Me.txtFletes.TabIndex = 6
        '
        'lblCamiones
        '
        Me.lblCamiones.AutoSize = True
        Me.lblCamiones.Location = New System.Drawing.Point(102, 126)
        Me.lblCamiones.Name = "lblCamiones"
        Me.lblCamiones.Size = New System.Drawing.Size(53, 13)
        Me.lblCamiones.TabIndex = 7
        Me.lblCamiones.Text = "Camiones"
        '
        'txtEmpleados
        '
        Me.txtEmpleados.Location = New System.Drawing.Point(161, 183)
        Me.txtEmpleados.Name = "txtEmpleados"
        Me.txtEmpleados.Size = New System.Drawing.Size(31, 20)
        Me.txtEmpleados.TabIndex = 8
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Location = New System.Drawing.Point(96, 186)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(59, 13)
        Me.lblEmpleados.TabIndex = 9
        Me.lblEmpleados.Text = "Empleados"
        '
        'txtNotaPedido
        '
        Me.txtNotaPedido.Location = New System.Drawing.Point(161, 70)
        Me.txtNotaPedido.Name = "txtNotaPedido"
        Me.txtNotaPedido.Size = New System.Drawing.Size(31, 20)
        Me.txtNotaPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID nota de pedido"
        '
        'dtimeFechaMud
        '
        Me.dtimeFechaMud.CustomFormat = "yyyy-MM-dd"
        Me.dtimeFechaMud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtimeFechaMud.Location = New System.Drawing.Point(264, 119)
        Me.dtimeFechaMud.Name = "dtimeFechaMud"
        Me.dtimeFechaMud.Size = New System.Drawing.Size(226, 20)
        Me.dtimeFechaMud.TabIndex = 14
        '
        'lblFechaMud
        '
        Me.lblFechaMud.AutoSize = True
        Me.lblFechaMud.Location = New System.Drawing.Point(294, 64)
        Me.lblFechaMud.Name = "lblFechaMud"
        Me.lblFechaMud.Size = New System.Drawing.Size(164, 26)
        Me.lblFechaMud.TabIndex = 15
        Me.lblFechaMud.Text = "Porfavor, seleccione la fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en la que se realizara la mudanza"
        '
        'formDatosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 387)
        Me.Controls.Add(Me.lblFechaMud)
        Me.Controls.Add(Me.dtimeFechaMud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNotaPedido)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.txtEmpleados)
        Me.Controls.Add(Me.lblCamiones)
        Me.Controls.Add(Me.txtFletes)
        Me.Controls.Add(Me.txtCamiones)
        Me.Controls.Add(Me.lblFletes)
        Me.Controls.Add(Me.lblMuebles)
        Me.Controls.Add(Me.txtMuebles)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "formDatosDetalle"
        Me.Text = "Datos detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtMuebles As TextBox
    Friend WithEvents lblMuebles As Label
    Friend WithEvents lblFletes As Label
    Friend WithEvents txtCamiones As TextBox
    Friend WithEvents txtFletes As TextBox
    Friend WithEvents lblCamiones As Label
    Friend WithEvents txtEmpleados As TextBox
    Friend WithEvents lblEmpleados As Label
    Friend WithEvents txtNotaPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtimeFechaMud As DateTimePicker
    Friend WithEvents lblFechaMud As Label
End Class
