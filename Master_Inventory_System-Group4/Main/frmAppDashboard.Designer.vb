﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAppDashboard
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
        Me.btnEmployeeNew = New System.Windows.Forms.Button()
        Me.pnlLabelEmployee = New System.Windows.Forms.Panel()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.pnlGrpEmployee = New System.Windows.Forms.Panel()
        Me.btnEmployeeDashboard = New System.Windows.Forms.Button()
        Me.pnlGrpHardware = New System.Windows.Forms.Panel()
        Me.btnHardwareAssign = New System.Windows.Forms.Button()
        Me.btnHardwareDashboard = New System.Windows.Forms.Button()
        Me.btnHardwareNew = New System.Windows.Forms.Button()
        Me.pnlLabelHardware = New System.Windows.Forms.Panel()
        Me.lblHardware = New System.Windows.Forms.Label()
        Me.pnlGrpSoftware = New System.Windows.Forms.Panel()
        Me.btnSoftwareNew = New System.Windows.Forms.Button()
        Me.btnSoftwareDashboard = New System.Windows.Forms.Button()
        Me.pnlLabelSoftware = New System.Windows.Forms.Panel()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.pnlLabelReports = New System.Windows.Forms.Panel()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.pnlGrpReports = New System.Windows.Forms.Panel()
        Me.btnHardwareReport = New System.Windows.Forms.Button()
        Me.btnSoftwareReport = New System.Windows.Forms.Button()
        Me.btnEmployeeRoster = New System.Windows.Forms.Button()
        Me.btnUnassignedReport = New System.Windows.Forms.Button()
        Me.pnlLabelEmployee.SuspendLayout()
        Me.pnlGrpEmployee.SuspendLayout()
        Me.pnlGrpHardware.SuspendLayout()
        Me.pnlLabelHardware.SuspendLayout()
        Me.pnlGrpSoftware.SuspendLayout()
        Me.pnlLabelSoftware.SuspendLayout()
        Me.pnlLabelReports.SuspendLayout()
        Me.pnlGrpReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmployeeNew
        '
        Me.btnEmployeeNew.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeNew.Location = New System.Drawing.Point(14, 144)
        Me.btnEmployeeNew.Name = "btnEmployeeNew"
        Me.btnEmployeeNew.Size = New System.Drawing.Size(178, 80)
        Me.btnEmployeeNew.TabIndex = 0
        Me.btnEmployeeNew.Text = "New Employee"
        Me.btnEmployeeNew.UseVisualStyleBackColor = True
        '
        'pnlLabelEmployee
        '
        Me.pnlLabelEmployee.BackColor = System.Drawing.Color.Lavender
        Me.pnlLabelEmployee.Controls.Add(Me.lblEmployee)
        Me.pnlLabelEmployee.Location = New System.Drawing.Point(3, 3)
        Me.pnlLabelEmployee.Name = "pnlLabelEmployee"
        Me.pnlLabelEmployee.Size = New System.Drawing.Size(200, 45)
        Me.pnlLabelEmployee.TabIndex = 1
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(44, 11)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(104, 24)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = "Employee"
        '
        'pnlGrpEmployee
        '
        Me.pnlGrpEmployee.BackColor = System.Drawing.Color.Lavender
        Me.pnlGrpEmployee.Controls.Add(Me.pnlLabelEmployee)
        Me.pnlGrpEmployee.Controls.Add(Me.btnEmployeeDashboard)
        Me.pnlGrpEmployee.Controls.Add(Me.btnEmployeeNew)
        Me.pnlGrpEmployee.Location = New System.Drawing.Point(12, 12)
        Me.pnlGrpEmployee.Name = "pnlGrpEmployee"
        Me.pnlGrpEmployee.Size = New System.Drawing.Size(206, 323)
        Me.pnlGrpEmployee.TabIndex = 2
        '
        'btnEmployeeDashboard
        '
        Me.btnEmployeeDashboard.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDashboard.Location = New System.Drawing.Point(14, 55)
        Me.btnEmployeeDashboard.Name = "btnEmployeeDashboard"
        Me.btnEmployeeDashboard.Size = New System.Drawing.Size(178, 83)
        Me.btnEmployeeDashboard.TabIndex = 2
        Me.btnEmployeeDashboard.Text = "Employee Dashboard"
        Me.btnEmployeeDashboard.UseVisualStyleBackColor = True
        '
        'pnlGrpHardware
        '
        Me.pnlGrpHardware.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlGrpHardware.Controls.Add(Me.btnHardwareAssign)
        Me.pnlGrpHardware.Controls.Add(Me.btnHardwareDashboard)
        Me.pnlGrpHardware.Controls.Add(Me.btnHardwareNew)
        Me.pnlGrpHardware.Controls.Add(Me.pnlLabelHardware)
        Me.pnlGrpHardware.Location = New System.Drawing.Point(224, 12)
        Me.pnlGrpHardware.Name = "pnlGrpHardware"
        Me.pnlGrpHardware.Size = New System.Drawing.Size(200, 323)
        Me.pnlGrpHardware.TabIndex = 3
        '
        'btnHardwareAssign
        '
        Me.btnHardwareAssign.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardwareAssign.Location = New System.Drawing.Point(10, 230)
        Me.btnHardwareAssign.Name = "btnHardwareAssign"
        Me.btnHardwareAssign.Size = New System.Drawing.Size(178, 80)
        Me.btnHardwareAssign.TabIndex = 3
        Me.btnHardwareAssign.Text = "Assign Hardware"
        Me.btnHardwareAssign.UseVisualStyleBackColor = True
        '
        'btnHardwareDashboard
        '
        Me.btnHardwareDashboard.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardwareDashboard.Location = New System.Drawing.Point(10, 55)
        Me.btnHardwareDashboard.Name = "btnHardwareDashboard"
        Me.btnHardwareDashboard.Size = New System.Drawing.Size(178, 83)
        Me.btnHardwareDashboard.TabIndex = 1
        Me.btnHardwareDashboard.Text = "Hardware Dashboard"
        Me.btnHardwareDashboard.UseVisualStyleBackColor = True
        '
        'btnHardwareNew
        '
        Me.btnHardwareNew.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardwareNew.Location = New System.Drawing.Point(10, 144)
        Me.btnHardwareNew.Name = "btnHardwareNew"
        Me.btnHardwareNew.Size = New System.Drawing.Size(178, 80)
        Me.btnHardwareNew.TabIndex = 2
        Me.btnHardwareNew.Text = "New Hardware"
        Me.btnHardwareNew.UseVisualStyleBackColor = True
        '
        'pnlLabelHardware
        '
        Me.pnlLabelHardware.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlLabelHardware.Controls.Add(Me.lblHardware)
        Me.pnlLabelHardware.Location = New System.Drawing.Point(4, 3)
        Me.pnlLabelHardware.Name = "pnlLabelHardware"
        Me.pnlLabelHardware.Size = New System.Drawing.Size(193, 45)
        Me.pnlLabelHardware.TabIndex = 0
        '
        'lblHardware
        '
        Me.lblHardware.AutoSize = True
        Me.lblHardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardware.Location = New System.Drawing.Point(42, 11)
        Me.lblHardware.Name = "lblHardware"
        Me.lblHardware.Size = New System.Drawing.Size(100, 24)
        Me.lblHardware.TabIndex = 0
        Me.lblHardware.Text = "Hardware"
        '
        'pnlGrpSoftware
        '
        Me.pnlGrpSoftware.BackColor = System.Drawing.Color.Lavender
        Me.pnlGrpSoftware.Controls.Add(Me.btnSoftwareNew)
        Me.pnlGrpSoftware.Controls.Add(Me.btnSoftwareDashboard)
        Me.pnlGrpSoftware.Controls.Add(Me.pnlLabelSoftware)
        Me.pnlGrpSoftware.Location = New System.Drawing.Point(430, 12)
        Me.pnlGrpSoftware.Name = "pnlGrpSoftware"
        Me.pnlGrpSoftware.Size = New System.Drawing.Size(200, 320)
        Me.pnlGrpSoftware.TabIndex = 4
        '
        'btnSoftwareNew
        '
        Me.btnSoftwareNew.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareNew.Location = New System.Drawing.Point(10, 141)
        Me.btnSoftwareNew.Name = "btnSoftwareNew"
        Me.btnSoftwareNew.Size = New System.Drawing.Size(178, 80)
        Me.btnSoftwareNew.TabIndex = 2
        Me.btnSoftwareNew.Text = "New Software"
        Me.btnSoftwareNew.UseVisualStyleBackColor = True
        '
        'btnSoftwareDashboard
        '
        Me.btnSoftwareDashboard.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareDashboard.Location = New System.Drawing.Point(10, 52)
        Me.btnSoftwareDashboard.Name = "btnSoftwareDashboard"
        Me.btnSoftwareDashboard.Size = New System.Drawing.Size(178, 78)
        Me.btnSoftwareDashboard.TabIndex = 1
        Me.btnSoftwareDashboard.Text = "Software Dashboard"
        Me.btnSoftwareDashboard.UseVisualStyleBackColor = True
        '
        'pnlLabelSoftware
        '
        Me.pnlLabelSoftware.BackColor = System.Drawing.Color.Lavender
        Me.pnlLabelSoftware.Controls.Add(Me.lblSoftware)
        Me.pnlLabelSoftware.Location = New System.Drawing.Point(4, 4)
        Me.pnlLabelSoftware.Name = "pnlLabelSoftware"
        Me.pnlLabelSoftware.Size = New System.Drawing.Size(193, 41)
        Me.pnlLabelSoftware.TabIndex = 0
        '
        'lblSoftware
        '
        Me.lblSoftware.AutoSize = True
        Me.lblSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftware.Location = New System.Drawing.Point(51, 7)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(90, 24)
        Me.lblSoftware.TabIndex = 0
        Me.lblSoftware.Text = "Software"
        '
        'pnlLabelReports
        '
        Me.pnlLabelReports.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlLabelReports.Controls.Add(Me.lblReports)
        Me.pnlLabelReports.Location = New System.Drawing.Point(4, 3)
        Me.pnlLabelReports.Name = "pnlLabelReports"
        Me.pnlLabelReports.Size = New System.Drawing.Size(193, 45)
        Me.pnlLabelReports.TabIndex = 0
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(42, 11)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(82, 24)
        Me.lblReports.TabIndex = 0
        Me.lblReports.Text = "Reports"
        '
        'pnlGrpReports
        '
        Me.pnlGrpReports.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlGrpReports.Controls.Add(Me.btnHardwareReport)
        Me.pnlGrpReports.Controls.Add(Me.btnSoftwareReport)
        Me.pnlGrpReports.Controls.Add(Me.btnEmployeeRoster)
        Me.pnlGrpReports.Controls.Add(Me.btnUnassignedReport)
        Me.pnlGrpReports.Controls.Add(Me.pnlLabelReports)
        Me.pnlGrpReports.Location = New System.Drawing.Point(636, 12)
        Me.pnlGrpReports.Name = "pnlGrpReports"
        Me.pnlGrpReports.Size = New System.Drawing.Size(200, 323)
        Me.pnlGrpReports.TabIndex = 4
        '
        'btnHardwareReport
        '
        Me.btnHardwareReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHardwareReport.Location = New System.Drawing.Point(3, 136)
        Me.btnHardwareReport.Name = "btnHardwareReport"
        Me.btnHardwareReport.Size = New System.Drawing.Size(178, 78)
        Me.btnHardwareReport.TabIndex = 6
        Me.btnHardwareReport.Text = "Hardware Report"
        Me.btnHardwareReport.UseVisualStyleBackColor = True
        '
        'btnSoftwareReport
        '
        Me.btnSoftwareReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftwareReport.Location = New System.Drawing.Point(4, 271)
        Me.btnSoftwareReport.Name = "btnSoftwareReport"
        Me.btnSoftwareReport.Size = New System.Drawing.Size(178, 78)
        Me.btnSoftwareReport.TabIndex = 5
        Me.btnSoftwareReport.Text = "Software Report"
        Me.btnSoftwareReport.UseVisualStyleBackColor = True
        '
        'btnEmployeeRoster
        '
        Me.btnEmployeeRoster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeRoster.Location = New System.Drawing.Point(3, 187)
        Me.btnEmployeeRoster.Name = "btnEmployeeRoster"
        Me.btnEmployeeRoster.Size = New System.Drawing.Size(178, 78)
        Me.btnEmployeeRoster.TabIndex = 4
        Me.btnEmployeeRoster.Text = "Employee Roster"
        Me.btnEmployeeRoster.UseVisualStyleBackColor = True
        '
        'btnUnassignedReport
        '
        Me.btnUnassignedReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnassignedReport.Location = New System.Drawing.Point(3, 52)
        Me.btnUnassignedReport.Name = "btnUnassignedReport"
        Me.btnUnassignedReport.Size = New System.Drawing.Size(178, 78)
        Me.btnUnassignedReport.TabIndex = 3
        Me.btnUnassignedReport.Text = "Unassigned Devices"
        Me.btnUnassignedReport.UseVisualStyleBackColor = True
        '
        'frmAppDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 329)
        Me.Controls.Add(Me.pnlGrpReports)
        Me.Controls.Add(Me.pnlGrpSoftware)
        Me.Controls.Add(Me.pnlGrpHardware)
        Me.Controls.Add(Me.pnlGrpEmployee)
        Me.Name = "frmAppDashboard"
        Me.Text = "frmAppDashboard"
        Me.pnlLabelEmployee.ResumeLayout(False)
        Me.pnlLabelEmployee.PerformLayout()
        Me.pnlGrpEmployee.ResumeLayout(False)
        Me.pnlGrpHardware.ResumeLayout(False)
        Me.pnlLabelHardware.ResumeLayout(False)
        Me.pnlLabelHardware.PerformLayout()
        Me.pnlGrpSoftware.ResumeLayout(False)
        Me.pnlLabelSoftware.ResumeLayout(False)
        Me.pnlLabelSoftware.PerformLayout()
        Me.pnlLabelReports.ResumeLayout(False)
        Me.pnlLabelReports.PerformLayout()
        Me.pnlGrpReports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployeeNew As System.Windows.Forms.Button
    Friend WithEvents pnlLabelEmployee As System.Windows.Forms.Panel
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
    Friend WithEvents pnlGrpEmployee As System.Windows.Forms.Panel
    Friend WithEvents btnEmployeeDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlGrpHardware As System.Windows.Forms.Panel
    Friend WithEvents btnHardwareNew As System.Windows.Forms.Button
    Friend WithEvents btnHardwareDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlLabelHardware As System.Windows.Forms.Panel
    Friend WithEvents lblHardware As System.Windows.Forms.Label
    Friend WithEvents pnlGrpSoftware As System.Windows.Forms.Panel
    Friend WithEvents btnSoftwareNew As System.Windows.Forms.Button
    Friend WithEvents btnSoftwareDashboard As System.Windows.Forms.Button
    Friend WithEvents pnlLabelSoftware As System.Windows.Forms.Panel
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents btnHardwareAssign As Button
    Friend WithEvents pnlLabelReports As Panel
    Friend WithEvents lblReports As Label
    Friend WithEvents pnlGrpReports As Panel
    Friend WithEvents btnUnassignedReport As Button
    Friend WithEvents btnEmployeeRoster As Button
    Friend WithEvents btnSoftwareReport As Button
    Friend WithEvents btnHardwareReport As Button
End Class
