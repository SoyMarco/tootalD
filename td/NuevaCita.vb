Public Class NuevaCita
    Private Sub NuevaCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.users_groups' Puede moverla o quitarla según sea necesario.
        Me.Users_groupsTableAdapter.Fill(Me.Tootalde_dbtDataSet.users_groups)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.Tootalde_dbtDataSet.users)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.
        Me.AppointmentTableAdapter.FillByID(Me.Tootalde_dbtDataSet.appointment, home.IDcita.Text)

        DateTimePickerDia.Value = home.DateTimePicker1.Value
        IdAppointment.Text = home.IDcita.Text
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
            Hora.Text = Stime
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
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        PacienteID.Text = NomDr

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
            Estatus.BackColor = Color.DarkGoldenrod

        Else
            If Estatus.Text = "Cancelled" Then
                Estatus.BackColor = Color.Pink

            Else
                If Estatus.Text = "Confirmed" Then
                    Estatus.BackColor = Color.SkyBlue

                Else
                    If Estatus.Text = "Treated" Then
                        Estatus.BackColor = Color.LightGreen

                    End If
                End If
            End If
        End If
    End Sub
    Private Sub GuardarCita()

        If PacienteID.Text <> "0" And NuevoDr.Text <> "0" And fecha.Text <> "0" And NuevaHora.Text <> "0" And Estatus.Text <> "0" And NuevoLugar.Text <> "0" Then
            If MsgPacient.Text = "PACIENTE NUEVO" Then
                NuevoPaciente()

            End If

            Try
                AppointmentTableAdapter.NuevaCita(PacienteID.Text, NuevoDr.Text, fecha.Text, NuevaHora.Text, NuevaHora.Text, NuevaHora.Text, NuevoLugar.Text, DateString.ToLower, vbNull, vbNull, Estatus.Text, NuevoDr.Text, vbNull)



            Finally
                Inicial.CerrarAbrirStart()
                Close()
            End Try
        Else
            notificacion.ForeColor = Color.Red
            notificacion.Text = "Datos incompletos"
        End If
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
    Private Sub BtnPendiente_Click(sender As Object, e As EventArgs) Handles BtnPendiente.Click
        Estatus.Text = "Pending Confirmation"
        GuardarCita()
    End Sub

    Private Sub BtnConfimado_Click(sender As Object, e As EventArgs) Handles BtnConfimado.Click
        Estatus.Text = "Confirmed"
        GuardarCita()
    End Sub
    Private Sub Hora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hora.SelectedIndexChanged
        NuevaHora.Text = Hora.SelectedItem
    End Sub

    Private Sub lugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lugar.SelectedIndexChanged
        NuevoLugar.Text = lugar.SelectedItem
    End Sub

    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub PatientDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellContentClick

    End Sub

    Private Sub PatientDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles PatientDataGridView.CurrentCellChanged
        Dim NPaci As String

        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
        If rowCU Is Nothing Then
        Else
            NPaci = CStr(rowCU.Cells(0).Value)
            PacienteID.Text = NPaci
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        PacienteID.Text = 1
        MsgPacient.Text = "PACIENTE NUEVO"
        MsgPacient.BackColor = Color.Orange
    End Sub

    Private Sub PacienteID_Click(sender As Object, e As EventArgs) Handles PacienteID.Click

    End Sub

    Private Sub PacienteID_TextChanged(sender As Object, e As EventArgs) Handles PacienteID.TextChanged
        If PacienteID.Text > "1" Then

            MsgPacient.Text = "EXISTENTE"
            MsgPacient.BackColor = Color.Green
        Else
            PacienteID.Text = 1

            MsgPacient.Text = "PACIENTE NUEVO"
            MsgPacient.BackColor = Color.Orange
        End If
    End Sub

    Private Sub NuevoPaciente()
        Dim pass As String
        Dim ip As String
        Dim dateInser As Integer
        ip = "187.190.163.116"
        pass = "$2y$08$IS3amhsiIeft4/MkDiEwgeNIHBdgUxbqPePdAYt0H4IR3Y0Tyx4jK"
        dateInser = (((Int(DateTimePicker1.Value.ToOADate)) - 25569) * 86400) + 30000



        UsersTableAdapter.InsertNuevoUsuario(ip, ComboBox1.Text, pass, vbNull, "@tootaldental.com", vbNull, vbNull, vbNull, vbNull, dateInser, vbNull, vbNull, vbNull, vbNull, vbNull, vbNull)
            UltimoUsuario()
            Dim NUsGr As Integer
            Dim rowCU As DataGridViewRow = UsersDataGridView.CurrentRow
            NUsGr = CStr(rowCU.Cells(0).Value)
            Users_groupsTableAdapter.InsertUsuarioGrupoR(NUsGr, "5")
            PatientTableAdapter.InsertNuevoPaciente(vbNull, ComboBox1.Text, vbNull, NuevoDr.Text, NuevoLugar.Text, vbNull, vbNull, vbNull, vbNull, vbNull, NUsGr, vbNull, Date.Today, dateInser, vbNull)
        idPacienteN()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = ComboBox1.Text
        NuevoPaciente()
    End Sub
    Private Sub UltimoUsuario()
        UsersTableAdapter.Fill(Tootalde_dbtDataSet.users)
        UsersDataGridView.Sort(UsersDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub idPacienteN()
        PatientTableAdapter.Fill(Tootalde_dbtDataSet.patient)
        PatientDataGridView.Sort(PatientDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        Dim NUsGr As Integer
        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
        NUsGr = CStr(rowCU.Cells(0).Value)
        PacienteID.Text = NUsGr
    End Sub

    Private Sub NuevoDr_Click(sender As Object, e As EventArgs) Handles NuevoDr.Click

    End Sub
End Class