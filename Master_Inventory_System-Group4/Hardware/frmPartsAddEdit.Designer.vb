<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartsAddEdit
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
        Me.lblPartType = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblCategory1 = New System.Windows.Forms.Label()
        Me.lblCategory2 = New System.Windows.Forms.Label()
        Me.lblCategory3 = New System.Windows.Forms.Label()
        Me.lblCategory4 = New System.Windows.Forms.Label()
        Me.lblCategory5 = New System.Windows.Forms.Label()
        Me.lblCategory6 = New System.Windows.Forms.Label()
        Me.lblCategory7 = New System.Windows.Forms.Label()
        Me.txtCategory1 = New System.Windows.Forms.TextBox()
        Me.txtCategory2 = New System.Windows.Forms.TextBox()
        Me.txtCategory3 = New System.Windows.Forms.TextBox()
        Me.txtCategory4 = New System.Windows.Forms.TextBox()
        Me.txtCategory5 = New System.Windows.Forms.TextBox()
        Me.txtCategory6 = New System.Windows.Forms.TextBox()
        Me.txtCategory7 = New System.Windows.Forms.TextBox()
        Me.cmbManufacturer = New System.Windows.Forms.ComboBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPartType
        '
        Me.lblPartType.AutoSize = True
        Me.lblPartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartType.Location = New System.Drawing.Point(101, 9)
        Me.lblPartType.Name = "lblPartType"
        Me.lblPartType.Size = New System.Drawing.Size(85, 20)
        Me.lblPartType.TabIndex = 0
        Me.lblPartType.Text = "Part Type"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(13, 44)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(73, 13)
        Me.lblManufacturer.TabIndex = 1
        Me.lblManufacturer.Text = "Manufacturer:"
        '
        'lblCategory1
        '
        Me.lblCategory1.AutoSize = True
        Me.lblCategory1.Location = New System.Drawing.Point(12, 70)
        Me.lblCategory1.Name = "lblCategory1"
        Me.lblCategory1.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory1.TabIndex = 2
        Me.lblCategory1.Text = "Category1:"
        '
        'lblCategory2
        '
        Me.lblCategory2.AutoSize = True
        Me.lblCategory2.Location = New System.Drawing.Point(13, 96)
        Me.lblCategory2.Name = "lblCategory2"
        Me.lblCategory2.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory2.TabIndex = 3
        Me.lblCategory2.Text = "Category2:"
        '
        'lblCategory3
        '
        Me.lblCategory3.AutoSize = True
        Me.lblCategory3.Location = New System.Drawing.Point(13, 122)
        Me.lblCategory3.Name = "lblCategory3"
        Me.lblCategory3.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory3.TabIndex = 4
        Me.lblCategory3.Text = "Category3:"
        '
        'lblCategory4
        '
        Me.lblCategory4.AutoSize = True
        Me.lblCategory4.Location = New System.Drawing.Point(13, 148)
        Me.lblCategory4.Name = "lblCategory4"
        Me.lblCategory4.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory4.TabIndex = 5
        Me.lblCategory4.Text = "Category4:"
        '
        'lblCategory5
        '
        Me.lblCategory5.AutoSize = True
        Me.lblCategory5.Location = New System.Drawing.Point(13, 174)
        Me.lblCategory5.Name = "lblCategory5"
        Me.lblCategory5.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory5.TabIndex = 6
        Me.lblCategory5.Text = "Category5:"
        '
        'lblCategory6
        '
        Me.lblCategory6.AutoSize = True
        Me.lblCategory6.Location = New System.Drawing.Point(13, 200)
        Me.lblCategory6.Name = "lblCategory6"
        Me.lblCategory6.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory6.TabIndex = 7
        Me.lblCategory6.Text = "Category6:"
        '
        'lblCategory7
        '
        Me.lblCategory7.AutoSize = True
        Me.lblCategory7.Location = New System.Drawing.Point(13, 226)
        Me.lblCategory7.Name = "lblCategory7"
        Me.lblCategory7.Size = New System.Drawing.Size(58, 13)
        Me.lblCategory7.TabIndex = 8
        Me.lblCategory7.Text = "Category7:"
        '
        'txtCategory1
        '
        Me.txtCategory1.Location = New System.Drawing.Point(172, 67)
        Me.txtCategory1.Name = "txtCategory1"
        Me.txtCategory1.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory1.TabIndex = 10
        '
        'txtCategory2
        '
        Me.txtCategory2.Location = New System.Drawing.Point(172, 93)
        Me.txtCategory2.Name = "txtCategory2"
        Me.txtCategory2.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory2.TabIndex = 11
        '
        'txtCategory3
        '
        Me.txtCategory3.Location = New System.Drawing.Point(172, 119)
        Me.txtCategory3.Name = "txtCategory3"
        Me.txtCategory3.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory3.TabIndex = 12
        '
        'txtCategory4
        '
        Me.txtCategory4.Location = New System.Drawing.Point(172, 145)
        Me.txtCategory4.Name = "txtCategory4"
        Me.txtCategory4.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory4.TabIndex = 13
        '
        'txtCategory5
        '
        Me.txtCategory5.Location = New System.Drawing.Point(172, 171)
        Me.txtCategory5.Name = "txtCategory5"
        Me.txtCategory5.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory5.TabIndex = 15
        '
        'txtCategory6
        '
        Me.txtCategory6.Location = New System.Drawing.Point(172, 197)
        Me.txtCategory6.Name = "txtCategory6"
        Me.txtCategory6.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory6.TabIndex = 16
        '
        'txtCategory7
        '
        Me.txtCategory7.Location = New System.Drawing.Point(172, 223)
        Me.txtCategory7.Name = "txtCategory7"
        Me.txtCategory7.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory7.TabIndex = 17
        '
        'cmbManufacturer
        '
        Me.cmbManufacturer.FormattingEnabled = True
        Me.cmbManufacturer.Location = New System.Drawing.Point(172, 40)
        Me.cmbManufacturer.Name = "cmbManufacturer"
        Me.cmbManufacturer.Size = New System.Drawing.Size(100, 21)
        Me.cmbManufacturer.TabIndex = 18
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(105, 250)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'frmPartsAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 285)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmbManufacturer)
        Me.Controls.Add(Me.txtCategory7)
        Me.Controls.Add(Me.txtCategory6)
        Me.Controls.Add(Me.txtCategory5)
        Me.Controls.Add(Me.txtCategory4)
        Me.Controls.Add(Me.txtCategory3)
        Me.Controls.Add(Me.txtCategory2)
        Me.Controls.Add(Me.txtCategory1)
        Me.Controls.Add(Me.lblCategory7)
        Me.Controls.Add(Me.lblCategory6)
        Me.Controls.Add(Me.lblCategory5)
        Me.Controls.Add(Me.lblCategory4)
        Me.Controls.Add(Me.lblCategory3)
        Me.Controls.Add(Me.lblCategory2)
        Me.Controls.Add(Me.lblCategory1)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.lblPartType)
        Me.Name = "frmPartsAddEdit"
        Me.Text = "frmPartsAddEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPartType As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblCategory1 As System.Windows.Forms.Label
    Friend WithEvents lblCategory2 As System.Windows.Forms.Label
    Friend WithEvents lblCategory3 As System.Windows.Forms.Label
    Friend WithEvents lblCategory4 As System.Windows.Forms.Label
    Friend WithEvents lblCategory5 As System.Windows.Forms.Label
    Friend WithEvents lblCategory6 As System.Windows.Forms.Label
    Friend WithEvents lblCategory7 As System.Windows.Forms.Label
    Friend WithEvents txtCategory1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory6 As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory7 As System.Windows.Forms.TextBox
    Friend WithEvents cmbManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
