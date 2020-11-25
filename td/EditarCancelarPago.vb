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
    Private Sub PasoDataPrintPago()
        ImprimirPagoServicio.Show()
        Me.Hide()
        ImprimirPagoServicio.Label18.Focus()
        ImprimirPagoServicio.paciente.Text = Entrada.NomPaciente.Text
        ImprimirPagoServicio.id.Text = Entrada.PacienteID.Text
        ImprimirPagoServicio.consultorio.Text = Entrada.NuevoLugar.Text
        ImprimirPagoServicio.Fecha.Text = Entrada.DateTimePickerDia.Value
        ImprimirPagoServicio.nota.Text = Entrada.IdPago.Text
        ImprimirPagoServicio.TotalParcial.Text = Entrada.SumServ.Text
        ImprimirPagoServicio.descuento.Text = Entrada.TotDesc.Text
        ImprimirPagoServicio.total.Text = Entrada.TotServicios.Text
        ImprimirPagoServicio.pago.Text = FormatCurrency(CantPago.Text)
        ImprimirPagoServicio.Pagos.Text = Entrada.TotPagos.Text
        ImprimirPagoServicio.resta.Text = Entrada.resta.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PasoDataPrintPago()
        ImprimirPagoServicio.PrintForm()
        ImprimirPagoServicio.Hide()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PasoDataPrintPago()
        ImprimirPagoServicio.pdf()
        ImprimirPagoServicio.Hide()
        Me.Close()
    End Sub
End Class