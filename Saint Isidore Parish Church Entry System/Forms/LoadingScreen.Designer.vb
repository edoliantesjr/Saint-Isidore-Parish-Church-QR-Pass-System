<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.progressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressBar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.progressBar.Location = New System.Drawing.Point(0, 178)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBar.ShadowDecoration.Parent = Me.progressBar
        Me.progressBar.ShowPercentage = True
        Me.progressBar.Size = New System.Drawing.Size(534, 13)
        Me.progressBar.TabIndex = 14
        Me.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblLoading.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLoading.Location = New System.Drawing.Point(171, 107)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(181, 21)
        Me.lblLoading.TabIndex = 13
        Me.lblLoading.Text = "Loading, Please wait..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 19.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(108, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Entry Monitoring System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Saint Isidore Parish Church"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 191)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents progressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lblLoading As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
