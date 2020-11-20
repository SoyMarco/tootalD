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

        Catch ex As Exception
            idPaciente.Text = "0"
        End Try

    End Sub

    Private Sub PatientDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellContentClick

    End Sub

    Private Sub PatientDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellClick
        MostIdPaci()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        NuevoPaciente.Show()
    End Sub
End Class