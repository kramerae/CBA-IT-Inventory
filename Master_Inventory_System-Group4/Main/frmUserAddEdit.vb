Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmUserAddEdit
#Region "Declarations"
    Private lngSelectedUserID As Integer

#End Region
#Region "Properties"
    Public Property SelectUserID() As Integer
        Get
            Return lngSelectedUserID
        End Get
        Set(value As Integer)
            lngSelectedUserID = value
        End Set
    End Property
#End Region
#Region "Form Events"

    Private Sub frmUserAddEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            PopulateForm()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"

#End Region
#Region "Button Events"
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            If ValidateForm() Then
                SaveForm()
                Me.Close()
            Else
                lblErrorMessage.Visible = True
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Utilities"
    Private Sub PopulateForm()
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
            qryTemp.CommandText = "qryGetSelectedUser"

            qryTemp.Parameters.Add(CreateParameter("@lngSelectedUserID", SqlDbType.Int, ParameterDirection.Input, lngSelectedUserID))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                txtUserName.Text = rsTemp.Item("txtUserName")
                txtFirstName.Text = rsTemp.Item("txtFirstName")
                txtLastName.Text = rsTemp.Item("txtLastName")
                txtPassword.Text = rsTemp.Item("txtPassword")
                chkActive.Checked = rsTemp.Item("ysnActive")
            End While

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub SaveForm()
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
            qryTemp.CommandText = "qrySaveUser"

            qryTemp.Parameters.Add(CreateParameter("@lngSelectedUserID", SqlDbType.Int, ParameterDirection.Input, lngSelectedUserID))
            qryTemp.Parameters.Add(CreateParameter("@txtUserName", SqlDbType.VarChar, ParameterDirection.Input, txtUserName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtFirstName", SqlDbType.VarChar, ParameterDirection.Input, txtFirstName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtLastName", SqlDbType.VarChar, ParameterDirection.Input, txtLastName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtPassword", SqlDbType.VarChar, ParameterDirection.Input, txtPassword.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngLoggedUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            qryTemp.Parameters.Add(CreateParameter("@ysnActive", SqlDbType.Bit, ParameterDirection.Input, IIf(chkActive.Checked = True, 1, 0)))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()


        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Function ValidateForm() As Boolean
        Try

            If txtUserName.Text.Trim.Length > 0 Then

                If txtFirstName.Text.Trim.Length > 0 Then

                    If txtLastName.Text.Trim.Length > 0 Then

                        If txtPassword.Text.Trim.Length > 0 Then
                            Return True
                        Else
                            lblErrorPassword.Visible = True
                            Return False
                        End If
                    Else
                        lblErrorLastName.Visible = True
                        Return False
                    End If
                Else
                    lblErrorFirstName.Visible = True
                    Return False
                End If
            Else
                lblErrorUserName.Visible = True
                Return False
            End If


        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return False
        End Try
    End Function
#End Region

    
End Class