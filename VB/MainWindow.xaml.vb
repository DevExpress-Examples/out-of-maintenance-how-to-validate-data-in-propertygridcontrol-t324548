Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.ComponentModel
Imports DevExpress.Xpf.PropertyGrid

Namespace DXSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub PropertyGridControl_ValidateCell(ByVal sender As Object, ByVal e As ValidateCellEventArgs)
            If e.NewValue Is Nothing OrElse String.IsNullOrEmpty(e.NewValue.ToString()) Then
                e.ValidationException = New System.Exception("A cell cannot be empty")
            End If
        End Sub
    End Class
End Namespace