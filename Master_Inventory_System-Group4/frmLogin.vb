Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Master_Inventory_System_Group4.modMain
Imports System.IO.Directory


Public Class frmLogin
    Private UserCount As Integer = 0
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtUserName.Text = ""
            txtPassword.Text = ""
            lblErrorMessage.Visible = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub UserAuthenticated()
        Me.Hide()
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Try
            txtUserName.Text = Nothing
            txtPassword.Text = Nothing
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Try
            'frmMain.Show()
            'Call UserAuthenticated()
            If UserCount >= 2 Then
                lblErrorMessage.Text = "You have exceeded the number of attempts allowed"
                lblErrorMessage.Visible = True
                btnlogin.Enabled = False

            Else
                If ValidateData() Then
                    If AuthenticateUser() Then
                        frmMain.Show()
                        Call UserAuthenticated()


                    Else
                        txtUserName.Clear()
                        txtUserName.Focus()
                        txtPassword.Clear()
                        UserCount += 1
                    End If
                Else
                    txtUserName.Clear()
                    txtUserName.Focus()
                    txtPassword.Clear()

                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Function ValidateData()
        Try
            If txtUserName.Text.Length > 0 Then
                If txtPassword.Text.Length > 0 Then
                    Return True
                Else
                    lblErrorMessage.Text = "Please enter a password!"
                    lblErrorMessage.Visible = True
                    txtPassword.Focus()
                    Return False
                End If
            Else
                lblErrorMessage.Text = "Please enter a user name!"
                lblErrorMessage.Visible = True
                Return False
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    Private Function AuthenticateUser() As Boolean
        Dim lngUserID As Integer = 1
        Dim para As SqlParameter = Nothing
        Try

            Dim objConn As New SqlClient.SqlConnection
            Dim qryTemp As New SqlClient.SqlCommand

            Dim rsTemp As SqlClient.SqlDataReader


            objConn.ConnectionString = g_ConnectionString

            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandText = "qryCheckUserLogin"
            qryTemp.CommandTimeout = 60

            para = New SqlParameter()

            para = CreateParameter("@txtUserName", SqlDbType.VarChar, ParameterDirection.Input, txtUserName.Text)
            qryTemp.Parameters.Add(para)

            para = New SqlParameter()

            para = CreateParameter("@txtPassword", SqlDbType.VarChar, ParameterDirection.Input, txtPassword.Text)
            qryTemp.Parameters.Add(para)

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read()
                lngUserID = rsTemp.Item("PK_autUserID")
            End While

            If lngUserID > 0 Then
                'MsgBox("Login Successful", MsgBoxStyle.Information, "Login Passed")
                frmMain.UserID = lngUserID
                g_lngLoggedUser = lngUserID
                frmMain.Show()
                txtUserName.Clear()
                txtPassword.Clear()

                Return True

            Else
                MsgBox("Login Failed. You have " & (2 - UserCount).ToString() & " attempt(s) remaining.", MsgBoxStyle.Critical, "Invalid Account")
                txtUserName.Clear()
                txtPassword.Clear()
                Return False
            End If
            Return False
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return False
        End Try
    End Function

End Class