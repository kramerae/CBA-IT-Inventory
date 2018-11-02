<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardware
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHardware))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.TabControlHardware = New System.Windows.Forms.TabControl()
        Me.TabHardware = New System.Windows.Forms.TabPage()
        Me.lblMACAddress = New System.Windows.Forms.Label()
        Me.txtMACAddress = New System.Windows.Forms.TextBox()
        Me.txtModelName = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cboAdapterType = New System.Windows.Forms.ComboBox()
        Me.lblAdapterType = New System.Windows.Forms.Label()
        Me.cboManufacturer = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtComputerIpAddress = New System.Windows.Forms.TextBox()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.txtComputerName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtComputerExpServiceTag = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComputerServiceTag = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtComputerSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboHardwareType = New System.Windows.Forms.ComboBox()
        Me.txtComputerModelNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabSoftware = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtOtherCopy = New System.Windows.Forms.TextBox()
        Me.lblOtherCopy = New System.Windows.Forms.Label()
        Me.chkOtherCopy = New System.Windows.Forms.CheckBox()
        Me.chkCopyOutlook = New System.Windows.Forms.CheckBox()
        Me.chkCopyUser = New System.Windows.Forms.CheckBox()
        Me.gbxAdditionalSoftware = New System.Windows.Forms.GroupBox()
        Me.grdSoftware = New System.Windows.Forms.DataGridView()
        Me.TabAccessories = New System.Windows.Forms.TabPage()
        Me.grpAccessory = New System.Windows.Forms.GroupBox()
        Me.grdAccessory = New System.Windows.Forms.DataGridView()
        Me.txtSLastName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSFirstName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddtoInventory = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControlHardware.SuspendLayout()
        Me.TabHardware.SuspendLayout()
        Me.TabSoftware.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbxAdditionalSoftware.SuspendLayout()
        CType(Me.grdSoftware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAccessories.SuspendLayout()
        Me.grpAccessory.SuspendLayout()
        CType(Me.grdAccessory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(888, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Indigo
        Me.Panel3.Location = New System.Drawing.Point(-6, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 10)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 50)
        Me.Panel1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SlateGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic)
        Me.lblFormTitle.Location = New System.Drawing.Point(12, 119)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(124, 25)
        Me.lblFormTitle.TabIndex = 11
        Me.lblFormTitle.Text = "lblFormTitle"
        '
        'TabControlHardware
        '
        Me.TabControlHardware.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlHardware.Controls.Add(Me.TabHardware)
        Me.TabControlHardware.Controls.Add(Me.TabSoftware)
        Me.TabControlHardware.Controls.Add(Me.TabAccessories)
        Me.TabControlHardware.Location = New System.Drawing.Point(3, 150)
        Me.TabControlHardware.Name = "TabControlHardware"
        Me.TabControlHardware.SelectedIndex = 0
        Me.TabControlHardware.Size = New System.Drawing.Size(962, 248)
        Me.TabControlHardware.TabIndex = 12
        '
        'TabHardware
        '
        Me.TabHardware.BackColor = System.Drawing.SystemColors.Menu
        Me.TabHardware.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabHardware.Controls.Add(Me.lblMACAddress)
        Me.TabHardware.Controls.Add(Me.txtMACAddress)
        Me.TabHardware.Controls.Add(Me.txtModelName)
        Me.TabHardware.Controls.Add(Me.Label43)
        Me.TabHardware.Controls.Add(Me.cboAdapterType)
        Me.TabHardware.Controls.Add(Me.lblAdapterType)
        Me.TabHardware.Controls.Add(Me.cboManufacturer)
        Me.TabHardware.Controls.Add(Me.Label42)
        Me.TabHardware.Controls.Add(Me.txtComputerIpAddress)
        Me.TabHardware.Controls.Add(Me.lblIPAddress)
        Me.TabHardware.Controls.Add(Me.txtComputerName)
        Me.TabHardware.Controls.Add(Me.Label12)
        Me.TabHardware.Controls.Add(Me.txtComputerExpServiceTag)
        Me.TabHardware.Controls.Add(Me.Label9)
        Me.TabHardware.Controls.Add(Me.txtComputerServiceTag)
        Me.TabHardware.Controls.Add(Me.Label8)
        Me.TabHardware.Controls.Add(Me.txtComputerSerialNumber)
        Me.TabHardware.Controls.Add(Me.Label7)
        Me.TabHardware.Controls.Add(Me.cboHardwareType)
        Me.TabHardware.Controls.Add(Me.txtComputerModelNumber)
        Me.TabHardware.Controls.Add(Me.Label5)
        Me.TabHardware.Controls.Add(Me.Label6)
        Me.TabHardware.Location = New System.Drawing.Point(4, 22)
        Me.TabHardware.Name = "TabHardware"
        Me.TabHardware.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHardware.Size = New System.Drawing.Size(954, 222)
        Me.TabHardware.TabIndex = 0
        Me.TabHardware.Text = "Hardware"
        '
        'lblMACAddress
        '
        Me.lblMACAddress.AutoSize = True
        Me.lblMACAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMACAddress.Location = New System.Drawing.Point(525, 93)
        Me.lblMACAddress.Name = "lblMACAddress"
        Me.lblMACAddress.Size = New System.Drawing.Size(94, 16)
        Me.lblMACAddress.TabIndex = 50
        Me.lblMACAddress.Text = "MAC Address:"
        '
        'txtMACAddress
        '
        Me.txtMACAddress.Location = New System.Drawing.Point(624, 92)
        Me.txtMACAddress.Name = "txtMACAddress"
        Me.txtMACAddress.Size = New System.Drawing.Size(125, 20)
        Me.txtMACAddress.TabIndex = 49
        '
        'txtModelName
        '
        Me.txtModelName.Location = New System.Drawing.Point(115, 65)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(121, 20)
        Me.txtModelName.TabIndex = 3
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(270, 92)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(114, 16)
        Me.Label43.TabIndex = 48
        Me.Label43.Text = "Exp. Service Tag:"
        '
        'cboAdapterType
        '
        Me.cboAdapterType.FormattingEnabled = True
        Me.cboAdapterType.Items.AddRange(New Object() {"", "DVI", "VGA", "HDMI", "Display Port"})
        Me.cboAdapterType.Location = New System.Drawing.Point(624, 36)
        Me.cboAdapterType.Name = "cboAdapterType"
        Me.cboAdapterType.Size = New System.Drawing.Size(125, 21)
        Me.cboAdapterType.TabIndex = 10
        '
        'lblAdapterType
        '
        Me.lblAdapterType.AutoSize = True
        Me.lblAdapterType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblAdapterType.Location = New System.Drawing.Point(527, 40)
        Me.lblAdapterType.Name = "lblAdapterType"
        Me.lblAdapterType.Size = New System.Drawing.Size(94, 16)
        Me.lblAdapterType.TabIndex = 46
        Me.lblAdapterType.Text = "Adapter Type:"
        '
        'cboManufacturer
        '
        Me.cboManufacturer.FormattingEnabled = True
        Me.cboManufacturer.Location = New System.Drawing.Point(115, 38)
        Me.cboManufacturer.Name = "cboManufacturer"
        Me.cboManufacturer.Size = New System.Drawing.Size(121, 21)
        Me.cboManufacturer.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(7, 10)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 16)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Hardware Type:"
        '
        'txtComputerIpAddress
        '
        Me.txtComputerIpAddress.Location = New System.Drawing.Point(624, 10)
        Me.txtComputerIpAddress.Name = "txtComputerIpAddress"
        Me.txtComputerIpAddress.Size = New System.Drawing.Size(125, 20)
        Me.txtComputerIpAddress.TabIndex = 9
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPAddress.Location = New System.Drawing.Point(544, 10)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(77, 16)
        Me.lblIPAddress.TabIndex = 26
        Me.lblIPAddress.Text = "IP Address:"
        '
        'txtComputerName
        '
        Me.txtComputerName.Location = New System.Drawing.Point(386, 8)
        Me.txtComputerName.Name = "txtComputerName"
        Me.txtComputerName.Size = New System.Drawing.Size(125, 20)
        Me.txtComputerName.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(259, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Name of Hardware:"
        '
        'txtComputerExpServiceTag
        '
        Me.txtComputerExpServiceTag.Location = New System.Drawing.Point(386, 91)
        Me.txtComputerExpServiceTag.Name = "txtComputerExpServiceTag"
        Me.txtComputerExpServiceTag.Size = New System.Drawing.Size(125, 20)
        Me.txtComputerExpServiceTag.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Model Name:"
        '
        'txtComputerServiceTag
        '
        Me.txtComputerServiceTag.Location = New System.Drawing.Point(386, 64)
        Me.txtComputerServiceTag.Name = "txtComputerServiceTag"
        Me.txtComputerServiceTag.Size = New System.Drawing.Size(125, 20)
        Me.txtComputerServiceTag.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Service Tag:"
        '
        'txtComputerSerialNumber
        '
        Me.txtComputerSerialNumber.Location = New System.Drawing.Point(386, 36)
        Me.txtComputerSerialNumber.Name = "txtComputerSerialNumber"
        Me.txtComputerSerialNumber.Size = New System.Drawing.Size(125, 20)
        Me.txtComputerSerialNumber.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Serial Number:"
        '
        'cboHardwareType
        '
        Me.cboHardwareType.FormattingEnabled = True
        Me.cboHardwareType.Location = New System.Drawing.Point(115, 8)
        Me.cboHardwareType.Name = "cboHardwareType"
        Me.cboHardwareType.Size = New System.Drawing.Size(121, 21)
        Me.cboHardwareType.TabIndex = 1
        '
        'txtComputerModelNumber
        '
        Me.txtComputerModelNumber.Location = New System.Drawing.Point(115, 91)
        Me.txtComputerModelNumber.Name = "txtComputerModelNumber"
        Me.txtComputerModelNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtComputerModelNumber.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Model Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Make:"
        '
        'TabSoftware
        '
        Me.TabSoftware.BackColor = System.Drawing.SystemColors.Menu
        Me.TabSoftware.Controls.Add(Me.GroupBox4)
        Me.TabSoftware.Controls.Add(Me.gbxAdditionalSoftware)
        Me.TabSoftware.Location = New System.Drawing.Point(4, 22)
        Me.TabSoftware.Name = "TabSoftware"
        Me.TabSoftware.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSoftware.Size = New System.Drawing.Size(954, 222)
        Me.TabSoftware.TabIndex = 3
        Me.TabSoftware.Text = "Software"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtOtherCopy)
        Me.GroupBox4.Controls.Add(Me.lblOtherCopy)
        Me.GroupBox4.Controls.Add(Me.chkOtherCopy)
        Me.GroupBox4.Controls.Add(Me.chkCopyOutlook)
        Me.GroupBox4.Controls.Add(Me.chkCopyUser)
        Me.GroupBox4.Location = New System.Drawing.Point(726, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 116)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Specified:"
        '
        'txtOtherCopy
        '
        Me.txtOtherCopy.Enabled = False
        Me.txtOtherCopy.Location = New System.Drawing.Point(100, 81)
        Me.txtOtherCopy.Name = "txtOtherCopy"
        Me.txtOtherCopy.Size = New System.Drawing.Size(100, 20)
        Me.txtOtherCopy.TabIndex = 24
        Me.txtOtherCopy.Visible = False
        '
        'lblOtherCopy
        '
        Me.lblOtherCopy.AutoSize = True
        Me.lblOtherCopy.Enabled = False
        Me.lblOtherCopy.Location = New System.Drawing.Point(6, 84)
        Me.lblOtherCopy.Name = "lblOtherCopy"
        Me.lblOtherCopy.Size = New System.Drawing.Size(90, 13)
        Me.lblOtherCopy.TabIndex = 3
        Me.lblOtherCopy.Text = "Please specify -->"
        Me.lblOtherCopy.Visible = False
        '
        'chkOtherCopy
        '
        Me.chkOtherCopy.AutoSize = True
        Me.chkOtherCopy.Location = New System.Drawing.Point(7, 66)
        Me.chkOtherCopy.Name = "chkOtherCopy"
        Me.chkOtherCopy.Size = New System.Drawing.Size(133, 17)
        Me.chkOtherCopy.TabIndex = 23
        Me.chkOtherCopy.Text = "Anything else to copy?"
        Me.chkOtherCopy.UseVisualStyleBackColor = True
        '
        'chkCopyOutlook
        '
        Me.chkCopyOutlook.AutoSize = True
        Me.chkCopyOutlook.Location = New System.Drawing.Point(6, 43)
        Me.chkCopyOutlook.Name = "chkCopyOutlook"
        Me.chkCopyOutlook.Size = New System.Drawing.Size(111, 17)
        Me.chkCopyOutlook.TabIndex = 22
        Me.chkCopyOutlook.Text = "Copy Outlook files"
        Me.chkCopyOutlook.UseVisualStyleBackColor = True
        '
        'chkCopyUser
        '
        Me.chkCopyUser.AutoSize = True
        Me.chkCopyUser.Location = New System.Drawing.Point(7, 20)
        Me.chkCopyUser.Name = "chkCopyUser"
        Me.chkCopyUser.Size = New System.Drawing.Size(94, 17)
        Me.chkCopyUser.TabIndex = 21
        Me.chkCopyUser.Text = "Copy user files"
        Me.chkCopyUser.UseVisualStyleBackColor = True
        '
        'gbxAdditionalSoftware
        '
        Me.gbxAdditionalSoftware.Controls.Add(Me.grdSoftware)
        Me.gbxAdditionalSoftware.Location = New System.Drawing.Point(9, 8)
        Me.gbxAdditionalSoftware.Name = "gbxAdditionalSoftware"
        Me.gbxAdditionalSoftware.Size = New System.Drawing.Size(710, 208)
        Me.gbxAdditionalSoftware.TabIndex = 3
        Me.gbxAdditionalSoftware.TabStop = False
        Me.gbxAdditionalSoftware.Text = "Software:"
        '
        'grdSoftware
        '
        Me.grdSoftware.AllowUserToAddRows = False
        Me.grdSoftware.AllowUserToDeleteRows = False
        Me.grdSoftware.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.grdSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSoftware.Location = New System.Drawing.Point(7, 15)
        Me.grdSoftware.Name = "grdSoftware"
        Me.grdSoftware.Size = New System.Drawing.Size(697, 187)
        Me.grdSoftware.TabIndex = 20
        '
        'TabAccessories
        '
        Me.TabAccessories.BackColor = System.Drawing.SystemColors.Menu
        Me.TabAccessories.Controls.Add(Me.grpAccessory)
        Me.TabAccessories.Location = New System.Drawing.Point(4, 22)
        Me.TabAccessories.Name = "TabAccessories"
        Me.TabAccessories.Size = New System.Drawing.Size(954, 222)
        Me.TabAccessories.TabIndex = 5
        Me.TabAccessories.Text = "Accessories"
        '
        'grpAccessory
        '
        Me.grpAccessory.Controls.Add(Me.grdAccessory)
        Me.grpAccessory.Location = New System.Drawing.Point(21, 23)
        Me.grpAccessory.Name = "grpAccessory"
        Me.grpAccessory.Size = New System.Drawing.Size(635, 179)
        Me.grpAccessory.TabIndex = 1
        Me.grpAccessory.TabStop = False
        Me.grpAccessory.Text = "Accessories:"
        '
        'grdAccessory
        '
        Me.grdAccessory.AllowUserToAddRows = False
        Me.grdAccessory.AllowUserToDeleteRows = False
        Me.grdAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAccessory.Location = New System.Drawing.Point(12, 19)
        Me.grdAccessory.Name = "grdAccessory"
        Me.grdAccessory.Size = New System.Drawing.Size(612, 150)
        Me.grdAccessory.TabIndex = 0
        '
        'txtSLastName
        '
        Me.txtSLastName.Enabled = False
        Me.txtSLastName.Location = New System.Drawing.Point(566, 124)
        Me.txtSLastName.Name = "txtSLastName"
        Me.txtSLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtSLastName.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(495, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Last Name:"
        '
        'txtSFirstName
        '
        Me.txtSFirstName.Enabled = False
        Me.txtSFirstName.Location = New System.Drawing.Point(350, 124)
        Me.txtSFirstName.Name = "txtSFirstName"
        Me.txtSFirstName.Size = New System.Drawing.Size(125, 20)
        Me.txtSFirstName.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(279, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "First Name:"
        '
        'txtSUserName
        '
        Me.txtSUserName.Enabled = False
        Me.txtSUserName.Location = New System.Drawing.Point(789, 124)
        Me.txtSUserName.Name = "txtSUserName"
        Me.txtSUserName.Size = New System.Drawing.Size(125, 20)
        Me.txtSUserName.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(716, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "User Name:"
        '
        'btnAddtoInventory
        '
        Me.btnAddtoInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddtoInventory.Location = New System.Drawing.Point(734, 402)
        Me.btnAddtoInventory.Name = "btnAddtoInventory"
        Me.btnAddtoInventory.Size = New System.Drawing.Size(219, 33)
        Me.btnAddtoInventory.TabIndex = 13
        Me.btnAddtoInventory.Text = "Add to Inventory"
        Me.btnAddtoInventory.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(581, 402)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 33)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(321, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 35)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Master Inventory System"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Indigo
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Menu
        Me.Label1.Location = New System.Drawing.Point(370, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "College of Business Administration"
        '
        'frmHardware
        '
        Me.AcceptButton = Me.btnAddtoInventory
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(965, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddtoInventory)
        Me.Controls.Add(Me.txtSUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSLastName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSFirstName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControlHardware)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHardware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hardware"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControlHardware.ResumeLayout(False)
        Me.TabHardware.ResumeLayout(False)
        Me.TabHardware.PerformLayout()
        Me.TabSoftware.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbxAdditionalSoftware.ResumeLayout(False)
        CType(Me.grdSoftware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAccessories.ResumeLayout(False)
        Me.grpAccessory.ResumeLayout(False)
        CType(Me.grdAccessory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents TabControlHardware As System.Windows.Forms.TabControl
    Friend WithEvents TabHardware As System.Windows.Forms.TabPage
    Friend WithEvents txtSLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboHardwareType As System.Windows.Forms.ComboBox
    Friend WithEvents txtComputerModelNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtComputerIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents txtComputerName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtComputerExpServiceTag As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComputerServiceTag As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtComputerSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabSoftware As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtherCopy As System.Windows.Forms.TextBox
    Friend WithEvents lblOtherCopy As System.Windows.Forms.Label
    Friend WithEvents chkOtherCopy As System.Windows.Forms.CheckBox
    Friend WithEvents chkCopyOutlook As System.Windows.Forms.CheckBox
    Friend WithEvents chkCopyUser As System.Windows.Forms.CheckBox
    Friend WithEvents gbxAdditionalSoftware As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddtoInventory As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TabAccessories As System.Windows.Forms.TabPage
    Friend WithEvents grdSoftware As System.Windows.Forms.DataGridView
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cboManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents txtModelName As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cboAdapterType As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdapterType As System.Windows.Forms.Label
    Friend WithEvents grpAccessory As System.Windows.Forms.GroupBox
    Friend WithEvents grdAccessory As System.Windows.Forms.DataGridView
    Friend WithEvents lblMACAddress As System.Windows.Forms.Label
    Friend WithEvents txtMACAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
