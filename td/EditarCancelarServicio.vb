Public Class EditarCancelarServicio
    Private Sub Paciente_servicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Paciente_servicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub EditarCancelarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.paciente_servicio' Puede moverla o quitarla según sea necesario.
        Me.Paciente_servicioTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_servicio, Entrada.PacienteID.Text, "0", "2")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Paciente_servicioTableAdapter.UpdEstServ("0", IdServ.Text)
        AccionCerrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Paciente_servicioTableAdapter.UpdEstServ("1", IdServ.Text)
        AccionCerrar()
    End Sub
    Private Sub AccionCerrar()
        Entrada.MostrarServActivos()

        Me.Close()
    End Sub
End Class