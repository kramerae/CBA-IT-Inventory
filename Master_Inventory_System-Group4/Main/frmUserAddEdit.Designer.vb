<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAddEdit
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblErrorUserName = New System.Windows.Forms.Label()
        Me.lblErrorFirstName = New System.Windows.Forms.Label()
        Me.lblErrorLastName = New System.Windows.Forms.Label()
        Me.lblErrorPassword = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(152, 24)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(152, 51)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(152, 78)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(152, 105)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(191, 132)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(15, 14)
        Me.chkActive.TabIndex = 4
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(50, 27)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 13)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "User Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(53, 54)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(52, 81)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(57, 108)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password:"
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(73, 132)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 9
        Me.lblActive.Text = "Active:"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(53, 171)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(176, 170)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblErrorUserName
        '
        Me.lblErrorUserName.AutoSize = True
        Me.lblErrorUserName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorUserName.Location = New System.Drawing.Point(259, 26)
        Me.lblErrorUserName.Name = "lblErrorUserName"
        Me.lblErrorUserName.Size = New System.Drawing.Size(11, 13)
        Me.lblErrorUserName.TabIndex = 12
        Me.lblErrorUserName.Text = "*"
        Me.lblErrorUserName.Visible = False
        '
        'lblErrorFirstName
        '
        Me.lblErrorFirstName.AutoSize = True
        Me.lblErrorFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorFirstName.Location = New System.Drawing.Point(259, 54)
        Me.lblErrorFirstName.Name = "lblErrorFirstName"
        Me.lblErrorFirstName.Size = New System.Drawing.Size(11, 13)
        Me.lblErrorFirstName.TabIndex = 13
        Me.lblErrorFirstName.Text = "*"
        Me.lblErrorFirstName.Visible = False
        '
        'lblErrorLastName
        '
        Me.lblErrorLastName.AutoSize = True
        Me.lblErrorLastName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLastName.Location = New System.Drawing.Point(259, 81)
        Me.lblErrorLastName.Name = "lblErrorLastName"
        Me.lblErrorLastName.Size = New System.Drawing.Size(11, 13)
        Me.lblErrorLastName.TabIndex = 14
        Me.lblErrorLastName.Text = "*"
        Me.lblErrorLastName.Visible = False
        '
        'lblErrorPassword
        '
        Me.lblErrorPassword.AutoSize = True
        Me.lblErrorPassword.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPassword.Location = New System.Drawing.Point(259, 108)
        Me.lblErrorPassword.Name = "lblErrorPassword"
        Me.lblErrorPassword.Size = New System.Drawing.Size(11, 13)
        Me.lblErrorPassword.TabIndex = 15
        Me.lblErrorPassword.Text = "*"
        Me.lblErrorPassword.Visible = False
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(50, 9)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(188, 13)
        Me.lblErrorMessage.TabIndex = 16
        Me.lblErrorMessage.Text = "* Indicates Required Field Not Entered"
        Me.lblErrorMessage.Visible = False
        '
        'frmUserAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 216)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.lblErrorPassword)
        Me.Controls.Add(Me.lblErrorLastName)
        Me.Controls.Add(Me.lblErrorFirstName)
        Me.Controls.Add(Me.lblErrorUserName)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "frmUserAddEdit"
        Me.Text = "User Add/Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblErrorUserName As System.Windows.Forms.Label
    Friend WithEvents lblErrorFirstName As System.Windows.Forms.Label
    Friend WithEvents lblErrorLastName As System.Windows.Forms.Label
    Friend WithEvents lblErrorPassword As System.Windows.Forms.Label
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
End Class
