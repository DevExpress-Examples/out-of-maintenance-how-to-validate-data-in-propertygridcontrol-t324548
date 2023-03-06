Imports System.ComponentModel.DataAnnotations

Namespace DXSample

    Public Class ViewModel

        Public Property Contact As Contact

        Public Sub New()
            Contact = New Contact() With {.FirstName = "Carolyn", .LastName = "Baker", .Email = "carolyn.baker@example.com", .Phone = "(555)349-3010", .Address = "1198 Theresa Cir", .City = "Whitinsville", .State = "MA", .Zip = "01582"}
        End Sub
    End Class

    Public Class Contact

        <MaxLength(25, ErrorMessage:="Value is too long")>
        Public Property FirstName As String

        Public Property LastName As String

        Public Property CreditCardNumber As String

        Public Property Email As String

        Public Property Phone As String

        Public Property Address As String

        Public Property City As String

        <CustomValidation(GetType(ContactValidator), "ValidateString")>
        Public Property State As String

        Public Property Zip As String
    End Class

    Public Class ContactValidator

        Public Shared Function ValidateString(ByVal value As Object) As ValidationResult
            If value Is Nothing OrElse value.ToString().Length > 25 Then Return New ValidationResult("Value is too long")
            Return ValidationResult.Success
        End Function
    End Class
End Namespace
