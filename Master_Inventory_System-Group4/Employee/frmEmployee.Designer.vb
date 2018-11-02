<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.gbxAccountInfo = New System.Windows.Forms.GroupBox()
        Me.txtEid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbxWork = New System.Windows.Forms.GroupBox()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkMailRoster = New System.Windows.Forms.CheckBox()
        Me.txtOutCallerID = New System.Windows.Forms.TextBox()
        Me.chkStaffRoster = New System.Windows.Forms.CheckBox()
        Me.lblOutCallerID = New System.Windows.Forms.Label()
        Me.lblLDCode = New System.Windows.Forms.Label()
        Me.txtLongDistCode = New System.Windows.Forms.TextBox()
        Me.chkLongDist = New System.Windows.Forms.CheckBox()
        Me.chkVoiceMail = New System.Windows.Forms.CheckBox()
        Me.chkCallerID = New System.Windows.Forms.CheckBox()
        Me.chkWPhone = New System.Windows.Forms.CheckBox()
        Me.cmbBuilding = New System.Windows.Forms.ComboBox()
        Me.cmbRoomSub = New System.Windows.Forms.ComboBox()
        Me.cmbRoomNum = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.txtOfficePhoneNum = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.gbxAcademics = New System.Windows.Forms.GroupBox()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.btnEducation = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstTitle = New System.Windows.Forms.ListBox()
        Me.lblEducation = New System.Windows.Forms.Label()
        Me.lstEducation = New System.Windows.Forms.ListBox()
        Me.gbxPersonal = New System.Windows.Forms.GroupBox()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtApt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gbxEmailAccounts = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lstEmailAcc = New System.Windows.Forms.ListBox()
        Me.btnEmailAcc = New System.Windows.Forms.Button()
        Me.gbxMappedDrives = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lstMappedDrives = New System.Windows.Forms.ListBox()
        Me.btnMappedDrives = New System.Windows.Forms.Button()
        Me.gbxListServs = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lstListServs = New System.Windows.Forms.ListBox()
        Me.btnListServs = New System.Windows.Forms.Button()
        Me.gbxADGroups = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lstADGroups = New System.Windows.Forms.ListBox()
        Me.btnADGroups = New System.Windows.Forms.Button()
        Me.btnUpdateAdd = New System.Windows.Forms.Button()
        Me.btnNewStaffCancel = New System.Windows.Forms.Button()
        Me.grdHardware = New System.Windows.Forms.DataGridView()
        Me.lblHardware = New System.Windows.Forms.Label()
        Me.gbxAccountInfo.SuspendLayout()
        Me.gbxWork.SuspendLayout()
        Me.gbxAcademics.SuspendLayout()
        Me.gbxPersonal.SuspendLayout()
        Me.gbxEmailAccounts.SuspendLayout()
        Me.gbxMappedDrives.SuspendLayout()
        Me.gbxListServs.SuspendLayout()
        Me.gbxADGroups.SuspendLayout()
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxAccountInfo
        '
        Me.gbxAccountInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxAccountInfo.Controls.Add(Me.txtEid)
        Me.gbxAccountInfo.Controls.Add(Me.Label14)
        Me.gbxAccountInfo.Controls.Add(Me.txtEmail)
        Me.gbxAccountInfo.Controls.Add(Me.Label13)
        Me.gbxAccountInfo.Controls.Add(Me.txtDate)
        Me.gbxAccountInfo.Controls.Add(Me.lbldate)
        Me.gbxAccountInfo.Controls.Add(Me.txtLastName)
        Me.gbxAccountInfo.Controls.Add(Me.Label11)
        Me.gbxAccountInfo.Controls.Add(Me.txtFirstName)
        Me.gbxAccountInfo.Controls.Add(Me.Label10)
        Me.gbxAccountInfo.Location = New System.Drawing.Point(-6, 25)
        Me.gbxAccountInfo.Name = "gbxAccountInfo"
        Me.gbxAccountInfo.Size = New System.Drawing.Size(510, 105)
        Me.gbxAccountInfo.TabIndex = 1
        Me.gbxAccountInfo.TabStop = False
        Me.gbxAccountInfo.Text = "Account Info"
        '
        'txtEid
        '
        Me.txtEid.Location = New System.Drawing.Point(78, 47)
        Me.txtEid.Name = "txtEid"
        Me.txtEid.Size = New System.Drawing.Size(125, 20)
        Me.txtEid.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "User ID:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(284, 47)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(125, 20)
        Me.txtEmail.TabIndex = 53
        Me.txtEmail.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(241, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Email:"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(283, 73)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(125, 20)
        Me.txtDate.TabIndex = 52
        Me.txtDate.TabStop = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(184, 74)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(95, 16)
        Me.lbldate.TabIndex = 51
        Me.lbldate.Text = "Date Modified:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(283, 19)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtLastName.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(212, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(79, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "First Name:"
        '
        'gbxWork
        '
        Me.gbxWork.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxWork.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxWork.Controls.Add(Me.lblFloor)
        Me.gbxWork.Controls.Add(Me.lblLevel)
        Me.gbxWork.Controls.Add(Me.Label32)
        Me.gbxWork.Controls.Add(Me.chkMailRoster)
        Me.gbxWork.Controls.Add(Me.txtOutCallerID)
        Me.gbxWork.Controls.Add(Me.chkStaffRoster)
        Me.gbxWork.Controls.Add(Me.lblOutCallerID)
        Me.gbxWork.Controls.Add(Me.lblLDCode)
        Me.gbxWork.Controls.Add(Me.txtLongDistCode)
        Me.gbxWork.Controls.Add(Me.chkLongDist)
        Me.gbxWork.Controls.Add(Me.chkVoiceMail)
        Me.gbxWork.Controls.Add(Me.chkCallerID)
        Me.gbxWork.Controls.Add(Me.chkWPhone)
        Me.gbxWork.Controls.Add(Me.cmbBuilding)
        Me.gbxWork.Controls.Add(Me.cmbRoomSub)
        Me.gbxWork.Controls.Add(Me.cmbRoomNum)
        Me.gbxWork.Controls.Add(Me.Label51)
        Me.gbxWork.Controls.Add(Me.Label15)
        Me.gbxWork.Controls.Add(Me.Label25)
        Me.gbxWork.Controls.Add(Me.cboDepartment)
        Me.gbxWork.Controls.Add(Me.txtOfficePhoneNum)
        Me.gbxWork.Controls.Add(Me.Label26)
        Me.gbxWork.Controls.Add(Me.Label27)
        Me.gbxWork.Location = New System.Drawing.Point(-6, 136)
        Me.gbxWork.Name = "gbxWork"
        Me.gbxWork.Size = New System.Drawing.Size(510, 158)
        Me.gbxWork.TabIndex = 3
        Me.gbxWork.TabStop = False
        Me.gbxWork.Text = "Work"
        '
        'lblFloor
        '
        Me.lblFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.Location = New System.Drawing.Point(408, 43)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(77, 18)
        Me.lblFloor.TabIndex = 80
        Me.lblFloor.Text = "FloorXXXX"
        Me.lblFloor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(316, 43)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(87, 15)
        Me.lblLevel.TabIndex = 79
        Me.lblLevel.Text = "Building Level:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(379, 121)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 15)
        Me.Label32.TabIndex = 51
        Me.Label32.Text = "Rosters:"
        '
        'chkMailRoster
        '
        Me.chkMailRoster.AutoSize = True
        Me.chkMailRoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMailRoster.Location = New System.Drawing.Point(440, 136)
        Me.chkMailRoster.Name = "chkMailRoster"
        Me.chkMailRoster.Size = New System.Drawing.Size(50, 19)
        Me.chkMailRoster.TabIndex = 31
        Me.chkMailRoster.Text = "Mail"
        Me.chkMailRoster.UseVisualStyleBackColor = True
        '
        'txtOutCallerID
        '
        Me.txtOutCallerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutCallerID.Location = New System.Drawing.Point(165, 67)
        Me.txtOutCallerID.Name = "txtOutCallerID"
        Me.txtOutCallerID.Size = New System.Drawing.Size(149, 20)
        Me.txtOutCallerID.TabIndex = 24
        '
        'chkStaffRoster
        '
        Me.chkStaffRoster.AutoSize = True
        Me.chkStaffRoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStaffRoster.Location = New System.Drawing.Point(440, 120)
        Me.chkStaffRoster.Name = "chkStaffRoster"
        Me.chkStaffRoster.Size = New System.Drawing.Size(50, 19)
        Me.chkStaffRoster.TabIndex = 30
        Me.chkStaffRoster.Text = "Staff"
        Me.chkStaffRoster.UseVisualStyleBackColor = True
        '
        'lblOutCallerID
        '
        Me.lblOutCallerID.AutoSize = True
        Me.lblOutCallerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutCallerID.Location = New System.Drawing.Point(89, 70)
        Me.lblOutCallerID.Name = "lblOutCallerID"
        Me.lblOutCallerID.Size = New System.Drawing.Size(79, 15)
        Me.lblOutCallerID.TabIndex = 78
        Me.lblOutCallerID.Text = "Out Caller ID:"
        '
        'lblLDCode
        '
        Me.lblLDCode.AutoSize = True
        Me.lblLDCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDCode.Location = New System.Drawing.Point(111, 120)
        Me.lblLDCode.Name = "lblLDCode"
        Me.lblLDCode.Size = New System.Drawing.Size(97, 15)
        Me.lblLDCode.TabIndex = 77
        Me.lblLDCode.Text = "Long Dist. Code:"
        '
        'txtLongDistCode
        '
        Me.txtLongDistCode.Enabled = False
        Me.txtLongDistCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongDistCode.Location = New System.Drawing.Point(214, 117)
        Me.txtLongDistCode.Name = "txtLongDistCode"
        Me.txtLongDistCode.Size = New System.Drawing.Size(100, 20)
        Me.txtLongDistCode.TabIndex = 26
        '
        'chkLongDist
        '
        Me.chkLongDist.AutoSize = True
        Me.chkLongDist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLongDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLongDist.Location = New System.Drawing.Point(3, 119)
        Me.chkLongDist.Name = "chkLongDist"
        Me.chkLongDist.Size = New System.Drawing.Size(84, 19)
        Me.chkLongDist.TabIndex = 26
        Me.chkLongDist.Text = "Long Dist.:"
        Me.chkLongDist.UseVisualStyleBackColor = True
        '
        'chkVoiceMail
        '
        Me.chkVoiceMail.AutoSize = True
        Me.chkVoiceMail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVoiceMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVoiceMail.Location = New System.Drawing.Point(2, 96)
        Me.chkVoiceMail.Name = "chkVoiceMail"
        Me.chkVoiceMail.Size = New System.Drawing.Size(86, 19)
        Me.chkVoiceMail.TabIndex = 25
        Me.chkVoiceMail.Text = "Voice Mail:"
        Me.chkVoiceMail.UseVisualStyleBackColor = True
        '
        'chkCallerID
        '
        Me.chkCallerID.AutoSize = True
        Me.chkCallerID.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCallerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCallerID.Location = New System.Drawing.Point(12, 69)
        Me.chkCallerID.Name = "chkCallerID"
        Me.chkCallerID.Size = New System.Drawing.Size(76, 19)
        Me.chkCallerID.TabIndex = 23
        Me.chkCallerID.Text = "Caller ID:"
        Me.chkCallerID.UseVisualStyleBackColor = True
        '
        'chkWPhone
        '
        Me.chkWPhone.AutoSize = True
        Me.chkWPhone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkWPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWPhone.Location = New System.Drawing.Point(25, 41)
        Me.chkWPhone.Name = "chkWPhone"
        Me.chkWPhone.Size = New System.Drawing.Size(65, 19)
        Me.chkWPhone.TabIndex = 21
        Me.chkWPhone.Text = "Phone:"
        Me.chkWPhone.UseVisualStyleBackColor = True
        '
        'cmbBuilding
        '
        Me.cmbBuilding.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuilding.FormattingEnabled = True
        Me.cmbBuilding.Location = New System.Drawing.Point(382, 12)
        Me.cmbBuilding.Name = "cmbBuilding"
        Me.cmbBuilding.Size = New System.Drawing.Size(106, 21)
        Me.cmbBuilding.TabIndex = 27
        '
        'cmbRoomSub
        '
        Me.cmbRoomSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomSub.FormattingEnabled = True
        Me.cmbRoomSub.Location = New System.Drawing.Point(427, 95)
        Me.cmbRoomSub.Name = "cmbRoomSub"
        Me.cmbRoomSub.Size = New System.Drawing.Size(61, 21)
        Me.cmbRoomSub.TabIndex = 29
        '
        'cmbRoomNum
        '
        Me.cmbRoomNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomNum.FormattingEnabled = True
        Me.cmbRoomNum.Location = New System.Drawing.Point(411, 68)
        Me.cmbRoomNum.Name = "cmbRoomNum"
        Me.cmbRoomNum.Size = New System.Drawing.Size(77, 21)
        Me.cmbRoomNum.TabIndex = 28
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(329, 15)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(55, 15)
        Me.Label51.TabIndex = 66
        Me.Label51.Text = "Building:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(359, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Sub Letter:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 15)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "Department:"
        '
        'cboDepartment
        '
        Me.cboDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(105, 12)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(209, 21)
        Me.cboDepartment.TabIndex = 11
        '
        'txtOfficePhoneNum
        '
        Me.txtOfficePhoneNum.Enabled = False
        Me.txtOfficePhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficePhoneNum.Location = New System.Drawing.Point(189, 40)
        Me.txtOfficePhoneNum.Name = "txtOfficePhoneNum"
        Me.txtOfficePhoneNum.Size = New System.Drawing.Size(125, 20)
        Me.txtOfficePhoneNum.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(91, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 15)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Phone Number:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(315, 71)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 15)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Room Number:"
        '
        'gbxAcademics
        '
        Me.gbxAcademics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxAcademics.Controls.Add(Me.btnTitle)
        Me.gbxAcademics.Controls.Add(Me.btnEducation)
        Me.gbxAcademics.Controls.Add(Me.lblTitle)
        Me.gbxAcademics.Controls.Add(Me.lstTitle)
        Me.gbxAcademics.Controls.Add(Me.lblEducation)
        Me.gbxAcademics.Controls.Add(Me.lstEducation)
        Me.gbxAcademics.Location = New System.Drawing.Point(786, 25)
        Me.gbxAcademics.Name = "gbxAcademics"
        Me.gbxAcademics.Size = New System.Drawing.Size(449, 145)
        Me.gbxAcademics.TabIndex = 4
        Me.gbxAcademics.TabStop = False
        Me.gbxAcademics.Text = "Academics"
        '
        'btnTitle
        '
        Me.btnTitle.BackColor = System.Drawing.Color.Lavender
        Me.btnTitle.Location = New System.Drawing.Point(360, 10)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(84, 23)
        Me.btnTitle.TabIndex = 41
        Me.btnTitle.Text = "Update Title"
        Me.btnTitle.UseVisualStyleBackColor = False
        '
        'btnEducation
        '
        Me.btnEducation.BackColor = System.Drawing.Color.Lavender
        Me.btnEducation.Location = New System.Drawing.Point(95, 10)
        Me.btnEducation.Name = "btnEducation"
        Me.btnEducation.Size = New System.Drawing.Size(122, 23)
        Me.btnEducation.TabIndex = 40
        Me.btnEducation.Text = "Update Education"
        Me.btnEducation.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(231, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Title:"
        '
        'lstTitle
        '
        Me.lstTitle.FormattingEnabled = True
        Me.lstTitle.Location = New System.Drawing.Point(233, 33)
        Me.lstTitle.Name = "lstTitle"
        Me.lstTitle.Size = New System.Drawing.Size(211, 108)
        Me.lstTitle.TabIndex = 2
        '
        'lblEducation
        '
        Me.lblEducation.AutoSize = True
        Me.lblEducation.Location = New System.Drawing.Point(3, 17)
        Me.lblEducation.Name = "lblEducation"
        Me.lblEducation.Size = New System.Drawing.Size(58, 13)
        Me.lblEducation.TabIndex = 1
        Me.lblEducation.Text = "Education:"
        '
        'lstEducation
        '
        Me.lstEducation.FormattingEnabled = True
        Me.lstEducation.Location = New System.Drawing.Point(6, 33)
        Me.lstEducation.Name = "lstEducation"
        Me.lstEducation.Size = New System.Drawing.Size(210, 108)
        Me.lstEducation.TabIndex = 0
        '
        'gbxPersonal
        '
        Me.gbxPersonal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxPersonal.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxPersonal.Controls.Add(Me.txtHomePhone)
        Me.gbxPersonal.Controls.Add(Me.cmbState)
        Me.gbxPersonal.Controls.Add(Me.Label16)
        Me.gbxPersonal.Controls.Add(Me.txtAddress)
        Me.gbxPersonal.Controls.Add(Me.Label17)
        Me.gbxPersonal.Controls.Add(Me.txtCity)
        Me.gbxPersonal.Controls.Add(Me.Label18)
        Me.gbxPersonal.Controls.Add(Me.txtApt)
        Me.gbxPersonal.Controls.Add(Me.Label20)
        Me.gbxPersonal.Controls.Add(Me.Label19)
        Me.gbxPersonal.Controls.Add(Me.Label22)
        Me.gbxPersonal.Controls.Add(Me.txtZip)
        Me.gbxPersonal.Controls.Add(Me.txtCellPhone)
        Me.gbxPersonal.Controls.Add(Me.Label21)
        Me.gbxPersonal.Location = New System.Drawing.Point(510, 25)
        Me.gbxPersonal.Name = "gbxPersonal"
        Me.gbxPersonal.Size = New System.Drawing.Size(261, 174)
        Me.gbxPersonal.TabIndex = 2
        Me.gbxPersonal.TabStop = False
        Me.gbxPersonal.Text = "Personal"
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Location = New System.Drawing.Point(84, 149)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(125, 20)
        Me.txtHomePhone.TabIndex = 10
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.ItemHeight = 13
        Me.cmbState.Location = New System.Drawing.Point(84, 97)
        Me.cmbState.MaxDropDownItems = 100
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(44, 21)
        Me.cmbState.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(84, 19)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(171, 20)
        Me.txtAddress.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(48, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(84, 71)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(149, 20)
        Me.txtCity.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(51, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 16)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Apt:"
        '
        'txtApt
        '
        Me.txtApt.Location = New System.Drawing.Point(84, 45)
        Me.txtApt.Name = "txtApt"
        Me.txtApt.Size = New System.Drawing.Size(171, 20)
        Me.txtApt.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(43, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 16)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "State:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(133, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 16)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Zip:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(4, 153)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 15)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Home Phone:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(166, 98)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(89, 20)
        Me.txtZip.TabIndex = 8
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Location = New System.Drawing.Point(84, 123)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(125, 20)
        Me.txtCellPhone.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 16)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Cell Phone:"
        '
        'gbxEmailAccounts
        '
        Me.gbxEmailAccounts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxEmailAccounts.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxEmailAccounts.Controls.Add(Me.Label31)
        Me.gbxEmailAccounts.Controls.Add(Me.lstEmailAcc)
        Me.gbxEmailAccounts.Controls.Add(Me.btnEmailAcc)
        Me.gbxEmailAccounts.Location = New System.Drawing.Point(1013, 172)
        Me.gbxEmailAccounts.Name = "gbxEmailAccounts"
        Me.gbxEmailAccounts.Size = New System.Drawing.Size(222, 148)
        Me.gbxEmailAccounts.TabIndex = 6
        Me.gbxEmailAccounts.TabStop = False
        Me.gbxEmailAccounts.Text = "Email Accounts"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(184, 13)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Selected email accounts listed below:"
        '
        'lstEmailAcc
        '
        Me.lstEmailAcc.FormattingEnabled = True
        Me.lstEmailAcc.Location = New System.Drawing.Point(6, 66)
        Me.lstEmailAcc.Name = "lstEmailAcc"
        Me.lstEmailAcc.Size = New System.Drawing.Size(210, 69)
        Me.lstEmailAcc.TabIndex = 1
        '
        'btnEmailAcc
        '
        Me.btnEmailAcc.BackColor = System.Drawing.Color.LightBlue
        Me.btnEmailAcc.Location = New System.Drawing.Point(6, 19)
        Me.btnEmailAcc.Name = "btnEmailAcc"
        Me.btnEmailAcc.Size = New System.Drawing.Size(210, 23)
        Me.btnEmailAcc.TabIndex = 43
        Me.btnEmailAcc.Text = "Select email accounts"
        Me.btnEmailAcc.UseVisualStyleBackColor = False
        '
        'gbxMappedDrives
        '
        Me.gbxMappedDrives.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxMappedDrives.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxMappedDrives.Controls.Add(Me.Label30)
        Me.gbxMappedDrives.Controls.Add(Me.lstMappedDrives)
        Me.gbxMappedDrives.Controls.Add(Me.btnMappedDrives)
        Me.gbxMappedDrives.Location = New System.Drawing.Point(786, 172)
        Me.gbxMappedDrives.Name = "gbxMappedDrives"
        Me.gbxMappedDrives.Size = New System.Drawing.Size(222, 148)
        Me.gbxMappedDrives.TabIndex = 5
        Me.gbxMappedDrives.TabStop = False
        Me.gbxMappedDrives.Text = "Mapped Drives"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(182, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Selected mapped drives listed below:"
        '
        'lstMappedDrives
        '
        Me.lstMappedDrives.FormattingEnabled = True
        Me.lstMappedDrives.Location = New System.Drawing.Point(6, 66)
        Me.lstMappedDrives.Name = "lstMappedDrives"
        Me.lstMappedDrives.Size = New System.Drawing.Size(210, 69)
        Me.lstMappedDrives.TabIndex = 1
        '
        'btnMappedDrives
        '
        Me.btnMappedDrives.BackColor = System.Drawing.Color.MistyRose
        Me.btnMappedDrives.Location = New System.Drawing.Point(7, 19)
        Me.btnMappedDrives.Name = "btnMappedDrives"
        Me.btnMappedDrives.Size = New System.Drawing.Size(210, 23)
        Me.btnMappedDrives.TabIndex = 42
        Me.btnMappedDrives.Text = "Select mapped drives"
        Me.btnMappedDrives.UseVisualStyleBackColor = False
        '
        'gbxListServs
        '
        Me.gbxListServs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxListServs.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxListServs.Controls.Add(Me.Label29)
        Me.gbxListServs.Controls.Add(Me.lstListServs)
        Me.gbxListServs.Controls.Add(Me.btnListServs)
        Me.gbxListServs.Location = New System.Drawing.Point(1013, 323)
        Me.gbxListServs.Name = "gbxListServs"
        Me.gbxListServs.Size = New System.Drawing.Size(222, 297)
        Me.gbxListServs.TabIndex = 8
        Me.gbxListServs.TabStop = False
        Me.gbxListServs.Text = "ListServs"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 50)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(150, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Selected listservs listed below:"
        '
        'lstListServs
        '
        Me.lstListServs.FormattingEnabled = True
        Me.lstListServs.Location = New System.Drawing.Point(6, 66)
        Me.lstListServs.Name = "lstListServs"
        Me.lstListServs.Size = New System.Drawing.Size(210, 225)
        Me.lstListServs.TabIndex = 1
        '
        'btnListServs
        '
        Me.btnListServs.BackColor = System.Drawing.Color.PaleGreen
        Me.btnListServs.Location = New System.Drawing.Point(7, 19)
        Me.btnListServs.Name = "btnListServs"
        Me.btnListServs.Size = New System.Drawing.Size(210, 23)
        Me.btnListServs.TabIndex = 45
        Me.btnListServs.Text = "Select listservs"
        Me.btnListServs.UseVisualStyleBackColor = False
        '
        'gbxADGroups
        '
        Me.gbxADGroups.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxADGroups.BackColor = System.Drawing.SystemColors.Menu
        Me.gbxADGroups.Controls.Add(Me.Label28)
        Me.gbxADGroups.Controls.Add(Me.lstADGroups)
        Me.gbxADGroups.Controls.Add(Me.btnADGroups)
        Me.gbxADGroups.Location = New System.Drawing.Point(787, 323)
        Me.gbxADGroups.Name = "gbxADGroups"
        Me.gbxADGroups.Size = New System.Drawing.Size(222, 297)
        Me.gbxADGroups.TabIndex = 7
        Me.gbxADGroups.TabStop = False
        Me.gbxADGroups.Text = "AD Groups"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 50)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(178, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Active Directory groups listed below:"
        '
        'lstADGroups
        '
        Me.lstADGroups.FormattingEnabled = True
        Me.lstADGroups.Location = New System.Drawing.Point(6, 66)
        Me.lstADGroups.Name = "lstADGroups"
        Me.lstADGroups.Size = New System.Drawing.Size(210, 225)
        Me.lstADGroups.TabIndex = 1
        '
        'btnADGroups
        '
        Me.btnADGroups.BackColor = System.Drawing.Color.Moccasin
        Me.btnADGroups.Location = New System.Drawing.Point(7, 19)
        Me.btnADGroups.Name = "btnADGroups"
        Me.btnADGroups.Size = New System.Drawing.Size(210, 23)
        Me.btnADGroups.TabIndex = 44
        Me.btnADGroups.Text = "Select AD Groups"
        Me.btnADGroups.UseVisualStyleBackColor = False
        '
        'btnUpdateAdd
        '
        Me.btnUpdateAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdateAdd.Location = New System.Drawing.Point(328, 611)
        Me.btnUpdateAdd.Name = "btnUpdateAdd"
        Me.btnUpdateAdd.Size = New System.Drawing.Size(453, 29)
        Me.btnUpdateAdd.TabIndex = 55
        Me.btnUpdateAdd.Text = "Update Account"
        Me.btnUpdateAdd.UseVisualStyleBackColor = True
        '
        'btnNewStaffCancel
        '
        Me.btnNewStaffCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNewStaffCancel.Location = New System.Drawing.Point(12, 611)
        Me.btnNewStaffCancel.Name = "btnNewStaffCancel"
        Me.btnNewStaffCancel.Size = New System.Drawing.Size(122, 29)
        Me.btnNewStaffCancel.TabIndex = 56
        Me.btnNewStaffCancel.Text = "Cancel"
        Me.btnNewStaffCancel.UseVisualStyleBackColor = True
        Me.btnNewStaffCancel.Visible = False
        '
        'grdHardware
        '
        Me.grdHardware.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grdHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdHardware.Location = New System.Drawing.Point(-5, 302)
        Me.grdHardware.Name = "grdHardware"
        Me.grdHardware.Size = New System.Drawing.Size(776, 262)
        Me.grdHardware.TabIndex = 57
        '
        'lblHardware
        '
        Me.lblHardware.AutoSize = True
        Me.lblHardware.Location = New System.Drawing.Point(11, 286)
        Me.lblHardware.Name = "lblHardware"
        Me.lblHardware.Size = New System.Drawing.Size(102, 13)
        Me.lblHardware.TabIndex = 58
        Me.lblHardware.Text = "Assigned Hardware:"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1444, 645)
        Me.Controls.Add(Me.gbxAcademics)
        Me.Controls.Add(Me.lblHardware)
        Me.Controls.Add(Me.gbxPersonal)
        Me.Controls.Add(Me.gbxEmailAccounts)
        Me.Controls.Add(Me.grdHardware)
        Me.Controls.Add(Me.gbxMappedDrives)
        Me.Controls.Add(Me.btnNewStaffCancel)
        Me.Controls.Add(Me.gbxListServs)
        Me.Controls.Add(Me.btnUpdateAdd)
        Me.Controls.Add(Me.gbxADGroups)
        Me.Controls.Add(Me.gbxWork)
        Me.Controls.Add(Me.gbxAccountInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        Me.gbxAccountInfo.ResumeLayout(False)
        Me.gbxAccountInfo.PerformLayout()
        Me.gbxWork.ResumeLayout(False)
        Me.gbxWork.PerformLayout()
        Me.gbxAcademics.ResumeLayout(False)
        Me.gbxAcademics.PerformLayout()
        Me.gbxPersonal.ResumeLayout(False)
        Me.gbxPersonal.PerformLayout()
        Me.gbxEmailAccounts.ResumeLayout(False)
        Me.gbxEmailAccounts.PerformLayout()
        Me.gbxMappedDrives.ResumeLayout(False)
        Me.gbxMappedDrives.PerformLayout()
        Me.gbxListServs.ResumeLayout(False)
        Me.gbxListServs.PerformLayout()
        Me.gbxADGroups.ResumeLayout(False)
        Me.gbxADGroups.PerformLayout()
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxAccountInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtEid As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxWork As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBuilding As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRoomSub As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRoomNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtOfficePhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents gbxAcademics As System.Windows.Forms.GroupBox
    Friend WithEvents btnTitle As System.Windows.Forms.Button
    Friend WithEvents btnEducation As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstTitle As System.Windows.Forms.ListBox
    Friend WithEvents lblEducation As System.Windows.Forms.Label
    Friend WithEvents lstEducation As System.Windows.Forms.ListBox
    Friend WithEvents gbxPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtApt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkMailRoster As System.Windows.Forms.CheckBox
    Friend WithEvents chkStaffRoster As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents gbxEmailAccounts As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lstEmailAcc As System.Windows.Forms.ListBox
    Friend WithEvents btnEmailAcc As System.Windows.Forms.Button
    Friend WithEvents gbxMappedDrives As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lstMappedDrives As System.Windows.Forms.ListBox
    Friend WithEvents btnMappedDrives As System.Windows.Forms.Button
    Friend WithEvents gbxListServs As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lstListServs As System.Windows.Forms.ListBox
    Friend WithEvents btnListServs As System.Windows.Forms.Button
    Friend WithEvents gbxADGroups As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lstADGroups As System.Windows.Forms.ListBox
    Friend WithEvents btnADGroups As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAdd As System.Windows.Forms.Button
    Friend WithEvents btnNewStaffCancel As System.Windows.Forms.Button
    Friend WithEvents grdHardware As System.Windows.Forms.DataGridView
    Friend WithEvents lblHardware As System.Windows.Forms.Label
    Friend WithEvents chkVoiceMail As System.Windows.Forms.CheckBox
    Friend WithEvents chkCallerID As System.Windows.Forms.CheckBox
    Friend WithEvents chkWPhone As System.Windows.Forms.CheckBox
    Friend WithEvents txtOutCallerID As System.Windows.Forms.TextBox
    Friend WithEvents lblOutCallerID As System.Windows.Forms.Label
    Friend WithEvents lblLDCode As System.Windows.Forms.Label
    Friend WithEvents txtLongDistCode As System.Windows.Forms.TextBox
    Friend WithEvents chkLongDist As System.Windows.Forms.CheckBox
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
End Class
