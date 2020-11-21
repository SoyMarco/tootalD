Public Class OpcionesPacientes
    Private Sub BtnTratado_Click(sender As Object, e As EventArgs) Handles BtnTratado.Click
        Cursor = Cursors.WaitCursor
        Pacientes.PasoANuevoPaciente()
        Me.Close()
    End Sub

    Private Sub OpcionesPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Pacientes.PasoAEntrada()
        Me.Close()
    End Sub
End Class