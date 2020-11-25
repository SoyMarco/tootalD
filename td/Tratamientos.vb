Public Class Tratamientos
    Private Sub Payment_categoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Payment_categoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Tratamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.payment_category' Puede moverla o quitarla según sea necesario.
        ListaTratamientos()
    End Sub
    Private Sub ListaTratamientos()
        Me.Payment_categoryTableAdapter.Fill(Me.Tootalde_dbtDataSet.payment_category)
        Me.Payment_categoryDataGridView.Sort(Payment_categoryDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Cursor = Cursors.Default
        home.Cursor = Cursors.Default
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        If Nombre.Text <> "" And Precio.Text <> "" Then
            Aviso.Visible = False

            Dim nombr As String
            Dim descr As String
            Dim prec As String
            Dim categ As String

            nombr = Nombre.Text
            prec = Precio.Text
            descr = nombr & " " & prec
            categ = Tratamiento.Text


            Try
                Payment_categoryTableAdapter.InsertTratamiento(descr, nombr, prec, categ, "20", "0")
                ListaTratamientos()
                Nombre.Text = ""
                Precio.Text = ""
                Tratamiento.Text = "Otro"
                Aviso.Visible = True
                Aviso.ForeColor = Color.Green
                Aviso.Text = "TRATAMIENTO GUARDADO"
            Catch ex As Exception
                Aviso.Visible = True
                Aviso.ForeColor = Color.Red
                Aviso.Text = "ERROR BASE"
            End Try

        Else
            Aviso.Visible = True
            Aviso.ForeColor = Color.Red
            Aviso.Text = "ERROR"
        End If

    End Sub
    Private Sub MostIdTrata()
        Try
            Dim idTrata As String
            Dim rowCU As DataGridViewRow = Payment_categoryDataGridView.CurrentRow
            idTrata = CStr(rowCU.Cells(0).Value)
            idTratamiento.Text = idTrata
            MostrarTratEdit()
        Catch ex As Exception
            idTratamiento.Text = "0"
        End Try

    End Sub

    Private Sub Payment_categoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Payment_categoryDataGridView.CellClick
        MostIdTrata()
    End Sub
    Private Sub MostrarTratEdit()
        For i As Integer = 0 To Payment_categoryDataGridView.Rows.Count - 1
            'Si el valor de la primera celda ubicada, por ejemplo, en la fila 1 es igual a 3
            If Payment_categoryDataGridView.Rows(i).Cells(0).Value = idTratamiento.Text Then
                'Mueve el cursor a dicha fila
                Payment_categoryDataGridView.CurrentCell = Payment_categoryDataGridView.Item(0, i)
                'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)
                Payment_categoryDataGridView.Rows(i).Selected = True
                'Cambiar color fila

                Try
                    Dim descr1 As String
                    Dim nombr2 As String
                    Dim prec3 As String
                    Dim categ4 As String

                    Dim rowCU As DataGridViewRow = Payment_categoryDataGridView.CurrentRow
                    descr1 = CStr(rowCU.Cells(1).Value)
                    nombr2 = CStr(rowCU.Cells(2).Value)
                    prec3 = CStr(rowCU.Cells(3).Value)
                    categ4 = CStr(rowCU.Cells(4).Value)

                    Nombre.Text = nombr2
                    Precio.Text = prec3
                    Tratamiento.Text = categ4

                    ButtonAgregar.Visible = False
                    ButtonEdit.Visible = True

                Catch ex As Exception
                End Try
                Exit For
            End If
        Next
    End Sub

    Private Sub Precio_TextChanged(sender As Object, e As EventArgs) Handles Precio.TextChanged

    End Sub

    Private Sub Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio.KeyPress
        'SOLO NUMEROS Y UN PUNTO
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Precio.Text.IndexOf(".") Then
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

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        If Nombre.Text <> "" And Precio.Text <> "" Then
            Aviso.Visible = False

            Dim nombr As String
            Dim descr As String
            Dim prec As String
            Dim categ As String

            nombr = Nombre.Text
            prec = Precio.Text
            descr = nombr & " " & prec
            categ = Tratamiento.Text

            If idTratamiento.Text > 0 Then
                Try
                    Payment_categoryTableAdapter.UpdateTratamiento(descr, nombr, prec, categ, idTratamiento.Text)

                    ListaTratamientos()
                    Nombre.Text = ""
                    Precio.Text = ""
                    ButtonEdit.Visible = False
                    Aviso.Visible = True
                    Aviso.Text = "CAMBIO GUARDADO"
                    Aviso.ForeColor = Color.Green
                    ButtonAgregar.Visible = True
                    idTratamiento.Text = "0"
                Catch ex As Exception
                    Aviso.Visible = True
                    Aviso.ForeColor = Color.Red
                    Aviso.Text = "ERROR BASE"
                End Try
            End If
        Else
            Aviso.Visible = True
            Aviso.ForeColor = Color.Red
            Aviso.Text = "ERROR"
        End If

    End Sub
End Class