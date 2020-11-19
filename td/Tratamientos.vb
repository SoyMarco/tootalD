Public Class Tratamientos
    Private Sub Payment_categoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Payment_categoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Tratamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.payment_category' Puede moverla o quitarla según sea necesario.
        Me.Payment_categoryTableAdapter.Fill(Me.Tootalde_dbtDataSet.payment_category)
        Me.Payment_categoryDataGridView.Sort(Payment_categoryDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim desc As String
        Dim prec As String
        Dim nombre As String
        Dim categ As String
        Dim comisi As String
        Payment_categoryTableAdapter.InsertTratamiento(nombre, desc, prec, categ, comisi, "0")
    End Sub
End Class