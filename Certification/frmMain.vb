Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Printing
Imports Newtonsoft.Json

Public Class frmMain

    Private _dictStaticValues As IDictionary(Of String, String())

    Private _printDoc As PrintDocument

    Private _selectedCustomerRowIndex As Integer = -1

    Private _selectedMachineRowIndex As Integer = -1

    Private _maxCustomerId As Integer = -1

    Private _maxMachineId As Integer = -1

    Private _addingCustomer As Boolean = False

    Private _addingMachine As Boolean = False




#Region "Form"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        ' Load Customers
        LoadCustomers()
        ' Load Machines
        LoadMachines()
        'tabCertPages.TabPages.RemoveAt(1)
        Me.tabCertPages.SelectedIndex = 0

    End Sub


    ''' <summary>
    ''' Data folder check
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        If (String.IsNullOrEmpty(My.Settings.DataLocation1)) Then
            Dim path As String = Directory.GetCurrentDirectory() & "\Data"
            If Not (Directory.Exists(path)) Then
                Directory.CreateDirectory(path)
            End If
            My.Settings.DataLocation1 = path
        End If
        If (String.IsNullOrEmpty(My.Settings.BackupLocation1)) Then
            Dim path As String = Directory.GetCurrentDirectory() & "\Backup"
            If Not (Directory.Exists(path)) Then
                Directory.CreateDirectory(path)
            End If
            My.Settings.BackupLocation1 = path
        End If
    End Sub

#End Region

#Region "Customers"

    ''' <summary>
    ''' Parse Customer json file and load customer dgrd
    ''' </summary>
    Private Sub LoadCustomers()

        Try
            Dim json = File.ReadAllText(My.Settings.DataLocation1 & "\Customers.json")
            Dim jObject As JArray = JArray.Parse(json)
            Dim MyTable As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jObject.ToString())
            MyTable.TableName = "Test Table"
            dgrdCustomers.DataSource = MyTable
            dgrdCustomers.Columns("Address1").Visible = False
            dgrdCustomers.Columns("Address2").Visible = False
            dgrdCustomers.Columns("Address3").Visible = False
            dgrdCustomers.Columns("Address4").Visible = False
            dgrdCustomers.Columns("Telephone").Visible = False
            dgrdCustomers.Columns("Fax").Visible = False
            dgrdCustomers.Columns("Contacts").Visible = False
            dgrdCustomers.Columns("Notes").Visible = False
            ' Set themax customer Id for adding new customers
            SetMaxCustomerId()

            ScrollBarCustomers.Maximum = dgrdCustomers.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetMaxCustomerId()
        For x As Integer = 0 To dgrdCustomers.Rows.Count - 1
            If (_maxCustomerId < dgrdCustomers.Rows(x).Cells("Code").Value) Then
                _maxCustomerId = dgrdCustomers.Rows(x).Cells(0).Value
            End If
        Next
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        If (searchByName.Checked) Then
            CType(dgrdCustomers.DataSource, DataTable).DefaultView.RowFilter = String.Format("Name like '{0}%'", txtSearchCustomer.Text)
        Else
            CType(dgrdCustomers.DataSource, DataTable).DefaultView.RowFilter = String.Format("Code like '{0}%'", txtSearchCustomer.Text)
        End If
        ScrollBarCustomers.Maximum = dgrdCustomers.Rows.Count

    End Sub


    ''' <summary>
    ''' Load Customer Details when customer selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgrdCustomers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdCustomers.CellMouseClick
        If (e.RowIndex > -1) Then
            Cursor.Current = Cursors.WaitCursor
            _selectedCustomerRowIndex = e.RowIndex
            Me.txtCode.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Code").Value.ToString
            Me.txtName.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Name").Value.ToString
            Me.txtAddress1.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Address1").Value.ToString
            Me.txtAddress2.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Address2").Value.ToString
            Me.txtAddress3.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Address3").Value.ToString
            Me.txtAddress4.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Address4").Value.ToString
            Me.txtTelephone.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Telephone").Value.ToString
            Me.txtFax.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Fax").Value.ToString
            Me.txtContacts.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Contacts").Value.ToString
            Me.txtNotes.Text = dgrdCustomers.Rows(e.RowIndex).Cells("Notes").Value.ToString
            lblInstalledMachines.Text = "Installed Machines For : " & Me.txtName.Text
            LoadCustomerCerts()
            Cursor.Current = Cursors.Default
        End If
    End Sub


    ''' <summary>
    ''' Load the relative Customer Certs
    ''' </summary>
    Private Sub LoadCustomerCerts()
        ' Refresh certs
        dgrdInstalledMachines.Rows.Clear()
        Try
            If Not (String.IsNullOrEmpty(Me.txtCode.Text)) Then
                Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\InstalledMachines.json")
                Dim jsonObject As JArray = JArray.Parse(json)
                For Each InstalledMachine As JToken In jsonObject.Where(Function(obj) obj("CustCode").Value(Of String)() = Me.txtCode.Text)
                    Dim row As DataGridViewRow = Me.dgrdInstalledMachines.Rows(Me.dgrdInstalledMachines.Rows.Add)

                    Dim cert As New Certificate

                    ' Add row to datagrid for selection
                    row.Cells("ModelId").Value = InstalledMachine("ModelId").ToString
                    row.Cells("SerialNumber").Value = InstalledMachine("SerialNumber").ToString
                    row.Cells("CertNumber").Value = InstalledMachine("CertNumber").ToString
                    row.Cells("TagId").Value = InstalledMachine("TagId").ToString
                    ' Main cert details
                    cert.CertificateNumber = InstalledMachine("CertNumber").ToString
                    cert.ModelId = InstalledMachine("ModelId").ToString
                    cert.SerialNumber = InstalledMachine("SerialNumber").ToString
                    cert.TagId = InstalledMachine("TagId").ToString

                    ' Set Customer Details
                    cert.CustomerCode = Me.txtCode.Text
                    cert.CustomerName = Me.txtName.Text
                    cert.CustomerAddress1 = Me.txtAddress1.Text
                    cert.CustomerAddress2 = Me.txtAddress2.Text
                    cert.CustomerAddress3 = Me.txtAddress3.Text
                    cert.CustomerAddress4 = Me.txtAddress4.Text

                    ' Secondary Cert Details
                    cert.Location = InstalledMachine("Location").ToString
                    cert.Procedure = InstalledMachine("Procedure").ToString
                    cert.CalibrationInterval = InstalledMachine("Calibration Interval").ToString
                    cert.Capacity = InstalledMachine("Capacity").ToString
                    cert.MinGraduations = InstalledMachine("Min Graduations").ToString
                    cert.RequiredTolerance = InstalledMachine("Required Tolerance").ToString
                    cert.TestWeightM1 = InstalledMachine("Test Weights M1").ToString
                    cert.TestWeightsF1 = InstalledMachine("Test Weights F1").ToString
                    cert.CalibrationWeight1 = InstalledMachine("Calibration Weight 1").ToString
                    cert.CalibrationWeight2 = InstalledMachine("Calibration Weight 2").ToString
                    cert.CalibrationWeight3 = InstalledMachine("Calibration Weight 3").ToString
                    cert.CalibrationWeight4 = InstalledMachine("Calibration Weight 4").ToString
                    cert.CalibrationWeight5 = InstalledMachine("Calibration Weight 5").ToString
                    cert.CalibrationWeight6 = InstalledMachine("Calibration Weight 6").ToString
                    cert.CalibrationWeight7 = InstalledMachine("Calibration Weight 7").ToString

                    'View Cert Button
                    row.Cells("ViewCert").Value = "View Cert"
                    row.Cells("ViewCert").Tag = cert

                    'print button
                    row.Cells("Print").Value = "Select To Print"
                    row.Cells("Print").Tag = 0
                Next
            End If
            Me.dgrdInstalledMachines.Refresh()
            dgrdInstalledMachines.ClearSelection()
        Catch ex As Exception
            Console.WriteLine("Update Error : " + ex.Message.ToString())
        End Try
    End Sub


    ''' <summary>
    ''' Installed Machines - View Cert
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgrdInstalledMachines_CellClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdInstalledMachines.CellMouseClick
        If (e.RowIndex > -1) Then
            If (e.ColumnIndex = dgrdInstalledMachines.Columns("ViewCert").Index) Then
                Dim frm As New frmPrint(dgrdInstalledMachines.Rows(e.RowIndex).Cells("ViewCert").Tag, False, False)
                Dim diaResult As DialogResult
                diaResult = frm.ShowDialog()
                If diaResult = DialogResult.OK Then
                    'Refresh the grid
                    LoadCustomerCerts()
                End If
            End If
            If (e.ColumnIndex = dgrdInstalledMachines.Columns("Print").Index) Then
                Dim buttonCell As DataGridViewButtonCell = dgrdInstalledMachines.Rows(e.RowIndex).Cells("Print")
                If buttonCell.Tag = 0 Then
                    buttonCell.Style.BackColor = System.Drawing.Color.LightGreen
                    buttonCell.Tag = 1
                    buttonCell.Selected = False
                    dgrdInstalledMachines.Refresh()
                Else
                    buttonCell.Style.BackColor = System.Drawing.Color.White
                    buttonCell.Tag = 0
                    buttonCell.Selected = False
                    dgrdInstalledMachines.Refresh()
                End If
                ' buttonCell.FlatStyle = FlatStyle.Popup
                buttonCell.Selected = False
                dgrdInstalledMachines.Refresh()
            End If
        End If
    End Sub


    ''' <summary>
    ''' Save Customers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        If (ValidateCustomer()) Then
            Try
                Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\Customers.json")
                Dim jsonObject As JArray = JArray.Parse(json)
                If (_addingCustomer) Then
                    Dim newCustomerMember As String = "{ 'Code': '" & Me.txtCode.Text &
                        "','Name': '" & txtName.Text &
                        "','Address1': '" & txtAddress1.Text &
                        "','Address2': '" & txtAddress2.Text &
                        "','Address3': '" & txtAddress3.Text &
                        "','Address4': '" & txtAddress4.Text &
                        "','Telephone': '" & txtTelephone.Text &
                        "','Fax': '" & txtFax.Text &
                        "','Contacts': '" & txtContacts.Text &
                        "','Notes': '" & txtNotes.Text &
                        "'}"
                    Dim newCompany As JObject = JObject.Parse(newCustomerMember)
                    jsonObject.Add(newCompany)
                    Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                    File.WriteAllText(My.Settings.DataLocation1 & "\Customers.json", output)
                    _maxCustomerId += 1
                    ' Dim row As DataGridViewRow = Me.dgrdCustomers.Rows(Me.dgrdCustomers.Rows.Add)
                    Dim dtCustomers As DataTable = dgrdCustomers.DataSource

                    Dim row As DataRow = dtCustomers.NewRow

                    row("Code") = txtCode.Text
                    row("Name") = txtName.Text
                    row("Address1") = txtAddress1.Text
                    row("Address2") = txtAddress2.Text
                    row("Address3") = txtAddress3.Text
                    row("Address4") = txtAddress4.Text
                    row("Telephone") = txtTelephone.Text
                    row("Fax") = txtFax.Text
                    row("Contacts") = txtContacts.Text
                    row("Notes") = txtNotes.Text
                    dtCustomers.Rows.Add(row)

                    ' Refresh the grid with the new row
                    dgrdCustomers.EndEdit()
                    dgrdCustomers.Refresh()
                    ScrollBarCustomers.Maximum = dgrdCustomers.Rows.Count
                    ' Scroll to the bottom of the grid to show the new row
                    _selectedCustomerRowIndex = dgrdCustomers.RowCount - 1
                    dgrdCustomers.FirstDisplayedScrollingRowIndex = _selectedCustomerRowIndex

                    MessageBox.Show("New Customer Created")
                    _addingCustomer = False
                Else
                    Try
                        For Each customer As JToken In jsonObject.Where(Function(obj) obj("Code").Value(Of String)() = txtCode.Text)
                            customer("Name") = txtName.Text
                            customer("Address1") = txtAddress1.Text
                            customer("Address2") = txtAddress2.Text
                            customer("Address3") = txtAddress3.Text
                            customer("Address4") = txtAddress4.Text
                            customer("Telephone") = txtTelephone.Text
                            customer("Fax") = txtFax.Text
                            customer("Contacts") = txtContacts.Text
                            customer("Notes") = txtNotes.Text
                        Next

                        Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                        File.WriteAllText(My.Settings.DataLocation1 & "\Customers.json", output)
                        ' Update the open customer grid also
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Name").Value = txtName.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Address1").Value = txtAddress1.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Address2").Value = txtAddress2.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Address3").Value = txtAddress3.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Address4").Value = txtAddress4.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Telephone").Value = txtTelephone.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Fax").Value = txtFax.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Contacts").Value = txtContacts.Text
                        dgrdCustomers.Rows(_selectedCustomerRowIndex).Cells("Notes").Value = txtNotes.Text
                        MessageBox.Show("Customer Updated")
                    Catch ex As Exception
                        MessageBox.Show("Update Error : " + ex.Message.ToString() + " Please try again.")
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    ''' <summary>
    ''' Delete Customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If Not (String.IsNullOrEmpty(txtName.Text)) Then
            Dim result As Integer = MessageBox.Show("Do you wish to Delete Customer " & txtName.Text, "Delete Customer", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\Customers.json")
                    Dim jsonObject As JArray = JArray.Parse(json)
                    Dim customerToDelete As JToken = jsonObject.FirstOrDefault(Function(obj) obj("Code").Value(Of String)() = txtCode.Text)
                    jsonObject.Remove(customerToDelete)
                    Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                    File.WriteAllText(My.Settings.DataLocation1 & "\Customers.json", output)
                    dgrdCustomers.Rows.RemoveAt(_selectedCustomerRowIndex)
                    ClearCustomerDetails()
                    ScrollBarCustomers.Maximum = dgrdCustomers.Rows.Count
                    MessageBox.Show("Customer deleted")
                Catch ex As Exception
                    Console.WriteLine("Error deleting Customer : " + ex.Message.ToString())
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub


    ''' <summary>
    ''' Validate Customer details
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateCustomer() As Boolean
        If (String.IsNullOrEmpty(txtCode.Text)) Then
            MessageBox.Show("Customer Code Empty.")
            Return False
        ElseIf (String.IsNullOrEmpty(txtName.Text)) Then
            MessageBox.Show("Please enter a Customer Name.")
            Return False
        End If
        Return True
    End Function


    ''' <summary>
    ''' Add Customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        _addingCustomer = True
        ' Clear all fields
        ClearCustomerDetails()
        txtCode.Text = _maxCustomerId + 1
    End Sub

    Private Sub ClearCustomerDetails()
        txtCode.Clear()
        txtName.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtAddress3.Clear()
        txtAddress4.Clear()
        txtContacts.Clear()
        txtFax.Clear()
        txtTelephone.Clear()
        txtNotes.Clear()
    End Sub


    ''' <summary>
    ''' Create New certificate
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewCert_Click(sender As Object, e As EventArgs) Handles btnNewCert.Click
        If Not (String.IsNullOrEmpty(txtCode.Text)) Then
            Dim cert As New Certificate
            cert.CertificateNumber = GenerateUniqueCertNumber("1")
            cert.CustomerCode = txtCode.Text
            cert.CustomerName = txtName.Text
            cert.CustomerAddress1 = txtAddress1.Text
            cert.CustomerAddress2 = txtAddress2.Text
            cert.CustomerAddress3 = txtAddress3.Text
            cert.CustomerAddress4 = txtAddress4.Text
            Dim frm As New frmPrint(cert, True, False)
            Dim diaResult As DialogResult
            diaResult = frm.ShowDialog()
            If diaResult = DialogResult.OK Then
                'Refresh the grid
                LoadCustomerCerts()
            End If
        End If
    End Sub


    ''' <summary>
    ''' Generate Unique Cert Number
    ''' </summary>
    ''' <returns></returns>
    Private Function GenerateUniqueCertNumber(ByVal certNumberSuffix As String) As String

        For Each row As DataGridViewRow In dgrdInstalledMachines.Rows
            Dim certNumber As String = row.Cells("CertNumber").Value.ToString
            If (certNumber.StartsWith(txtCode.Text & "-")) Then
                Dim num As Integer = CType(certNumber.Replace(txtCode.Text & "-", ""), Integer)
                certNumberSuffix = (num + 1).ToString
            End If
        Next
        Return txtCode.Text & "-" & certNumberSuffix
    End Function

    Private Sub dgrdCustomers_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgrdCustomers.DataBindingComplete
        dgrdCustomers.ClearSelection()
    End Sub

#End Region

#Region "Customer Scroll Bar"

    Private Sub dgrdCustomers_Scroll(sender As Object, e As ScrollEventArgs) Handles dgrdCustomers.Scroll
        ScrollBarCustomers.Value = e.NewValue
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBarCustomers.Scroll
        dgrdCustomers.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

#End Region

#Region "Machines"

    ''' <summary>
    ''' Parse Machines json file and load machines dgrd
    ''' </summary>
    Private Sub LoadMachines()
        Try
            Dim json = File.ReadAllText(My.Settings.DataLocation1 & "\Machines.json")
            Dim jObject As JArray = JArray.Parse(json)
            Dim MyTable As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jObject.ToString())
            MyTable.TableName = "Machines Table"
            dgrdMachines.DataSource = MyTable
            ' Set the max machine Id for adding new machines
            SetMaxMachineId()
            ScrollbarMachines.Maximum = dgrdMachines.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''' <summary>
    '''  Set the Max Machine Id for adding new Machines
    ''' </summary>
    Private Sub SetMaxMachineId()
        For x As Integer = 0 To dgrdMachines.Rows.Count - 1
            If (IsNumeric(dgrdMachines.Rows(x).Cells("Model ID").Value)) Then
                If (_maxMachineId < dgrdMachines.Rows(x).Cells("Model ID").Value) Then
                    _maxMachineId = dgrdMachines.Rows(x).Cells(0).Value
                End If
            Else
                Continue For
            End If
        Next
    End Sub


    ''' <summary>
    ''' Load Machine based on the Selected Machine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgrdMachines_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdMachines.CellMouseClick
        If (e.RowIndex > -1) Then
            Cursor.Current = Cursors.WaitCursor
            _selectedMachineRowIndex = e.RowIndex
            Me.txtModelId.Text = dgrdMachines.Rows(e.RowIndex).Cells("Model Id").Value.ToString
            Me.txtModelDescription.Text = dgrdMachines.Rows(e.RowIndex).Cells("Model Description").Value.ToString
            Me.txtManufacturer.Text = dgrdMachines.Rows(e.RowIndex).Cells("Manufacturer").Value.ToString
            Me.txtCertType.Text = dgrdMachines.Rows(e.RowIndex).Cells("Cert Type").Value.ToString
            Me.txtElectronicMechanical.Text = dgrdMachines.Rows(e.RowIndex).Cells("Electronic Mechanical").Value.ToString
            Me.txtDefaultCapacity.Text = dgrdMachines.Rows(e.RowIndex).Cells("Default_Capacity").Value.ToString
            Me.txtDefaultMinGrad.Text = dgrdMachines.Rows(e.RowIndex).Cells("Default_Min_Grad").Value.ToString
            Me.txtInservice.Text = dgrdMachines.Rows(e.RowIndex).Cells("Inservice").Value.ToString
            Cursor.Current = Cursors.Default
        End If
    End Sub

#End Region


#Region "Machines Scroll Bar"

    Private Sub dgrdMachines_Scroll(sender As Object, e As ScrollEventArgs) Handles dgrdMachines.Scroll
        ScrollbarMachines.Value = e.NewValue
    End Sub

    Private Sub ScrollbarMachines_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollbarMachines.Scroll
        dgrdMachines.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'pnlCerts.Location = New Point(pnlCerts.Location.X - 740, pnlCerts.Location.Y)


    '    'For i As Integer = -(pnlCerts.Width) To 0 Step 1
    '    '    pnlCerts.Location = New Point(i, pnlCerts.Location.Y)
    '    'Next

    '    For i As Integer = 0 To 100
    '        pnlCerts.Location = New Point(pnlCerts.Location.X - i, pnlCerts.Location.Y)
    '        System.Threading.Thread.Sleep(10)
    '    Next



    '    '  While i As Interger = -pnlCerts.Width 

    '    '     For Int() i = -(panel2.Width); i < 0; i++)

    '    'panel2.Location = New Point(i, panel2.Location.Y);

    'End Sub

#End Region

#Region "Painting Override"

    'Public Class MyButtonCell
    '    Inherits DataGridViewButtonCell

    '    'Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
    '    '    ButtonRenderer.DrawButton(graphics, cellBounds, formattedValue.ToString(), New Font("Comic Sans MS", 9.0F, FontStyle.Bold), True, System.Windows.Forms.VisualStyles.PushButtonState.[Default])
    '    'End Sub
    'End Class

#End Region


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
            Dim frm As New Settings()
            Dim diaResult As DialogResult
            diaResult = frm.ShowDialog()
            If diaResult = DialogResult.OK Then
                'Refresh the grid
                LoadCustomerCerts()
            End If
        End Sub


        Private Sub btnAddNewMachine_Click(sender As Object, e As EventArgs) Handles btnAddNewMachine.Click
            _addingMachine = True
            ' Clear all fields
            ClearMachineDetails()
            txtModelId.Text = _maxMachineId + 1
        End Sub


        Private Sub ClearMachineDetails()
            Me.txtModelDescription.Clear()
            Me.txtManufacturer.Clear()
            Me.txtCertType.Clear()
            Me.txtElectronicMechanical.Clear()
            Me.txtDefaultCapacity.Clear()
            Me.txtDefaultMinGrad.Clear()
            Me.txtInservice.Clear()
        End Sub

        Private Sub btnSaveMachines_Click(sender As Object, e As EventArgs) Handles btnSaveMachines.Click
            If (ValidateMachine()) Then
                Try
                    Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\Machines.json")
                    Dim jsonObject As JArray = JArray.Parse(json)
                    If (_addingMachine) Then
                        Dim newMachineMember As String = "{ 'Model ID': '" & Me.txtModelId.Text &
                            "','Model Description': '" & txtModelDescription.Text &
                            "','Manufacturer': '" & txtManufacturer.Text &
                            "','Cert Type': '" & txtCertType.Text &
                            "','Electronic Mechanical': '" & txtElectronicMechanical.Text &
                            "','Default_Capacity': '" & txtDefaultCapacity.Text &
                            "','Default_Min_Grad': '" & txtDefaultMinGrad.Text &
                            "','Inservice': '" & txtInservice.Text &
                            "'}"
                        Dim newMachine As JObject = JObject.Parse(newMachineMember)
                        jsonObject.Add(newMachine)
                        Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                        File.WriteAllText(My.Settings.DataLocation1 & "\Machines.json", output)
                        _maxMachineId += 1

                        Dim dtMachines As DataTable = dgrdMachines.DataSource

                        Dim row As DataRow = dtMachines.NewRow

                        row("Model ID") = txtModelId.Text
                        row("Model Description") = txtModelDescription.Text
                        row("Manufacturer") = txtManufacturer.Text
                        row("Cert Type") = txtCertType.Text
                        row("Electronic Mechanical") = txtElectronicMechanical.Text
                        row("Default_Capacity") = txtDefaultCapacity.Text
                        row("Default_Min_Grad") = txtDefaultMinGrad.Text
                        row("Inservice") = txtInservice.Text
                        dtMachines.Rows.Add(row)

                        ' Refresh the grid with the new row
                        dgrdMachines.EndEdit()
                        dgrdMachines.Refresh()
                        ScrollbarMachines.Maximum = dgrdMachines.Rows.Count
                        ' Scroll to the bottom of the grid to show the new row
                        _selectedMachineRowIndex = dgrdMachines.RowCount - 1
                        dgrdMachines.FirstDisplayedScrollingRowIndex = _selectedMachineRowIndex

                        MessageBox.Show("New Machine Created")
                        _addingMachine = False
                    Else
                        Try
                            For Each machine As JToken In jsonObject.Where(Function(obj) obj("Model ID").Value(Of String)() = txtModelId.Text)
                                machine("Model Description") = txtModelDescription.Text
                                machine("Manufacturer") = txtManufacturer.Text
                                machine("Cert Type") = txtCertType.Text
                                machine("Electronic Mechanical") = txtElectronicMechanical.Text
                                machine("Default_Capacity") = txtDefaultCapacity.Text
                                machine("Default_Min_Grad") = txtDefaultMinGrad.Text
                                machine("Inservice") = txtInservice.Text
                            Next

                            Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                            File.WriteAllText(My.Settings.DataLocation1 & "\Machines.json", output)
                            ' Update the open machines grid also
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Model Description").Value = txtModelDescription.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Manufacturer").Value = txtManufacturer.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Cert Type").Value = txtCertType.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Electronic Mechanical").Value = txtElectronicMechanical.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Default_Capacity").Value = txtDefaultCapacity.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Default_Min_Grad").Value = txtDefaultMinGrad.Text
                            dgrdMachines.Rows(_selectedMachineRowIndex).Cells("Inservice").Value = txtInservice.Text
                            MessageBox.Show("Machine Updated")
                        Catch ex As Exception
                            MessageBox.Show("Update Error : " + ex.Message.ToString() + " Please try again.")
                        End Try
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End Sub

        Private Function ValidateMachine() As Boolean
            If (String.IsNullOrEmpty(txtModelDescription.Text)) Then
                MessageBox.Show("Model Description Empty.")
                Return False
            End If
            Return True
        End Function

        Private Sub btnDeleteMachine_Click(sender As Object, e As EventArgs) Handles btnDeleteMachine.Click
            If Not (String.IsNullOrEmpty(txtModelDescription.Text)) Then
                Dim result As Integer = MessageBox.Show("Do you wish to Delete Machine " & txtModelDescription.Text, "Delete Machine", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\Machines.json")
                        Dim jsonObject As JArray = JArray.Parse(json)
                        Dim machineToDelete As JToken = jsonObject.FirstOrDefault(Function(obj) obj("Model ID").Value(Of String)() = txtCode.Text)
                        jsonObject.Remove(machineToDelete)
                        Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                        File.WriteAllText(My.Settings.DataLocation1 & "\Machines.json", output)
                        dgrdMachines.Rows.RemoveAt(_selectedMachineRowIndex)
                        ClearMachineDetails()
                        ScrollbarMachines.Maximum = dgrdMachines.Rows.Count
                        MessageBox.Show("Machine deleted")
                    Catch ex As Exception
                        MessageBox.Show("Error deleting Machine : " + ex.Message.ToString())
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub txtMachineSearch_TextChanged(sender As Object, e As EventArgs) Handles txtMachineSearch.TextChanged
            If (searchByMachineName.Checked) Then
                CType(dgrdMachines.DataSource, DataTable).DefaultView.RowFilter = String.Format("[Model Description] like '{0}%'", txtMachineSearch.Text)
            Else
                CType(dgrdMachines.DataSource, DataTable).DefaultView.RowFilter = String.Format("[Model ID] like '{0}%'", txtMachineSearch.Text)
            End If
            ScrollbarMachines.Maximum = dgrdMachines.Rows.Count
        End Sub

    Private Sub btnPrintSelectedCerts_Click(sender As Object, e As EventArgs) Handles btnPrintSelectedCerts.Click
        If Not (String.IsNullOrEmpty(txtCode.Text)) Then
            Dim i = 0
            For Each row As DataGridViewRow In dgrdInstalledMachines.Rows
                If row.Cells("Print").Tag = 1 Then
                    i += 1
                End If
            Next
            If i > 0 Then
                Dim frm As New CalibrationInterval(i)
                Dim diaResult As DialogResult
                diaResult = frm.ShowDialog()
                If diaResult = DialogResult.OK Then
                    Dim calibrationInterval As String = frm.Interval
                    Dim certIndex As Integer = 1
                    For Each row As DataGridViewRow In dgrdInstalledMachines.Rows
                        If row.Cells("Print").Tag = 1 Then
                            Dim cert As New Certificate
                            cert = CopyCertToCert(row.Cells("ViewCert").Tag, cert)
                            cert.CertificateNumber = GenerateUniqueCertNumber(certIndex.ToString)
                            cert.CalibrationInterval = calibrationInterval
                            Dim frmPrint As New frmPrint(cert, True, True)
                            Dim diaPrintResult As DialogResult
                            diaPrintResult = frmPrint.ShowDialog()
                            If diaPrintResult = DialogResult.OK Or diaPrintResult = DialogResult.Cancel Then
                                'Refresh the grid
                                certIndex += 1
                                Continue For
                            End If
                        End If
                    Next
                    'Refresh the grid
                    LoadCustomerCerts()
                Else
                    MessageBox.Show("Print Job Cancelled")
                    Exit Sub
                End If

            Else
                MessageBox.Show("Please Select a Cert to Print")
            End If
        End If
    End Sub

    Private Function CopyCertToCert(ByVal certToCopy As Certificate, ByVal newCert As Certificate) As Certificate
        newCert.CustomerCode = certToCopy.CustomerCode
        newCert.CustomerName = certToCopy.CustomerName
        newCert.CustomerAddress1 = certToCopy.CustomerAddress1
        newCert.CustomerAddress2 = certToCopy.CustomerAddress2
        newCert.CustomerAddress3 = certToCopy.CustomerAddress3
        newCert.CustomerAddress4 = certToCopy.CustomerAddress4

        ' Main Details
        'newCert.CertificateNumber =
        newCert.ModelId = certToCopy.ModelId
        newCert.SerialNumber = certToCopy.SerialNumber
        newCert.TagId = certToCopy.TagId

        ' Secondary Details
        newCert.Location = certToCopy.Location
        newCert.Procedure = certToCopy.Procedure
        newCert.CalibrationInterval = certToCopy.CalibrationInterval
        newCert.Capacity = certToCopy.Capacity
        newCert.MinGraduations = certToCopy.MinGraduations
        newCert.RequiredTolerance = certToCopy.RequiredTolerance
        newCert.TestWeightM1 = certToCopy.TestWeightM1
        newCert.TestWeightsF1 = certToCopy.TestWeightsF1
        newCert.CalibrationWeight1 = certToCopy.CalibrationWeight1
        newCert.CalibrationWeight2 = certToCopy.CalibrationWeight2
        newCert.CalibrationWeight3 = certToCopy.CalibrationWeight3
        newCert.CalibrationWeight4 = certToCopy.CalibrationWeight4
        newCert.CalibrationWeight5 = certToCopy.CalibrationWeight5
        newCert.CalibrationWeight6 = certToCopy.CalibrationWeight6
        newCert.CalibrationWeight7 = certToCopy.CalibrationWeight7
        Return newCert
    End Function




    Private Sub dgrdInstalledMachines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrdInstalledMachines.CellDoubleClick
        If Not (dgrdInstalledMachines.Rows(e.RowIndex).Cells("ViewCert").ColumnIndex = e.ColumnIndex Or dgrdInstalledMachines.Rows(e.RowIndex).Cells("Print").ColumnIndex = e.ColumnIndex) Then
            Dim result As Integer = MessageBox.Show("Do you wish to this Cert ?", "Delete Certificate", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim json As String = File.ReadAllText(My.Settings.DataLocation1 & "\InstalledMachines.json")
                    Dim jsonObject As JArray = JArray.Parse(json)
                    Dim certToDelete As JToken = jsonObject.FirstOrDefault(Function(obj) obj("SerialNumber").Value(Of String)() = dgrdInstalledMachines.Rows(e.RowIndex).Cells("SerialNumber").Value And obj("CertNumber").Value(Of String)() = dgrdInstalledMachines.Rows(e.RowIndex).Cells("CertNumber").Value)
                    jsonObject.Remove(certToDelete)
                    Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                    File.WriteAllText(My.Settings.DataLocation1 & "\InstalledMachines.json", output)
                    dgrdInstalledMachines.Rows.RemoveAt(e.RowIndex)
                    ScrollBarCustomers.Maximum = dgrdInstalledMachines.Rows.Count
                    MessageBox.Show("Certificate deleted")
                Catch ex As Exception
                    Console.WriteLine("Error deleting certificate : " + ex.Message.ToString())
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class
