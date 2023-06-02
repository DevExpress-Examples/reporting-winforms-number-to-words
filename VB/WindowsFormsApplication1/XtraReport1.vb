Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub WordsUnitPrice_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs)
            e.Value = NumberToWords(Convert.ToInt32(e.GetColumnValue("UnitPrice")))
        End Sub

        Public Shared Function NumberToWords(ByVal number As Integer) As String
            If number = 0 Then Return "Zero"
            If number < 0 Then Return "Minus " & NumberToWords(Math.Abs(number))
            Dim words As String = ""
            If number \ 1000000 > 0 Then
                words += NumberToWords(number \ 1000000) & " Million "
                number = number Mod 1000000
            End If

            If number \ 1000 > 0 Then
                words += NumberToWords(number \ 1000) & " Thousand "
                number = number Mod 1000
            End If

            If number \ 100 > 0 Then
                words += NumberToWords(number \ 100) & " Hundred "
                number = number Mod 100
            End If

            If number > 0 Then
                If Not Equals(words, "") Then words += "and "
                Dim unitsMap = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim tensMap = {"zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                If number < 20 Then
                    words += unitsMap(number)
                Else
                    words += tensMap(number \ 10)
                    If number Mod 10 > 0 Then words += "-" & unitsMap(number Mod 10)
                End If
            End If

            Return words
        End Function
    End Class
End Namespace
