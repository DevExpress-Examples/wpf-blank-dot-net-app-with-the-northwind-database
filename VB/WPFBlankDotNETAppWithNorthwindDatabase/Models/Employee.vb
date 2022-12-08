Imports System.Collections.Generic

Namespace WPFBlankDotNETAppWithNorthwindDatabase.Models

    Public Partial Class Employee

        Public Property EmployeeId As Integer

        Public Property LastName As String

        Public Property FirstName As String

        Public Property Title As String

        Public Property TitleOfCourtesy As String

        Public Property BirthDate As Date?

        Public Property HireDate As Date?

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property HomePhone As String

        Public Property Extension As String

        Public Property Photo As Byte()

        Public Property Notes As String

        Public Property ReportsTo As Integer?

        Public Property PhotoPath As String

        Public Overridable ReadOnly Property InverseReportsToNavigation As ICollection(Of Employee) = New List(Of Employee)()

        Public Overridable ReadOnly Property Orders As ICollection(Of Order) = New List(Of Order)()

        Public Overridable Property ReportsToNavigation As Employee
    End Class
End Namespace
