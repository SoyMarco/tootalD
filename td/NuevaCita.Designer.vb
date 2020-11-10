<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaCita))
        Me.NuevoLugar = New System.Windows.Forms.Label()
        Me.notificacion = New System.Windows.Forms.Label()
        Me.IdAppointment = New System.Windows.Forms.Label()
        Me.lugar = New System.Windows.Forms.ComboBox()
        Me.NuevoDr = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnConfimado = New System.Windows.Forms.Button()
        Me.BtnPendiente = New System.Windows.Forms.Button()
        Me.Estatus = New System.Windows.Forms.Label()
        Me.Doctor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PacienteID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.NuevaHora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDia = New System.Windows.Forms.DateTimePicker()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New td.tootalde_dbtDataSetTableAdapters.appointmentTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.DoctorTableAdapter = New td.tootalde_dbtDataSetTableAdapters.doctorTableAdapter()
        Me.PatientTableAdapter = New td.tootalde_dbtDataSetTableAdapters.patientTableAdapter()
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
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.MsgPacient = New System.Windows.Forms.Label()
        Me.Tootalde_dbtDataSet1 = New td.tootalde_dbtDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New td.tootalde_dbtDataSetTableAdapters.usersTableAdapter()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Users_groupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Users_groupsTableAdapter = New td.tootalde_dbtDataSetTableAdapters.users_groupsTableAdapter()
        Me.Users_groupsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users_groupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users_groupsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuevoLugar
        '
        Me.NuevoLugar.AutoSize = True
        Me.NuevoLugar.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoLugar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoLugar.Location = New System.Drawing.Point(524, 259)
        Me.NuevoLugar.Name = "NuevoLugar"
        Me.NuevoLugar.Size = New System.Drawing.Size(30, 32)
        Me.NuevoLugar.TabIndex = 57379
        Me.NuevoLugar.Text = "0"
        Me.NuevoLugar.Visible = False
        '
        'notificacion
        '
        Me.notificacion.AutoSize = True
        Me.notificacion.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.notificacion.Location = New System.Drawing.Point(139, 317)
        Me.notificacion.Name = "notificacion"
        Me.notificacion.Size = New System.Drawing.Size(271, 32)
        Me.notificacion.TabIndex = 57377
        Me.notificacion.Text = "Guardar todo como:"
        '
        'IdAppointment
        '
        Me.IdAppointment.AutoSize = True
        Me.IdAppointment.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdAppointment.Location = New System.Drawing.Point(524, 358)
        Me.IdAppointment.Name = "IdAppointment"
        Me.IdAppointment.Size = New System.Drawing.Size(30, 32)
        Me.IdAppointment.TabIndex = 57376
        Me.IdAppointment.Text = "0"
        Me.IdAppointment.Visible = False
        '
        'lugar
        '
        Me.lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lugar.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lugar.FormattingEnabled = True
        Me.lugar.Items.AddRange(New Object() {"Peñitas", "Lago"})
        Me.lugar.Location = New System.Drawing.Point(145, 259)
        Me.lugar.Name = "lugar"
        Me.lugar.Size = New System.Drawing.Size(373, 31)
        Me.lugar.TabIndex = 5
        '
        'NuevoDr
        '
        Me.NuevoDr.AutoSize = True
        Me.NuevoDr.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoDr.Location = New System.Drawing.Point(524, 106)
        Me.NuevoDr.Name = "NuevoDr"
        Me.NuevoDr.Size = New System.Drawing.Size(30, 32)
        Me.NuevoDr.TabIndex = 57374
        Me.NuevoDr.Text = "0"
        Me.NuevoDr.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 57372
        Me.Label5.Text = "Lugar"
        '
        'BtnConfimado
        '
        Me.BtnConfimado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnConfimado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfimado.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfimado.ForeColor = System.Drawing.Color.White
        Me.BtnConfimado.Location = New System.Drawing.Point(318, 358)
        Me.BtnConfimado.Name = "BtnConfimado"
        Me.BtnConfimado.Size = New System.Drawing.Size(200, 56)
        Me.BtnConfimado.TabIndex = 57370
        Me.BtnConfimado.Text = "Confirmado"
        Me.BtnConfimado.UseVisualStyleBackColor = False
        '
        'BtnPendiente
        '
        Me.BtnPendiente.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPendiente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPendiente.ForeColor = System.Drawing.Color.White
        Me.BtnPendiente.Location = New System.Drawing.Point(23, 358)
        Me.BtnPendiente.Name = "BtnPendiente"
        Me.BtnPendiente.Size = New System.Drawing.Size(200, 56)
        Me.BtnPendiente.TabIndex = 57367
        Me.BtnPendiente.Text = "Pendiente"
        Me.BtnPendiente.UseVisualStyleBackColor = False
        '
        'Estatus
        '
        Me.Estatus.AutoSize = True
        Me.Estatus.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Estatus.Location = New System.Drawing.Point(193, 386)
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Size = New System.Drawing.Size(0, 32)
        Me.Estatus.TabIndex = 57365
        '
        'Doctor
        '
        Me.Doctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Doctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Doctor.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor.FormattingEnabled = True
        Me.Doctor.Items.AddRange(New Object() {"J. Oscar Quevedo Mendoza", "Yeimi Yuriet Muñoz Angeles", "Ariadna Campos Hurtado", "Aime Abigail  Vasquez Perez"})
        Me.Doctor.Location = New System.Drawing.Point(145, 110)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(373, 31)
        Me.Doctor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 57358
        Me.Label1.Text = "Dr(a)"
        '
        'PacienteID
        '
        Me.PacienteID.AutoSize = True
        Me.PacienteID.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PacienteID.Location = New System.Drawing.Point(524, 21)
        Me.PacienteID.Name = "PacienteID"
        Me.PacienteID.Size = New System.Drawing.Size(30, 32)
        Me.PacienteID.TabIndex = 57357
        Me.PacienteID.Text = "0"
        Me.PacienteID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 32)
        Me.Label4.TabIndex = 57356
        Me.Label4.Text = "Paciente"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.PatientBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(373, 31)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "name"
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
        'NuevaHora
        '
        Me.NuevaHora.AutoSize = True
        Me.NuevaHora.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevaHora.Location = New System.Drawing.Point(524, 202)
        Me.NuevaHora.Name = "NuevaHora"
        Me.NuevaHora.Size = New System.Drawing.Size(30, 32)
        Me.NuevaHora.TabIndex = 57386
        Me.NuevaHora.Text = "0"
        Me.NuevaHora.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 32)
        Me.Label3.TabIndex = 57385
        Me.Label3.Text = "Día"
        '
        'Hora
        '
        Me.Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Hora.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.FormattingEnabled = True
        Me.Hora.Items.AddRange(New Object() {"10:00 A. M.", "10:30 A. M.", "11:00 A. M.", "11:30 A. M.", "12:00 P. M.", "12:30 P. M.", "01:00 P. M.", "01:30 P. M.", "02:00 P. M.", "02:30 P. M.", "03:00 P. M.", "03:30 P. M.", "04:00 P. M.", "04:30 P. M.", "05:00 P. M.", "05:30 P. M.", "06:00 P. M.", "06:30 P. M.", "07:00 P. M.", "07:30 P. M.", "08:00 P. M."})
        Me.Hora.Location = New System.Drawing.Point(145, 206)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(373, 31)
        Me.Hora.TabIndex = 4
        '
        'DateTimePickerDia
        '
        Me.DateTimePickerDia.Location = New System.Drawing.Point(145, 163)
        Me.DateTimePickerDia.Name = "DateTimePickerDia"
        Me.DateTimePickerDia.Size = New System.Drawing.Size(373, 20)
        Me.DateTimePickerDia.TabIndex = 3
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fecha.Location = New System.Drawing.Point(524, 154)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(30, 32)
        Me.fecha.TabIndex = 57382
        Me.fecha.Text = "0"
        Me.fecha.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 32)
        Me.Label2.TabIndex = 57381
        Me.Label2.Text = "Hora"
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
        Me.TableAdapterManager.doctorTableAdapter = Me.DoctorTableAdapter
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
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(542, 237)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.AppointmentDataGridView.TabIndex = 57388
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
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "doctor"
        Me.DoctorBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AutoGenerateColumns = False
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource
        Me.DoctorDataGridView.Location = New System.Drawing.Point(542, 237)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DoctorDataGridView.TabIndex = 57388
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
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.Location = New System.Drawing.Point(542, 237)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PatientDataGridView.TabIndex = 57388
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
        'MsgPacient
        '
        Me.MsgPacient.AutoSize = True
        Me.MsgPacient.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgPacient.ForeColor = System.Drawing.Color.White
        Me.MsgPacient.Location = New System.Drawing.Point(148, 55)
        Me.MsgPacient.Name = "MsgPacient"
        Me.MsgPacient.Size = New System.Drawing.Size(134, 32)
        Me.MsgPacient.TabIndex = 57389
        Me.MsgPacient.Text = "Paciente:"
        '
        'Tootalde_dbtDataSet1
        '
        Me.Tootalde_dbtDataSet1.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.AutoGenerateColumns = False
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        Me.UsersDataGridView.DataSource = Me.UsersBindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(542, 237)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.UsersDataGridView.TabIndex = 57389
        Me.UsersDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn42.HeaderText = "id"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "ip_address"
        Me.DataGridViewTextBoxColumn43.HeaderText = "ip_address"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn44.HeaderText = "username"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn45.HeaderText = "password"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "salt"
        Me.DataGridViewTextBoxColumn46.HeaderText = "salt"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn47.HeaderText = "email"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "activation_code"
        Me.DataGridViewTextBoxColumn48.HeaderText = "activation_code"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "forgotten_password_code"
        Me.DataGridViewTextBoxColumn49.HeaderText = "forgotten_password_code"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "forgotten_password_time"
        Me.DataGridViewTextBoxColumn50.HeaderText = "forgotten_password_time"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "remember_code"
        Me.DataGridViewTextBoxColumn51.HeaderText = "remember_code"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "created_on"
        Me.DataGridViewTextBoxColumn52.HeaderText = "created_on"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "last_login"
        Me.DataGridViewTextBoxColumn53.HeaderText = "last_login"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "active"
        Me.DataGridViewTextBoxColumn54.HeaderText = "active"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn55.HeaderText = "first_name"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn56.HeaderText = "last_name"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "company"
        Me.DataGridViewTextBoxColumn57.HeaderText = "company"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn58.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(560, 175)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 57390
        Me.DateTimePicker1.Visible = False
        '
        'Users_groupsBindingSource
        '
        Me.Users_groupsBindingSource.DataMember = "users_groups"
        Me.Users_groupsBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Users_groupsTableAdapter
        '
        Me.Users_groupsTableAdapter.ClearBeforeFill = True
        '
        'Users_groupsDataGridView
        '
        Me.Users_groupsDataGridView.AutoGenerateColumns = False
        Me.Users_groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Users_groupsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61})
        Me.Users_groupsDataGridView.DataSource = Me.Users_groupsBindingSource
        Me.Users_groupsDataGridView.Location = New System.Drawing.Point(542, 237)
        Me.Users_groupsDataGridView.Name = "Users_groupsDataGridView"
        Me.Users_groupsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Users_groupsDataGridView.TabIndex = 57390
        Me.Users_groupsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn59.HeaderText = "id"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "user_id"
        Me.DataGridViewTextBoxColumn60.HeaderText = "user_id"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "group_id"
        Me.DataGridViewTextBoxColumn61.HeaderText = "group_id"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'NuevaCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 477)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.IdAppointment)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.Controls.Add(Me.NuevaHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.DateTimePickerDia)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NuevoLugar)
        Me.Controls.Add(Me.notificacion)
        Me.Controls.Add(Me.lugar)
        Me.Controls.Add(Me.NuevoDr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnConfimado)
        Me.Controls.Add(Me.BtnPendiente)
        Me.Controls.Add(Me.Estatus)
        Me.Controls.Add(Me.Doctor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PacienteID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MsgPacient)
        Me.Controls.Add(Me.Users_groupsDataGridView)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Controls.Add(Me.AppointmentDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevaCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevaCita"
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users_groupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users_groupsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NuevoLugar As Label
    Friend WithEvents notificacion As Label
    Friend WithEvents IdAppointment As Label
    Friend WithEvents lugar As ComboBox
    Friend WithEvents NuevoDr As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnConfimado As Button
    Friend WithEvents BtnPendiente As Button
    Friend WithEvents Estatus As Label
    Friend WithEvents Doctor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PacienteID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NuevaHora As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Hora As ComboBox
    Friend WithEvents DateTimePickerDia As DateTimePicker
    Friend WithEvents fecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As tootalde_dbtDataSetTableAdapters.appointmentTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorTableAdapter As tootalde_dbtDataSetTableAdapters.doctorTableAdapter
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
    Friend WithEvents PatientTableAdapter As tootalde_dbtDataSetTableAdapters.patientTableAdapter
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents PatientBindingSource As BindingSource
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
    Friend WithEvents MsgPacient As Label
    Friend WithEvents Tootalde_dbtDataSet1 As tootalde_dbtDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As tootalde_dbtDataSetTableAdapters.usersTableAdapter
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Users_groupsBindingSource As BindingSource
    Friend WithEvents Users_groupsTableAdapter As tootalde_dbtDataSetTableAdapters.users_groupsTableAdapter
    Friend WithEvents Users_groupsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
End Class
