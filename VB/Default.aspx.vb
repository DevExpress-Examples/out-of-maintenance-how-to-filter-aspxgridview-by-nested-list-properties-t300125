Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class T300125
    Inherits System.Web.UI.Page

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        grid.DataSource = GetData()
        grid.DataBind()
    End Sub

    Public Function GetData() As List(Of Department)
        Return New List(Of Department)() From { _
            New Department() With { _
                .Name = "Management", .Location = "London", .Employees = New List(Of Person)() From { _
                    New Person() With {.FirstName = "Ben", .LastName = "Summers", .Age = 57, .Position = Position.Head}, _
                    New Person() With {.FirstName = "Peter", .LastName = "Enchi", .Age = 48, .Position = Position.Developer} _
                } _
            }, _
            New Department() With { _
                .Name = "R&D", .Location = "Bristol", .Employees = New List(Of Person)() From { _
                    New Person() With {.FirstName = "Sam", .LastName = "Johnson", .Age = 34, .Position = Position.Manager}, _
                    New Person() With {.FirstName = "John", .LastName = "Samson", .Age = 29, .Position = Position.Developer}, _
                    New Person() With {.FirstName = "Julia", .LastName = "Green", .Age = 23, .Position = Position.Developer} _
                } _
            }, _
            New Department() With { _
                .Name = "SEO", .Location = "Liverpool", .Employees = New List(Of Person)() From { _
                    New Person() With {.FirstName = "Mary", .LastName = "Smith", .Age = 27, .Position = Position.Manager}, _
                    New Person() With {.FirstName = "Ann", .LastName = "Davolio", .Age = 19, .Position = Position.Manager} _
                } _
            }, _
            New Department() With {.Name = "Marketing", .Location = "Moscow"} _
        }
    End Function
    Protected Sub detailGrid_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs)
        Dim grid = TryCast(sender, ASPxGridView)
        Dim key = grid.GetMasterRowKeyValue().ToString()
        grid.DataSource = GetData().Single(Function(item) item.Name = key).Employees
    End Sub
End Class

Public Enum Position
    Manager
    Developer
    Head
End Enum

Public Class Department
    Public Property Name() As String
    Public Property Location() As String
    Public Property Employees() As List(Of Person)
End Class

Public Class Person
    Public Property LastName() As String
    Public Property FirstName() As String
    Public Property Age() As Integer
    Public Property Position() As Position
End Class
