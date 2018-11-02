<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParts
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
        Me.grdParts = New System.Windows.Forms.DataGridView()
        Me.lblPartType = New System.Windows.Forms.Label()
        Me.cmbPartType = New System.Windows.Forms.ComboBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        CType(Me.grdParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdParts
        '
        Me.grdParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdParts.Location = New System.Drawing.Point(12, 33)
        Me.grdParts.Name = "grdParts"
        Me.grdParts.Size = New System.Drawing.Size(572, 150)
        Me.grdParts.TabIndex = 0
        '
        'lblPartType
        '
        Me.lblPartType.AutoSize = True
        Me.lblPartType.Location = New System.Drawing.Point(12, 9)
        Me.lblPartType.Name = "lblPartType"
        Me.lblPartType.Size = New System.Drawing.Size(56, 13)
        Me.lblPartType.TabIndex = 1
        Me.lblPartType.Text = "Part Type:"
        '
        'cmbPartType
        '
        Me.cmbPartType.FormattingEnabled = True
        Me.cmbPartType.Location = New System.Drawing.Point(74, 6)
        Me.cmbPartType.Name = "cmbPartType"
        Me.cmbPartType.Size = New System.Drawing.Size(121, 21)
        Me.cmbPartType.TabIndex = 2
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(201, 6)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(78, 23)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(286, 6)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNew.TabIndex = 4
        Me.cmdAddNew.Text = "Add New"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'frmParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(596, 194)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmbPartType)
        Me.Controls.Add(Me.lblPartType)
        Me.Controls.Add(Me.grdParts)
        Me.Name = "frmParts"
        Me.Text = "frmParts"
        CType(Me.grdParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdParts As System.Windows.Forms.DataGridView
    Friend WithEvents lblPartType As System.Windows.Forms.Label
    Friend WithEvents cmbPartType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
End Class
