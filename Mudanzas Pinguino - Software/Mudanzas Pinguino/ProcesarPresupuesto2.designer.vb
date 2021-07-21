<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcesarPresupuesto2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcesarPresupuesto2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Reserva = New System.Windows.Forms.Label()
        Me.idpresupuesto = New System.Windows.Forms.Label()
        Me.montoRes = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!)
        Me.Label1.Location = New System.Drawing.Point(105, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Reservas"
        '
        'lbl_Reserva
        '
        Me.lbl_Reserva.AutoSize = True
        Me.lbl_Reserva.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.lbl_Reserva.Location = New System.Drawing.Point(47, 194)
        Me.lbl_Reserva.Name = "lbl_Reserva"
        Me.lbl_Reserva.Size = New System.Drawing.Size(73, 23)
        Me.lbl_Reserva.TabIndex = 6
        Me.lbl_Reserva.Text = "idReserva"
        '
        'idpresupuesto
        '
        Me.idpresupuesto.AutoSize = True
        Me.idpresupuesto.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.idpresupuesto.Location = New System.Drawing.Point(258, 194)
        Me.idpresupuesto.Name = "idpresupuesto"
        Me.idpresupuesto.Size = New System.Drawing.Size(100, 23)
        Me.idpresupuesto.TabIndex = 7
        Me.idpresupuesto.Text = "idpresupuesto"
        '
        'montoRes
        '
        Me.montoRes.AutoSize = True
        Me.montoRes.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.montoRes.Location = New System.Drawing.Point(16, 240)
        Me.montoRes.Name = "montoRes"
        Me.montoRes.Size = New System.Drawing.Size(99, 23)
        Me.montoRes.TabIndex = 8
        Me.montoRes.Text = "MontoReserva"
        '
        'estado
        '
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.estado.Location = New System.Drawing.Point(304, 237)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(52, 23)
        Me.estado.TabIndex = 9
        Me.estado.Text = "estado"
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn.Location = New System.Drawing.Point(173, 284)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(144, 44)
        Me.btn.TabIndex = 11
        Me.btn.Text = "Registrar"
        Me.btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(67, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 102)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(175, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Volver al menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(125, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 38)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Volver a ""Estado del presupuesto"""
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(169, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(171, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(370, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(370, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label5"
        '
        'ProcesarPresupuesto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 436)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.montoRes)
        Me.Controls.Add(Me.idpresupuesto)
        Me.Controls.Add(Me.lbl_Reserva)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcesarPresupuesto2"
        Me.Text = "Reservas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Reserva As Label
    Friend WithEvents idpresupuesto As Label
    Friend WithEvents montoRes As Label
    Friend WithEvents estado As Label
    Friend WithEvents btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
