<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabCertPages = New MetroFramework.Controls.MetroTabControl()
        Me.tabCustomersNew = New MetroFramework.Controls.MetroTabPage()
        Me.btnNewCert = New System.Windows.Forms.Button()
        Me.pnlCerts = New System.Windows.Forms.Panel()
        Me.btnPrintSelectedCerts = New System.Windows.Forms.Button()
        Me.dgrdInstalledMachines = New MetroFramework.Controls.MetroGrid()
        Me.ViewCert = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SerialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Print = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.searchByCode = New MetroFramework.Controls.MetroRadioButton()
        Me.searchByName = New MetroFramework.Controls.MetroRadioButton()
        Me.ScrollBarCustomers = New System.Windows.Forms.VScrollBar()
        Me.btnDeleteCustomer = New MetroFramework.Controls.MetroButton()
        Me.lblInstalledMachines = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New MetroFramework.Controls.MetroButton()
        Me.btnSaveCustomer = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.dgrdCustomers = New MetroFramework.Controls.MetroGrid()
        Me.txtNotes = New MetroFramework.Controls.MetroTextBox()
        Me.txtContacts = New MetroFramework.Controls.MetroTextBox()
        Me.txtFax = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelephone = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabMaintainMachines = New MetroFramework.Controls.MetroTabPage()
        Me.txtInservice = New MetroFramework.Controls.MetroTextBox()
        Me.txtDefaultMinGrad = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.searchByMachineCode = New MetroFramework.Controls.MetroRadioButton()
        Me.searchByMachineName = New MetroFramework.Controls.MetroRadioButton()
        Me.ScrollbarMachines = New System.Windows.Forms.VScrollBar()
        Me.btnDeleteMachine = New MetroFramework.Controls.MetroButton()
        Me.btnAddNewMachine = New MetroFramework.Controls.MetroButton()
        Me.btnSaveMachines = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtMachineSearch = New System.Windows.Forms.TextBox()
        Me.dgrdMachines = New MetroFramework.Controls.MetroGrid()
        Me.txtDefaultCapacity = New MetroFramework.Controls.MetroTextBox()
        Me.txtElectronicMechanical = New MetroFramework.Controls.MetroTextBox()
        Me.txtCertType = New MetroFramework.Controls.MetroTextBox()
        Me.txtManufacturer = New MetroFramework.Controls.MetroTextBox()
        Me.txtModelDescription = New MetroFramework.Controls.MetroTextBox()
        Me.txtModelId = New MetroFramework.Controls.MetroTextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnSettings = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.tabCertPages.SuspendLayout()
        Me.tabCustomersNew.SuspendLayout()
        Me.pnlCerts.SuspendLayout()
        CType(Me.dgrdInstalledMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMaintainMachines.SuspendLayout()
        CType(Me.dgrdMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCertPages
        '
        Me.tabCertPages.Controls.Add(Me.tabCustomersNew)
        Me.tabCertPages.Controls.Add(Me.tabMaintainMachines)
        Me.tabCertPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCertPages.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tabCertPages.Location = New System.Drawing.Point(20, 60)
        Me.tabCertPages.Name = "tabCertPages"
        Me.tabCertPages.SelectedIndex = 0
        Me.tabCertPages.Size = New System.Drawing.Size(1417, 851)
        Me.tabCertPages.TabIndex = 0
        Me.tabCertPages.UseSelectable = True
        '
        'tabCustomersNew
        '
        Me.tabCustomersNew.Controls.Add(Me.btnNewCert)
        Me.tabCustomersNew.Controls.Add(Me.pnlCerts)
        Me.tabCustomersNew.Controls.Add(Me.searchByCode)
        Me.tabCustomersNew.Controls.Add(Me.searchByName)
        Me.tabCustomersNew.Controls.Add(Me.ScrollBarCustomers)
        Me.tabCustomersNew.Controls.Add(Me.btnDeleteCustomer)
        Me.tabCustomersNew.Controls.Add(Me.lblInstalledMachines)
        Me.tabCustomersNew.Controls.Add(Me.btnAddCustomer)
        Me.tabCustomersNew.Controls.Add(Me.btnSaveCustomer)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel12)
        Me.tabCustomersNew.Controls.Add(Me.txtSearchCustomer)
        Me.tabCustomersNew.Controls.Add(Me.dgrdCustomers)
        Me.tabCustomersNew.Controls.Add(Me.txtNotes)
        Me.tabCustomersNew.Controls.Add(Me.txtContacts)
        Me.tabCustomersNew.Controls.Add(Me.txtFax)
        Me.tabCustomersNew.Controls.Add(Me.txtTelephone)
        Me.tabCustomersNew.Controls.Add(Me.txtAddress4)
        Me.tabCustomersNew.Controls.Add(Me.txtAddress3)
        Me.tabCustomersNew.Controls.Add(Me.txtAddress2)
        Me.tabCustomersNew.Controls.Add(Me.txtAddress1)
        Me.tabCustomersNew.Controls.Add(Me.txtName)
        Me.tabCustomersNew.Controls.Add(Me.txtCode)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel10)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel9)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel8)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel7)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel6)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel5)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel4)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel3)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel2)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel1)
        Me.tabCustomersNew.Controls.Add(Me.GroupBox1)
        Me.tabCustomersNew.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCustomersNew.HorizontalScrollbarBarColor = True
        Me.tabCustomersNew.HorizontalScrollbarHighlightOnWheel = False
        Me.tabCustomersNew.HorizontalScrollbarSize = 10
        Me.tabCustomersNew.Location = New System.Drawing.Point(4, 44)
        Me.tabCustomersNew.Name = "tabCustomersNew"
        Me.tabCustomersNew.Size = New System.Drawing.Size(1409, 803)
        Me.tabCustomersNew.TabIndex = 3
        Me.tabCustomersNew.Text = " Customers  Certificates        "
        Me.tabCustomersNew.VerticalScrollbarBarColor = True
        Me.tabCustomersNew.VerticalScrollbarHighlightOnWheel = False
        Me.tabCustomersNew.VerticalScrollbarSize = 10
        '
        'btnNewCert
        '
        Me.btnNewCert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewCert.BackColor = System.Drawing.Color.Gold
        Me.btnNewCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCert.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCert.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNewCert.Location = New System.Drawing.Point(1208, 488)
        Me.btnNewCert.Name = "btnNewCert"
        Me.btnNewCert.Size = New System.Drawing.Size(181, 50)
        Me.btnNewCert.TabIndex = 42
        Me.btnNewCert.Text = "New Empty Cert"
        Me.btnNewCert.UseVisualStyleBackColor = False
        '
        'pnlCerts
        '
        Me.pnlCerts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCerts.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlCerts.Controls.Add(Me.btnPrintSelectedCerts)
        Me.pnlCerts.Controls.Add(Me.dgrdInstalledMachines)
        Me.pnlCerts.Location = New System.Drawing.Point(0, 538)
        Me.pnlCerts.Name = "pnlCerts"
        Me.pnlCerts.Size = New System.Drawing.Size(1389, 289)
        Me.pnlCerts.TabIndex = 43
        '
        'btnPrintSelectedCerts
        '
        Me.btnPrintSelectedCerts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSelectedCerts.BackColor = System.Drawing.Color.LightGreen
        Me.btnPrintSelectedCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSelectedCerts.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSelectedCerts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrintSelectedCerts.Location = New System.Drawing.Point(1226, 35)
        Me.btnPrintSelectedCerts.Name = "btnPrintSelectedCerts"
        Me.btnPrintSelectedCerts.Size = New System.Drawing.Size(149, 214)
        Me.btnPrintSelectedCerts.TabIndex = 43
        Me.btnPrintSelectedCerts.Text = "Print Selected Certs"
        Me.btnPrintSelectedCerts.UseVisualStyleBackColor = False
        '
        'dgrdInstalledMachines
        '
        Me.dgrdInstalledMachines.AllowUserToAddRows = False
        Me.dgrdInstalledMachines.AllowUserToDeleteRows = False
        Me.dgrdInstalledMachines.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        Me.dgrdInstalledMachines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrdInstalledMachines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrdInstalledMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrdInstalledMachines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgrdInstalledMachines.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdInstalledMachines.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrdInstalledMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgrdInstalledMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdInstalledMachines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgrdInstalledMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrdInstalledMachines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ViewCert, Me.SerialNumber, Me.ModelId, Me.CertNumber, Me.TagId, Me.Print})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdInstalledMachines.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgrdInstalledMachines.EnableHeadersVisualStyles = False
        Me.dgrdInstalledMachines.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgrdInstalledMachines.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdInstalledMachines.Location = New System.Drawing.Point(3, 3)
        Me.dgrdInstalledMachines.MultiSelect = False
        Me.dgrdInstalledMachines.Name = "dgrdInstalledMachines"
        Me.dgrdInstalledMachines.ReadOnly = True
        Me.dgrdInstalledMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdInstalledMachines.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgrdInstalledMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgrdInstalledMachines.RowTemplate.Height = 40
        Me.dgrdInstalledMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgrdInstalledMachines.Size = New System.Drawing.Size(1208, 260)
        Me.dgrdInstalledMachines.TabIndex = 27
        '
        'ViewCert
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.ViewCert.DefaultCellStyle = DataGridViewCellStyle3
        Me.ViewCert.FillWeight = 30.0!
        Me.ViewCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCert.HeaderText = ""
        Me.ViewCert.Name = "ViewCert"
        Me.ViewCert.ReadOnly = True
        Me.ViewCert.Text = "View Cert"
        Me.ViewCert.UseColumnTextForButtonValue = True
        '
        'SerialNumber
        '
        Me.SerialNumber.HeaderText = "Serial No."
        Me.SerialNumber.Name = "SerialNumber"
        Me.SerialNumber.ReadOnly = True
        '
        'ModelId
        '
        Me.ModelId.HeaderText = "Model Id"
        Me.ModelId.Name = "ModelId"
        Me.ModelId.ReadOnly = True
        '
        'CertNumber
        '
        Me.CertNumber.HeaderText = "Cert No."
        Me.CertNumber.Name = "CertNumber"
        Me.CertNumber.ReadOnly = True
        '
        'TagId
        '
        Me.TagId.HeaderText = "Tag Id"
        Me.TagId.Name = "TagId"
        Me.TagId.ReadOnly = True
        '
        'Print
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Print.DefaultCellStyle = DataGridViewCellStyle4
        Me.Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Print.HeaderText = ""
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'searchByCode
        '
        Me.searchByCode.AutoSize = True
        Me.searchByCode.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.searchByCode.Location = New System.Drawing.Point(621, 25)
        Me.searchByCode.Name = "searchByCode"
        Me.searchByCode.Size = New System.Drawing.Size(120, 19)
        Me.searchByCode.TabIndex = 40
        Me.searchByCode.Text = "Search By Code"
        Me.searchByCode.UseSelectable = True
        '
        'searchByName
        '
        Me.searchByName.AutoSize = True
        Me.searchByName.Checked = True
        Me.searchByName.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.searchByName.Location = New System.Drawing.Point(491, 25)
        Me.searchByName.Name = "searchByName"
        Me.searchByName.Size = New System.Drawing.Size(124, 19)
        Me.searchByName.TabIndex = 39
        Me.searchByName.TabStop = True
        Me.searchByName.Text = "Search By Name"
        Me.searchByName.UseSelectable = True
        '
        'ScrollBarCustomers
        '
        Me.ScrollBarCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScrollBarCustomers.Location = New System.Drawing.Point(735, 59)
        Me.ScrollBarCustomers.Name = "ScrollBarCustomers"
        Me.ScrollBarCustomers.Size = New System.Drawing.Size(44, 412)
        Me.ScrollBarCustomers.TabIndex = 38
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(1084, 77)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(120, 52)
        Me.btnDeleteCustomer.TabIndex = 35
        Me.btnDeleteCustomer.Text = "Delete Customer"
        Me.btnDeleteCustomer.UseCustomBackColor = True
        Me.btnDeleteCustomer.UseSelectable = True
        '
        'lblInstalledMachines
        '
        Me.lblInstalledMachines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstalledMachines.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInstalledMachines.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstalledMachines.ForeColor = System.Drawing.SystemColors.Window
        Me.lblInstalledMachines.Location = New System.Drawing.Point(0, 488)
        Me.lblInstalledMachines.Name = "lblInstalledMachines"
        Me.lblInstalledMachines.Size = New System.Drawing.Size(1389, 50)
        Me.lblInstalledMachines.TabIndex = 34
        Me.lblInstalledMachines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddCustomer.Location = New System.Drawing.Point(897, 77)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(120, 52)
        Me.btnAddCustomer.TabIndex = 32
        Me.btnAddCustomer.Text = "Add New Customer"
        Me.btnAddCustomer.UseCustomBackColor = True
        Me.btnAddCustomer.UseSelectable = True
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSaveCustomer.Location = New System.Drawing.Point(1269, 77)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(120, 52)
        Me.btnSaveCustomer.TabIndex = 31
        Me.btnSaveCustomer.Text = "Save Changes"
        Me.btnSaveCustomer.UseCustomBackColor = True
        Me.btnSaveCustomer.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 19)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(154, 25)
        Me.MetroLabel12.TabIndex = 30
        Me.MetroLabel12.Text = "Search Customers"
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCustomer.Location = New System.Drawing.Point(163, 19)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(280, 29)
        Me.txtSearchCustomer.TabIndex = 28
        '
        'dgrdCustomers
        '
        Me.dgrdCustomers.AllowUserToAddRows = False
        Me.dgrdCustomers.AllowUserToDeleteRows = False
        Me.dgrdCustomers.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgrdCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgrdCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrdCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgrdCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrdCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgrdCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdCustomers.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgrdCustomers.EnableHeadersVisualStyles = False
        Me.dgrdCustomers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgrdCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdCustomers.Location = New System.Drawing.Point(0, 59)
        Me.dgrdCustomers.MultiSelect = False
        Me.dgrdCustomers.Name = "dgrdCustomers"
        Me.dgrdCustomers.ReadOnly = True
        Me.dgrdCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgrdCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgrdCustomers.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgrdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdCustomers.Size = New System.Drawing.Size(732, 412)
        Me.dgrdCustomers.TabIndex = 26
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtNotes.CustomButton.Image = Nothing
        Me.txtNotes.CustomButton.Location = New System.Drawing.Point(448, 2)
        Me.txtNotes.CustomButton.Name = ""
        Me.txtNotes.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNotes.CustomButton.TabIndex = 1
        Me.txtNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNotes.CustomButton.UseSelectable = True
        Me.txtNotes.CustomButton.Visible = False
        Me.txtNotes.Lines = New String(-1) {}
        Me.txtNotes.Location = New System.Drawing.Point(897, 399)
        Me.txtNotes.MaxLength = 32767
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.SelectionLength = 0
        Me.txtNotes.SelectionStart = 0
        Me.txtNotes.ShortcutsEnabled = True
        Me.txtNotes.Size = New System.Drawing.Size(492, 46)
        Me.txtNotes.TabIndex = 25
        Me.txtNotes.UseSelectable = True
        Me.txtNotes.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNotes.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContacts
        '
        Me.txtContacts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtContacts.CustomButton.Image = Nothing
        Me.txtContacts.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtContacts.CustomButton.Name = ""
        Me.txtContacts.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContacts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContacts.CustomButton.TabIndex = 1
        Me.txtContacts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContacts.CustomButton.UseSelectable = True
        Me.txtContacts.CustomButton.Visible = False
        Me.txtContacts.Lines = New String(-1) {}
        Me.txtContacts.Location = New System.Drawing.Point(897, 370)
        Me.txtContacts.MaxLength = 32767
        Me.txtContacts.Name = "txtContacts"
        Me.txtContacts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContacts.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContacts.SelectedText = ""
        Me.txtContacts.SelectionLength = 0
        Me.txtContacts.SelectionStart = 0
        Me.txtContacts.ShortcutsEnabled = True
        Me.txtContacts.Size = New System.Drawing.Size(492, 23)
        Me.txtContacts.TabIndex = 24
        Me.txtContacts.UseSelectable = True
        Me.txtContacts.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContacts.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtFax.CustomButton.Image = Nothing
        Me.txtFax.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtFax.CustomButton.Name = ""
        Me.txtFax.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFax.CustomButton.TabIndex = 1
        Me.txtFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFax.CustomButton.UseSelectable = True
        Me.txtFax.CustomButton.Visible = False
        Me.txtFax.Lines = New String(-1) {}
        Me.txtFax.Location = New System.Drawing.Point(897, 338)
        Me.txtFax.MaxLength = 32767
        Me.txtFax.Name = "txtFax"
        Me.txtFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFax.SelectedText = ""
        Me.txtFax.SelectionLength = 0
        Me.txtFax.SelectionStart = 0
        Me.txtFax.ShortcutsEnabled = True
        Me.txtFax.Size = New System.Drawing.Size(492, 23)
        Me.txtFax.TabIndex = 23
        Me.txtFax.UseSelectable = True
        Me.txtFax.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFax.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelephone
        '
        Me.txtTelephone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtTelephone.CustomButton.Image = Nothing
        Me.txtTelephone.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtTelephone.CustomButton.Name = ""
        Me.txtTelephone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelephone.CustomButton.TabIndex = 1
        Me.txtTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelephone.CustomButton.UseSelectable = True
        Me.txtTelephone.CustomButton.Visible = False
        Me.txtTelephone.Lines = New String(-1) {}
        Me.txtTelephone.Location = New System.Drawing.Point(897, 309)
        Me.txtTelephone.MaxLength = 32767
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelephone.SelectedText = ""
        Me.txtTelephone.SelectionLength = 0
        Me.txtTelephone.SelectionStart = 0
        Me.txtTelephone.ShortcutsEnabled = True
        Me.txtTelephone.Size = New System.Drawing.Size(492, 23)
        Me.txtTelephone.TabIndex = 22
        Me.txtTelephone.UseSelectable = True
        Me.txtTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelephone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress4
        '
        Me.txtAddress4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtAddress4.CustomButton.Image = Nothing
        Me.txtAddress4.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtAddress4.CustomButton.Name = ""
        Me.txtAddress4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAddress4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress4.CustomButton.TabIndex = 1
        Me.txtAddress4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress4.CustomButton.UseSelectable = True
        Me.txtAddress4.CustomButton.Visible = False
        Me.txtAddress4.Lines = New String(-1) {}
        Me.txtAddress4.Location = New System.Drawing.Point(897, 280)
        Me.txtAddress4.MaxLength = 32767
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress4.SelectedText = ""
        Me.txtAddress4.SelectionLength = 0
        Me.txtAddress4.SelectionStart = 0
        Me.txtAddress4.ShortcutsEnabled = True
        Me.txtAddress4.Size = New System.Drawing.Size(492, 23)
        Me.txtAddress4.TabIndex = 21
        Me.txtAddress4.UseSelectable = True
        Me.txtAddress4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress3
        '
        Me.txtAddress3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtAddress3.CustomButton.Image = Nothing
        Me.txtAddress3.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtAddress3.CustomButton.Name = ""
        Me.txtAddress3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAddress3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress3.CustomButton.TabIndex = 1
        Me.txtAddress3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress3.CustomButton.UseSelectable = True
        Me.txtAddress3.CustomButton.Visible = False
        Me.txtAddress3.Lines = New String(-1) {}
        Me.txtAddress3.Location = New System.Drawing.Point(897, 250)
        Me.txtAddress3.MaxLength = 32767
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress3.SelectedText = ""
        Me.txtAddress3.SelectionLength = 0
        Me.txtAddress3.SelectionStart = 0
        Me.txtAddress3.ShortcutsEnabled = True
        Me.txtAddress3.Size = New System.Drawing.Size(492, 23)
        Me.txtAddress3.TabIndex = 20
        Me.txtAddress3.UseSelectable = True
        Me.txtAddress3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress2
        '
        Me.txtAddress2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtAddress2.CustomButton.Image = Nothing
        Me.txtAddress2.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtAddress2.CustomButton.Name = ""
        Me.txtAddress2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAddress2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress2.CustomButton.TabIndex = 1
        Me.txtAddress2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress2.CustomButton.UseSelectable = True
        Me.txtAddress2.CustomButton.Visible = False
        Me.txtAddress2.Lines = New String(-1) {}
        Me.txtAddress2.Location = New System.Drawing.Point(897, 221)
        Me.txtAddress2.MaxLength = 32767
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress2.SelectedText = ""
        Me.txtAddress2.SelectionLength = 0
        Me.txtAddress2.SelectionStart = 0
        Me.txtAddress2.ShortcutsEnabled = True
        Me.txtAddress2.Size = New System.Drawing.Size(492, 23)
        Me.txtAddress2.TabIndex = 19
        Me.txtAddress2.UseSelectable = True
        Me.txtAddress2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress1
        '
        Me.txtAddress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtAddress1.CustomButton.Image = Nothing
        Me.txtAddress1.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtAddress1.CustomButton.Name = ""
        Me.txtAddress1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAddress1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress1.CustomButton.TabIndex = 1
        Me.txtAddress1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress1.CustomButton.UseSelectable = True
        Me.txtAddress1.CustomButton.Visible = False
        Me.txtAddress1.Lines = New String(-1) {}
        Me.txtAddress1.Location = New System.Drawing.Point(897, 193)
        Me.txtAddress1.MaxLength = 32767
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress1.SelectedText = ""
        Me.txtAddress1.SelectionLength = 0
        Me.txtAddress1.SelectionStart = 0
        Me.txtAddress1.ShortcutsEnabled = True
        Me.txtAddress1.Size = New System.Drawing.Size(492, 23)
        Me.txtAddress1.TabIndex = 18
        Me.txtAddress1.UseSelectable = True
        Me.txtAddress1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(897, 164)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(492, 23)
        Me.txtName.TabIndex = 17
        Me.txtName.UseCustomBackColor = True
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(897, 135)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ReadOnly = True
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(492, 23)
        Me.txtCode.TabIndex = 16
        Me.txtCode.UseCustomBackColor = True
        Me.txtCode.UseSelectable = True
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(821, 399)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel10.TabIndex = 15
        Me.MetroLabel10.Text = "Notes"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(821, 374)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel9.TabIndex = 14
        Me.MetroLabel9.Text = "Contacts"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(821, 342)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "Fax"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(820, 313)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Telephone"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(821, 284)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "Address 4"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(820, 225)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Address 2"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(821, 254)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Address 3"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(821, 197)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Address 1"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(821, 168)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Name"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(820, 139)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Location = New System.Drawing.Point(790, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 452)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Maintenance"
        '
        'tabMaintainMachines
        '
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel20)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel19)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel18)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel17)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel16)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel15)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel14)
        Me.tabMaintainMachines.Controls.Add(Me.txtInservice)
        Me.tabMaintainMachines.Controls.Add(Me.txtDefaultMinGrad)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel13)
        Me.tabMaintainMachines.Controls.Add(Me.searchByMachineCode)
        Me.tabMaintainMachines.Controls.Add(Me.searchByMachineName)
        Me.tabMaintainMachines.Controls.Add(Me.ScrollbarMachines)
        Me.tabMaintainMachines.Controls.Add(Me.btnDeleteMachine)
        Me.tabMaintainMachines.Controls.Add(Me.btnAddNewMachine)
        Me.tabMaintainMachines.Controls.Add(Me.btnSaveMachines)
        Me.tabMaintainMachines.Controls.Add(Me.MetroLabel11)
        Me.tabMaintainMachines.Controls.Add(Me.txtMachineSearch)
        Me.tabMaintainMachines.Controls.Add(Me.dgrdMachines)
        Me.tabMaintainMachines.Controls.Add(Me.txtDefaultCapacity)
        Me.tabMaintainMachines.Controls.Add(Me.txtElectronicMechanical)
        Me.tabMaintainMachines.Controls.Add(Me.txtCertType)
        Me.tabMaintainMachines.Controls.Add(Me.txtManufacturer)
        Me.tabMaintainMachines.Controls.Add(Me.txtModelDescription)
        Me.tabMaintainMachines.Controls.Add(Me.txtModelId)
        Me.tabMaintainMachines.HorizontalScrollbarBarColor = True
        Me.tabMaintainMachines.HorizontalScrollbarHighlightOnWheel = False
        Me.tabMaintainMachines.HorizontalScrollbarSize = 10
        Me.tabMaintainMachines.Location = New System.Drawing.Point(4, 44)
        Me.tabMaintainMachines.Name = "tabMaintainMachines"
        Me.tabMaintainMachines.Size = New System.Drawing.Size(1409, 803)
        Me.tabMaintainMachines.TabIndex = 2
        Me.tabMaintainMachines.Text = "                              Maintain Machines"
        Me.tabMaintainMachines.VerticalScrollbarBarColor = True
        Me.tabMaintainMachines.VerticalScrollbarHighlightOnWheel = False
        Me.tabMaintainMachines.VerticalScrollbarSize = 10
        '
        'txtInservice
        '
        Me.txtInservice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtInservice.CustomButton.Image = Nothing
        Me.txtInservice.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtInservice.CustomButton.Name = ""
        Me.txtInservice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtInservice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInservice.CustomButton.TabIndex = 1
        Me.txtInservice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInservice.CustomButton.UseSelectable = True
        Me.txtInservice.CustomButton.Visible = False
        Me.txtInservice.Lines = New String(-1) {}
        Me.txtInservice.Location = New System.Drawing.Point(902, 580)
        Me.txtInservice.MaxLength = 32767
        Me.txtInservice.Name = "txtInservice"
        Me.txtInservice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInservice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInservice.SelectedText = ""
        Me.txtInservice.SelectionLength = 0
        Me.txtInservice.SelectionStart = 0
        Me.txtInservice.ShortcutsEnabled = True
        Me.txtInservice.Size = New System.Drawing.Size(492, 23)
        Me.txtInservice.TabIndex = 72
        Me.txtInservice.UseSelectable = True
        Me.txtInservice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInservice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDefaultMinGrad
        '
        Me.txtDefaultMinGrad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtDefaultMinGrad.CustomButton.Image = Nothing
        Me.txtDefaultMinGrad.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtDefaultMinGrad.CustomButton.Name = ""
        Me.txtDefaultMinGrad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDefaultMinGrad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDefaultMinGrad.CustomButton.TabIndex = 1
        Me.txtDefaultMinGrad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDefaultMinGrad.CustomButton.UseSelectable = True
        Me.txtDefaultMinGrad.CustomButton.Visible = False
        Me.txtDefaultMinGrad.Lines = New String(-1) {}
        Me.txtDefaultMinGrad.Location = New System.Drawing.Point(902, 519)
        Me.txtDefaultMinGrad.MaxLength = 32767
        Me.txtDefaultMinGrad.Name = "txtDefaultMinGrad"
        Me.txtDefaultMinGrad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDefaultMinGrad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDefaultMinGrad.SelectedText = ""
        Me.txtDefaultMinGrad.SelectionLength = 0
        Me.txtDefaultMinGrad.SelectionStart = 0
        Me.txtDefaultMinGrad.ShortcutsEnabled = True
        Me.txtDefaultMinGrad.Size = New System.Drawing.Size(492, 23)
        Me.txtDefaultMinGrad.TabIndex = 71
        Me.txtDefaultMinGrad.UseSelectable = True
        Me.txtDefaultMinGrad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDefaultMinGrad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(902, 152)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel13.TabIndex = 70
        Me.MetroLabel13.Text = "Model Id"
        '
        'searchByMachineCode
        '
        Me.searchByMachineCode.AutoSize = True
        Me.searchByMachineCode.Location = New System.Drawing.Point(483, 47)
        Me.searchByMachineCode.Name = "searchByMachineCode"
        Me.searchByMachineCode.Size = New System.Drawing.Size(105, 15)
        Me.searchByMachineCode.TabIndex = 69
        Me.searchByMachineCode.Text = "Search By Code"
        Me.searchByMachineCode.UseSelectable = True
        '
        'searchByMachineName
        '
        Me.searchByMachineName.AutoSize = True
        Me.searchByMachineName.Checked = True
        Me.searchByMachineName.Location = New System.Drawing.Point(332, 47)
        Me.searchByMachineName.Name = "searchByMachineName"
        Me.searchByMachineName.Size = New System.Drawing.Size(109, 15)
        Me.searchByMachineName.TabIndex = 68
        Me.searchByMachineName.TabStop = True
        Me.searchByMachineName.Text = "Search By Name"
        Me.searchByMachineName.UseSelectable = True
        '
        'ScrollbarMachines
        '
        Me.ScrollbarMachines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScrollbarMachines.Location = New System.Drawing.Point(810, 77)
        Me.ScrollbarMachines.Name = "ScrollbarMachines"
        Me.ScrollbarMachines.Size = New System.Drawing.Size(44, 722)
        Me.ScrollbarMachines.TabIndex = 67
        '
        'btnDeleteMachine
        '
        Me.btnDeleteMachine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteMachine.Location = New System.Drawing.Point(1077, 77)
        Me.btnDeleteMachine.Name = "btnDeleteMachine"
        Me.btnDeleteMachine.Size = New System.Drawing.Size(120, 52)
        Me.btnDeleteMachine.TabIndex = 66
        Me.btnDeleteMachine.Text = "Delete Machine"
        Me.btnDeleteMachine.UseSelectable = True
        '
        'btnAddNewMachine
        '
        Me.btnAddNewMachine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNewMachine.Location = New System.Drawing.Point(902, 77)
        Me.btnAddNewMachine.Name = "btnAddNewMachine"
        Me.btnAddNewMachine.Size = New System.Drawing.Size(120, 52)
        Me.btnAddNewMachine.TabIndex = 65
        Me.btnAddNewMachine.Text = "Add New Machine"
        Me.btnAddNewMachine.UseSelectable = True
        '
        'btnSaveMachines
        '
        Me.btnSaveMachines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveMachines.Location = New System.Drawing.Point(1274, 77)
        Me.btnSaveMachines.Name = "btnSaveMachines"
        Me.btnSaveMachines.Size = New System.Drawing.Size(120, 52)
        Me.btnSaveMachines.TabIndex = 64
        Me.btnSaveMachines.Text = "Save Changes"
        Me.btnSaveMachines.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 37)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(143, 25)
        Me.MetroLabel11.TabIndex = 63
        Me.MetroLabel11.Text = "Search Machines"
        '
        'txtMachineSearch
        '
        Me.txtMachineSearch.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineSearch.Location = New System.Drawing.Point(163, 37)
        Me.txtMachineSearch.Name = "txtMachineSearch"
        Me.txtMachineSearch.Size = New System.Drawing.Size(156, 29)
        Me.txtMachineSearch.TabIndex = 62
        '
        'dgrdMachines
        '
        Me.dgrdMachines.AllowUserToAddRows = False
        Me.dgrdMachines.AllowUserToDeleteRows = False
        Me.dgrdMachines.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgrdMachines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgrdMachines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrdMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrdMachines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgrdMachines.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdMachines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrdMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgrdMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdMachines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgrdMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdMachines.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgrdMachines.EnableHeadersVisualStyles = False
        Me.dgrdMachines.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgrdMachines.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdMachines.Location = New System.Drawing.Point(0, 77)
        Me.dgrdMachines.MultiSelect = False
        Me.dgrdMachines.Name = "dgrdMachines"
        Me.dgrdMachines.ReadOnly = True
        Me.dgrdMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdMachines.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgrdMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgrdMachines.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgrdMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdMachines.Size = New System.Drawing.Size(798, 722)
        Me.dgrdMachines.TabIndex = 61
        '
        'txtDefaultCapacity
        '
        Me.txtDefaultCapacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtDefaultCapacity.CustomButton.Image = Nothing
        Me.txtDefaultCapacity.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtDefaultCapacity.CustomButton.Name = ""
        Me.txtDefaultCapacity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDefaultCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDefaultCapacity.CustomButton.TabIndex = 1
        Me.txtDefaultCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDefaultCapacity.CustomButton.UseSelectable = True
        Me.txtDefaultCapacity.CustomButton.Visible = False
        Me.txtDefaultCapacity.Lines = New String(-1) {}
        Me.txtDefaultCapacity.Location = New System.Drawing.Point(902, 459)
        Me.txtDefaultCapacity.MaxLength = 32767
        Me.txtDefaultCapacity.Name = "txtDefaultCapacity"
        Me.txtDefaultCapacity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDefaultCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDefaultCapacity.SelectedText = ""
        Me.txtDefaultCapacity.SelectionLength = 0
        Me.txtDefaultCapacity.SelectionStart = 0
        Me.txtDefaultCapacity.ShortcutsEnabled = True
        Me.txtDefaultCapacity.Size = New System.Drawing.Size(492, 23)
        Me.txtDefaultCapacity.TabIndex = 56
        Me.txtDefaultCapacity.UseSelectable = True
        Me.txtDefaultCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDefaultCapacity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtElectronicMechanical
        '
        Me.txtElectronicMechanical.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtElectronicMechanical.CustomButton.Image = Nothing
        Me.txtElectronicMechanical.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtElectronicMechanical.CustomButton.Name = ""
        Me.txtElectronicMechanical.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtElectronicMechanical.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtElectronicMechanical.CustomButton.TabIndex = 1
        Me.txtElectronicMechanical.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtElectronicMechanical.CustomButton.UseSelectable = True
        Me.txtElectronicMechanical.CustomButton.Visible = False
        Me.txtElectronicMechanical.Lines = New String(-1) {}
        Me.txtElectronicMechanical.Location = New System.Drawing.Point(902, 399)
        Me.txtElectronicMechanical.MaxLength = 32767
        Me.txtElectronicMechanical.Name = "txtElectronicMechanical"
        Me.txtElectronicMechanical.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtElectronicMechanical.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtElectronicMechanical.SelectedText = ""
        Me.txtElectronicMechanical.SelectionLength = 0
        Me.txtElectronicMechanical.SelectionStart = 0
        Me.txtElectronicMechanical.ShortcutsEnabled = True
        Me.txtElectronicMechanical.Size = New System.Drawing.Size(492, 23)
        Me.txtElectronicMechanical.TabIndex = 55
        Me.txtElectronicMechanical.UseSelectable = True
        Me.txtElectronicMechanical.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtElectronicMechanical.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCertType
        '
        Me.txtCertType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtCertType.CustomButton.Image = Nothing
        Me.txtCertType.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtCertType.CustomButton.Name = ""
        Me.txtCertType.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCertType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCertType.CustomButton.TabIndex = 1
        Me.txtCertType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCertType.CustomButton.UseSelectable = True
        Me.txtCertType.CustomButton.Visible = False
        Me.txtCertType.Lines = New String(-1) {}
        Me.txtCertType.Location = New System.Drawing.Point(902, 340)
        Me.txtCertType.MaxLength = 32767
        Me.txtCertType.Name = "txtCertType"
        Me.txtCertType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCertType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCertType.SelectedText = ""
        Me.txtCertType.SelectionLength = 0
        Me.txtCertType.SelectionStart = 0
        Me.txtCertType.ShortcutsEnabled = True
        Me.txtCertType.Size = New System.Drawing.Size(492, 23)
        Me.txtCertType.TabIndex = 54
        Me.txtCertType.UseSelectable = True
        Me.txtCertType.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCertType.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtManufacturer.CustomButton.Image = Nothing
        Me.txtManufacturer.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtManufacturer.CustomButton.Name = ""
        Me.txtManufacturer.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtManufacturer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtManufacturer.CustomButton.TabIndex = 1
        Me.txtManufacturer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtManufacturer.CustomButton.UseSelectable = True
        Me.txtManufacturer.CustomButton.Visible = False
        Me.txtManufacturer.Lines = New String(-1) {}
        Me.txtManufacturer.Location = New System.Drawing.Point(902, 282)
        Me.txtManufacturer.MaxLength = 32767
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtManufacturer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtManufacturer.SelectedText = ""
        Me.txtManufacturer.SelectionLength = 0
        Me.txtManufacturer.SelectionStart = 0
        Me.txtManufacturer.ShortcutsEnabled = True
        Me.txtManufacturer.Size = New System.Drawing.Size(492, 23)
        Me.txtManufacturer.TabIndex = 53
        Me.txtManufacturer.UseSelectable = True
        Me.txtManufacturer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtManufacturer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtModelDescription
        '
        Me.txtModelDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelDescription.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtModelDescription.CustomButton.Image = Nothing
        Me.txtModelDescription.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtModelDescription.CustomButton.Name = ""
        Me.txtModelDescription.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtModelDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtModelDescription.CustomButton.TabIndex = 1
        Me.txtModelDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtModelDescription.CustomButton.UseSelectable = True
        Me.txtModelDescription.CustomButton.Visible = False
        Me.txtModelDescription.Lines = New String(-1) {}
        Me.txtModelDescription.Location = New System.Drawing.Point(902, 227)
        Me.txtModelDescription.MaxLength = 32767
        Me.txtModelDescription.Name = "txtModelDescription"
        Me.txtModelDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModelDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModelDescription.SelectedText = ""
        Me.txtModelDescription.SelectionLength = 0
        Me.txtModelDescription.SelectionStart = 0
        Me.txtModelDescription.ShortcutsEnabled = True
        Me.txtModelDescription.Size = New System.Drawing.Size(492, 23)
        Me.txtModelDescription.TabIndex = 52
        Me.txtModelDescription.UseCustomBackColor = True
        Me.txtModelDescription.UseSelectable = True
        Me.txtModelDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModelDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtModelId
        '
        Me.txtModelId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelId.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtModelId.CustomButton.Image = Nothing
        Me.txtModelId.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.txtModelId.CustomButton.Name = ""
        Me.txtModelId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtModelId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtModelId.CustomButton.TabIndex = 1
        Me.txtModelId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtModelId.CustomButton.UseSelectable = True
        Me.txtModelId.CustomButton.Visible = False
        Me.txtModelId.Lines = New String(-1) {}
        Me.txtModelId.Location = New System.Drawing.Point(902, 174)
        Me.txtModelId.MaxLength = 32767
        Me.txtModelId.Name = "txtModelId"
        Me.txtModelId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModelId.ReadOnly = True
        Me.txtModelId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModelId.SelectedText = ""
        Me.txtModelId.SelectionLength = 0
        Me.txtModelId.SelectionStart = 0
        Me.txtModelId.ShortcutsEnabled = True
        Me.txtModelId.Size = New System.Drawing.Size(492, 23)
        Me.txtModelId.TabIndex = 51
        Me.txtModelId.UseCustomBackColor = True
        Me.txtModelId.UseSelectable = True
        Me.txtModelId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModelId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Black
        Me.btnSettings.BackgroundImage = Global.CertificationSystem.My.Resources.Resources.Settings
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.Info
        Me.btnSettings.Location = New System.Drawing.Point(258, 18)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(53, 36)
        Me.btnSettings.TabIndex = 67
        Me.btnSettings.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(902, 205)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel14.TabIndex = 73
        Me.MetroLabel14.Text = "Model Description"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.Location = New System.Drawing.Point(902, 260)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel15.TabIndex = 74
        Me.MetroLabel15.Text = "Manufacturer"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(902, 318)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel16.TabIndex = 75
        Me.MetroLabel16.Text = "Cert Type"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(902, 377)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(148, 19)
        Me.MetroLabel17.TabIndex = 76
        Me.MetroLabel17.Text = "Electronic / Mechanical"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.Location = New System.Drawing.Point(902, 437)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel18.TabIndex = 77
        Me.MetroLabel18.Text = "Default Capacity"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(902, 496)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel19.TabIndex = 78
        Me.MetroLabel19.Text = "Default Min Graduation"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel20.Location = New System.Drawing.Point(902, 557)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel20.TabIndex = 79
        Me.MetroLabel20.Text = "In Service"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 931)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.tabCertPages)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Atlas Certification"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabCertPages.ResumeLayout(False)
        Me.tabCustomersNew.ResumeLayout(False)
        Me.tabCustomersNew.PerformLayout()
        Me.pnlCerts.ResumeLayout(False)
        CType(Me.dgrdInstalledMachines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMaintainMachines.ResumeLayout(False)
        Me.tabMaintainMachines.PerformLayout()
        CType(Me.dgrdMachines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCertPages As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents tabMaintainMachines As MetroFramework.Controls.MetroTabPage
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabCustomersNew As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtNotes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContacts As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFax As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelephone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgrdCustomers As MetroFramework.Controls.MetroGrid
    Friend WithEvents dgrdInstalledMachines As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSaveCustomer As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddCustomer As MetroFramework.Controls.MetroButton
    Friend WithEvents lblInstalledMachines As Label
    Friend WithEvents btnDeleteCustomer As MetroFramework.Controls.MetroButton
    Friend WithEvents ScrollBarCustomers As VScrollBar
    Friend WithEvents searchByCode As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents searchByName As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents searchByMachineCode As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents searchByMachineName As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ScrollbarMachines As VScrollBar
    Friend WithEvents btnDeleteMachine As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddNewMachine As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveMachines As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMachineSearch As TextBox
    Friend WithEvents dgrdMachines As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtDefaultCapacity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtElectronicMechanical As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCertType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtManufacturer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtModelDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtModelId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnNewCert As Button
    Friend WithEvents pnlCerts As Panel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSettings As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInservice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDefaultMinGrad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnPrintSelectedCerts As Button
    Friend WithEvents ViewCert As DataGridViewButtonColumn
    Friend WithEvents SerialNumber As DataGridViewTextBoxColumn
    Friend WithEvents ModelId As DataGridViewTextBoxColumn
    Friend WithEvents CertNumber As DataGridViewTextBoxColumn
    Friend WithEvents TagId As DataGridViewTextBoxColumn
    Friend WithEvents Print As DataGridViewButtonColumn
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
End Class
