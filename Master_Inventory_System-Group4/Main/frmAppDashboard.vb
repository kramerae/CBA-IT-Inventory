Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain

Public Class frmAppDashboard
#Region "Declarations"
    Private m_bolLoading As Boolean = False
#End Region
#Region "Properties"

#End Region
#Region "Form Events"
    Private Sub frmAppDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True


        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub

    Private Sub frmAppDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try

            pnlGrpEmployee.Top = Me.Top + 5
            pnlGrpEmployee.Left = Me.Left + 3
            pnlGrpEmployee.Height = Me.Height - 10
            pnlGrpEmployee.Width = (Me.Width - 20) / 4
            pnlLabelEmployee.Left = 0
            pnlLabelEmployee.Top = 0
            pnlLabelEmployee.Width = pnlGrpEmployee.Width

            lblEmployee.Top = (pnlLabelEmployee.Height / 2) - (lblEmployee.Height / 2)
            lblEmployee.Left = (pnlLabelEmployee.Width / 2) - (lblEmployee.Width / 2)

            btnEmployeeDashboard.Top = (pnlLabelEmployee.Bottom + 10)
            btnEmployeeDashboard.Left = (pnlGrpEmployee.Width / 2) - (btnEmployeeDashboard.Width / 2)
            btnEmployeeNew.Top = (btnEmployeeDashboard.Bottom + 10)
            btnEmployeeNew.Left = btnEmployeeDashboard.Left


            pnlGrpHardware.Top = Me.Top + 5
            'pnlGrpHardware.Left = (Me.Width / 2) - (pnlGrpHardware.Width / 2)
            pnlGrpHardware.Left = pnlGrpEmployee.Right + 1
            pnlGrpHardware.Height = Me.Height - 10
            pnlGrpHardware.Width = pnlGrpEmployee.Width
            pnlLabelHardware.Left = 0
            pnlLabelHardware.Top = 0
            pnlLabelHardware.Width = pnlGrpHardware.Width
            pnlLabelHardware.Height = pnlLabelEmployee.Height

            lblHardware.Top = (pnlLabelHardware.Height / 2) - (lblHardware.Height / 2)
            lblHardware.Left = (pnlLabelHardware.Width / 2) - (lblHardware.Width / 2)

            btnHardwareDashboard.Top = (pnlLabelHardware.Bottom + 10)
            btnHardwareDashboard.Left = (pnlGrpHardware.Width / 2) - (btnHardwareDashboard.Width / 2)
            btnHardwareNew.Top = btnHardwareDashboard.Bottom + 10
            btnHardwareNew.Left = btnHardwareDashboard.Left
            btnHardwareAssign.Top = btnHardwareNew.Bottom + 10
            btnHardwareAssign.Left = btnHardwareNew.Left

            pnlGrpSoftware.Top = Me.Top + 5
            'pnlGrpSoftware.Left = (Me.Width - pnlGrpSoftware.Width - 20)
            pnlGrpSoftware.Left = pnlGrpHardware.Right + 1
            pnlGrpSoftware.Height = Me.Height - 10
            pnlGrpSoftware.Width = pnlGrpEmployee.Width
            pnlLabelSoftware.Left = 0
            pnlLabelSoftware.Top = 0
            pnlLabelSoftware.Width = pnlGrpSoftware.Width
            pnlLabelSoftware.Height = pnlLabelEmployee.Height

            lblSoftware.Top = (pnlLabelSoftware.Height / 2) - (lblSoftware.Height / 2)
            lblSoftware.Left = (pnlLabelSoftware.Width / 2) - (lblSoftware.Width / 2)

            btnSoftwareDashboard.Top = pnlLabelSoftware.Bottom + 10
            btnSoftwareDashboard.Left = (pnlGrpSoftware.Width / 2) - (btnSoftwareDashboard.Width / 2)
            btnSoftwareNew.Top = btnSoftwareDashboard.Bottom + 10
            btnSoftwareNew.Left = btnSoftwareDashboard.Left

            pnlGrpReports.Top = Me.Top + 5
            'pnlGrpSoftware.Left = (Me.Width - pnlGrpSoftware.Width - 20)
            pnlGrpReports.Left = pnlGrpSoftware.Right + 1
            pnlGrpReports.Height = Me.Height - 10
            pnlGrpReports.Width = pnlGrpEmployee.Width
            pnlLabelReports.Left = 0
            pnlLabelReports.Top = 0
            pnlLabelReports.Width = pnlGrpReports.Width
            pnlLabelReports.Height = pnlLabelEmployee.Height

            lblReports.Top = (pnlLabelReports.Height / 2) - (lblReports.Height / 2)
            lblReports.Left = (pnlLabelReports.Width / 2) - (lblReports.Width / 2)

            btnUnassignedReport.Top = pnlLabelReports.Bottom + 10
            btnUnassignedReport.Left = (pnlGrpReports.Width / 2) - (btnUnassignedReport.Width / 2)

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"

#End Region
#Region "Button Events"

    Private Sub btnEmployeeDashboard_Click(sender As Object, e As EventArgs) Handles btnEmployeeDashboard.Click
        Dim frmRefEmployeeDashboard As frmEmployeeDashboard
        Try
            frmRefEmployeeDashboard = New frmEmployeeDashboard()
            frmRefEmployeeDashboard.Name = "EmployeeDashboard"
            frmRefEmployeeDashboard.Tag = "Employee Dashboard"
            frmMDIChildAdd(frmRefEmployeeDashboard)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub
    Private Sub btnEmployeeNew_Click(sender As Object, e As EventArgs) Handles btnEmployeeNew.Click
        Dim frmRefEmployee As frmEmployee
        Try
            frmRefEmployee = New frmEmployee()
            frmRefEmployee.Name = "EmployeeNew"
            frmRefEmployee.Tag = "Employee - New"
            frmRefEmployee.Employee = 0
            frmMDIChildAdd(frmRefEmployee)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnHardwareDashboard_Click(sender As Object, e As EventArgs) Handles btnHardwareDashboard.Click
        Dim frmRefHardwareDashboard As frmHardwareDashboard
        Try
            frmRefHardwareDashboard = New frmHardwareDashboard()
            frmRefHardwareDashboard.Name = "HardwareDashboard"
            frmRefHardwareDashboard.Tag = "Hardware Dashboard"
            frmMDIChildAdd(frmRefHardwareDashboard)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnHardwareNew_Click(sender As Object, e As EventArgs) Handles btnHardwareNew.Click
        'Dim frmRefHardware As frmHardware2
        'Dim frmRefHardwareParts As frmHardwareParts
        Dim frmRefHardwareNew As frmHardwareNew
        Try
            frmRefHardwareNew = New frmHardwareNew()
            frmRefHardwareNew.Name = "NewHardware"
            frmRefHardwareNew.Tag = "New Hardware"
            frmMDIChildAdd(frmRefHardwareNew)
            'frmRefHardwareParts = New frmHardwareParts()
            'frmRefHardwareParts.Name = "Test"
            'frmRefHardwareParts.Tag = "Test"
            'frmMDIChildAdd(frmRefHardwareParts)
            'frmRefHardware = New frmHardware2()
            'frmRefHardware.Name = "HardwareNew"
            'frmRefHardware.Tag = "Hardware - New"
            'frmMDIChildAdd(frmRefHardware)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnHardwareAssign_Click(sender As Object, e As EventArgs) Handles btnHardwareAssign.Click
        Dim frmRefHardwareAssign As frmAssignEquipment
        Try
            frmRefHardwareAssign = New frmAssignEquipment()
            frmRefHardwareAssign.Name = "Assign"
            frmRefHardwareAssign.Tag = "Assign Hardware"
            frmMDIChildAdd(frmRefHardwareAssign)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSoftwareDashboard_Click(sender As Object, e As EventArgs) Handles btnSoftwareDashboard.Click
        Dim frmRefSoftwareDashboard As frmSoftwareDashboard
        Try
            frmRefSoftwareDashboard = New frmSoftwareDashboard()
            frmRefSoftwareDashboard.Name = "SoftwareDashboard"
            frmRefSoftwareDashboard.Tag = "Sofware Dashboard"
            frmMDIChildAdd(frmRefSoftwareDashboard)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSoftwareNew_Click(sender As Object, e As EventArgs) Handles btnSoftwareNew.Click
        Dim frmRefSoftware As frmSoftware = Nothing
        Try
            frmRefSoftware = New frmSoftware()
            frmRefSoftware.Name = "SoftwareNew"
            frmRefSoftware.Tag = "Software - New"
            frmMDIChildAdd(frmRefSoftware)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmRefReport As Form1 = Nothing
        Try
            frmRefReport = New Form1()
            frmRefReport.Name = "TestReport"
            frmRefReport.Tag = "Test Report"
            frmMDIChildAdd(frmRefReport)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnUnassignedReport_Click(sender As Object, e As EventArgs) Handles btnUnassignedReport.Click
        Dim frmRefReport As frmUnassignedDevices = Nothing
        Try
            frmRefReport = New frmUnassignedDevices()
            frmRefReport.Name = "UnassignedReport"
            frmRefReport.Tag = "Unassigned Report"
            frmMDIChildAdd(frmRefReport)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


#End Region

End Class