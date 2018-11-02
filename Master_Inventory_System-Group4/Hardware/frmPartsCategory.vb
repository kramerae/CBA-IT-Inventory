Imports Master_Inventory_System_Group4.frmMain
Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient

Public Class frmPartsCategory
#Region "Declarations"

#End Region
#Region "Properties"

#End Region
#Region "Form Events"

    Private Sub frmPartsCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cmbPartType_Load()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"
    Private Sub cmbPartType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartType.SelectedIndexChanged
        Try
            PopulateList()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Button Events"

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Try
            If cmbPartType.Items.Count > 0 Then
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryPartsCategoryUpdate"

                qryTemp.Parameters.Add(CreateParameter("@FK_lngPartTypeID", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbPartType)))
                qryTemp.Parameters.Add(CreateParameter("@txtDescription", SqlDbType.VarChar, ParameterDirection.Input, txtCategory.Text))
                qryTemp.Parameters.Add(CreateParameter("@lngLoggedUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
                objConn.Open()

                qryTemp.ExecuteNonQuery()


            End If
            PopulateList()
            txtCategory.Text = ""
            txtCategory.Focus()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region
#Region "Utilities"
    Private Sub PopulateList()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Try
            lstPartCategory.Items.Clear()

            If cmbPartType.Items.Count > 0 Then


                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryPartsCategoryGetByPartsTypeID"

                qryTemp.Parameters.Add(CreateParameter("@FK_lngPartTypeID", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbPartType)))
                objConn.Open()
                rsTemp = qryTemp.ExecuteReader()

                While rsTemp.Read
                    lstPartCategory.Items.Add(rsTemp.Item("txtDescription").ToString())
                End While
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub cmbPartType_Load()
        
        Try
            LoadComboBox(cmbPartType, "qryPartType")
        

        Catch ex As Exception
            HandleException(Me.Name, ex)
        
        End Try
    End Sub
#End Region

End Class