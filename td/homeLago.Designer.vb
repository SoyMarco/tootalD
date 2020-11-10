<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeLago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeLago))
        Me.DataGridViewLago = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New td.tootalde_dbtDataSetTableAdapters.appointmentTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.StimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeslotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StimekeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorTableAdapter = New td.tootalde_dbtDataSetTableAdapters.doctorTableAdapter()
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New td.tootalde_dbtDataSetTableAdapters.patientTableAdapter()
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewLago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewLago
        '
        Me.DataGridViewLago.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewLago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewLago.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewLago.Location = New System.Drawing.Point(28, 90)
        Me.DataGridViewLago.Name = "DataGridViewLago"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewLago.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewLago.Size = New System.Drawing.Size(430, 430)
        Me.DataGridViewLago.TabIndex = 57337
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(206, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 32)
        Me.Label3.TabIndex = 57338
        Me.Label3.Text = "Lago"
        '
        'Tootalde_dbtDataSet
        '
        Me.Tootalde_dbtDataSet.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "appointment"
        Me.AppointmentBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountantTableAdapter = Nothing
        Me.TableAdapterManager.appointmentTableAdapter = Me.AppointmentTableAdapter
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
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StimeDataGridViewTextBoxColumn, Me.Paciente, Me.Dr, Me.StatusDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn, Me.PatientDataGridViewTextBoxColumn, Me.DoctorDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.TimeslotDataGridViewTextBoxColumn, Me.EtimeDataGridViewTextBoxColumn, Me.AdddateDataGridViewTextBoxColumn, Me.RegistrationtimeDataGridViewTextBoxColumn, Me.StimekeyDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.RequestDataGridViewTextBoxColumn})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource1
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(28, 290)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(327, 220)
        Me.AppointmentDataGridView.TabIndex = 57339
        '
        'StimeDataGridViewTextBoxColumn
        '
        Me.StimeDataGridViewTextBoxColumn.DataPropertyName = "s_time"
        Me.StimeDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.StimeDataGridViewTextBoxColumn.Name = "StimeDataGridViewTextBoxColumn"
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        '
        'Dr
        '
        Me.Dr.HeaderText = "Dr"
        Me.Dr.Name = "Dr"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'PatientDataGridViewTextBoxColumn
        '
        Me.PatientDataGridViewTextBoxColumn.DataPropertyName = "patient"
        Me.PatientDataGridViewTextBoxColumn.HeaderText = "patient"
        Me.PatientDataGridViewTextBoxColumn.Name = "PatientDataGridViewTextBoxColumn"
        '
        'DoctorDataGridViewTextBoxColumn
        '
        Me.DoctorDataGridViewTextBoxColumn.DataPropertyName = "doctor"
        Me.DoctorDataGridViewTextBoxColumn.HeaderText = "doctor"
        Me.DoctorDataGridViewTextBoxColumn.Name = "DoctorDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'TimeslotDataGridViewTextBoxColumn
        '
        Me.TimeslotDataGridViewTextBoxColumn.DataPropertyName = "time_slot"
        Me.TimeslotDataGridViewTextBoxColumn.HeaderText = "time_slot"
        Me.TimeslotDataGridViewTextBoxColumn.Name = "TimeslotDataGridViewTextBoxColumn"
        '
        'EtimeDataGridViewTextBoxColumn
        '
        Me.EtimeDataGridViewTextBoxColumn.DataPropertyName = "e_time"
        Me.EtimeDataGridViewTextBoxColumn.HeaderText = "e_time"
        Me.EtimeDataGridViewTextBoxColumn.Name = "EtimeDataGridViewTextBoxColumn"
        '
        'AdddateDataGridViewTextBoxColumn
        '
        Me.AdddateDataGridViewTextBoxColumn.DataPropertyName = "add_date"
        Me.AdddateDataGridViewTextBoxColumn.HeaderText = "add_date"
        Me.AdddateDataGridViewTextBoxColumn.Name = "AdddateDataGridViewTextBoxColumn"
        '
        'RegistrationtimeDataGridViewTextBoxColumn
        '
        Me.RegistrationtimeDataGridViewTextBoxColumn.DataPropertyName = "registration_time"
        Me.RegistrationtimeDataGridViewTextBoxColumn.HeaderText = "registration_time"
        Me.RegistrationtimeDataGridViewTextBoxColumn.Name = "RegistrationtimeDataGridViewTextBoxColumn"
        '
        'StimekeyDataGridViewTextBoxColumn
        '
        Me.StimekeyDataGridViewTextBoxColumn.DataPropertyName = "s_time_key"
        Me.StimekeyDataGridViewTextBoxColumn.HeaderText = "s_time_key"
        Me.StimekeyDataGridViewTextBoxColumn.Name = "StimekeyDataGridViewTextBoxColumn"
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "user"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "user"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        '
        'RequestDataGridViewTextBoxColumn
        '
        Me.RequestDataGridViewTextBoxColumn.DataPropertyName = "request"
        Me.RequestDataGridViewTextBoxColumn.HeaderText = "request"
        Me.RequestDataGridViewTextBoxColumn.Name = "RequestDataGridViewTextBoxColumn"
        '
        'AppointmentBindingSource1
        '
        Me.AppointmentBindingSource1.DataMember = "appointment"
        Me.AppointmentBindingSource1.DataSource = Me.Tootalde_dbtDataSet
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "doctor"
        Me.DoctorBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AutoGenerateColumns = False
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource1
        Me.DoctorDataGridView.Location = New System.Drawing.Point(28, 300)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DoctorDataGridView.TabIndex = 57339
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn2.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "department"
        Me.DataGridViewTextBoxColumn7.HeaderText = "department"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "profile"
        Me.DataGridViewTextBoxColumn8.HeaderText = "profile"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "x"
        Me.DataGridViewTextBoxColumn9.HeaderText = "x"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "y"
        Me.DataGridViewTextBoxColumn10.HeaderText = "y"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DoctorBindingSource1
        '
        Me.DoctorBindingSource1.DataMember = "doctor"
        Me.DoctorBindingSource1.DataSource = Me.Tootalde_dbtDataSet
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource1
        Me.PatientDataGridView.Location = New System.Drawing.Point(28, 300)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PatientDataGridView.TabIndex = 57339
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn13.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn15.HeaderText = "email"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn16.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn17.HeaderText = "address"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn18.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "sex"
        Me.DataGridViewTextBoxColumn19.HeaderText = "sex"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "birthdate"
        Me.DataGridViewTextBoxColumn20.HeaderText = "birthdate"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn21.HeaderText = "age"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "bloodgroup"
        Me.DataGridViewTextBoxColumn22.HeaderText = "bloodgroup"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "patient_id"
        Me.DataGridViewTextBoxColumn24.HeaderText = "patient_id"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "add_date"
        Me.DataGridViewTextBoxColumn25.HeaderText = "add_date"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "registration_time"
        Me.DataGridViewTextBoxColumn26.HeaderText = "registration_time"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "how_added"
        Me.DataGridViewTextBoxColumn27.HeaderText = "how_added"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'PatientBindingSource1
        '
        Me.PatientBindingSource1.DataMember = "patient"
        Me.PatientBindingSource1.DataSource = Me.Tootalde_dbtDataSet
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.InitialImage = CType(resources.GetObject("PictureBox7.InitialImage"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(436, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 57340
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.WaitOnLoad = True
        '
        'homeLago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.DataGridViewLago)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.Controls.Add(Me.AppointmentDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(780, 0)
        Me.Name = "homeLago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "homeLago"
        CType(Me.DataGridViewLago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewLago As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As tootalde_dbtDataSetTableAdapters.appointmentTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentDataGridView As DataGridView
    Friend WithEvents AppointmentBindingSource1 As BindingSource
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As tootalde_dbtDataSetTableAdapters.doctorTableAdapter
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As tootalde_dbtDataSetTableAdapters.patientTableAdapter
    Friend WithEvents PatientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DoctorBindingSource1 As BindingSource
    Friend WithEvents PatientBindingSource1 As BindingSource
    Friend WithEvents StimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Dr As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoctorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeslotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StimekeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox7 As PictureBox
End Class
