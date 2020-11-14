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
        Try
            'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
            Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
            'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.doctor' Puede moverla o quitarla según sea necesario.
            Me.DoctorTableAdapter.Fill(Me.Tootalde_dbtDataSet.doctor)

        Catch ex As Exception
            ErrCnn.Visible = True
        End Try


        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1)

        LlenarCols()
        Inicio()
        homeLago.Show()
        Inicial.Hide()
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
        DataGridViewPEÑITAS.DataSource = AppointmentDataGridView.DataSource

    End Sub

    Public Sub Inicio()
        Cursor = Cursors.WaitCursor
        funix.Text = (((Int(DateTimePicker1.Value.ToOADate)) - 25569) * 86400) + 14400
        funix2.Text = (((Int(DateTimePicker2.Value.ToOADate)) - 25569) * 86400) + 14400
        Peñitas()


    End Sub
    Public Sub Inicio2()
        Cursor = Cursors.WaitCursor
        funix.Text = (((Int(DateTimePicker1.Value.ToOADate)) - 25569) * 86400) + 14400
        funix2.Text = (((Int(DateTimePicker2.Value.ToOADate)) - 25569) * 86400) + 14400
        Peñitas2()


    End Sub
    Public Sub LlenarCols()

    End Sub
    Public Sub Peñitas()
        Try
            'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.


            Me.AppointmentTableAdapter.FillFiltroPeñitas(Me.Tootalde_dbtDataSet.appointment, funix.Text, funix2.Text)
            Me.AppointmentDataGridView.Sort(AppointmentDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        Catch ex As Exception
            ErrCnn.Visible = True
        End Try
        'COPIA LOS DATOS DE LA PRINCIPAL A PEÑITAS
        For Each col As DataGridViewColumn In AppointmentDataGridView.Columns
            DataGridViewPEÑITAS.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next



        DataGridViewPEÑITAS.DataSource = AppointmentDataGridView.DataSource


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
                    'Cambiar color fila

                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewPEÑITAS.Item(0, Renglones).Value = NomDr

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
                        Me.DataGridViewPEÑITAS.Item(1, Renglones).Value = NomDr
                        'CAMBIAR COLOR FILA
                        ColorFila()
                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next


        Next
        ColorFila()
        DataGridViewPEÑITAS.ReadOnly = True
        ftitulo.Text = DateTimePicker1.Value.ToLongDateString
        Cursor = Cursors.Default
    End Sub
    Public Sub Peñitas2()

        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.


        Me.AppointmentTableAdapter.FillFiltroPeñitas(Me.Tootalde_dbtDataSet.appointment, funix.Text, funix2.Text)
        Me.AppointmentDataGridView.Sort(AppointmentDataGridView.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        'COPIA LOS DATOS DE LA PRINCIPAL A PEÑITAS
        For Each col As DataGridViewColumn In AppointmentDataGridView.Columns
            DataGridViewPEÑITAS.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next



        DataGridViewPEÑITAS.DataSource = AppointmentDataGridView.DataSource


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
                    'Cambiar color fila

                    Try
                        Dim NomDr As String
                        Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
                        NomDr = CStr(rowCU.Cells(1).Value)
                        Me.DataGridViewPEÑITAS.Item(1, Renglones).Value = NomDr

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
                        Me.DataGridViewPEÑITAS.Item(2, Renglones).Value = NomDr
                        'CAMBIAR COLOR FILA
                        ColorFila()
                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        Next
        ColorFila()
        DataGridViewPEÑITAS.ReadOnly = True
        ftitulo.Text = DateTimePicker1.Value.ToLongDateString
        Cursor = Cursors.Default
    End Sub

    Private Sub ColorFila()
        For i As Integer = 0 To AppointmentDataGridView.Rows.Count - 1
            'CAMBIAR COLOR FILA
            If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Pending Confirmation" Then
                DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Yellow
            Else
                If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Cancelled" Then
                    DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                    DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Pink
                Else
                    If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Confirmed" Then
                        DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                        DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.SelectionBackColor = Color.SkyBlue
                    Else
                        If CStr(AppointmentDataGridView.Rows(i).Cells(3).Value) = "Treated" Then
                            DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            DataGridViewPEÑITAS.Rows(i).DefaultCellStyle.SelectionBackColor = Color.LightGreen
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Peñitas()
    End Sub
    Public Sub Lago()
        Dim form2 As New homeLago
        form2.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(form2)
        form2.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Lago()
    End Sub


    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        NuevaCita.Show()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If contador.Text < 1 Then
            Inicio()
            homeLago.Lago()
        Else
            Inicio2()
            homeLago.Lago2()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        contador.Text = contador.Text + 1
        DataGridViewPEÑITAS.Columns.Clear()
        homeLago.DataGridViewLago.Columns.Clear()
        DateTimePicker2.Value = DateTimePicker1.Value.AddDays(1)
        If contador.Text < 1 Then
            Inicio()
            homeLago.Lago()
        Else
            Inicio2()
            homeLago.Lago2()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador.Text = contador.Text + 1
        DataGridViewPEÑITAS.Columns.Clear()
        homeLago.DataGridViewLago.Columns.Clear()
        DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1)

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        contador.Text = contador.Text + 1
        DataGridViewPEÑITAS.Columns.Clear()
        homeLago.DataGridViewLago.Columns.Clear()
        DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-1)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        homeLago.Show()
        contador.Text = contador.Text + 1
        DataGridViewPEÑITAS.Columns.Clear()
        homeLago.DataGridViewLago.Columns.Clear()
        Inicio2()
        homeLago.Lago2()
    End Sub

    Private Sub DataGridViewPEÑITAS_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPEÑITAS.CellContentDoubleClick

    End Sub
    Private Sub DataGridViewPEÑITAS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPEÑITAS.CellContentClick
        MostrarIdCita()
    End Sub
    Private Sub MostrarIdCita()
        If contador.Text < 1 Then
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewPEÑITAS.CurrentRow
            NomDr = CStr(rowCU.Cells(2).Value)
            IDcita.Text = NomDr
        Else
            Dim NomDr As String
            Dim rowCU As DataGridViewRow = DataGridViewPEÑITAS.CurrentRow
            NomDr = CStr(rowCU.Cells(8).Value)
            IDcita.Text = NomDr
        End If
        If IDcita.Text > "1" Then
            citas.Show()

        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        recargar()
    End Sub
    Public Sub recargar()
        Cursor = Cursors.WaitCursor
        Inicial.CerrarAbrirStart()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        recargar()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        Entrada.Show()
    End Sub

    Private Sub DataGridViewPEÑITAS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPEÑITAS.CellClick
        Cursor = Cursors.WaitCursor
        MostrarIdCita()
    End Sub
End Class
