Imports System
Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

	Partial Public Class Territory
		Public Property TerritoryId() As String

		Public Property TerritoryDescription() As String

		Public Property RegionId() As Integer

		Public Overridable Property Region() As Region
	End Class
End Namespace
