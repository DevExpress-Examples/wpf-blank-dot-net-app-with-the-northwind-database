Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Product
		Public Property ProductId() As Integer

		Public Property ProductName() As String

		Public Property SupplierId() As Integer?

		Public Property CategoryId() As Integer?

		Public Property QuantityPerUnit() As String

		Public Property UnitPrice() As Decimal?

		Public Property UnitsInStock() As Short?

		Public Property UnitsOnOrder() As Short?

		Public Property ReorderLevel() As Short?

		Public Property Discontinued() As Boolean

		Public Overridable Property Category() As Category

		Public Overridable Property OrderDetails() As ICollection(Of OrderDetail) = New List(Of OrderDetail)()

		Public Overridable Property Supplier() As Supplier
	End Class
End Namespace
