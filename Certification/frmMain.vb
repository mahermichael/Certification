Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Printing
Imports Newtonsoft.Json

Public Class frmMain

    Private _dictStaticValues As IDictionary(Of String, String())

    Private _printDoc As PrintDocument

    Private _selectedCustomerRowIndex As Integer = -1

    Private _maxCustomerId As Integer = -1

    Private _addingCustomer As Boolean = False



#Region "Form"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        ' LoadPrintVariables()
        LoadCustomers()
        '  CreatePrintDocument()

    End Sub


    ''' <summary>
    ''' Data folder check
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        Dim path As String = Directory.GetCurrentDirectory() & "\Data"
        If Not (Directory.Exists(path)) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

#End Region




#Region "Customers"

    ''' <summary>
    ''' Parse Customer json file and load customer dgrd
    ''' </summary>
    Private Sub LoadCustomers()

        Try
            Dim json = File.ReadAllText("Data\Customers.json")
            Dim jObject As JArray = JArray.Parse(json)
            Dim MyTable As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jObject.ToString())
            MyTable.TableName = "Test Table"
            dgrdCustomers.DataSource = MyTable
            ' Dim dtTmp As DataTable = jObject
            '   dgrdCustomers.DataSource = jObject
            'dgrdCustomers.D
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

            VScrollBar1.Maximum = dgrdCustomers.Rows.Count
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
        VScrollBar1.Maximum = dgrdCustomers.Rows.Count

    End Sub



    ' Private dsCustomers As DataSet

    ''' <summary>
    ''' Load Customer Details when customer selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgrdCustomers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrdCustomers.CellMouseClick
        If (e.RowIndex > -1) Then
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

            LoadCustomerCerts()
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
                Dim json As String = File.ReadAllText("Data\InstalledMachines.json")
                Dim jsonObject As JArray = JArray.Parse(json)
                For Each InstalledMachine As JToken In jsonObject.Where(Function(obj) obj("CustCode").Value(Of String)() = Me.txtCode.Text)
                    Dim row As DataGridViewRow = Me.dgrdInstalledMachines.Rows(Me.dgrdInstalledMachines.Rows.Add)

                    Dim cert As New Certificate

                    ' Add row to datagrid for selection
                    row.Cells("ModelId").Value = InstalledMachine("ModelId").ToString
                    row.Cells("SerialNumber").Value = InstalledMachine("SerialNumber").ToString
                    row.Cells("CertNumber").Value = InstalledMachine("CertNumber").ToString
                    row.Cells("InstallationDate").Value = InstalledMachine("InstallationDate").ToString

                    ' Main cert details
                    cert.CertificateNumber = InstalledMachine("CertNumber").ToString
                    cert.ModelId = InstalledMachine("ModelId").ToString
                    cert.SerialNumber = InstalledMachine("SerialNumber").ToString
                    cert.InstallationDate = InstalledMachine("InstallationDate").ToString

                    ' Set Customer Details
                    cert.CustomerCode = Me.txtCode.Text
                    cert.CustomerName = Me.txtName.Text
                    cert.CustomerAddress1 = Me.txtAddress1.Text
                    cert.CustomerAddress2 = Me.txtAddress2.Text
                    cert.CustomerAddress3 = Me.txtAddress3.Text
                    cert.CustomerAddress4 = Me.txtAddress4.Text



                    'row.Cells("SalesValue").Value = InstalledMachine("SalesValue").ToString
                    'row.Cells("SupplierInvoice").Value = InstalledMachine("SupplierInvoice").ToString
                    'row.Cells("CustomerInvoice").Value = InstalledMachine("CustomerInvoice").ToString
                    'row.Cells("WeightsMeasureDocketNo").Value = InstalledMachine("WeightsMeasureDocketNo").ToString
                    'row.Cells("GuaranteeExpiryDate").Value = InstalledMachine("GuaranteeExpiryDate").ToString
                    'row.Cells("InService").Value = InstalledMachine("InService").ToString
                    'row.Cells("Location").Value = InstalledMachine("Location").ToString
                    'row.Cells("TagId").Value = InstalledMachine("TagId").ToString
                    'row.Cells("ContractNumber").Value = InstalledMachine("ContractNumber").ToString
                    'row.Cells("CalibrationType").Value = InstalledMachine("CalibrationType").ToString
                    'row.Cells("Capacity").Value = InstalledMachine("Capacity").ToString
                    'row.Cells("MinimumGraduation").Value = InstalledMachine("MinimumGraduation").ToString
                    'row.Cells("SalesPerson").Value = InstalledMachine("SalesPerson").ToString
                    'row.Cells("SelectColumn").Value = InstalledMachine("SelectColumn").ToString
                    'row.Cells("AdhocSelect").Value = InstalledMachine("AdhocSelect").ToString
                    'row.Cells("partinfo").Value = InstalledMachine("partinfo").ToString
                    'row.Cells("Tolerance").Value = InstalledMachine("Tolerance").ToString
                    'View Cert Button
                    row.Cells("ViewCert").Value = "View Cert"
                    row.Cells("ViewCert").Tag = cert
                Next
            End If
            Me.dgrdInstalledMachines.Refresh()
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
                Dim frm As New frmPrint(dgrdInstalledMachines.Rows(e.RowIndex).Cells("ViewCert").Tag, False)
                Dim diaResult As DialogResult
                diaResult = frm.ShowDialog()
                If diaResult = DialogResult.OK Then
                    'Refresh the grid
                    LoadCustomerCerts()
                End If
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
                Dim json As String = File.ReadAllText("Data\Customers.json")
                Dim jsonObject As JArray = JArray.Parse(json)
                If (_addingCustomer) Then
                    'Dim newCust As New JToken
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
                    File.WriteAllText("Data\Customers.json", output)
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
                    VScrollBar1.Maximum = dgrdCustomers.Rows.Count
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
                        File.WriteAllText("Data\Customers.json", output)
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
                    Dim json As String = File.ReadAllText("Data\Customers.json")
                    Dim jsonObject As JArray = JArray.Parse(json)
                    Dim customerToDelete As JToken = jsonObject.FirstOrDefault(Function(obj) obj("Code").Value(Of String)() = txtCode.Text)
                    jsonObject.Remove(customerToDelete)
                    Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
                    File.WriteAllText("Data\Customers.json", output)
                    dgrdCustomers.Rows.RemoveAt(_selectedCustomerRowIndex)
                    ClearCustomerDetails()
                    VScrollBar1.Maximum = dgrdCustomers.Rows.Count
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

#End Region


#Region "Customer Scroll Bar"

    Private Sub dgrdCustomers_Scroll(sender As Object, e As ScrollEventArgs) Handles dgrdCustomers.Scroll
        VScrollBar1.Value = e.NewValue
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        dgrdCustomers.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub
#End Region


    ''' <summary>
    ''' Create New certificate
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewCert_Click(sender As Object, e As EventArgs) Handles btnNewCert.Click
        If Not (String.IsNullOrEmpty(txtCode.Text)) Then
            Dim cert As New Certificate
            cert.CertificateNumber = GenerateUniqueCertNumber()
            cert.CustomerCode = txtCode.Text
            cert.CustomerName = txtName.Text
            cert.CustomerAddress1 = txtAddress1.Text
            cert.CustomerAddress2 = txtAddress2.Text
            cert.CustomerAddress3 = txtAddress3.Text
            cert.CustomerAddress4 = txtAddress4.Text
            Dim frm As New frmPrint(cert, True)
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
    Private Function GenerateUniqueCertNumber() As String
        Dim certNumberSuffix As String = "1"
        For Each row As DataGridViewRow In dgrdInstalledMachines.Rows
            Dim certNumber As String = row.Cells("CertNumber").Value.ToString
            If (certNumber.StartsWith(txtCode.Text & "-")) Then
                Dim num As Integer = CType(certNumber.Replace(txtCode.Text & "-", ""), Integer)
                certNumberSuffix = (num + 1).ToString
            End If
        Next
        Return txtCode.Text & "-" & certNumberSuffix
    End Function


End Class
