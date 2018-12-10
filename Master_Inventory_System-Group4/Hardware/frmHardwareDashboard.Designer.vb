<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardwareDashboard
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
        Me.grdHardware = New System.Windows.Forms.DataGridView()
        Me.cmbHardwareName = New System.Windows.Forms.ComboBox()
        Me.cmbSerialNumber = New System.Windows.Forms.ComboBox()
        Me.cmbServiceTag = New System.Windows.Forms.ComboBox()
        Me.cmbHardwareType = New System.Windows.Forms.ComboBox()
        Me.cmbAssigned = New System.Windows.Forms.ComboBox()
        Me.lblHardwareName = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblServiceTag = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblAssigned = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblModelNumber = New System.Windows.Forms.Label()
        Me.cmbModelNumber = New System.Windows.Forms.ComboBox()
        Me.lblModelName = New System.Windows.Forms.Label()
        Me.cmbModelName = New System.Windows.Forms.ComboBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdHardware
        '
        Me.grdHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdHardware.Location = New System.Drawing.Point(12, 63)
        Me.grdHardware.Name = "grdHardware"
        Me.grdHardware.Size = New System.Drawing.Size(874, 150)
        Me.grdHardware.TabIndex = 0
        '
        'cmbHardwareName
        '
        Me.cmbHardwareName.FormattingEnabled = True
        Me.cmbHardwareName.Location = New System.Drawing.Point(12, 36)
        Me.cmbHardwareName.Name = "cmbHardwareName"
        Me.cmbHardwareName.Size = New System.Drawing.Size(121, 21)
        Me.cmbHardwareName.TabIndex = 1
        '
        'cmbSerialNumber
        '
        Me.cmbSerialNumber.FormattingEnabled = True
        Me.cmbSerialNumber.Location = New System.Drawing.Point(161, 36)
        Me.cmbSerialNumber.Name = "cmbSerialNumber"
        Me.cmbSerialNumber.Size = New System.Drawing.Size(121, 21)
        Me.cmbSerialNumber.TabIndex = 2
        '
        'cmbServiceTag
        '
        Me.cmbServiceTag.FormattingEnabled = True
        Me.cmbServiceTag.Location = New System.Drawing.Point(306, 36)
        Me.cmbServiceTag.Name = "cmbServiceTag"
        Me.cmbServiceTag.Size = New System.Drawing.Size(121, 21)
        Me.cmbServiceTag.TabIndex = 3
        '
        'cmbHardwareType
        '
        Me.cmbHardwareType.FormattingEnabled = True
        Me.cmbHardwareType.Location = New System.Drawing.Point(458, 36)
        Me.cmbHardwareType.Name = "cmbHardwareType"
        Me.cmbHardwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbHardwareType.TabIndex = 4
        '
        'cmbAssigned
        '
        Me.cmbAssigned.FormattingEnabled = True
        Me.cmbAssigned.Location = New System.Drawing.Point(599, 36)
        Me.cmbAssigned.Name = "cmbAssigned"
        Me.cmbAssigned.Size = New System.Drawing.Size(121, 21)
        Me.cmbAssigned.TabIndex = 5
        '
        'lblHardwareName
        '
        Me.lblHardwareName.AutoSize = True
        Me.lblHardwareName.Location = New System.Drawing.Point(9, 20)
        Me.lblHardwareName.Name = "lblHardwareName"
        Me.lblHardwareName.Size = New System.Drawing.Size(84, 13)
        Me.lblHardwareName.TabIndex = 6
        Me.lblHardwareName.Text = "Hardware Name"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Location = New System.Drawing.Point(158, 20)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblSerialNumber.TabIndex = 7
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'lblServiceTag
        '
        Me.lblServiceTag.AutoSize = True
        Me.lblServiceTag.Location = New System.Drawing.Point(303, 20)
        Me.lblServiceTag.Name = "lblServiceTag"
        Me.lblServiceTag.Size = New System.Drawing.Size(65, 13)
        Me.lblServiceTag.TabIndex = 8
        Me.lblServiceTag.Text = "Service Tag"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(455, 20)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 9
        Me.lblType.Text = "Type"
        '
        'lblAssigned
        '
        Me.lblAssigned.AutoSize = True
        Me.lblAssigned.Location = New System.Drawing.Point(596, 20)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(50, 13)
        Me.lblAssigned.TabIndex = 10
        Me.lblAssigned.Text = "Assigned"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(749, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblModelNumber
        '
        Me.lblModelNumber.AutoSize = True
        Me.lblModelNumber.Location = New System.Drawing.Point(905, 122)
        Me.lblModelNumber.Name = "lblModelNumber"
        Me.lblModelNumber.Size = New System.Drawing.Size(76, 13)
        Me.lblModelNumber.TabIndex = 13
        Me.lblModelNumber.Text = "Model Number"
        '
        'cmbModelNumber
        '
        Me.cmbModelNumber.FormattingEnabled = True
        Me.cmbModelNumber.Location = New System.Drawing.Point(908, 138)
        Me.cmbModelNumber.Name = "cmbModelNumber"
        Me.cmbModelNumber.Size = New System.Drawing.Size(121, 21)
        Me.cmbModelNumber.TabIndex = 12
        '
        'lblModelName
        '
        Me.lblModelName.AutoSize = True
        Me.lblModelName.Location = New System.Drawing.Point(905, 72)
        Me.lblModelName.Name = "lblModelName"
        Me.lblModelName.Size = New System.Drawing.Size(67, 13)
        Me.lblModelName.TabIndex = 15
        Me.lblModelName.Text = "Model Name"
        '
        'cmbModelName
        '
        Me.cmbModelName.FormattingEnabled = True
        Me.cmbModelName.Location = New System.Drawing.Point(908, 88)
        Me.cmbModelName.Name = "cmbModelName"
        Me.cmbModelName.Size = New System.Drawing.Size(121, 21)
        Me.cmbModelName.Sorted = True
        Me.cmbModelName.TabIndex = 14
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(905, 20)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 17
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'cmbManufacturer
        '
        Me.cmbManufacturer.FormattingEnabled = True
        Me.cmbManufacturer.Location = New System.Drawing.Point(908, 36)
        Me.cmbManufacturer.Name = "cmbManufacturer"
        Me.cmbManufacturer.Size = New System.Drawing.Size(121, 21)
        Me.cmbManufacturer.TabIndex = 16
        '
        'frmHardwareDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 262)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.cmbManufacturer)
        Me.Controls.Add(Me.lblModelName)
        Me.Controls.Add(Me.cmbModelName)
        Me.Controls.Add(Me.lblModelNumber)
        Me.Controls.Add(Me.cmbModelNumber)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblAssigned)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblServiceTag)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.lblHardwareName)
        Me.Controls.Add(Me.cmbAssigned)
        Me.Controls.Add(Me.cmbHardwareType)
        Me.Controls.Add(Me.cmbServiceTag)
        Me.Controls.Add(Me.cmbSerialNumber)
        Me.Controls.Add(Me.cmbHardwareName)
        Me.Controls.Add(Me.grdHardware)
        Me.Name = "frmHardwareDashboard"
        Me.Text = "frmHardwareDashboard"
        CType(Me.grdHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdHardware As System.Windows.Forms.DataGridView
    Friend WithEvents cmbHardwareName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSerialNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cmbServiceTag As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHardwareType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblHardwareName As System.Windows.Forms.Label
    Friend WithEvents lblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents lblServiceTag As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblAssigned As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblModelNumber As System.Windows.Forms.Label
    Friend WithEvents cmbModelNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lblModelName As System.Windows.Forms.Label
    Friend WithEvents cmbModelName As System.Windows.Forms.ComboBox
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents cmbManufacturer As System.Windows.Forms.ComboBox
End Class
