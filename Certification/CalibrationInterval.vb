Imports System.Drawing.Printing
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports ICSharpCode.SharpZipLib.Zip



Public Class CalibrationInterval

    Public Property Interval As String


    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByVal numofCerts As Integer)
        InitializeComponent()
        lblInfo.Text = "You have selected " + numofCerts.ToString() + " certs to print"
        cbCalibrationInterval.Items.Add("1 Monthly")
        cbCalibrationInterval.Items.Add("2 Monthly")
        cbCalibrationInterval.Items.Add("3 Monthly")
        cbCalibrationInterval.Items.Add("4 Monthly")
        cbCalibrationInterval.Items.Add("5 Monthly")
        cbCalibrationInterval.Items.Add("6 Monthly")
        cbCalibrationInterval.Items.Add("7 Monthly")
        cbCalibrationInterval.Items.Add("8 Monthly")
        cbCalibrationInterval.Items.Add("9 Monthly")
        cbCalibrationInterval.Items.Add("10 Monthly")
        cbCalibrationInterval.Items.Add("11 Monthly")
        cbCalibrationInterval.Items.Add("12 Monthly")
        cbCalibrationInterval.SelectedItem = "6 Monthly"
        Interval = "6 Monthly"
    End Sub

    Private Sub cbCalibrationInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCalibrationInterval.SelectedIndexChanged
        Interval = cbCalibrationInterval.SelectedItem.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class
