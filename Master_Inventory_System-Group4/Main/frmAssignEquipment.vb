Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient


Public Class frmAssignEquipment

    Private m_lngEmployeeID As Integer
    Private m_lngHardwareID As Integer



    Public Property Employee() As Integer
        Get
            Employee = m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value
        End Set
    End Property
    Public Property Hardware() As Integer
        Get
            Hardware = m_lngHardwareID
        End Get
        Set(value As Integer)
            m_lngHardwareID = value
        End Set
    End Property


    Private Sub frmAssignEquipment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadComboBox(cmbEmployee, "qryCBOAssignEmployee_Populate")
            'LoadComboBox(cmbHardware, "qryCBOAssignHardware_Populate")

            If m_lngEmployeeID > 0 Then
                SetIntegerID(cmbEmployee, m_lngEmployeeID)
            End If

            'grdHardware_Format()
            'grdHardware_Populate()
            'If m_lngHardwareID > 0 Then
            '    SetIntegerID(cmbHardware, m_lngHardwareID)
            'End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub frmAssignEquipment_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Me.Width = 900
            lblEmployee.Top = 5
            lblEmployee.Left = 5

            cmbEmployee.Top = lblEmployee.Bottom + 5
            cmbEmployee.Left = lblEmployee.Left

            lblHardware.Top = cmbEmployee.Bottom + 5
            lblHardware.Left = cmbEmployee.Left

            grdHardware.Top = lblHardware.Bottom + 5
            grdHardware.Left = lblHardware.Left
            grdHardware.Width = Me.Width - 30
            grdHardware.Height = Me.Height - grdHardware.Top - 50

            btnCancel.Top = cmbEmployee.Top
            btnCancel.Left = grdHardware.Right - btnCancel.Width

            btnSave.Top = cmbEmployee.Top
            btnSave.Left = btnCancel.Left - btnSave.Width - 5

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            For Each row As DataGridViewRow In grdHardware.Rows
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryAssignEquipment_Update"
                qryTemp.Parameters.Add(CreateParameter("@lngEmployee", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbEmployee)))
                qryTemp.Parameters.Add(CreateParameter("@lngHardware", SqlDbType.Int, ParameterDirection.Input, NZ(CInt(row.Cells("PK_autHardwareID").Value), 0)))
                qryTemp.Parameters.Add(CreateParameter("@ysnAssign", SqlDbType.Bit, ParameterDirection.Input, NZ(CBool(row.Cells("ysnAssign").Value), False)))
                qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
                qryTemp.Parameters.Add(CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, CStr(row.Cells("txtHardwareName").Value)))

                objConn.Open()
                qryTemp.ExecuteNonQuery()

                objConn.Close()
                qryTemp.Dispose()
            Next
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
            Me.Dispose()
        End Try
    End Sub
    Private Sub grdHardware_Format()
        Dim colTemp As DataGridViewColumn = Nothing
        Dim colCheck As DataGridViewCheckBoxColumn = Nothing
        Dim celTemp As DataGridViewTextBoxCell = Nothing
        Dim celCheck As DataGridViewCheckBoxCell = Nothing
        Dim colCombo As DataGridViewComboBoxColumn = Nothing
        Dim celCombo As DataGridViewComboBoxCell = Nothing
        Try
            grdHardware.Columns.Clear()

            grdHardware_Populate()

            If grdHardware.Rows.Count > 0 Then
                grdHardware.AllowUserToAddRows = False


                'Primary Key 
                With grdHardware.Columns("PK_autHardwareID")
                    .HeaderText = "Hardware ID"
                    .Width = 50
                    .Visible = False
                End With

                With grdHardware.Columns("ysnAssign")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Assign"
                    .Width = 50
                    .Visible = True
                End With

                With grdHardware.Columns("txtHardwareName")
                    .HeaderText = "Hardware Name"
                    .ReadOnly = False
                    .Width = 150
                End With

                With grdHardware.Columns("txtHardwareTypeName")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtModelName")
                    .HeaderText = "Model"
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

                'Dim cmbTemplate As New ComboBox()
                'LoadComboBox(cmbTemplate, "qryCBOIPAddress_Load")

                'colCombo = New DataGridViewComboBoxColumn()
                'celCombo = New DataGridViewComboBoxCell()
                'colCombo.Visible = True
                'colCombo.Width = 150
                'colCombo.HeaderText = "IP Address"
                'colCombo.Name = "IPAddress"
                'LoadDataGridViewComboBoxColumn(colCombo, "qryCBOIPAddress_Load")
                'grdHardware.Columns.Add(colCombo)



            End If


        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub grdHardware_Populate()
        Dim dt As DataTable
        Dim dr As DataRow
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            'grdHardware.Rows.Clear()


            dt = New DataTable()
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryAssignInventory_Populate"
            qryTemp.Parameters.Add(CreateParameter("lngEmployee", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbEmployee)))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt.Columns.Add("PK_autHardwareID", GetType(Integer))
            dt.Columns.Add("ysnAssign", GetType(Boolean))
            dt.Columns.Add("txtHardwareTypeName", GetType(String))
            dt.Columns.Add("txtModelName", GetType(String))
            dt.Columns.Add("txtSerialNumber", GetType(String))
            dt.Columns.Add("txtServiceTag", GetType(String))
            dt.Columns.Add("txtHardwareName", GetType(String))

            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autHardwareID") = rsTemp.Item("PK_autHardwareID")
                dr("ysnAssign") = rsTemp.Item("ysnAssign")
                dr("txtHardwareTypeName") = rsTemp.Item("txtHardwareTypeName")
                dr("txtModelName") = rsTemp.Item("txtModelName")
                dr("txtSerialNumber") = rsTemp.Item("txtSerialNumber")
                dr("txtServiceTag") = rsTemp.Item("txtServiceTag")
                dr("txtHardwareName") = rsTemp.Item("txtHardwareName")
                dt.Rows.Add(dr)
            End While
            grdHardware.DataSource = dt
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
        Try
            grdHardware_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    
End Class