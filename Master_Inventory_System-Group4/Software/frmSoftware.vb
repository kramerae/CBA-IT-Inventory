Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmSoftware
#Region "Declarations"
    Private m_lngSoftwareID As Integer
    Private m_bolLoading As Boolean = False
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
    Private Sub frmSoftware_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True

            cmbSoftwareType_Load()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub
#End Region

#Region "Button Events"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtSoftwareName.Text Is String.Empty Then
                MsgBox("Please enter a software name.", MsgBoxStyle.OkOnly, "System Message")
            Else
                Software_Save()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Populate/Save/Validate"
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
            qryTemp.CommandText = "qryAddSoftware"
            qryTemp.Connection = objConn

            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            qryTemp.Parameters.Add(CreateParameter("@txtSoftwareName", SqlDbType.VarChar, ParameterDirection.Input, txtSoftwareName.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngSoftwareType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSoftwareType)))
            qryTemp.Parameters.Add(CreateParameter("@txtSoftwareVersion", SqlDbType.VarChar, ParameterDirection.Input, txtSoftwareVersion.Text))

            If txtCost.Text IsNot "" Then
                Dim cost As Decimal
                Decimal.TryParse(txtCost.Text, cost)
                qryTemp.Parameters.Add(CreateParameter("@txtCost", SqlDbType.Money, ParameterDirection.Input, txtCost.Text))
            Else
                qryTemp.Parameters.Add(CreateParameter("@txtCost", SqlDbType.Money, ParameterDirection.Input, DBNull.Value))
            End If

            objConn.Open()
            qryTemp.ExecuteReader()

            MsgBox("Software added successfully.", MsgBoxStyle.OkOnly, "System Message")

        Catch ex As Exception
            HandleException(Me.Name, ex)
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

#End Region
End Class