<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConfeccionarPresup = New System.Windows.Forms.Button()
        Me.btnFormFinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnConfeccionarPresup.Location = New System.Drawing.Point(151, 238)
        Me.btnConfeccionarPresup.Name = "btnConfeccionarPresup"
        Me.btnConfeccionarPresup.Size = New System.Drawing.Size(146, 55)
        Me.btnConfeccionarPresup.TabIndex = 1
        Me.btnConfeccionarPresup.Text = "Confeccionar presupuesto"
        Me.btnConfeccionarPresup.UseVisualStyleBackColor = False
        '
        'btnFormFinalizar
        '
        Me.btnFormFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFormFinalizar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFormFinalizar.Location = New System.Drawing.Point(380, 238)
        Me.btnFormFinalizar.Name = "btnFormFinalizar"
        Me.btnFormFinalizar.Size = New System.Drawing.Size(143, 55)
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
        Me.Label1.Size = New System.Drawing.Size(583, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Porfavor, seleccione la accion que desea realizar"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
