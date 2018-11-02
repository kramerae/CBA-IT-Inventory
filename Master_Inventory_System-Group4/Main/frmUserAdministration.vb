Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmUserAdministration
#Region "Declarations"

#End Region
#Region "Properties"

#End Region
#Region "Form Events"
    Private Sub frmUserAdministration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Format_Grid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub frmUserAdministration_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            grdUsers.Width = Me.Width - 30
            grdUsers.Height = Me.Height - grdUsers.Top - 130
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Grid"
    Private Function Populate_Grid() As DataTable
        Dim dt As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dr As DataRow
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryGetUserAll"
            qryTemp.Parameters.Add(CreateParameter("@lngLoggedUserID", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Users")
            dt.Columns.Add("PK_autUserID", GetType(Integer))
            dt.Columns.Add("txtUserName", GetType(String))
            dt.Columns.Add("txtFirstName", GetType(String))
            dt.Columns.Add("txtLastName", GetType(String))
            dt.Columns.Add("txtPassword", GetType(String))
            dt.Columns.Add("ysnActive", GetType(Boolean))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autUserID") = rsTemp.Item("PK_autUserID")
                dr("txtUserName") = rsTemp.Item("txtUserName")
                dr("txtFirstName") = rsTemp.Item("txtFirstName")
                dr("txtLastName") = rsTemp.Item("txtLastName")
                dr("txtPassword") = rsTemp.Item("txtPassword")
                dr("ysnActive") = rsTemp.Item("ysnActive")

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
    Private Sub Format_Grid()
        Dim dt As DataTable
        Try
            dt = Populate_Grid()

            grdUsers.DataSource = dt


            If grdUsers.ColumnCount > 0 Then
                grdUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grdUsers.AllowUserToAddRows = False

                With grdUsers.Columns("PK_autUserID")
                    .Width = 0
                    .Visible = 0
                End With

                With grdUsers.Columns("txtUserName")
                    .Width = 70
                    .Visible = True
                    .ReadOnly = True
                    .HeaderText = "User ID"
                End With

                With grdUsers.Columns("txtFirstName")
                    .Width = 70
                    .Visible = True
                    .ReadOnly = True
                    .HeaderText = "First"
                End With

                With grdUsers.Columns("txtLastName")
                    .Width = 70
                    .Visible = True
                    .ReadOnly = True
                    .HeaderText = "Last"
                End With

                With grdUsers.Columns("txtPassword")
                    .Width = 70
                    .Visible = True
                    .ReadOnly = True
                    .HeaderText = "Password"
                End With

                With grdUsers.Columns("ysnActive")
                    .Width = 50
                    .Visible = True
                    .ReadOnly = True
                    .HeaderText = "Active"
                End With

            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub grdUsers_DoubleClick(sender As Object, e As EventArgs) Handles grdUsers.DoubleClick
        Dim lngSelected As Integer = 0
        Try
            If grdUsers.Rows.Count > 0 Then
                lngSelected = CInt(grdUsers.SelectedCells(0).Value)

                EditSelected(lngSelected)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Button Events"

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Try
            EditSelected(0)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim lngSelected As Integer = 0
        Try
            If grdUsers.Rows.Count > 0 Then
                lngSelected = CInt(grdUsers.SelectedCells(0).Value)

                EditSelected(lngSelected)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    
#End Region
#Region "Control Events"

#End Region
#Region "Utilities"
    Private Sub EditSelected(lngSelectedUser As Integer)
        Dim frmRefUserAddEdit As frmUserAddEdit
        Try
            frmRefUserAddEdit = New frmUserAddEdit()
            frmRefUserAddEdit.SelectUserID = lngSelectedUser
            frmRefUserAddEdit.ShowDialog()
            RefreshGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Public Sub RefreshGrid()
        Format_Grid()
    End Sub
#End Region

    
End Class