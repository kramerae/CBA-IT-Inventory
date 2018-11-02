Imports Master_Inventory_System_Group4.modMain
Public Class frmMain

#Region "Declarations"
    Private m_bolLoading As Boolean = False
    'Define all form variables and contructs here.
    Private m_lngEmployeeID As Integer
    Private m_lngSearchEmployeeID As Integer
    Private m_lngUserID As Integer
    Private m_lngEmployeeAddress As Integer = 0
    Private m_lngHardware As Integer = 0
    Private m_bolLogOut As Boolean = False
    Private m_lstForms As List(Of String)
#End Region
#Region "Properties"
    'Define all form properties here.
    Public Property EmployeeID As Integer
        Get
            Return m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value
        End Set
    End Property
    Public Property SearchEmployeeID As Integer
        Get
            Return m_lngSearchEmployeeID
        End Get
        Set(value As Integer)
            m_lngSearchEmployeeID = value
        End Set
    End Property
    Public Property UserID As Integer
        Get
            Return m_lngUserID
        End Get
        Set(value As Integer)
            m_lngUserID = value
        End Set
    End Property
    Public Property HardwareID As Integer
        Get
            Return m_lngHardware
        End Get
        Set(value As Integer)
            m_lngHardware = value
        End Set
    End Property

#End Region
#Region "Form Events"

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            frmLogin.Close()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmRefAppDashboard As frmAppDashboard
        Try
            m_bolLoading = True
            cmbChildList.Items.Clear()
            m_lstForms = New List(Of String)
            m_lstForms.Add("")
            frmRefAppDashboard = New frmAppDashboard()
            frmRefAppDashboard.Name = "AppDashboard"
            frmRefAppDashboard.Tag = "App Dashboard"
            frmMDIChildAdd(frmRefAppDashboard)

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim lngTop As Integer
        Dim lngLeft As Integer
        Dim lngHeight As Integer
        Dim lngWidth As Integer
        Try
            lngTop = Me.Top
            lngLeft = Me.Left
            lngHeight = Me.Height
            lngWidth = Me.Width

            pnlBanner.Height = 50
            pnlBanner.Top = mnuMain.Bottom + 1
            pnlBanner.Left = 1
            pnlBanner.Width = Me.Width - 4

            pnlMain.Height = Me.Height - pnlBanner.Height - mnuMain.Height - 2
            pnlMain.Width = Me.Width - 4
            pnlMain.Left = 0
            pnlMain.Top = pnlBanner.Bottom + 1

            For Each frm As Form In pnlMain.Controls
                frm.Top = 0
                frm.Left = 0
                frm.Width = pnlMain.Width - 2
                frm.Height = pnlMain.Height - 2
            Next

            lblBanner.Top = (pnlBanner.Height / 2) - (lblBanner.Height / 2)
            lblBanner.Left = (pnlBanner.Width / 2) - (lblBanner.Width / 2)

            btnChildClose.Left = Me.Width - btnChildClose.Width - 20
            btnChildClose.Top = mnuMain.Top + 2
            btnChildClose.Top = (pnlBanner.Height / 2) - (btnChildClose.Height / 2)
            cmbChildList.Left = btnChildClose.Left - cmbChildList.Width - 15
            cmbChildList.Top = btnChildClose.Top

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
#Region "Control Events"
    Private Sub cmbChildCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChildList.SelectedIndexChanged
        Dim Item As clsItemData
        Dim frmRef As Form
        Try
            If cmbChildList.SelectedItem.GetType() = GetType(clsItemData) Then
                Item = cmbChildList.SelectedItem
                frmRef = Me.pnlMain.Controls.Item(Item.StringID)
                frmRef.BringToFront()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
#Region "Button Events"
    Private Sub btnChildClose_Click(sender As Object, e As EventArgs) Handles btnChildClose.Click
        Dim Item As clsItemData
        Dim frmRef As Form
        Try
            If cmbChildList.SelectedItem.GetType() = GetType(clsItemData) Then
                Item = cmbChildList.SelectedItem
                If Item.StringID <> "AppDashboard" Then
                    frmRef = Me.pnlMain.Controls.Item(Item.StringID)
                    frmRef.Close()
                    cmbChildList.Items.Remove(cmbChildList.SelectedItem)
                    m_lstForms.Remove(Item.StringID)
                    cmbChildList.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
#Region "Menu Events"
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
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

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
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

    Private Sub DashboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem1.Click
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

    Private Sub NewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem2.Click
        Dim frmRefHardware As frmHardware2
        Try
            frmRefHardware = New frmHardware2()
            frmRefHardware.Name = "HardwareNew"
            frmRefHardware.Tag = "Hardware - New"
            'frmRefHardware.Hardware = 0
            frmMDIChildAdd(frmRefHardware)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub NewToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem3.Click
        Dim frmRefSoftware As frmSoftware = Nothing
        Try
            'frmRefSoftware = New frmSoftware()
            'frmRefSoftware.Name = "SoftwareNew"
            'frmRefSoftware.Tag = "Software - New"
            ''frmRefSoftware.Software = 0
            'frmMDIChildAdd(frmRefSoftware)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub DashboardToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem2.Click
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

    Private Sub ActiveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveDirectoryToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditADGroups"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub EducationLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EducationLevelToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditEducation"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub EmailAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailAccountsToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditEmailAcc"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub ListServToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListServToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditListServs"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub MappedDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MappedDrivesToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditMappedDrives"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditDepartment"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub TitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitleToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditTitle"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub BuildingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildingToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditBuilding"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub OfficeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditOffice"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub OfficeSubLettersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeSubLettersToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditOfficeSub"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub HardwareTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardwareTypeToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditHardwareType"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub ManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManufacturerToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditManufacturer"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub IPAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IPAddressToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditIPAddress"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub OSTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OSTypeToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditOSType"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub StateTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StateToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditState"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub UserAdministrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAdministrationToolStripMenuItem.Click
        Dim frmRefUserAdmin As frmUserAdministration
        
        Try
            frmRefUserAdmin = New frmUserAdministration()
            frmRefUserAdmin.Name = "UserAdministration"
            frmRefUserAdmin.Tag = "User Administration"
            frmMDIChildAdd(frmRefUserAdmin)

            'frmUserAdministration.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub PartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsToolStripMenuItem.Click
        Dim frmRefParts As frmParts
        Try
            frmRefParts = New frmParts()
            frmRefParts.Name = "Parts"
            frmRefParts.Tag = "Parts"
            frmMDIChildAdd(frmRefParts)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub PartsCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsCategoriesToolStripMenuItem.Click
        Dim frmRefPartsCategory As frmPartsCategory
        Try
            frmRefPartsCategory = New frmPartsCategory()
            frmRefPartsCategory.ShowDialog()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "MDI Child"
    Public Shared Sub frmMDIChildAdd(ByRef frmRef As Form)
        Try
            frmMain.MDIChildAdd(frmRef)
        Catch ex As Exception
            HandleException(frmMain.Name, ex)
        End Try
    End Sub
    Protected Sub MDIChildAdd(ByRef frmRef As Form)
        Try
            If Not m_lstForms.Contains(frmRef.Name.ToString()) Then
                frmRef.MdiParent = Me
                frmRef.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frmRef.Width = Me.pnlMain.Width - 2
                frmRef.Height = Me.pnlMain.Height - 2
                frmRef.Top = 1
                frmRef.Left = 1
                Me.pnlMain.Controls.Add(frmRef)
                m_lstForms.Add(frmRef.Name.ToString())
                frmRef.Show()
                frmRef.BringToFront()
                LoadChildCombo(cmbChildList, frmRef.Name.ToString(), frmRef.Tag.ToString())
                Me.frmMain_Resize(Nothing, Nothing)
                SetStringID(cmbChildList, frmRef.Name.ToString)

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

    
End Class