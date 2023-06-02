Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim rep As XtraReport1 = New XtraReport1()
            rep.ShowPreview()
        End Sub
    End Class
End Namespace
