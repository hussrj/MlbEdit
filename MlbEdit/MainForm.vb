' Rob Hussey
' Started: 3/28/2012
' Last modified: 3/29/2012
Imports System.Text
Imports IronPython.Hosting
Imports Microsoft.Scripting.Hosting
Imports IronPython.Runtime

Public Class MainForm
    ' Dictionary key is input and value is utf32 encoded string of mlb char associated with input
    Private mlbDict As Dictionary(Of String, String)
    Private py As ScriptRuntime = Python.CreateRuntime

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the font to the Aegean font
        MlbTextBox.Font = EmbedFont.GetInstance(22, FontStyle.Regular)
        ' Get an instance of the mlb dictionary
        mlbDict = MlbDictionary.GetInstance()
    End Sub

    Private Sub InputButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton.Click
        Dim mlbStr As String = Nothing
        MlbTextBox.SelectionStart = 0
        MlbTextBox.SelectionLength = 0

        ' if input text is valid key then this will return utf32 encoded string for the input
        mlbDict.TryGetValue(InputTextBox.Text, mlbStr)

        If mlbStr Is Nothing Then
            ' input text was not a valid key
            Return
        End If

        ' get length before appending string
        Dim length As Integer = MlbTextBox.TextLength

        ' append the utf32 encoded string for the input
        MlbTextBox.AppendText(mlbStr)
        TransTextBox.AppendText(InputTextBox.Text & " ")

        ' tuple with first = true or false and second = unicode char point converted to integer if true
        Dim isIdeogram As PythonTuple = CType(py.UseFile("ideogramChecker.py"), Object).isIdeogram(mlbStr)

        ' if ideogram entered, color it
        If isIdeogram.First Then
            MlbTextBox.Select(length, 1)
            MlbTextBox.SelectionColor = Color.DarkOliveGreen
        End If

        ' clear any selected text
        MlbTextBox.Select(0, 0)
    End Sub
End Class
