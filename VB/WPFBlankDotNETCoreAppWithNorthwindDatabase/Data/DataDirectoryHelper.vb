Imports System.IO
Imports System.Reflection

Namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Data
	Public Class DataDirectoryHelper
		Public Shared Function GetDataDirectory() As String
			Dim entryAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly()
			If entryAssembly Is Nothing Then
				Return Nothing
			End If
			Dim appPath As String = entryAssembly.Location
			Return Path.GetDirectoryName(appPath)
		End Function
		Public Shared Function GetFile(ByVal fileName As String, ByVal directoryName As String) As String
			Dim dirName As String = Path.GetFullPath(GetDataDirectory())
			Return dirName & "\" & directoryName & "\" & fileName
		End Function
	End Class
End Namespace