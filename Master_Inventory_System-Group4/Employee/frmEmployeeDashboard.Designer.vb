<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grdEmployee = New System.Windows.Forms.DataGridView()
        Me.cmbSearchLastName = New System.Windows.Forms.ComboBox()
        Me.cmbSearchFirstName = New System.Windows.Forms.ComboBox()
        Me.cmbSearchEID = New System.Windows.Forms.ComboBox()
        Me.cmbSearchDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbSearchADGroup = New System.Windows.Forms.ComboBox()
        Me.cmbSearchListServ = New System.Windows.Forms.ComboBox()
        Me.lblSearchLastName = New System.Windows.Forms.Label()
        Me.lblSearchFirstName = New System.Windows.Forms.Label()
        Me.lblSearchEID = New System.Windows.Forms.Label()
        Me.lblSearchDepartment = New System.Windows.Forms.Label()
        Me.lblSearchADGroup = New System.Windows.Forms.Label()
        Me.lblSearchListServ = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmbSearchRoom = New System.Windows.Forms.ComboBox()
        Me.lblSearchRoom = New System.Windows.Forms.Label()
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEmployee
        '
        Me.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmployee.Location = New System.Drawing.Point(13, 54)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(785, 230)
        Me.grdEmployee.TabIndex = 0
        '
        'cmbSearchLastName
        '
        Me.cmbSearchLastName.FormattingEnabled = True
        Me.cmbSearchLastName.Location = New System.Drawing.Point(13, 25)
        Me.cmbSearchLastName.Name = "cmbSearchLastName"
        Me.cmbSearchLastName.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchLastName.TabIndex = 1
        '
        'cmbSearchFirstName
        '
        Me.cmbSearchFirstName.FormattingEnabled = True
        Me.cmbSearchFirstName.Location = New System.Drawing.Point(141, 25)
        Me.cmbSearchFirstName.Name = "cmbSearchFirstName"
        Me.cmbSearchFirstName.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchFirstName.TabIndex = 2
        '
        'cmbSearchEID
        '
        Me.cmbSearchEID.FormattingEnabled = True
        Me.cmbSearchEID.Location = New System.Drawing.Point(402, 26)
        Me.cmbSearchEID.Name = "cmbSearchEID"
        Me.cmbSearchEID.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchEID.TabIndex = 3
        '
        'cmbSearchDepartment
        '
        Me.cmbSearchDepartment.FormattingEnabled = True
        Me.cmbSearchDepartment.Location = New System.Drawing.Point(272, 25)
        Me.cmbSearchDepartment.Name = "cmbSearchDepartment"
        Me.cmbSearchDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchDepartment.TabIndex = 4
        '
        'cmbSearchADGroup
        '
        Me.cmbSearchADGroup.FormattingEnabled = True
        Me.cmbSearchADGroup.Location = New System.Drawing.Point(532, 26)
        Me.cmbSearchADGroup.Name = "cmbSearchADGroup"
        Me.cmbSearchADGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchADGroup.TabIndex = 5
        '
        'cmbSearchListServ
        '
        Me.cmbSearchListServ.FormattingEnabled = True
        Me.cmbSearchListServ.Location = New System.Drawing.Point(815, 78)
        Me.cmbSearchListServ.Name = "cmbSearchListServ"
        Me.cmbSearchListServ.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchListServ.TabIndex = 6
        '
        'lblSearchLastName
        '
        Me.lblSearchLastName.AutoSize = True
        Me.lblSearchLastName.Location = New System.Drawing.Point(9, 6)
        Me.lblSearchLastName.Name = "lblSearchLastName"
        Me.lblSearchLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblSearchLastName.TabIndex = 7
        Me.lblSearchLastName.Text = "Last Name"
        '
        'lblSearchFirstName
        '
        Me.lblSearchFirstName.AutoSize = True
        Me.lblSearchFirstName.Location = New System.Drawing.Point(138, 6)
        Me.lblSearchFirstName.Name = "lblSearchFirstName"
        Me.lblSearchFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblSearchFirstName.TabIndex = 8
        Me.lblSearchFirstName.Text = "First Name"
        '
        'lblSearchEID
        '
        Me.lblSearchEID.AutoSize = True
        Me.lblSearchEID.Location = New System.Drawing.Point(402, 10)
        Me.lblSearchEID.Name = "lblSearchEID"
        Me.lblSearchEID.Size = New System.Drawing.Size(43, 13)
        Me.lblSearchEID.TabIndex = 9
        Me.lblSearchEID.Text = "User ID"
        '
        'lblSearchDepartment
        '
        Me.lblSearchDepartment.AutoSize = True
        Me.lblSearchDepartment.Location = New System.Drawing.Point(269, 7)
        Me.lblSearchDepartment.Name = "lblSearchDepartment"
        Me.lblSearchDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblSearchDepartment.TabIndex = 10
        Me.lblSearchDepartment.Text = "Department"
        '
        'lblSearchADGroup
        '
        Me.lblSearchADGroup.AutoSize = True
        Me.lblSearchADGroup.Location = New System.Drawing.Point(532, 11)
        Me.lblSearchADGroup.Name = "lblSearchADGroup"
        Me.lblSearchADGroup.Size = New System.Drawing.Size(54, 13)
        Me.lblSearchADGroup.TabIndex = 11
        Me.lblSearchADGroup.Text = "AD Group"
        '
        'lblSearchListServ
        '
        Me.lblSearchListServ.AutoSize = True
        Me.lblSearchListServ.Location = New System.Drawing.Point(812, 63)
        Me.lblSearchListServ.Name = "lblSearchListServ"
        Me.lblSearchListServ.Size = New System.Drawing.Size(48, 13)
        Me.lblSearchListServ.TabIndex = 12
        Me.lblSearchListServ.Text = "List Serv"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(671, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(752, 25)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdNew.TabIndex = 14
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmbSearchRoom
        '
        Me.cmbSearchRoom.FormattingEnabled = True
        Me.cmbSearchRoom.Location = New System.Drawing.Point(815, 129)
        Me.cmbSearchRoom.Name = "cmbSearchRoom"
        Me.cmbSearchRoom.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchRoom.TabIndex = 7
        '
        'lblSearchRoom
        '
        Me.lblSearchRoom.AutoSize = True
        Me.lblSearchRoom.Location = New System.Drawing.Point(812, 113)
        Me.lblSearchRoom.Name = "lblSearchRoom"
        Me.lblSearchRoom.Size = New System.Drawing.Size(35, 13)
        Me.lblSearchRoom.TabIndex = 15
        Me.lblSearchRoom.Text = "Room"
        '
        'frmEmployeeDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 296)
        Me.Controls.Add(Me.lblSearchRoom)
        Me.Controls.Add(Me.cmbSearchRoom)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearchListServ)
        Me.Controls.Add(Me.lblSearchADGroup)
        Me.Controls.Add(Me.lblSearchDepartment)
        Me.Controls.Add(Me.lblSearchEID)
        Me.Controls.Add(Me.lblSearchFirstName)
        Me.Controls.Add(Me.lblSearchLastName)
        Me.Controls.Add(Me.cmbSearchListServ)
        Me.Controls.Add(Me.cmbSearchADGroup)
        Me.Controls.Add(Me.cmbSearchDepartment)
        Me.Controls.Add(Me.cmbSearchEID)
        Me.Controls.Add(Me.cmbSearchFirstName)
        Me.Controls.Add(Me.cmbSearchLastName)
        Me.Controls.Add(Me.grdEmployee)
        Me.Name = "frmEmployeeDashboard"
        Me.Text = "frmEmployeeDashboard"
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSearchLastName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchFirstName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchEID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchADGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchListServ As System.Windows.Forms.ComboBox
    Friend WithEvents lblSearchLastName As System.Windows.Forms.Label
    Friend WithEvents lblSearchFirstName As System.Windows.Forms.Label
    Friend WithEvents lblSearchEID As System.Windows.Forms.Label
    Friend WithEvents lblSearchDepartment As System.Windows.Forms.Label
    Friend WithEvents lblSearchADGroup As System.Windows.Forms.Label
    Friend WithEvents lblSearchListServ As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmbSearchRoom As ComboBox
    Friend WithEvents lblSearchRoom As Label
End Class
