Imports System.Collections.Generic

Namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Models

    Public Partial Class Shipper

        Public Sub New()
            Orders = New HashSet(Of Order)()
        End Sub

        Public Property ShipperId As Integer

        Public Property CompanyName As String

        Public Property Phone As String

        Public Overridable Property Orders As ICollection(Of Order)
    End Class
End Namespace
