Imports MySql.Data.MySqlClient

Public Class FrmMain

#Region "My Methods for entry recording"
    ''Instance variables
    Dim qrcode As String
    Dim sql As String
    Dim time_in As String
    Dim schedMass As String
    Private Shared Instance As FrmMain
    Public Shared Function GetInstance() As FrmMain
        If IsNothing(Instance) Then
            Instance = New FrmMain()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    ''switch panel
    Public Sub switchPanel(panel As Control)
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        If TypeOf panel Is SwitchPanels Then
            DirectCast(panel, SwitchPanels).RefreshControl()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
        btnNormal.BringToFront()
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        Me.WindowState = FormWindowState.Normal
        btnMax.BringToFront()
    End Sub

    ''method to show entry panel
    Dim entrypanelVisible As Boolean
    Sub showEntryPanel()
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(entryPanel)
        entrypanelVisible = True
    End Sub

    ''method to get qr image
    Sub getQRImage()
        Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Try
            QR_Generator.QRCodeScale = 20
            QR_Generator.QRCodeVersion = 0
            ''QR_Generator.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H

            Dim bm As Bitmap
            bm = QR_Generator.Encode(txtQR.Text)
            '  picQR.Image = bm
            qrPic.BackgroundImage = bm
            lblQR.Text = txtQR.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'function to identify if qr id exist in database
    Function checkPeople()
        Dim sql As String = "SELECT * FROM people_table WHERE qr_id='" & txtQR.Text & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            Return True

        Else
            Return False

        End If
    End Function

    'function to validate duplication of records
    Function checkRecord() As Boolean
        Dim sql As String = "SELECT * FROM entry_table WHERE date='" & Date.Today.ToString("yyyy/M/dd") & "' AND qr_id='" & txtQR.Text & "' AND mass='" & schedMass & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            Return True

        Else
            Return False

        End If
    End Function

    ''method to save entry log record
    Sub saveEntryRecord(qrcode As String)
        sql = ""
        time_in = TimeOfDay().ToString("hh:mm:ss tt")
        schedMass = startMass.Text.ToUpper + " - " + endMass.Text.ToUpper

        If checkPeople() = True Then

            If checkRecord() = False Then ''if false save entry
                sql = "INSERT INTO entry_table(date,qr_id,time_in,mass,temp)VALUES('" & Date.Today.ToString("yyyy/M/dd") & "'
                ,'" & qrcode & "','" & time_in & "','" & schedMass & "','" & txtTemp.Text & "')"

                ' getPersonalDetails(qrcode)

            Else ''if true update entry
                sql = "UPDATE entry_table SET time_in='" & time_in & "',temp='" & txtTemp.Text & "' WHERE qr_id='" & qrcode & "' 
                AND date='" & Date.Today.ToString("yyyy/M/dd") & "' AND mass='" & schedMass & "'"
            End If

            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            Alert("SUCCESS", "New Church Entry Saved!", BubbleNotification.alertTypeEnum.Success)
            con.Close()
            getPersonalDetails(qrcode)
            getQRImage()
            showLogEntry()
        Else
            Alert("Error", "QR Code Not Found", BubbleNotification.alertTypeEnum.Error)
        End If
    End Sub

    ''Method to get personal info
    Sub getPersonalDetails(qrcode)
        Dim sql As String = "SELECT fullname,barangay,municipal,province,sex from people_table where qr_id='" & qrcode & "' limit 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read

                lblName.Text = dr.Item("fullname").ToString
                lblAddress.Text = dr.Item("barangay").ToString() + ", " + dr.Item("municipal").ToString() + ", " + dr.Item("province").ToString()
                lblLogTime.Text = time_in.ToUpper
            End While
        End If
        con.Close()
    End Sub

    ''Method to show recent log
    Sub showLogEntry()
        sql = "SELECT entry_table.qr_id as `QR ID`, people_table.fullname as Name,people_table.purok as Purok,people_table.Barangay,
               people_table.contact as Contact,entry_table.temp as Temp, entry_table.time_in as 'Log Time' FROM entry_table INNER JOIN people_table USING(qr_id) 
               WHERE  entry_table.date='" & Date.Today.ToString("yyyy/M/dd") & "' AND entry_table.mass='" & schedMass & "'
               ORDER BY entry_table.time_in DESC"

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "people_table,entry_table")

        dgviewRecord.DataSource = ds.Tables(0)

        con.Close()

    End Sub
#End Region

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
        entrypanelVisible = False
        showEntryPanel()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size

        switchPanel(HomePanel.GetInstance())
    End Sub

    Private Sub ButtonCandidate_Click(sender As Object, e As EventArgs) Handles ButtonCandidate.Click
        entrypanelVisible = False
        switchPanel(GenerateQR.GetInstance())
    End Sub


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        schedMass = startMass.Text.ToUpper + " - " + endMass.Text.ToUpper
        If schedMass <> "" Then
            txtQR.Focus()
            qrcode = txtQR.Text.Trim
            saveEntryRecord(qrcode)
            txtQR.Text = ""
            txtTemp.Text = ""
            txtQR.Focus()
        Else
            Alert("Warning!", "No Mass Schedule Selected!", BubbleNotification.alertTypeEnum.Warning)

        End If

    End Sub

    Private Sub cmbMass_SelectedValueChanged(sender As Object, e As EventArgs)
        showLogEntry()
    End Sub

    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If entrypanelVisible = True Then
            ' txtQR.Focus()
            If e.KeyCode = Keys.Enter Then
                If schedMass <> "" Then
                    schedMass = startMass.Text.ToUpper + " - " + endMass.Text.ToUpper
                    qrcode = txtQR.Text.Trim
                    saveEntryRecord(qrcode)
                    txtQR.Text = ""
                    txtTemp.Text = ""
                    showLogEntry()
                    txtQR.Focus()
                Else
                    Alert("Warning!", "No Mass Schedule Selected!", BubbleNotification.alertTypeEnum.Warning)

                End If
            End If
            End If

    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        switchPanel(HomePanel.GetInstance())
    End Sub

    Private Sub ButtonParty_Click(sender As Object, e As EventArgs) Handles ButtonParty.Click
        entrypanelVisible = False
        switchPanel(Records.GetInstance())
    End Sub

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        entrypanelVisible = False
        switchPanel(UserAcct.GetInstance())
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click, Guna2Button1.Click
        entrypanelVisible = False
        switchPanel(PrintBarcode.GetInstance())
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
        lblDay.Text = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        lblDate.Text = Format(Now, "MMMM dd, yyyy")
        lblTime.Text = Format(Now, "hh:mm tt").ToUpper

    End Sub


End Class
