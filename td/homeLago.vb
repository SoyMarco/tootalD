Public Class homeLago
    Private Sub homeLago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
            Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
            'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
            Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)

            Lago()
        Catch ex As Exception
            home.ErrCnn.Visible = True
        End Try

    End Sub

    Public Sub Lago()
        For Each col As DataGridViewColumn In AppointmentDataGridView.Columns
            DataGridViewLago.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next
        Try
            Me.AppointmentTableAdapter.FillFiltroLago(Me.Tootalde_dbtDataSet.appointment, home.funix.Text, home.funix2.Text)

        Catch ex As Exception
            home.ErrCnn.Visible = True
        End Try
        'COPIA LOS DATOS DE LA PRINCIPAL A LAGO
        DataGridViewLago.DataSource = AppointmentDataGridView.DataSource

        For Renglones As Integer = 0 To AppointmentDataGridView.RowCount - 1


            'PACIENTE
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To PatientDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3

                If PatientDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(5, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    PatientDataGridView.CurrentCell = PatientDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    PatientDataGridView.Rows(i).Selected = True


                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewLago.Item(0, Renglones).Value = NomDr
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
                If DoctorDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(6, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    DoctorDataGridView.CurrentCell = DoctorDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    DoctorDataGridView.Rows(i).Selected = True
                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = DoctorDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewLago.Item(1, Renglones).Value = NomDr

                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        Next
        ColorFila()
        Me.AppointmentDataGridView.Sort(AppointmentDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Public Sub Lago2()
        For Each col As DataGridViewColumn In AppointmentDataGridView.Columns
            DataGridViewLago.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next
        Me.AppointmentTableAdapter.FillFiltroLago(Me.Tootalde_dbtDataSet.appointment, home.funix.Text, home.funix2.Text)
        'COPIA LOS DATOS DE LA PRINCIPAL A LAGO
        DataGridViewLago.DataSource = AppointmentDataGridView.DataSource

        For Renglones As Integer = 0 To AppointmentDataGridView.RowCount - 1


            'PACIENTE
            'PASAR DE UNA CELDA A OTRA TOMANDO ID DE LA PRIMERA
            For i As Integer = 0 To PatientDataGridView.Rows.Count - 1
                'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3

                If PatientDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(5, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    PatientDataGridView.CurrentCell = PatientDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    PatientDataGridView.Rows(i).Selected = True


                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewLago.Item(1, Renglones).Value = NomDr
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
                If DoctorDataGridView.Rows(i).Cells(0).Value = Me.AppointmentDataGridView.Item(6, Renglones).Value Then
                    'Mueve el cursor a dicha fila
                    DoctorDataGridView.CurrentCell = DoctorDataGridView.Item(0, i)
                    'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                    DoctorDataGridView.Rows(i).Selected = True
                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = DoctorDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewLago.Item(2, Renglones).Value = NomDr

                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        Next
        ColorFila()
        Me.AppointmentDataGridView.Sort(AppointmentDataGridView.Columns(7), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub ColorFila()
        For i As Integer = 0 To AppointmentDataGridView.Rows.Count - 1
            'CAMBIAR COLOR FILA
            If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Pending Confirmation" Then
                DataGridViewLago.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                DataGridViewLago.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Yellow
            Else
                If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Cancelled" Then
                    DataGridViewLago.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                    DataGridViewLago.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Pink
                Else
                    If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Confirmed" Then
                        DataGridViewLago.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                        DataGridViewLago.Rows(i).DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                    Else
                        If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Treated" Then
                            DataGridViewLago.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            DataGridViewLago.Rows(i).DefaultCellStyle.SelectionBackColor = Color.LightGreen
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub DataGridViewLago_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLago.CellContentDoubleClick
        If home.contador.Text < 1 Then
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewLago.CurrentRow
            NomDr = CStr(rowCU.Cells(2).Value)
            home.IDcita.Text = NomDr
        Else
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewLago.CurrentRow
            NomDr = CStr(rowCU.Cells(8).Value)
            home.IDcita.Text = NomDr
        End If

    End Sub

    Private Sub DataGridViewLago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLago.CellContentClick
        AbrirCita()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        home.recargar()
    End Sub

    Private Sub DataGridViewLago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLago.CellClick
        AbrirCita()
    End Sub
    Private Sub AbrirCita()
        Cursor = Cursors.WaitCursor
        If home.contador.Text < 1 Then
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewLago.CurrentRow
            NomDr = CStr(rowCU.Cells(2).Value)
            home.IDcita.Text = NomDr
        Else
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewLago.CurrentRow
            NomDr = CStr(rowCU.Cells(8).Value)
            home.IDcita.Text = NomDr
        End If
        If home.IDcita.Text > "1" Then
            citas.Show()
            Cursor = Cursors.Default
        End If

    End Sub
End Class