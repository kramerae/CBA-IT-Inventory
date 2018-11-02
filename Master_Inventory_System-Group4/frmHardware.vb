Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Master_Inventory_System_Group4.modMain

Public Class frmHardware
#Region "Declarations"
    'Declare module level variables here.
    Protected m_lngEmployeeID As Integer = 0
    Protected m_lngHardwareID As Integer = 0
    Private m_strFormMode As String
    Private m_strName As String

#End Region

#Region "Properties"
    'Declare form properties here.
    Public Property EmployeeID As Integer
        Get
            Return m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value
        End Set
    End Property
    Public Property HardwareID As Integer
        Get
            Return m_lngHardwareID
        End Get
        Set(value As Integer)
            m_lngHardwareID = value
        End Set
    End Property
    Public Property FormMode As String
        Get
            Return m_strFormMode
        End Get
        Set(value As String)
            m_strFormMode = value
        End Set
    End Property
#End Region

#Region "Form Events"
    'List all form events here.
    Private Sub Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ClearForm()
            Me.Text = "Hardware"
            lblFormTitle.Text = "Hardware"
            TabControlHardware.TabPages.Remove(TabSoftware)
            TabControlHardware.TabPages.Remove(TabAccessories)

            'If the hardware is not being assigned to an employee then hide the IP address.
            If m_lngEmployeeID = 0 Then
                txtComputerIpAddress.Visible = False
                lblIPAddress.Visible = False
            Else
                txtComputerIpAddress.Visible = True
                lblIPAddress.Visible = True
            End If

            cboHardwareType_Populate()
            cboManufacturer_Populate()
            Hardware_Populate()
            getEmployee()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region

#Region "Control Events"
    'List all control events here, such as checkbox events, combobox events. Not buttons.

    Private Sub cboHardwareType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHardwareType.SelectedIndexChanged
        'Hardware Type Change
        Try
            If cboHardwareType.SelectedItem.ToString().Trim() = "Desktop" Then
                Me.Text = "Desktop"
                lblFormTitle.Text = "Desktop"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    'nothing
                Else
                    TabControlHardware.TabPages.Add(TabSoftware)
                    grdSoftware_Format()
                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)

                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Laptop" Then
                Me.Text = "Laptop"
                lblFormTitle.Text = "Laptop"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    'nothing
                Else
                    TabControlHardware.TabPages.Add(TabSoftware)
                    grdSoftware_Format()
                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    'TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    TabControlHardware.TabPages.Add(TabAccessories)
                    grdAccessory_Format()
                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Not Assigned" Then
                Me.Text = "Hardware"
                lblFormTitle.Text = "Hardware"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then

                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Thin Client" Then
                Me.Text = "Thin Client"
                lblFormTitle.Text = "Thin Client"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    'TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    TabControlHardware.TabPages.Add(TabSoftware)
                    grdSoftware_Format()
                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Server" Then
                Me.Text = "Server"
                lblFormTitle.Text = "Server"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)
                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Tablet" Then
                Me.Text = "Tablet"
                lblFormTitle.Text = "Tablet"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then

                    'TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    TabControlHardware.TabPages.Add(TabSoftware)
                    grdSoftware_Format()
                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    'TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    TabControlHardware.TabPages.Add(TabAccessories)
                    grdAccessory_Format()
                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Printer" Then
                Me.Text = "Printer"
                lblFormTitle.Text = "Printer"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Work Center" Then
                Me.Text = "Work Center"
                lblFormTitle.Text = "Work Center"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Copier" Then
                Me.Text = "Copier"
                lblFormTitle.Text = "Copier"
                cboAdapterType.Visible = False
                lblAdapterType.Visible = False
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Monitor" Then
                Me.Text = "Monitor"
                lblFormTitle.Text = "Monitor"
                cboAdapterType.Visible = True
                lblAdapterType.Visible = True
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Case" Then
                Me.Text = "Case"
                lblFormTitle.Text = "Case"
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Charger" Then
                Me.Text = "Charger"
                lblFormTitle.Text = "Charger"
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Keyboard" Then
                Me.Text = "Keyboard"
                lblFormTitle.Text = "Keyboard"
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "Dock" Then
                Me.Text = "Dock"
                lblFormTitle.Text = "Dock"
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            ElseIf cboHardwareType.SelectedItem.ToString().Trim() = "VGA Adapter" Then
                Me.Text = "VGA Adapter"
                lblFormTitle.Text = "VGA Adapter"
                If TabControlHardware.TabPages.Contains(TabSoftware) Then
                    TabControlHardware.TabPages.Remove(TabSoftware)
                Else
                    'TabControlHardware.TabPages.Add(TabSoftware)

                End If
                If TabControlHardware.TabPages.Contains(TabAccessories) Then
                    TabControlHardware.TabPages.Remove(TabAccessories)
                Else
                    'TabControlHardware.TabPages.Add(TabAccessories)

                End If
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    'Private Sub tabControlHardware_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlHardware.SelectedIndexChanged

    '    Try
    '        If TabControlHardware.SelectedIndex = 1 Then
    '            'Populate software grid.
    '            grdSoftware_Format()
    '        ElseIf TabControlHardware.SelectedIndex = 2 Then
    '            'Populate Accessory page.
    '            grdAccessory_Format()

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message & ": tabControlHardware_SelectIndexChanged", MsgBoxStyle.Critical, "System Error")
    '    End Try

    'End Sub

    Private Sub chkMonitor_CheckedChanged(sender As Object, e As EventArgs)
        Try


            'If chkMonitor.Checked Then
            '    TabControlNewDesktop.TabPages.Insert(1, TabMonitor)
            'ElseIf chkMonitor.Checked = False Then
            '    TabControlNewDesktop.TabPages.Remove(TabMonitor)
            'End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub chkprinter_CheckedChanged(sender As Object, e As EventArgs)
        Try
            'If chkPrinter.Checked Then
            '    TabControlNewDesktop.TabPages.Add(TabPrinter)
            'ElseIf chkPrinter.Checked = False Then
            '    TabControlNewDesktop.TabPages.Remove(TabPrinter)
            'End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub



    Private Sub chkOtherSoftware_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtherCopy.CheckedChanged
        Try
            If chkOtherCopy.Checked Then
                lblOtherCopy.Enabled = True
                lblOtherCopy.Visible = True
                'txtOtherSoftware.Enabled = True
                'txtOtherSoftware.Visible = True
            ElseIf chkOtherCopy.Checked = False Then
                lblOtherCopy.Enabled = False
                lblOtherCopy.Visible = False
                'txtOtherSoftware.Enabled = False
                'txtOtherSoftware.Visible = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub chkOtherCopy_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtherCopy.CheckedChanged
        Try
            If chkOtherCopy.Checked Then
                lblOtherCopy.Enabled = True
                lblOtherCopy.Visible = True
                txtOtherCopy.Enabled = True
                txtOtherCopy.Visible = True
            ElseIf chkOtherCopy.Checked = False Then
                lblOtherCopy.Enabled = False
                lblOtherCopy.Visible = False
                txtOtherCopy.Enabled = False
                txtOtherCopy.Visible = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Button Events"
    'List all button events here.
    Private Sub btnAddtoInventory_Click(sender As Object, e As EventArgs) Handles btnAddtoInventory.Click

        'Dim result As DialogResult = MsgBox("New Desktop successfully added to Inventory. Would you like to print a New Desktop Checkout report?", MsgBoxStyle.YesNoCancel, "Print Report")
        Try
            If Validation() Then
                If SaveData() Then
                    If MsgBox("New Hardware successfully added to Inventory", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                        Main.Reload_form()
                        Me.Dispose()
                    End If
                Else

                End If
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Try
            Main.Reload_form()
            Me.Dispose()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub
#End Region

#Region "Population/Validation/Save"

#Region "    Population"

    Private Sub getEmployee()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim para As SqlParameter = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryGetSelectedEmployee"

            para = New SqlParameter()
            para.ParameterName = "@FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                txtSFirstName.Text = rsTemp.Item("txtFirstName")
                txtSLastName.Text = rsTemp.Item("txtLastName")
                txtSUserName.Text = rsTemp.Item("txtEID")
            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Hardware_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim para As SqlParameter = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryHardwareUpdate_Populate"

            para = New SqlParameter()
            para.ParameterName = "@FK_lngHardware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngHardwareID
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngHardwareID = rsTemp.Item("PK_autHardwareID")
                txtComputerName.Text = rsTemp.Item("txtHardwareName")
                lngIndex = cboHardwareType.FindString(rsTemp.Item("txtHardwareTypeName").ToString().Trim())
                cboHardwareType.SelectedIndex = lngIndex
                lngIndex = cboManufacturer.FindString(rsTemp.Item("txtManufacturerName").ToString().Trim())
                cboManufacturer.SelectedIndex = lngIndex
                txtModelName.Text = rsTemp.Item("txtModel")
                txtComputerModelNumber.Text = rsTemp.Item("txtModelNumber")
                txtComputerSerialNumber.Text = rsTemp.Item("txtSerialNumber")
                txtComputerServiceTag.Text = rsTemp.Item("txtServiceTag")
                txtComputerExpServiceTag.Text = rsTemp.Item("txtExpressServiceTag")
                txtMACAddress.Text = rsTemp.Item("txtMACAddress")
                txtComputerIpAddress.Text = rsTemp.Item("txtIPAddress")

            End While


        Catch ex As Exception
            MsgBox(ex.Message & ": Hardware_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    Private Sub cboHardwareType_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Try

            cboHardwareType.Items.Clear()

            cboHardwareType.AutoCompleteMode = AutoCompleteMode.Append
            cboHardwareType.DropDownStyle = ComboBoxStyle.DropDown
            cboHardwareType.AutoCompleteSource = AutoCompleteSource.ListItems

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryCBOHardwareType_Populate"

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("HardwareType")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")

                cboHardwareType.Items.Insert(lngIndex, strDescription)
                dt.Rows.Add(dr)
            End While
            'cboHardwareType.SelectedIndex = 0
            'cboSearchDepartment.Items.Insert(dt)

            objConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message & ": cboHardwareType_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    Private Sub cboManufacturer_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Try
            cboManufacturer.Items.Clear()

            cboManufacturer.AutoCompleteMode = AutoCompleteMode.Append
            cboManufacturer.DropDownStyle = ComboBoxStyle.DropDown
            cboManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryCBOManufacturer_Populate"

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Manufacturer")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")

                cboManufacturer.Items.Insert(lngIndex, strDescription)
                dt.Rows.Add(dr)
            End While
            'cboManufacturer.SelectedIndex = 0
            'cboSearchDepartment.Items.Insert(dt)

            objConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message & ": cboManufacturer_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    Private Sub cboAdapter_Populate()

        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Try
            'cboAdapterType.Items.Clear()

            cboAdapterType.AutoCompleteMode = AutoCompleteMode.Append
            cboAdapterType.DropDownStyle = ComboBoxStyle.DropDown
            cboAdapterType.AutoCompleteSource = AutoCompleteSource.ListItems

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = ""

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Manufacturer")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")

                cboAdapterType.Items.Insert(lngIndex, strDescription)
                dt.Rows.Add(dr)
            End While
            cboAdapterType.SelectedIndex = 0
            'cboSearchDepartment.Items.Insert(dt)

            objConn.Close()


        Catch ex As Exception
            MsgBox(ex.Message & ": cboAdapter_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub
#End Region

#Region "    Validation"

    Private Function Validation() As Boolean
        Dim bolValid As Boolean = False
        Try
            bolValid = True

            Return bolValid
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return False
        End Try
    End Function

#End Region

#Region "    Save"

    Private Function SaveData() As Boolean
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim ysnAssign As Boolean = False
        Try
            objConn = New SqlConnection()
            qryTemp = New SqlCommand()

            objConn.ConnectionString = g_ConnectionString

            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryHardwareSave"
            qryTemp.Connection = objConn

            para = New SqlParameter()
            para.ParameterName = "@FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@FK_lngHardware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngHardwareID
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtHardwareType"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = cboHardwareType.SelectedItem.ToString()
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtManufacturer"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = cboManufacturer.SelectedItem.ToString()
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtServiceTag"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtComputerServiceTag.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtExpServiceTag"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtComputerExpServiceTag.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtModelNumber"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtComputerModelNumber.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtModelName"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtModelName.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtSerialNumber"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtComputerSerialNumber.Text
            qryTemp.Parameters.Add(para)


            para = New SqlParameter()
            para.ParameterName = "@txtAdapterType"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            If cboAdapterType.Visible = True Then
                para.Value = cboAdapterType.SelectedItem.ToString()
            Else
                para.Value = ""
            End If
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtHardwareName"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtComputerName.Text
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtIPAddress"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            If txtComputerIpAddress.Visible = True Then
                para.Value = txtComputerIpAddress.Text
            Else
                para.Value = ""
            End If
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()
            para.ParameterName = "@txtMACAddress"
            para.SqlDbType = SqlDbType.VarChar
            para.Direction = ParameterDirection.Input
            para.Value = txtMACAddress.Text
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngHardwareID = rsTemp.Item("lngHardware")
            End While
            'Need to save the other tabs.
            If TabControlHardware.Contains(TabSoftware) Then
                SoftwareSave()
            End If
            If TabControlHardware.Contains(TabAccessories) Then
                AccessorySave()
            End If

            If m_lngHardwareID > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ": SaveData", MsgBoxStyle.Critical, "System Error")
            Return False
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Function
    Private Sub SoftwareSave()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim ysnAssign As Boolean = False

        Try

            Dim i As Integer = 0
            For Each row As DataGridViewRow In grdSoftware.Rows
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qrySoftwareSave"


                para = New SqlParameter()
                para.ParameterName = "@FK_lngHardware"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = m_lngHardwareID
                qryTemp.Parameters.Add(para)

                lngAD = grdSoftware.Rows(i).Cells(0).Value

                para = New SqlParameter()
                para.ParameterName = "@FK_lngItem"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = CInt(lngAD)
                qryTemp.Parameters.Add(para)

                If grdSoftware.Rows(i).Cells(1).Value = True Then
                    ysnAssign = True
                Else
                    ysnAssign = False
                End If
                para = New SqlParameter()
                para.ParameterName = "@ysnAssign"
                para.SqlDbType = SqlDbType.Bit
                para.Direction = ParameterDirection.Input
                para.Value = ysnAssign
                qryTemp.Parameters.Add(para)

                objConn.Open()
                qryTemp.ExecuteNonQuery()
                objConn.Close()
                qryTemp.Dispose()

                i += 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message & ": SoftwareSave", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    Private Sub AccessorySave()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim ysnAssign As Boolean = False
        Try
            Dim i As Integer = 0
            For Each row As DataGridViewRow In grdAccessory.Rows
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryAccessorySave"


                para = New SqlParameter()
                para.ParameterName = "@FK_lngHardware"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = m_lngHardwareID
                qryTemp.Parameters.Add(para)

                lngAD = grdAccessory.Rows(i).Cells(0).Value

                para = New SqlParameter()
                para.ParameterName = "@FK_lngItem"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = CInt(lngAD)
                qryTemp.Parameters.Add(para)

                If grdAccessory.Rows(i).Cells(1).Value = True Then
                    ysnAssign = True
                Else
                    ysnAssign = False
                End If
                para = New SqlParameter()
                para.ParameterName = "@ysnAssign"
                para.SqlDbType = SqlDbType.Bit
                para.Direction = ParameterDirection.Input
                para.Value = ysnAssign
                qryTemp.Parameters.Add(para)

                objConn.Open()
                qryTemp.ExecuteNonQuery()
                objConn.Close()
                qryTemp.Dispose()

                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message & ": AccessorySave", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region
#End Region

#Region "Grid Software"

#Region "    Grid Format"
    Private Sub grdSoftware_Format()
        Dim dt As DataTable
        Try
            grdSoftware.Columns.Clear()

            dt = grdSoftware_Populate()

            grdSoftware.DataSource = dt

            If grdSoftware.ColumnCount > 0 Then
                'Format the grid
                grdSoftware.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                'Primary Key column
                With grdSoftware.Columns("PK_autItemID")
                    .Width = 0
                    .Visible = 0
                End With

                'Assign checkbox column
                With grdSoftware.Columns("Assign")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Assign"
                    .ReadOnly = False
                    .Width = 50
                End With

                'General description column.
                With grdSoftware.Columns("txtDescriptionType")
                    .HeaderText = "Platform"
                    .ReadOnly = True
                    .Width = 100
                End With

                'General description column.
                With grdSoftware.Columns("txtDescription")
                    .HeaderText = "Program"
                    .ReadOnly = True
                    .Width = 235
                End With

                'General description column.
                With grdSoftware.Columns("txtDescriptionVer")
                    .HeaderText = "Version"
                    .ReadOnly = True
                    .Width = 150
                End With

                'Active column
                With grdSoftware.Columns("txtActive")
                    .HeaderText = "Active"
                    .ReadOnly = True
                    .Width = 50
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message & ": grdSoftware_Populate", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
#End Region

#Region "   Grid Populate"

    Private Function grdSoftware_Populate() As DataTable
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

            qryTemp.CommandText = "qryGridSoftware_Populate"


            para = New SqlParameter()
            para.ParameterName = "@FK_lngHardware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngHardwareID 'Needs correct parameter. currently set to a test value
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Software")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("Assign", GetType(Boolean))
            dt.Columns.Add("txtDescriptionType", GetType(String))
            dt.Columns.Add("txtDescription", GetType(String))
            dt.Columns.Add("txtDescriptionVer", GetType(String))
            dt.Columns.Add("txtActive", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("Assign") = rsTemp.Item("Assign")
                dr("txtDescriptionType") = rsTemp.Item("txtDescriptionType")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                dr("txtDescriptionVer") = rsTemp.Item("txtDescriptionVer")
                dr("txtActive") = rsTemp.Item("txtActive")

                dt.Rows.Add(dr)
            End While


            Return dt
        Catch ex As Exception
            MsgBox(ex.Message & ": grdSoftware_Populate", MsgBoxStyle.Critical, "System Error")
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

#Region "Grid Accessory"


#Region "    Grid Format"

    Private Sub grdAccessory_Format()
        Dim dt As DataTable

        Try
            grdAccessory.Columns.Clear()

            dt = grdAccessory_Populate()

            grdAccessory.DataSource = dt

            If grdAccessory.ColumnCount > 0 Then
                'Format the grid

                'Primary Key column
                With grdAccessory.Columns("PK_autItemID")
                    .Width = 0
                    .Visible = 0
                End With

                'Assign checkbox column
                With grdAccessory.Columns("Assign")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Assign"
                    .ReadOnly = False
                    .Width = 50
                End With

                'General description column.
                'With grdAccessory.Columns("txtDescriptionType")
                '    .HeaderText = "Platform"
                '    .ReadOnly = True
                '    .Width = 100
                'End With

                'General description column.
                With grdAccessory.Columns("txtDescription")
                    .HeaderText = "Program"
                    .ReadOnly = True
                    .Width = 235
                End With

                'General description column.
                'With grdAccessory.Columns("txtDescriptionVer")
                '    .HeaderText = "Version"
                '    .ReadOnly = True
                '    .Width = 150
                'End With

                'Active column
                With grdAccessory.Columns("txtActive")
                    .HeaderText = "Active"
                    .ReadOnly = True
                    .Width = 50
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message & ": grdAccessory_Format", MsgBoxStyle.Critical, "System Error")
        End Try

    End Sub

#End Region

#Region "    Grid Populate"

    Private Function grdAccessory_Populate()
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

            qryTemp.CommandText = "qryGridAccessory_Populate"


            para = New SqlParameter()
            para.ParameterName = "@FK_lngHardware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngHardwareID 'Needs correct parameter. currently set to a test value
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Accessory")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("Assign", GetType(Boolean))
            dt.Columns.Add("txtDescription", GetType(String))
            dt.Columns.Add("txtActive", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("Assign") = rsTemp.Item("Assign")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                dr("txtActive") = rsTemp.Item("txtActive")

                dt.Rows.Add(dr)
            End While


            Return dt
        Catch ex As Exception
            MsgBox(ex.Message & ": grdAccessory_Populate", MsgBoxStyle.Critical, "System Error")
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

#Region "Utilities"

    Private Sub ClearForm()
        Try
            txtComputerExpServiceTag.Clear() : chkCopyOutlook.Checked = False
            txtComputerIpAddress.Clear() : chkCopyOutlook.Checked = False
            txtComputerModelNumber.Clear() : chkOtherCopy.Checked = False
            txtComputerName.Clear()
            txtComputerSerialNumber.Clear()
            txtComputerServiceTag.Clear()
            txtModelName.Clear()
            txtOtherCopy.Clear()
            txtSFirstName.Clear()
            txtSLastName.Clear()
            txtSUserName.Clear()
            cboAdapterType.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message & ": ClearForm", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

#End Region

End Class