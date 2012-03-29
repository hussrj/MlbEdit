' Rob Hussey
' Started: 3/29/2012
' Last modified: 3/29/2012
' Create a single dictionary instance in which the key is the input associated with a
' mlb character and the value is a unicode string representing that character
Imports System.Text

Module MlbDictionary
    Private mlbDict As Dictionary(Of String, String) = Nothing

    ' First call creates dictionary and returns it. Subsequent calls will just return it.
    Public ReadOnly Property GetInstance() As Dictionary(Of String, String)
        Get
            ' Only load the dictionary a single time
            If mlbDict Is Nothing Then LoadDictionary()

            Return mlbDict
        End Get
    End Property

    Private Sub LoadDictionary()
        ' UTF32Encoding to decode byte arrays (character codes) to utf32 strings
        Dim u32BE As New UTF32Encoding(True, False) ' Big endian with no BOM

        mlbDict = New Dictionary(Of String, String)
        Dim mlbDictText As String = (My.Resources.MlbDictionary).ToString()

        ' Split on CR+LF to get individual lines in the dictionary text file resource
        Dim mlbDictLines() As String = mlbDictText.Split(vbCrLf)

        ' Convert each line to key, value pairs and add them to mlb dictionary
        For index = 0 To mlbDictLines.Length - 1
            ' Split on space to get individual key, value pairs
            Dim mlbDictStrings() As String = mlbDictLines(index).Split(" ")

            ' The first string in pair is key. Remove spaces.
            Dim mlbInput As String = mlbDictStrings(0).Trim()

            ' The second string in pair is Unicode character code as string. Remove spaces.
            Dim mlbCode As String = mlbDictStrings(1).Trim()
            Dim mlbCodeBytes(7) As Byte ' Why 7 bytes? Lowest value that worked. TODO: Figure out why

            ' &H specifies hex, each character in string is a hex digit
            ' The first two hex digits make up the first byte and so on
            mlbCodeBytes(0) = ("&H" & mlbCode(0) & mlbCode(1))
            mlbCodeBytes(1) = ("&H" & mlbCode(2) & mlbCode(3))
            mlbCodeBytes(2) = ("&H" & mlbCode(4) & mlbCode(5))
            mlbCodeBytes(3) = ("&H" & mlbCode(6) & mlbCode(7))

            ' Decode the byte array to a utf32 encoded string of the mlb character associated with they key
            mlbDict.Add(mlbInput, u32BE.GetString(mlbCodeBytes))
        Next
    End Sub
End Module
