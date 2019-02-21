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
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtMinGraduation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModelId = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'printPreviewCtrl
        '
        Me.printPreviewCtrl.AutoZoom = False
        Me.printPreviewCtrl.Location = New System.Drawing.Point(746, 63)
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
        Me.txtCustomerName.Size = New System.Drawing.Size(569, 29)
        Me.txtCustomerName.TabIndex = 6
        '
        'txtCustomerAddress1
        '
        Me.txtCustomerAddress1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress1.Location = New System.Drawing.Point(11, 70)
        Me.txtCustomerAddress1.Name = "txtCustomerAddress1"
        Me.txtCustomerAddress1.ReadOnly = True
        Me.txtCustomerAddress1.Size = New System.Drawing.Size(306, 29)
        Me.txtCustomerAddress1.TabIndex = 8
        '
        'txtCustomerAddress2
        '
        Me.txtCustomerAddress2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress2.Location = New System.Drawing.Point(333, 70)
        Me.txtCustomerAddress2.Name = "txtCustomerAddress2"
        Me.txtCustomerAddress2.ReadOnly = True
        Me.txtCustomerAddress2.Size = New System.Drawing.Size(369, 29)
        Me.txtCustomerAddress2.TabIndex = 10
        '
        'txtCustomerAddress4
        '
        Me.txtCustomerAddress4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress4.Location = New System.Drawing.Point(333, 105)
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
        Me.txtCustomerAddress3.Size = New System.Drawing.Size(307, 29)
        Me.txtCustomerAddress3.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(514, 598)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(226, 79)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Print And Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
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
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 147)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txtCertificateNumber
        '
        Me.txtCertificateNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertificateNumber.Location = New System.Drawing.Point(103, 22)
        Me.txtCertificateNumber.Name = "txtCertificateNumber"
        Me.txtCertificateNumber.Size = New System.Drawing.Size(199, 29)
        Me.txtCertificateNumber.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbModel)
        Me.GroupBox2.Controls.Add(Me.ckElectronic)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCapacity)
        Me.GroupBox2.Controls.Add(Me.txtMinGraduation)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtModelId)
        Me.GroupBox2.Controls.Add(Me.txtManufacturer)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 179)
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
        Me.cbModel.Size = New System.Drawing.Size(439, 33)
        Me.cbModel.TabIndex = 28
        '
        'ckElectronic
        '
        Me.ckElectronic.AutoSize = True
        Me.ckElectronic.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckElectronic.Location = New System.Drawing.Point(587, 35)
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
        'txtCapacity
        '
        Me.txtCapacity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Location = New System.Drawing.Point(442, 105)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.Size = New System.Drawing.Size(260, 29)
        Me.txtCapacity.TabIndex = 25
        '
        'txtMinGraduation
        '
        Me.txtMinGraduation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinGraduation.Location = New System.Drawing.Point(130, 105)
        Me.txtMinGraduation.Name = "txtMinGraduation"
        Me.txtMinGraduation.ReadOnly = True
        Me.txtMinGraduation.Size = New System.Drawing.Size(187, 29)
        Me.txtMinGraduation.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Capacity"
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
        Me.Label1.Location = New System.Drawing.Point(339, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Model Id"
        '
        'txtModelId
        '
        Me.txtModelId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelId.Location = New System.Drawing.Point(442, 73)
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
        Me.txtManufacturer.Size = New System.Drawing.Size(187, 29)
        Me.txtManufacturer.TabIndex = 10
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 691)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCertificateNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.printPreviewCtrl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPrint"
        Me.Text = "Print Certificate"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
End Class
