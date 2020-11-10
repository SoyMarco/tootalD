Public Class home
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        citas.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.
        Me.AppointmentTableAdapter.Fill(Me.Tootalde_dbtDataSet.appointment)

    End Sub

    Public Sub CopyColu()
        Dim col1 As New DataGridViewTextBoxColumn()
        col1.Name = "Columna1"
        col1.HeaderText = "Columna1"

        Dim col2 As New DataGridViewCheckBoxColumn()
        col2.Name = "Columna2"
        col2.HeaderText = "Columna2"

        AppointmentDataGridView.Columns.AddRange(col1, col2)
    End Sub

    Private Sub CopyCol()
        For Each col As DataGridViewColumn In AppointmentDataGridView.Columns
            DataGridView1.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CopyCol()
    End Sub

    Public Sub ConvUnix()
        funix.Text = ((Int(DateTimePicker1.Value.ToOADate)) - 25569) * 86400
    End Sub
End Class
