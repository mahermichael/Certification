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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Code"
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(193, 121)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        Me.txtCustomerCode.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerCode.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(193, 156)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer Name"
        '
        'txtCustomerAddress1
        '
        Me.txtCustomerAddress1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress1.Location = New System.Drawing.Point(193, 191)
        Me.txtCustomerAddress1.Name = "txtCustomerAddress1"
        Me.txtCustomerAddress1.ReadOnly = True
        Me.txtCustomerAddress1.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerAddress1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer Address 1"
        '
        'txtCustomerAddress2
        '
        Me.txtCustomerAddress2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress2.Location = New System.Drawing.Point(193, 226)
        Me.txtCustomerAddress2.Name = "txtCustomerAddress2"
        Me.txtCustomerAddress2.ReadOnly = True
        Me.txtCustomerAddress2.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerAddress2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer Address 2"
        '
        'txtCustomerAddress4
        '
        Me.txtCustomerAddress4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress4.Location = New System.Drawing.Point(193, 296)
        Me.txtCustomerAddress4.Name = "txtCustomerAddress4"
        Me.txtCustomerAddress4.ReadOnly = True
        Me.txtCustomerAddress4.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerAddress4.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Customer Address 4"
        '
        'txtCustomerAddress3
        '
        Me.txtCustomerAddress3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress3.Location = New System.Drawing.Point(193, 261)
        Me.txtCustomerAddress3.Name = "txtCustomerAddress3"
        Me.txtCustomerAddress3.ReadOnly = True
        Me.txtCustomerAddress3.Size = New System.Drawing.Size(224, 29)
        Me.txtCustomerAddress3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Customer Address 3"
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 691)
        Me.Controls.Add(Me.txtCustomerAddress4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustomerAddress3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCustomerAddress2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustomerAddress1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustomerCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printPreviewCtrl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPrint"
        Me.Text = "Print Certificate"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents printPreviewCtrl As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerCode As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerAddress1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerAddress2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerAddress4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomerAddress3 As TextBox
    Friend WithEvents Label6 As Label
End Class
