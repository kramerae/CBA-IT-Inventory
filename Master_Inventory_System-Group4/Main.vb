Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Master_Inventory_System_Group4.modMain
Imports System.IO.Directory

Public Class Main

#Region "Declarations"
    'Define all form variables and contructs here.
    Private m_lngEmployeeID As Integer
    Private m_lngSearchEmployeeID As Integer
    Private m_lngUserID As Integer
    Private m_lngEmployeeAddress As Integer = 0
    Private m_lngHardware As Integer = 0
    Private m_bolLogOut As Boolean = False

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

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If m_bolLogOut = False Then
                frmLogin.Close()
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLogOut = False
        End Try
    End Sub
    'Define all form events in this region.
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'All events triggered on form load are called from here.

        Try
            LoginName_Load()
            tabMain_SelectedIndexChanged(sender, e)

            txtDate.Text = Date.Today

            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtEid.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtCity.Text = ""
            txtCellPhone.Text = ""
            txtHomePhone.Text = ""
            txtZip.Text = ""
            'cboState.SelectedIndex = 0
            'cboDepartment.SelectedIndex = 0
            txtLoggedIn.Enabled = False
        Catch ex As Exception
            HandleException(Me.Name, ex)
            'HandleException(Me.name, ex)
        End Try
    End Sub
#End Region

#Region "Control Events"
    'Define all form component events in this region.

    'Private Sub chkStaffInfo_CheckedChanged(sender As Object, e As EventArgs)
    '    Try

    '        If chkStaffInfo.Checked Then
    '            gbxPersonal.Enabled = True
    '            gbxWork.Enabled = True

    '        ElseIf chkStaffInfo.Checked = False Then
    '            gbxPersonal.Enabled = False
    '            gbxWork.Enabled = False
    '        End If

    '    Catch ex As Exception
    '        HandleException(Me.name, ex)
    '    End Try
    'End Sub

    'Private Sub chkADGroupsLists_CheckedChanged(sender As Object, e As EventArgs)
    '    Try

    '        If chkADGroupsLists.Checked Then
    '            gbxADGroups.Enabled = True
    '            gbxListServs.Enabled = True
    '            gbxMappedDrives.Enabled = True
    '            gbxEmailAccounts.Enabled = True

    '        ElseIf chkADGroupsLists.Checked = False Then
    '            gbxADGroups.Enabled = False
    '            gbxListServs.Enabled = False
    '            gbxMappedDrives.Enabled = False
    '            gbxEmailAccounts.Enabled = False
    '        End If

    '    Catch ex As Exception
    '        HandleException(Me.name, ex)
    '    End Try
    'End Sub

    Protected Sub grdData1_doubleclick(sender As Object, e As EventArgs) Handles grdEmployee.CellMouseDoubleClick
        Try

        Catch ex As Exception
            HandleException(Me.name, ex)
        End Try
    End Sub

    Protected Sub Selected_IndexChanged(sender As Object, e As EventArgs) Handles TabControlMain.SelectedIndexChanged

        Try
            If m_lngEmployeeID = 0 Then
                gbxAcademics.Enabled = False
                gbxADGroupList.Enabled = False
            Else
                gbxAcademics.Enabled = True
                gbxADGroupList.Enabled = True
            End If
            If TabAccount.Text = "New Staff Member/Account" Then
                TabControlMain.SelectedIndex = 1
                MsgBox("New Staff form must be completed to continue", MsgBoxStyle.Critical)

            End If
        Catch ex As Exception
            HandleException(Me.name, ex)
        End Try

    End Sub

    Protected Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlMain.SelectedIndexChanged
        Try
            If TabControlMain.SelectedIndex = TabControlMain.TabPages.IndexOf(TabSearch) Then
                cbosearchStaffID_Load() '--Loads the combobox
                cboSearchFirstName_Load() '--Loads the combobox
                cboSearchLastName_Load() '--Loads the combobox
                cboSearchDepartment_Load() '--Loads the combobox
                cboSearchListServ_Load() '--Loads the combobox
                cboSearchADGroup_Load() '--Loads the combobox
                'grdEmployee_Format() 'Populate the grid

            ElseIf TabControlMain.SelectedIndex = TabControlMain.TabPages.IndexOf(TabAccount) Then
                cboDepartment_Load() 'Loads the combobox
                cboStat_Load() 'Loads the combobox
                cboEmailAccount_Load() 'Loads the combobox
                cboBuilding_Load()
                cboOffice_Load()
                cboOfficeSub_Load()

            ElseIf TabControlMain.SelectedIndex = TabControlMain.TabPages.IndexOf(TabStaffInventory) Then
                'grdInvetory_Format()
                grdHardware_Format()
            ElseIf TabControlMain.SelectedIndex = TabControlMain.TabPages.IndexOf(TabInventory) Then
                cboType_Load()
                cboSerialNumber_Load()
                cboHardwareName_Load()
                cboMake_Load()
                cboModel_Load()
                cboModelNumber_Load()

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Button Events"
    'Define all form button component events in this region.
    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click

        Try
            m_lngEmployeeID = 0
            TabControlMain.SelectedIndex = 1
            TabControlMain.SelectedTab.Text = "New Staff Member/Account"
            btnUpdateAdd.Text = "Add Account"
            btnEducation.Text = "Add Education"
            btnTitle.Text = "Add Title"
            'chkStaffInfo.Text = "New to College of Business? (Check to add Staff information)"
            lbldate.Text = "Date Created:"
            txtFirstName.Clear()
            txtLastName.Clear()
            txtDate.Clear()
            txtEid.Clear()
            txtEmail.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtCellPhone.Clear()
            cboStat_Load()
            cboState.SelectedIndex = 0
            txtApt.Clear()
            txtZip.Clear()
            txtHomePhone.Clear()
            txtOfficePhoneNum.Clear()
            cboDepartment_Load()
            cboDepartment.SelectedIndex = 0
            btnNewStaffCancel.Visible = True
            btnNewStaffCancel.Enabled = True
            txtInvFirstName.Clear()
            txtInvLastName.Clear()
            txtSFirstName.Clear()
            txtSLastName.Clear()
            txtExcessFirstName.Clear()
            txtExcessLastName.Clear()
            lstADGroups.Items.Clear() : lstEducation.Items.Clear() : lstTitle.Items.Clear()
            lstEmailAcc.Items.Clear() : lstListServs.Items.Clear() : lstMappedDrives.Items.Clear()


        Catch ex As Exception
            MsgBox(ex.Message & ": btnNewAccount", MsgBoxStyle.Critical, "System Error")
        End Try

    End Sub

    Private Sub btnADGroups_Click(sender As Object, e As EventArgs) Handles btnADGroups.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "ADGroups"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnListServs_Click(sender As Object, e As EventArgs) Handles btnListServs.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "ListServs"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnMappedDrives_Click(sender As Object, e As EventArgs) Handles btnMappedDrives.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "MappedDrives"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnEmailAcc_Click(sender As Object, e As EventArgs) Handles btnEmailAcc.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "EmailAcc"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnNewHardware_Click(sender As Object, e As EventArgs) Handles btnNewHardware.Click
        Try
            frmHardware.HardwareID = 0
            frmHardware.EmployeeID = 0
            frmHardware.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnNewHardware2_Click(sender As Object, e As EventArgs) Handles btnNewHardware2.Click
        Try
            frmHardware.HardwareID = 0
            frmHardware.EmployeeID = 0
            frmHardware.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnViewAllInventory_Click(sender As Object, e As EventArgs) Handles btnViewAllInventory.Click
        Try
            TabControlMain.SelectedIndex = 2
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnStaffAssignHardware_Click(sender As Object, e As EventArgs) Handles btnStaffAssignHardware.Click
        Try
            TabControlMain.SelectedIndex = 3
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btn2StaffAssignNew_Click(sender As Object, e As EventArgs) Handles btn2StaffAssignNew.Click
        Try
            TabControlMain.SelectedIndex = 3
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnAssignSelectedHardware_Click(sender As Object, e As EventArgs) Handles btnAssignSelectedHardware.Click
        Try
            If m_lngEmployeeID > 0 Then
                If CInt(grdEmployee.SelectedCells(0).Value) > 0 Then
                    grdInventory_Assignment()
                Else
                    MsgBox("You must select an inventory item from the grid to assign to an employee.", MsgBoxStyle.Exclamation, "Validation Error")
                End If
            Else
                MsgBox("You must have an Employee selected to assign hardware to.", MsgBoxStyle.Exclamation, "Validation Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ": btnAssignSelectedHardware", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnUpdateAdd_Click(sender As Object, e As EventArgs) Handles btnUpdateAdd.Click
        Try
            If ValidateData() Then
                AddEmployee_Save()
                Call Reload_form()
                If btnUpdateAdd.Text = "Add Account" Then
                    TabControlMain.SelectedTab.Text = "Update Staff Member/Account"
                    TabControlMain.SelectedIndex = 0
                    btnUpdateAdd.Text = "Update Account"
                    'chkStaffInfo.Text = "Personal Information"
                    lbldate.Text = "Date Modified:"
                    btnNewStaffCancel.Visible = False
                    btnNewStaffCancel.Enabled = False
                    txtFirstName.Clear()
                    txtLastName.Clear()
                    txtEid.Clear()
                    txtEmail.Clear()
                    txtDate.Clear()
                    txtApt.Clear()
                    txtAddress.Clear()
                    txtCity.Clear()
                    cboState.SelectedIndex = 0
                    txtZip.Clear()
                    txtCellPhone.Clear()
                    txtHomePhone.Clear()
                    txtOfficePhoneNum.Clear()
                    cboDepartment.SelectedIndex = 0
                    btnEducation.Text = "Update Education"
                    btnTitle.Text = "Update Title"

                End If
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        Try
            If grdEmployee.RowCount > 0 Then
                m_lngEmployeeID = CInt(grdEmployee.SelectedCells(0).Value)
                UpdateEmployee_Populate()
            End If
            TabControlMain.SelectedIndex = 1
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Try
            Me.Hide()
            frmLogin.Show()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnInvUpdate_Click(sender As Object, e As EventArgs) Handles btnInvUpdate.Click
        Dim lngID As Integer = 0
        Try
            lngID = CInt(grdHardware.SelectedCells(0).Value)
            frmHardware.HardwareID = lngID
            frmHardware.EmployeeID = m_lngEmployeeID
            frmHardware.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            grdEmployee_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Try
            grdInvetory_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        Try
            cboSearchStaffID.SelectedIndex = 0
            cboSearchFirstName.SelectedIndex = 0
            cboSearchLastName.SelectedIndex = 0
            cboSearchDepartment.SelectedIndex = 0
            cboSearchListServs.SelectedIndex = 0
            cboSearchADGroups.SelectedIndex = 0
            'cboSearchEmailAccounts.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message & ": btnClearFields", MsgBoxStyle.Critical, "System Error")

        End Try
    End Sub

    Private Sub btnClearFields2_Click(sender As Object, e As EventArgs) Handles btnClearFields2.Click
        Try
            cboType.SelectedIndex = 0
            cboSerialNumber.SelectedIndex = 0
            cboHardwareName.SelectedIndex = 0
            cboMake.SelectedIndex = 0
            cboModel.SelectedIndex = 0
            cboModelNumber.SelectedIndex = 0

        Catch ex As Exception
            'MsgBox(ex.Message & ": btnClearFields2", MsgBoxStyle.Critical, "System Error")
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnResetResults_Click(sender As Object, e As EventArgs) Handles btnResetResults.Click
        Try
            btnClearFields_Click(sender, e)
            grdEmployee_Format()

        Catch ex As Exception
            'HandleException(Me.name, ex)
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnResetResults2_Click(sender As Object, e As EventArgs) Handles btnResetResults2.Click
        Try
            btnClearFields2_Click(sender, e)
            grdInvetory_Format()
        Catch ex As Exception
            'HandleException(Me.name, ex)
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click


        Try
            If MsgBox("Are you sure you want to delete the selected Employee?", MsgBoxStyle.OkCancel, "Validation Message") = MsgBoxResult.Ok Then
                Try
                    m_lngSearchEmployeeID = CInt(grdEmployee.SelectedCells(0).Value)
                    grdEmployee_Delete()
                    grdEmployee_Format()
                Catch ex As Exception
                    HandleException(Me.Name, ex)
                End Try

            End If

        Catch ex As Exception
            'HandleException(Me.name, ex)
            HandleException(Me.Name, ex)
        End Try


    End Sub

    Private Sub btnNewStaffCancel_Click(sender As Object, e As EventArgs) Handles btnNewStaffCancel.Click
        Try
            If btnUpdateAdd.Text = "Add Account" Then
                TabControlMain.SelectedTab.Text = "Update Staff Member/Account"
                TabControlMain.SelectedIndex = 0
                btnUpdateAdd.Text = "Update Account"
                'chkStaffInfo.Text = "Personal Information"
                lbldate.Text = "Date Modified:"
                btnNewStaffCancel.Visible = False
                btnNewStaffCancel.Enabled = False
                btnEducation.Text = "Update Education"
                btnTitle.Text = "Update Title"

            Else
                TabControlMain.SelectedIndex = 0
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnEducation_Click(sender As Object, e As EventArgs) Handles btnEducation.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "Education"
            frmNetworkExtras.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message & ":btnEducation_Click", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "Title"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message & ": btnTitle_Click", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnUpdateExcessInventory_Click(sender As Object, e As EventArgs) Handles btnUpdateExcessInventory.Click
        Try
            frmHardware.EmployeeID = m_lngEmployeeID
            frmHardware.HardwareID = CInt(grdInventory.SelectedCells(0).Value)
            frmHardware.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message & ": btnUpdateExcessInventory_Click", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnRemoveExcessInventory_Click(sender As Object, e As EventArgs) Handles btnRemoveExcessInventory.Click
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngID As Integer = 0

        Try
            If MsgBox("Are you sure you want to remove this hardware from inventory?", MsgBoxStyle.OkCancel, "Validation Message") = MsgBoxResult.Ok Then
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryDeleteHardware"

                lngID = CInt(grdInventory.SelectedCells(0).Value)

                para = New SqlParameter()
                para.ParameterName = "@FK_lngHardware"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = lngID
                qryTemp.Parameters.Add(para)

                objConn.Open()
                rsTemp = qryTemp.ExecuteReader()

                While rsTemp.Read
                    lngID = rsTemp.Item("FK_lngHardware")
                End While

                Call grdInvetory_Format()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub btnInvRemove_Click(sender As Object, e As EventArgs) Handles btnInvRemove.Click
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngID As Integer = 0

        Try
            If MsgBox("Are you sure you want to unassign hardware from staff member?", MsgBoxStyle.OkCancel, "Validation Message") = MsgBoxResult.Ok Then
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryUnassignEmployeeHardware"

                para = New SqlParameter()
                para.ParameterName = "@FK_lngEmployee"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = m_lngEmployeeID
                qryTemp.Parameters.Add(para)

                lngID = CInt(grdHardware.SelectedCells(0).Value)

                para = New SqlParameter()
                para.ParameterName = "@FK_lngHardware"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = lngID
                qryTemp.Parameters.Add(para)

                objConn.Open()
                rsTemp = qryTemp.ExecuteReader()

                While rsTemp.Read
                    lngID = rsTemp.Item("FK_lngHardware")
                End While

                Call grdHardware_Format()
                grdInvetory_Format()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region

#Region "Population/Validation/Save"

#Region "    Population"
    Public Sub Reload_form()
        Try


            cbosearchStaffID_Load() 'Loads the combobox
            cboSearchFirstName_Load() 'Loads the combobox
            cboSearchLastName_Load() 'Loads the combobox
            cboSearchDepartment_Load() 'Loads the combobox
            cboSearchListServ_Load() 'Loads the combobox
            cboSearchADGroup_Load() 'Loads the combobox
            cboEmailAccount_Load() 'Loads the combobox
            cboType_Load()
            cboSerialNumber_Load()
            cboHardwareName_Load()
            cboMake_Load()
            cboModel_Load()
            cboModelNumber_Load()
            cboDepartment_Load()
            cboOffice_Load()
            cboOfficeSub_Load()

            grdEmployee_Format() 'Populate the grid
            grdInvetory_Format()
            UpdateEmployee_Populate()
        Catch ex As Exception
            MsgBox(ex.Message & ": Reload_form()", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub UpdateEmployee_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryUpdateEmployee_Populate"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngEmployeeID = rsTemp.Item("PK_autEmployeeID")
                txtFirstName.Text = rsTemp.Item("txtFirstName").ToString().Trim()
                txtInvFirstName.Text = rsTemp.Item("txtFirstName").ToString().Trim()
                txtInvLastName.Text = rsTemp.Item("txtLastName").ToString().Trim()
                txtSFirstName.Text = rsTemp.Item("txtFirstName").ToString().Trim()
                txtSLastName.Text = rsTemp.Item("txtLastName").ToString().Trim()
                txtExcessFirstName.Text = rsTemp.Item("txtFirstName").ToString().Trim()
                txtExcessLastName.Text = rsTemp.Item("txtLastName").ToString().Trim()
                txtLastName.Text = rsTemp.Item("txtLastName").ToString().Trim()
                txtEid.Text = rsTemp.Item("txtEID").ToString().Trim()
                txtEmail.Text = rsTemp.Item("txtEmail").ToString().Trim()
                lngSelected = cboDepartment.FindString(rsTemp("txtDepartment").ToString())
                cboDepartment.SelectedIndex = lngSelected
                m_lngEmployeeAddress = rsTemp.Item("PK_autEmployeeAddressID")
                txtAddress.Text = rsTemp.Item("txtAddressLine1").ToString().Trim()
                txtApt.Text = rsTemp.Item("txtAddressLine2").ToString().Trim()
                txtCity.Text = rsTemp.Item("txtCity").ToString().Trim()
                lngSelected = cboState.FindString(rsTemp.Item("txtState"))
                cboState.SelectedIndex = lngSelected
                txtZip.Text = rsTemp.Item("txtZipPrefix").ToString().Trim()
                txtHomePhone.Text = rsTemp.Item("txtHomePhone").ToString().Trim()
                txtCellPhone.Text = rsTemp.Item("txtCellPhone").ToString().Trim()
                txtOfficePhoneNum.Text = rsTemp.Item("txtWorkPhone").ToString().Trim()
                SetIntegerID(cmbBuilding, NZ(rsTemp.Item("PK_autBuildingID"), 0))
                SetIntegerID(cmbRoomNum, NZ(rsTemp.Item("PK_autOfficeID"), 0))
                SetIntegerID(cmbRoomSub, NZ(rsTemp.Item("PK_autOfficeSubID"), 0))
                'txtRoomNum.Text = rsTemp.Item("txtOfficeNumber").ToString().Trim()
                'txtSubLetter.Text = rsTemp.Item("txtOfficeSubLetter").ToString().Trim()
                'txtBuilding.Text = rsTemp.Item("txtBuildingName").ToString().Trim()
            End While
            grdHardware_Format() ' Populate the other grid
            lbxEdcuation_Populate() : lstEmailAcc_Populate()
            lbxTitle_Populate() : lstMappedDrives_Populate()
            lstADGroups_Populate() : lstListServs_Populate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
            'MsgBox(ex.Message & ": UpdateEmployee()", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    Private Sub lbxEdcuation_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstEducation.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetEducationLevel"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstEducation.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lbxEdcuation_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lbxTitle_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstTitle.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetTitle"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstTitle.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lbxTitle_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lstADGroups_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstADGroups.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetADGroups"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstADGroups.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lstADGroups_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lstListServs_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstListServs.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetListServs"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstListServs.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lstListServs_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lstMappedDrives_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstMappedDrives.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetMappedDrives"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstMappedDrives.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lstMappedDrives_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lstEmailAcc_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstEmailAcc.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryMainGetEmailAccount"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstEmailAcc.Items.Add(rsTemp.Item("txtDescription").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": llstEmailAcc_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region

#Region "    Validation"
    Private Function ValidateData() As Boolean
        Try
            If txtFirstName.Text.Length > 0 Then
                If txtLastName.Text.Length > 0 Then
                    If txtEid.Text.Length > 0 Then
                        If txtEmail.Text.Length > 0 Then
                            If txtAddress.Text.Length > 0 Then
                                If txtCity.Text.Length > 0 Then
                                    If txtCellPhone.Text.Length > 0 Then
                                        If txtHomePhone.Text.Length > 0 Then
                                            If cboState.SelectedIndex > 0 Then
                                                If cboDepartment.SelectedIndex > 0 Then
                                                    Return True

                                                Else
                                                    MsgBox("Department Name Required", MsgBoxStyle.Critical, "Validation")
                                                    Return False
                                                End If

                                            Else
                                                MsgBox("State Required", MsgBoxStyle.Critical, "Validation")
                                                Return False
                                            End If

                                        Else
                                            MsgBox("Home Phone Number Required", MsgBoxStyle.Critical, "Validation")
                                            Return False
                                        End If
                                    Else
                                        MsgBox("Cell Phone Number Required", MsgBoxStyle.Critical, "Validation")
                                        Return False
                                    End If
                                Else
                                    MsgBox("City Required", MsgBoxStyle.Critical, "Validation")
                                    Return False
                                End If
                            Else
                                MsgBox("Address Required", MsgBoxStyle.Critical, "Validation")
                                Return False
                            End If
                        Else
                            MsgBox("Email Required", MsgBoxStyle.Critical, "Validation")
                            Return False
                        End If
                    Else
                        MsgBox("Eid Required", MsgBoxStyle.Critical, "Validation")
                        Return False
                    End If
                Else
                    MsgBox("Last Name Required", MsgBoxStyle.Critical, "Validation")
                    Return False
                End If
            Else
                MsgBox("First Name Required", MsgBoxStyle.Critical, "Validation")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & ": ValidateData", MsgBoxStyle.Critical, "System Error")
            Return False
        End Try
    End Function
#End Region

#Region "    Save"

    Private Sub AddEmployee_Save()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryAddEmployee"

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtFirstName"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtFirstName.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtLastName"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtLastName.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtEID"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtEid.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtEMail"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtEmail.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "FK_lngEmployeeAddress"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeAddress
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtAddressLine1"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtAddress.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtAddressLine2"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtApt.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtCity"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtCity.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtZipPrefix"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtZip.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "FK_lngState"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = cboState.SelectedIndex
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtHomePhone"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtHomePhone.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "txtCellPhone"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtCellPhone.Text
            qryTemp.Parameters.Add(para)

            'para = New SqlParameter()
            'para.ParameterName = "txtRoomNumber"
            'para.SqlDbType = SqlDbType.VarChar
            'para.Direction = ParameterDirection.Input
            'para.Value = "" 'txtRoomNum.Text
            qryTemp.Parameters.Add(CreateParameter("FK_lngOffice", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbRoomNum)))

            'para = New SqlParameter()
            'para.ParameterName = "txtOfficeSubLetter"
            'para.SqlDbType = SqlDbType.VarChar
            'para.Direction = ParameterDirection.Input
            'para.Value = "" 'txtRoomNum.Text
            qryTemp.Parameters.Add(CreateParameter("FK_lngOfficeSub", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbRoomSub)))

            'para = New SqlParameter()
            'para.ParameterName = "txtBuilding"
            'para.SqlDbType = SqlDbType.VarChar
            'para.Direction = ParameterDirection.Input
            'para.Value = "" 'txtBuilding.Text
            qryTemp.Parameters.Add(CreateParameter("FK_lngBuilding", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbBuilding)))

            para = New SqlParameter()
            para.ParameterName = "txtWorkPhone"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtOfficePhoneNum.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "FK_lngDepartment"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = cboDepartment.SelectedIndex
            qryTemp.Parameters.Add(para)

            qryTemp.Parameters.Add(CreateParameter("FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                EmployeeID = rsTemp.Item("lngEmployee")
            End While

            If m_lngEmployeeID > 0 Then
                MsgBox("Employee save successful.", MsgBoxStyle.Exclamation, "Validation Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & ": AddEmployee_Save()", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub
#End Region

#End Region

#Region "Tabs"

#Region "    Update Staff"


#End Region

#End Region

#Region "Grid Employee"

#Region "    Grid Format"

    Private Sub grdEmployee_Format()
        Dim dt As DataTable
        Try

            dt = grdEmployee_Populate() 'Populate the datatable.

            grdEmployee.DataSource = dt 'Set data source of the grid.

            '   Format the columns of the grid.
            If grdEmployee.ColumnCount > 0 Then
                grdEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect


                'Primary Key 
                With grdEmployee.Columns("PK_autEmployeeID")
                    .Width = 0
                    .Visible = False
                End With

                'Last Name column
                With grdEmployee.Columns("txtLastName")
                    .HeaderText = "Last"
                    .ReadOnly = True
                    .Width = 150
                End With

                'First Name column.
                With grdEmployee.Columns("txtFirstName")
                    .HeaderText = "First"
                    .ReadOnly = True
                    .Width = 150
                End With

                'User Name column
                With grdEmployee.Columns("txtEID")
                    .HeaderText = "User Name"
                    .ReadOnly = True
                    .Width = 150

                End With

                'Department column
                With grdEmployee.Columns("txtDepartmentName")
                    .HeaderText = "Department"
                    .ReadOnly = True
                    .Width = 150

                End With

                'Title column
                With grdEmployee.Columns("txtTitleName")
                    .HeaderText = "Title"
                    .ReadOnly = True
                    .Width = 150

                End With

                'Title Department column
                With grdEmployee.Columns("txtTitleDepartment")
                    .HeaderText = "Group"
                    .ReadOnly = True
                    .Width = 150

                End With
            End If



        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "    Grid Populate"
    Private Function grdEmployee_Populate() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryGetEmployeeList"

            para = New SqlParameter()
            para = CreateParameter("@lngEmployeeID", SqlDbType.Int, ParameterDirection.Input, m_lngSearchEmployeeID)
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtEID", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSearchStaffID))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtFirstName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSearchFirstName))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtLastName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSearchLastName))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngDepartment", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cboSearchDepartment))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngListServ", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cboSearchListServs))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngAD", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cboSearchADGroups))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            'para = CreateParameter("@txtEmailAccountName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSearchEmailAccounts))
            para = CreateParameter("@txtEmailAccountName", SqlDbType.VarChar, ParameterDirection.Input, "")
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Generic")
            dt.Columns.Add("PK_autEmployeeID", GetType(Integer))
            dt.Columns.Add("txtLastName", GetType(String))
            dt.Columns.Add("txtFirstName", GetType(String))
            dt.Columns.Add("txtEID", GetType(String))
            dt.Columns.Add("txtDepartmentName", GetType(String))
            dt.Columns.Add("txtTitleName", GetType(String))
            dt.Columns.Add("txtTitleDepartment", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autEmployeeID") = rsTemp.Item("PK_autEmployeeID")
                dr("txtLastName") = rsTemp.Item("txtLastName")
                dr("txtFirstName") = rsTemp.Item("txtFirstName")
                dr("txtEID") = rsTemp.Item("txtEID")
                dr("txtDepartmentName") = rsTemp.Item("txtDepartmentName")
                dr("txtTitleName") = rsTemp.Item("txtTitleName")
                dr("txtTitleDepartment") = rsTemp.Item("txtTitleDepartment")

                dt.Rows.Add(dr)
            End While


            Return dt

        Catch ex As Exception
            MsgBox(ex.Message & ": grdEmployee_Populate", MsgBoxStyle.Critical, "System Error")
            Return Nothing
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Function
#End Region

#Region "    Grid Events"

    Protected Sub grdEmployee_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles grdEmployee.DoubleClick
        Try
            If grdEmployee.RowCount > 0 Then
                m_lngEmployeeID = CInt(grdEmployee.SelectedCells(0).Value)
                UpdateEmployee_Populate()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub mouse(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdEmployee.MouseWheel
        Dim intMove As Integer = grdEmployee.FirstDisplayedScrollingRowIndex - e.Delta / 120
        Try
            If (intMove >= 0) And (intMove <= grdEmployee.RowCount) Then
                grdEmployee.FirstDisplayedScrollingRowIndex = intMove

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#End Region

#Region "Grid Hardware"

#Region "   Grid Format"

    Private Sub grdHardware_Format()
        Dim dt As DataTable
        Try
            grdHardware.Columns.Clear()

            dt = grdHardware_Populate() 'Populate the HARDWARE datatable.

            grdHardware.DataSource = dt 'Set data source of the grid.

            '   Format the columns of the grid.
            If grdHardware.ColumnCount > 0 Then
                grdHardware.SelectionMode = DataGridViewSelectionMode.FullRowSelect


                'Primary Key 
                With grdHardware.Columns("PK_autHardwareID")
                    .Width = 50
                    .Visible = True
                End With


                With grdHardware.Columns("txtHardwareName")
                    .HeaderText = "Hardware Name"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtHardwareTypeName")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtManufacturerName")
                    .HeaderText = "Make"
                    .ReadOnly = True
                    .Width = 150
                End With


                With grdHardware.Columns("txtModel")
                    .HeaderText = "Model"
                    .ReadOnly = True
                    .Width = 150
                End With


                With grdHardware.Columns("txtModelNumber")
                    .HeaderText = "Model Number"
                    .ReadOnly = True
                    .Width = 150

                End With


                With grdHardware.Columns("txtSerialNumber")
                    .HeaderText = "Serial Number"
                    .ReadOnly = True
                    .Width = 150

                End With


                With grdHardware.Columns("txtServiceTag")
                    .HeaderText = "Service Tag"
                    .ReadOnly = True
                    .Width = 150

                End With

                With grdHardware.Columns("txtExpressServiceTag")
                    .HeaderText = "Exp. Service Tag"
                    .ReadOnly = True
                    .Width = 150

                End With

                With grdHardware.Columns("txtMACAddress")
                    .HeaderText = "MAC Address"
                    .ReadOnly = True
                    .Width = 150

                End With
            End If



        Catch ex As Exception
            MsgBox(ex.Message & ": grdHardware_Format", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

#End Region

#Region "   Grid Populate"

    Private Function grdHardware_Populate() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryViewHardware"

            para = New SqlParameter()
            para.ParameterName = "@EmployeeID"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("HardGeneric")
            dt.Columns.Add("PK_autHardwareID", GetType(Integer))
            dt.Columns.Add("txtHardwareName", GetType(String))
            dt.Columns.Add("txtHardwareTypeName", GetType(String))
            dt.Columns.Add("txtManufacturerName", GetType(String))
            dt.Columns.Add("txtModel", GetType(String))
            dt.Columns.Add("txtModelNumber", GetType(String))
            dt.Columns.Add("txtSerialNumber", GetType(String))
            dt.Columns.Add("txtServiceTag", GetType(String))
            dt.Columns.Add("txtExpressServiceTag", GetType(String))
            dt.Columns.Add("txtMACAddress", GetType(String))


            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autHardwareID") = rsTemp.Item("PK_autHardwareID")
                dr("txtHardwareName") = rsTemp.Item("txtHardwareName")
                dr("txtHardwareTypeName") = rsTemp.Item("txtHardwareTypeName")
                dr("txtManufacturerName") = rsTemp.Item("txtManufacturerName")
                dr("txtModel") = rsTemp.Item("txtModel")
                dr("txtModelNumber") = rsTemp.Item("txtModelNumber")
                dr("txtSerialNumber") = rsTemp.Item("txtSerialNumber")
                dr("txtServiceTag") = rsTemp.Item("txtServiceTag")
                dr("txtExpressServiceTag") = rsTemp.Item("txtExpressServiceTag")
                dr("txtMACAddress") = rsTemp.Item("txtMACAddress")

                dt.Rows.Add(dr)

            End While

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message & ": grdHardware_Populate", MsgBoxStyle.Critical, "System Error")
            Return Nothing
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try


    End Function

#End Region

#Region "   Grid Events"

#End Region

#End Region

#Region "Grid Inventory"

#Region "    Grid Format"

    Private Sub grdInvetory_Format()
        Dim dt As DataTable

        Try
            grdInventory.Columns.Clear()

            dt = grdInventory_Populate()

            grdInventory.DataSource = dt

            If grdInventory.ColumnCount > 0 Then
                grdInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Format the grid

                'Primary Key
                With grdInventory.Columns("PK_autHardwareID")
                    .Width = 50
                    .Visible = False
                End With

                'Hardware Name
                With grdInventory.Columns("txtHardwareName")
                    .HeaderText = "Hardware Name"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtHardwareTypeName")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtManufacturerName")
                    .HeaderText = "Make"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtModel")
                    .HeaderText = "Model"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtModelNumber")
                    .HeaderText = "Model Number"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtSerialNumber")
                    .HeaderText = "Serial Number"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtServiceTag")
                    .HeaderText = "Service Tag"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtExpressServiceTag")
                    .HeaderText = "Exp. Service Tag"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdInventory.Columns("txtMACAddress")
                    .HeaderText = "MAC Address"
                    .ReadOnly = True
                    .Width = 100
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message & ": grdHardware_Populate", MsgBoxStyle.Critical, "System Error")

        End Try

    End Sub

#End Region

#Region "    Grid Populate"

    Private Function grdInventory_Populate() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryExcessInventory_Populate"

            para = New SqlParameter()
            para = CreateParameter("@txtType", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboType))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtSerialNumber", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSerialNumber))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboHardwareName))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtMake", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboMake))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtModel", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboModel))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtModelNumber", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboModelNumber))
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Inventory")
            dt.Columns.Add("PK_autHardwareID", GetType(Integer))
            dt.Columns.Add("txtHardwareName", GetType(String))
            dt.Columns.Add("txtHardwareTypeName", GetType(String))
            dt.Columns.Add("txtManufacturerName", GetType(String))
            dt.Columns.Add("txtModel", GetType(String))
            dt.Columns.Add("txtModelNumber", GetType(String))
            dt.Columns.Add("txtSerialNumber", GetType(String))
            dt.Columns.Add("txtServiceTag", GetType(String))
            dt.Columns.Add("txtExpressServiceTag", GetType(String))
            dt.Columns.Add("txtMACAddress", GetType(String))

            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autHardwareID") = rsTemp.Item("PK_autHardwareID")
                dr("txtHardwareName") = rsTemp.Item("txtHardwareName")
                dr("txtHardwareTypeName") = rsTemp.Item("txtHardwareTypeName")
                dr("txtManufacturerName") = rsTemp.Item("txtManufacturerName")
                dr("txtModel") = rsTemp.Item("txtModel")
                dr("txtModelNumber") = rsTemp.Item("txtModelNumber")
                dr("txtSerialNumber") = rsTemp.Item("txtSerialNumber")
                dr("txtServiceTag") = rsTemp.Item("txtServiceTag")
                dr("txtExpressServiceTag") = rsTemp.Item("txtExpressServiceTag")
                dr("txtMACAddress") = rsTemp.Item("txtMACAddress")

                dt.Rows.Add(dr)

            End While

            Return dt
        Catch ex As Exception
            MsgBox(ex.Message & ": grdInventory_Populate", MsgBoxStyle.Critical, "System Error")
            Return Nothing
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Function

#End Region

#Region "    Grid Events"


#End Region

#End Region

#Region "MenuStrip"

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Try
            Clipboard.SetDataObject(CType(ActiveControl, TextBox).SelectedText)
            CType(ActiveControl, TextBox).SelectedText = String.Empty
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Clipboard.SetDataObject(CType(ActiveControl, TextBox).SelectedText)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Dim odata As IDataObject
        Try
            odata = Clipboard.GetDataObject
            If odata.GetDataPresent(DataFormats.Text) Then
                CType(ActiveControl, TextBox).SelectedText = CType(odata.GetData(DataFormats.Text), String)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Try
            CType(ActiveControl, TextBox).SelectAll()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            Me.Close()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Try
            TabControlMain.SelectedIndex = 1
            TabControlMain.SelectedTab.Text = "New Staff Member/Account"
            btnUpdateAdd.Text = "Add Account"
            'chkStaffInfo.Text = "New to College of Business? (Check to add Staff information)"
            lbldate.Text = "Date Created:"
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        Try
            Me.Close()
            frmLogin.Show()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub UserManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManualToolStripMenuItem.Click

        Try
            'System.Diagnostics.Process.Start("E:\Dalton Sherley (785-313-6215)\Spring 2014\Mangt 686\Project\User Interface\MISUserManual.docx")

            System.Diagnostics.Process.Start("C:\temp\MISUserManual.pdf")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub
    Private Sub StateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StateToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditState"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_StateToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
    Private Sub ActiveDirectoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveDirectoriesToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditADGroups"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_ActiveDirectoriesToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
    Private Sub ListServsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListServsToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditListServs"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_ListServsToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
    Private Sub MappedDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MappedDrivesToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditMappedDrives"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_MappedDrivesToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
    Private Sub EMailAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMailAccountsToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditEmailAcc"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_EMailAccountsToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
    Private Sub EducationLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EducationLevelToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditEducation"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            MsgBox("Main_EducationLevelToolStripMenuItem: " & ex.Message, MsgBoxStyle.Critical, "System Error")
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


    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditDepartment"
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

    Private Sub OfficeSubLetterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeSubLetterToolStripMenuItem.Click
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

    Private Sub SoftwareTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareTypeToolStripMenuItem.Click
        Try
            frmNetworkExtras.FormMode = "EditSoftwareType"
            frmNetworkExtras.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Utilities"
    Private Sub cboModelNumber_Load()

        Try
            cboModelNumber.Items.Clear()
            'Model Number Auto Complete
            cboModelNumber.AutoCompleteMode = AutoCompleteMode.Append
            cboModelNumber.DropDownStyle = ComboBoxStyle.DropDown
            cboModelNumber.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboModelNumber, "qrySearchHardwareModelNumber")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboModel_Load()

        Try
            cboModel.Items.Clear()
            'Model Auto Complete
            cboModel.AutoCompleteMode = AutoCompleteMode.Append
            cboModel.DropDownStyle = ComboBoxStyle.DropDown
            cboModel.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboModel, "qrySearchHardwareModel")
            'cboModel.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboMake_Load()

        Try
            cboMake.Items.Clear()
            'Make Auto Complete
            cboMake.AutoCompleteMode = AutoCompleteMode.Append
            cboMake.DropDownStyle = ComboBoxStyle.DropDown
            cboMake.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboMake, "qryMake")
            'cboMake.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboHardwareName_Load()

        Try
            cboHardwareName.Items.Clear()
            'Hardware Name Auto Complete
            cboHardwareName.AutoCompleteMode = AutoCompleteMode.Append
            cboHardwareName.DropDownStyle = ComboBoxStyle.DropDown
            cboHardwareName.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboHardwareName, "qrySearchHardwareName")
            'cboHardwareName.SelectedIndex = 0
        Catch ex As Exception

        Finally
        End Try
    End Sub

    Private Sub cboSerialNumber_Load()

        Try
            cboSerialNumber.Items.Clear()
            'Serial Number Auto Complete
            cboSerialNumber.AutoCompleteMode = AutoCompleteMode.Append
            cboSerialNumber.DropDownStyle = ComboBoxStyle.DropDown
            cboSerialNumber.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSerialNumber, "qrySerialNumber")
            'cboSerialNumber.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboType_Load()
        Try
            'Hardware Type Auto Complete
            cboType.AutoCompleteMode = AutoCompleteMode.Append
            cboType.DropDownStyle = ComboBoxStyle.DropDown
            cboType.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboType, "qrySearchHardwareType")
            'cboType.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cbosearchStaffID_Load()

        Try
            cboSearchStaffID.Items.Clear()
            'Staff ID Auto Complete
            cboSearchStaffID.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchStaffID.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchStaffID.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchStaffID, "qrySearchEID")
            'cboSearchStaffID.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try

    End Sub

    Private Sub cboSearchFirstName_Load()
        Try
            cboSearchFirstName.Items.Clear()
            'First Name Auto Complete
            cboSearchFirstName.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchFirstName.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchFirstName.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchFirstName, "qrySearchFirstName")
            'cboSearchFirstName.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try

    End Sub

    Private Sub cboSearchLastName_Load()
        Try
            cboSearchLastName.Items.Clear()
            'Last Name Auto Complete
            cboSearchLastName.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchLastName.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchLastName.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchLastName, "qrySearchLastName")
            'cboSearchLastName.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboStat_Load()

        Try
            cboState.Items.Clear()
            'Last Name Auto Complete
            cboState.AutoCompleteMode = AutoCompleteMode.Append
            cboState.DropDownStyle = ComboBoxStyle.DropDown
            cboState.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboState, "qryCBOState_Populate")
            'cboState.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboSearchDepartment_Load()

        Try
            cboSearchDepartment.Items.Clear()
            'Department Auto Complete
            cboSearchDepartment.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchDepartment.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchDepartment.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchDepartment, "qryCBOSearchDepartment_Populate")
            'cboSearchDepartment.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboSearchListServ_Load()

        Try
            cboSearchListServs.Items.Clear()
            'List Servs Auto Complete
            cboSearchListServs.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchListServs.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchListServs.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchListServs, "qryCBOSearchListServ_Populate")
            'cboSearchListServs.SelectedIndex = 0

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboDepartment_Load()

        Try
            LoadComboBox(cboDepartment, "qryCBOSearchDepartment_Populate")
            'cboDepartment.SelectedIndex = 0

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboSearchADGroup_Load()

        Try
            cboSearchADGroups.Items.Clear()
            'AD Groups Auto Complete
            cboSearchADGroups.AutoCompleteMode = AutoCompleteMode.Append
            cboSearchADGroups.DropDownStyle = ComboBoxStyle.DropDown
            cboSearchADGroups.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cboSearchADGroups, "qryCBOSearchADGroup_Populate")
            'cboSearchADGroups.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cboEmailAccount_Load()
        Try
            'cboSearchEmailAccounts.Items.Clear()
            ''Email Accounts Auto Complete
            'cboSearchEmailAccounts.AutoCompleteMode = AutoCompleteMode.Append
            'cboSearchEmailAccounts.DropDownStyle = ComboBoxStyle.DropDown
            'cboSearchEmailAccounts.AutoCompleteSource = AutoCompleteSource.ListItems

            'LoadComboBox(cboSearchEmailAccounts, "qryCBOSearchEmailAccount_Populate")
            ''cboSearchEmailAccounts.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub LoginName_Load()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter

        Try

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryCurrentLoginName"

            para = New SqlParameter()
            para = CreateParameter("txtUserID", SqlDbType.VarChar, ParameterDirection.Input, m_lngUserID)
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()
            While rsTemp.Read()
                txtLoggedIn.Text = rsTemp.Item("txtUserName")
            End While
            g_lngLoggedUser = m_lngUserID
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cboBuilding_Load()
        Try
            cmbBuilding.Items.Clear()
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbBuilding, "qryCBOBuilding_Populate")
            'cmbBuilding.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cboOffice_Load()
        Try
            cmbRoomNum.Items.Clear()
            cmbRoomNum.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbRoomNum, "qryCBOOffice_Populate")
            'cmbRoomNum.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cboOfficeSub_Load()
        Try
            cmbRoomSub.Items.Clear()
            cmbRoomSub.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbRoomSub, "qryCBOOfficeSub_Populate")
            'cmbRoomSub.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub grdEmployee_Delete()
        Dim objConn As SqlConnection = Nothing
        Dim para As SqlParameter
        Dim qryTemp As SqlCommand = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryDeleteEmployee"

            para = New SqlParameter()
            para.ParameterName = "@EmployeeID"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = SearchEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            qryTemp.ExecuteNonQuery()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            'Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try


    End Sub

    Private Sub grdInventory_Assignment()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngID As Integer = 0
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryHardwareAssignment_Save"

            para = New SqlParameter()
            para.ParameterName = "@FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            lngID = CInt(grdInventory.SelectedCells(0).Value)

            para = New SqlParameter()
            para.ParameterName = "@FK_lngHardware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = lngID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lngID = rsTemp.Item("lngEmployeeHardware")
            End While

            grdHardware_Format()
            grdInvetory_Format()

        Catch ex As Exception
            MsgBox(ex.Message & ": grdInventory_Assignment", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region





    Private Sub HardwareChecklistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardwareChecklistToolStripMenuItem.Click
        'Try
        '    'If grdHardware.RowCount > 0 Then
        '    m_lngHardware = 7 'CInt(grdHardware.SelectedCells(0).Value)
        '    If m_lngHardware > 0 Then
        '        Reporting.HardwareID = m_lngHardware
        '        Reporting.Show()
        '    End If
        '    'End If
        'Catch ex As Exception
        '    MsgBox(ex.Message & ": Hardware Checklist Tool", MsgBoxStyle.Critical, "System Error")
        'End Try
    End Sub



End Class