Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Category
		Public Property CategoryId() As Integer

		Public Property CategoryName() As String

		Public Property Description() As String

		Public Property Picture() As Byte()

		Public Overridable Property Products() As ICollection(Of Product) = New List(Of Product)()
	End Class
End Namespace