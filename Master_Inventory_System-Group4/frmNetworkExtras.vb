Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Master_Inventory_System_Group4.modMain
Imports System.Xml
Public Class frmNetworkExtras

#Region "Declarations"
    'Define all form variables and contructs here.
    Private m_strFormMode As String
    Private m_strName As String
    Private m_lngEmployeeID As Integer
    Private m_ysnCode As Boolean = False
    Private m_ysnCategory As Boolean = False
    Private m_strName2 As String = ""
    Private m_bolItemEdit As Boolean = False
    Private m_PK_autItemKey As Integer
    Private m_FK_Category As Integer
    Private m_strComboQuery As String
    Private m_strPopQuery As String
    Private m_strSavQuery As String
#End Region

#Region "Properties"
    'Define all form properties here.
    Public Property FormMode As String
        Get
            Return m_strFormMode
        End Get
        Set(value As String)
            m_strFormMode = value
        End Set
    End Property
    Public Property EmployeeID As Integer
        Get
            Return m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value
        End Set
    End Property


#End Region

#Region "Form Events"


    'Define all form events in this region.

    Private Sub NetWorkExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'All events triggered on form load are called from here.

        Try
            If m_strFormMode = "ADGroups" Then
                m_strName = "Active Directory Groups"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "ListServs" Then
                m_strName = "List Serves"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "MappedDrives" Then
                m_strName = "Mapped Drives"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "EmailAcc" Then
                m_strName = "Email Accounts"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "Education" Then
                m_strName = "Education"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "Title" Then
                m_strName = "Title"
                Me.Text = m_strName
                lblFormTitle.Text = "Select " & m_strName & ":"
            ElseIf m_strFormMode = "EditState" Then
                m_strName = "State"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditADGroups" Then
                m_strName = "AD Group"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
                m_strName2 = "Department"
            ElseIf m_strFormMode = "EditListServs" Then
                m_strName = "List Servs"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditMappedDrives" Then
                m_strName = "Mapped Drives"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditEmailAcc" Then
                m_strName = "eMail Account"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditEducation" Then
                m_strName = "Education Level"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditTitle" Then
                m_strName = "Title"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
                m_bolItemEdit = True
                m_strName2 = "Department"
            ElseIf m_strFormMode = "EditDepartment" Then
                m_strName = "Department"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditBuilding" Then
                m_strName = "Building"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditOffice" Then
                m_strName = "Office"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditOfficeSub" Then
                m_strName = "Office Sub"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "" Then
                m_strName = "Edit  List"
                lblFormTitle.Text = m_strName & ":"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditHardwareType" Then
                m_strName = "Hardware Type"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditSoftwareType" Then
                m_strName = "Software Type"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditOSType" Then
                m_strName = "OS Type"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditManufacturer" Then
                m_strName = "Manufacturer"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            ElseIf m_strFormMode = "EditIPAddress" Then
                m_strName = "IP Address"
                lblFormTitle.Text = "Edit " & m_strName & " List:"
                Me.Text = m_strName
            End If

            If m_strFormMode.Contains("Edit") Then
                Call EditGridFormat()
            Else
                Call FormPopulation()
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub NetworkExtras_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            'If m_bolItemEdit = False Then
            Me.Width = 10 + 450 + 15
            Me.Height = 505
            btnApply.Left = grdList.Right - btnApply.Width
            btnCancel.Left = btnApply.Left - 10 - btnCancel.Width
            btnSave.Left = btnCancel.Left - 10 - btnSave.Width

            Panel1.Visible = False
            'Else
            'Me.Width = 15 + grdList.Width + 10 + Panel1.Width + 15
            'Panel1.Visible = True
            'btnApply.Left = grdList.Right - btnApply.Width
            'btnCancel.Left = btnApply.Left - 10 - btnCancel.Width
            'btnSave.Left = btnCancel.Left - 10 - btnSave.Width
            'End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub NetworkExtras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Main.Reload_form()

            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Control Events"
    'Define all form component events in this region.

#End Region

#Region "Button Events"
    'Define all form button component events in this region.
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Try
            'Main.Reload_form()
            Me.Dispose()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
        Try
            If m_strFormMode.Contains("Edit") Then
                If FormValidation() Then
                    EditFormSave()

                    EditGridFormat()
                End If
            Else
                If FormValidation() Then
                    FormSave()
                    GridFormat()
                End If
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            If m_strFormMode <> "EditTitle" Then
                If m_strFormMode.Contains("Edit") Then
                    If FormValidation() Then
                        EditFormSave()
                        'Main.Reload_form()
                        Me.Dispose()
                    End If
                Else

                    If FormValidation() Then
                        FormSave()
                        'Main.Reload_form()
                        Me.Dispose()
                    End If
                End If
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try

    End Sub
    Private Sub cmdSaveCategory_Click(sender As Object, e As EventArgs) Handles cmdSaveCategory.Click
        Try
            If ValidateData() = True Then
                SaveCategory()
                m_bolItemEdit = False
                'Call Me.NetworkExtras_Resize(sender, e)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub cmdCancelCategory_Click(sender As Object, e As EventArgs) Handles cmdCancelCategory.Click
        Try
            m_bolItemEdit = False
            'Call Me.NetworkExtras_Resize(sender, e)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "Population/Validation/Save"
    'Define all form population, validation and save subroutines and functions.
#Region "    Population"
    'Define only form population in this region.
    Private Sub FormPopulation()
        Try

            Call GridFormat()
            'Call GridPopulation()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "    Validation"
    'Define only form validation in this region.
    Private Function FormValidation() As Boolean
        Dim bolResult As Boolean = False
        Try
            bolResult = True

            Return bolResult
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return False
        End Try
    End Function
#End Region

#Region "    Save"
    'Define only form save in this region.
    Private Sub FormSave()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim ysnAssign As Boolean = False
        Try
            Dim i As Integer = 0
            For Each row As DataGridViewRow In grdList.Rows
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                If m_strFormMode = "ADGroups" Then
                    qryTemp.CommandText = "qryUpdateEmployeeActiveDirectoryLink"
                ElseIf m_strFormMode = "ListServs" Then
                    qryTemp.CommandText = "qryUpdateEmployeeListServLink"
                ElseIf m_strFormMode = "MappedDrives" Then
                    qryTemp.CommandText = "qryUpdateEmployeeMappedDriveLink"
                ElseIf m_strFormMode = "EmailAcc" Then
                    qryTemp.CommandText = "qryUpdateEmployeeEmailAccountLink"
                ElseIf m_strFormMode = "Education" Then
                    qryTemp.CommandText = "qryUpdateEmployeeEducationLevelLink"
                ElseIf m_strFormMode = "Title" Then
                    qryTemp.CommandText = "qryUpdateEmployeeTitleLink"
                End If

                para = New SqlParameter()
                para.ParameterName = "@FK_lngEmployee"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = m_lngEmployeeID
                qryTemp.Parameters.Add(para)

                lngAD = grdList.Rows(i).Cells("PK_autItemID").Value

                para = New SqlParameter()
                para.ParameterName = "@FK_lngItem"
                para.SqlDbType = SqlDbType.Int
                para.Direction = ParameterDirection.Input
                para.Value = CInt(lngAD)
                qryTemp.Parameters.Add(para)

                If grdList.Rows(i).Cells("Assign").Value = True Then
                    ysnAssign = True
                Else
                    ysnAssign = False
                End If
                para = New SqlParameter()
                para.ParameterName = "@ysnAssign"
                para.SqlDbType = SqlDbType.Bit
                para.Direction = ParameterDirection.Input
                para.Value = ysnAssign
                qryTemp.Parameters.Add(para)

                qryTemp.Parameters.Add(CreateParameter("@FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

                objConn.Open()
                qryTemp.ExecuteNonQuery()
                objConn.Close()
                qryTemp.Dispose()

                i += 1
            Next
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            'Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub EditFormSave()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim strDescription As String = ""
        Dim strCode As String = ""
        Dim ysnActive As Boolean = False
        Dim ysnCode As Boolean = False
        Try
            Dim i As Integer = 0
            For Each row As DataGridViewRow In grdList.Rows
                If Trim(grdList.Rows(i).Cells(2).Value) <> "" Then

                    objConn = New SqlConnection()
                    objConn.ConnectionString = g_ConnectionString

                    qryTemp = New SqlCommand()
                    qryTemp.Connection = objConn
                    qryTemp.CommandType = CommandType.StoredProcedure
                    qryTemp.CommandTimeout = 60
                    If m_strFormMode = "EditADGroups" Then
                        qryTemp.CommandText = "qryUpdateActiveDirectory"
                    ElseIf m_strFormMode = "EditListServs" Then
                        qryTemp.CommandText = "qryUpdateListServ"
                    ElseIf m_strFormMode = "EditMappedDrives" Then
                        qryTemp.CommandText = "qryUpdateMappedDrive"
                    ElseIf m_strFormMode = "EditEmailAcc" Then
                        qryTemp.CommandText = "qryUpdateEmailAccount"
                    ElseIf m_strFormMode = "EditEducation" Then
                        qryTemp.CommandText = "qryUpdateEducationLevel"
                    ElseIf m_strFormMode = "EditTitle" Then
                        qryTemp.CommandText = "qryUpdateTitle"
                    ElseIf m_strFormMode = "EditState" Then
                        qryTemp.CommandText = "qryUpdateState"
                        ysnCode = True
                    ElseIf m_strFormMode = "EditDepartment" Then
                        qryTemp.CommandText = "qryDepartmentListUpdate"
                    ElseIf m_strFormMode = "EditBuilding" Then
                        qryTemp.CommandText = "qryBuildingListUpdate"
                    ElseIf m_strFormMode = "EditOffice" Then
                        qryTemp.CommandText = "qryOfficeListUpdate"
                    ElseIf m_strFormMode = "EditOfficeSub" Then
                        qryTemp.CommandText = "qryOfficeSubListUpdate"
                    ElseIf m_strFormMode = "EditHardwareType" Then
                        qryTemp.CommandText = "qryEditHardwareType_Update"
                    ElseIf m_strFormMode = "EditManufacturer" Then
                        qryTemp.CommandText = "qryEditManufacturer_Update"
                    ElseIf m_strFormMode = "EditSoftwareType" Then
                        qryTemp.CommandText = "qryEditSoftwareType_Update"
                    ElseIf m_strFormMode = "EditOSType" Then
                        qryTemp.CommandText = "qryEditOSType_Update"
                    ElseIf m_strFormMode = "EditIPAddress" Then
                        qryTemp.CommandText = "qryEditIPAddress_Update"

                    End If

                    para = New SqlParameter()
                    para.ParameterName = "@FK_lngEmployee"
                    para.SqlDbType = SqlDbType.Int
                    para.Direction = ParameterDirection.Input
                    para.Value = NZ(m_lngEmployeeID, 0)
                    qryTemp.Parameters.Add(para)

                    lngAD = NZ(grdList.Rows(i).Cells("PK_autItemID").Value, 0)

                    para = New SqlParameter()
                    para.ParameterName = "@FK_lngItem"
                    para.SqlDbType = SqlDbType.Int
                    para.Direction = ParameterDirection.Input
                    para.Value = NZ(lngAD, 0)
                    qryTemp.Parameters.Add(para)

                    strDescription = NZ(grdList.Rows(i).Cells("txtDescription").Value, "")

                    para = New SqlParameter()
                    para.ParameterName = "@txtDescription"
                    para.SqlDbType = SqlDbType.VarChar
                    para.Direction = ParameterDirection.Input
                    para.Value = NZ(strDescription, "")
                    qryTemp.Parameters.Add(para)

                    'Not all lists need this column.
                    If ysnCode Then
                        strCode = NZ(grdList.Rows(i).Cells("txtCode").Value, "")
                    Else
                        strCode = NZ(grdList.Rows(i).Cells("txtDescription").Value, "")
                    End If


                    para = New SqlParameter()
                    para.ParameterName = "@txtCode"
                    para.SqlDbType = SqlDbType.VarChar
                    para.Direction = ParameterDirection.Input
                    para.Value = NZ(strCode, "")
                    qryTemp.Parameters.Add(para)

                    ysnActive = NZ(grdList.Rows(i).Cells("ysnActive").Value, False)

                    para = New SqlParameter()
                    para.ParameterName = "@ysnActive"
                    para.SqlDbType = SqlDbType.Bit
                    para.Direction = ParameterDirection.Input
                    para.Value = NZ(ysnActive, False)
                    qryTemp.Parameters.Add(para)

                    qryTemp.Parameters.Add(CreateParameter("@FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))


                    objConn.Open()
                    qryTemp.ExecuteNonQuery()
                    objConn.Close()
                    qryTemp.Dispose()

                End If
                i += 1

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NetWorkExtras_EditFormSave")
        Finally
            'Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region
#End Region

#Region "Grid"
    'Define all grid subroutines and functions.

#Region "    Format"
    'Define all grid formatting in this region.
    Private Sub GridFormat()
        Dim dt As DataTable
        'Dim cellStyle As DataGridViewCellStyle
        'Dim rowTemplate As DataGridViewRow
        Try

            dt = GridPopulation()

            grdList.DataSource = dt
            grdList.AllowUserToAddRows = False
            grdList.AllowUserToDeleteRows = False


            '   Format the columns of the grid.
            If grdList.ColumnCount > 0 Then


                'Primary Key 
                With grdList.Columns("PK_autItemID")
                    .Width = 0
                    .Visible = False
                End With

                'Assign checkbox column
                With grdList.Columns("Assign")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Assign"
                    .ReadOnly = False
                    .Width = 50
                End With

                'General description column.
                With grdList.Columns("txtDescription")
                    .HeaderText = m_strName
                    .ReadOnly = True
                    .Width = 235
                End With

                'Active column
                With grdList.Columns("txtActive")
                    .HeaderText = "Active"
                    .ReadOnly = True
                    .Width = 50
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            End If


        Catch ex As Exception
            MsgBox(ex.Message & ": GridFormat", MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub
#End Region

#Region "    Populate"
    'Define grid population subroutine in this region.
    Private Function GridPopulation() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter


        Try

            Dim lngID As Integer = 1
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            If m_strFormMode = "ADGroups" Then
                qryTemp.CommandText = "qryActiveDirectory_Populate"
            ElseIf m_strFormMode = "ListServs" Then
                qryTemp.CommandText = "qryListServ_Populate"
            ElseIf m_strFormMode = "MappedDrives" Then
                qryTemp.CommandText = "qryMappedDrive_Populate"
            ElseIf m_strFormMode = "EmailAcc" Then
                qryTemp.CommandText = "qryEmailAccount_Populate"
            ElseIf m_strFormMode = "Education" Then
                qryTemp.CommandText = "qryEducation_Populate"
            ElseIf m_strFormMode = "Title" Then
                qryTemp.CommandText = "qryTitle_Populate"
            End If

            para = New SqlParameter()
            para.ParameterName = "@FK_lngEmployee"
            para.SqlDbType = SqlDbType.Int
            para.Direction = ParameterDirection.Input
            para.Value = m_lngEmployeeID.ToString()
            qryTemp.Parameters.Add(para)

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Generic")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("Assign", GetType(Boolean))
            dt.Columns.Add("txtDescription", GetType(String))
            dt.Columns.Add("txtActive", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("Assign") = rsTemp.Item("Assign")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                dr("txtActive") = rsTemp.Item("txtActive")

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
#End Region

#Region "    Grid Events"

    'Private Sub grdList_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles grdList.Paint
    '    Try
    '        Dim i As Integer = 0
    '        For Each row As DataGridViewRow In grdList.Rows
    '            If grdList.Rows(i).Cells("Assign").Value = True Then
    '                grdList.Rows(i).Cells("Assign").
    '            End If
    '            i += 1
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message & ": GridPreRender", MsgBoxStyle.Critical, "System Error")

    '    End Try
    'End Sub


#End Region

#End Region

#Region "Edit Grid"
    'All edit grid functions here.
#Region "    Format"
    'Format the editable grid here.
    Private Sub EditGridFormat()
        Dim dt As DataTable
        Try
            dt = New DataTable
            dt = EditGridPopulate()

            grdList.DataSource = dt

            '   Format the columns of the grid.
            If grdList.ColumnCount > 0 Then
                grdList.AllowUserToAddRows = True
                If m_strFormMode <> "EditTitle" Then
                    'grdList.AllowUserToAddRows = True
                    grdList.EditMode = DataGridViewEditMode.EditOnEnter
                Else
                    'grdList.AllowUserToAddRows = False
                    grdList.EditMode = False
                End If

                'Primary Key 
                With grdList.Columns("PK_autItemID")
                    .Width = 0
                    .Visible = False
                End With

                'Assign checkbox column ' Not accessible in edit mode.
                With grdList.Columns("Assign")
                    .Visible = False
                    .Width = 0
                End With

                'General description column.
                With grdList.Columns("txtDescription")
                    .HeaderText = m_strName
                    .ReadOnly = False
                    .Width = 175
                End With
                'If m_ysnCode Then
                'General code column.
                With grdList.Columns("txtCode")
                    .HeaderText = "Code"
                    .ReadOnly = False
                    .Width = 50
                    If m_ysnCode Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With
                'End If
                If m_ysnCategory Then
                    'Combobox column
                    With grdList.Columns("txtCategory")
                        .HeaderText = m_strName2
                        .ReadOnly = False
                        .Width = 150
                        .Visible = True
                    End With
                Else
                    '   Do not include
                End If
                'Active column
                With grdList.Columns("ysnActive")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Active"
                    .ReadOnly = False
                    .Width = 50
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
                If m_strFormMode = "EditTitle" Then
                    For i As Integer = 0 To grdList.Columns.Count - 1
                        With grdList.Columns(i)
                            .ReadOnly = True
                        End With

                    Next
                End If

            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region

#Region "    Populate"

    Private Function EditGridPopulate() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try

            Dim lngID As Integer = 1
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            If m_strFormMode = "EditADGroups" Then
                qryTemp.CommandText = "qryEditActiveDirectory_Populate"
            ElseIf m_strFormMode = "EditListServs" Then
                qryTemp.CommandText = "qryEditListServ_Populate"
            ElseIf m_strFormMode = "EditMappedDrives" Then
                qryTemp.CommandText = "qryEditMappedDrive_Populate"
            ElseIf m_strFormMode = "EditEmailAcc" Then
                qryTemp.CommandText = "qryEditEmailAccount_Populate"
            ElseIf m_strFormMode = "EditEducation" Then
                qryTemp.CommandText = "qryEditEducation_Populate"
            ElseIf m_strFormMode = "EditTitle" Then
                qryTemp.CommandText = "qryEditTitle_Populate"
                m_ysnCategory = True
            ElseIf m_strFormMode = "EditState" Then
                qryTemp.CommandText = "qryEditStatePopulate"
                m_ysnCode = True
            ElseIf m_strFormMode = "EditDepartment" Then
                qryTemp.CommandText = "qryEditDepartment_Populate"
            ElseIf m_strFormMode = "EditBuilding" Then
                qryTemp.CommandText = "qryEditBuilding_Populate"
            ElseIf m_strFormMode = "EditOffice" Then
                qryTemp.CommandText = "qryEditOffice_Populate"
            ElseIf m_strFormMode = "EditOfficeSub" Then
                qryTemp.CommandText = "qryEditOfficeSub_Populate"
            ElseIf m_strFormMode = "EditHardwareType" Then
                qryTemp.CommandText = "qryEditHardwareType_Populate"
            ElseIf m_strFormMode = "EditSoftwareType" Then
                qryTemp.CommandText = "qryEditSoftwareType_Populate"
            ElseIf m_strFormMode = "EditOSType" Then
                qryTemp.CommandText = "qryEditOSType_Populate"
            ElseIf m_strFormMode = "EditManufacturer" Then
                qryTemp.CommandText = "qryEditManufacturer_Populate"
            ElseIf m_strFormMode = "EditIPAddress" Then
                qryTemp.CommandText = "qryEditIPAddress_Populate"
            End If

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("Generic")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("Assign", GetType(Boolean))
            dt.Columns.Add("txtDescription", GetType(String))
            'If m_ysnCode Then
            dt.Columns.Add("txtCode", GetType(String))
            'End If
            If m_ysnCategory Then
                dt.Columns.Add("txtCategory", GetType(String))
            End If

            dt.Columns.Add("ysnActive", GetType(Boolean))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("Assign") = rsTemp.Item("Assign")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                If m_ysnCode Then
                    dr("txtCode") = rsTemp.Item("txtCode")
                Else
                    dr("txtCode") = ""
                End If
                dr("ysnActive") = rsTemp.Item("ysnActive")
                If m_ysnCategory Then
                    dr("txtCategory") = rsTemp.Item("txtCategory")
                End If
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

    Private Sub CategoryPopulate()
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
                    m_FK_Category = NZ(rsTemp("PK_autCategory"), 0)
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

#Region "    Events"
    Private Sub grdList_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdList.CellMouseDoubleClick
        Dim lngSelected As Integer = Nothing

        Try
            If m_strFormMode = "EditTitle" Then
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    'lngSelected = grdList.Rows(e.RowIndex).Cells("PK_autItemID").Value
                    'm_PK_autItemKey = lngSelected
                    'm_bolItemEdit = True
                    'Call NetworkExtras_Resize(sender, e)
                    Call CategoryEditList_Load()


                    'Call OpenCategoryEditList(lngSelected)
                End If
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Utilities"
    'Define miscellaneous and utility functions and subroutines.
    Public Sub RefreshGrid()
        Try
            If Me.FormMode.Contains("Edit") Then
                EditGridFormat()
            Else
                GridFormat()
            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Function GetXML() As String
        Dim rowTemp As DataGridViewRow
        Dim strXML As String = ""
        Try
            If grdList.RowCount > 0 Then
                strXML = "<Items>"

                For Each rowTemp In grdList.Rows
                    If rowTemp.GetType() Is GetType(DataGridViewRow) Then
                        strXML = strXML & "<Item PK_autItemID = " & rowTemp.Cells("PK_autItemID").ToString() & " />"
                    End If
                Next

                strXML = strXML & "</Items>"
            End If
            Return strXML
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return Nothing
        End Try
    End Function
    'Private Sub OpenCategoryEditList(lngSelected As Integer)
    '    Dim frmCategoryEditList As CategoryListEdit
    '    Try
    '        frmCategoryEditList = New CategoryListEdit()
    '        frmCategoryEditList.ItemKey = lngSelected
    '        frmCategoryEditList.FormMode = m_strFormMode
    '        frmCategoryEditList.ShowDialog()

    '    Catch ex As Exception
    '        HandleException(Me.Name, ex)
    '    End Try
    'End Sub
    Private Sub CategoryEditList_Load()
        Dim frmRefCategoryAddEdit As frmCategoryAddEdit
        Dim row As DataGridViewRow

        Try
            row = New DataGridViewRow()
            If grdList.Rows.Count > 0 Then
                row = grdList.SelectedRows(0)
            End If
            If m_strFormMode = "EditTitle" Then

                m_strComboQuery = "qryCBOSearchDepartment_Populate"
                m_strPopQuery = "qryEditTitle_CategoryPopulate"
                m_strSavQuery = "qryEditCategory_TitleUpdate"

                frmRefCategoryAddEdit = New frmCategoryAddEdit()
                frmRefCategoryAddEdit.ListName = "Title"
                frmRefCategoryAddEdit.CategoryName = "Department"
                frmRefCategoryAddEdit.CategoryQueryLoad = m_strComboQuery
                frmRefCategoryAddEdit.Item = NZ(row.Cells("PK_autItemID").Value, 0)
                frmRefCategoryAddEdit.Category = NZ(row.Cells("txtCategory").Value, "")
                frmRefCategoryAddEdit.ItemText = NZ(row.Cells("txtDescription").Value, "")
                frmRefCategoryAddEdit.Active = NZ(row.Cells("ysnActive").Value, False)



                frmRefCategoryAddEdit.ShowDialog()


                'NetworkExtras_Resize(Nothing, Nothing)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub SaveCategory()
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
            qryTemp.Parameters.Add(CreateParameter("@FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            objConn.Open()

            qryTemp.ExecuteReader()


        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
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
    Public Sub SavefrmCategoryAddEdit(ByVal lngItem As Integer, ByVal strItemText As String, ByVal lngCategory As Integer, ByVal bolActive As Boolean)
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
            qryTemp.Parameters.Add(CreateParameter("@lngItemID", SqlDbType.Int, ParameterDirection.Input, NZ(lngItem, 0)))
            qryTemp.Parameters.Add(CreateParameter("@txtName", SqlDbType.VarChar, ParameterDirection.Input, NZ(strItemText, "")))
            qryTemp.Parameters.Add(CreateParameter("@lngCategoryID", SqlDbType.Int, ParameterDirection.Input, NZ(lngCategory, 0)))
            qryTemp.Parameters.Add(CreateParameter("@ysnActive", SqlDbType.Bit, ParameterDirection.Input, NZ(bolActive, False)))
            qryTemp.Parameters.Add(CreateParameter("@FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            objConn.Open()

            qryTemp.ExecuteReader()

            RefreshGrid()
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