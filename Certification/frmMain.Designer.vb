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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabPages = New MetroFramework.Controls.MetroTabControl()
        Me.tabCustomersNew = New MetroFramework.Controls.MetroTabPage()
        Me.btnNewCert = New System.Windows.Forms.Button()
        Me.searchByCode = New MetroFramework.Controls.MetroRadioButton()
        Me.searchByName = New MetroFramework.Controls.MetroRadioButton()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.btnDeleteCustomer = New MetroFramework.Controls.MetroButton()
        Me.lblInstalledMachines = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New MetroFramework.Controls.MetroButton()
        Me.btnSaveCustomer = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.dgrdInstalledMachines = New MetroFramework.Controls.MetroGrid()
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
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox9 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox10 = New MetroFramework.Controls.MetroTextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SerialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewCert = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tabPages.SuspendLayout()
        Me.tabCustomersNew.SuspendLayout()
        CType(Me.dgrdInstalledMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPages
        '
        Me.tabPages.Controls.Add(Me.tabCustomersNew)
        Me.tabPages.Controls.Add(Me.MetroTabPage1)
        Me.tabPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPages.Location = New System.Drawing.Point(20, 60)
        Me.tabPages.Name = "tabPages"
        Me.tabPages.SelectedIndex = 0
        Me.tabPages.Size = New System.Drawing.Size(1417, 851)
        Me.tabPages.TabIndex = 0
        Me.tabPages.UseSelectable = True
        '
        'tabCustomersNew
        '
        Me.tabCustomersNew.Controls.Add(Me.btnNewCert)
        Me.tabCustomersNew.Controls.Add(Me.searchByCode)
        Me.tabCustomersNew.Controls.Add(Me.searchByName)
        Me.tabCustomersNew.Controls.Add(Me.VScrollBar1)
        Me.tabCustomersNew.Controls.Add(Me.btnDeleteCustomer)
        Me.tabCustomersNew.Controls.Add(Me.lblInstalledMachines)
        Me.tabCustomersNew.Controls.Add(Me.btnAddCustomer)
        Me.tabCustomersNew.Controls.Add(Me.btnSaveCustomer)
        Me.tabCustomersNew.Controls.Add(Me.MetroLabel12)
        Me.tabCustomersNew.Controls.Add(Me.txtSearchCustomer)
        Me.tabCustomersNew.Controls.Add(Me.dgrdInstalledMachines)
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
        Me.tabCustomersNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCustomersNew.HorizontalScrollbarBarColor = True
        Me.tabCustomersNew.HorizontalScrollbarHighlightOnWheel = False
        Me.tabCustomersNew.HorizontalScrollbarSize = 10
        Me.tabCustomersNew.Location = New System.Drawing.Point(4, 38)
        Me.tabCustomersNew.Name = "tabCustomersNew"
        Me.tabCustomersNew.Size = New System.Drawing.Size(1409, 809)
        Me.tabCustomersNew.TabIndex = 3
        Me.tabCustomersNew.Text = "Customers"
        Me.tabCustomersNew.VerticalScrollbarBarColor = True
        Me.tabCustomersNew.VerticalScrollbarHighlightOnWheel = False
        Me.tabCustomersNew.VerticalScrollbarSize = 10
        '
        'btnNewCert
        '
        Me.btnNewCert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewCert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCert.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCert.Location = New System.Drawing.Point(1065, 496)
        Me.btnNewCert.Name = "btnNewCert"
        Me.btnNewCert.Size = New System.Drawing.Size(324, 70)
        Me.btnNewCert.TabIndex = 42
        Me.btnNewCert.Text = "Create New Cert For Selected Customer"
        Me.btnNewCert.UseVisualStyleBackColor = False
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
        'VScrollBar1
        '
        Me.VScrollBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VScrollBar1.Location = New System.Drawing.Point(735, 59)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(44, 412)
        Me.VScrollBar1.TabIndex = 38
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(1084, 45)
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
        Me.lblInstalledMachines.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstalledMachines.Location = New System.Drawing.Point(3, 496)
        Me.lblInstalledMachines.Name = "lblInstalledMachines"
        Me.lblInstalledMachines.Size = New System.Drawing.Size(1386, 70)
        Me.lblInstalledMachines.TabIndex = 34
        Me.lblInstalledMachines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddCustomer.Location = New System.Drawing.Point(897, 45)
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
        Me.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveCustomer.Location = New System.Drawing.Point(1269, 45)
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
        'dgrdInstalledMachines
        '
        Me.dgrdInstalledMachines.AllowUserToAddRows = False
        Me.dgrdInstalledMachines.AllowUserToDeleteRows = False
        Me.dgrdInstalledMachines.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrdInstalledMachines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrdInstalledMachines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrdInstalledMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrdInstalledMachines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgrdInstalledMachines.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdInstalledMachines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrdInstalledMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgrdInstalledMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdInstalledMachines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgrdInstalledMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrdInstalledMachines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerialNumber, Me.ModelId, Me.CertNumber, Me.TagId, Me.ViewCert})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdInstalledMachines.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgrdInstalledMachines.EnableHeadersVisualStyles = False
        Me.dgrdInstalledMachines.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgrdInstalledMachines.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdInstalledMachines.Location = New System.Drawing.Point(3, 569)
        Me.dgrdInstalledMachines.MultiSelect = False
        Me.dgrdInstalledMachines.Name = "dgrdInstalledMachines"
        Me.dgrdInstalledMachines.ReadOnly = True
        Me.dgrdInstalledMachines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdInstalledMachines.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgrdInstalledMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgrdInstalledMachines.RowTemplate.Height = 40
        Me.dgrdInstalledMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdInstalledMachines.Size = New System.Drawing.Size(1386, 237)
        Me.dgrdInstalledMachines.TabIndex = 27
        '
        'dgrdCustomers
        '
        Me.dgrdCustomers.AllowUserToAddRows = False
        Me.dgrdCustomers.AllowUserToDeleteRows = False
        Me.dgrdCustomers.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgrdCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgrdCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrdCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgrdCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrdCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgrdCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdCustomers.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgrdCustomers.EnableHeadersVisualStyles = False
        Me.dgrdCustomers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgrdCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgrdCustomers.Location = New System.Drawing.Point(0, 59)
        Me.dgrdCustomers.MultiSelect = False
        Me.dgrdCustomers.Name = "dgrdCustomers"
        Me.dgrdCustomers.ReadOnly = True
        Me.dgrdCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        Me.txtNotes.Location = New System.Drawing.Point(897, 367)
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
        Me.txtContacts.Location = New System.Drawing.Point(897, 338)
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
        Me.txtFax.Location = New System.Drawing.Point(897, 306)
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
        Me.txtTelephone.Location = New System.Drawing.Point(897, 277)
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
        Me.txtAddress4.Location = New System.Drawing.Point(897, 248)
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
        Me.txtAddress3.Location = New System.Drawing.Point(897, 218)
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
        Me.txtAddress2.Location = New System.Drawing.Point(897, 189)
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
        Me.txtAddress1.Location = New System.Drawing.Point(897, 161)
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
        Me.txtName.Location = New System.Drawing.Point(897, 132)
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
        Me.txtCode.Location = New System.Drawing.Point(897, 103)
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
        Me.MetroLabel10.Location = New System.Drawing.Point(821, 367)
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
        Me.MetroLabel9.Location = New System.Drawing.Point(821, 342)
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
        Me.MetroLabel8.Location = New System.Drawing.Point(821, 310)
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
        Me.MetroLabel7.Location = New System.Drawing.Point(820, 281)
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
        Me.MetroLabel6.Location = New System.Drawing.Point(821, 252)
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
        Me.MetroLabel5.Location = New System.Drawing.Point(820, 193)
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
        Me.MetroLabel4.Location = New System.Drawing.Point(821, 222)
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
        Me.MetroLabel3.Location = New System.Drawing.Point(821, 165)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(821, 136)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(820, 107)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Code"
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroRadioButton1)
        Me.MetroTabPage1.Controls.Add(Me.MetroRadioButton2)
        Me.MetroTabPage1.Controls.Add(Me.VScrollBar2)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton2)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage1.Controls.Add(Me.TextBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox5)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox6)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox7)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox8)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox9)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox10)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1409, 809)
        Me.MetroTabPage1.TabIndex = 2
        Me.MetroTabPage1.Text = "Maintenance"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(483, 47)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(105, 15)
        Me.MetroRadioButton1.TabIndex = 69
        Me.MetroRadioButton1.Text = "Search By Code"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Checked = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(332, 47)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(109, 15)
        Me.MetroRadioButton2.TabIndex = 68
        Me.MetroRadioButton2.TabStop = True
        Me.MetroRadioButton2.Text = "Search By Name"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VScrollBar2.Location = New System.Drawing.Point(582, 77)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(44, 267)
        Me.VScrollBar2.TabIndex = 67
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(905, 93)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(120, 52)
        Me.MetroButton1.TabIndex = 66
        Me.MetroButton1.Text = "Delete Machine"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.Location = New System.Drawing.Point(730, 93)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(120, 52)
        Me.MetroButton2.TabIndex = 65
        Me.MetroButton2.Text = "Add New Machine"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton3.Location = New System.Drawing.Point(1102, 93)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(120, 52)
        Me.MetroButton3.TabIndex = 64
        Me.MetroButton3.Text = "Save Changes"
        Me.MetroButton3.UseSelectable = True
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(163, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 29)
        Me.TextBox1.TabIndex = 62
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.MetroGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle11
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 77)
        Me.MetroGrid1.MultiSelect = False
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(561, 267)
        Me.MetroGrid1.TabIndex = 61
        '
        'MetroTextBox5
        '
        Me.MetroTextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(730, 296)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.ShortcutsEnabled = True
        Me.MetroTextBox5.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox5.TabIndex = 56
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox6
        '
        Me.MetroTextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = Nothing
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.Lines = New String(-1) {}
        Me.MetroTextBox6.Location = New System.Drawing.Point(730, 266)
        Me.MetroTextBox6.MaxLength = 32767
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.ShortcutsEnabled = True
        Me.MetroTextBox6.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox6.TabIndex = 55
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox7
        '
        Me.MetroTextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = Nothing
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox7.CustomButton.Name = ""
        Me.MetroTextBox7.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox7.CustomButton.TabIndex = 1
        Me.MetroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox7.CustomButton.UseSelectable = True
        Me.MetroTextBox7.CustomButton.Visible = False
        Me.MetroTextBox7.Lines = New String(-1) {}
        Me.MetroTextBox7.Location = New System.Drawing.Point(730, 237)
        Me.MetroTextBox7.MaxLength = 32767
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.ShortcutsEnabled = True
        Me.MetroTextBox7.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox7.TabIndex = 54
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox8
        '
        Me.MetroTextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = Nothing
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.Lines = New String(-1) {}
        Me.MetroTextBox8.Location = New System.Drawing.Point(730, 209)
        Me.MetroTextBox8.MaxLength = 32767
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.ShortcutsEnabled = True
        Me.MetroTextBox8.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox8.TabIndex = 53
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox9
        '
        Me.MetroTextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox9.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroTextBox9.CustomButton.Image = Nothing
        Me.MetroTextBox9.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox9.CustomButton.Name = ""
        Me.MetroTextBox9.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox9.CustomButton.TabIndex = 1
        Me.MetroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox9.CustomButton.UseSelectable = True
        Me.MetroTextBox9.CustomButton.Visible = False
        Me.MetroTextBox9.Lines = New String(-1) {}
        Me.MetroTextBox9.Location = New System.Drawing.Point(730, 180)
        Me.MetroTextBox9.MaxLength = 32767
        Me.MetroTextBox9.Name = "MetroTextBox9"
        Me.MetroTextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox9.SelectedText = ""
        Me.MetroTextBox9.SelectionLength = 0
        Me.MetroTextBox9.SelectionStart = 0
        Me.MetroTextBox9.ShortcutsEnabled = True
        Me.MetroTextBox9.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox9.TabIndex = 52
        Me.MetroTextBox9.UseCustomBackColor = True
        Me.MetroTextBox9.UseSelectable = True
        Me.MetroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox9.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox10
        '
        Me.MetroTextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox10.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.MetroTextBox10.CustomButton.Image = Nothing
        Me.MetroTextBox10.CustomButton.Location = New System.Drawing.Point(470, 1)
        Me.MetroTextBox10.CustomButton.Name = ""
        Me.MetroTextBox10.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox10.CustomButton.TabIndex = 1
        Me.MetroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox10.CustomButton.UseSelectable = True
        Me.MetroTextBox10.CustomButton.Visible = False
        Me.MetroTextBox10.Lines = New String(-1) {}
        Me.MetroTextBox10.Location = New System.Drawing.Point(730, 151)
        Me.MetroTextBox10.MaxLength = 32767
        Me.MetroTextBox10.Name = "MetroTextBox10"
        Me.MetroTextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox10.ReadOnly = True
        Me.MetroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox10.SelectedText = ""
        Me.MetroTextBox10.SelectionLength = 0
        Me.MetroTextBox10.SelectionStart = 0
        Me.MetroTextBox10.ShortcutsEnabled = True
        Me.MetroTextBox10.Size = New System.Drawing.Size(492, 23)
        Me.MetroTextBox10.TabIndex = 51
        Me.MetroTextBox10.UseCustomBackColor = True
        Me.MetroTextBox10.UseSelectable = True
        Me.MetroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox10.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        'ViewCert
        '
        Me.ViewCert.FillWeight = 30.0!
        Me.ViewCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCert.HeaderText = ""
        Me.ViewCert.Name = "ViewCert"
        Me.ViewCert.ReadOnly = True
        Me.ViewCert.Text = "View Cert"
        Me.ViewCert.UseColumnTextForButtonValue = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 931)
        Me.Controls.Add(Me.tabPages)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Atlas Certification"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabPages.ResumeLayout(False)
        Me.tabCustomersNew.ResumeLayout(False)
        Me.tabCustomersNew.PerformLayout()
        CType(Me.dgrdInstalledMachines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPages As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
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
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents searchByCode As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents searchByName As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox9 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox10 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnNewCert As Button
    Friend WithEvents SerialNumber As DataGridViewTextBoxColumn
    Friend WithEvents ModelId As DataGridViewTextBoxColumn
    Friend WithEvents CertNumber As DataGridViewTextBoxColumn
    Friend WithEvents TagId As DataGridViewTextBoxColumn
    Friend WithEvents ViewCert As DataGridViewButtonColumn
End Class
