Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmEmployeeDashboard
#Region "Declarations"
    'Define all form variables and contructs here.
    Private m_lngEmployeeID As Integer
    Private m_lngSearchEmployeeID As Integer
    Private m_lngUserID As Integer
    Private m_lngEmployeeAddress As Integer = 0
    Private m_lngHardware As Integer = 0
    Private m_bolLogOut As Boolean = False
    Private m_bolLoading As Boolean = False
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

    Private Sub frmEmployeeDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True

            cmbSearchDepartment_Load()
            cmbSearchEID_Load()
            cmbSearchFirstName_Load()
            cmbSearchLastName_Load()
            cmbSearchListServ_Load()
            cmbSearchADGroup_Load()
            cmbSearchRoom_Load()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub

    Private Sub frmEmployeeDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            'Align all components to the top left corner
            lblSearchLastName.Top = 10
            lblSearchLastName.Left = 15

            cmbSearchLastName.Top = lblSearchLastName.Bottom + 5
            cmbSearchLastName.Left = lblSearchLastName.Left
            cmbSearchLastName.Width = 150

            grdEmployee.Top = cmbSearchLastName.Bottom + 5
            grdEmployee.Left = cmbSearchLastName.Left
            grdEmployee.Width = Me.Width - 30
            grdEmployee.Height = Me.Height - grdEmployee.Top - 40

            cmbSearchFirstName.Top = cmbSearchLastName.Top
            cmbSearchFirstName.Left = cmbSearchLastName.Right + 5
            cmbSearchFirstName.Width = 145

            lblSearchFirstName.Top = lblSearchLastName.Top
            lblSearchFirstName.Left = cmbSearchFirstName.Left

            cmbSearchEID.Top = cmbSearchFirstName.Top
            cmbSearchEID.Left = cmbSearchFirstName.Right + 5
            cmbSearchEID.Width = 145

            lblSearchEID.Top = lblSearchFirstName.Top
            lblSearchEID.Left = cmbSearchEID.Left

            'Added by Abbey (ROOM)'
            cmbSearchRoom.Top = cmbSearchEID.Top
            cmbSearchRoom.Left = cmbSearchEID.Right + 5
            cmbSearchRoom.Width = 145

            lblSearchRoom.Top = lblSearchEID.Top
            lblSearchRoom.Left = cmbSearchRoom.Left

            cmbSearchDepartment.Top = cmbSearchRoom.Top
            cmbSearchDepartment.Left = cmbSearchRoom.Right + 5
            cmbSearchDepartment.Width = 145

            lblSearchDepartment.Top = lblSearchRoom.Top
            lblSearchDepartment.Left = cmbSearchDepartment.Left

            cmbSearchADGroup.Top = cmbSearchDepartment.Top
            cmbSearchADGroup.Left = cmbSearchDepartment.Right + 5
            cmbSearchADGroup.Width = 145

            lblSearchADGroup.Top = lblSearchDepartment.Top
            lblSearchADGroup.Left = cmbSearchADGroup.Left

            cmbSearchListServ.Top = cmbSearchADGroup.Top
            cmbSearchListServ.Left = cmbSearchADGroup.Right + 5
            cmbSearchListServ.Width = 145

            lblSearchListServ.Top = lblSearchADGroup.Top
            lblSearchListServ.Left = cmbSearchListServ.Left

            btnSearch.Top = cmbSearchListServ.Top - 2
            btnSearch.Left = cmbSearchListServ.Right + 5

            cmdNew.Top = btnSearch.Top
            cmdNew.Left = btnSearch.Right + 5

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

#End Region
#Region "Control Events"
    Private Sub grdEmployee_DoubleClick(sender As Object, e As EventArgs) Handles grdEmployee.DoubleClick
        Dim lngEmployeeID As Integer = 0
        Dim frmRefEmployee As frmEmployee
        Try
            If grdEmployee.Rows.Count > 0 Then
                lngEmployeeID = CInt(grdEmployee.SelectedCells(0).Value)

            End If
            If lngEmployeeID > 0 Then
                frmRefEmployee = New frmEmployee
                frmRefEmployee.Employee = lngEmployeeID
                frmRefEmployee.Name = "Employee"
                frmRefEmployee.Tag = "Employee"
                frmMDIChildAdd(frmRefEmployee)

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub



#End Region
#Region "Button Events"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        
        Try
            grdEmployee_Format()
            
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Dim frmRefNewEmployee As frmEmployee
        Try
            frmRefNewEmployee = New frmEmployee
            frmRefNewEmployee.Name = "New Employee"
            frmRefNewEmployee.Text = "New Employee"
            frmRefNewEmployee.ShowDialog()
            grdEmployee_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Grid"
    Private Function grdEmployee_Populate() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter
        Dim dt As DataTable
        Dim dr As DataRow

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
            para = CreateParameter("@txtEID", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSearchEID))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtFirstName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSearchFirstName))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtLastName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSearchLastName))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngDepartment", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSearchDepartment))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngListServ", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSearchListServ))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@lngAD", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSearchADGroup))
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            'para = CreateParameter("@txtEmailAccountName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cboSearchEmailAccounts))
            para = CreateParameter("@txtEmailAccountName", SqlDbType.VarChar, ParameterDirection.Input, "")
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para = CreateParameter("@txtRoom", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSearchRoom))
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
            dt.Columns.Add("txtWorkPhone", GetType(String))
            dt.Columns.Add("txtRoomNum", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autEmployeeID") = rsTemp.Item("PK_autEmployeeID")
                dr("txtLastName") = rsTemp.Item("txtLastName")
                dr("txtFirstName") = rsTemp.Item("txtFirstName")
                dr("txtEID") = rsTemp.Item("txtEID")
                dr("txtDepartmentName") = rsTemp.Item("txtDepartmentName")
                dr("txtTitleName") = rsTemp.Item("txtTitleName")
                dr("txtWorkPhone") = rsTemp.Item("txtWorkPhone")
                dr("txtRoomNum") = rsTemp.Item("txtRoomNum")

                dt.Rows.Add(dr)
            End While


            Return dt
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return Nothing
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Function
    Private Sub grdEmployee_Format()
        Dim dt As DataTable
        Try

            dt = grdEmployee_Populate() 'Populate the datatable.

            grdEmployee.DataSource = dt 'Set data source of the grid.

            '   Format the columns of the grid.
            If grdEmployee.ColumnCount > 0 Then
                grdEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grdEmployee.AllowUserToAddRows = False

                grdEmployee.RowHeadersWidth = 5


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
                    .HeaderText = "User ID"
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

                'Work Phone column
                With grdEmployee.Columns("txtWorkPhone")
                    .HeaderText = "Office Phone"
                    .ReadOnly = True
                    .Width = 150

                End With

                'Room Num
                With grdEmployee.Columns("txtRoomNum")
                    .HeaderText = "Office Number"
                    .ReadOnly = True
                    .Width = 150

                End With
            End If



        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Functions"
    Private Sub cmbSearchEID_Load()

        Try
            cmbSearchEID.Items.Clear()
            'Staff ID Auto Complete
            cmbSearchEID.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchEID.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchEID.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchEID, "qrySearchEID")
            'cboSearchStaffID.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
    Private Sub cmbSearchFirstName_Load()
        Try
            cmbSearchFirstName.Items.Clear()
            'First Name Auto Complete
            cmbSearchFirstName.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchFirstName.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchFirstName.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchFirstName, "qrySearchFirstName")
            'cboSearchFirstName.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try

    End Sub
    Private Sub cmbSearchLastName_Load()
        Try
            cmbSearchLastName.Items.Clear()
            'Last Name Auto Complete
            cmbSearchLastName.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchLastName.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchLastName.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchLastName, "qrySearchLastName")
            'cboSearchLastName.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
    Private Sub cmbSearchDepartment_Load()

        Try
            cmbSearchDepartment.Items.Clear()
            'Department Auto Complete
            cmbSearchDepartment.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchDepartment.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchDepartment.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchDepartment, "qryCBOSearchDepartment_Populate")
            'cboSearchDepartment.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cmbSearchListServ_Load()

        Try
            cmbSearchListServ.Items.Clear()
            'List Servs Auto Complete
            cmbSearchListServ.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchListServ.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchListServ.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchListServ, "qryCBOSearchListServ_Populate")
            'cboSearchListServs.SelectedIndex = 0

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
    Private Sub cmbSearchADGroup_Load()

        Try
            cmbSearchADGroup.Items.Clear()
            'AD Groups Auto Complete
            cmbSearchADGroup.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchADGroup.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchADGroup.AutoCompleteSource = AutoCompleteSource.ListItems

            'LoadComboBox(cmbSearchADGroup, "qryCBOSearchADGroup_Populate")
            'cboSearchADGroups.SelectedIndex = 0
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub

    Private Sub cmbSearchRoom_Load()

        Try
            cmbSearchRoom.Items.Clear()
            'Room Auto Complete
            cmbSearchRoom.AutoCompleteMode = AutoCompleteMode.Append
            cmbSearchRoom.DropDownStyle = ComboBoxStyle.DropDown
            cmbSearchRoom.AutoCompleteSource = AutoCompleteSource.ListItems

            LoadComboBox(cmbSearchRoom, "qryCBOOffice_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
        End Try
    End Sub
#End Region


End Class