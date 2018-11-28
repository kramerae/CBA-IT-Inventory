<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftwareDashboard
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSoftwareVersion = New System.Windows.Forms.Label()
        Me.lblSoftwareType = New System.Windows.Forms.Label()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.cmbSoftwareVersion = New System.Windows.Forms.ComboBox()
        Me.cmbSoftwareType = New System.Windows.Forms.ComboBox()
        Me.cmbSoftwareName = New System.Windows.Forms.ComboBox()
        Me.grdSoftware = New System.Windows.Forms.DataGridView()
        CType(Me.grdSoftware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(749, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSoftwareVersion
        '
        Me.lblSoftwareVersion.AutoSize = True
        Me.lblSoftwareVersion.Location = New System.Drawing.Point(308, 13)
        Me.lblSoftwareVersion.Name = "lblSoftwareVersion"
        Me.lblSoftwareVersion.Size = New System.Drawing.Size(87, 13)
        Me.lblSoftwareVersion.TabIndex = 18
        Me.lblSoftwareVersion.Text = "Software Version"
        '
        'lblSoftwareType
        '
        Me.lblSoftwareType.AutoSize = True
        Me.lblSoftwareType.Location = New System.Drawing.Point(158, 13)
        Me.lblSoftwareType.Name = "lblSoftwareType"
        Me.lblSoftwareType.Size = New System.Drawing.Size(76, 13)
        Me.lblSoftwareType.TabIndex = 17
        Me.lblSoftwareType.Text = "Software Type"
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(9, 13)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(80, 13)
        Me.lblSoftwareName.TabIndex = 16
        Me.lblSoftwareName.Text = "Software Name"
        '
        'cmbSoftwareVersion
        '
        Me.cmbSoftwareVersion.FormattingEnabled = True
        Me.cmbSoftwareVersion.Location = New System.Drawing.Point(311, 29)
        Me.cmbSoftwareVersion.Name = "cmbSoftwareVersion"
        Me.cmbSoftwareVersion.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareVersion.TabIndex = 15
        '
        'cmbSoftwareType
        '
        Me.cmbSoftwareType.FormattingEnabled = True
        Me.cmbSoftwareType.Location = New System.Drawing.Point(161, 29)
        Me.cmbSoftwareType.Name = "cmbSoftwareType"
        Me.cmbSoftwareType.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareType.TabIndex = 14
        '
        'cmbSoftwareName
        '
        Me.cmbSoftwareName.FormattingEnabled = True
        Me.cmbSoftwareName.Location = New System.Drawing.Point(12, 29)
        Me.cmbSoftwareName.Name = "cmbSoftwareName"
        Me.cmbSoftwareName.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftwareName.TabIndex = 13
        '
        'grdSoftware
        '
        Me.grdSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSoftware.Location = New System.Drawing.Point(12, 56)
        Me.grdSoftware.Name = "grdSoftware"
        Me.grdSoftware.Size = New System.Drawing.Size(874, 150)
        Me.grdSoftware.TabIndex = 12
        '
        'frmSoftwareDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 261)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSoftwareVersion)
        Me.Controls.Add(Me.lblSoftwareType)
        Me.Controls.Add(Me.lblSoftwareName)
        Me.Controls.Add(Me.cmbSoftwareVersion)
        Me.Controls.Add(Me.cmbSoftwareType)
        Me.Controls.Add(Me.cmbSoftwareName)
        Me.Controls.Add(Me.grdSoftware)
        Me.Name = "frmSoftwareDashboard"
        Me.Text = "frmSoftwareDashboard"
        CType(Me.grdSoftware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSoftwareVersion As Label
    Friend WithEvents lblSoftwareType As Label
    Friend WithEvents lblSoftwareName As Label
    Friend WithEvents cmbSoftwareVersion As ComboBox
    Friend WithEvents cmbSoftwareType As ComboBox
    Friend WithEvents cmbSoftwareName As ComboBox
    Friend WithEvents grdSoftware As DataGridView
End Class
