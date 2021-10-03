Imports MySql.Data.MySqlClient

Public Class PrintRecord
    Dim dataAdapter As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Dim sql As String
    Sub printLogRecord(date1 As String, mass As String)

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
            sql = "SELECT people_table.*, entry_table.*
               FROM entry_table INNER JOIN people_table ON entry_table.qr_id=people_table.qr_id  
               WHERE  entry_table.date = '" & date1 & "' AND entry_table.mass LIKE '%" & mass & "%'
               ORDER BY entry_table.time_in ASC"
            dataAdapter.SelectCommand = New MySqlCommand(sql, con)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(dataAdapter)

            dataAdapter.Fill(ds, "entry_table,people_table")
            dataAdapter.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Dim objRpt As New CrystalRecord
        objRpt.SetDataSource(ds.Tables("entry_table,people_table"))
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub PrintRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class