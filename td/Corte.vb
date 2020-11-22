Public Class Corte
    Private Sub Paciente_pagoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Paciente_pagoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Corte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
        Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.paciente_pago' Puede moverla o quitarla según sea necesario.
        Me.Paciente_pagoTableAdapter.Fill(Me.Tootalde_dbtDataSet.paciente_pago)
        Paciente_pagoTableAdapter.FillEntreFechas(Tootalde_dbtDataSet.paciente_pago, DateTimePicker1.Value, DateTimePicker2.Value)

        DateTimePicker1.Value = DateTime.Today.AddDays(-DateTime.Today.DayOfWeek + 1)
        DateTimePicker2.Value = DateTimePicker1.Value.AddDays(5)

        InicioCorte()

        Cursor = Cursors.Default
        home.Cursor = Cursors.Default
    End Sub
    Public Sub InicioCorte()
        ' ORIGINAL   AppointmentDataGridView =   Paciente_pagoDataGridView
        ' COPIA      DataGridViewCorte=        DataGridViewCorte

        'COPIA LOS DATOS DE LA PRINCIPAL A CORTE    
        For Each col As DataGridViewColumn In Paciente_pagoDataGridView.Columns
            DataGridViewCorte.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next



        DataGridViewCorte.DataSource = Paciente_pagoDataGridView.DataSource


        For Renglones As Integer = 0 To Paciente_pagoDataGridView.RowCount - 1
            'PACIENTE
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To PatientDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
                If PatientDataGridView.Rows(i).Cells(0).Value = Me.Paciente_pagoDataGridView.Item(7, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    PatientDataGridView.CurrentCell = PatientDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    PatientDataGridView.Rows(i).Selected = True
                    'Cambiar color fila

                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(2).Value)
                        Me.DataGridViewCorte.Item(0, Renglones).Value = NomDr

                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        Next



        For Renglones As Integer = 0 To Paciente_pagoDataGridView.RowCount - 1
            'DOCTOR
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To DoctorDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
                If DoctorDataGridView.Rows(i).Cells(0).Value = Me.Paciente_pagoDataGridView.Item(8, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    DoctorDataGridView.CurrentCell = DoctorDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    DoctorDataGridView.Rows(i).Selected = True
                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = DoctorDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(2).Value)
                        Me.DataGridViewCorte.Item(1, Renglones).Value = NomDr
                        'CAMBIAR COLOR FILA

                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next


        Next
        DataGridViewCorte.ReadOnly = True
        Operaciones()
        Cursor = Cursors.Default
    End Sub
    Private Sub Operaciones()
        Dim Total As Single
        Dim Col As Integer = Me.Paciente_pagoDataGridView.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.Paciente_pagoDataGridView.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Me.Tsemana.Text = FormatCurrency(Total.ToString)
        Tcomisiones.Text = FormatCurrency(Total * 0.2)
    End Sub
End Class