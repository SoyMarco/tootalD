<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.NuevaHora = New System.Windows.Forms.Label()
        Me.DateTimePickerDia = New System.Windows.Forms.DateTimePicker()
        Me.fecha = New System.Windows.Forms.Label()
        Me.NuevoLugar = New System.Windows.Forms.Label()
        Me.lugar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Doctor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PacienteID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tratamiento = New System.Windows.Forms.ComboBox()
        Me.PaymentcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tootalde_dbtDataSet = New td.tootalde_dbtDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotParcial = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.TextBox()
        Me.efectivo = New System.Windows.Forms.TextBox()
        Me.tarjeta = New System.Windows.Forms.TextBox()
        Me.Payment_categoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Paciente_servicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente_servicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Paciente_pagoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_efectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TotPagos = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NomPaciente = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NuevoDr = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.IdCita = New System.Windows.Forms.Label()
        Me.comentarios = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Payment_categoryTableAdapter = New td.tootalde_dbtDataSetTableAdapters.payment_categoryTableAdapter()
        Me.TableAdapterManager = New td.tootalde_dbtDataSetTableAdapters.TableAdapterManager()
        Me.Paciente_servicioTableAdapter = New td.tootalde_dbtDataSetTableAdapters.paciente_servicioTableAdapter()
        Me.Paciente_pagoTableAdapter = New td.tootalde_dbtDataSetTableAdapters.paciente_pagoTableAdapter()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorTableAdapter = New td.tootalde_dbtDataSetTableAdapters.doctorTableAdapter()
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TratamientoId = New System.Windows.Forms.Label()
        Me.InfoGuarServ = New System.Windows.Forms.Label()
        Me.TotServicios = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.resta = New System.Windows.Forms.Label()
        Me.IdServ = New System.Windows.Forms.Label()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New td.tootalde_dbtDataSetTableAdapters.patientTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NameServ = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.PaymentcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payment_categoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payment_categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_servicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_servicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_pagoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paciente_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuevaHora
        '
        Me.NuevaHora.AutoSize = True
        Me.NuevaHora.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevaHora.Location = New System.Drawing.Point(914, 39)
        Me.NuevaHora.Name = "NuevaHora"
        Me.NuevaHora.Size = New System.Drawing.Size(30, 32)
        Me.NuevaHora.TabIndex = 57398
        Me.NuevaHora.Text = "0"
        '
        'DateTimePickerDia
        '
        Me.DateTimePickerDia.Location = New System.Drawing.Point(790, 13)
        Me.DateTimePickerDia.Name = "DateTimePickerDia"
        Me.DateTimePickerDia.Size = New System.Drawing.Size(377, 20)
        Me.DateTimePickerDia.TabIndex = 57388
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fecha.Location = New System.Drawing.Point(914, 1)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(30, 32)
        Me.fecha.TabIndex = 57396
        Me.fecha.Text = "0"
        '
        'NuevoLugar
        '
        Me.NuevoLugar.AutoSize = True
        Me.NuevoLugar.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoLugar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoLugar.Location = New System.Drawing.Point(676, 86)
        Me.NuevoLugar.Name = "NuevoLugar"
        Me.NuevoLugar.Size = New System.Drawing.Size(30, 32)
        Me.NuevoLugar.TabIndex = 57394
        Me.NuevoLugar.Text = "0"
        '
        'lugar
        '
        Me.lugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lugar.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lugar.FormattingEnabled = True
        Me.lugar.Items.AddRange(New Object() {"Peñitas", "Lago"})
        Me.lugar.Location = New System.Drawing.Point(193, 87)
        Me.lugar.Name = "lugar"
        Me.lugar.Size = New System.Drawing.Size(469, 31)
        Me.lugar.TabIndex = 57389
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 57393
        Me.Label5.Text = "Lugar"
        '
        'Doctor
        '
        Me.Doctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Doctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Doctor.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor.FormattingEnabled = True
        Me.Doctor.Items.AddRange(New Object() {"J. Oscar Quevedo Mendoza", "Yeimi Yuriet Muñoz Angeles", "Ariadna Campos Hurtado", "Aime Abigail  Vasquez Perez"})
        Me.Doctor.Location = New System.Drawing.Point(193, 43)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(469, 31)
        Me.Doctor.TabIndex = 57387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 57392
        Me.Label1.Text = "Dr(a)"
        '
        'PacienteID
        '
        Me.PacienteID.AutoSize = True
        Me.PacienteID.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PacienteID.Location = New System.Drawing.Point(676, 7)
        Me.PacienteID.Name = "PacienteID"
        Me.PacienteID.Size = New System.Drawing.Size(30, 32)
        Me.PacienteID.TabIndex = 57391
        Me.PacienteID.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 32)
        Me.Label4.TabIndex = 57390
        Me.Label4.Text = "Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 32)
        Me.Label2.TabIndex = 57399
        Me.Label2.Text = "Total Parcial"
        '
        'Tratamiento
        '
        Me.Tratamiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Tratamiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tratamiento.DataSource = Me.PaymentcategoryBindingSource
        Me.Tratamiento.DisplayMember = "category"
        Me.Tratamiento.Font = New System.Drawing.Font("Helvetica LT Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tratamiento.FormattingEnabled = True
        Me.Tratamiento.Location = New System.Drawing.Point(193, 134)
        Me.Tratamiento.Name = "Tratamiento"
        Me.Tratamiento.Size = New System.Drawing.Size(469, 31)
        Me.Tratamiento.TabIndex = 57400
        Me.Tratamiento.ValueMember = "category"
        '
        'PaymentcategoryBindingSource
        '
        Me.PaymentcategoryBindingSource.DataMember = "payment_category"
        Me.PaymentcategoryBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Tootalde_dbtDataSet
        '
        Me.Tootalde_dbtDataSet.DataSetName = "tootalde_dbtDataSet"
        Me.Tootalde_dbtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 32)
        Me.Label3.TabIndex = 57401
        Me.Label3.Text = "Tratamiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 32)
        Me.Label6.TabIndex = 57402
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 32)
        Me.Label7.TabIndex = 57403
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(676, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 32)
        Me.Label8.TabIndex = 57404
        Me.Label8.Text = "Efectivo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(676, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 32)
        Me.Label9.TabIndex = 57405
        Me.Label9.Text = "Tarjeta"
        '
        'TotParcial
        '
        Me.TotParcial.AutoSize = True
        Me.TotParcial.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotParcial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotParcial.Location = New System.Drawing.Point(187, 179)
        Me.TotParcial.Name = "TotParcial"
        Me.TotParcial.Size = New System.Drawing.Size(30, 32)
        Me.TotParcial.TabIndex = 57406
        Me.TotParcial.Text = "0"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Helvetica LT Std", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Red
        Me.Total.Location = New System.Drawing.Point(185, 262)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(154, 44)
        Me.Total.TabIndex = 57407
        Me.Total.Text = "ERROR"
        '
        'descuento
        '
        Me.descuento.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.descuento.Location = New System.Drawing.Point(193, 219)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(469, 40)
        Me.descuento.TabIndex = 57408
        '
        'efectivo
        '
        Me.efectivo.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.efectivo.Location = New System.Drawing.Point(801, 94)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(351, 40)
        Me.efectivo.TabIndex = 57409
        '
        'tarjeta
        '
        Me.tarjeta.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tarjeta.Location = New System.Drawing.Point(801, 179)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(351, 40)
        Me.tarjeta.TabIndex = 57410
        '
        'Payment_categoryDataGridView
        '
        Me.Payment_categoryDataGridView.AutoGenerateColumns = False
        Me.Payment_categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payment_categoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Payment_categoryDataGridView.DataSource = Me.Payment_categoryBindingSource
        Me.Payment_categoryDataGridView.Location = New System.Drawing.Point(-1, 405)
        Me.Payment_categoryDataGridView.Name = "Payment_categoryDataGridView"
        Me.Payment_categoryDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Payment_categoryDataGridView.TabIndex = 57411
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn2.HeaderText = "category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "c_price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "c_price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "d_commission"
        Me.DataGridViewTextBoxColumn6.HeaderText = "d_commission"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "h_commission"
        Me.DataGridViewTextBoxColumn7.HeaderText = "h_commission"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Payment_categoryBindingSource
        '
        Me.Payment_categoryBindingSource.DataMember = "payment_category"
        Me.Payment_categoryBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Paciente_servicioDataGridView
        '
        Me.Paciente_servicioDataGridView.AutoGenerateColumns = False
        Me.Paciente_servicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paciente_servicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Paciente_servicioDataGridView.DataSource = Me.Paciente_servicioBindingSource
        Me.Paciente_servicioDataGridView.Location = New System.Drawing.Point(115, 405)
        Me.Paciente_servicioDataGridView.Name = "Paciente_servicioDataGridView"
        Me.Paciente_servicioDataGridView.ReadOnly = True
        Me.Paciente_servicioDataGridView.Size = New System.Drawing.Size(548, 220)
        Me.Paciente_servicioDataGridView.TabIndex = 57411
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "tratamiento"
        Me.DataGridViewTextBoxColumn9.HeaderText = "tratamiento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "descuento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "descuento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn12.HeaderText = "total"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "paciente"
        Me.DataGridViewTextBoxColumn13.HeaderText = "paciente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn14.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "cita"
        Me.DataGridViewTextBoxColumn15.HeaderText = "cita"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn17.HeaderText = "estatus"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fecha_cambio"
        Me.DataGridViewTextBoxColumn18.HeaderText = "fecha_cambio"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "usuario_cambio"
        Me.DataGridViewTextBoxColumn19.HeaderText = "usuario_cambio"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'Paciente_servicioBindingSource
        '
        Me.Paciente_servicioBindingSource.DataMember = "paciente_servicio"
        Me.Paciente_servicioBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Paciente_pagoDataGridView
        '
        Me.Paciente_pagoDataGridView.AutoGenerateColumns = False
        Me.Paciente_pagoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paciente_pagoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.monto_efectivo, Me.monto_tarjeta, Me.monto_total, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.Paciente_pagoDataGridView.DataSource = Me.Paciente_pagoBindingSource
        Me.Paciente_pagoDataGridView.Location = New System.Drawing.Point(682, 405)
        Me.Paciente_pagoDataGridView.Name = "Paciente_pagoDataGridView"
        Me.Paciente_pagoDataGridView.ReadOnly = True
        Me.Paciente_pagoDataGridView.Size = New System.Drawing.Size(470, 220)
        Me.Paciente_pagoDataGridView.TabIndex = 57411
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn20.HeaderText = "id"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'monto_efectivo
        '
        Me.monto_efectivo.DataPropertyName = "monto_efectivo"
        Me.monto_efectivo.HeaderText = "monto_efectivo"
        Me.monto_efectivo.Name = "monto_efectivo"
        Me.monto_efectivo.ReadOnly = True
        '
        'monto_tarjeta
        '
        Me.monto_tarjeta.DataPropertyName = "monto_tarjeta"
        Me.monto_tarjeta.HeaderText = "monto_tarjeta"
        Me.monto_tarjeta.Name = "monto_tarjeta"
        Me.monto_tarjeta.ReadOnly = True
        '
        'monto_total
        '
        Me.monto_total.DataPropertyName = "monto_total"
        Me.monto_total.HeaderText = "monto_total"
        Me.monto_total.Name = "monto_total"
        Me.monto_total.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "d_comision"
        Me.DataGridViewTextBoxColumn22.HeaderText = "d_comision"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "paciente"
        Me.DataGridViewTextBoxColumn23.HeaderText = "paciente"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "doctor"
        Me.DataGridViewTextBoxColumn24.HeaderText = "doctor"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "cita"
        Me.DataGridViewTextBoxColumn25.HeaderText = "cita"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "notas"
        Me.DataGridViewTextBoxColumn26.HeaderText = "notas"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn28.HeaderText = "usuario"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn29.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn30.HeaderText = "estatus"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "fecha_cambio"
        Me.DataGridViewTextBoxColumn31.HeaderText = "fecha_cambio"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "usuario_cambio"
        Me.DataGridViewTextBoxColumn32.HeaderText = "usuario_cambio"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'Paciente_pagoBindingSource
        '
        Me.Paciente_pagoBindingSource.DataMember = "paciente_pago"
        Me.Paciente_pagoBindingSource.DataSource = Me.Tootalde_dbtDataSet
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(828, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 34)
        Me.Label12.TabIndex = 57412
        Me.Label12.Text = "NUEVO PAGO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(828, 369)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 34)
        Me.Label13.TabIndex = 57413
        Me.Label13.Text = "PAGOS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(331, 369)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(179, 34)
        Me.Label14.TabIndex = 57414
        Me.Label14.Text = "SERVICIOS"
        '
        'TotPagos
        '
        Me.TotPagos.AutoSize = True
        Me.TotPagos.BackColor = System.Drawing.Color.White
        Me.TotPagos.Font = New System.Drawing.Font("Helvetica LT Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotPagos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotPagos.Location = New System.Drawing.Point(803, 628)
        Me.TotPagos.Name = "TotPagos"
        Me.TotPagos.Size = New System.Drawing.Size(37, 42)
        Me.TotPagos.TabIndex = 57415
        Me.TotPagos.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(241, 630)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 34)
        Me.Label16.TabIndex = 57416
        Me.Label16.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(676, 628)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 34)
        Me.Label17.TabIndex = 57417
        Me.Label17.Text = "TOTAL"
        '
        'NomPaciente
        '
        Me.NomPaciente.AutoSize = True
        Me.NomPaciente.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NomPaciente.Location = New System.Drawing.Point(187, 4)
        Me.NomPaciente.Name = "NomPaciente"
        Me.NomPaciente.Size = New System.Drawing.Size(125, 32)
        Me.NomPaciente.TabIndex = 57419
        Me.NomPaciente.Text = "Paciente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(801, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(280, 50)
        Me.Button1.TabIndex = 57420
        Me.Button1.Text = "Agregar Pago"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(271, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 50)
        Me.Button2.TabIndex = 57421
        Me.Button2.Text = "Agregar Servicio"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NuevoDr
        '
        Me.NuevoDr.AutoSize = True
        Me.NuevoDr.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NuevoDr.Location = New System.Drawing.Point(676, 43)
        Me.NuevoDr.Name = "NuevoDr"
        Me.NuevoDr.Size = New System.Drawing.Size(30, 32)
        Me.NuevoDr.TabIndex = 57422
        Me.NuevoDr.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(667, -7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 700)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57423
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'IdCita
        '
        Me.IdCita.AutoSize = True
        Me.IdCita.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdCita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdCita.Location = New System.Drawing.Point(8, 304)
        Me.IdCita.Name = "IdCita"
        Me.IdCita.Size = New System.Drawing.Size(30, 32)
        Me.IdCita.TabIndex = 57424
        Me.IdCita.Text = "0"
        '
        'comentarios
        '
        Me.comentarios.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentarios.Location = New System.Drawing.Point(824, 245)
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(328, 33)
        Me.comentarios.TabIndex = 57426
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(676, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 25)
        Me.Label15.TabIndex = 57425
        Me.Label15.Text = "Comentarios"
        '
        'Payment_categoryTableAdapter
        '
        Me.Payment_categoryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.payment_categoryTableAdapter = Me.Payment_categoryTableAdapter
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
        'Paciente_servicioTableAdapter
        '
        Me.Paciente_servicioTableAdapter.ClearBeforeFill = True
        '
        'Paciente_pagoTableAdapter
        '
        Me.Paciente_pagoTableAdapter.ClearBeforeFill = True
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
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource
        Me.DoctorDataGridView.Location = New System.Drawing.Point(-1, 405)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DoctorDataGridView.TabIndex = 57426
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn33.HeaderText = "id"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "img_url"
        Me.DataGridViewTextBoxColumn34.HeaderText = "img_url"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn35.HeaderText = "name"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn36.HeaderText = "email"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn37.HeaderText = "address"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn38.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "department"
        Me.DataGridViewTextBoxColumn39.HeaderText = "department"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "profile"
        Me.DataGridViewTextBoxColumn40.HeaderText = "profile"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "x"
        Me.DataGridViewTextBoxColumn41.HeaderText = "x"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "y"
        Me.DataGridViewTextBoxColumn42.HeaderText = "y"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "ion_user_id"
        Me.DataGridViewTextBoxColumn43.HeaderText = "ion_user_id"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'TratamientoId
        '
        Me.TratamientoId.AutoSize = True
        Me.TratamientoId.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TratamientoId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TratamientoId.Location = New System.Drawing.Point(676, 137)
        Me.TratamientoId.Name = "TratamientoId"
        Me.TratamientoId.Size = New System.Drawing.Size(30, 32)
        Me.TratamientoId.TabIndex = 57427
        Me.TratamientoId.Text = "0"
        '
        'InfoGuarServ
        '
        Me.InfoGuarServ.AutoSize = True
        Me.InfoGuarServ.Font = New System.Drawing.Font("Helvetica LT Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGuarServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InfoGuarServ.Location = New System.Drawing.Point(-2, 369)
        Me.InfoGuarServ.Name = "InfoGuarServ"
        Me.InfoGuarServ.Size = New System.Drawing.Size(60, 38)
        Me.InfoGuarServ.TabIndex = 57428
        Me.InfoGuarServ.Text = "Ok"
        '
        'TotServicios
        '
        Me.TotServicios.AutoSize = True
        Me.TotServicios.BackColor = System.Drawing.Color.White
        Me.TotServicios.Font = New System.Drawing.Font("Helvetica LT Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotServicios.Location = New System.Drawing.Point(359, 626)
        Me.TotServicios.Name = "TotServicios"
        Me.TotServicios.Size = New System.Drawing.Size(37, 42)
        Me.TotServicios.TabIndex = 57429
        Me.TotServicios.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Helvetica LT Std Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(675, 670)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 34)
        Me.Label10.TabIndex = 57430
        Me.Label10.Text = "RESTA"
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.BackColor = System.Drawing.Color.White
        Me.resta.Font = New System.Drawing.Font("Helvetica LT Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resta.Location = New System.Drawing.Point(803, 663)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(37, 42)
        Me.resta.TabIndex = 57431
        Me.resta.Text = "$"
        '
        'IdServ
        '
        Me.IdServ.AutoSize = True
        Me.IdServ.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdServ.Location = New System.Drawing.Point(-1, 636)
        Me.IdServ.Name = "IdServ"
        Me.IdServ.Size = New System.Drawing.Size(30, 32)
        Me.IdServ.TabIndex = 57432
        Me.IdServ.Text = "0"
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(-1, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 31)
        Me.Button4.TabIndex = 57434
        Me.Button4.Text = "Cancelados"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(-1, 480)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 28)
        Me.Button5.TabIndex = 57435
        Me.Button5.Text = "Todos"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(-1, 506)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 29)
        Me.Button6.TabIndex = 57436
        Me.Button6.Text = "Activos"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 423)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 25)
        Me.Label11.TabIndex = 57437
        Me.Label11.Text = "Mostar"
        '
        'NameServ
        '
        Me.NameServ.AutoSize = True
        Me.NameServ.Font = New System.Drawing.Font("Helvetica LT Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameServ.Location = New System.Drawing.Point(-1, 671)
        Me.NameServ.Name = "NameServ"
        Me.NameServ.Size = New System.Drawing.Size(30, 32)
        Me.NameServ.TabIndex = 57438
        Me.NameServ.Text = "0"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(1158, 506)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 29)
        Me.Button3.TabIndex = 57441
        Me.Button3.Text = "Activos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(1158, 480)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 28)
        Me.Button7.TabIndex = 57440
        Me.Button7.Text = "Todos"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Helvetica LT Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(1158, 449)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 31)
        Me.Button8.TabIndex = 57439
        Me.Button8.Text = "Cancelados"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Helvetica LT Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1175, 423)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 25)
        Me.Label18.TabIndex = 57442
        Me.Label18.Text = "Mostar"
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1272, 743)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NameServ)
        Me.Controls.Add(Me.IdServ)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Paciente_servicioDataGridView)
        Me.Controls.Add(Me.InfoGuarServ)
        Me.Controls.Add(Me.TratamientoId)
        Me.Controls.Add(Me.Payment_categoryDataGridView)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.Controls.Add(Me.NuevaHora)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.comentarios)
        Me.Controls.Add(Me.IdCita)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.NuevoLugar)
        Me.Controls.Add(Me.NuevoDr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PacienteID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NomPaciente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TotPagos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Paciente_pagoDataGridView)
        Me.Controls.Add(Me.tarjeta)
        Me.Controls.Add(Me.efectivo)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.TotParcial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tratamiento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerDia)
        Me.Controls.Add(Me.lugar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Doctor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TotServicios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entrada"
        CType(Me.PaymentcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tootalde_dbtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payment_categoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payment_categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_servicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_servicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_pagoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paciente_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NuevaHora As Label
    Friend WithEvents DateTimePickerDia As DateTimePicker
    Friend WithEvents fecha As Label
    Friend WithEvents NuevoLugar As Label
    Friend WithEvents lugar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Doctor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PacienteID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tratamiento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TotParcial As Label
    Friend WithEvents Total As Label
    Friend WithEvents descuento As TextBox
    Friend WithEvents efectivo As TextBox
    Friend WithEvents tarjeta As TextBox
    Friend WithEvents Tootalde_dbtDataSet As tootalde_dbtDataSet
    Friend WithEvents Payment_categoryBindingSource As BindingSource
    Friend WithEvents Payment_categoryTableAdapter As tootalde_dbtDataSetTableAdapters.payment_categoryTableAdapter
    Friend WithEvents TableAdapterManager As tootalde_dbtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Payment_categoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Paciente_servicioBindingSource As BindingSource
    Friend WithEvents Paciente_servicioTableAdapter As tootalde_dbtDataSetTableAdapters.paciente_servicioTableAdapter
    Friend WithEvents Paciente_servicioDataGridView As DataGridView
    Friend WithEvents Paciente_pagoBindingSource As BindingSource
    Friend WithEvents Paciente_pagoTableAdapter As tootalde_dbtDataSetTableAdapters.paciente_pagoTableAdapter
    Friend WithEvents Paciente_pagoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TotPagos As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NomPaciente As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NuevoDr As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents IdCita As Label
    Friend WithEvents comentarios As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As tootalde_dbtDataSetTableAdapters.doctorTableAdapter
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentcategoryBindingSource As BindingSource
    Friend WithEvents TratamientoId As Label
    Friend WithEvents InfoGuarServ As Label
    Friend WithEvents TotServicios As Label
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents monto_efectivo As DataGridViewTextBoxColumn
    Friend WithEvents monto_tarjeta As DataGridViewTextBoxColumn
    Friend WithEvents monto_total As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents resta As Label
    Friend WithEvents IdServ As Label
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As tootalde_dbtDataSetTableAdapters.patientTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents NameServ As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label18 As Label
End Class
