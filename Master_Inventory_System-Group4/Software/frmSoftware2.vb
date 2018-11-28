Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmSoftware2
#Region "Declarations"
    Private m_lngSoftwareID As Integer
    Private m_bolLoading As Boolean = False
    Private m_lngEmployeeID As Integer
#End Region

#Region "Properties"
    Public Property Software() As Integer
        Get
            Software = m_lngSoftwareID
        End Get
        Set(value As Integer)
            m_lngSoftwareID = value

        End Set
    End Property
#End Region

#Region "Form Events"

    Private Sub frmHardware2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True

            cmbSoftwareType_Load()

            If m_lngSoftwareID > 0 Then
                Software_Populate()
            End If

            ' If txtAssigned.Text = "No" Then
            'btnUnassign.Enabled = False
            'btnAssign.Enabled = True
            'Else
            'btnUnassign.Enabled = True
            'btnAssign.Enabled = False
            'End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub
#End Region
#Region "Populate/Save/Validate"

    Private Sub Software_Populate()
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
            qryTemp.CommandText = "qrySoftwareUpdate_Populate"

            qryTemp.Parameters.Add(CreateParameter("@lngSoftware", SqlDbType.Int, ParameterDirection.Input, m_lngSoftwareID))
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngSoftwareID = rsTemp.Item("PK_autSoftwareID")
                txtSoftwareName.Text = rsTemp.Item("txtSoftwareName")
                txtSoftwareVersion.Text = rsTemp.Item("txtSoftwareVersion")
                SetIntegerID(cmbSoftwareType, rsTemp.Item("PK_autSoftwareTypeID"))
                txtCost.Text = rsTemp.Item("txtCost")

            End While

            lstSoftwareDevices_Populate()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub Software_Save()
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
            qryTemp.CommandText = "qrySoftwareUpdate_Save"
            qryTemp.Connection = objConn

            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            qryTemp.Parameters.Add(CreateParameter("@PK_autSoftwareID", SqlDbType.Int, ParameterDirection.Input, m_lngSoftwareID))
            qryTemp.Parameters.Add(CreateParameter("@txtSoftwareName", SqlDbType.VarChar, ParameterDirection.Input, txtSoftwareName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtSoftwareVersion", SqlDbType.VarChar, ParameterDirection.Input, txtSoftwareVersion.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngSoftwareType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSoftwareType)))
            If txtCost.Text IsNot "" Then
                Dim cost As Decimal
                Decimal.TryParse(txtCost.Text, cost)
                qryTemp.Parameters.Add(CreateParameter("@txtCost", SqlDbType.Money, ParameterDirection.Input, cost))
            Else
                qryTemp.Parameters.Add(CreateParameter("@txtCost", SqlDbType.Money, ParameterDirection.Input, DBNull.Value))
            End If

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngSoftwareID = rsTemp.Item("lngSoftware")
            End While

            If m_lngSoftwareID > 0 Then
                MsgBox("Software saved successfully.", MsgBoxStyle.OkOnly, "System Message")
                Software_Populate()
            Else

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub

    Private Sub lstSoftwareDevices_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngSelected As Integer = Nothing
        Try
            lstSoftwareDevices.Items.Clear()

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryGetSoftHardLinks"

            para = New SqlParameter()
            para.ParameterName = "lngSoftware"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngSoftwareID
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lstSoftwareDevices.Items.Add(rsTemp.Item("txtDeviceName").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message & ": lstSoftwareDevices_Populate", MsgBoxStyle.Critical, "System Error")
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region

#Region "Utility"
    Private Sub cmbSoftwareType_Load()
        Try
            LoadComboBox(cmbSoftwareType, "qryCBOSoftwareType_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Software_Save()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
End Class