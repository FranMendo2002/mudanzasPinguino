<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConfeccionarPresup = New System.Windows.Forms.Button()
        Me.btnFormFinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFormNotaP = New System.Windows.Forms.Button()
        Me.btnFormCheque = New System.Windows.Forms.Button()
        Me.btnFormContrato = New System.Windows.Forms.Button()
        Me.btnFormCancelarServ = New System.Windows.Forms.Button()
        Me.btnFormProcesarPresup = New System.Windows.Forms.Button()
        Me.btnFormBorrarPresup = New System.Windows.Forms.Button()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(151, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(365, 125)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnConfeccionarPresup
        '
        Me.btnConfeccionarPresup.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConfeccionarPresup.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfeccionarPresup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfeccionarPresup.Location = New System.Drawing.Point(224, 217)
        Me.btnConfeccionarPresup.Name = "btnConfeccionarPresup"
        Me.btnConfeccionarPresup.Size = New System.Drawing.Size(165, 55)
        Me.btnConfeccionarPresup.TabIndex = 1
        Me.btnConfeccionarPresup.Text = "Confeccionar detalle de pedido y presupuesto"
        Me.btnConfeccionarPresup.UseVisualStyleBackColor = False
        '
        'btnFormFinalizar
        '
        Me.btnFormFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormFinalizar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormFinalizar.Location = New System.Drawing.Point(422, 296)
        Me.btnFormFinalizar.Name = "btnFormFinalizar"
        Me.btnFormFinalizar.Size = New System.Drawing.Size(165, 55)
        Me.btnFormFinalizar.TabIndex = 2
        Me.btnFormFinalizar.Text = "Finalizar servicio"
        Me.btnFormFinalizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Por favor, seleccione la accion que desea realizar"
        '
        'btnFormNotaP
        '
        Me.btnFormNotaP.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormNotaP.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormNotaP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormNotaP.Location = New System.Drawing.Point(37, 217)
        Me.btnFormNotaP.Name = "btnFormNotaP"
        Me.btnFormNotaP.Size = New System.Drawing.Size(165, 55)
        Me.btnFormNotaP.TabIndex = 4
        Me.btnFormNotaP.Text = "Crear nota de pedido"
        Me.btnFormNotaP.UseVisualStyleBackColor = False
        '
        'btnFormCheque
        '
        Me.btnFormCheque.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormCheque.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormCheque.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormCheque.Location = New System.Drawing.Point(37, 373)
        Me.btnFormCheque.Name = "btnFormCheque"
        Me.btnFormCheque.Size = New System.Drawing.Size(165, 55)
        Me.btnFormCheque.TabIndex = 5
        Me.btnFormCheque.Text = "Confeccionar cheque"
        Me.btnFormCheque.UseVisualStyleBackColor = False
        '
        'btnFormContrato
        '
        Me.btnFormContrato.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormContrato.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormContrato.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormContrato.Location = New System.Drawing.Point(37, 296)
        Me.btnFormContrato.Name = "btnFormContrato"
        Me.btnFormContrato.Size = New System.Drawing.Size(165, 55)
        Me.btnFormContrato.TabIndex = 6
        Me.btnFormContrato.Text = "Crear contrato de servicio"
        Me.btnFormContrato.UseVisualStyleBackColor = False
        '
        'btnFormCancelarServ
        '
        Me.btnFormCancelarServ.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormCancelarServ.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormCancelarServ.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormCancelarServ.Location = New System.Drawing.Point(224, 296)
        Me.btnFormCancelarServ.Name = "btnFormCancelarServ"
        Me.btnFormCancelarServ.Size = New System.Drawing.Size(165, 55)
        Me.btnFormCancelarServ.TabIndex = 7
        Me.btnFormCancelarServ.Text = "Cancelar servicio"
        Me.btnFormCancelarServ.UseVisualStyleBackColor = False
        '
        'btnFormProcesarPresup
        '
        Me.btnFormProcesarPresup.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormProcesarPresup.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormProcesarPresup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormProcesarPresup.Location = New System.Drawing.Point(422, 217)
        Me.btnFormProcesarPresup.Name = "btnFormProcesarPresup"
        Me.btnFormProcesarPresup.Size = New System.Drawing.Size(165, 55)
        Me.btnFormProcesarPresup.TabIndex = 9
        Me.btnFormProcesarPresup.Text = "Procesar presupuesto"
        Me.btnFormProcesarPresup.UseVisualStyleBackColor = False
        '
        'btnFormBorrarPresup
        '
        Me.btnFormBorrarPresup.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormBorrarPresup.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormBorrarPresup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormBorrarPresup.Location = New System.Drawing.Point(138, 443)
        Me.btnFormBorrarPresup.Name = "btnFormBorrarPresup"
        Me.btnFormBorrarPresup.Size = New System.Drawing.Size(165, 55)
        Me.btnFormBorrarPresup.TabIndex = 10
        Me.btnFormBorrarPresup.Text = "Borrar presupuesto"
        Me.btnFormBorrarPresup.UseVisualStyleBackColor = False
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(422, 373)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(165, 55)
        Me.btnRegistrarCliente.TabIndex = 11
        Me.btnRegistrarCliente.Text = "Registrar cliente"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(224, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 55)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Registrar recibo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(330, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 55)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Insertar Empleados/Vehículos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 520)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.btnFormBorrarPresup)
        Me.Controls.Add(Me.btnFormProcesarPresup)
        Me.Controls.Add(Me.btnFormCancelarServ)
        Me.Controls.Add(Me.btnFormContrato)
        Me.Controls.Add(Me.btnFormCheque)
        Me.Controls.Add(Me.btnFormNotaP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFormFinalizar)
        Me.Controls.Add(Me.btnConfeccionarPresup)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConfeccionarPresup As Button
    Friend WithEvents btnFormFinalizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFormNotaP As Button
    Friend WithEvents btnFormCheque As Button
    Friend WithEvents btnFormContrato As Button
    Friend WithEvents btnFormCancelarServ As Button
    Friend WithEvents btnFormProcesarPresup As Button
    Friend WithEvents btnFormBorrarPresup As Button
    Friend WithEvents btnRegistrarCliente As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
