Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Region
		Public Property RegionId() As Integer

		Public Property RegionDescription() As String

		Public Overridable Property Territories() As ICollection(Of Territory) = New List(Of Territory)()
	End Class
End Namespace
