Public Class NuevoPaciente
    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub NuevoPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.Tootalde_dbtDataSet.users)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.users_groups' Puede moverla o quitarla según sea necesario.
        Me.Users_groupsTableAdapter.Fill(Me.Tootalde_dbtDataSet.users_groups)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)

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

    Private Sub NuevoPaciente()
        Dim name As String
        Dim pass As String
        Dim ip As String
        Dim dateInser As Integer
        Dim correo As String

        ip = "187.190.163.116"
        pass = "$2y$08$IS3amhsiIeft4/MkDiEwgeNIHBdgUxbqPePdAYt0H4IR3Y0Tyx4jK"
        dateInser = (((Int(DateTimePicker1.Value.ToOADate)) - 25569) * 86400) + 30000
        If Email.Text <> "" Then
            correo = Email.Text
        Else
            correo = "@tootaldental.com"
        End If

        If Nombre.Text <> "" Then
            name = Nombre.Text
            'Insertar Usuario
            UsersTableAdapter.InsertNuevoUsuario(ip, name, pass, vbNull, correo, vbNull, vbNull, vbNull, vbNull, dateInser, vbNull, vbNull, vbNull, vbNull, vbNull, vbNull)
            '                                   (ip_address, username, password, salt, email, activation_code, forgotten_password_code, forgotten_password_time, remember_code, created_on, last_login, active, first_name, last_name, company, phone)

            UltimoUsuario()

            Dim NUsGr As Integer
            Dim rowCU As DataGridViewRow = UsersDataGridView.CurrentRow
            NUsGr = CStr(rowCU.Cells(0).Value)

            'Insertar Grupo
            Users_groupsTableAdapter.InsertUsuarioGrupoR(NUsGr, "5")

            'Insertar Paciente
            Dim doc As String
            Dim lug As String
            Dim tel As String
            Dim sex As String
            Dim fnac As String
            Dim eda As String
            Dim sang As String

            If Doctor.Text = "" Then
                doc = vbNull
            Else
                doc = Doctor.Text
            End If

            If lugar.Text = "" Then
                lug = vbNull
            Else
                lug = lugar.Text
            End If

            If Telefono.Text = "" Then
                tel = vbNull
            Else
                tel = Telefono.Text
            End If

            If Sexo.Text = "" Then
                sex = vbNull
            Else
                sex = Sexo.Text
            End If

            If FNacimiento.Text = "" Then
                fnac = vbNull
            Else
                fnac = FNacimiento.Text
            End If

            If Edad.Text = "" Then
                eda = vbNull
            Else
                eda = Edad.Text
            End If

            If TipSangre.Text = "" Then
                sang = vbNull
            Else
                sang = TipSangre.Text
            End If

            PatientTableAdapter.InsertNuevoPaciente(vbNull, name, correo, doc, lug, tel, sex, fnac, eda, sang, NUsGr, vbNull, Date.Today, dateInser, vbNull)
            '                                   (img_url, name, email, doctor,address,phone,sex, birthdate, age, bloodgroup, ion_user_id, patient_id, add_date, registration_time, how_added`)

            idPacienteN()
        Else
            Informe.Text = "ERROR DE NOMBRE"
            Informe.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Doctor.SelectedIndexChanged

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        NuevoPaciente()
    End Sub
End Class