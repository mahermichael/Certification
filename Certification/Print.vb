Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Printing
Imports Newtonsoft.Json

Public Class frmPrint

    ''' <summary>
    ''' Unique serial number
    ''' </summary>
    Private _serialNumber As String

    '''' <summary>
    '''' Certificate Object
    '''' </summary>
    Private _certificate As Certificate

    ''' <summary>
    ''' Print Document
    ''' </summary>
    Private _printDoc As PrintDocument

    ''' <summary>
    ''' Machines Array
    ''' </summary>
    Private _machinesArray As JArray

#Region "Form"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByVal cert As Certificate)
        InitializeComponent()
        'LoadCustomerDetails(cert)
        _certificate = cert
        LoadMachineDetails()
        DisplayCertificate()
        CreatePrintDocument()
    End Sub


    Private Sub LoadMachineDetails()
        Try
            Dim json = File.ReadAllText("Data\Machines.json")
            _machinesArray = JArray.Parse(json)
            cbModel.Items.Clear()
            For Each item In _machinesArray
                cbModel.Items.Add(item("Model Description"))
            Next
            ' Set the specific Machine
            For Each machine As JToken In _machinesArray.Where(Function(obj) obj("Model ID").Value(Of String)() = _certificate.ModelId)
                txtModelId.Text = _certificate.ModelId
                txtManufacturer.Text = machine("Manufacturer")
                txtCapacity.Text = machine("Default_Capacity")
                txtMinGraduation.Text = machine("Default_Min_Grad")
                ckElectronic.Checked = machine("Electronic Mechanical").ToString.Equals("E")
                Dim modelIndex As Integer = cbModel.FindString(machine("Model Description"))
                cbModel.SelectedIndex = modelIndex
            Next
            '        _certificate = New Certificate
            '        _certificate.CustomerCode = customer("Code")
            '        _certificate.CustomerName = customer("Name")
            '        _certificate.CustomerAddress1 = customer("Address1")
            '        _certificate.CustomerAddress2 = customer("Address2")
            '        _certificate.CustomerAddress3 = customer("Address3")
            '        _certificate.CustomerAddress4 = customer("Address4")
            '    Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Machine Changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbModelId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModel.SelectedIndexChanged
        For Each machine As JToken In _machinesArray.Where(Function(obj) obj("Model Description").Value(Of String)() = cbModel.SelectedItem.ToString)
            txtModelId.Text = machine("Model ID")
            ' Update the Certificate objects Model Id
            _certificate.ModelId = txtModelId.Text
            txtManufacturer.Text = machine("Manufacturer")
            txtCapacity.Text = machine("Default_Capacity")
            txtMinGraduation.Text = machine("Default_Min_Grad")
            ckElectronic.Checked = machine("Electronic Mechanical").ToString.Equals("E")
        Next
    End Sub



    'Private Sub LoadCustomerDetails(ByVal cert As Certificate)
    '    Dim json As String = File.ReadAllText("Data\Customers.json")
    '    Dim jsonObject As JArray = JArray.Parse(json)
    '    For Each customer As JToken In jsonObject.Where(Function(obj) obj("Code").Value(Of String)() = CustomerCode)
    '        _certificate = New Certificate
    '        _certificate.CustomerCode = customer("Code")
    '        _certificate.CustomerName = customer("Name")
    '        _certificate.CustomerAddress1 = customer("Address1")
    '        _certificate.CustomerAddress2 = customer("Address2")
    '        _certificate.CustomerAddress3 = customer("Address3")
    '        _certificate.CustomerAddress4 = customer("Address4")
    '    Next
    '    DisplayCertificate()
    'End Sub

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

#Region "Helpers"

    Private Sub DisplayCertificate()
        txtCustomerCode.Text = _certificate.CustomerCode
        txtCustomerName.Text = _certificate.CustomerName
        txtCustomerAddress1.Text = _certificate.CustomerAddress1
        txtCustomerAddress2.Text = _certificate.CustomerAddress2
        txtCustomerAddress3.Text = _certificate.CustomerAddress3
        txtCustomerAddress4.Text = _certificate.CustomerAddress4
        txtCertificateNumber.Text = _certificate.CertificateNumber


    End Sub

#End Region


#Region "Printing"

    ''' <summary>
    ''' Print Document
    ''' </summary>
    Private Sub CreatePrintDocument()
        _printDoc = New PrintDocument
        ' Hide Print dialog
        Dim prntController As PrintController = New StandardPrintController()
        _printDoc.PrintController = prntController
        Dim pprSize As New PaperSize("custom", 827, 1170)
        _printDoc.DefaultPageSettings.PaperSize = pprSize
        _printDoc.DefaultPageSettings.Landscape = False
        AddHandler _printDoc.PrintPage, AddressOf PrintDocument1_PrintPage
        printPreviewCtrl.Document = _printDoc
    End Sub

    ''' <summary>
    ''' Print Page Delegate
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim reportFont As Font = New Drawing.Font("Times New Roman", 14)
        Dim json As String = File.ReadAllText("Data\PrintLocations.json")
        Dim jsonObject As JArray = JArray.Parse(json)

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer No")
            e.Graphics.DrawString(_certificate.CustomerCode, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Name")
            e.Graphics.DrawString(_certificate.CustomerName, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address1")
            e.Graphics.DrawString(_certificate.CustomerAddress1, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address2")
            e.Graphics.DrawString(_certificate.CustomerAddress2, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address3")
            e.Graphics.DrawString(_certificate.CustomerAddress3, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address4")
            e.Graphics.DrawString(_certificate.CustomerAddress4, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        'For Each row As DataGridViewRow In Me.dgrdPrintVariables.Rows
        '    If Not (row.IsNewRow) Then
        '        e.Graphics.DrawString(row.Cells("FieldValue").Value.ToString, reportFont, Brushes.Black, row.Cells("xCoordinate").Value.ToString, row.Cells("yCoordinate").Value.ToString)
        '    End If
        'Next
    End Sub


    ''' <summary>
    ''' Save Changes to Certificate
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _certificate.CertificateNumber = txtCertificateNumber.Text
        Try
            Dim json As String = File.ReadAllText("Data\InstalledMachines.json")
            Dim jsonObject As JArray = JArray.Parse(json)

            For Each installedMachine As JToken In jsonObject.Where(Function(obj) obj("SerialNumber").Value(Of String)() = _certificate.SerialNumber)
                installedMachine("CertNumber") = _certificate.CertificateNumber
            Next

            Dim output As String = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented)
            File.WriteAllText("Data\InstalledMachines.json", output)

            MessageBox.Show("Customer Updated")

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Error saving certificate, please try again. " & ex.Message)
        End Try


    End Sub





#End Region


















End Class
