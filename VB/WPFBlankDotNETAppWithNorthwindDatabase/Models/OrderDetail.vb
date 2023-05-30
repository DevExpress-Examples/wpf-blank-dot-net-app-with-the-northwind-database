Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class OrderDetail
		Public Property OrderId() As Integer

		Public Property ProductId() As Integer

		Public Property UnitPrice() As Decimal

		Public Property Quantity() As Short

		Public Property Discount() As Single

		Public Overridable Property Order() As Order

		Public Overridable Property Product() As Product
	End Class
End Namespace
