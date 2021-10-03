<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateQR
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateQR))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.qrPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.qrPic = New Guna.UI2.WinForms.Guna2Panel()
        Me.logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQR = New System.Windows.Forms.Label()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbMunicipal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbPurok = New System.Windows.Forms.ComboBox()
        Me.cmbBarangay = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnQR = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtQR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dgviewPeople = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.rightClickMenu = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.PersonBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.qrPanel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.qrPic.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgviewPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.qrPanel)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.btnClear)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSubmit)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnQR)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtQR)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DimGray
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(555, 527)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Register An Individual"
        '
        'qrPanel
        '
        Me.qrPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qrPanel.BackColor = System.Drawing.Color.Transparent
        Me.qrPanel.BorderColor = System.Drawing.Color.Black
        Me.qrPanel.BorderRadius = 10
        Me.qrPanel.BorderThickness = 2
        Me.qrPanel.Controls.Add(Me.Label4)
        Me.qrPanel.Controls.Add(Me.Guna2Panel2)
        Me.qrPanel.CustomBorderColor = System.Drawing.Color.Black
        Me.qrPanel.FillColor = System.Drawing.Color.White
        Me.qrPanel.ForeColor = System.Drawing.Color.Black
        Me.qrPanel.Location = New System.Drawing.Point(317, 44)
        Me.qrPanel.Name = "qrPanel"
        Me.qrPanel.ShadowDecoration.Parent = Me.qrPanel
        Me.qrPanel.Size = New System.Drawing.Size(229, 271)
        Me.qrPanel.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(69, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "SCAN ME"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.qrPic)
        Me.Guna2Panel2.Controls.Add(Me.lblFullname)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.lblQR)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(213, 230)
        Me.Guna2Panel2.TabIndex = 0
        '
        'qrPic
        '
        Me.qrPic.BackgroundImage = Global.Saint_Isidore_Parish_Church_Entry_System.My.Resources.Resources.QR_Code
        Me.qrPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.qrPic.Controls.Add(Me.logo)
        Me.qrPic.Location = New System.Drawing.Point(9, 28)
        Me.qrPic.Name = "qrPic"
        Me.qrPic.ShadowDecoration.Parent = Me.qrPic
        Me.qrPic.Size = New System.Drawing.Size(194, 175)
        Me.qrPic.TabIndex = 16
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.White
        Me.logo.FillColor = System.Drawing.Color.White
        Me.logo.Image = Global.Saint_Isidore_Parish_Church_Entry_System.My.Resources.Resources.icons8_cross_45px
        Me.logo.Location = New System.Drawing.Point(90, 80)
        Me.logo.Name = "logo"
        Me.logo.ShadowDecoration.Parent = Me.logo
        Me.logo.Size = New System.Drawing.Size(18, 18)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 16
        Me.logo.TabStop = False
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(48, 7)
        Me.lblFullname.MaximumSize = New System.Drawing.Size(155, 16)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(133, 16)
        Me.lblFullname.TabIndex = 15
        Me.lblFullname.Text = "    Hello World          "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name:"
        '
        'lblQR
        '
        Me.lblQR.AutoSize = True
        Me.lblQR.Font = New System.Drawing.Font("Bahnschrift", 12.75!)
        Me.lblQR.ForeColor = System.Drawing.Color.Black
        Me.lblQR.Location = New System.Drawing.Point(61, 205)
        Me.lblQR.Name = "lblQR"
        Me.lblQR.Size = New System.Drawing.Size(90, 21)
        Me.lblQR.TabIndex = 15
        Me.lblQR.Text = "0000-0000"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Animated = True
        Me.btnDelete.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.BorderThickness = 2
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(317, 422)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(229, 45)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Animated = True
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(317, 472)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(107, 45)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Animated = True
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(430, 472)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(116, 45)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbMunicipal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbPurok)
        Me.GroupBox2.Controls.Add(Me.cmbBarangay)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 194)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Purok"
        '
        'cmbMunicipal
        '
        Me.cmbMunicipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMunicipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMunicipal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMunicipal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbMunicipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMunicipal.FormattingEnabled = True
        Me.cmbMunicipal.Items.AddRange(New Object() {"TRINIDAD", "TALIBON", "UBAY"})
        Me.cmbMunicipal.Location = New System.Drawing.Point(6, 155)
        Me.cmbMunicipal.Name = "cmbMunicipal"
        Me.cmbMunicipal.Size = New System.Drawing.Size(284, 28)
        Me.cmbMunicipal.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(6, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Municipality"
        '
        'cmbPurok
        '
        Me.cmbPurok.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPurok.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPurok.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPurok.BackColor = System.Drawing.Color.White
        Me.cmbPurok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPurok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurok.FormattingEnabled = True
        Me.cmbPurok.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cmbPurok.Location = New System.Drawing.Point(6, 47)
        Me.cmbPurok.Name = "cmbPurok"
        Me.cmbPurok.Size = New System.Drawing.Size(284, 28)
        Me.cmbPurok.TabIndex = 0
        '
        'cmbBarangay
        '
        Me.cmbBarangay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBarangay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBarangay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBarangay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarangay.FormattingEnabled = True
        Me.cmbBarangay.Items.AddRange(New Object() {"BANLASAN", "BONGBONG", "CATOOGAN", "GUINOBATAN", "HINLAYAGAN ILAUD", "HINLAYAGN ILAYA", "KAUSWAGAN", "KINAN-OAN", "LA UNION", "LA VICTORIA", "CABIGUHAN", "MAHAGBU", "ROXAS", "POBLACION", "SAN ISIDRO", "SAN VICENTE", "SANTO TOMAS", "SOOM", "TAGUM NORTE", "TAGUM SUR"})
        Me.cmbBarangay.Location = New System.Drawing.Point(6, 101)
        Me.cmbBarangay.Name = "cmbBarangay"
        Me.cmbBarangay.Size = New System.Drawing.Size(284, 28)
        Me.cmbBarangay.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(6, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Barangay"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbSex)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'cmbSex
        '
        Me.cmbSex.BackColor = System.Drawing.Color.Transparent
        Me.cmbSex.BorderColor = System.Drawing.Color.Black
        Me.cmbSex.BorderRadius = 2
        Me.cmbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSex.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSex.FocusedState.Parent = Me.cmbSex
        Me.cmbSex.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cmbSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.HoverState.Parent = Me.cmbSex
        Me.cmbSex.ItemHeight = 30
        Me.cmbSex.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSex.ItemsAppearance.Parent = Me.cmbSex
        Me.cmbSex.Location = New System.Drawing.Point(8, 168)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.ShadowDecoration.Parent = Me.cmbSex
        Me.cmbSex.Size = New System.Drawing.Size(101, 36)
        Me.cmbSex.TabIndex = 2
        '
        'txtFirstname
        '
        Me.txtFirstname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstname.Animated = True
        Me.txtFirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstname.BorderRadius = 2
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.Parent = Me.txtFirstname
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtFirstname.FocusedState.Parent = Me.txtFirstname
        Me.txtFirstname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtFirstname.HoverState.Parent = Me.txtFirstname
        Me.txtFirstname.Location = New System.Drawing.Point(8, 47)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(15, 21, 15, 21)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtFirstname.PlaceholderText = "Your firstname"
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.ShadowDecoration.Parent = Me.txtFirstname
        Me.txtFirstname.Size = New System.Drawing.Size(284, 32)
        Me.txtFirstname.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAge.Animated = True
        Me.txtAge.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAge.BorderRadius = 2
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.Parent = Me.txtAge
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtAge.FocusedState.Parent = Me.txtAge
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtAge.HoverState.Parent = Me.txtAge
        Me.txtAge.Location = New System.Drawing.Point(118, 168)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(22, 34, 22, 34)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtAge.PlaceholderText = "0"
        Me.txtAge.SelectedText = ""
        Me.txtAge.ShadowDecoration.Parent = Me.txtAge
        Me.txtAge.Size = New System.Drawing.Size(47, 36)
        Me.txtAge.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(123, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Age"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(15, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Sex"
        '
        'txtContact
        '
        Me.txtContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContact.Animated = True
        Me.txtContact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.BorderRadius = 2
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = "09"
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.Parent = Me.txtContact
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtContact.FocusedState.Parent = Me.txtContact
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtContact.HoverState.Parent = Me.txtContact
        Me.txtContact.Location = New System.Drawing.Point(173, 168)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(22, 34, 22, 34)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.PlaceholderForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtContact.PlaceholderText = "11digit No"
        Me.txtContact.SelectedText = ""
        Me.txtContact.SelectionStart = 2
        Me.txtContact.ShadowDecoration.Parent = Me.txtContact
        Me.txtContact.Size = New System.Drawing.Size(117, 36)
        Me.txtContact.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(180, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contact No."
        '
        'txtLastname
        '
        Me.txtLastname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastname.Animated = True
        Me.txtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastname.BorderRadius = 2
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.Parent = Me.txtLastname
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtLastname.FocusedState.Parent = Me.txtLastname
        Me.txtLastname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtLastname.HoverState.Parent = Me.txtLastname
        Me.txtLastname.Location = New System.Drawing.Point(6, 103)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(22, 34, 22, 34)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtLastname.PlaceholderText = "Your lastname"
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.ShadowDecoration.Parent = Me.txtLastname
        Me.txtLastname.Size = New System.Drawing.Size(284, 32)
        Me.txtLastname.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(15, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(15, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Firstname"
        '
        'btnQR
        '
        Me.btnQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQR.Animated = True
        Me.btnQR.CheckedState.Parent = Me.btnQR
        Me.btnQR.CustomImages.Parent = Me.btnQR
        Me.btnQR.FillColor = System.Drawing.Color.Gray
        Me.btnQR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQR.ForeColor = System.Drawing.Color.White
        Me.btnQR.HoverState.Parent = Me.btnQR
        Me.btnQR.Location = New System.Drawing.Point(317, 317)
        Me.btnQR.Name = "btnQR"
        Me.btnQR.ShadowDecoration.Parent = Me.btnQR
        Me.btnQR.Size = New System.Drawing.Size(229, 36)
        Me.btnQR.TabIndex = 2
        Me.btnQR.Text = "Save Barcode"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(62, 44)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(52, 23)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "QR ID<font color=""red"">*</font>"
        '
        'txtQR
        '
        Me.txtQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQR.Animated = True
        Me.txtQR.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQR.BorderRadius = 2
        Me.txtQR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQR.DefaultText = ""
        Me.txtQR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQR.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtQR.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txtQR.DisabledState.Parent = Me.txtQR
        Me.txtQR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtQR.FocusedState.Parent = Me.txtQR
        Me.txtQR.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQR.ForeColor = System.Drawing.Color.Black
        Me.txtQR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.txtQR.HoverState.Parent = Me.txtQR
        Me.txtQR.Location = New System.Drawing.Point(62, 67)
        Me.txtQR.Margin = New System.Windows.Forms.Padding(10, 13, 10, 13)
        Me.txtQR.Name = "txtQR"
        Me.txtQR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQR.PlaceholderForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtQR.PlaceholderText = "(e.g. 2021-0001) "
        Me.txtQR.ReadOnly = True
        Me.txtQR.SelectedText = ""
        Me.txtQR.ShadowDecoration.Parent = Me.txtQR
        Me.txtQR.Size = New System.Drawing.Size(240, 32)
        Me.txtQR.TabIndex = 0
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.BorderRadius = 2
        Me.ButtonRefresh.BorderThickness = 1
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.White
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Black
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(704, 93)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(114, 36)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearch.CheckedState.Parent = Me.ButtonSearch
        Me.ButtonSearch.CustomBorderColor = System.Drawing.Color.Blue
        Me.ButtonSearch.CustomImages.Parent = Me.ButtonSearch
        Me.ButtonSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.HoverState.Parent = Me.ButtonSearch
        Me.ButtonSearch.Location = New System.Drawing.Point(825, 94)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.ShadowDecoration.Parent = Me.ButtonSearch
        Me.ButtonSearch.Size = New System.Drawing.Size(117, 36)
        Me.ButtonSearch.TabIndex = 2
        Me.ButtonSearch.Text = "Search"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgviewPeople)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(573, 160)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(369, 380)
        Me.Guna2ShadowPanel1.TabIndex = 8
        '
        'dgviewPeople
        '
        Me.dgviewPeople.AllowUserToAddRows = False
        Me.dgviewPeople.AllowUserToDeleteRows = False
        Me.dgviewPeople.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgviewPeople.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewPeople.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgviewPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgviewPeople.BackgroundColor = System.Drawing.Color.White
        Me.dgviewPeople.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgviewPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewPeople.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewPeople.ColumnHeadersHeight = 38
        Me.dgviewPeople.ContextMenuStrip = Me.rightClickMenu
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewPeople.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewPeople.EnableHeadersVisualStyles = False
        Me.dgviewPeople.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgviewPeople.Location = New System.Drawing.Point(11, 11)
        Me.dgviewPeople.MultiSelect = False
        Me.dgviewPeople.Name = "dgviewPeople"
        Me.dgviewPeople.ReadOnly = True
        Me.dgviewPeople.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewPeople.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewPeople.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgviewPeople.RowTemplate.Height = 40
        Me.dgviewPeople.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewPeople.Size = New System.Drawing.Size(347, 357)
        Me.dgviewPeople.TabIndex = 4
        Me.dgviewPeople.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgviewPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgviewPeople.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgviewPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgviewPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgviewPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgviewPeople.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgviewPeople.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgviewPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgviewPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgviewPeople.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.dgviewPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgviewPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgviewPeople.ThemeStyle.HeaderStyle.Height = 38
        Me.dgviewPeople.ThemeStyle.ReadOnly = True
        Me.dgviewPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgviewPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgviewPeople.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgviewPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgviewPeople.ThemeStyle.RowsStyle.Height = 40
        Me.dgviewPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgviewPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.rightClickMenu.Name = "rightClickMenu"
        Me.rightClickMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rightClickMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.rightClickMenu.RenderStyle.ColorTable = Nothing
        Me.rightClickMenu.RenderStyle.RoundedEdges = True
        Me.rightClickMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.rightClickMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rightClickMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.rightClickMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.rightClickMenu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.rightClickMenu.Size = New System.Drawing.Size(113, 48)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResult.Location = New System.Drawing.Point(580, 134)
        Me.LabelResult.MaximumSize = New System.Drawing.Size(313, 20)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(313, 20)
        Me.LabelResult.TabIndex = 9
        Me.LabelResult.Text = "Search Results for: ""Rolando Edoliantes Jr."""
        Me.LabelResult.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSearch.Location = New System.Drawing.Point(578, 48)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "    Search Person Here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(364, 38)
        Me.txtSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(579, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Manage Personal Information"
        '
        'GenerateQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "GenerateQR"
        Me.Size = New System.Drawing.Size(953, 552)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.qrPanel.ResumeLayout(False)
        Me.qrPanel.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.qrPic.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgviewPeople, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnQR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents qrPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQR As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtQR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbMunicipal As ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dgviewPeople As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LabelResult As Label
    Friend WithEvents PersonBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblFullname As Label
    Public WithEvents cmbPurok As ComboBox
    Friend WithEvents rightClickMenu As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents qrPic As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbBarangay As ComboBox
    Friend WithEvents cmbSex As Guna.UI2.WinForms.Guna2ComboBox
End Class
