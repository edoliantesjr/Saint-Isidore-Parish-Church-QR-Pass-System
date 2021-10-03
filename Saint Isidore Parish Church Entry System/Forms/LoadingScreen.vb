Public Class LoadingScreen
    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Timer1.Start()
    End Sub
    Private Sub Expand()
        progressBar.Value = (Percent / 100) * Me.Width
    End Sub

    Dim Percent As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Select Case Percent
            Case 1
                'HomePanel.GetInstance()
                FrmMain.switchPanel(HomePanel.GetInstance)
                lblLoading.Text = "Loading, Home Menu..."
            Case 20
                FrmMain.switchPanel(GenerateQR.GetInstance)
                lblLoading.Text = "Loading, QR Library..."
            Case 30
                'Records.GetInstance()
                FrmMain.switchPanel(Records.GetInstance)
                lblLoading.Text = "Loading, Records Database..."
            Case 35
                'account.GetInstance()
                FrmMain.switchPanel(PrintBarcode.GetInstance())
                lblLoading.Text = "Loading, User Accounts..."
            Case 40
                FrmMain.GetInstance()
                lblLoading.Text = "Loading, Entry Library..."
            Case 45

                lblLoading.Text = "Now Opening Main Menu..."

            Case 50
                FrmMain.switchPanel(GenerateQR.GetInstance)
                Percent = 90

                ' Me.Hide()
        End Select
        If Percent >= 100 Then
            FrmMain.Show()
            Me.Hide()
        Else
            Timer1.Start()
            'Expand()
            Percent = Percent + 1
            progressBar.Value = Percent
        End If
    End Sub
End Class