<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftware2
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.txtSoftwareVersion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHardwareType = New System.Windows.Forms.Label()
        Me.cmbSoftwareType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lstSoftwareDevices = New System.Windows.Forms.ListBox()
        Me.gbxGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 18)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Software Information"
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareVersion)
        Me.gbxGeneral.Controls.Add(Me.Label10)
        Me.gbxGeneral.Controls.Add(Me.lblHardwareType)
        Me.gbxGeneral.Controls.Add(Me.cmbSoftwareType)
        Me.gbxGeneral.Controls.Add(Me.Label1)
        Me.gbxGeneral.Controls.Add(Me.txtCost)
        Me.gbxGeneral.Controls.Add(Me.Label5)
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareName)
        Me.gbxGeneral.Location = New System.Drawing.Point(15, 39)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(277, 122)
        Me.gbxGeneral.TabIndex = 44
        Me.gbxGeneral.TabStop = False
        Me.gbxGeneral.Text = "General"
        '
        'txtSoftwareVersion
        '
        Me.txtSoftwareVersion.Location = New System.Drawing.Point(141, 36)
        Me.txtSoftwareVersion.Name = "txtSoftwareVersion"
        Me.txtSoftwareVersion.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareVersion.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Software Name"
        '
        'lblHardwareType
        '
        Me.lblHardwareType.AutoSize = True
        Me.lblHardwareType.Location = New System.Drawing.Point(140, 16)
        Me.lblHardwareType.Name = "lblHardwareType"
        Me.lblHardwareType.Size = New System.Drawing.Size(87, 13)
        Me.lblHardwareType.TabIndex = 1
        Me.lblHardwareType.Text = "Software Version"
        '
        'cmbSoftwareType
        '
        Me.cmbSoftwareType.FormattingEnabled = True
        Me.cmbSoftwareType.Location = New System.Drawing.Point(9, 87)
        Me.cmbSoftwareType.Name = "cmbSoftwareType"
        Me.cmbSoftwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Software Type"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(143, 88)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(121, 20)
        Me.txtCost.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cost"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Location = New System.Drawing.Point(9, 36)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareName.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 167)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 13)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Installed on Devices:"
        '
        'lstSoftwareDevices
        '
        Me.lstSoftwareDevices.FormattingEnabled = True
        Me.lstSoftwareDevices.Location = New System.Drawing.Point(15, 183)
        Me.lstSoftwareDevices.Name = "lstSoftwareDevices"
        Me.lstSoftwareDevices.Size = New System.Drawing.Size(210, 225)
        Me.lstSoftwareDevices.TabIndex = 45
        '
        'frmSoftware2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 439)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lstSoftwareDevices)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.Label15)
        Me.Name = "frmSoftware2"
        Me.Text = "Update Software"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents txtSoftwareVersion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHardwareType As Label
    Friend WithEvents cmbSoftwareType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoftwareName As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lstSoftwareDevices As ListBox
End Class
