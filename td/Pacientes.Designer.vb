<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.NomPaciente = New System.Windows.Forms.Label()
        Me.PatientTableAdapter = New td.tootalde_dbtDataSetTableAdapters.patientTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.idPaciente = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica LT Std", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PatientDataGridView.Location = New System.Drawing.Point(156, 85)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(765, 279)
        Me.PatientDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 46
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "phone"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 93
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "birthdate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Nacim."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 127
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sex"
        Me.DataGridViewTextBoxColumn8.HeaderText = "sex"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn2.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn10.HeaderText = "age"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "bloodgroup"
        Me.DataGridViewTextBoxColumn11.HeaderText = "bloodgroup"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "patient_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "patient_id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "add_date"
        Me.DataGridViewTextBoxColumn14.HeaderText = "add_date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "registration_time"
        Me.DataGridViewTextBoxColumn15.HeaderText = "registration_time"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "how_added"
        Me.DataGridViewTextBoxColumn16.HeaderText = "how_added"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Tootalde_dbtDataSet
        '
        Me.Tootalde_dbtDataSet.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Buscar.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(733, 39)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(188, 40)
        Me.Buscar.TabIndex = 57422
        Me.Buscar.Text = "Editar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'NomPaciente
        '
        Me.NomPaciente.AutoSize = True
        Me.NomPaciente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NomPaciente.Location = New System.Drawing.Point(151, 7)
        Me.NomPaciente.Name = "NomPaciente"
        Me.NomPaciente.Size = New System.Drawing.Size(115, 32)
        Me.NomPaciente.TabIndex = 57423
        Me.NomPaciente.Text = "Nombre"
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.paciente_servicioTableAdapter = Nothing
        Me.TableAdapterManager.patient_depositTableAdapter = Nothing
        Me.TableAdapterManager.patient_materialTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Me.PatientTableAdapter
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
        'idPaciente
        '
        Me.idPaciente.AutoSize = True
        Me.idPaciente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idPaciente.Location = New System.Drawing.Point(760, 6)
        Me.idPaciente.Name = "idPaciente"
        Me.idPaciente.Size = New System.Drawing.Size(39, 32)
        Me.idPaciente.TabIndex = 57424
        Me.idPaciente.Text = "Id"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(-7, -7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(157, 475)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57425
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 50)
        Me.Label8.TabIndex = 57426
        Me.Label8.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paciente"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57427
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.PatientBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.Font = New System.Drawing.Font("Helvetica LT Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(571, 37)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(727, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 32)
        Me.Label1.TabIndex = 57428
        Me.Label1.Text = "Id"
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.idPaciente)
        Me.Controls.Add(Me.NomPaciente)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As tootalde_dbtDataSetTableAdapters.patientTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientDataGridView As DataGridView
    Friend WithEvents Buscar As Button
    Friend WithEvents NomPaciente As Label
    Friend WithEvents idPaciente As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
