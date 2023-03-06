Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.ComponentModel
Imports DevExpress.Xpf.PropertyGrid

Namespace DXSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub PropertyGridControl_ValidateCell(ByVal sender As Object, ByVal e As ValidateCellEventArgs)
            If e.NewValue Is Nothing OrElse String.IsNullOrEmpty(e.NewValue.ToString()) Then e.ValidationException = New Exception("A cell cannot be empty")
        End Sub
    End Class
End Namespace
