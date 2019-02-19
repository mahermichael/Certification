Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Printing
Imports Newtonsoft.Json

Public Class frmPrint

    ''' <summary>
    ''' Unique serial number
    ''' </summary>
    Private _serialNumber As String

    ''' <summary>
    ''' Certificate Object
    ''' </summary>
    Private _certificate As Certificate

    ''' <summary>
    ''' Print Document
    ''' </summary>
    Private _printDoc As PrintDocument

#Region "Form"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByVal customerCode As String, ByVal serialNumber As String)
        InitializeComponent()
        LoadCustomerDetails(customerCode)
        CreatePrintDocument()
    End Sub


    Private Sub LoadCustomerDetails(ByVal customerCode As String)
        Dim json As String = File.ReadAllText("Data\Customers.json")
        Dim jsonObject As JArray = JArray.Parse(json)
        For Each customer As JToken In jsonObject.Where(Function(obj) obj("Code").Value(Of String)() = customerCode)
            _certificate = New Certificate
            _certificate.CustomerCode = customer("Code")
            _certificate.CustomerName = customer("Name")
            _certificate.CustomerAddress1 = customer("Address1")
            _certificate.CustomerAddress2 = customer("Address2")
            _certificate.CustomerAddress3 = customer("Address3")
            _certificate.CustomerAddress4 = customer("Address4")
        Next
        DisplayCertificate()
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

#Region "Helpers"

    Private Sub DisplayCertificate()
        txtCustomerCode.Text = _certificate.CustomerCode
        txtCustomerName.Text = _certificate.CustomerName
        txtCustomerAddress1.Text = _certificate.CustomerAddress1
        txtCustomerAddress2.Text = _certificate.CustomerAddress2
        txtCustomerAddress3.Text = _certificate.CustomerAddress3
        txtCustomerAddress4.Text = _certificate.CustomerAddress4
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
#End Region


















End Class
