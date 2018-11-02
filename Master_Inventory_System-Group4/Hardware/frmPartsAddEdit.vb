Imports Master_Inventory_System_Group4.frmMain
Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient

Public Class frmPartsAddEdit
#Region "Declarations"
    Private m_lngPartID As Integer = 0
    Private m_strPartType As String = ""
    Private m_lngPartTypeID As Integer = 0
#End Region
#Region "Properties"
    Public Property PartID() As Integer
        Get
            Return m_lngPartID
        End Get
        Set(value As Integer)
            m_lngPartID = value
        End Set
    End Property
    Public Property PartType() As String
        Get
            Return m_strPartType
        End Get
        Set(value As String)
            m_strPartType = value
        End Set
    End Property
    Public Property PartTypeID() As Integer
        Get
            Return m_lngPartTypeID
        End Get
        Set(value As Integer)
            m_lngPartTypeID = value
        End Set
    End Property
#End Region
#Region "Form Events"
    Private Sub frmPartsAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If m_lngPartID = 0 Then
                Me.Text = "Add Part"
            Else
                Me.Text = "Edit Part"
            End If
            lblPartType.Text = m_strPartType

            LoadComboBox(cmbManufacturer, "qryCBOManufacturer_Populate")
            LoadCategory()
            LoadPart()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Button Events"
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            SavePart()
            Me.Close()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"

#End Region
#Region "Utilities"
    Private Sub LoadPart()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryPartsAddEditGetByPartsID"

            qryTemp.Parameters.Add(CreateParameter("@lngPartID", SqlDbType.Int, ParameterDirection.Input, m_lngPartID))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()
            While rsTemp.Read()
                txtCategory1.Text = rsTemp.Item("txtCategory1")
                txtCategory2.Text = rsTemp.Item("txtCategory2")
                txtCategory3.Text = rsTemp.Item("txtCategory3")
                txtCategory4.Text = rsTemp.Item("txtCategory4")
                txtCategory5.Text = rsTemp.Item("txtCategory5")
                txtCategory6.Text = rsTemp.Item("txtCategory6")
                txtCategory7.Text = rsTemp.Item("txtCategory7")
                SetIntegerID(cmbManufacturer, rsTemp.Item("PK_autManufacturerID"))

            End While
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub LoadCategory()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryPartsCategoryGetHeaders"

            qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, m_lngPartTypeID))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lblCategory1.Text = rsTemp.Item("txtCategory1")
                lblCategory2.Text = rsTemp.Item("txtCategory2")
                lblCategory3.Text = rsTemp.Item("txtCategory3")
                lblCategory4.Text = rsTemp.Item("txtCategory4")
                lblCategory5.Text = rsTemp.Item("txtCategory5")
                lblCategory6.Text = rsTemp.Item("txtCategory6")
                lblCategory7.Text = rsTemp.Item("txtCategory7")
            End While

            If lblCategory1.Text.Length > 0 Then
                txtCategory1.Visible = True
            Else
                txtCategory1.Visible = False
            End If

            If lblCategory2.Text.Length > 0 Then
                txtCategory2.Visible = True
            Else
                txtCategory2.Visible = False
            End If

            If lblCategory3.Text.Length > 0 Then
                txtCategory3.Visible = True
            Else
                txtCategory3.Visible = False
            End If

            If lblCategory4.Text.Length > 0 Then
                txtCategory4.Visible = True
            Else
                txtCategory4.Visible = False
            End If

            If lblCategory5.Text.Length > 0 Then
                txtCategory5.Visible = True
            Else
                txtCategory5.Visible = False
            End If

            If lblCategory6.Text.Length > 0 Then
                txtCategory6.Visible = True
            Else
                txtCategory6.Visible = False
            End If

            If lblCategory7.Text.Length > 0 Then
                txtCategory7.Visible = True
            Else
                txtCategory7.Visible = False
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub SavePart()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryPartsUpdateByPK_autID"

            qryTemp.Parameters.Add(CreateParameter("@PK_autID", SqlDbType.Int, ParameterDirection.Input, m_lngPartID))
            qryTemp.Parameters.Add(CreateParameter("@PK_PartTypeID", SqlDbType.Int, ParameterDirection.Input, m_lngPartTypeID))
            qryTemp.Parameters.Add(CreateParameter("@PK_autManufacturerID", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbManufacturer)))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory1", SqlDbType.VarChar, ParameterDirection.Input, txtCategory1.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory2", SqlDbType.VarChar, ParameterDirection.Input, txtCategory2.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory3", SqlDbType.VarChar, ParameterDirection.Input, txtCategory3.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory4", SqlDbType.VarChar, ParameterDirection.Input, txtCategory4.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory5", SqlDbType.VarChar, ParameterDirection.Input, txtCategory5.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory6", SqlDbType.VarChar, ParameterDirection.Input, txtCategory6.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtCategory7", SqlDbType.VarChar, ParameterDirection.Input, txtCategory7.Text))
            qryTemp.Parameters.Add(CreateParameter("@FK_lngUserID", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read()
                If rsTemp.Item("lngReturn") > 0 Then
                    'MsgBox("Save Successful", MsgBoxStyle.OkOnly, "System Message")
                End If
            End While

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region

    
End Class