<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class citas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(citas))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Paciente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Doctor = New System.Windows.Forms.ComboBox()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.DateTimePickerDia = New System.Windows.Forms.DateTimePicker()
        Me.Hora = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Estatus = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnPendiente = New System.Windows.Forms.Button()
        Me.BtnTratado = New System.Windows.Forms.Button()
        Me.BtnConfimado = New System.Windows.Forms.Button()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NuevoDr = New System.Windows.Forms.Label()
        Me.lugar = New System.Windows.Forms.ComboBox()
        Me.IdAppointment = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NuevaHora = New System.Windows.Forms.Label()
        Me.NuevoLugar = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.IdPaciente = New System.Windows.Forms.Label()
        Me.AppointmentTableAdapter = New td.tootalde_dbtDataSetTableAdapters.appointmentTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.DoctorTableAdapter = New td.tootalde_dbtDataSetTableAdapters.doctorTableAdapter()
        Me.PatientTableAdapter = New td.tootalde_dbtDataSetTableAdapters.patientTableAdapter()
        Me.DoctorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(131, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Paciente"
        '
        'Paciente
        '
        Me.Paciente.AutoSize = True
        Me.Paciente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Paciente.Location = New System.Drawing.Point(253, 9)
        Me.Paciente.Name = "Paciente"
        Me.Paciente.Size = New System.Drawing.Size(134, 32)
        Me.Paciente.TabIndex = 13
        Me.Paciente.Text = "Paciente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(131, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Dr(a)"
        '
        'Doctor
        '
        Me.Doctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Doctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Doctor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AppointmentBindingSource, "doctor", True))
        Me.Doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Doctor.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor.FormattingEnabled = True
        Me.Doctor.Items.AddRange(New Object() {"J. Oscar Quevedo Mendoza", "Yeimi Yuriet Muñoz Angeles", "Ariadna Campos Hurtado", "Aime Abigail  Vasquez Perez"})
        Me.Doctor.Location = New System.Drawing.Point(259, 56)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(373, 31)
        Me.Doctor.TabIndex = 15
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "appointment"
        Me.AppointmentBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Tootalde_dbtDataSet
        '
        Me.Tootalde_dbtDataSet.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(131, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Hora"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fecha.Location = New System.Drawing.Point(638, 106)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(66, 32)
        Me.fecha.TabIndex = 17
        Me.fecha.Text = "Día:"
        Me.fecha.Visible = False
        '
        'DateTimePickerDia
        '
        Me.DateTimePickerDia.Location = New System.Drawing.Point(259, 115)
        Me.DateTimePickerDia.Name = "DateTimePickerDia"
        Me.DateTimePickerDia.Size = New System.Drawing.Size(373, 20)
        Me.DateTimePickerDia.TabIndex = 18
        '
        'Hora
        '
        Me.Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hora.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.FormattingEnabled = True
        Me.Hora.Items.AddRange(New Object() {"10:00 A. M.", "10:30 A. M.", "11:00 A. M.", "11:30 A. M.", "12:00 P. M.", "12:30 P. M.", "01:00 P. M.", "01:30 P. M.", "02:00 P. M.", "02:30 P. M.", "03:00 P. M.", "03:30 P. M.", "04:00 P. M.", "04:30 P. M.", "05:00 P. M.", "05:30 P. M.", "06:00 P. M.", "06:30 P. M.", "07:00 P. M.", "07:30 P. M.", "08:00 P. M."})
        Me.Hora.Location = New System.Drawing.Point(259, 158)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(373, 31)
        Me.Hora.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(137, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Estatus"
        '
        'Estatus
        '
        Me.Estatus.AutoSize = True
        Me.Estatus.BackColor = System.Drawing.Color.White
        Me.Estatus.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Estatus.Location = New System.Drawing.Point(264, 276)
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Size = New System.Drawing.Size(111, 32)
        Me.Estatus.TabIndex = 21
        Me.Estatus.Text = "Estatus"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 382)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(172, 56)
        Me.BtnCancelar.TabIndex = 57341
        Me.BtnCancelar.Text = "Cancelado"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnPendiente
        '
        Me.BtnPendiente.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPendiente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPendiente.ForeColor = System.Drawing.Color.White
        Me.BtnPendiente.Location = New System.Drawing.Point(190, 382)
        Me.BtnPendiente.Name = "BtnPendiente"
        Me.BtnPendiente.Size = New System.Drawing.Size(172, 56)
        Me.BtnPendiente.TabIndex = 57342
        Me.BtnPendiente.Text = "Pendiente"
        Me.BtnPendiente.UseVisualStyleBackColor = False
        '
        'BtnTratado
        '
        Me.BtnTratado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTratado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTratado.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTratado.ForeColor = System.Drawing.Color.White
        Me.BtnTratado.Location = New System.Drawing.Point(546, 382)
        Me.BtnTratado.Name = "BtnTratado"
        Me.BtnTratado.Size = New System.Drawing.Size(172, 56)
        Me.BtnTratado.TabIndex = 57343
        Me.BtnTratado.Text = "Tratado"
        Me.BtnTratado.UseVisualStyleBackColor = False
        '
        'BtnConfimado
        '
        Me.BtnConfimado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnConfimado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfimado.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfimado.ForeColor = System.Drawing.Color.White
        Me.BtnConfimado.Location = New System.Drawing.Point(368, 382)
        Me.BtnConfimado.Name = "BtnConfimado"
        Me.BtnConfimado.Size = New System.Drawing.Size(172, 56)
        Me.BtnConfimado.TabIndex = 57344
        Me.BtnConfimado.Text = "Confirmado"
        Me.BtnConfimado.UseVisualStyleBackColor = False
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(0, 234)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.AppointmentDataGridView.TabIndex = 57344
        Me.AppointmentDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "patient"
        Me.DataGridViewTextBoxColumn2.HeaderText = "patient"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "time_slot"
        Me.DataGridViewTextBoxColumn5.HeaderText = "time_slot"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "s_time"
        Me.DataGridViewTextBoxColumn6.HeaderText = "s_time"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "e_time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "e_time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "remarks"
        Me.DataGridViewTextBoxColumn8.HeaderText = "remarks"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "add_date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "add_date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "registration_time"
        Me.DataGridViewTextBoxColumn10.HeaderText = "registration_time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "s_time_key"
        Me.DataGridViewTextBoxColumn11.HeaderText = "s_time_key"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn12.HeaderText = "status"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "user"
        Me.DataGridViewTextBoxColumn13.HeaderText = "user"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "request"
        Me.DataGridViewTextBoxColumn14.HeaderText = "request"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AutoGenerateColumns = False
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource
        Me.DoctorDataGridView.Location = New System.Drawing.Point(0, 234)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DoctorDataGridView.TabIndex = 57344
        Me.DoctorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn17.HeaderText = "name"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn16.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn18.HeaderText = "email"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn19.HeaderText = "address"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn20.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "department"
        Me.DataGridViewTextBoxColumn21.HeaderText = "department"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "profile"
        Me.DataGridViewTextBoxColumn22.HeaderText = "profile"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "x"
        Me.DataGridViewTextBoxColumn23.HeaderText = "x"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "y"
        Me.DataGridViewTextBoxColumn24.HeaderText = "y"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "doctor"
        Me.DoctorBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.Location = New System.Drawing.Point(0, 236)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PatientDataGridView.TabIndex = 57344
        Me.PatientDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn26.HeaderText = "id"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn28.HeaderText = "name"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn27.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn29.HeaderText = "email"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn30.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn31.HeaderText = "address"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn32.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "sex"
        Me.DataGridViewTextBoxColumn33.HeaderText = "sex"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "birthdate"
        Me.DataGridViewTextBoxColumn34.HeaderText = "birthdate"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn35.HeaderText = "age"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "bloodgroup"
        Me.DataGridViewTextBoxColumn36.HeaderText = "bloodgroup"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "patient_id"
        Me.DataGridViewTextBoxColumn38.HeaderText = "patient_id"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "add_date"
        Me.DataGridViewTextBoxColumn39.HeaderText = "add_date"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "registration_time"
        Me.DataGridViewTextBoxColumn40.HeaderText = "registration_time"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "how_added"
        Me.DataGridViewTextBoxColumn41.HeaderText = "how_added"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(131, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 57345
        Me.Label5.Text = "Lugar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(131, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 32)
        Me.Label3.TabIndex = 57347
        Me.Label3.Text = "Día"
        '
        'NuevoDr
        '
        Me.NuevoDr.AutoSize = True
        Me.NuevoDr.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoDr.Location = New System.Drawing.Point(638, 52)
        Me.NuevoDr.Name = "NuevoDr"
        Me.NuevoDr.Size = New System.Drawing.Size(45, 32)
        Me.NuevoDr.TabIndex = 57350
        Me.NuevoDr.Text = "Dr"
        Me.NuevoDr.Visible = False
        '
        'lugar
        '
        Me.lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lugar.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lugar.FormattingEnabled = True
        Me.lugar.Items.AddRange(New Object() {"Peñitas", "Lago"})
        Me.lugar.Location = New System.Drawing.Point(259, 213)
        Me.lugar.Name = "lugar"
        Me.lugar.Size = New System.Drawing.Size(373, 31)
        Me.lugar.TabIndex = 57351
        '
        'IdAppointment
        '
        Me.IdAppointment.AutoSize = True
        Me.IdAppointment.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdAppointment.Location = New System.Drawing.Point(629, 276)
        Me.IdAppointment.Name = "IdAppointment"
        Me.IdAppointment.Size = New System.Drawing.Size(90, 32)
        Me.IdAppointment.TabIndex = 57352
        Me.IdAppointment.Text = "idCita"
        Me.IdAppointment.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(236, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 32)
        Me.Label7.TabIndex = 57353
        Me.Label7.Text = "Guardar todo como:"
        '
        'NuevaHora
        '
        Me.NuevaHora.AutoSize = True
        Me.NuevaHora.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevaHora.Location = New System.Drawing.Point(638, 154)
        Me.NuevaHora.Name = "NuevaHora"
        Me.NuevaHora.Size = New System.Drawing.Size(75, 32)
        Me.NuevaHora.TabIndex = 57354
        Me.NuevaHora.Text = "Hora"
        Me.NuevaHora.Visible = False
        '
        'NuevoLugar
        '
        Me.NuevoLugar.AutoSize = True
        Me.NuevoLugar.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoLugar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoLugar.Location = New System.Drawing.Point(638, 213)
        Me.NuevoLugar.Name = "NuevoLugar"
        Me.NuevoLugar.Size = New System.Drawing.Size(89, 32)
        Me.NuevoLugar.TabIndex = 57355
        Me.NuevoLugar.Text = "Lugar"
        Me.NuevoLugar.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 308)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57356
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(46, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 32)
        Me.Label8.TabIndex = 57357
        Me.Label8.Text = "Pago"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = CType(resources.GetObject("PictureBox5.InitialImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 57358
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.WaitOnLoad = True
        '
        'IdPaciente
        '
        Me.IdPaciente.AutoSize = True
        Me.IdPaciente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdPaciente.Location = New System.Drawing.Point(619, 9)
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.Size = New System.Drawing.Size(149, 32)
        Me.IdPaciente.TabIndex = 57359
        Me.IdPaciente.Text = "idPaciente"
        Me.IdPaciente.Visible = False
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
        Me.TableAdapterManager.paciente_pagoTableAdapter = Nothing
        Me.TableAdapterManager.paciente_servicioTableAdapter = Nothing
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
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'DoctorBindingSource1
        '
        Me.DoctorBindingSource1.DataMember = "doctor"
        Me.DoctorBindingSource1.DataSource = Me.Tootalde_dbtDataSet
        '
        'citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 450)
        Me.Controls.Add(Me.IdPaciente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.NuevoLugar)
        Me.Controls.Add(Me.NuevaHora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IdAppointment)
        Me.Controls.Add(Me.lugar)
        Me.Controls.Add(Me.NuevoDr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnConfimado)
        Me.Controls.Add(Me.BtnTratado)
        Me.Controls.Add(Me.BtnPendiente)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Estatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.DateTimePickerDia)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Doctor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Paciente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.Controls.Add(Me.AppointmentDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "citas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "citas"
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As tootalde_dbtDataSetTableAdapters.appointmentTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As Label
    Friend WithEvents Paciente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Doctor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fecha As Label
    Friend WithEvents DateTimePickerDia As DateTimePicker
    Friend WithEvents Hora As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Estatus As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnPendiente As Button
    Friend WithEvents BtnTratado As Button
    Friend WithEvents BtnConfimado As Button
    Friend WithEvents AppointmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As tootalde_dbtDataSetTableAdapters.doctorTableAdapter
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As tootalde_dbtDataSetTableAdapters.patientTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents PatientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DoctorBindingSource1 As BindingSource
    Friend WithEvents NuevoDr As Label
    Friend WithEvents lugar As ComboBox
    Friend WithEvents IdAppointment As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NuevaHora As Label
    Friend WithEvents NuevoLugar As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents IdPaciente As Label
End Class
