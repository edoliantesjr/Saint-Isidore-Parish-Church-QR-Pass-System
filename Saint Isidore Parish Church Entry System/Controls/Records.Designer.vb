<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.dgviewRecord = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLoadRecord = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbMass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.srchStudent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgviewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgviewRecord)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(3, 98)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(944, 445)
        Me.Guna2ShadowPanel1.TabIndex = 42
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
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(854, 360)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(55, 54)
        Me.Guna2CircleButton1.TabIndex = 5
        '
        'dgviewRecord
        '
        Me.dgviewRecord.AllowUserToAddRows = False
        Me.dgviewRecord.AllowUserToDeleteRows = False
        Me.dgviewRecord.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.dgviewRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgviewRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgviewRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewRecord.BackgroundColor = System.Drawing.Color.White
        Me.dgviewRecord.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgviewRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgviewRecord.ColumnHeadersHeight = 38
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewRecord.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgviewRecord.EnableHeadersVisualStyles = False
        Me.dgviewRecord.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgviewRecord.Location = New System.Drawing.Point(11, 11)
        Me.dgviewRecord.MultiSelect = False
        Me.dgviewRecord.Name = "dgviewRecord"
        Me.dgviewRecord.ReadOnly = True
        Me.dgviewRecord.RowHeadersVisible = False
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewRecord.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgviewRecord.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgviewRecord.RowTemplate.Height = 40
        Me.dgviewRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewRecord.Size = New System.Drawing.Size(922, 422)
        Me.dgviewRecord.TabIndex = 4
        Me.dgviewRecord.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgviewRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgviewRecord.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgviewRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgviewRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgviewRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgviewRecord.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgviewRecord.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgviewRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgviewRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgviewRecord.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.dgviewRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgviewRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgviewRecord.ThemeStyle.HeaderStyle.Height = 38
        Me.dgviewRecord.ThemeStyle.ReadOnly = True
        Me.dgviewRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgviewRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgviewRecord.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgviewRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgviewRecord.ThemeStyle.RowsStyle.Height = 40
        Me.dgviewRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgviewRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(523, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 22)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Select Specific Person"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(281, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Mass Schedule"
        '
        'btnLoadRecord
        '
        Me.btnLoadRecord.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLoadRecord.AutoRoundedCorners = True
        Me.btnLoadRecord.BorderRadius = 21
        Me.btnLoadRecord.CheckedState.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.CustomImages.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadRecord.ForeColor = System.Drawing.Color.White
        Me.btnLoadRecord.HoverState.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Location = New System.Drawing.Point(770, 46)
        Me.btnLoadRecord.Name = "btnLoadRecord"
        Me.btnLoadRecord.ShadowDecoration.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Size = New System.Drawing.Size(166, 45)
        Me.btnLoadRecord.TabIndex = 43
        Me.btnLoadRecord.Text = "GO"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 22)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Mass/Event Date"
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDate.CheckedState.Parent = Me.dtpDate
        Me.dtpDate.FillColor = System.Drawing.Color.White
        Me.dtpDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.HoverState.Parent = Me.dtpDate
        Me.dtpDate.Location = New System.Drawing.Point(35, 56)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(2000, 12, 12, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShadowDecoration.Parent = Me.dtpDate
        Me.dtpDate.Size = New System.Drawing.Size(216, 36)
        Me.dtpDate.TabIndex = 51
        Me.dtpDate.Value = New Date(2021, 4, 9, 21, 35, 6, 913)
        '
        'cmbMass
        '
        Me.cmbMass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbMass.BackColor = System.Drawing.Color.Transparent
        Me.cmbMass.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMass.BorderRadius = 2
        Me.cmbMass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMass.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbMass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbMass.FocusedState.Parent = Me.cmbMass
        Me.cmbMass.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMass.FormattingEnabled = True
        Me.cmbMass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbMass.HoverState.Parent = Me.cmbMass
        Me.cmbMass.ItemHeight = 30
        Me.cmbMass.ItemsAppearance.Parent = Me.cmbMass
        Me.cmbMass.Location = New System.Drawing.Point(285, 56)
        Me.cmbMass.Name = "cmbMass"
        Me.cmbMass.ShadowDecoration.Parent = Me.cmbMass
        Me.cmbMass.Size = New System.Drawing.Size(210, 36)
        Me.cmbMass.TabIndex = 52
        '
        'srchStudent
        '
        Me.srchStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.srchStudent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.srchStudent.DefaultText = ""
        Me.srchStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.srchStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.srchStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchStudent.DisabledState.Parent = Me.srchStudent
        Me.srchStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchStudent.FocusedState.Parent = Me.srchStudent
        Me.srchStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.srchStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchStudent.HoverState.Parent = Me.srchStudent
        Me.srchStudent.IconRight = CType(resources.GetObject("srchStudent.IconRight"), System.Drawing.Image)
        Me.srchStudent.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.srchStudent.IconRightSize = New System.Drawing.Size(30, 30)
        Me.srchStudent.Location = New System.Drawing.Point(526, 55)
        Me.srchStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchStudent.Name = "srchStudent"
        Me.srchStudent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.srchStudent.PlaceholderText = "Look Up"
        Me.srchStudent.SelectedText = ""
        Me.srchStudent.ShadowDecoration.Parent = Me.srchStudent
        Me.srchStudent.Size = New System.Drawing.Size(200, 36)
        Me.srchStudent.TabIndex = 44
        Me.srchStudent.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbMass)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.srchStudent)
        Me.Controls.Add(Me.btnLoadRecord)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Name = "Records"
        Me.Size = New System.Drawing.Size(953, 546)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgviewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dgviewRecord As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents srchStudent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLoadRecord As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbMass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
End Class
