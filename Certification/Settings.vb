Imports System.Drawing.Printing
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports ICSharpCode.SharpZipLib.Zip



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



    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        Me.txtBackupLocation.Text = My.Settings.BackupLocation.ToString()
        Me.txtDataLocation.Text = My.Settings.DataLocation.ToString()
    End Sub


    ''' <summary>
    ''' Exit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Save Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.BackupLocation = Me.txtBackupLocation.Text
        My.Settings.DataLocation = Me.txtDataLocation.Text
        Me.Close()
    End Sub


    ''' <summary>
    ''' Perform Backup
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPerformBackup_Click(sender As Object, e As EventArgs) Handles btnPerformBackup.Click
        If Not (String.IsNullOrEmpty(txtBackupLocation.Text)) Then
            Dim path As String = txtBackupLocation.Text
            If Not (Directory.Exists(path)) Then
                Directory.CreateDirectory(path)
            End If
            Dim startPath = Me.txtDataLocation.Text
            Dim zipPath = Me.txtBackupLocation.Text & "\result.zip"

            Dim z As FastZip = New FastZip()
            z.CreateEmptyDirectories = True

            z.CreateZip(zipPath, startPath, True, "")
            'Try
            '    ZipFile.
            'Catch ex As Exception

            'End Try
            'String startPath = @".\start";
            'String zipPath = @".\result.zip";
            'String extractPath = @".\extract";

            'ZipFile.CreateFromDirectory(startPath, zipPath);

            'ZipFile.ExtractToDirectory(zipPath, extractPath);

        End If
    End Sub





















End Class
