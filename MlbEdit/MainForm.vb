' Rob Hussey
' Started: 3/28/2012
' Last modified: 3/29/2012
Imports System.Text

Public Class MainForm
    ' Dictionary key is input and value is utf32 encoded string of mlb char associated with input
    Private mlbDict As Dictionary(Of String, String)

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the font to the Aegean font
        MlbTextBox.Font = EmbedFont.GetInstance(22, FontStyle.Regular)
        ' Get an instance of the mlb dictionary
        mlbDict = MlbDictionary.GetInstance()
    End Sub

    Private Sub InputButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton.Click
        Dim mlbStr As String = Nothing
        ' if input text is valid key then this will return utf32 encoded string for the input
        mlbDict.TryGetValue(InputTextBox.Text, mlbStr)

        If mlbStr Is Nothing Then
            ' input text was not a valid key
            Return
        End If

        ' append the utf32 encoded string for the input
        MlbTextBox.AppendText(mlbStr)
        TransTextBox.AppendText(InputTextBox.Text & " ")
    End Sub
End Class
