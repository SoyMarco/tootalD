<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.PacienteId = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PacienteId
        '
        Me.PacienteId.AutoSize = True
        Me.PacienteId.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PacienteId.Location = New System.Drawing.Point(12, 19)
        Me.PacienteId.Name = "PacienteId"
        Me.PacienteId.Size = New System.Drawing.Size(39, 32)
        Me.PacienteId.TabIndex = 57420
        Me.PacienteId.Text = "Id"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Helvetica LT Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.Location = New System.Drawing.Point(57, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(144, 42)
        Me.id.TabIndex = 57422
        Me.id.Text = "nombre"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nombre.Location = New System.Drawing.Point(12, 77)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(112, 32)
        Me.nombre.TabIndex = 57423
        Me.nombre.Text = "nombre"
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 135)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.PacienteId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PacienteId As Label
    Friend WithEvents id As Label
    Friend WithEvents nombre As Label
End Class
