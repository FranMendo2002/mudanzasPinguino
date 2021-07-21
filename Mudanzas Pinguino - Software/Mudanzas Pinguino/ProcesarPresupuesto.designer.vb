<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProcesarPresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcesarPresupuesto))
        Me.titulo = New System.Windows.Forms.Label()
        Me.clientetxt = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!)
        Me.titulo.Location = New System.Drawing.Point(239, 114)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(287, 42)
        Me.titulo.TabIndex = 0
        Me.titulo.Text = "Estado del presupuesto"
        '
        'clientetxt
        '
        Me.clientetxt.Location = New System.Drawing.Point(430, 171)
        Me.clientetxt.Name = "clientetxt"
        Me.clientetxt.Size = New System.Drawing.Size(100, 20)
        Me.clientetxt.TabIndex = 2
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn.Location = New System.Drawing.Point(355, 214)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(81, 33)
        Me.btn.TabIndex = 15
        Me.btn.Text = "Consultar"
        Me.btn.UseVisualStyleBackColor = False
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!)
        Me.cliente.Location = New System.Drawing.Point(242, 166)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(159, 23)
        Me.cliente.TabIndex = 1
        Me.cliente.Text = "Numero de presupuesto"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(213, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 99)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(355, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProcesarPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.clientetxt)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.titulo)
        Me.Name = "ProcesarPresupuesto"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titulo As Label
    Friend WithEvents clientetxt As TextBox
    Friend WithEvents btn As Button
    Friend WithEvents cliente As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
