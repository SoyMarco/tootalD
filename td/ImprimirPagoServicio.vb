Public Class ImprimirPagoServicio
    Private Sub Paciente_servicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Paciente_servicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tootalde_dbtDataSet)

    End Sub

    Private Sub ImprimirPagoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tootalde_dbtDataSet.paciente_servicio' Puede moverla o quitarla según sea necesario.
        Me.Paciente_servicioTableAdapter.Fill(Me.Tootalde_dbtDataSet.paciente_servicio)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintForm()
    End Sub
    Private Sub PrintForm()
        Try
            Cursor.Current = Cursors.WaitCursor
            With Me.PrintForm1
                .PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(20, 11, 20, 11)
                .PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End With
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pdf()
    End Sub
    Private Sub pdf()
        ' Establezca PrintAction para que aparezca un cuadro de diálogo Print Preview
        PrintForm1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintForm1.PrintFileName = CStr(vbLongDate)
        ' Imprima una copia del formulario
        Me.PrintForm1.Print()
    End Sub
    Private Sub Impresora()
        ' Establezca PrintAction para que aparezca un cuadro de diálogo Print Previe
        Me.PrintForm1.Print()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Impresora()
    End Sub
End Class