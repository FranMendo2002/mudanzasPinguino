<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class procesarReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(procesarReserva))
        Me.Label = New System.Windows.Forms.Label()
        Me.TBDViaje = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBHini = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.TBFlete = New System.Windows.Forms.TextBox()
        Me.TBCamion = New System.Windows.Forms.TextBox()
        Me.TBCEmp = New System.Windows.Forms.TextBox()
        Me.TBMon = New System.Windows.Forms.TextBox()
        Me.TBDIni = New System.Windows.Forms.TextBox()
        Me.TBFMud = New System.Windows.Forms.TextBox()
        Me.TBNomApe = New System.Windows.Forms.TextBox()
        Me.TBReserva = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BVerificar = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtVEmpleados = New System.Windows.Forms.Button()
        Me.GBEmpleados = New System.Windows.Forms.GroupBox()
        Me.BtBorrarEmp = New System.Windows.Forms.Button()
        Me.LEmpIngresado4 = New System.Windows.Forms.Label()
        Me.LEmpIngresado3 = New System.Windows.Forms.Label()
        Me.LEmpIngresado2 = New System.Windows.Forms.Label()
        Me.LEmpIngresado1 = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LEspecialidad = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.CBEmpleado = New System.Windows.Forms.ComboBox()
        Me.GBVehiculos = New System.Windows.Forms.GroupBox()
        Me.BtBorrarVeh = New System.Windows.Forms.Button()
        Me.LTara = New System.Windows.Forms.Label()
        Me.LVehIngresado2 = New System.Windows.Forms.Label()
        Me.LVehIngresado1 = New System.Windows.Forms.Label()
        Me.LPatente = New System.Windows.Forms.Label()
        Me.LModelo = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.CBVehiculo = New System.Windows.Forms.ComboBox()
        Me.BtVVehiculos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEmpleados.SuspendLayout()
        Me.GBVehiculos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label.Location = New System.Drawing.Point(224, 167)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(125, 23)
        Me.Label.TabIndex = 58
        Me.Label.Text = "ingrese id reserva"
        '
        'TBDViaje
        '
        Me.TBDViaje.AcceptsTab = True
        Me.TBDViaje.Enabled = False
        Me.TBDViaje.Location = New System.Drawing.Point(388, 346)
        Me.TBDViaje.Name = "TBDViaje"
        Me.TBDViaje.Size = New System.Drawing.Size(86, 20)
        Me.TBDViaje.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(266, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 23)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Destino de Viaje: "
        '
        'TBHini
        '
        Me.TBHini.Enabled = False
        Me.TBHini.Location = New System.Drawing.Point(177, 371)
        Me.TBHini.Name = "TBHini"
        Me.TBHini.Size = New System.Drawing.Size(86, 20)
        Me.TBHini.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(92, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Hora Inicio: "
        '
        'BIngresar
        '
        Me.BIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BIngresar.Location = New System.Drawing.Point(213, 408)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(136, 46)
        Me.BIngresar.TabIndex = 53
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = False
        Me.BIngresar.Visible = False
        '
        'TBFlete
        '
        Me.TBFlete.Enabled = False
        Me.TBFlete.Location = New System.Drawing.Point(388, 321)
        Me.TBFlete.Name = "TBFlete"
        Me.TBFlete.Size = New System.Drawing.Size(86, 20)
        Me.TBFlete.TabIndex = 52
        '
        'TBCamion
        '
        Me.TBCamion.Enabled = False
        Me.TBCamion.Location = New System.Drawing.Point(388, 296)
        Me.TBCamion.Name = "TBCamion"
        Me.TBCamion.Size = New System.Drawing.Size(86, 20)
        Me.TBCamion.TabIndex = 51
        '
        'TBCEmp
        '
        Me.TBCEmp.Enabled = False
        Me.TBCEmp.Location = New System.Drawing.Point(388, 271)
        Me.TBCEmp.Name = "TBCEmp"
        Me.TBCEmp.Size = New System.Drawing.Size(86, 20)
        Me.TBCEmp.TabIndex = 50
        '
        'TBMon
        '
        Me.TBMon.Enabled = False
        Me.TBMon.Location = New System.Drawing.Point(177, 346)
        Me.TBMon.Name = "TBMon"
        Me.TBMon.Size = New System.Drawing.Size(86, 20)
        Me.TBMon.TabIndex = 49
        '
        'TBDIni
        '
        Me.TBDIni.Enabled = False
        Me.TBDIni.Location = New System.Drawing.Point(177, 321)
        Me.TBDIni.Name = "TBDIni"
        Me.TBDIni.Size = New System.Drawing.Size(86, 20)
        Me.TBDIni.TabIndex = 48
        '
        'TBFMud
        '
        Me.TBFMud.Enabled = False
        Me.TBFMud.Location = New System.Drawing.Point(177, 296)
        Me.TBFMud.Name = "TBFMud"
        Me.TBFMud.Size = New System.Drawing.Size(86, 20)
        Me.TBFMud.TabIndex = 47
        '
        'TBNomApe
        '
        Me.TBNomApe.Enabled = False
        Me.TBNomApe.Location = New System.Drawing.Point(177, 271)
        Me.TBNomApe.Name = "TBNomApe"
        Me.TBNomApe.Size = New System.Drawing.Size(86, 20)
        Me.TBNomApe.TabIndex = 46
        '
        'TBReserva
        '
        Me.TBReserva.Location = New System.Drawing.Point(240, 193)
        Me.TBReserva.Name = "TBReserva"
        Me.TBReserva.Size = New System.Drawing.Size(86, 20)
        Me.TBReserva.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(328, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Fletes: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(304, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Camiones: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(297, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Empleados: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(121, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 23)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Monto: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(101, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Direccion: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(60, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha Mudanza: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(46, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nombre y Apellido: "
        '
        'BVerificar
        '
        Me.BVerificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BVerificar.Location = New System.Drawing.Point(228, 219)
        Me.BVerificar.Name = "BVerificar"
        Me.BVerificar.Size = New System.Drawing.Size(121, 46)
        Me.BVerificar.TabIndex = 37
        Me.BVerificar.Text = "Verificar"
        Me.BVerificar.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BVolver.Location = New System.Drawing.Point(227, 460)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(107, 45)
        Me.BVolver.TabIndex = 59
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 99)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!)
        Me.Label8.Location = New System.Drawing.Point(375, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 42)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Registro de Servicios"
        '
        'BtVEmpleados
        '
        Me.BtVEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtVEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtVEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtVEmpleados.Location = New System.Drawing.Point(6, 64)
        Me.BtVEmpleados.Name = "BtVEmpleados"
        Me.BtVEmpleados.Size = New System.Drawing.Size(83, 34)
        Me.BtVEmpleados.TabIndex = 62
        Me.BtVEmpleados.Text = "Asignar"
        Me.BtVEmpleados.UseVisualStyleBackColor = False
        '
        'GBEmpleados
        '
        Me.GBEmpleados.Controls.Add(Me.BtBorrarEmp)
        Me.GBEmpleados.Controls.Add(Me.LEmpIngresado4)
        Me.GBEmpleados.Controls.Add(Me.LEmpIngresado3)
        Me.GBEmpleados.Controls.Add(Me.LEmpIngresado2)
        Me.GBEmpleados.Controls.Add(Me.LEmpIngresado1)
        Me.GBEmpleados.Controls.Add(Me.LTelefono)
        Me.GBEmpleados.Controls.Add(Me.LEspecialidad)
        Me.GBEmpleados.Controls.Add(Me.LNombre)
        Me.GBEmpleados.Controls.Add(Me.CBEmpleado)
        Me.GBEmpleados.Controls.Add(Me.BtVEmpleados)
        Me.GBEmpleados.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.GBEmpleados.Location = New System.Drawing.Point(542, 167)
        Me.GBEmpleados.Name = "GBEmpleados"
        Me.GBEmpleados.Size = New System.Drawing.Size(388, 159)
        Me.GBEmpleados.TabIndex = 63
        Me.GBEmpleados.TabStop = False
        Me.GBEmpleados.Text = "AgregarEmpleado"
        Me.GBEmpleados.Visible = False
        '
        'BtBorrarEmp
        '
        Me.BtBorrarEmp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtBorrarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtBorrarEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtBorrarEmp.Location = New System.Drawing.Point(6, 118)
        Me.BtBorrarEmp.Name = "BtBorrarEmp"
        Me.BtBorrarEmp.Size = New System.Drawing.Size(83, 34)
        Me.BtBorrarEmp.TabIndex = 71
        Me.BtBorrarEmp.Text = "Borrar"
        Me.BtBorrarEmp.UseVisualStyleBackColor = False
        '
        'LEmpIngresado4
        '
        Me.LEmpIngresado4.AutoSize = True
        Me.LEmpIngresado4.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LEmpIngresado4.Location = New System.Drawing.Point(292, 98)
        Me.LEmpIngresado4.Name = "LEmpIngresado4"
        Me.LEmpIngresado4.Size = New System.Drawing.Size(74, 19)
        Me.LEmpIngresado4.TabIndex = 70
        Me.LEmpIngresado4.Text = "Ingresado 4:"
        Me.LEmpIngresado4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LEmpIngresado4.Visible = False
        '
        'LEmpIngresado3
        '
        Me.LEmpIngresado3.AutoSize = True
        Me.LEmpIngresado3.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LEmpIngresado3.Location = New System.Drawing.Point(196, 98)
        Me.LEmpIngresado3.Name = "LEmpIngresado3"
        Me.LEmpIngresado3.Size = New System.Drawing.Size(73, 19)
        Me.LEmpIngresado3.TabIndex = 69
        Me.LEmpIngresado3.Text = "Ingresado 3:"
        Me.LEmpIngresado3.Visible = False
        '
        'LEmpIngresado2
        '
        Me.LEmpIngresado2.AutoSize = True
        Me.LEmpIngresado2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LEmpIngresado2.Location = New System.Drawing.Point(100, 98)
        Me.LEmpIngresado2.Name = "LEmpIngresado2"
        Me.LEmpIngresado2.Size = New System.Drawing.Size(73, 19)
        Me.LEmpIngresado2.TabIndex = 68
        Me.LEmpIngresado2.Text = "Ingresado 2:"
        Me.LEmpIngresado2.Visible = False
        '
        'LEmpIngresado1
        '
        Me.LEmpIngresado1.AutoSize = True
        Me.LEmpIngresado1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LEmpIngresado1.Location = New System.Drawing.Point(6, 98)
        Me.LEmpIngresado1.Name = "LEmpIngresado1"
        Me.LEmpIngresado1.Size = New System.Drawing.Size(71, 19)
        Me.LEmpIngresado1.TabIndex = 67
        Me.LEmpIngresado1.Text = "Ingresado 1:"
        Me.LEmpIngresado1.Visible = False
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(133, 69)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(64, 23)
        Me.LTelefono.TabIndex = 66
        Me.LTelefono.Text = "Telefono:"
        '
        'LEspecialidad
        '
        Me.LEspecialidad.AutoSize = True
        Me.LEspecialidad.Location = New System.Drawing.Point(133, 46)
        Me.LEspecialidad.Name = "LEspecialidad"
        Me.LEspecialidad.Size = New System.Drawing.Size(93, 23)
        Me.LEspecialidad.TabIndex = 65
        Me.LEspecialidad.Text = "Especialidad:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(133, 23)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(61, 23)
        Me.LNombre.TabIndex = 64
        Me.LNombre.Text = "Nombre:"
        '
        'CBEmpleado
        '
        Me.CBEmpleado.FormattingEnabled = True
        Me.CBEmpleado.Location = New System.Drawing.Point(6, 29)
        Me.CBEmpleado.Name = "CBEmpleado"
        Me.CBEmpleado.Size = New System.Drawing.Size(121, 31)
        Me.CBEmpleado.TabIndex = 63
        '
        'GBVehiculos
        '
        Me.GBVehiculos.Controls.Add(Me.BtBorrarVeh)
        Me.GBVehiculos.Controls.Add(Me.LTara)
        Me.GBVehiculos.Controls.Add(Me.LVehIngresado2)
        Me.GBVehiculos.Controls.Add(Me.LVehIngresado1)
        Me.GBVehiculos.Controls.Add(Me.LPatente)
        Me.GBVehiculos.Controls.Add(Me.LModelo)
        Me.GBVehiculos.Controls.Add(Me.LMarca)
        Me.GBVehiculos.Controls.Add(Me.CBVehiculo)
        Me.GBVehiculos.Controls.Add(Me.BtVVehiculos)
        Me.GBVehiculos.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.GBVehiculos.Location = New System.Drawing.Point(542, 332)
        Me.GBVehiculos.Name = "GBVehiculos"
        Me.GBVehiculos.Size = New System.Drawing.Size(388, 185)
        Me.GBVehiculos.TabIndex = 71
        Me.GBVehiculos.TabStop = False
        Me.GBVehiculos.Text = "AgregarVehiculo"
        Me.GBVehiculos.Visible = False
        '
        'BtBorrarVeh
        '
        Me.BtBorrarVeh.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtBorrarVeh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtBorrarVeh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtBorrarVeh.Location = New System.Drawing.Point(6, 138)
        Me.BtBorrarVeh.Name = "BtBorrarVeh"
        Me.BtBorrarVeh.Size = New System.Drawing.Size(83, 34)
        Me.BtBorrarVeh.TabIndex = 70
        Me.BtBorrarVeh.Text = "Borrar"
        Me.BtBorrarVeh.UseVisualStyleBackColor = False
        '
        'LTara
        '
        Me.LTara.AutoSize = True
        Me.LTara.Location = New System.Drawing.Point(133, 87)
        Me.LTara.Name = "LTara"
        Me.LTara.Size = New System.Drawing.Size(49, 23)
        Me.LTara.TabIndex = 69
        Me.LTara.Text = "Tara:  "
        '
        'LVehIngresado2
        '
        Me.LVehIngresado2.AutoSize = True
        Me.LVehIngresado2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LVehIngresado2.Location = New System.Drawing.Point(100, 116)
        Me.LVehIngresado2.Name = "LVehIngresado2"
        Me.LVehIngresado2.Size = New System.Drawing.Size(73, 19)
        Me.LVehIngresado2.TabIndex = 68
        Me.LVehIngresado2.Text = "Ingresado 2:"
        Me.LVehIngresado2.Visible = False
        '
        'LVehIngresado1
        '
        Me.LVehIngresado1.AutoSize = True
        Me.LVehIngresado1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.LVehIngresado1.Location = New System.Drawing.Point(6, 116)
        Me.LVehIngresado1.Name = "LVehIngresado1"
        Me.LVehIngresado1.Size = New System.Drawing.Size(71, 19)
        Me.LVehIngresado1.TabIndex = 67
        Me.LVehIngresado1.Text = "Ingresado 1:"
        Me.LVehIngresado1.Visible = False
        '
        'LPatente
        '
        Me.LPatente.AutoSize = True
        Me.LPatente.Location = New System.Drawing.Point(133, 64)
        Me.LPatente.Name = "LPatente"
        Me.LPatente.Size = New System.Drawing.Size(69, 23)
        Me.LPatente.TabIndex = 66
        Me.LPatente.Text = "Patente:  "
        '
        'LModelo
        '
        Me.LModelo.AutoSize = True
        Me.LModelo.Location = New System.Drawing.Point(133, 41)
        Me.LModelo.Name = "LModelo"
        Me.LModelo.Size = New System.Drawing.Size(61, 23)
        Me.LModelo.TabIndex = 65
        Me.LModelo.Text = "Modelo: "
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Location = New System.Drawing.Point(133, 18)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(57, 23)
        Me.LMarca.TabIndex = 64
        Me.LMarca.Text = "Marca: "
        '
        'CBVehiculo
        '
        Me.CBVehiculo.FormattingEnabled = True
        Me.CBVehiculo.Location = New System.Drawing.Point(6, 29)
        Me.CBVehiculo.Name = "CBVehiculo"
        Me.CBVehiculo.Size = New System.Drawing.Size(121, 31)
        Me.CBVehiculo.TabIndex = 63
        '
        'BtVVehiculos
        '
        Me.BtVVehiculos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtVVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtVVehiculos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtVVehiculos.Location = New System.Drawing.Point(6, 64)
        Me.BtVVehiculos.Name = "BtVVehiculos"
        Me.BtVVehiculos.Size = New System.Drawing.Size(83, 34)
        Me.BtVVehiculos.TabIndex = 62
        Me.BtVVehiculos.Text = "Asignar"
        Me.BtVVehiculos.UseVisualStyleBackColor = False
        '
        'procesarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 536)
        Me.Controls.Add(Me.GBVehiculos)
        Me.Controls.Add(Me.GBEmpleados)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TBDViaje)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBHini)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.TBFlete)
        Me.Controls.Add(Me.TBCamion)
        Me.Controls.Add(Me.TBCEmp)
        Me.Controls.Add(Me.TBMon)
        Me.Controls.Add(Me.TBDIni)
        Me.Controls.Add(Me.TBFMud)
        Me.Controls.Add(Me.TBNomApe)
        Me.Controls.Add(Me.TBReserva)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BVerificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "procesarReserva"
        Me.Text = "Procesar reserva"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEmpleados.ResumeLayout(False)
        Me.GBEmpleados.PerformLayout()
        Me.GBVehiculos.ResumeLayout(False)
        Me.GBVehiculos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents TBDViaje As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBHini As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BIngresar As Button
    Friend WithEvents TBFlete As TextBox
    Friend WithEvents TBCamion As TextBox
    Friend WithEvents TBCEmp As TextBox
    Friend WithEvents TBMon As TextBox
    Friend WithEvents TBDIni As TextBox
    Friend WithEvents TBFMud As TextBox
    Friend WithEvents TBNomApe As TextBox
    Friend WithEvents TBReserva As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BVerificar As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtVEmpleados As Button
    Friend WithEvents GBEmpleados As GroupBox
    Friend WithEvents CBEmpleado As ComboBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LEspecialidad As Label
    Friend WithEvents LEmpIngresado1 As Label
    Friend WithEvents LEmpIngresado4 As Label
    Friend WithEvents LEmpIngresado3 As Label
    Friend WithEvents LEmpIngresado2 As Label
    Friend WithEvents GBVehiculos As GroupBox
    Friend WithEvents LVehIngresado2 As Label
    Friend WithEvents LVehIngresado1 As Label
    Friend WithEvents LPatente As Label
    Friend WithEvents LModelo As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents CBVehiculo As ComboBox
    Friend WithEvents BtVVehiculos As Button
    Friend WithEvents LTara As Label
    Friend WithEvents BtBorrarEmp As Button
    Friend WithEvents BtBorrarVeh As Button
End Class
