Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

    Public Partial Class Order

        Public Property OrderId As Integer

        Public Property CustomerId As String

        Public Property EmployeeId As Integer?

        Public Property OrderDate As Date?

        Public Property RequiredDate As Date?

        Public Property ShippedDate As Date?

        Public Property ShipVia As Integer?

        Public Property Freight As Decimal?

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Overridable Property Customer As Customer

        Public Overridable Property Employee As Employee

        Public Overridable ReadOnly Property OrderDetails As ICollection(Of OrderDetail) = New List(Of OrderDetail)()

        Public Overridable Property ShipViaNavigation As Shipper
    End Class
End Namespace
