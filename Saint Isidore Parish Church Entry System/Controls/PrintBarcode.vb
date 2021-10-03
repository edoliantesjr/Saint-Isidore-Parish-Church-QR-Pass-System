Imports MySql.Data.MySqlClient

Public Class PrintBarcode

    Private Shared Instance As PrintBarcode
    Public Shared Function GetInstance() As PrintBarcode
        If IsNothing(Instance) Then
            Instance = New PrintBarcode()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Dim sql As String
    Sub setQuerySearch()

        ''show by event id,event name,event date,full name,course,year,section,amin,amout,pmin,pmout
        sql = "SELECT photo FROM people_table ORDER BY qr_id ASC"

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "photo")
        con.Close()

    End Sub
    Dim dataAdapter As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Sub printBarcode()

        ds.Clear()
        Try
            With con
                If .State = ConnectionState.Open Then .Close()

                con.Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            sql = "SELECT photo FROM people_table ORDER BY qr_id ASC"
            dataAdapter.SelectCommand = New MySqlCommand(sql, con)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(dataAdapter)

            dataAdapter.Fill(ds, "photo")
            dataAdapter.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Dim objRpt As New barcodeReport
        objRpt.SetDataSource(ds.Tables("photo"))
        barcodeReportViewer.ReportSource = objRpt
        barcodeReportViewer.RefreshReport()

    End Sub
    Private Sub PrintBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printBarcode()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        printBarcode()
    End Sub
End Class
