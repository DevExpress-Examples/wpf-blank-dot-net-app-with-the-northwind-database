Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

    Public Partial Class Shipper

        Public Property ShipperId As Integer

        Public Property CompanyName As String

        Public Property Phone As String

        Public Overridable ReadOnly Property Orders As ICollection(Of Order) = New List(Of Order)()
    End Class
End Namespace
