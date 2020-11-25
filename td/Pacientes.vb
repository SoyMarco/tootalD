Public Class Pacientes
    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.patient' Puede moverla o quitarla según sea necesario.
        Me.PatientTableAdapter.Fill(Me.Tootalde_dbtDataSet.patient)
        Me.PatientDataGridView.Sort(PatientDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        Cursor = Cursors.Default
        home.Cursor = Cursors.Default
    End Sub

    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs)
        PatientTableAdapter.FillPacientNom(Tootalde_dbtDataSet.patient, idPaciente.Text)
    End Sub
    Private Sub MostIdPaci()
        Cursor = Cursors.WaitCursor
        Try
            Dim idPaci As String

            Dim rowCU As DataGridViewRow = PatientDataGridView.CurrentRow
            idPaci = CStr(rowCU.Cells(0).Value)
            idPaciente.Text = idPaci
            OpcionesPacientes.Show()

        Catch ex As Exception
            idPaciente.Text = "0"
        End Try

    End Sub
    Public Sub PasoAEntrada()
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
            Try
                name = CStr(rowCU.Cells(1).Value)
            Catch ex As Exception
                name = "ERROR NOMBRE"
            End Try
            Try
                email = CStr(rowCU.Cells(4).Value)
            Catch ex As Exception
                email = "ERROR EMAIL"
            End Try
            Try
                dr = CStr(rowCU.Cells(6).Value)
            Catch ex As Exception
                dr = "ERROR"
            End Try
            Try
                lugar = CStr(rowCU.Cells(7).Value)
            Catch ex As Exception
                lugar = "ERROR lUGAR"
            End Try
            Try
                telefono = CStr(rowCU.Cells(2).Value)
            Catch ex As Exception
                telefono = "ERROR TELEFONO"
            End Try
            Try
                sexo = CStr(rowCU.Cells(5).Value)
            Catch ex As Exception
                sexo = "OTRO"
            End Try
            Try
                edad = CStr(rowCU.Cells(9).Value)
            Catch ex As Exception
                edad = "0"
            End Try
            Try
                fNaci = CStr(rowCU.Cells(3).Value)
            Catch ex As Exception
                fNaci = "0"
            End Try
            Try
                sangr = CStr(rowCU.Cells(10).Value)
            Catch ex As Exception
                sangr = "O+"
            End Try


            Entrada.Show()
            Entrada.PacienteID.Text = idPaciente.Text
            Entrada.NuevoDr.Text = dr
            Entrada.IdCita.Text = "0"
            Entrada.NomPaciente.Text = name
            ' Entrada.Doctor.SelectedItem = Doctor.SelectedItem

            Entrada.lugar.Text = lugar
            Entrada.lugar.Items.Add(lugar)
            Entrada.lugar.SelectedItem = lugar
            Entrada.lugar.SelectedItem = lugar

            Me.Close()
        End If
    End Sub
    Public Sub PasoANuevoPaciente()
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
            Try
                name = CStr(rowCU.Cells(1).Value)
            Catch ex As Exception
                name = "ERROR NOMBRE"
            End Try
            Try
                email = CStr(rowCU.Cells(4).Value)
            Catch ex As Exception
                email = "ERROR EMAIL"
            End Try
            Try
                dr = CStr(rowCU.Cells(6).Value)
            Catch ex As Exception
                dr = "ERROR"
            End Try
            Try
                lugar = CStr(rowCU.Cells(7).Value)
            Catch ex As Exception
                lugar = "ERROR lUGAR"
            End Try
            Try
                telefono = CStr(rowCU.Cells(2).Value)
            Catch ex As Exception
                telefono = "ERROR TELEFONO"
            End Try
            Try
                sexo = CStr(rowCU.Cells(5).Value)
            Catch ex As Exception
                sexo = "OTRO"
            End Try
            Try
                edad = CStr(rowCU.Cells(9).Value)
            Catch ex As Exception
                edad = "0"
            End Try
            Try
                fNaci = CStr(rowCU.Cells(3).Value)
            Catch ex As Exception
                fNaci = "0"
            End Try
            Try
                sangr = CStr(rowCU.Cells(10).Value)
            Catch ex As Exception
                sangr = "O+"
            End Try


            NuevoPaciente.Show()
            NuevoPaciente.BtnEditar.Visible = True

            NuevoPaciente.PacienteId.Text = idPaciente.Text
            NuevoPaciente.Nombre.Text = name
            NuevoPaciente.Email.Text = email

            NuevoPaciente.NuevoDr.Text = dr


            NuevoPaciente.lugar.Text = lugar
            NuevoPaciente.lugar.Items.Add(lugar)
            NuevoPaciente.lugar.SelectedItem = lugar
            NuevoPaciente.lugar.SelectedItem = lugar

            NuevoPaciente.Telefono.Text = telefono

            NuevoPaciente.Sexo.Items.Add(sexo)
            NuevoPaciente.Sexo.SelectedItem = sexo

            NuevoPaciente.Edad.Text = edad
            NuevoPaciente.FNacimiento.Text = fNaci
            NuevoPaciente.TipSangre.Text = sangr





            Me.Close()
        End If
    End Sub
    Private Sub PatientDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellContentClick

    End Sub

    Private Sub PatientDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView.CellClick
        MostIdPaci()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Cursor = Cursors.WaitCursor
        NuevoPaciente.Show()
        NuevoPaciente.BtnGuardar.Visible = True
        Me.Close()
    End Sub
End Class