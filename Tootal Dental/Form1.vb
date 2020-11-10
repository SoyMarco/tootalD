Public Class Form1
    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.appointment' Puede moverla o quitarla según sea necesario.
        Me.AppointmentTableAdapter.Fill(Me.Tootalde_dbtDataSet.appointment)

    End Sub
End Class
