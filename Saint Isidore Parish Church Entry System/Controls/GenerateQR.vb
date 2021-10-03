Imports MySql.Data.MySqlClient

Public Class GenerateQR
    Dim sql As String

#Region "My Methods"

    ''get generateQr
    Private Shared Instance As GenerateQR
    Public Shared Function GetInstance() As GenerateQR
        If IsNothing(Instance) Then
            Instance = New GenerateQR
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    ''generate qr code
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Sub generateQr()

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

    ''clear fields
    Sub clearFields()
        txtFirstname.Text = ""
        txtLastname.Text = ""
        lblFullname.Text = ""
        newQRId()
        btnSubmit.Text = "Submit"
        btnDelete.Visible = False
        txtContact.Text = "09"
        txtAge.Text = ""
        cmbSex.SelectedIndex = -1
    End Sub

    ''save qrcode to folder and save qr to db
    Public photo() As Byte
    Sub saveQr(panel As Control)
        Dim SD As New SaveFileDialog
        SD.FileName = txtQR.Text + " " + txtFirstname.Text + " " + txtLastname.Text
        Dim filename As String = txtQR.Text + " " + txtFirstname.Text + " " + txtLastname.Text
        SD.Filter = "PNG File|*.png"

        Dim fileSize As UInt64
        Dim mStream As New System.IO.MemoryStream()
        'qrPanel.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)


        Using bmp = New Bitmap(panel.Width, panel.Height)
            Try
                panel.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
                bmp.Save("C:\Users\JhunR\Desktop\QR Codes\" + filename + ".png")
                bmp.Save(mStream, Imaging.ImageFormat.Png)
                photo = mStream.GetBuffer()
                fileSize = mStream.Length
                mStream.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            '  If SD.ShowDialog() = DialogResult.OK Then
            ' Try
            ''captureQR(qrPanel).Save(SD.FileName, Imaging.ImageFormat.Png)
            'bmp.Save("C:\Desktop\QR Codes\" + SD.FileName, Imaging.ImageFormat.Jpeg)
            'bmp.Save(mStream, Imaging.ImageFormat.Jpeg)
            'photo = mStream.GetBuffer()
            'fileSize = mStream.Length
            'mStream.Close()
            'Catch ex As Exception
            '  MessageBox.Show(ex.Message)
            '  End Try
            '  End If
        End Using
    End Sub

    Function getQrId() As Integer
        sql = "SELECT MAX(id) from people_table LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then

            While dr.Read
                If Not dr.IsDBNull(0) Then
                    getQrId = dr.GetInt64(0) + 1
                Else
                    getQrId = 1
                End If

                '  txtQR.Text = Date.Today.Year + "-" + String.Format("%04d", generateQrId)
                'txtQR.Text = Date.Today.Year + "-" + String.Format("%04d", 1)

            End While
        End If
        con.Close()
        Return getQrId

    End Function

    ''new QRID
    Sub newQRId()
        txtQR.Text = "QR" + Now.Year.ToString() + "-" + Format(getQrId(), "0000").ToString
    End Sub

    ''check if qr_id already exist
    Function duplicateQrId() As Boolean
        Dim b As Boolean
        Dim sql As String = "SELECT * FROM people_table WHERE qr_id='" & txtQR.Text & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            errSound()
            b = True
            BubbleNotification.closeAlert()
            Alert("WARNING", "QR ID Already Existed!,Generating New ID...", BubbleNotification.alertTypeEnum.Warning)
            Dim newId As Integer = getQrId() + 1
            newQRId()
        Else
            b = False
        End If
        Return b
    End Function

    ''function to identify complete profile
    Function profileStat() As String
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtContact.Text = "" Then
            Return "incomplete"
        Else
            Return "complete"
        End If
    End Function

    ''savePersonal Info
    Dim province As String = "BOHOL"
    Dim address As String
    Dim fullname As String
    Sub savePersonsInfo()


        fullname = txtFirstname.Text + " " + txtLastname.Text
        address = "P-" + cmbPurok.Text + " " + cmbBarangay.Text + ", " + cmbMunicipal.Text + ", " + province

        sql = "INSERT INTO people_table(qr_id,fullname,firstname,lastname,address,purok,barangay,municipal,province,contact,status,date_created,sex,age,photo)
        VALUES('" & txtQR.Text & "','" & fullname & "','" & txtFirstname.Text & "','" & txtLastname.Text & "',
        '" & address & "','" & cmbPurok.Text & "','" & cmbBarangay.Text & "','" & cmbMunicipal.Text & "','" & province & "',
        '" & txtContact.Text & "','" & profileStat() & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "','" & cmbSex.Text & "','" & txtAge.Text & "',@photo)"
        Dim cmd As New MySqlCommand(sql, con)
        saveQr(qrPanel)
        cmd.Parameters.AddWithValue("@photo", photo)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        BubbleNotification.closeAlert()
        Alert("SUCCESS", "Person's Information Saved!", BubbleNotification.alertTypeEnum.Success)

    End Sub

    ''updatePersonsInfo
    Sub updatePersonsInfo()
        fullname = txtFirstname.Text + " " + txtLastname.Text
        address = "P-" + cmbPurok.Text + " " + cmbBarangay.Text + ", " + cmbMunicipal.Text + ", " + province

        sql = "UPDATE people_table SET fullname='" & fullname & "',firstname='" & txtFirstname.Text & "',lastname='" & txtLastname.Text & "',
               address='" & address & "',purok='" & cmbPurok.Text & "',barangay='" & cmbBarangay.Text & "',
               municipal= '" & cmbMunicipal.Text & "',contact='" & txtContact.Text & "',age='" & txtAge.Text & "',status='" & profileStat() & "',
               date_created='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "',sex='" & cmbSex.Text & "',photo=@photo WHERE qr_id='" & txtQR.Text & "'"
        Dim cmd As New MySqlCommand(sql, con)
        saveQr(qrPanel)
        cmd.Parameters.AddWithValue("@photo", photo)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        BubbleNotification.closeAlert()
        Alert("SUCCESS", "Updated Person's Information!", BubbleNotification.alertTypeEnum.Success)
    End Sub

    ''delete PersonInfo
    Sub deletePerson(qr_id As String)
        sql = "DELETE FROM people_table WHERE qr_id='" & qr_id & "' "
        bQuery(sql)
        Alert("DELETED", "Person's Information Deleted!", BubbleNotification.alertTypeEnum.Warning)
        searchPerson("")
    End Sub

    ''get Personal Details
    Sub getPersonalDetails()
        Try
            txtQR.Text = dgviewPeople.SelectedCells(0).Value.ToString()
            txtFirstname.Text = dgviewPeople.SelectedCells(2).Value.ToString()
            txtLastname.Text = dgviewPeople.SelectedCells(3).Value.ToString()
            cmbSex.Text = dgviewPeople.SelectedCells(4).Value.ToString()
            txtAge.Text = dgviewPeople.SelectedCells(5).Value.ToString()
            txtContact.Text = dgviewPeople.SelectedCells(6).Value.ToString()
            cmbPurok.Text = dgviewPeople.SelectedCells(7).Value.ToString()
            cmbBarangay.Text = dgviewPeople.SelectedCells(8).Value.ToString()
            cmbMunicipal.Text = dgviewPeople.SelectedCells(9).Value.ToString()



            btnDelete.Visible = True
            btnSubmit.Text = "Edit"
        Catch ex As Exception
            MessageBox.Show("INVALID SELECTION")
        End Try
    End Sub

    'searchPerson
    Sub searchPerson(search As String)
        Dim sql As String = "SELECT qr_id as ID,fullname as Name,firstname,lastname,sex as `Gender`,age as Age,contact as `Contact No.`,purok as Purok,barangay as Barangay,
        municipal as Municipality, province as Province,status FROM people_table WHERE qr_id Like '%" & search &
        "%' OR fullname LIKE '%" & search & "%' OR address LIKE '%" & search & "%' OR status LIKE '%" & search & "%' ORDER BY date_created DESC "

        ' Dim sql As String = "SELECT qr_id as ID,fullname as Name,firstname,lastname,address as Address FROM people_table WHERE qr_id LIKE '%" & search &
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "people_table")

        dgviewPeople.DataSource = ds.Tables(0)

        con.Close()
        If dgviewPeople.ColumnCount > 0 Then
            dgviewPeople.Columns(2).Visible = False
            dgviewPeople.Columns(3).Visible = False
            dgviewPeople.Columns(9).Visible = False
            dgviewPeople.Columns(10).Visible = False
            dgviewPeople.Columns(11).Visible = False
            ' dgviewPeople.Columns(3).Visible = False
        End If
    End Sub


#End Region
    Private Sub GenerateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newQRId()
        searchPerson("")
        lblFullname.Text = Nothing
    End Sub

    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        saveQr(qrPanel)
        Alert("Success", "Barcode is saved!", BubbleNotification.alertTypeEnum.Warning)
    End Sub

    Private Sub txtQR_TextChanged(sender As Object, e As EventArgs) Handles txtQR.TextChanged
        generateQr()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If btnSubmit.Text = "Submit" Then
            If duplicateQrId() = False Then
                savePersonsInfo()
                searchPerson(txtSearch.Text)
                LabelResult.Visible = False
                clearFields()
                newQRId()
            End If

        ElseIf btnSubmit.Text = "Edit" Then
            updatePersonsInfo()
            searchPerson(txtSearch.Text)
            LabelResult.Visible = False
            clearFields()
            newQRId()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        searchPerson(txtSearch.Text.Trim())
        LabelResult.Text = "Search Results for:" + """" + txtSearch.Text + """"
        LabelResult.Visible = True
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        searchPerson("")
        LabelResult.Visible = False
        txtSearch.Text = ""
    End Sub

    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged, txtLastname.TextChanged, txtAge.TextChanged, txtContact.TextChanged
        lblFullname.Text = txtFirstname.Text + " " + txtLastname.Text
    End Sub

    Private Sub dgviewPeople_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgviewPeople.MouseDoubleClick
        getPersonalDetails()
    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        getPersonalDetails()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            deletePerson(dgviewPeople.SelectedCells(0).Value.ToString())
            clearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deletePerson(txtQR.Text)
        clearFields()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchPerson(txtSearch.Text)
        End If
    End Sub

    Private Sub txtFirstname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLastname.KeyDown, txtFirstname.KeyDown, txtContact.KeyDown, txtAge.KeyDown, cmbPurok.KeyDown, cmbMunicipal.KeyDown, cmbBarangay.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub txtFirstname_Leave(sender As Object, e As EventArgs) Handles txtLastname.Leave, txtFirstname.Leave
        txtFirstname.Text = StrConv(txtFirstname.Text, VbStrConv.ProperCase)
        txtLastname.Text = StrConv(txtLastname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub cmbBarangay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMunicipal.KeyPress, cmbBarangay.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.KeyChar = Char.ToUpper(e.KeyChar)

        End If
    End Sub


End Class
