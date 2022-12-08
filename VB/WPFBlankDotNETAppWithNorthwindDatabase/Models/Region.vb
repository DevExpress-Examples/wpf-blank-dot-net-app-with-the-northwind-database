Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

    Public Partial Class Region

        Public Property RegionId As Integer

        Public Property RegionDescription As String

        Public Overridable ReadOnly Property Territories As ICollection(Of Territory) = New List(Of Territory)()
    End Class
End Namespace
