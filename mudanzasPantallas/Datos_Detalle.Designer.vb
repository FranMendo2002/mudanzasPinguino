﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Datos_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Detalle))
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
        Me.imgBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.imgBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(164, 140)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(332, 42)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registrar detalle de pedido"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistrar.Location = New System.Drawing.Point(240, 303)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(163, 45)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtMuebles
        '
        Me.txtMuebles.Location = New System.Drawing.Point(360, 198)
        Me.txtMuebles.Name = "txtMuebles"
        Me.txtMuebles.Size = New System.Drawing.Size(31, 20)
        Me.txtMuebles.TabIndex = 10
        '
        'lblMuebles
        '
        Me.lblMuebles.AutoSize = True
        Me.lblMuebles.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuebles.Location = New System.Drawing.Point(292, 197)
        Me.lblMuebles.Name = "lblMuebles"
        Me.lblMuebles.Size = New System.Drawing.Size(62, 23)
        Me.lblMuebles.TabIndex = 3
        Me.lblMuebles.Text = "Muebles"
        '
        'lblFletes
        '
        Me.lblFletes.AutoSize = True
        Me.lblFletes.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFletes.Location = New System.Drawing.Point(523, 195)
        Me.lblFletes.Name = "lblFletes"
        Me.lblFletes.Size = New System.Drawing.Size(47, 23)
        Me.lblFletes.TabIndex = 4
        Me.lblFletes.Text = "Fletes"
        '
        'txtCamiones
        '
        Me.txtCamiones.Location = New System.Drawing.Point(250, 198)
        Me.txtCamiones.Name = "txtCamiones"
        Me.txtCamiones.Size = New System.Drawing.Size(31, 20)
        Me.txtCamiones.TabIndex = 5
        '
        'txtFletes
        '
        Me.txtFletes.Location = New System.Drawing.Point(576, 198)
        Me.txtFletes.Name = "txtFletes"
        Me.txtFletes.Size = New System.Drawing.Size(31, 20)
        Me.txtFletes.TabIndex = 6
        '
        'lblCamiones
        '
        Me.lblCamiones.AutoSize = True
        Me.lblCamiones.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamiones.Location = New System.Drawing.Point(173, 195)
        Me.lblCamiones.Name = "lblCamiones"
        Me.lblCamiones.Size = New System.Drawing.Size(71, 23)
        Me.lblCamiones.TabIndex = 7
        Me.lblCamiones.Text = "Camiones"
        '
        'txtEmpleados
        '
        Me.txtEmpleados.Location = New System.Drawing.Point(481, 198)
        Me.txtEmpleados.Name = "txtEmpleados"
        Me.txtEmpleados.Size = New System.Drawing.Size(31, 20)
        Me.txtEmpleados.TabIndex = 8
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.Location = New System.Drawing.Point(397, 195)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(78, 23)
        Me.lblEmpleados.TabIndex = 9
        Me.lblEmpleados.Text = "Empleados"
        '
        'txtNotaPedido
        '
        Me.txtNotaPedido.Location = New System.Drawing.Point(136, 198)
        Me.txtNotaPedido.Name = "txtNotaPedido"
        Me.txtNotaPedido.Size = New System.Drawing.Size(31, 20)
        Me.txtNotaPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID nota de pedido"
        '
        'dtimeFechaMud
        '
        Me.dtimeFechaMud.CustomFormat = "yyyy-MM-dd"
        Me.dtimeFechaMud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtimeFechaMud.Location = New System.Drawing.Point(206, 277)
        Me.dtimeFechaMud.Name = "dtimeFechaMud"
        Me.dtimeFechaMud.Size = New System.Drawing.Size(226, 20)
        Me.dtimeFechaMud.TabIndex = 14
        '
        'lblFechaMud
        '
        Me.lblFechaMud.AutoSize = True
        Me.lblFechaMud.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMud.Location = New System.Drawing.Point(147, 240)
        Me.lblFechaMud.Name = "lblFechaMud"
        Me.lblFechaMud.Size = New System.Drawing.Size(349, 19)
        Me.lblFechaMud.TabIndex = 15
        Me.lblFechaMud.Text = "Porfavor, seleccione la fecha en la que se realizara la mudanza"
        '
        'imgBoxLogo
        '
        Me.imgBoxLogo.Image = CType(resources.GetObject("imgBoxLogo.Image"), System.Drawing.Image)
        Me.imgBoxLogo.Location = New System.Drawing.Point(151, 12)
        Me.imgBoxLogo.Name = "imgBoxLogo"
        Me.imgBoxLogo.Size = New System.Drawing.Size(361, 116)
        Me.imgBoxLogo.TabIndex = 16
        Me.imgBoxLogo.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(284, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Datos_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 426)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgBoxLogo)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Datos_Detalle"
        Me.Text = "Datos detalle"
        CType(Me.imgBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgBoxLogo As PictureBox
    Friend WithEvents Button1 As Button
End Class