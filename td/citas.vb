Public Class citas
    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.
        Me.AppointmentTableAdapter.FillByID(Me.Tootalde_dbtDataSet.appointment, home.IDcita.Text)
        IdAppointment.Text = home.IDcita.Text
        DatosId()
        DateTimePickerDia.Value = home.DateTimePicker1.Value
        IdAppointment.Text = home.IDcita.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub DatosId()
        Try
            Dim DateConsul As String
            Dim Stime As String
            Dim Remarks As String
            Dim Status As String
            Dim rowCU As DataGridViewRow = AppointmentDataGridView.CurrentRow
            DateConsul = CStr(rowCU.Cells(3).Value)
            Stime = CStr(rowCU.Cells(5).Value)
            Remarks = CStr(rowCU.Cells(7).Value)
            Status = CStr(rowCU.Cells(11).Value)

            fecha.Text = DateConsul
            Hora.SelectedItem = Stime
            NuevaHora.Text = Stime
            lugar.SelectedItem = Remarks
            Estatus.Text = Status

        Catch ex As Exception
        End Try


        For Renglones As Integer = 0 To AppointmentDataGridView.RowCount - 1
            'PACIENTE
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To PatientDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
                If PatientDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(1, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    PatientDataGridView.CurrentCell = PatientDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    PatientDataGridView.Rows(i).Selected = True
                    'Cambiar color fila

                    Try
                        Dim NomPac As String
                        Dim idPac As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomPac = CStr(rowCU.Cells(1).Value)
                        idPac = CStr(rowCU.Cells(0).Value)
                        Paciente.Text = NomPac
                        IdPaciente.Text = idPac
                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        Next




        For Renglones As Integer = 0 To AppointmentDataGridView.RowCount - 1
            'DOCTOR
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To DoctorDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
                If DoctorDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(2, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    DoctorDataGridView.CurrentCell = DoctorDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    DoctorDataGridView.Rows(i).Selected = True
                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = DoctorDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Doctor.Text = NomDr
                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next


        Next
    End Sub

    Private Sub Estatus_Click(sender As Object, e As EventArgs) Handles Estatus.Click

    End Sub

    Private Sub Estatus_TextChanged(sender As Object, e As EventArgs) Handles Estatus.TextChanged
        If Estatus.Text = "Pending Confirmation" Then
            Estatus.ForeColor = Color.DarkGoldenrod

        Else
            If Estatus.Text = "Cancelled" Then
                Estatus.ForeColor = Color.Pink

            Else
                If Estatus.Text = "Confirmed" Then
                    Estatus.ForeColor = Color.SkyBlue

                Else
                    If Estatus.Text = "Treated" Then
                        Estatus.ForeColor = Color.LightGreen

                    End If
                End If
            End If
        End If
    End Sub
    Private Sub GuardarCita()
        Try
            AppointmentTableAdapter.UpdateAppointment(NuevoDr.Text, fecha.Text, NuevaHora.Text, NuevoLugar.Text, Estatus.Text, IdAppointment.Text)
        Finally
            home.Button1.PerformClick()
            home.Button2.PerformClick()
            Close()
        End Try
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

    Private Sub DateTimePickerDia_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDia.ValueChanged
        fecha.Text = (((Int(DateTimePickerDia.Value.ToOADate)) - 25569) * 86400) + 30000
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Estatus.Text = "Cancelled"
        GuardarCita()
    End Sub

    Private Sub BtnPendiente_Click(sender As Object, e As EventArgs) Handles BtnPendiente.Click
        Estatus.Text = "Pending Confirmation"
        GuardarCita()
    End Sub

    Private Sub BtnConfimado_Click(sender As Object, e As EventArgs) Handles BtnConfimado.Click
        Estatus.Text = "Confirmed"
        GuardarCita()
    End Sub

    Private Sub BtnTratado_Click(sender As Object, e As EventArgs) Handles BtnTratado.Click
        Estatus.Text = "Treated"
        GuardarCita()
    End Sub

    Private Sub Hora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hora.SelectedIndexChanged
        NuevaHora.Text = Hora.SelectedItem
    End Sub

    Private Sub lugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lugar.SelectedIndexChanged
        NuevoLugar.Text = lugar.SelectedItem
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PagoServicio()
    End Sub
    Public Sub PagoServicio()
        Entrada.Show()
        Entrada.PacienteID.Text = IdPaciente.Text
        Entrada.NuevoDr.Text = NuevoDr.Text
        Entrada.NuevoLugar.Text = NuevoLugar.Text
        Entrada.IdCita.Text = IdAppointment.Text
        Entrada.NomPaciente.Text = Paciente.Text
        Entrada.Doctor.SelectedItem = Doctor.SelectedItem
        Entrada.lugar.SelectedItem = lugar.SelectedItem
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        PagoServicio()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PagoServicio()
    End Sub
End Class