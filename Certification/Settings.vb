Imports System.Drawing.Printing
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Settings


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
    Public Sub New()
        InitializeComponent()

        Me.txtBackupLocation.Text = My.Settings.BackupLocation.ToString()
        Me.txtDataLocation.Text = My.Settings.DataLocation.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.BackupLocation = Me.txtBackupLocation.Text
        My.Settings.DataLocation = Me.txtDataLocation.Text
        Me.Close()
    End Sub

    Private Sub btnPerformBackup_Click(sender As Object, e As EventArgs) Handles btnPerformBackup.Click
        If Not (String.IsNullOrEmpty(txtBackupLocation.Text)) Then
            Dim path As String = txtBackupLocation.Text
            If Not (Directory.Exists(path)) Then
                Directory.CreateDirectory(path)
            End If
        End If
    End Sub





#End Region



















End Class
