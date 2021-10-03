Imports MySql.Data.MySqlClient

Public Class Records

#Region "My Methods"
    Private Shared Instance As Records
    Public Shared Function GetInstance() As Records
        If IsNothing(Instance) Then
            Instance = New Records()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    ''set query report
    Dim sql As String

    ''search
    Sub setQuerySearch()

        ''show by event id,event name,event date,full name,course,year,section,amin,amout,pmin,pmout
        sql = "SELECT entry_table.qr_id as `QR ID`,entry_table.time_in as 'Log Time', people_table.fullname as Name,entry_table.temp as Temp,people_table.sex as Gender,
               people_table.age as Age,people_table.contact as `Contact No`,mass as `Mass Schedule`,people_table.purok as Purok,people_table.Barangay,
               people_table.municipal as Municipality, people_table.province as Province
               FROM entry_table INNER JOIN people_table USING(qr_id) 
               WHERE  entry_table.date = '" & dtpDate.Value.ToString("yyyy/M/dd") & "' AND entry_table.mass LIKE '%" & cmbMass.Text & "%'
               ORDER BY entry_table.time_in ASC"

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "people_table,entry_table")

        dgviewRecord.DataSource = ds.Tables(0)
        '      If record_dgview.ColumnCount > 0 Then
        '     record_dgview.Columns(1).Visible = False
        '     End If

        con.Close()

    End Sub

    Sub getEventList()

        Try
            Dim sql As String = "SELECT date,mass,COUNT(*) FROM entry_table WHERE date='" & dtpDate.Value.ToString("yyyy/M/dd") & "' GROUP BY mass HAVING Count(*) >= 1  "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "mass")
            con.Close()

            cmbMass.DataSource = ds.Tables(0)
            cmbMass.DisplayMember = "mass"
            cmbMass.ValueMember = "mass"
            cmbMass.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = Date.Now
        getEventList()
    End Sub

    Private Sub btnLoadRecord_Click(sender As Object, e As EventArgs) Handles btnLoadRecord.Click
        setQuerySearch()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        PrintRecord.printLogRecord(dtpDate.Value.ToString("yyyy/M/dd"), cmbMass.Text)
        PrintRecord.Show()
        PrintRecord.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub cmbMass_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbMass.MouseClick
        getEventList()
    End Sub

    Private Sub cmbMass_Click(sender As Object, e As EventArgs) Handles cmbMass.Click
        getEventList()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        getEventList()
    End Sub
End Class
