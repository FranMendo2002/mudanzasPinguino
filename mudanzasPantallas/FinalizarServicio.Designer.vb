<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizarServicio
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
        Me.btnFinalizarServicio = New System.Windows.Forms.Button()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFinalizarServicio
        '
        Me.btnFinalizarServicio.Location = New System.Drawing.Point(146, 147)
        Me.btnFinalizarServicio.Name = "btnFinalizarServicio"
        Me.btnFinalizarServicio.Size = New System.Drawing.Size(139, 46)
        Me.btnFinalizarServicio.TabIndex = 0
        Me.btnFinalizarServicio.Text = "Finalizar servicio"
        Me.btnFinalizarServicio.UseVisualStyleBackColor = True
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Location = New System.Drawing.Point(78, 51)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(154, 13)
        Me.lblServicio.TabIndex = 1
        Me.lblServicio.Text = "Ingrese id de servicio a finalizar"
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(238, 48)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(78, 20)
        Me.txtServicio.TabIndex = 2
        '
        'FinalizarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 259)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.btnFinalizarServicio)
        Me.Name = "FinalizarServicio"
        Me.Text = "Finalizar servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinalizarServicio As Button
    Friend WithEvents lblServicio As Label
    Friend WithEvents txtServicio As TextBox
End Class
