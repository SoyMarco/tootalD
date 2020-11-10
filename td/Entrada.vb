Public Class Entrada
    Private Sub Payment_categoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Payment_categoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        Me.Payment_categoryTableAdapter.Fill(Me.Tootalde_dbtDataSet.payment_category)
        Me.Payment_categoryDataGridView.Sort(Payment_categoryDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub GuardarServicio()
        If Total.Text = "ERROR" Then

            InfoGuarServ.Text = "ERROR EN DATOS"
            InfoGuarServ.ForeColor = Color.Red


        Else
            Paciente_servicioTableAdapter.InsertarServicioPaciente(TratamientoId.Text, CInt(TotParcial.Text), descuento.Text, CInt(Total.Text), PacienteID.Text, NuevoDr.Text, IdCita.Text, DateTimePickerDia.Value, "1", DateTimePickerDia.Value, vbNull)
                                                                    (Tratamiento, precio, descuento, Total, paciente, Doctor, cita, fecha, estatus, fecha_cambio, usuario_cambio)
            InfoGuarServ.Text = "GUARDADO"
            InfoGuarServ.ForeColor = Color.DarkGreen
        End If
    End Sub
    Private Sub GuardarPago()

        Dim montoT As String
        montoT = efectivo.Text + tarjeta.Text
        If montoT > 0 Then
            Dim comi As String
            comi = montoT * 0.2
            Paciente_pagoTableAdapter.InPacientePago(comi, PacienteID.Text, NuevoDr.Text, IdCita.Text, comentarios.Text, NuevoDr.Text, DateTimePickerDia.Value, "1", DateTimePickerDia.Value, vbNull, efectivo.Text, tarjeta.Text, montoT)
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
                Payment_categoryDataGridView.CurrentCell = Payment_categoryDataGridView.Item(0, i)
                'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                Payment_categoryDataGridView.Rows(i).Selected = True
                'Cambiar color fila
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
        If descuento.Text <> "" Then
            If descuento.Text < CInt(TotParcial.Text) Then
                Total.Text = FormatCurrency(TotParcial.Text - descuento.Text)
                Total.ForeColor = Color.Navy
            Else
                Total.Text = "ERROR"
                Total.ForeColor = Color.Red
            End If
        Else
            If CInt(TotParcial.Text) > 0 Then
                Total.ForeColor = Color.Navy
                Total.Text = TotParcial.Text
            Else
                Total.Text = "ERROR"
                Total.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class