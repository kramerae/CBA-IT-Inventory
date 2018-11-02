<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartsCategory
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
        Me.lstPartCategory = New System.Windows.Forms.ListBox()
        Me.cmbPartType = New System.Windows.Forms.ComboBox()
        Me.lblPartType = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPartCategory
        '
        Me.lstPartCategory.FormattingEnabled = True
        Me.lstPartCategory.Location = New System.Drawing.Point(12, 146)
        Me.lstPartCategory.Name = "lstPartCategory"
        Me.lstPartCategory.Size = New System.Drawing.Size(259, 160)
        Me.lstPartCategory.TabIndex = 0
        '
        'cmbPartType
        '
        Me.cmbPartType.FormattingEnabled = True
        Me.cmbPartType.Location = New System.Drawing.Point(13, 42)
        Me.cmbPartType.Name = "cmbPartType"
        Me.cmbPartType.Size = New System.Drawing.Size(259, 21)
        Me.cmbPartType.TabIndex = 1
        '
        'lblPartType
        '
        Me.lblPartType.AutoSize = True
        Me.lblPartType.Location = New System.Drawing.Point(13, 23)
        Me.lblPartType.Name = "lblPartType"
        Me.lblPartType.Size = New System.Drawing.Size(53, 13)
        Me.lblPartType.TabIndex = 2
        Me.lblPartType.Text = "Part Type"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(13, 91)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(259, 20)
        Me.txtCategory.TabIndex = 3
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(13, 72)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(12, 117)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'frmPartsCategory
        '
        Me.AcceptButton = Me.cmdAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(284, 315)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblPartType)
        Me.Controls.Add(Me.cmbPartType)
        Me.Controls.Add(Me.lstPartCategory)
        Me.Name = "frmPartsCategory"
        Me.Text = "Parts Categories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPartCategory As System.Windows.Forms.ListBox
    Friend WithEvents cmbPartType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPartType As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
End Class
