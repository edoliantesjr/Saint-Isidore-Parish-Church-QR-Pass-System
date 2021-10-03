Imports MySql.Data.MySqlClient

Public Class HomePanel
    Private Shared Instance As HomePanel
    Public Shared Function GetInstance() As HomePanel
        If IsNothing(Instance) Then
            Instance = New HomePanel()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function
    Private Sub EntryPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
