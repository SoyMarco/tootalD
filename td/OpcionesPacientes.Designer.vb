<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcionesPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpcionesPacientes))
        Me.BtnTratado = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTratado
        '
        Me.BtnTratado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTratado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTratado.Font = New System.Drawing.Font("Helvetica LT Std", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTratado.ForeColor = System.Drawing.Color.White
        Me.BtnTratado.Location = New System.Drawing.Point(12, 29)
        Me.BtnTratado.Name = "BtnTratado"
        Me.BtnTratado.Size = New System.Drawing.Size(220, 75)
        Me.BtnTratado.TabIndex = 57344
        Me.BtnTratado.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paciente"
        Me.BtnTratado.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Helvetica LT Std", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(259, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 75)
        Me.Button1.TabIndex = 57345
        Me.Button1.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pago/Servicio"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpcionesPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 133)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnTratado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpcionesPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpcionesPacientes"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTratado As Button
    Friend WithEvents Button1 As Button
End Class
