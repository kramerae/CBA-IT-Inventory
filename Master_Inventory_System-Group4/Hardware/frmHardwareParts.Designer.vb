<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardwareParts
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtHardwarePartName = New System.Windows.Forms.TextBox()
        Me.cmbHardwarePartName = New System.Windows.Forms.ComboBox()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(13, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 286)
        Me.Panel1.TabIndex = 0
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Purple
        Me.lblInstructions.Location = New System.Drawing.Point(13, 74)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(535, 24)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Please build a computer using the available parts below:"
        '
        'txtHardwarePartName
        '
        Me.txtHardwarePartName.Location = New System.Drawing.Point(250, 44)
        Me.txtHardwarePartName.Name = "txtHardwarePartName"
        Me.txtHardwarePartName.Size = New System.Drawing.Size(100, 20)
        Me.txtHardwarePartName.TabIndex = 2
        '
        'cmbHardwarePartName
        '
        Me.cmbHardwarePartName.FormattingEnabled = True
        Me.cmbHardwarePartName.Location = New System.Drawing.Point(13, 44)
        Me.cmbHardwarePartName.Name = "cmbHardwarePartName"
        Me.cmbHardwarePartName.Size = New System.Drawing.Size(121, 21)
        Me.cmbHardwarePartName.TabIndex = 3
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(17, 13)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(67, 17)
        Me.lblSelected.TabIndex = 4
        Me.lblSelected.Text = "Selected:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(247, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(496, 44)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'frmHardwareParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 431)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.cmbHardwarePartName)
        Me.Controls.Add(Me.txtHardwarePartName)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmHardwareParts"
        Me.Text = "frmHardwareParts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents txtHardwarePartName As System.Windows.Forms.TextBox
    Friend WithEvents cmbHardwarePartName As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
End Class
