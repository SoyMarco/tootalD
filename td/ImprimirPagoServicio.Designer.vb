<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirPagoServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirPagoServicio))
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.Paciente_servicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Paciente_servicioTableAdapter = New td.tootalde_dbtDataSetTableAdapters.paciente_servicioTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.Paciente_servicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_servicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_servicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tootalde_dbtDataSet
        '
        Me.Tootalde_dbtDataSet.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Paciente_servicioBindingSource
        '
        Me.Paciente_servicioBindingSource.DataMember = "paciente_servicio"
        Me.Paciente_servicioBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Paciente_servicioTableAdapter
        '
        Me.Paciente_servicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountantTableAdapter = Nothing
        Me.TableAdapterManager.appointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bankbTableAdapter = Nothing
        Me.TableAdapterManager.diagnostic_reportTableAdapter = Nothing
        Me.TableAdapterManager.doctorTableAdapter = Nothing
        Me.TableAdapterManager.donorTableAdapter = Nothing
        Me.TableAdapterManager.email_settingsTableAdapter = Nothing
        Me.TableAdapterManager.emailTableAdapter = Nothing
        Me.TableAdapterManager.expense_categoryTableAdapter = Nothing
        Me.TableAdapterManager.expenseTableAdapter = Nothing
        Me.TableAdapterManager.featuredTableAdapter = Nothing
        Me.TableAdapterManager.groupsTableAdapter = Nothing
        Me.TableAdapterManager.holidaysTableAdapter = Nothing
        Me.TableAdapterManager.lab_categoryTableAdapter = Nothing
        Me.TableAdapterManager.laboratoristTableAdapter = Nothing
        Me.TableAdapterManager.labTableAdapter = Nothing
        Me.TableAdapterManager.login_attemptsTableAdapter = Nothing
        Me.TableAdapterManager.medical_historyTableAdapter = Nothing
        Me.TableAdapterManager.medicine_categoryTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.nurseTableAdapter = Nothing
        Me.TableAdapterManager.ot_paymentTableAdapter = Nothing
        Me.TableAdapterManager.paciente_pagoTableAdapter = Nothing
        Me.TableAdapterManager.paciente_servicioTableAdapter = Me.Paciente_servicioTableAdapter
        Me.TableAdapterManager.patient_depositTableAdapter = Nothing
        Me.TableAdapterManager.patient_materialTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.payment_categoryTableAdapter = Nothing
        Me.TableAdapterManager.paymentGatewayTableAdapter = Nothing
        Me.TableAdapterManager.paymentTableAdapter = Nothing
        Me.TableAdapterManager.pharmacistTableAdapter = Nothing
        Me.TableAdapterManager.pharmacy_expense_categoryTableAdapter = Nothing
        Me.TableAdapterManager.pharmacy_expenseTableAdapter = Nothing
        Me.TableAdapterManager.pharmacy_payment_categoryTableAdapter = Nothing
        Me.TableAdapterManager.pharmacy_paymentTableAdapter = Nothing
        Me.TableAdapterManager.prescriptionTableAdapter = Nothing
        Me.TableAdapterManager.receptionistTableAdapter = Nothing
        Me.TableAdapterManager.serviceTableAdapter = Nothing
        Me.TableAdapterManager.settingsTableAdapter = Nothing
        Me.TableAdapterManager.slideTableAdapter = Nothing
        Me.TableAdapterManager.sms_settingsTableAdapter = Nothing
        Me.TableAdapterManager.smsTableAdapter = Nothing
        Me.TableAdapterManager.templateTableAdapter = Nothing
        Me.TableAdapterManager.time_scheduleTableAdapter = Nothing
        Me.TableAdapterManager.time_slotTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = td.tootalde_dbtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.users_groupsTableAdapter = Nothing
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.website_settingsTableAdapter = Nothing
        '
        'Paciente_servicioDataGridView
        '
        Me.Paciente_servicioDataGridView.AutoGenerateColumns = False
        Me.Paciente_servicioDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Paciente_servicioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Paciente_servicioDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Paciente_servicioDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Paciente_servicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paciente_servicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Paciente_servicioDataGridView.DataSource = Me.Paciente_servicioBindingSource
        Me.Paciente_servicioDataGridView.Location = New System.Drawing.Point(6, 242)
        Me.Paciente_servicioDataGridView.Name = "Paciente_servicioDataGridView"
        Me.Paciente_servicioDataGridView.RowHeadersVisible = False
        Me.Paciente_servicioDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Paciente_servicioDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.Paciente_servicioDataGridView.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "impresora"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(354, 498)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "pdf"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(498, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57329
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(464, 92)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(145, 25)
        Me.label1.TabIndex = 57343
        Me.label1.Text = "Tootal Dental"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 72)
        Me.Label2.TabIndex = 57344
        Me.Label2.Text = "Av. Adolfo López Mateos 142," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Las Peñitas, Atizapán de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zaragoza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel: 5511460432" &
    ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(219, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 72)
        Me.Label3.TabIndex = 57345
        Me.Label3.Text = "Av. Adolfo López Mateos 142," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Las Peñitas, Atizapán de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zaragoza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel: 5511460432" &
    ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 32)
        Me.Label4.TabIndex = 57346
        Me.Label4.Text = "Peñitas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(269, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 32)
        Me.Label5.TabIndex = 57347
        Me.Label5.Text = "Lago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 57348
        Me.Label6.Text = "Paciente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 18)
        Me.Label7.TabIndex = 57349
        Me.Label7.Text = "Id:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(366, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 57350
        Me.Label8.Text = "Factura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(366, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 57351
        Me.Label9.Text = "Medico:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(367, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 57352
        Me.Label10.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 18)
        Me.Label11.TabIndex = 57353
        Me.Label11.Text = "Tel. Paciente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(3, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 57354
        Me.Label12.Text = "Consultorio:"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tratamiento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TRATAMIENTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descuento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DESCUENTO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 127
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(456, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 18)
        Me.Label13.TabIndex = 57355
        Me.Label13.Text = "Fecha:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(456, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 57356
        Me.Label14.Text = "Fecha:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(456, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 18)
        Me.Label15.TabIndex = 57357
        Me.Label15.Text = "Fecha:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(456, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 18)
        Me.Label16.TabIndex = 57358
        Me.Label16.Text = "Fecha:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(456, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 18)
        Me.Label17.TabIndex = 57359
        Me.Label17.Text = "Fecha:"
        '
        'ImprimirPagoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 788)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Paciente_servicioDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImprimirPagoServicio"
        Me.Text = "ImprimirPagoServicio"
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_servicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_servicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents Paciente_servicioBindingSource As BindingSource
    Friend WithEvents Paciente_servicioTableAdapter As tootalde_dbtDataSetTableAdapters.paciente_servicioTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Paciente_servicioDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Button5 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
