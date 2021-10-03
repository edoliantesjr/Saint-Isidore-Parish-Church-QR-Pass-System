<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintBarcode
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.barcodeReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'barcodeReportViewer
        '
        Me.barcodeReportViewer.ActiveViewIndex = -1
        Me.barcodeReportViewer.AutoScroll = True
        Me.barcodeReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.barcodeReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.barcodeReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.barcodeReportViewer.Name = "barcodeReportViewer"
        Me.barcodeReportViewer.ShowCloseButton = False
        Me.barcodeReportViewer.ShowGroupTreeButton = False
        Me.barcodeReportViewer.ShowLogo = False
        Me.barcodeReportViewer.ShowParameterPanelButton = False
        Me.barcodeReportViewer.ShowRefreshButton = False
        Me.barcodeReportViewer.Size = New System.Drawing.Size(953, 552)
        Me.barcodeReportViewer.TabIndex = 0
        Me.barcodeReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Image = Global.Saint_Isidore_Parish_Church_Entry_System.My.Resources.Resources.icons8_print_48px
        Me.Guna2CircleButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(895, 475)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(55, 54)
        Me.Guna2CircleButton1.TabIndex = 6
        '
        'PrintBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.barcodeReportViewer)
        Me.Name = "PrintBarcode"
        Me.Size = New System.Drawing.Size(953, 552)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barcodeReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
End Class
