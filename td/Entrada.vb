Public Class Entrada
    Private Sub Payment_categoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Payment_categoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        Me.Payment_categoryTableAdapter.Fill(Me.Tootalde_dbtDataSet.payment_category)
        Me.Payment_categoryDataGridView.Sort(Payment_categoryDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub Operaciones()
        SumTotServ()
        SumTotPagos()
        PaciResta()
        ColorServicios()
        ColorPagos()
    End Sub
    Private Sub AgregarUnoMas()
        If IdServ.Text > "0" Then
            Dim UMas As String
            Dim CurRow As DataGridViewRow = Paciente_servicioDataGridView.CurrentRow
            UMas = CStr(CurRow.Cells(1).Value)
            Tratamiento.SelectedIndex = UMas
            'AgregarProducto()
        End If
    End Sub
    Private Sub GuardarServicio()
        If Total.Text = "ERROR" Then

            InfoGuarServ.Text = "ERROR EN DATOS"
            InfoGuarServ.ForeColor = Color.Red


        Else
            Paciente_servicioTableAdapter.InsertarServicioPaciente(Tratamiento.Text, CInt(TotParcial.Text), descuento.Text, CInt(Total.Text), PacienteID.Text, NuevoDr.Text, IdCita.Text, DateTimePickerDia.Value, "1", DateTimePickerDia.Value, vbNull)
            '(Tratamiento, precio, descuento, Total, paciente, Doctor, cita, fecha, estatus, fecha_cambio, usuario_cambio)
            InfoGuarServ.Text = "GUARDADO"
            InfoGuarServ.ForeColor = Color.DarkGreen
            MostrarServActivos()
            Tratamiento.Text = ""
        End If
    End Sub
    Private Sub OperTarEfe()
        Dim efec As Double
        Dim tarj As Double
        If efectivo.Text = "" Or efectivo.Text = "." Then
            efec = CDbl(0)
        Else
            efec = CDbl(efectivo.Text)
        End If
        If tarjeta.Text = "" Or tarjeta.Text = "." Then
            tarj = CDbl(0)
        Else
            tarj = CDbl(tarjeta.Text)
        End If
        Dim montoT As Double
        montoT = efec + tarj
        MontoTotal.Text = FormatCurrency(montoT)
    End Sub
    Private Sub GuardarPago()
        Dim efec As Double
        Dim tarj As Double
        If efectivo.Text = "" Or efectivo.Text = "." Then
            efec = CDbl(0)
        Else
            efec = CDbl(efectivo.Text)
        End If
        If tarjeta.Text = "" Or tarjeta.Text = "." Then
            tarj = CDbl(0)
        Else
            tarj = CDbl(tarjeta.Text)
        End If
        Dim montoT As Double
        montoT = efec + tarj

        If montoT > 0 Then
            Dim comi As String
            comi = montoT * 0.2
            Paciente_pagoTableAdapter.InPacientePago(comi, PacienteID.Text, NuevoDr.Text, IdCita.Text, comentarios.Text, NuevoDr.Text, DateTimePickerDia.Value, "1", DateTimePickerDia.Value, vbNull, efec, tarj, montoT)
            MostrarPagosActivos()
            efectivo.Text = ""
            tarjeta.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuardarPago()
    End Sub

    Private Sub descuento_TextChanged(sender As Object, e As EventArgs) Handles descuento.TextChanged
        FormatoTotal()
    End Sub

    Private Sub descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles descuento.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not descuento.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub

    Private Sub efectivo_TextChanged(sender As Object, e As EventArgs) Handles efectivo.TextChanged
        OperTarEfe()
    End Sub

    Private Sub efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles efectivo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not efectivo.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub

    Private Sub tarjeta_TextChanged(sender As Object, e As EventArgs) Handles tarjeta.TextChanged
        OperTarEfe()
    End Sub

    Private Sub tarjeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tarjeta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not tarjeta.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then  'Si es enter.
            e.Handled = True          ' eliminamos el sonido. 
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GuardarServicio()
    End Sub

    Private Sub Doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Doctor.SelectedIndexChanged
        Me.DoctorTableAdapter.FillBusDr(Me.Tootalde_dbtDataSet.doctor, Doctor.SelectedItem)
        Try
            Dim Ndr As String

            Dim rowCU As DataGridViewRow = DoctorDataGridView.CurrentRow
            Ndr = CStr(rowCU.Cells(0).Value)


            NuevoDr.Text = Ndr


        Catch ex As Exception
        End Try
    End Sub

    Private Sub lugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lugar.SelectedIndexChanged
        NuevoLugar.Text = lugar.SelectedItem
    End Sub

    Private Sub Tratamiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tratamiento.SelectedIndexChanged

        For i As Integer = 0 To Payment_categoryDataGridView.Rows.Count - 1
            'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
            If Payment_categoryDataGridView.Rows(i).Cells(1).Value = Tratamiento.Text Then
                'Mueve el cursor a dicha fila
                Try
                    Payment_categoryDataGridView.CurrentCell = Payment_categoryDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    Payment_categoryDataGridView.Rows(i).Selected = True
                    'Cambiar color fila
                Catch ex As Exception

                End Try

            End If
        Next
        Dim Prec As String
        Dim TraId As Integer
        Dim rowCU As DataGridViewRow = Payment_categoryDataGridView.CurrentRow
        Prec = CStr(rowCU.Cells(3).Value)
        TraId = CStr(rowCU.Cells(0).Value)
        TotParcial.Text = FormatCurrency(Prec)
        TratamientoId.Text = TraId
        FormatoTotal()

    End Sub
    Private Sub FormatoTotal()
        If descuento.Text > "1" Then
            If descuento.Text < CInt(TotParcial.Text) Then
                Total.Text = FormatCurrency(TotParcial.Text - descuento.Text)
                Total.ForeColor = Color.Navy
            Else
                Total.Text = "ERROR"
                Total.ForeColor = Color.Red
            End If
        Else
            Try
                If CInt(TotParcial.Text) > 0 Then
                    Total.ForeColor = Color.Navy
                    Total.Text = TotParcial.Text
                Else
                    Total.Text = "ERROR"
                    Total.ForeColor = Color.Red
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub SumTotServ()
        Try
            'SUMAR COLUMNA DE PRECIOS SERVICIOS
            Dim Total As Single
            Dim Col As Integer = Paciente_servicioDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.Paciente_servicioDataGridView.Rows
                Total += Val(row.Cells(4).Value)
            Next
            TotServicios.Text = FormatCurrency(Total.ToString)
        Catch ex As Exception
            TotServicios.Text = "ERROR"
        End Try

    End Sub
    Private Sub SumTotPagos()
        Try
            'SUMAR COLUMNA DE PRECIOS SERVICIOS
            Dim Total As Single
            Dim Col As Integer = Paciente_pagoDataGridView.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.Paciente_pagoDataGridView.Rows
                Total += Val(row.Cells(3).Value)
            Next
            TotPagos.Text = FormatCurrency(Total.ToString)
            Tratamiento.Text = ""
        Catch ex As Exception
            TotPagos.Text = "EROOR"
        End Try

    End Sub
    Private Sub PaciResta()
        Try
            If TotPagos.Text And TotServicios.Text <> "" Then
                Dim montoT As Integer
                montoT = CInt(TotServicios.Text) - CInt(TotPagos.Text)
                resta.Text = FormatCurrency(montoT)
            End If
        Catch ex As Exception
            resta.Text = "ERROR"
        End Try

    End Sub
    Private Sub Entrada_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Add) Then
            AgregarUnoMas()
        End If
    End Sub

    Private Sub Paciente_servicioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Paciente_servicioDataGridView.CellContentClick

        MostIdServ()
    End Sub
    Private Sub MostIdServ()
        Try
            Dim idSer As String
            Dim NamServ As String
            Dim rowCU As DataGridViewRow = Paciente_servicioDataGridView.CurrentRow
            idSer = CStr(rowCU.Cells(0).Value)
            NamServ = CStr(rowCU.Cells(1).Value)
            IdServ.Text = idSer
            NameServ.Text = NamServ
            EditCancelServ()
        Catch ex As Exception
            IdServ.Text = "0"
        End Try

    End Sub
    Private Sub MostIdPago()
        Try
            Dim idPag As String
            Dim CantPAgo As String
            Dim rowCU As DataGridViewRow = Paciente_pagoDataGridView.CurrentRow
            idPag = CStr(rowCU.Cells(0).Value)
            CantPAgo = CStr(rowCU.Cells(3).Value)
            IdPago.Text = idPag
            TotalPago.Text = CantPAgo
            EditCancelPago()
        Catch ex As Exception
            IdPago.Text = "0"
        End Try

    End Sub
    Private Sub EditCancelPago()
        EditarCancelarPago.Show()
        EditarCancelarPago.NamePago.Text = TotalPago.Text
        EditarCancelarPago.IdPago.Text = IdPago.Text
        EditarCancelarPago.PacienteId.Text = PacienteID.Text
    End Sub
    Private Sub EditCancelServ()
        EditarCancelarServicio.Show()
        EditarCancelarServicio.NameServ.Text = NameServ.Text
        EditarCancelarServicio.IdServ.Text = IdServ.Text
        EditarCancelarServicio.idPaciente.Text = PacienteID.Text
    End Sub

    Private Sub Paciente_servicioDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Paciente_servicioDataGridView.CellClick
        MostIdServ()
    End Sub
    Private Sub Paciente_pagoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Paciente_pagoDataGridView.CellClick
        MostIdPago()
    End Sub

    Private Sub PacienteID_TextChanged(sender As Object, e As EventArgs) Handles PacienteID.TextChanged
        MostrarServActivos()
        MostrarPagosActivos()
    End Sub
    Public Sub MostrarServActivos()
        If PacienteID.Text > 1 Then
            'PACIENTE, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_servicioTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_servicio, PacienteID.Text, "1", "1")
            Operaciones()
        End If
    End Sub
    Public Sub MostrarPagosActivos()
        If PacienteID.Text > 1 Then
            'PAGO, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_pagoTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_pago, PacienteID.Text, "1", "1")
            Operaciones()
        End If
    End Sub
    Public Sub MostrarServCancel()
        If PacienteID.Text > 1 Then
            'PACIENTE, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_servicioTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_servicio, PacienteID.Text, "0", "0")
            Operaciones()
        End If
    End Sub
    Public Sub MostrarPagosCancel()
        If PacienteID.Text > 1 Then
            'PAGOS, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_pagoTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_pago, PacienteID.Text, "0", "0")
            Operaciones()
        End If
    End Sub
    Public Sub MostrarServTodo()
        If PacienteID.Text > 1 Then
            'PACIENTE, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_servicioTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_servicio, PacienteID.Text, "0", "2")
            Operaciones()
        End If
    End Sub
    Public Sub MostrarPagosTodo()
        If PacienteID.Text > 1 Then
            'PAGOS, ESTATUS, ESTATUS (BETWEEN)
            Me.Paciente_pagoTableAdapter.FillPaciEst(Me.Tootalde_dbtDataSet.paciente_pago, PacienteID.Text, "0", "2")
            Operaciones()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MostrarServCancel()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MostrarServTodo()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MostrarServActivos()
    End Sub
    Private Sub ColorServicios()
        For i As Integer = 0 To Paciente_servicioDataGridView.Rows.Count - 1
            'CAMBIAR COLOR FILA
            If CStr(Paciente_servicioDataGridView.Rows(i).Cells(9).Value) = "0" Then
                Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Pink
            Else
                If CStr(Paciente_servicioDataGridView.Rows(i).Cells(9).Value) = "2" Then
                    Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                    Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                Else
                    If CStr(Paciente_servicioDataGridView.Rows(i).Cells(9).Value) = "1" Then
                        Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        Paciente_servicioDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.LightGreen
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub ColorPagos()
        For i As Integer = 0 To Paciente_pagoDataGridView.Rows.Count - 1
            'CAMBIAR COLOR FILA
            If CStr(Paciente_pagoDataGridView.Rows(i).Cells(11).Value) = "0" Then
                Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Pink
            Else
                If CStr(Paciente_pagoDataGridView.Rows(i).Cells(11).Value) = "2" Then
                    Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                    Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                Else
                    If CStr(Paciente_pagoDataGridView.Rows(i).Cells(11).Value) = "1" Then
                        Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        Paciente_pagoDataGridView.Rows(i).DefaultCellStyle.SelectionBackColor = Color.LightGreen
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MostrarPagosActivos()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MostrarPagosTodo()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MostrarPagosCancel()
    End Sub

    Private Sub Paciente_pagoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Paciente_pagoDataGridView.CellContentClick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Me.Close()
    End Sub
End Class