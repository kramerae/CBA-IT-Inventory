Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmNetworkExtras
Imports System.Data.SqlClient

Public Class frmCategoryAddEdit
    Private m_strName As String
    Private m_strItemText As String
    Private m_lngItem As Integer
    Private m_strCategoryQueryLoad As String
    Private m_strCategoryName As String
    Private m_strTitle As String
    Private m_bolActive As String
    Private m_strCategory As String

    Public Property ListName() As String
        Get
            ListName = m_strName
        End Get
        Set(value As String)
            m_strName = value
        End Set
    End Property
    Public Property Item() As Integer
        Get
            Item = m_lngItem
        End Get
        Set(value As Integer)
            m_lngItem = value
        End Set
    End Property
    Public Property ItemText() As String
        Get
            ItemText = m_strItemText
        End Get
        Set(value As String)
            m_strItemText = value
        End Set
    End Property
    Public Property CategoryQueryLoad() As String
        Get
            CategoryQueryLoad = m_strCategoryQueryLoad
        End Get
        Set(value As String)
            m_strCategoryQueryLoad = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Title = m_strTitle
        End Get
        Set(value As String)
            m_strTitle = value
        End Set
    End Property
    Public Property Active() As Boolean
        Get
            Active = m_bolActive
        End Get
        Set(value As Boolean)
            m_bolActive = value
        End Set
    End Property
    Public Property Category() As String
        Get
            Category = m_strCategory
        End Get
        Set(value As String)
            m_strCategory = value
        End Set
    End Property
    Public Property CategoryName() As String
        Get
            CategoryName = m_strCategoryName
        End Get
        Set(value As String)
            m_strCategoryName = value
        End Set
    End Property


    Private Sub frmCategoryAddEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Text = m_strName
            lblName.Text = m_strName
            txtTitle.Text = m_strItemText
            lblCategory.Text = m_strCategoryName
            chkActive.Checked = m_bolActive
            LoadComboBox(cmbCategory, m_strCategoryQueryLoad)
            SetStringID(cmbCategory, m_strCategory)

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub cmdSaveCategory_Click(sender As Object, e As EventArgs) Handles cmdSaveCategory.Click
        
        Try

            m_strItemText = txtTitle.Text
            m_strCategory = GetStringID(cmbCategory)
            m_bolActive = chkActive.Checked
            frmNetworkExtras.SavefrmCategoryAddEdit(m_lngItem, m_strItemText, GetIntegerID(cmbCategory), m_bolActive)
            Me.Dispose()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cmdCancelCategory_Click(sender As Object, e As EventArgs) Handles cmdCancelCategory.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
End Class