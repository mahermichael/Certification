Imports System.Drawing.Printing
Imports System.IO
Imports Newtonsoft.Json.Linq

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
    ''' New Certificate
    ''' </summary>
    Private _newRecord As Boolean

    ''' <summary>
    ''' Machines Array
    ''' </summary>
    Private _machinesArray As JArray

#Region "Form"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByVal cert As Certificate, ByVal newRecord As Boolean)
        InitializeComponent()
        'LoadCustomerDetails(cert)
        _certificate = cert
        _newRecord = newRecord
        LoadMachineDetails()
        ' Set The drop downs
        cbCalibrationInterval.SelectedIndex = 1
        cbProcedure.SelectedIndex = 1
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
        txtSerialNumber.Text = _certificate.SerialNumber
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
        ' customer code
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer No")
            e.Graphics.DrawString(txtCustomerCode.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Customer Name
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Name")
            e.Graphics.DrawString(txtCustomerName.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Customer Address 1
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address1")
            e.Graphics.DrawString(txtCustomerAddress1.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Customer Address 2
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address2")
            e.Graphics.DrawString(txtCustomerAddress2.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Customer Address 3
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address3")
            e.Graphics.DrawString(txtCustomerAddress3.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Customer Address 4
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Customer Address4")
            e.Graphics.DrawString(txtCustomerAddress4.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Cert Number
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Cert No")
            e.Graphics.DrawString(txtCertificateNumber.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Serial No
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Serial No")
            e.Graphics.DrawString(txtSerialNumber.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Model
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Model")
            e.Graphics.DrawString(cbModel.SelectedItem.ToString, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Manufacturer
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Manufacturer")
            e.Graphics.DrawString(txtManufacturer.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Tag Identifier
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Tag Identifier")
            e.Graphics.DrawString(txtTagId.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Location
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Location")
            e.Graphics.DrawString(txtLocation.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Electronic
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Electronic")
            e.Graphics.DrawString(IIf(ckElectronic.Checked, "X", ""), reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Procedure
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Procedure")
            e.Graphics.DrawString(cbProcedure.SelectedItem.ToString, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Interval
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Interval")
            e.Graphics.DrawString(cbCalibrationInterval.SelectedItem.ToString, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        ' Capacity
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Capacity")
            e.Graphics.DrawString(txtCapacity.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Min Graduations
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Min Graduations")
            e.Graphics.DrawString(txtMinGraduation.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Test Weights M1
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Test Weights M1")
            e.Graphics.DrawString(txtTestWeightsM1.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Test Weights F1
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Test Weights F1")
            e.Graphics.DrawString(txtTestWeightsF1.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Required Tolerance
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Required Tolerance")
            e.Graphics.DrawString(txtTestWeightsF1.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next

        ' Calibration Weight 1
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 1")
            e.Graphics.DrawString(txtCalWeight1.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 2
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 2")
            e.Graphics.DrawString(txtCalWeight2.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 3
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 3")
            e.Graphics.DrawString(txtCalWeight3.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 4
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 4")
            e.Graphics.DrawString(txtCalWeight4.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 5
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 5")
            e.Graphics.DrawString(txtCalWeight5.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 6
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 6")
            e.Graphics.DrawString(txtCalWeight6.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
        ' Calibration Weight 7
        For Each printLocation As JToken In jsonObject.Where(Function(obj) obj("fieldName").Value(Of String)() = "Calibration Weight 7")
            e.Graphics.DrawString(txtCalWeight7.Text, reportFont, Brushes.Black, printLocation("fromLeft"), printLocation("fromTop"))
        Next
    End Sub


    ''' <summary>
    ''' Save Changes to Certificate
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Print
        ' _printDoc.Print()


        'Save cert
        _certificate.CertificateNumber = txtCertificateNumber.Text
        Try
            Dim json As String = File.ReadAllText("Data\InstalledMachines.json")
            Dim jsonObject As JArray = JArray.Parse(json)
            If (_newRecord) Then
                Dim newInstalledMachine As New JObject
                newInstalledMachine("SerialNumber") = txtSerialNumber.Text
                newInstalledMachine("CustCode") = txtCustomerCode.Text.ToString
                newInstalledMachine("ModelId") = txtModelId.Text.ToString
                newInstalledMachine("CertNumber") = txtCertificateNumber.Text.ToString

                newInstalledMachine("InstallationDate") = ""  ' Get todays Date
                newInstalledMachine("SalesValue") = "0"
                newInstalledMachine("SupplierInvoice") = ""
                newInstalledMachine("CustomerInvoice") = ""
                newInstalledMachine("WeightsMeasureDocketNo") = ""

                newInstalledMachine("GuaranteeExpiryDate") = ""
                Dim inService As String = "Yes"
                newInstalledMachine("InService") = inService
                newInstalledMachine("Location") = txtLocation.Text.ToString
                newInstalledMachine("TagId") = txtTagId.Text.ToString
                newInstalledMachine("ContractNumber") = ""
                newInstalledMachine("CalibrationType") = ""
                newInstalledMachine("Capacity") = txtCapacity.Text.ToString
                newInstalledMachine("MinimumGraduation") = txtMinGraduation.Text.ToString
                newInstalledMachine("SalesPerson") = ""
                newInstalledMachine("SelectColumn") = "FALSE"
                newInstalledMachine("AdhocSelect") = "TRUE"
                newInstalledMachine("partinfo") = ""
                newInstalledMachine("Tolerance") = txtTolerance.Text.ToString



                jsonObject.Add(newInstalledMachine)
            Else
                For Each installedMachine As JToken In jsonObject.Where(Function(obj) obj("SerialNumber").Value(Of String)() = _certificate.SerialNumber)
                    installedMachine("CertNumber") = _certificate.CertificateNumber
                Next
            End If

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
