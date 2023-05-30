Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Shipper
		Public Property ShipperId() As Integer

		Public Property CompanyName() As String

		Public Property Phone() As String

		Public Overridable Property Orders() As ICollection(Of Order) = New List(Of Order)()
	End Class
End Namespace
