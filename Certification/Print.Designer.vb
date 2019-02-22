<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.printPreviewCtrl = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress1 = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress4 = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress3 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCertificateNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.ckElectronic = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.cbProcedure = New System.Windows.Forms.ComboBox()
        Me.txtMinGraduation = New System.Windows.Forms.TextBox()
        Me.cbCalibrationInterval = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModelId = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTagId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTolerance = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTestWeightsM1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTestWeightsF1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCalWeight7 = New System.Windows.Forms.TextBox()
        Me.txtCalWeight6 = New System.Windows.Forms.TextBox()
        Me.txtCalWeight5 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCalWeight4 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCalWeight3 = New System.Windows.Forms.TextBox()
        Me.txtCalWeight2 = New System.Windows.Forms.TextBox()
        Me.txtCalWeight1 = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'printPreviewCtrl
        '
        Me.printPreviewCtrl.AutoZoom = False
        Me.printPreviewCtrl.Location = New System.Drawing.Point(813, 25)
        Me.printPreviewCtrl.Name = "printPreviewCtrl"
        Me.printPreviewCtrl.Size = New System.Drawing.Size(498, 614)
        Me.printPreviewCtrl.TabIndex = 2
        Me.printPreviewCtrl.Zoom = 0.5R
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
        'txtCustomerCode
        '
        Me.txtCustomerCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(11, 31)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        Me.txtCustomerCode.Size = New System.Drawing.Size(116, 29)
        Me.txtCustomerCode.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(133, 31)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(610, 29)
        Me.txtCustomerName.TabIndex = 6
        '
        'txtCustomerAddress1
        '
        Me.txtCustomerAddress1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress1.Location = New System.Drawing.Point(11, 70)
        Me.txtCustomerAddress1.Name = "txtCustomerAddress1"
        Me.txtCustomerAddress1.ReadOnly = True
        Me.txtCustomerAddress1.Size = New System.Drawing.Size(345, 29)
        Me.txtCustomerAddress1.TabIndex = 8
        '
        'txtCustomerAddress2
        '
        Me.txtCustomerAddress2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress2.Location = New System.Drawing.Point(373, 70)
        Me.txtCustomerAddress2.Name = "txtCustomerAddress2"
        Me.txtCustomerAddress2.ReadOnly = True
        Me.txtCustomerAddress2.Size = New System.Drawing.Size(370, 29)
        Me.txtCustomerAddress2.TabIndex = 10
        '
        'txtCustomerAddress4
        '
        Me.txtCustomerAddress4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress4.Location = New System.Drawing.Point(373, 105)
        Me.txtCustomerAddress4.Name = "txtCustomerAddress4"
        Me.txtCustomerAddress4.ReadOnly = True
        Me.txtCustomerAddress4.Size = New System.Drawing.Size(369, 29)
        Me.txtCustomerAddress4.TabIndex = 14
        '
        'txtCustomerAddress3
        '
        Me.txtCustomerAddress3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress3.Location = New System.Drawing.Point(10, 105)
        Me.txtCustomerAddress3.Name = "txtCustomerAddress3"
        Me.txtCustomerAddress3.ReadOnly = True
        Me.txtCustomerAddress3.Size = New System.Drawing.Size(346, 29)
        Me.txtCustomerAddress3.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(987, 659)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 83)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cert No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerCode)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerAddress4)
        Me.GroupBox1.Controls.Add(Me.txtCustomerAddress1)
        Me.GroupBox1.Controls.Add(Me.txtCustomerAddress3)
        Me.GroupBox1.Controls.Add(Me.txtCustomerAddress2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 147)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txtCertificateNumber
        '
        Me.txtCertificateNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertificateNumber.Location = New System.Drawing.Point(127, 25)
        Me.txtCertificateNumber.Name = "txtCertificateNumber"
        Me.txtCertificateNumber.Size = New System.Drawing.Size(240, 29)
        Me.txtCertificateNumber.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbModel)
        Me.GroupBox2.Controls.Add(Me.ckElectronic)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCapacity)
        Me.GroupBox2.Controls.Add(Me.cbProcedure)
        Me.GroupBox2.Controls.Add(Me.txtMinGraduation)
        Me.GroupBox2.Controls.Add(Me.cbCalibrationInterval)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtModelId)
        Me.GroupBox2.Controls.Add(Me.txtManufacturer)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTagId)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 219)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine Details"
        '
        'cbModel
        '
        Me.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Location = New System.Drawing.Point(130, 31)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(461, 33)
        Me.cbModel.TabIndex = 28
        '
        'ckElectronic
        '
        Me.ckElectronic.AutoSize = True
        Me.ckElectronic.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckElectronic.Location = New System.Drawing.Point(633, 35)
        Me.ckElectronic.Name = "ckElectronic"
        Me.ckElectronic.Size = New System.Drawing.Size(96, 25)
        Me.ckElectronic.TabIndex = 27
        Me.ckElectronic.Text = "Electronic"
        Me.ckElectronic.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Min Grad."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 21)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Procedure"
        '
        'txtCapacity
        '
        Me.txtCapacity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Location = New System.Drawing.Point(483, 105)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(260, 29)
        Me.txtCapacity.TabIndex = 25
        '
        'cbProcedure
        '
        Me.cbProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProcedure.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbProcedure.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProcedure.FormattingEnabled = True
        Me.cbProcedure.Items.AddRange(New Object() {"Quality Assurance Procedure 15"})
        Me.cbProcedure.Location = New System.Drawing.Point(130, 175)
        Me.cbProcedure.Name = "cbProcedure"
        Me.cbProcedure.Size = New System.Drawing.Size(270, 29)
        Me.cbProcedure.TabIndex = 45
        '
        'txtMinGraduation
        '
        Me.txtMinGraduation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinGraduation.Location = New System.Drawing.Point(130, 105)
        Me.txtMinGraduation.Name = "txtMinGraduation"
        Me.txtMinGraduation.Size = New System.Drawing.Size(255, 29)
        Me.txtMinGraduation.TabIndex = 24
        '
        'cbCalibrationInterval
        '
        Me.cbCalibrationInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalibrationInterval.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbCalibrationInterval.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCalibrationInterval.FormattingEnabled = True
        Me.cbCalibrationInterval.Location = New System.Drawing.Point(564, 180)
        Me.cbCalibrationInterval.Name = "cbCalibrationInterval"
        Me.cbCalibrationInterval.Size = New System.Drawing.Size(179, 29)
        Me.cbCalibrationInterval.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(406, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Capacity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(406, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 21)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Calibration Interval"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Manufacturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Model Id"
        '
        'txtModelId
        '
        Me.txtModelId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelId.Location = New System.Drawing.Point(483, 70)
        Me.txtModelId.Name = "txtModelId"
        Me.txtModelId.ReadOnly = True
        Me.txtModelId.Size = New System.Drawing.Size(260, 29)
        Me.txtModelId.TabIndex = 14
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(130, 70)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(255, 29)
        Me.txtManufacturer.TabIndex = 10
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(130, 140)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(356, 29)
        Me.txtLocation.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Location"
        '
        'txtTagId
        '
        Me.txtTagId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagId.Location = New System.Drawing.Point(569, 140)
        Me.txtTagId.Name = "txtTagId"
        Me.txtTagId.Size = New System.Drawing.Size(174, 29)
        Me.txtTagId.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(513, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tag Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Serial No."
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(486, 25)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(280, 29)
        Me.txtSerialNumber.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 21)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Required Tolerance"
        '
        'txtTolerance
        '
        Me.txtTolerance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTolerance.Location = New System.Drawing.Point(172, 42)
        Me.txtTolerance.Name = "txtTolerance"
        Me.txtTolerance.Size = New System.Drawing.Size(206, 29)
        Me.txtTolerance.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(406, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 21)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Test Weights M1"
        '
        'txtTestWeightsM1
        '
        Me.txtTestWeightsM1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestWeightsM1.Location = New System.Drawing.Point(568, 39)
        Me.txtTestWeightsM1.Name = "txtTestWeightsM1"
        Me.txtTestWeightsM1.Size = New System.Drawing.Size(175, 29)
        Me.txtTestWeightsM1.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 21)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Test Weights F1"
        '
        'txtTestWeightsF1
        '
        Me.txtTestWeightsF1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestWeightsF1.Location = New System.Drawing.Point(172, 82)
        Me.txtTestWeightsF1.Name = "txtTestWeightsF1"
        Me.txtTestWeightsF1.Size = New System.Drawing.Size(206, 29)
        Me.txtTestWeightsF1.TabIndex = 44
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(406, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 21)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Calibration Weight 1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 21)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Calibration Weight 2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(406, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 21)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Calibration Weight 3"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight7)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight6)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight5)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight4)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight3)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight2)
        Me.GroupBox3.Controls.Add(Me.txtCalWeight1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtTolerance)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtTestWeightsF1)
        Me.GroupBox3.Controls.Add(Me.txtTestWeightsM1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 501)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(763, 241)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weight Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(406, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 21)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Calibration Weight 7"
        '
        'txtCalWeight7
        '
        Me.txtCalWeight7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight7.Location = New System.Drawing.Point(568, 197)
        Me.txtCalWeight7.Name = "txtCalWeight7"
        Me.txtCalWeight7.Size = New System.Drawing.Size(175, 29)
        Me.txtCalWeight7.TabIndex = 59
        '
        'txtCalWeight6
        '
        Me.txtCalWeight6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight6.Location = New System.Drawing.Point(172, 197)
        Me.txtCalWeight6.Name = "txtCalWeight6"
        Me.txtCalWeight6.Size = New System.Drawing.Size(206, 29)
        Me.txtCalWeight6.TabIndex = 58
        '
        'txtCalWeight5
        '
        Me.txtCalWeight5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight5.Location = New System.Drawing.Point(568, 159)
        Me.txtCalWeight5.Name = "txtCalWeight5"
        Me.txtCalWeight5.Size = New System.Drawing.Size(175, 29)
        Me.txtCalWeight5.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 21)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Calibration Weight 6"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(406, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 21)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Calibration Weight 5"
        '
        'txtCalWeight4
        '
        Me.txtCalWeight4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight4.Location = New System.Drawing.Point(172, 159)
        Me.txtCalWeight4.Name = "txtCalWeight4"
        Me.txtCalWeight4.Size = New System.Drawing.Size(206, 29)
        Me.txtCalWeight4.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 162)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(152, 21)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Calibration Weight 4"
        '
        'txtCalWeight3
        '
        Me.txtCalWeight3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight3.Location = New System.Drawing.Point(568, 120)
        Me.txtCalWeight3.Name = "txtCalWeight3"
        Me.txtCalWeight3.Size = New System.Drawing.Size(175, 29)
        Me.txtCalWeight3.TabIndex = 51
        '
        'txtCalWeight2
        '
        Me.txtCalWeight2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight2.Location = New System.Drawing.Point(172, 120)
        Me.txtCalWeight2.Name = "txtCalWeight2"
        Me.txtCalWeight2.Size = New System.Drawing.Size(206, 29)
        Me.txtCalWeight2.TabIndex = 50
        '
        'txtCalWeight1
        '
        Me.txtCalWeight1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalWeight1.Location = New System.Drawing.Point(568, 79)
        Me.txtCalWeight1.Name = "txtCalWeight1"
        Me.txtCalWeight1.Size = New System.Drawing.Size(175, 29)
        Me.txtCalWeight1.TabIndex = 49
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(813, 660)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(133, 83)
        Me.btnPreview.TabIndex = 51
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1178, 659)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(133, 83)
        Me.btnPrint.TabIndex = 52
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 765)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCertificateNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.printPreviewCtrl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPrint"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents printPreviewCtrl As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerCode As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerAddress1 As TextBox
    Friend WithEvents txtCustomerAddress2 As TextBox
    Friend WithEvents txtCustomerAddress4 As TextBox
    Friend WithEvents txtCustomerAddress3 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCertificateNumber As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModelId As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents ckElectronic As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtMinGraduation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbModel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTagId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTolerance As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCalibrationInterval As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTestWeightsM1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTestWeightsF1 As TextBox
    Friend WithEvents cbProcedure As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCalWeight7 As TextBox
    Friend WithEvents txtCalWeight6 As TextBox
    Friend WithEvents txtCalWeight5 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCalWeight4 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCalWeight3 As TextBox
    Friend WithEvents txtCalWeight2 As TextBox
    Friend WithEvents txtCalWeight1 As TextBox
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
End Class
