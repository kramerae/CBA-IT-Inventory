Imports Master_Inventory_System_Group4
Imports Master_Inventory_System_Group4.modMain
Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class CategoryListEdit
#Region "Declarations"
    Private m_strFormMode As String
    Private m_strQuery As String
    Private m_PK_autItemKey As Integer
    Private m_FK_Category As Integer
    Private m_strComboQuery As String
    Private m_strPopQuery As String
    Private m_strSavQuery As String
#End Region
#Region "Properties"
    Public Property FormMode() As String
        Get
            FormMode = m_strFormMode
        End Get
        Set(value As String)
            m_strFormMode = value
        End Set
    End Property
    Public Property ItemKey() As Integer
        Get
            ItemKey = m_PK_autItemKey
        End Get
        Set(value As Integer)
            m_PK_autItemKey = value
        End Set
    End Property
#End Region
#Region "Form Events"
    Private Sub CategoryEditList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If m_strFormMode = "EditTitle" Then
                Me.Text = "Title"
                lblName.Text = "Title"
                lblCategory.Text = "Department"
                m_strComboQuery = "qryCBOSearchDepartment_Populate"
                m_strPopQuery = "qryEditTitle_CategoryPopulate"
                m_strSavQuery = "qryEditCategory_TitleUpdate"
            End If

            LoadComboBox(cmbCategory, m_strComboQuery)
            Call FormPopulate()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
#Region "Control Events"

#End Region
#Region "Button Events"
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            If ValidateData() = True Then
                SaveData()
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region
#Region "Populate/Save/Validate"
#Region "    Populate"
    Private Sub FormPopulate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = m_strPopQuery
            qryTemp.Parameters.Add(CreateParameter("@lngItemID", SqlDbType.Int, ParameterDirection.Input, m_PK_autItemKey))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            If Not IsNothing(rsTemp) Then
                Do While rsTemp.Read
                    m_PK_autItemKey = NZ(rsTemp("PK_autItemID"), 0)
                    txtTitle.Text = NZ(rsTemp("txtDescription"), "")
                    m_FK_Category = NZ(rsTemp("PK_autTitleDepartment"), 0)
                    If NZ(rsTemp("ysnActive"), False) = True Then
                        chkActive.Checked = True
                    Else
                        chkActive.Checked = False
                    End If
                Loop
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region
#Region "    Save"
    Private Sub SaveData()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = m_strSavQuery
            qryTemp.Parameters.Add(CreateParameter("@lngItemID", SqlDbType.Int, ParameterDirection.Input, m_PK_autItemKey))
            qryTemp.Parameters.Add(CreateParameter("@txtName", SqlDbType.VarChar, ParameterDirection.Input, txtTitle.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngCategoryID", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbCategory)))
            qryTemp.Parameters.Add(CreateParameter("@ysnActive", SqlDbType.Bit, ParameterDirection.Input, chkActive.Checked))

            objConn.Open()

            qryTemp.ExecuteReader()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "    Validate"
    Private Function ValidateData() As Boolean
        Dim bolResult As Boolean = True
        Try
            If txtTitle.Text.Length = 0 Then
                bolResult = False
            End If
            If cmbCategory.SelectedIndex <= 0 Then
                bolResult = False
            End If
            Return bolResult
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return False
        End Try
    End Function
#End Region
#End Region
#Region "Utilities"

#End Region

    
End Class