Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient


Public Class frmHardware2Assign

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


    Private Sub frmHardware2Assign_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadComboBox(cmbEmployee, "qryCBOAssignEmployee_Populate")

            LoadComboBox(cmbManufacturer, "qryCBOManufacturer_Populate")
            LoadComboBox(cmbHardwareType, "qryCBOHardwareType_Populate")

            Hardware_Populate()
            txtDeviceName.ReadOnly = True
            txtModelNumber.ReadOnly = True
            txtSerialNum.ReadOnly = True
            txtServiceTag.ReadOnly = True
            cmbHardwareType.Enabled = False
            cmbManufacturer.Enabled = False
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

            If GetIntegerID(cmbEmployee) > 0 Then

                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryAssignEquipment_Update"
                qryTemp.Parameters.Add(CreateParameter("@lngEmployee", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbEmployee)))
                qryTemp.Parameters.Add(CreateParameter("@lngHardware", SqlDbType.Int, ParameterDirection.Input, m_lngHardwareID))
                qryTemp.Parameters.Add(CreateParameter("@ysnAssign", SqlDbType.Bit, ParameterDirection.Input, 1))
                qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
                qryTemp.Parameters.Add(CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, txtDeviceName.Text))

                objConn.Open()
                qryTemp.ExecuteNonQuery()

                objConn.Close()
                qryTemp.Dispose()

                MsgBox("Hardware saved successfully.", MsgBoxStyle.OkOnly, "System Message")

            Else
                MsgBox("You must select an employee.", MsgBoxStyle.OkOnly, "System Message")
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
            Me.Dispose()
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
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngHardwareID = rsTemp.Item("PK_autHardwareID")
                txtDeviceName.Text = rsTemp.Item("txtDeviceName")
                SetIntegerID(cmbHardwareType, rsTemp.Item("PK_autHardwareTypeID"))
                SetIntegerID(cmbManufacturer, rsTemp.Item("PK_autManufacturerID"))
                txtModelNumber.Text = rsTemp.Item("txtModelNumber")
                txtSerialNum.Text = rsTemp.Item("txtSerialNumber")
                txtServiceTag.Text = rsTemp.Item("txtServiceTag")

                m_lngEmployeeID = rsTemp.Item("PK_autEmployeeID")
            End While


        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub


End Class