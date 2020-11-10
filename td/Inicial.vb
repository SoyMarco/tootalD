Public Class Inicial

    Private Sub Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        home.Show()
    End Sub

    Public Sub CerrarAbrirStart()

        home.Close()
        homeLago.Close()
        home.Show()
        Cursor = Cursor.Current
    End Sub
End Class