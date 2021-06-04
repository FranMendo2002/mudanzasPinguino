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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalizarServicio))
        Me.btnFinalizarServicio = New System.Windows.Forms.Button()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinalizarServicio
        '
        Me.btnFinalizarServicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFinalizarServicio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFinalizarServicio.Location = New System.Drawing.Point(151, 249)
        Me.btnFinalizarServicio.Name = "btnFinalizarServicio"
        Me.btnFinalizarServicio.Size = New System.Drawing.Size(184, 46)
        Me.btnFinalizarServicio.TabIndex = 0
        Me.btnFinalizarServicio.Text = "Finalizar servicio"
        Me.btnFinalizarServicio.UseVisualStyleBackColor = False
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(110, 174)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(215, 23)
        Me.lblServicio.TabIndex = 1
        Me.lblServicio.Text = "Ingrese id de servicio a finalizar"
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(331, 177)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(78, 20)
        Me.txtServicio.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 120)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FinalizarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 328)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.btnFinalizarServicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FinalizarServicio"
        Me.Text = "Finalizar servicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinalizarServicio As Button
    Friend WithEvents lblServicio As Label
    Friend WithEvents txtServicio As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
