Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Customer
		Public Property CustomerId() As String

		Public Property CompanyName() As String

		Public Property ContactName() As String

		Public Property ContactTitle() As String

		Public Property Address() As String

		Public Property City() As String

		Public Property Region() As String

		Public Property PostalCode() As String

		Public Property Country() As String

		Public Property Phone() As String

		Public Property Fax() As String

		Public Overridable Property Orders() As ICollection(Of Order) = New List(Of Order)()
	End Class
End Namespace
