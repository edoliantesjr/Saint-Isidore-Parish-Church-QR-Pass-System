<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAcct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAcct))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.userPhoto = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnChoose = New Guna.UI2.WinForms.Guna2Button()
        Me.tConfirm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tLast = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tFirst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClearUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveUser = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.userCount = New System.Windows.Forms.Label()
        Me.txtSearchUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.user_dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.userPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.user_dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 2
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(412, 376)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(53, 17)
        Me.Guna2CheckBox1.TabIndex = 79
        Me.Guna2CheckBox1.Text = "Show"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 2
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 1
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2CheckBox1.UseVisualStyleBackColor = True
        '
        'userPhoto
        '
        Me.userPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.userPhoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.userPhoto.BaseColor = System.Drawing.Color.Gainsboro
        Me.userPhoto.Location = New System.Drawing.Point(335, 73)
        Me.userPhoto.Name = "userPhoto"
        Me.userPhoto.Size = New System.Drawing.Size(214, 200)
        Me.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPhoto.TabIndex = 90
        Me.userPhoto.TabStop = False
        '
        'btnChoose
        '
        Me.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChoose.CheckedState.Parent = Me.btnChoose
        Me.btnChoose.CustomImages.Parent = Me.btnChoose
        Me.btnChoose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.ForeColor = System.Drawing.Color.White
        Me.btnChoose.HoverState.Parent = Me.btnChoose
        Me.btnChoose.Location = New System.Drawing.Point(335, 272)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.ShadowDecoration.Parent = Me.btnChoose
        Me.btnChoose.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnChoose.Size = New System.Drawing.Size(214, 29)
        Me.btnChoose.TabIndex = 80
        Me.btnChoose.Text = "Choose  Photo"
        '
        'tConfirm
        '
        Me.tConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tConfirm.DefaultText = ""
        Me.tConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tConfirm.DisabledState.Parent = Me.tConfirm
        Me.tConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tConfirm.FocusedState.Parent = Me.tConfirm
        Me.tConfirm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tConfirm.ForeColor = System.Drawing.Color.Black
        Me.tConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tConfirm.HoverState.Parent = Me.tConfirm
        Me.tConfirm.Location = New System.Drawing.Point(173, 415)
        Me.tConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.tConfirm.Name = "tConfirm"
        Me.tConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tConfirm.PlaceholderText = "Confirm"
        Me.tConfirm.SelectedText = ""
        Me.tConfirm.ShadowDecoration.Parent = Me.tConfirm
        Me.tConfirm.Size = New System.Drawing.Size(301, 37)
        Me.tConfirm.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tConfirm.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(70, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Confirm :"
        '
        'tPass
        '
        Me.tPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tPass.DefaultText = ""
        Me.tPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tPass.DisabledState.Parent = Me.tPass
        Me.tPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tPass.FocusedState.Parent = Me.tPass
        Me.tPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPass.ForeColor = System.Drawing.Color.Black
        Me.tPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tPass.HoverState.Parent = Me.tPass
        Me.tPass.Location = New System.Drawing.Point(173, 366)
        Me.tPass.Margin = New System.Windows.Forms.Padding(4)
        Me.tPass.Name = "tPass"
        Me.tPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tPass.PlaceholderText = "Your Password"
        Me.tPass.SelectedText = ""
        Me.tPass.ShadowDecoration.Parent = Me.tPass
        Me.tPass.Size = New System.Drawing.Size(301, 37)
        Me.tPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tPass.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(70, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 18)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Password :"
        '
        'tUsername
        '
        Me.tUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tUsername.DefaultText = ""
        Me.tUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tUsername.DisabledState.Parent = Me.tUsername
        Me.tUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tUsername.FocusedState.Parent = Me.tUsername
        Me.tUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.ForeColor = System.Drawing.Color.Black
        Me.tUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tUsername.HoverState.Parent = Me.tUsername
        Me.tUsername.Location = New System.Drawing.Point(173, 321)
        Me.tUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tUsername.PlaceholderText = "Your username"
        Me.tUsername.SelectedText = ""
        Me.tUsername.ShadowDecoration.Parent = Me.tUsername
        Me.tUsername.Size = New System.Drawing.Size(301, 37)
        Me.tUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tUsername.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(70, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Username :"
        '
        'tLast
        '
        Me.tLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tLast.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tLast.DefaultText = ""
        Me.tLast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tLast.DisabledState.Parent = Me.tLast
        Me.tLast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tLast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.FocusedState.Parent = Me.tLast
        Me.tLast.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLast.ForeColor = System.Drawing.Color.Black
        Me.tLast.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.HoverState.Parent = Me.tLast
        Me.tLast.Location = New System.Drawing.Point(15, 265)
        Me.tLast.Margin = New System.Windows.Forms.Padding(4)
        Me.tLast.Name = "tLast"
        Me.tLast.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tLast.PlaceholderText = "Lastname"
        Me.tLast.SelectedText = ""
        Me.tLast.ShadowDecoration.Parent = Me.tLast
        Me.tLast.Size = New System.Drawing.Size(314, 37)
        Me.tLast.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tLast.TabIndex = 75
        '
        'tFirst
        '
        Me.tFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tFirst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tFirst.DefaultText = ""
        Me.tFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tFirst.DisabledState.Parent = Me.tFirst
        Me.tFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.FocusedState.Parent = Me.tFirst
        Me.tFirst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFirst.ForeColor = System.Drawing.Color.Black
        Me.tFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.HoverState.Parent = Me.tFirst
        Me.tFirst.Location = New System.Drawing.Point(15, 220)
        Me.tFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.tFirst.Name = "tFirst"
        Me.tFirst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tFirst.PlaceholderText = "Firstname"
        Me.tFirst.SelectedText = ""
        Me.tFirst.ShadowDecoration.Parent = Me.tFirst
        Me.tFirst.Size = New System.Drawing.Size(314, 37)
        Me.tFirst.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tFirst.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Full Name :"
        '
        'btnClearUser
        '
        Me.btnClearUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearUser.Animated = True
        Me.btnClearUser.BackColor = System.Drawing.Color.Transparent
        Me.btnClearUser.BorderRadius = 6
        Me.btnClearUser.CheckedState.Parent = Me.btnClearUser
        Me.btnClearUser.CustomImages.Parent = Me.btnClearUser
        Me.btnClearUser.FillColor = System.Drawing.Color.White
        Me.btnClearUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearUser.ForeColor = System.Drawing.Color.Black
        Me.btnClearUser.HoverState.Parent = Me.btnClearUser
        Me.btnClearUser.Location = New System.Drawing.Point(335, 476)
        Me.btnClearUser.Name = "btnClearUser"
        Me.btnClearUser.ShadowDecoration.Enabled = True
        Me.btnClearUser.ShadowDecoration.Parent = Me.btnClearUser
        Me.btnClearUser.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnClearUser.Size = New System.Drawing.Size(139, 55)
        Me.btnClearUser.TabIndex = 83
        Me.btnClearUser.Text = "Clear"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteUser.BorderRadius = 6
        Me.btnDeleteUser.CheckedState.Parent = Me.btnDeleteUser
        Me.btnDeleteUser.CustomImages.Parent = Me.btnDeleteUser
        Me.btnDeleteUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnDeleteUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUser.HoverState.Parent = Me.btnDeleteUser
        Me.btnDeleteUser.Location = New System.Drawing.Point(183, 476)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.ShadowDecoration.Enabled = True
        Me.btnDeleteUser.ShadowDecoration.Parent = Me.btnDeleteUser
        Me.btnDeleteUser.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnDeleteUser.Size = New System.Drawing.Size(146, 55)
        Me.btnDeleteUser.TabIndex = 82
        Me.btnDeleteUser.Text = "Delete"
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveUser.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveUser.BorderRadius = 6
        Me.btnSaveUser.CheckedState.Parent = Me.btnSaveUser
        Me.btnSaveUser.CustomImages.Parent = Me.btnSaveUser
        Me.btnSaveUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUser.ForeColor = System.Drawing.Color.White
        Me.btnSaveUser.HoverState.Parent = Me.btnSaveUser
        Me.btnSaveUser.Location = New System.Drawing.Point(31, 476)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.ShadowDecoration.Enabled = True
        Me.btnSaveUser.ShadowDecoration.Parent = Me.btnSaveUser
        Me.btnSaveUser.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnSaveUser.Size = New System.Drawing.Size(146, 55)
        Me.btnSaveUser.TabIndex = 81
        Me.btnSaveUser.Text = "Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.userCount)
        Me.GroupBox1.Controls.Add(Me.txtSearchUser)
        Me.GroupBox1.Controls.Add(Me.user_dgview)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(556, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 462)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLICK ACCT. TO MANAGE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Location = New System.Drawing.Point(511, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 5)
        Me.Panel3.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 16)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "to Edit or Delete"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Right Click "
        '
        'userCount
        '
        Me.userCount.AutoSize = True
        Me.userCount.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userCount.Location = New System.Drawing.Point(6, 440)
        Me.userCount.Name = "userCount"
        Me.userCount.Size = New System.Drawing.Size(159, 20)
        Me.userCount.TabIndex = 49
        Me.userCount.Text = "99 Total System Acct."
        '
        'txtSearchUser
        '
        Me.txtSearchUser.AutoRoundedCorners = True
        Me.txtSearchUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtSearchUser.BorderRadius = 16
        Me.txtSearchUser.BorderThickness = 2
        Me.txtSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchUser.DefaultText = ""
        Me.txtSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchUser.DisabledState.Parent = Me.txtSearchUser
        Me.txtSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtSearchUser.FocusedState.Parent = Me.txtSearchUser
        Me.txtSearchUser.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtSearchUser.HoverState.Parent = Me.txtSearchUser
        Me.txtSearchUser.IconRight = CType(resources.GetObject("txtSearchUser.IconRight"), System.Drawing.Image)
        Me.txtSearchUser.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.txtSearchUser.IconRightSize = New System.Drawing.Size(28, 28)
        Me.txtSearchUser.Location = New System.Drawing.Point(118, 49)
        Me.txtSearchUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchUser.PlaceholderText = "Search User Account"
        Me.txtSearchUser.SelectedText = ""
        Me.txtSearchUser.ShadowDecoration.Parent = Me.txtSearchUser
        Me.txtSearchUser.Size = New System.Drawing.Size(262, 35)
        Me.txtSearchUser.TabIndex = 0
        Me.txtSearchUser.TextOffset = New System.Drawing.Point(5, 0)
        '
        'user_dgview
        '
        Me.user_dgview.AllowUserToAddRows = False
        Me.user_dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.user_dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.user_dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.user_dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.user_dgview.BackgroundColor = System.Drawing.Color.White
        Me.user_dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user_dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.user_dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.user_dgview.ColumnHeadersHeight = 25
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.user_dgview.DefaultCellStyle = DataGridViewCellStyle6
        Me.user_dgview.EnableHeadersVisualStyles = False
        Me.user_dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.user_dgview.Location = New System.Drawing.Point(6, 91)
        Me.user_dgview.Name = "user_dgview"
        Me.user_dgview.ReadOnly = True
        Me.user_dgview.RowHeadersVisible = False
        Me.user_dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.user_dgview.Size = New System.Drawing.Size(382, 346)
        Me.user_dgview.TabIndex = 8
        Me.user_dgview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower
        Me.user_dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.user_dgview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.user_dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.user_dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.user_dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.user_dgview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.user_dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.user_dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.user_dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.user_dgview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.user_dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.user_dgview.ThemeStyle.HeaderStyle.Height = 25
        Me.user_dgview.ThemeStyle.ReadOnly = True
        Me.user_dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.user_dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.user_dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.user_dgview.ThemeStyle.RowsStyle.Height = 22
        Me.user_dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.user_dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(10, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(274, 30)
        Me.GunaLabel1.TabIndex = 91
        Me.GunaLabel1.Text = "CREATE ADMIN ACCOUNT"
        '
        'UserAcct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Guna2CheckBox1)
        Me.Controls.Add(Me.userPhoto)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.tConfirm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tUsername)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tLast)
        Me.Controls.Add(Me.tFirst)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClearUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnSaveUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserAcct"
        Me.Size = New System.Drawing.Size(953, 552)
        CType(Me.userPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.user_dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents userPhoto As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnChoose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tConfirm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tLast As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tFirst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClearUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents userCount As Label
    Friend WithEvents txtSearchUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents user_dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
