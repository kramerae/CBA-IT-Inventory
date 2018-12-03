Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmHardware2
#Region "Declarations"
    Private m_lngHardwareID As Integer
    Private m_bolLoading As Boolean = False
    Private m_lngEmployeeID As Integer
#End Region

#Region "Properties"
    Public Property Hardware() As Integer
        Get
            Hardware = m_lngHardwareID
        End Get
        Set(value As Integer)
            m_lngHardwareID = value

        End Set
    End Property
#End Region

#Region "Form Events"

    Private Sub frmHardware2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True

            cmbHardwareType_Load()
            cmbIPAddress_Load()
            cmbManufacturer_Load()
            cmbOSType_Load()

            If m_lngHardwareID > 0 Then
                Hardware_Populate()
            End If

            If txtAssigned.Text = "No" Then
                btnUnassign.Enabled = False
                btnAssign.Enabled = True
            Else
                btnUnassign.Enabled = True
                btnAssign.Enabled = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub
#End Region

#Region "Control Events"

#End Region

#Region "Button Events"
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Hardware_Save()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Try
            frmHardware2Assign.Hardware = m_lngHardwareID
            frmHardware2Assign.Employee = m_lngEmployeeID
            frmHardware2Assign.ShowDialog()

            Hardware_Save()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnUnassign_Click(sender As Object, e As EventArgs) Handles btnUnassign.Click
        Dim message As String = "Are you sure you want to unassign " + txtFirstName.Text.Trim + " " + txtLastName.Text.Trim + " from " + txtDeviceName.Text.Trim
        Dim dlgR As DialogResult
        dlgR = MessageBox.Show(message, "Unassign Hardware", MessageBoxButtons.YesNo)
        Try
            If dlgR = DialogResult.Yes Then
                UnassignHardware_Save()
                MsgBox("Unassigned successful.", MsgBoxStyle.Exclamation, "Validation Message")
                btnAssign.Enabled = True
                btnUnassign.Enabled = False
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
        Hardware_Populate()
        'Me.Close()
    End Sub
#End Region

#Region "Populate/Save/Validate"

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
                txtModelName.Text = rsTemp.Item("txtModelName")
                txtModelNumber.Text = rsTemp.Item("txtModelNumber")
                txtSerialNum.Text = rsTemp.Item("txtSerialNumber")
                txtPurchaseDate.Text = rsTemp.Item("dtiPurchaseDate")
                txtWarrantyExpDate.Text = rsTemp.Item("dtiWarrantyExp")
                txtServiceTag.Text = rsTemp.Item("txtServiceTag")
                txtExprServiceTag.Text = rsTemp.Item("txtExpressServiceTag")
                txtMACAddress.Text = rsTemp.Item("txtMACAddress")
                txtBarcode.Text = rsTemp.Item("txtBarcode")
                SetIntegerID(cmbOS, rsTemp.Item("PK_autOSTypeID"))
                txtCPU.Text = rsTemp.Item("txtCPU")
                txtMemory.Text = rsTemp.Item("txtMemory")
                txtHDD.Text = rsTemp.Item("txtHDD")
                txtResolution.Text = rsTemp.Item("txtResolution")
                txtAspectRatio.Text = rsTemp.Item("txtAspectRatio")
                txtMount.Text = rsTemp.Item("txtMount")
                txtInput.Text = rsTemp.Item("txtInput")
                txtPrinterType.Text = rsTemp.Item("txtPrinterType")
                txtBlackInk.Text = rsTemp.Item("txtBlackInk")
                txtColorInk.Text = rsTemp.Item("txtColorInk")
                txtAssigned.Text = rsTemp.Item("txtAssign")
                txtLastName.Text = rsTemp.Item("txtLastName")
                txtFirstName.Text = rsTemp.Item("txtFirstName")
                txtRoom.Text = rsTemp.Item("txtOffice")
                txtDepartment.Text = rsTemp.Item("txtDepartment")
                If rsTemp.Item("PK_autIPAddressID") > 0 Then
                    LoadIPComboBox(cmbIPAddress, "qryCBOIPAddress_Populate", rsTemp.Item("PK_autIPAddressID"))
                    SetIntegerID(cmbIPAddress, rsTemp.Item("PK_autIPAddressID"))
                End If
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

    Private Sub Hardware_Save()
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

            qryTemp.Parameters.Add(CreateParameter("@FK_lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            qryTemp.Parameters.Add(CreateParameter("@FK_lngHardware", SqlDbType.Int, ParameterDirection.Input, m_lngHardwareID))
            qryTemp.Parameters.Add(CreateParameter("@lngHardwareType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbHardwareType)))
            qryTemp.Parameters.Add(CreateParameter("@lngManufacturer", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbManufacturer)))
            qryTemp.Parameters.Add(CreateParameter("@txtServiceTag", SqlDbType.VarChar, ParameterDirection.Input, txtServiceTag.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtExpServiceTag", SqlDbType.VarChar, ParameterDirection.Input, txtExprServiceTag.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtModelNumber", SqlDbType.VarChar, ParameterDirection.Input, txtModelNumber.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtModelName", SqlDbType.VarChar, ParameterDirection.Input, txtModelName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtSerialNumber", SqlDbType.VarChar, ParameterDirection.Input, txtSerialNum.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, txtDeviceName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMACAddress", SqlDbType.VarChar, ParameterDirection.Input, txtMACAddress.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngIPAddress", SqlDbType.VarChar, ParameterDirection.Input, GetIntegerID(cmbIPAddress)))
            qryTemp.Parameters.Add(CreateParameter("@txtBarcode", SqlDbType.VarChar, ParameterDirection.Input, txtBarcode.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngOSType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbOS)))
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            qryTemp.Parameters.Add(CreateParameter("@dtiPurchase", SqlDbType.Date, ParameterDirection.Input, txtPurchaseDate.Text))
            qryTemp.Parameters.Add(CreateParameter("@dtiWarranty", SqlDbType.Date, ParameterDirection.Input, txtWarrantyExpDate.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCPU", SqlDbType.VarChar, ParameterDirection.Input, txtCPU.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMemory", SqlDbType.VarChar, ParameterDirection.Input, txtMemory.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtHDD", SqlDbType.VarChar, ParameterDirection.Input, txtHDD.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtResolution", SqlDbType.VarChar, ParameterDirection.Input, txtResolution.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtAspectRation", SqlDbType.VarChar, ParameterDirection.Input, txtAspectRatio.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMount", SqlDbType.VarChar, ParameterDirection.Input, txtMount.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtInput", SqlDbType.VarChar, ParameterDirection.Input, txtInput.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtPrinterType", SqlDbType.VarChar, ParameterDirection.Input, txtPrinterType.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtBlackInk", SqlDbType.VarChar, ParameterDirection.Input, txtBlackInk.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtColorInk", SqlDbType.VarChar, ParameterDirection.Input, txtColorInk.Text))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                m_lngHardwareID = rsTemp.Item("lngHardware")
            End While

            If m_lngHardwareID > 0 Then
                Hardware_Populate()
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

    Private Sub UnassignHardware_Save()
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
            qryTemp.CommandText = "qryAssignEquipment_Update"
            qryTemp.Parameters.Add(CreateParameter("@lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            qryTemp.Parameters.Add(CreateParameter("@lngHardware", SqlDbType.Int, ParameterDirection.Input, m_lngHardwareID))
            qryTemp.Parameters.Add(CreateParameter("@ysnAssign", SqlDbType.Bit, ParameterDirection.Input, 0))
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            qryTemp.Parameters.Add(CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, txtDeviceName.Text.Trim))

            objConn.Open()
            qryTemp.ExecuteNonQuery()

            objConn.Close()
            qryTemp.Dispose()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
            'Me.Dispose()
        End Try
    End Sub
#End Region

#Region "Utility"
    Private Sub cmbIPAddress_Load()
        Try
            LoadComboBox(cmbIPAddress, "qryCBOIPAddress_Load")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbManufacturer_Load()
        Try
            LoadComboBox(cmbManufacturer, "qryCBOManufacturer_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbOSType_Load()
        Try
            LoadComboBox(cmbOS, "qryCBOOSType_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbHardwareType_Load()
        Try
            LoadComboBox(cmbHardwareType, "qryCBOHardwareType_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnHardwareReport_Click(sender As Object, e As EventArgs) Handles btnHardwareReport.Click
        Dim frmRefReport As frmHardwareReport = Nothing
        Try
            frmRefReport = New frmHardwareReport()
            frmRefReport.Hardware = m_lngHardwareID
            frmRefReport.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSoftwareReport_Click(sender As Object, e As EventArgs) Handles btnSoftwareReport.Click
        Dim frmRefReport As frmHardwareSoftwareReport = Nothing
        Try
            frmRefReport = New frmHardwareSoftwareReport()
            frmRefReport.Hardware = m_lngHardwareID
            frmRefReport.ShowDialog()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region

End Class