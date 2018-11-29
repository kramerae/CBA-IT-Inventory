<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignSoftware
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
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grdHardware = New System.Windows.Forms.DataGridView()
        Me.txtSoftwareVersion = New System.Windows.Forms.TextBox()
        Me.cmbSoftwareType = New System.Windows.Forms.ComboBox()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHardwareType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSoftware
        '
        Me.lblSoftware.AutoSize = True
        Me.lblSoftware.Location = New System.Drawing.Point(42, 49)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(52, 13)
        Me.lblSoftware.TabIndex = 1
        Me.lblSoftware.Text = "Software:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(510, 23)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(429, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grdHardware
        '
        Me.grdHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdHardware.Location = New System.Drawing.Point(12, 82)
        Me.grdHardware.Name = "grdHardware"
        Me.grdHardware.Size = New System.Drawing.Size(626, 220)
        Me.grdHardware.TabIndex = 6
        '
        'txtSoftwareVersion
        '
        Me.txtSoftwareVersion.Location = New System.Drawing.Point(141, 36)
        Me.txtSoftwareVersion.Name = "txtSoftwareVersion"
        Me.txtSoftwareVersion.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareVersion.TabIndex = 32
        '
        'cmbSoftwareType
        '
        Me.cmbSoftwareType.FormattingEnabled = True
        Me.cmbSoftwareType.Location = New System.Drawing.Point(273, 35)
        Me.cmbSoftwareType.Name = "cmbSoftwareType"
        Me.cmbSoftwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareType.TabIndex = 2
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareVersion)
        Me.gbxGeneral.Controls.Add(Me.Label10)
        Me.gbxGeneral.Controls.Add(Me.lblHardwareType)
        Me.gbxGeneral.Controls.Add(Me.cmbSoftwareType)
        Me.gbxGeneral.Controls.Add(Me.Label1)
        Me.gbxGeneral.Controls.Add(Me.txtSoftwareName)
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 12)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(404, 64)
        Me.gbxGeneral.TabIndex = 45
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
        'lblHardwareType
        '
        Me.lblHardwareType.AutoSize = True
        Me.lblHardwareType.Location = New System.Drawing.Point(140, 16)
        Me.lblHardwareType.Name = "lblHardwareType"
        Me.lblHardwareType.Size = New System.Drawing.Size(87, 13)
        Me.lblHardwareType.TabIndex = 1
        Me.lblHardwareType.Text = "Software Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Software Type"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Location = New System.Drawing.Point(9, 36)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(121, 20)
        Me.txtSoftwareName.TabIndex = 0
        '
        'frmAssignSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(687, 312)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.grdHardware)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSoftware)
        Me.Name = "frmAssignSoftware"
        Me.Text = "Assign Software"
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grdHardware As System.Windows.Forms.DataGridView
    Friend WithEvents txtSoftwareVersion As TextBox
    Friend WithEvents cmbSoftwareType As ComboBox
    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHardwareType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoftwareName As TextBox
End Class
