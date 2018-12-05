Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient

Public Class frmEmployee

#Region "Declarations"

    Private m_bolLoading As Boolean = False
    Private m_lngEmployeeID As Integer
    Private m_lngSearchEmployeeID As Integer
    Private m_lngUserID As Integer
    Private m_lngEmployeeAddress As Integer = 0

#End Region
#Region "Properties"
    Public Property Employee() As Integer
        Get
            Employee = m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value
        End Set
    End Property
#End Region
#Region "Form Events"
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True
            'If m_lngEmployeeID > 0 Then
            '    gbxAcademics.Enabled = True
            '    gbxADGroupList.Enabled = True
            'Else
            '    gbxAcademics.Enabled = False
            '    gbxADGroupList.Enabled = False
            'End If

            cmbBuilding_Load()
            cmbRoomNum_Load()
            cmbRoomSub_Load()
            cmbState_Load()
            cmbDepartment_Load()
            cmbTitle_Load()
            EnableDisableLists()

            If m_lngEmployeeID > 0 Then
                Employee_Populate()
            End If


        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub
    Private Sub frmEmployee_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            btnUpdateAdd.Left = (Me.Width / 2) - (btnUpdateAdd.Width / 2)
            btnUpdateAdd.Top = (Me.Height - btnUpdateAdd.Height - 50)
            btnNewStaffCancel.Top = btnUpdateAdd.Top
            btnNewStaffCancel.Left = Me.Left + 20
            btnDeactivate.Top = btnUpdateAdd.Top
            btnDeactivate.Left = Me.Left + 20

            'lblHardware.Top = gbxADGroupList.Bottom + 5
            lblHardware.Left = gbxAccountInfo.Left

            grdHardware.Top = lblHardware.Bottom + 5
            'grdHardware.Left = Me.Left + 30
            grdHardware.Width = 776
            grdHardware.Height = btnUpdateAdd.Top - lblHardware.Bottom - 10

            gbxAccountInfo.Top = 5
            gbxAccountInfo.Left = 5

            gbxPersonal.Top = 5
            gbxPersonal.Left = 5 + gbxAccountInfo.Right

            gbxAcademics.Top = 5
            gbxAcademics.Left = 5 + grdHardware.Right

            gbxWork.Top = 5 + gbxAccountInfo.Bottom
            gbxWork.Left = gbxAccountInfo.Left

            grdHardware.Left = gbxWork.Left

            gbxMappedDrives.Top = gbxAcademics.Bottom + 5
            gbxMappedDrives.Left = gbxAcademics.Left

            gbxEmailAccounts.Top = gbxAcademics.Top
            gbxEmailAccounts.Left = 5 + gbxMappedDrives.Right

            gbxADGroups.Left = gbxAcademics.Left
            gbxADGroups.Top = gbxMappedDrives.Bottom + 5
            gbxADGroups.Height = btnUpdateAdd.Top - gbxADGroups.Top - 5
            lstADGroups.Height = gbxADGroups.Height - lstADGroups.Top - 5

            gbxListServs.Left = gbxADGroups.Right + 5
            gbxListServs.Top = gbxMappedDrives.Top
            gbxListServs.Height = gbxADGroups.Height
            lstListServs.Height = lstADGroups.Height

            btnEmpReport.Top = gbxPersonal.Bottom + 5
            btnEmpReport.Left = gbxWork.Right + 5

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"
    Private Sub txtEID_TextChanged(sender As Object, e As EventArgs) Handles txtEid.TextChanged
        Try
            txtEmail.Text = txtEid.Text
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub chkWPhone_CheckedChanged(sender As Object, e As EventArgs) Handles chkWPhone.CheckedChanged
        Try
            If chkWPhone.Checked = True Then
                txtOfficePhoneNum.Enabled = True

            Else
                txtOfficePhoneNum.Enabled = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub chkLongDist_CheckedChanged(sender As Object, e As EventArgs) Handles chkLongDist.CheckedChanged
        Try
            If chkLongDist.Checked = True Then
                txtLongDistCode.Enabled = False

            Else
                txtLongDistCode.Enabled = True
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Button Events"
    Private Sub btnEducation_Click(sender As Object, e As EventArgs) Handles btnEducation.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "Education"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()

        Catch ex As Exception
            MsgBox(ex.Message & ":btnEducation_Click", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs)
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "Title"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()
        Catch ex As Exception
            MsgBox(ex.Message & ": btnTitle_Click", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub btnADGroups_Click(sender As Object, e As EventArgs) Handles btnADGroups.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "ADGroups"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnListServs_Click(sender As Object, e As EventArgs) Handles btnListServs.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "ListServs"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnMappedDrives_Click(sender As Object, e As EventArgs) Handles btnMappedDrives.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "MappedDrives"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnEmailAcc_Click(sender As Object, e As EventArgs) Handles btnEmailAcc.Click
        Try
            frmNetworkExtras.EmployeeID = m_lngEmployeeID
            frmNetworkExtras.FormMode = "EmailAcc"
            frmNetworkExtras.ShowDialog()
            Employee_Populate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnUpdateAdd_Click(sender As Object, e As EventArgs) Handles btnUpdateAdd.Click
        Try
            If cmbTitle.SelectedIndex = 0 Then
                MsgBox("Please select a title.", MsgBoxStyle.Exclamation, "Error Message")
            ElseIf cmbRoomNum.SelectedIndex = 0 Then
                MsgBox("Please select a room number.", MsgBoxStyle.Exclamation, "Error Message")
            Else
                AddEmployee_Save()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Grid"
    Private Sub grdHardware_Format()
        Try
            grdHardware.Columns.Clear()

            grdHardware_Populate()

            If grdHardware.ColumnCount > 0 Then
                grdHardware.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grdHardware.AllowUserToAddRows = False
                grdHardware.EditMode = False
                grdHardware.RowHeadersWidth = 5

                'Format the grid

                'Primary Key
                With grdHardware.Columns("PK_autHardwareID")
                    .Width = 50
                    .Visible = False
                End With

                With grdHardware.Columns("txtHardwareName")
                    .HeaderText = "Hardware Name"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtHardwareTypeName")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("txtManufacturerName")
                    .HeaderText = "Manufacturer"
                    .ReadOnly = True
                    .Width = 100
                End With

                With grdHardware.Columns("txtModelName")
                    .HeaderText = "Model"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("txtModelNumber")
                    .HeaderText = "Model Number"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("txtSerialNumber")
                    .HeaderText = "Serial Number"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("txtServiceTag")
                    .HeaderText = "Service Tag"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("txtExpressServiceTag")
                    .HeaderText = "Exp. Service Tag"
                    .ReadOnly = True
                    .Width = 75
                    .Visible = True
                End With

                With grdHardware.Columns("txtIPAddress")
                    .HeaderText = "IP Address"
                    .ReadOnly = True
                    .Width = 75
                End With

                With grdHardware.Columns("ysnAssign")
                    .HeaderText = "Assigned"
                    .ReadOnly = True
                    .Width = 60
                    .Visible = False
                End With

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub grdHardware_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            dt = New DataTable
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryEmployeeAssignedHardware_Populate"
            qryTemp.Parameters.Add(CreateParameter("lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()
            dt.Columns.Add("PK_autHardwareID", GetType(Integer))
            dt.Columns.Add("txtHardwareName", GetType(String))
            dt.Columns.Add("txtHardwareTypeName", GetType(String))
            dt.Columns.Add("txtManufacturerName", GetType(String))
            dt.Columns.Add("txtModelName", GetType(String))
            dt.Columns.Add("txtModelNumber", GetType(String))
            dt.Columns.Add("txtSerialNumber", GetType(String))
            dt.Columns.Add("txtServiceTag", GetType(String))
            dt.Columns.Add("txtExpressServiceTag", GetType(String))
            dt.Columns.Add("txtIPAddress", GetType(String))
            dt.Columns.Add("ysnAssign", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autHardwareID") = rsTemp.Item("PK_autHardwareID")
                dr("txtHardwareName") = rsTemp.Item("txtHardwareName")
                dr("txtHardwareTypeName") = rsTemp.Item("txtHardwareTypeName")
                dr("txtManufacturerName") = rsTemp.Item("txtManufacturerName")
                dr("txtModelName") = rsTemp.Item("txtModelName")
                dr("txtModelNumber") = rsTemp.Item("txtModelNumber")
                dr("txtSerialNumber") = rsTemp.Item("txtSerialNumber")
                dr("txtServiceTag") = rsTemp.Item("txtServiceTag")
                dr("txtExpressServiceTag") = rsTemp.Item("txtExpressServiceTag")
                dr("txtIPAddress") = rsTemp.Item("txtIPAddress")
                dr("ysnAssign") = rsTemp.Item("ysnAssign")

                dt.Rows.Add(dr)

            End While

            grdHardware.DataSource = dt
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Population/Save/Validation"
    Private Sub Employee_Populate()
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
                'Account Section
                txtFirstName.Text = rsTemp.Item("txtFirstName").ToString().Trim()
                txtLastName.Text = rsTemp.Item("txtLastName").ToString().Trim()
                txtEid.Text = rsTemp.Item("txtEID").ToString().Trim()
                txtEmail.Text = rsTemp.Item("txtEmail").ToString().Trim()
                txtDate.Text = rsTemp.Item("dtiModified").ToString()

                'Personal Section
                m_lngEmployeeAddress = rsTemp.Item("PK_autEmployeeAddressID")
                txtAddress.Text = rsTemp.Item("txtAddressLine1").ToString().Trim()
                txtApt.Text = rsTemp.Item("txtAddressLine2").ToString().Trim()
                txtCity.Text = rsTemp.Item("txtCity").ToString().Trim()
                lngSelected = cmbState.FindString(rsTemp.Item("txtState"))
                cmbState.SelectedIndex = lngSelected
                txtZip.Text = rsTemp.Item("txtZipPrefix").ToString().Trim()
                txtHomePhone.Text = FormatPhone(rsTemp.Item("txtHomePhone").ToString().Trim())
                txtCellPhone.Text = FormatPhone(rsTemp.Item("txtCellPhone").ToString().Trim())
                'Work Section
                lngSelected = cmbDepartment.FindString(rsTemp("txtDepartment").ToString())
                cmbDepartment.SelectedIndex = lngSelected
                lngSelected = cmbTitle.FindString(rsTemp("txtTitle").ToString())
                cmbTitle.SelectedIndex = lngSelected
                txtOfficePhoneNum.Text = FormatPhone(rsTemp.Item("txtWorkPhone").ToString().Trim())
                chkWPhone.Checked = IIf(rsTemp.Item("ysnWPhone").ToString() = "True", True, False)
                chkCallerID.Checked = IIf(rsTemp.Item("ysnCallerID").ToString() = "True", True, False)
                txtOutCallerID.Text = rsTemp.Item("txtOutCallerID").ToString()
                chkVoiceMail.Checked = IIf(rsTemp.Item("ysnVoiceMail").ToString() = "True", True, False)
                chkLongDist.Checked = IIf(rsTemp.Item("ysnLongDist").ToString() = "True", True, False)
                txtLongDistCode.Text = rsTemp.Item("txtLongDistCode").ToString()
                chkStaffRoster.Checked = IIf(rsTemp.Item("ysnStaffRoster").ToString() = "True", True, False)
                chkMailRoster.Checked = IIf(rsTemp.Item("ysnMailRoster").ToString() = "True", True, False)
                SetIntegerID(cmbBuilding, NZ(rsTemp.Item("PK_autBuildingID"), 0))
                SetIntegerID(cmbRoomNum, NZ(rsTemp.Item("PK_autOfficeID"), 0))
                SetIntegerID(cmbRoomSub, NZ(rsTemp.Item("PK_autOfficeSubID"), 0))
                lblFloor.Text = NZ(rsTemp.Item("txtFloor"), "")

                'need to add the work information 
            End While
            lbxEdcuation_Populate() : lstEmailAcc_Populate()
            lstADGroups_Populate() : lstListServs_Populate()
            grdHardware_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub
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

            'Account Section
            qryTemp.Parameters.Add(CreateParameter("FK_lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            qryTemp.Parameters.Add(CreateParameter("txtFirstName", SqlDbType.VarChar, ParameterDirection.Input, txtFirstName.Text))
            qryTemp.Parameters.Add(CreateParameter("txtLastName", SqlDbType.VarChar, ParameterDirection.Input, txtLastName.Text))
            qryTemp.Parameters.Add(CreateParameter("txtEID", SqlDbType.VarChar, ParameterDirection.Input, txtEid.Text))
            qryTemp.Parameters.Add(CreateParameter("txtEMail", SqlDbType.VarChar, ParameterDirection.Input, txtEmail.Text))

            'Personal Section
            qryTemp.Parameters.Add(CreateParameter("FK_lngEmployeeAddress", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeAddress))
            qryTemp.Parameters.Add(CreateParameter("txtAddressLine1", SqlDbType.VarChar, ParameterDirection.Input, txtAddress.Text))
            qryTemp.Parameters.Add(CreateParameter("txtAddressLine2", SqlDbType.VarChar, ParameterDirection.Input, txtApt.Text))
            qryTemp.Parameters.Add(CreateParameter("txtCity", SqlDbType.VarChar, ParameterDirection.Input, txtCity.Text))
            qryTemp.Parameters.Add(CreateParameter("txtZipPrefix", SqlDbType.VarChar, ParameterDirection.Input, txtZip.Text))
            qryTemp.Parameters.Add(CreateParameter("FK_lngState", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbState)))
            qryTemp.Parameters.Add(CreateParameter("txtHomePhone", SqlDbType.VarChar, ParameterDirection.Input, StripPhone(txtHomePhone.Text)))
            qryTemp.Parameters.Add(CreateParameter("txtCellPhone", SqlDbType.VarChar, ParameterDirection.Input, StripPhone(txtCellPhone.Text)))

            'Work Section
            qryTemp.Parameters.Add(CreateParameter("FK_lngOffice", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbRoomNum)))
            qryTemp.Parameters.Add(CreateParameter("FK_lngOfficeSub", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbRoomSub)))
            qryTemp.Parameters.Add(CreateParameter("FK_lngBuilding", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbBuilding)))
            qryTemp.Parameters.Add(CreateParameter("ysnWPhone", SqlDbType.Bit, ParameterDirection.Input, IIf(chkWPhone.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("txtWorkPhone", SqlDbType.VarChar, ParameterDirection.Input, StripPhone(txtOfficePhoneNum.Text)))
            qryTemp.Parameters.Add(CreateParameter("ysnCallerID", SqlDbType.Bit, ParameterDirection.Input, IIf(chkCallerID.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("txtOutCallerID", SqlDbType.VarChar, ParameterDirection.Input, txtOutCallerID.Text))
            qryTemp.Parameters.Add(CreateParameter("ysnVoiceMail", SqlDbType.Bit, ParameterDirection.Input, IIf(chkVoiceMail.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("ysnLongDist", SqlDbType.Bit, ParameterDirection.Input, IIf(chkLongDist.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("txtLongDistCode", SqlDbType.VarChar, ParameterDirection.Input, txtLongDistCode.Text))
            qryTemp.Parameters.Add(CreateParameter("ysnStaffRoster", SqlDbType.Bit, ParameterDirection.Input, IIf(chkStaffRoster.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("ysnMailRoster", SqlDbType.Bit, ParameterDirection.Input, IIf(chkMailRoster.Checked = True, 1, 0)))
            qryTemp.Parameters.Add(CreateParameter("FK_lngDepartment", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbDepartment)))
            qryTemp.Parameters.Add(CreateParameter("FK_lngTitle", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbTitle)))
            qryTemp.Parameters.Add(CreateParameter("FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                Employee = rsTemp.Item("lngEmployee")
            End While

            If m_lngEmployeeID > 0 Then
                MsgBox("Employee save successful.", MsgBoxStyle.Exclamation, "Validation Message")
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
        Employee_Populate()
    End Sub
#End Region
#Region "Utility"

    Private Sub cmbDepartment_Load()
        Try
            cmbDepartment.Items.Clear()
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbDepartment, "qryCBOSearchDepartment_Populate")

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
    Private Sub cmbTitle_Load()
        Try
            cmbTitle.Items.Clear()
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbTitle, "qryCBOTitle_Populate")

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cmbBuilding_Load()
        Try
            cmbBuilding.Items.Clear()
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbBuilding, "qryCBOBuilding_Populate")
            'cmbBuilding.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbRoomNum_Load()
        Try
            cmbRoomNum.Items.Clear()
            cmbRoomNum.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbRoomNum, "qryCBOOffice_Populate")
            'cmbRoomNum.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbRoomSub_Load()
        Try
            cmbRoomSub.Items.Clear()
            cmbRoomSub.DropDownStyle = ComboBoxStyle.DropDown

            LoadComboBox(cmbRoomSub, "qryCBOOfficeSub_Populate")
            'cmbRoomSub.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbState_Load()

        Try
            cmbState.Items.Clear()
            'Last Name Auto Complete
            cmbState.AutoCompleteMode = AutoCompleteMode.Append
            cmbState.DropDownStyle = ComboBoxStyle.DropDown
            cmbState.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbState, "qryCBOState_Populate")
            'cmbState.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
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

    Private Sub DeactivateEmployee_Save()
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
            qryTemp.CommandText = "qryEmployeeDeactivate"
            qryTemp.Parameters.Add(CreateParameter("@FK_lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))


            objConn.Open()
            qryTemp.ExecuteNonQuery()

            objConn.Close()
            qryTemp.Dispose()

            MsgBox("Deactivate successful.", MsgBoxStyle.Exclamation, "Validation Message")

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
            'Me.Dispose()
        End Try
    End Sub

    Private Sub EnableDisableLists()
        Dim bolEnabled As Boolean = False
        Try
            If m_lngEmployeeID = 0 Then
                bolEnabled = False
            Else
                bolEnabled = True
            End If

            gbxAcademics.Enabled = bolEnabled
            gbxADGroups.Enabled = bolEnabled
            gbxEmailAccounts.Enabled = bolEnabled
            gbxListServs.Enabled = bolEnabled
            gbxMappedDrives.Enabled = bolEnabled
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnEmpReport_Click(sender As Object, e As EventArgs) Handles btnEmpReport.Click
        Dim frmRefReport As frmEmpReport = Nothing
        Try
            frmRefReport = New frmEmpReport()
            frmRefReport.Employee = m_lngEmployeeID
            frmRefReport.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Dim message As String = "Are you sure you want to deactivate " + txtFirstName.Text.Trim + " " + txtLastName.Text.Trim + "? This action cannot be undone."
        Dim dlgR As DialogResult
        dlgR = MessageBox.Show(message, "Deactivate Employee", MessageBoxButtons.YesNo)
        Try
            If dlgR = DialogResult.Yes Then
                DeactivateEmployee_Save()
                btnUpdateAdd.Enabled = False
                btnNewStaffCancel.Enabled = False
                btnDeactivate.Enabled = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region





End Class