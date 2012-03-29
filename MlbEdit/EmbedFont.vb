' Rob Hussey
' Started: 3/28/2012
' Last modified: 3/29/2012
Imports System.Runtime.InteropServices
Imports System.Drawing.Text

Module EmbedFont
    Private pfc As PrivateFontCollection = Nothing

    ' First call loads the font and returns it. Subsequent calls just return it.
    Public ReadOnly Property GetInstance(ByVal Size As Single, ByVal Style As FontStyle) As Font
        Get
            ' Only load the font a single time
            If pfc Is Nothing Then LoadFont()

            ' Return a font created from the font resource with a give size and style
            Return New Font(pfc.Families(0), Size, Style)
        End Get
    End Property

    Private Sub LoadFont()
        Try
            pfc = New PrivateFontCollection

            ' Allocate memory for font resource and get a pointer to it
            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.Aegean.Length)
            ' Copy font resource data to memory starting at the given pointer address
            Marshal.Copy(My.Resources.Aegean, 0, fontMemPointer, My.Resources.Aegean.Length)
            ' Add font from memory to the private font collection
            pfc.AddMemoryFont(fontMemPointer, My.Resources.Aegean.Length)

            ' Free memory allocated for the font resource
            Marshal.FreeCoTaskMem(fontMemPointer)

        Catch ex As Exception
            ' Error loading font
            MessageBox.Show("Failed to load Aegean font.")
        End Try
    End Sub
End Module
