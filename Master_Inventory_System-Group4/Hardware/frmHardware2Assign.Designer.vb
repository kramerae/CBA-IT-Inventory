<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardware2Assign
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbHardwareType = New System.Windows.Forms.ComboBox()
        Me.lblHardwareType = New System.Windows.Forms.Label()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerialNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModelNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.txtServiceTag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEmployee = New System.Windows.Forms.ComboBox()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.gbxGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(108, 222)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 222)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Assign"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.Label10)
        Me.gbxGeneral.Controls.Add(Me.cmbHardwareType)
        Me.gbxGeneral.Controls.Add(Me.lblHardwareType)
        Me.gbxGeneral.Controls.Add(Me.cmbManufacturer)
        Me.gbxGeneral.Controls.Add(Me.Label1)
        Me.gbxGeneral.Controls.Add(Me.txtSerialNum)
        Me.gbxGeneral.Controls.Add(Me.Label3)
        Me.gbxGeneral.Controls.Add(Me.txtModelNumber)
        Me.gbxGeneral.Controls.Add(Me.Label5)
        Me.gbxGeneral.Controls.Add(Me.txtDeviceName)
        Me.gbxGeneral.Controls.Add(Me.txtServiceTag)
        Me.gbxGeneral.Controls.Add(Me.Label4)
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 12)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(409, 120)
        Me.gbxGeneral.TabIndex = 36
        Me.gbxGeneral.TabStop = False
        Me.gbxGeneral.Text = "General"
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
        'txtSerialNum
        '
        Me.txtSerialNum.Location = New System.Drawing.Point(277, 88)
        Me.txtSerialNum.Name = "txtSerialNum"
        Me.txtSerialNum.Size = New System.Drawing.Size(121, 20)
        Me.txtSerialNum.TabIndex = 5
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
        'txtModelNumber
        '
        Me.txtModelNumber.Location = New System.Drawing.Point(143, 88)
        Me.txtModelNumber.Name = "txtModelNumber"
        Me.txtModelNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtModelNumber.TabIndex = 4
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
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(9, 36)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(121, 20)
        Me.txtDeviceName.TabIndex = 0
        '
        'txtServiceTag
        '
        Me.txtServiceTag.Location = New System.Drawing.Point(9, 88)
        Me.txtServiceTag.Name = "txtServiceTag"
        Me.txtServiceTag.Size = New System.Drawing.Size(121, 20)
        Me.txtServiceTag.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Service Tag"
        '
        'cmbEmployee
        '
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.Location = New System.Drawing.Point(21, 183)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmployee.TabIndex = 38
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Location = New System.Drawing.Point(18, 167)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(87, 13)
        Me.lblEmployee.TabIndex = 37
        Me.lblEmployee.Text = "Employee Name:"
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.Location = New System.Drawing.Point(9, 144)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(321, 15)
        Me.lblDirections.TabIndex = 39
        Me.lblDirections.Text = "Select user from drop down below to assign this device to:"
        '
        'frmHardware2Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(492, 259)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmHardware2Assign"
        Me.Text = "Assign Hardware"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbHardwareType As ComboBox
    Friend WithEvents lblHardwareType As Label
    Friend WithEvents cmbManufacturer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSerialNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModelNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeviceName As TextBox
    Friend WithEvents txtServiceTag As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblDirections As Label
End Class
