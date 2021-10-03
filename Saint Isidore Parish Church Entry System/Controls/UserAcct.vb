Public Class UserAcct
#Region "My Methods"

    Private Shared Instance As UserAcct
    Public Shared Function GetInstance() As UserAcct
        If IsNothing(Instance) Then
            Instance = New UserAcct()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

#End Region

    Private Sub UserAcct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
