Public Class Pacientes
    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        Me.PatientDataGridView.Sort(PatientDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        PatientTableAdapter.FillPacientNom(Tootalde_dbtDataSet.patient, idPaciente.Text)
    End Sub
    Private Sub MostIdPaci()
        Try
            Dim idPaci As String

            Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
            idPaci = CStr(rowCU.Cells(0).Value)
            idPaciente.Text = idPaci
            PasoANuevoPaciente()
        Catch ex As Exception
            idPaciente.Text = "0"
        End Try

    End Sub
    Private Sub PasoANuevoPaciente()
        If idPaciente.Text > "0" Then
            Dim name As String
            Dim email As String
            Dim dr As String
            Dim lugar As String
            Dim telefono As String
            Dim sexo As String
            Dim edad As String
            Dim fNaci As String
            Dim sangr As String

            Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow

            name = CStr(rowCU.Cells(1).Value)
            email = CStr(rowCU.Cells(4).Value)
            dr = CStr(rowCU.Cells(6).Value)
            lugar = CStr(rowCU.Cells(7).Value)
            telefono = CStr(rowCU.Cells(2).Value)
            sexo = CStr(rowCU.Cells(5).Value)
            edad = CStr(rowCU.Cells(9).Value)
            fNaci = CStr(rowCU.Cells(3).Value)
            sangr = CStr(rowCU.Cells(10).Value)

            NuevoPaciente.Show()
            NuevoPaciente.BtnEditar.Visible = True

            NuevoPaciente.PacienteId.Text = idPaciente.Text
            NuevoPaciente.Nombre.Text = name
            NuevoPaciente.Email.Text = email
            NuevoPaciente.NuevoDr.Text = dr
            NuevoPaciente.lugar.Text = lugar
            NuevoPaciente.Telefono.Text = telefono

            NuevoPaciente.Sexo.Items.Add(sexo)
            NuevoPaciente.Sexo.SelectedItem = sexo

            NuevoPaciente.Edad.Text = edad
            NuevoPaciente.FNacimiento.Text = fNaci
            NuevoPaciente.TipSangre.Text = sangr






        End If
    End Sub
    Private Sub PatientDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellContentClick

    End Sub

    Private Sub PatientDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellClick
        MostIdPaci()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        NuevoPaciente.Show()
        NuevoPaciente.BtnGuardar.Visible = True
        Me.Close()
    End Sub
End Class