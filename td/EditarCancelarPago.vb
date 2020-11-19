Public Class EditarCancelarPago
    Private Sub Paciente_servicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Paciente_pagoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub
    Private Sub EditarCancelarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PAGOS, ESTATUS, ESTATUS (BETWEEN)
        Me.Paciente_pagoTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_pago, Entrada.PacienteID.Text, "0", "2")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Paciente_pagoTableAdapter.UpdEstPago("0", IdPago.Text)
        AccionCerrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Paciente_pagoTableAdapter.UpdEstPago("1", IdPago.Text)
        AccionCerrar()
    End Sub
    Private Sub AccionCerrar()
        Entrada.MostrarPagosActivos()

        Me.Close()
    End Sub

    Private Sub idPaciente_TextChanged(sender As Object, e As EventArgs) Handles PacienteId.TextChanged


    End Sub

    Private Sub idPaciente_Click(sender As Object, e As EventArgs) Handles PacienteId.Click

    End Sub
End Class