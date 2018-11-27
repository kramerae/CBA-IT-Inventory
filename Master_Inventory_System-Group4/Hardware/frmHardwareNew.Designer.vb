<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardwareNew
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
        Me.cmbHardwareType = New System.Windows.Forms.ComboBox()
        Me.lblHardwareType = New System.Windows.Forms.Label()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSerialNum = New System.Windows.Forms.TextBox()
        Me.txtServiceTag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModelNumber = New System.Windows.Forms.TextBox()
        Me.txtExprServiceTag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWarrantyExpDate = New System.Windows.Forms.TextBox()
        Me.txtPurchaseDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbIPAddress = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtModelName = New System.Windows.Forms.TextBox()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblHDD = New System.Windows.Forms.Label()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.gbxComputer = New System.Windows.Forms.GroupBox()
        Me.txtHDD = New System.Windows.Forms.TextBox()
        Me.txtMemory = New System.Windows.Forms.TextBox()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.gbxNetwork = New System.Windows.Forms.GroupBox()
        Me.gbxMonitor = New System.Windows.Forms.GroupBox()
        Me.txtAspectRatio = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtMount = New System.Windows.Forms.TextBox()
        Me.lblMount = New System.Windows.Forms.Label()
        Me.lblAspectRatio = New System.Windows.Forms.Label()
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.lblResolution = New System.Windows.Forms.Label()
        Me.gbxPrinter = New System.Windows.Forms.GroupBox()
        Me.txtColorInk = New System.Windows.Forms.TextBox()
        Me.lblColorInk = New System.Windows.Forms.Label()
        Me.txtBlackInk = New System.Windows.Forms.TextBox()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.txtPrinterType = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMACAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCurCost = New System.Windows.Forms.TextBox()
        Me.gbxGeneral.SuspendLayout()
        Me.gbxComputer.SuspendLayout()
        Me.gbxNetwork.SuspendLayout()
        Me.gbxMonitor.SuspendLayout()
        Me.gbxPrinter.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbHardwareType
        '
        Me.cmbHardwareType.FormattingEnabled = True
        Me.cmbHardwareType.Location = New System.Drawing.Point(143, 35)
        Me.cmbHardwareType.Name = "cmbHardwareType"
        Me.cmbHardwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbHardwareType.TabIndex = 1
        '
        'lblHardwareType
        '
        Me.lblHardwareType.AutoSize = True
        Me.lblHardwareType.Location = New System.Drawing.Point(140, 16)
        Me.lblHardwareType.Name = "lblHardwareType"
        Me.lblHardwareType.Size = New System.Drawing.Size(80, 13)
        Me.lblHardwareType.TabIndex = 1
        Me.lblHardwareType.Text = "Hardware Type"
        '
        'cmbManufacturer
        '
        Me.cmbManufacturer.FormattingEnabled = True
        Me.cmbManufacturer.Location = New System.Drawing.Point(277, 35)
        Me.cmbManufacturer.Name = "cmbManufacturer"
        Me.cmbManufacturer.Size = New System.Drawing.Size(121, 21)
        Me.cmbManufacturer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manufacturer"
        '
        'cmbOS
        '
        Me.cmbOS.FormattingEnabled = True
        Me.cmbOS.Location = New System.Drawing.Point(9, 36)
        Me.cmbOS.Name = "cmbOS"
        Me.cmbOS.Size = New System.Drawing.Size(121, 21)
        Me.cmbOS.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OS Type"
        '
        'txtSerialNum
        '
        Me.txtSerialNum.Location = New System.Drawing.Point(277, 88)
        Me.txtSerialNum.Name = "txtSerialNum"
        Me.txtSerialNum.Size = New System.Drawing.Size(121, 20)
        Me.txtSerialNum.TabIndex = 5
        '
        'txtServiceTag
        '
        Me.txtServiceTag.Location = New System.Drawing.Point(9, 190)
        Me.txtServiceTag.Name = "txtServiceTag"
        Me.txtServiceTag.Size = New System.Drawing.Size(121, 20)
        Me.txtServiceTag.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Serial Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Service Tag"
        '
        'txtModelNumber
        '
        Me.txtModelNumber.Location = New System.Drawing.Point(143, 88)
        Me.txtModelNumber.Name = "txtModelNumber"
        Me.txtModelNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtModelNumber.TabIndex = 4
        '
        'txtExprServiceTag
        '
        Me.txtExprServiceTag.Location = New System.Drawing.Point(143, 190)
        Me.txtExprServiceTag.Name = "txtExprServiceTag"
        Me.txtExprServiceTag.Size = New System.Drawing.Size(119, 20)
        Me.txtExprServiceTag.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Model Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Expr. Service Tag"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Warranty Exp. Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Purchase Date"
        '
        'txtWarrantyExpDate
        '
        Me.txtWarrantyExpDate.Location = New System.Drawing.Point(277, 141)
        Me.txtWarrantyExpDate.Name = "txtWarrantyExpDate"
        Me.txtWarrantyExpDate.Size = New System.Drawing.Size(119, 20)
        Me.txtWarrantyExpDate.TabIndex = 8
        '
        'txtPurchaseDate
        '
        Me.txtPurchaseDate.Location = New System.Drawing.Point(141, 141)
        Me.txtPurchaseDate.Name = "txtPurchaseDate"
        Me.txtPurchaseDate.Size = New System.Drawing.Size(121, 20)
        Me.txtPurchaseDate.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "IP Address"
        '
        'cmbIPAddress
        '
        Me.cmbIPAddress.FormattingEnabled = True
        Me.cmbIPAddress.Location = New System.Drawing.Point(6, 32)
        Me.cmbIPAddress.Name = "cmbIPAddress"
        Me.cmbIPAddress.Size = New System.Drawing.Size(121, 21)
        Me.cmbIPAddress.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Device Name"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(9, 36)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(121, 20)
        Me.txtDeviceName.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(274, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(277, 190)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(121, 20)
        Me.txtBarcode.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(67, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add Device"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Model Name"
        '
        'txtModelName
        '
        Me.txtModelName.Location = New System.Drawing.Point(9, 88)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(121, 20)
        Me.txtModelName.TabIndex = 3
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Location = New System.Drawing.Point(6, 122)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(44, 13)
        Me.lblMemory.TabIndex = 31
        Me.lblMemory.Text = "Memory"
        '
        'lblHDD
        '
        Me.lblHDD.AutoSize = True
        Me.lblHDD.Location = New System.Drawing.Point(6, 174)
        Me.lblHDD.Name = "lblHDD"
        Me.lblHDD.Size = New System.Drawing.Size(31, 13)
        Me.lblHDD.TabIndex = 32
        Me.lblHDD.Text = "HDD"
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.Label13)
        Me.gbxGeneral.Controls.Add(Me.txtMACAddress)
        Me.gbxGeneral.Controls.Add(Me.Label10)
        Me.gbxGeneral.Controls.Add(Me.cmbHardwareType)
        Me.gbxGeneral.Controls.Add(Me.lblHardwareType)
        Me.gbxGeneral.Controls.Add(Me.cmbManufacturer)
        Me.gbxGeneral.Controls.Add(Me.Label11)
        Me.gbxGeneral.Controls.Add(Me.txtBarcode)
        Me.gbxGeneral.Controls.Add(Me.Label1)
        Me.gbxGeneral.Controls.Add(Me.Label12)
        Me.gbxGeneral.Controls.Add(Me.txtSerialNum)
        Me.gbxGeneral.Controls.Add(Me.txtModelName)
        Me.gbxGeneral.Controls.Add(Me.Label3)
        Me.gbxGeneral.Controls.Add(Me.txtModelNumber)
        Me.gbxGeneral.Controls.Add(Me.Label5)
        Me.gbxGeneral.Controls.Add(Me.Label7)
        Me.gbxGeneral.Controls.Add(Me.txtDeviceName)
        Me.gbxGeneral.Controls.Add(Me.Label8)
        Me.gbxGeneral.Controls.Add(Me.txtWarrantyExpDate)
        Me.gbxGeneral.Controls.Add(Me.txtServiceTag)
        Me.gbxGeneral.Controls.Add(Me.txtPurchaseDate)
        Me.gbxGeneral.Controls.Add(Me.Label4)
        Me.gbxGeneral.Controls.Add(Me.Label6)
        Me.gbxGeneral.Controls.Add(Me.txtExprServiceTag)
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 35)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(409, 223)
        Me.gbxGeneral.TabIndex = 35
        Me.gbxGeneral.TabStop = False
        Me.gbxGeneral.Text = "General"
        '
        'gbxComputer
        '
        Me.gbxComputer.Controls.Add(Me.txtHDD)
        Me.gbxComputer.Controls.Add(Me.txtMemory)
        Me.gbxComputer.Controls.Add(Me.txtCPU)
        Me.gbxComputer.Controls.Add(Me.Label2)
        Me.gbxComputer.Controls.Add(Me.lblCPU)
        Me.gbxComputer.Controls.Add(Me.cmbOS)
        Me.gbxComputer.Controls.Add(Me.lblHDD)
        Me.gbxComputer.Controls.Add(Me.lblMemory)
        Me.gbxComputer.Location = New System.Drawing.Point(428, 35)
        Me.gbxComputer.Name = "gbxComputer"
        Me.gbxComputer.Size = New System.Drawing.Size(142, 223)
        Me.gbxComputer.TabIndex = 36
        Me.gbxComputer.TabStop = False
        Me.gbxComputer.Text = "Computer"
        '
        'txtHDD
        '
        Me.txtHDD.Location = New System.Drawing.Point(9, 190)
        Me.txtHDD.Name = "txtHDD"
        Me.txtHDD.Size = New System.Drawing.Size(120, 20)
        Me.txtHDD.TabIndex = 15
        '
        'txtMemory
        '
        Me.txtMemory.Location = New System.Drawing.Point(9, 141)
        Me.txtMemory.Name = "txtMemory"
        Me.txtMemory.Size = New System.Drawing.Size(120, 20)
        Me.txtMemory.TabIndex = 14
        '
        'txtCPU
        '
        Me.txtCPU.Location = New System.Drawing.Point(9, 88)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(120, 20)
        Me.txtCPU.TabIndex = 13
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.Location = New System.Drawing.Point(6, 69)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(29, 13)
        Me.lblCPU.TabIndex = 35
        Me.lblCPU.Text = "CPU"
        '
        'gbxNetwork
        '
        Me.gbxNetwork.Controls.Add(Me.Label9)
        Me.gbxNetwork.Controls.Add(Me.cmbIPAddress)
        Me.gbxNetwork.Location = New System.Drawing.Point(871, 35)
        Me.gbxNetwork.Name = "gbxNetwork"
        Me.gbxNetwork.Size = New System.Drawing.Size(140, 69)
        Me.gbxNetwork.TabIndex = 37
        Me.gbxNetwork.TabStop = False
        Me.gbxNetwork.Text = "Network"
        '
        'gbxMonitor
        '
        Me.gbxMonitor.Controls.Add(Me.txtAspectRatio)
        Me.gbxMonitor.Controls.Add(Me.txtInput)
        Me.gbxMonitor.Controls.Add(Me.lblInput)
        Me.gbxMonitor.Controls.Add(Me.txtMount)
        Me.gbxMonitor.Controls.Add(Me.lblMount)
        Me.gbxMonitor.Controls.Add(Me.lblAspectRatio)
        Me.gbxMonitor.Controls.Add(Me.txtResolution)
        Me.gbxMonitor.Controls.Add(Me.lblResolution)
        Me.gbxMonitor.Location = New System.Drawing.Point(576, 35)
        Me.gbxMonitor.Name = "gbxMonitor"
        Me.gbxMonitor.Size = New System.Drawing.Size(144, 223)
        Me.gbxMonitor.TabIndex = 38
        Me.gbxMonitor.TabStop = False
        Me.gbxMonitor.Text = "Monitor"
        '
        'txtAspectRatio
        '
        Me.txtAspectRatio.Location = New System.Drawing.Point(10, 88)
        Me.txtAspectRatio.Name = "txtAspectRatio"
        Me.txtAspectRatio.Size = New System.Drawing.Size(124, 20)
        Me.txtAspectRatio.TabIndex = 17
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(10, 191)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(124, 20)
        Me.txtInput.TabIndex = 19
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(10, 174)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "Input"
        '
        'txtMount
        '
        Me.txtMount.Location = New System.Drawing.Point(10, 139)
        Me.txtMount.Name = "txtMount"
        Me.txtMount.Size = New System.Drawing.Size(124, 20)
        Me.txtMount.TabIndex = 18
        '
        'lblMount
        '
        Me.lblMount.AutoSize = True
        Me.lblMount.Location = New System.Drawing.Point(10, 122)
        Me.lblMount.Name = "lblMount"
        Me.lblMount.Size = New System.Drawing.Size(37, 13)
        Me.lblMount.TabIndex = 4
        Me.lblMount.Text = "Mount"
        '
        'lblAspectRatio
        '
        Me.lblAspectRatio.AutoSize = True
        Me.lblAspectRatio.Location = New System.Drawing.Point(10, 68)
        Me.lblAspectRatio.Name = "lblAspectRatio"
        Me.lblAspectRatio.Size = New System.Drawing.Size(68, 13)
        Me.lblAspectRatio.TabIndex = 2
        Me.lblAspectRatio.Text = "Aspect Ratio"
        '
        'txtResolution
        '
        Me.txtResolution.Location = New System.Drawing.Point(10, 33)
        Me.txtResolution.Name = "txtResolution"
        Me.txtResolution.Size = New System.Drawing.Size(124, 20)
        Me.txtResolution.TabIndex = 16
        '
        'lblResolution
        '
        Me.lblResolution.AutoSize = True
        Me.lblResolution.Location = New System.Drawing.Point(7, 16)
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(57, 13)
        Me.lblResolution.TabIndex = 0
        Me.lblResolution.Text = "Resolution"
        '
        'gbxPrinter
        '
        Me.gbxPrinter.Controls.Add(Me.txtColorInk)
        Me.gbxPrinter.Controls.Add(Me.lblColorInk)
        Me.gbxPrinter.Controls.Add(Me.txtBlackInk)
        Me.gbxPrinter.Controls.Add(Me.lblBlack)
        Me.gbxPrinter.Controls.Add(Me.txtPrinterType)
        Me.gbxPrinter.Controls.Add(Me.lblType)
        Me.gbxPrinter.Location = New System.Drawing.Point(726, 35)
        Me.gbxPrinter.Name = "gbxPrinter"
        Me.gbxPrinter.Size = New System.Drawing.Size(139, 223)
        Me.gbxPrinter.TabIndex = 39
        Me.gbxPrinter.TabStop = False
        Me.gbxPrinter.Text = "Printer"
        '
        'txtColorInk
        '
        Me.txtColorInk.Location = New System.Drawing.Point(7, 139)
        Me.txtColorInk.Name = "txtColorInk"
        Me.txtColorInk.Size = New System.Drawing.Size(126, 20)
        Me.txtColorInk.TabIndex = 22
        '
        'lblColorInk
        '
        Me.lblColorInk.AutoSize = True
        Me.lblColorInk.Location = New System.Drawing.Point(12, 122)
        Me.lblColorInk.Name = "lblColorInk"
        Me.lblColorInk.Size = New System.Drawing.Size(49, 13)
        Me.lblColorInk.TabIndex = 4
        Me.lblColorInk.Text = "Color Ink"
        '
        'txtBlackInk
        '
        Me.txtBlackInk.Location = New System.Drawing.Point(7, 88)
        Me.txtBlackInk.Name = "txtBlackInk"
        Me.txtBlackInk.Size = New System.Drawing.Size(126, 20)
        Me.txtBlackInk.TabIndex = 21
        '
        'lblBlack
        '
        Me.lblBlack.AutoSize = True
        Me.lblBlack.Location = New System.Drawing.Point(9, 68)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(52, 13)
        Me.lblBlack.TabIndex = 2
        Me.lblBlack.Text = "Black Ink"
        '
        'txtPrinterType
        '
        Me.txtPrinterType.Location = New System.Drawing.Point(7, 33)
        Me.txtPrinterType.Name = "txtPrinterType"
        Me.txtPrinterType.Size = New System.Drawing.Size(126, 20)
        Me.txtPrinterType.TabIndex = 20
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 16)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 18)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Add New Hardware"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "MAC Address"
        '
        'txtMACAddress
        '
        Me.txtMACAddress.Location = New System.Drawing.Point(9, 141)
        Me.txtMACAddress.Name = "txtMACAddress"
        Me.txtMACAddress.Size = New System.Drawing.Size(121, 20)
        Me.txtMACAddress.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCurCost)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(871, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 69)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cost"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Current Cost"
        '
        'txtCurCost
        '
        Me.txtCurCost.Location = New System.Drawing.Point(6, 35)
        Me.txtCurCost.Name = "txtCurCost"
        Me.txtCurCost.Size = New System.Drawing.Size(126, 20)
        Me.txtCurCost.TabIndex = 20
        '
        'frmHardwareNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(997, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbxPrinter)
        Me.Controls.Add(Me.gbxMonitor)
        Me.Controls.Add(Me.gbxNetwork)
        Me.Controls.Add(Me.gbxComputer)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmHardwareNew"
        Me.Text = "New Hardware"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.gbxComputer.ResumeLayout(False)
        Me.gbxComputer.PerformLayout()
        Me.gbxNetwork.ResumeLayout(False)
        Me.gbxNetwork.PerformLayout()
        Me.gbxMonitor.ResumeLayout(False)
        Me.gbxMonitor.PerformLayout()
        Me.gbxPrinter.ResumeLayout(False)
        Me.gbxPrinter.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbHardwareType As System.Windows.Forms.ComboBox
    Friend WithEvents lblHardwareType As System.Windows.Forms.Label
    Friend WithEvents cmbManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNum As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceTag As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtModelNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtExprServiceTag As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtWarrantyExpDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchaseDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbIPAddress As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtModelName As System.Windows.Forms.TextBox
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents lblHDD As System.Windows.Forms.Label
    Friend WithEvents gbxGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents gbxComputer As System.Windows.Forms.GroupBox
    Friend WithEvents txtCPU As System.Windows.Forms.TextBox
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents gbxNetwork As System.Windows.Forms.GroupBox
    Friend WithEvents gbxMonitor As System.Windows.Forms.GroupBox
    Friend WithEvents lblAspectRatio As System.Windows.Forms.Label
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents lblResolution As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtMount As System.Windows.Forms.TextBox
    Friend WithEvents lblMount As System.Windows.Forms.Label
    Friend WithEvents gbxPrinter As System.Windows.Forms.GroupBox
    Friend WithEvents txtColorInk As System.Windows.Forms.TextBox
    Friend WithEvents lblColorInk As System.Windows.Forms.Label
    Friend WithEvents txtBlackInk As System.Windows.Forms.TextBox
    Friend WithEvents lblBlack As System.Windows.Forms.Label
    Friend WithEvents txtPrinterType As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtHDD As System.Windows.Forms.TextBox
    Friend WithEvents txtMemory As System.Windows.Forms.TextBox
    Friend WithEvents txtAspectRatio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMACAddress As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCurCost As TextBox
    Friend WithEvents Label14 As Label
End Class
