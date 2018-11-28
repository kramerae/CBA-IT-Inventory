<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftware
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSoftwareType = New System.Windows.Forms.ComboBox()
        Me.lblHardwareType = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSoftwareVersion = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbxGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 176)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 26)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "Add Software"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.Label10)
        Me.gbxGeneral.Controls.Add(Me.cmbSoftwareType)
        Me.gbxGeneral.Controls.Add(Me.lblHardwareType)
        Me.gbxGeneral.Controls.Add(Me.Label12)
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareVersion)
        Me.gbxGeneral.Controls.Add(Me.txtCost)
        Me.gbxGeneral.Controls.Add(Me.Label5)
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareName)
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 42)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(282, 128)
        Me.gbxGeneral.TabIndex = 39
        Me.gbxGeneral.TabStop = False
        Me.gbxGeneral.Text = "General"
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
        'cmbSoftwareType
        '
        Me.cmbSoftwareType.FormattingEnabled = True
        Me.cmbSoftwareType.Location = New System.Drawing.Point(143, 35)
        Me.cmbSoftwareType.Name = "cmbSoftwareType"
        Me.cmbSoftwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareType.TabIndex = 1
        '
        'lblHardwareType
        '
        Me.lblHardwareType.AutoSize = True
        Me.lblHardwareType.Location = New System.Drawing.Point(140, 16)
        Me.lblHardwareType.Name = "lblHardwareType"
        Me.lblHardwareType.Size = New System.Drawing.Size(76, 13)
        Me.lblHardwareType.TabIndex = 1
        Me.lblHardwareType.Text = "Software Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Software Version"
        '
        'txtSoftwareVersion
        '
        Me.txtSoftwareVersion.Location = New System.Drawing.Point(9, 88)
        Me.txtSoftwareVersion.Name = "txtSoftwareVersion"
        Me.txtSoftwareVersion.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareVersion.TabIndex = 3
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
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "License Cost"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Location = New System.Drawing.Point(9, 36)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareName.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 18)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Add New Software"
        '
        'frmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 213)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.Label15)
        Me.Name = "frmSoftware"
        Me.Text = "frmSoftware"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbSoftwareType As ComboBox
    Friend WithEvents lblHardwareType As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSoftwareVersion As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoftwareName As TextBox
    Friend WithEvents Label15 As Label
End Class
