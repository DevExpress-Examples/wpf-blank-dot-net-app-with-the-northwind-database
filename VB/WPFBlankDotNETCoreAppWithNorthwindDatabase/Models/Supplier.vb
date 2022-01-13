Imports System.Collections.Generic

Namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Models

    Public Partial Class Supplier

        Public Sub New()
            Products = New HashSet(Of Product)()
        End Sub

        Public Property SupplierId As Integer

        Public Property CompanyName As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property Phone As String

        Public Property Fax As String

        Public Property HomePage As String

        Public Overridable Property Products As ICollection(Of Product)
    End Class
End Namespace
