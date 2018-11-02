Imports Master_Inventory_System_Group4.frmMain
Imports Master_Inventory_System_Group4.modMain
Imports System.Data.SqlClient

Public Class frmParts
#Region "Declarations"
    Private strCategory1Header As String = ""
    Private strCategory2Header As String = ""
    Private strCategory3Header As String = ""
    Private strCategory4Header As String = ""
    Private strCategory5Header As String = ""
    Private strCategory6Header As String = ""
    Private strCategory7Header As String = ""
#End Region
#Region "Properties"

#End Region
#Region "Form Events"

    Private Sub frmParts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadPartType()
            FormatGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub frmParts_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            grdParts.Width = Me.Width - 50
            grdParts.Height = Me.Height - grdParts.Top - 60
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Button Events"
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            OpenPartsAddEdit()
            FormatGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        Dim frmRefPartsAddEdit As frmPartsAddEdit
        Dim lngSelectedRowID As Integer
        Try
            
            lngSelectedRowID = 0
            frmRefPartsAddEdit = New frmPartsAddEdit()
            frmRefPartsAddEdit.PartID = lngSelectedRowID
            frmRefPartsAddEdit.PartType = GetStringID(cmbPartType)
            frmRefPartsAddEdit.PartTypeID = GetIntegerID(cmbPartType)
            frmRefPartsAddEdit.ShowDialog()

            FormatGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"
    Private Sub cmbPartType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartType.SelectedIndexChanged
        Try

            FormatGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub grdParts_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdParts.CellContentDoubleClick
        Try
            OpenPartsAddEdit()
            FormatGrid()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Utilities"
    Private Sub LoadPartType()
        Try
            LoadComboBox(cmbPartType, "qryPartType")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub FormatGrid()
        Dim dt As New DataTable()
        Try
            grdParts.Columns.Clear()

            dt = PopulateGrid()
            grdParts.DataSource = dt


            
            GetHeaders()

            If grdParts.Columns.Count > 0 Then
                grdParts.AllowUserToAddRows = False
                grdParts.AllowUserToDeleteRows = False
                grdParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                'Primary Key
                With grdParts.Columns("PK_autID")
                    .Width = 0
                    .Visible = False
                End With

                With grdParts.Columns("PK_autManufacturerID")
                    .Width = 0
                    .Visible = False

                End With

                With grdParts.Columns("txtManufacturer")
                    .HeaderText = "Manufacturer"
                    .ReadOnly = True
                    .Width = 150
                    
                End With

                With grdParts.Columns("txtCategory1")
                    .HeaderText = strCategory1Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory1Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory2")
                    .HeaderText = strCategory2Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory2Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory3")
                    .HeaderText = strCategory3Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory3Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory4")
                    .HeaderText = strCategory4Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory4Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory5")
                    .HeaderText = strCategory5Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory5Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory6")
                    .HeaderText = strCategory6Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory6Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grdParts.Columns("txtCategory7")
                    .HeaderText = strCategory7Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory7Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

            End If

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Function PopulateGrid() As DataTable
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryPartsGetAllByPartTypeID"

            qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbPartType)))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable()
            dt.Columns.Add("PK_autID", GetType(Integer))
            dt.Columns.Add("PK_autManufacturerID", GetType(Integer))
            dt.Columns.Add("txtManufacturer", GetType(String))
            dt.Columns.Add("txtCategory1", GetType(String))
            dt.Columns.Add("txtCategory2", GetType(String))
            dt.Columns.Add("txtCategory3", GetType(String))
            dt.Columns.Add("txtCategory4", GetType(String))
            dt.Columns.Add("txtCategory5", GetType(String))
            dt.Columns.Add("txtCategory6", GetType(String))
            dt.Columns.Add("txtCategory7", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autID") = rsTemp.Item("PK_autID")
                dr("PK_autManufacturerID") = rsTemp.Item("PK_autManufacturerID")
                dr("txtManufacturer") = rsTemp.Item("txtManufacturer")
                dr("txtCategory1") = rsTemp.Item("txtCategory1")
                dr("txtCategory2") = rsTemp.Item("txtCategory2")
                dr("txtCategory3") = rsTemp.Item("txtCategory3")
                dr("txtCategory4") = rsTemp.Item("txtCategory4")
                dr("txtCategory5") = rsTemp.Item("txtCategory5")
                dr("txtCategory6") = rsTemp.Item("txtCategory6")
                dr("txtCategory7") = rsTemp.Item("txtCategory7")

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
    'Private Sub SaveGrid()
    '    Dim objConn As SqlConnection = Nothing
    '    Dim qryTemp As SqlCommand = Nothing
    '    Dim rsTemp As SqlDataReader = Nothing
    '    Dim dt As DataTable = Nothing
    '    'Dim dr As DataRow = Nothing
    '    Dim lngtest As Integer
    '    For Each dr As DataGridViewRow In grdParts.Rows
    '        Try
    '            objConn = New SqlConnection()
    '            objConn.ConnectionString = g_ConnectionString

    '            qryTemp = New SqlCommand()
    '            qryTemp.Connection = objConn
    '            qryTemp.CommandType = CommandType.StoredProcedure
    '            qryTemp.CommandTimeout = 60
    '            qryTemp.CommandText = "qryPartsUpdateByPK_autID"

    '            lngtest = GetDVGIntegerID(dr.Cells("PK_autManufacturerID"))
    '            qryTemp.Parameters.Add(CreateParameter("@PK_autID", SqlDbType.Int, ParameterDirection.Input, dr.Cells("PK_autID").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@PK_PartTypeID", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbPartType)))
    '            qryTemp.Parameters.Add(CreateParameter("@PK_autManufacturerID", SqlDbType.Int, ParameterDirection.Input, GetDVGIntegerID(dr.Cells("PK_autManufacturerID"))))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory1", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory1").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory2", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory2").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory3", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory3").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory4", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory4").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory5", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory5").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory6", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory6").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@txtCategory7", SqlDbType.VarChar, ParameterDirection.Input, dr.Cells("txtCategory7").Value))
    '            qryTemp.Parameters.Add(CreateParameter("@FK_lngUserID", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
    '            objConn.Open()

    '            rsTemp = qryTemp.ExecuteReader()

    '            While rsTemp.Read()
    '                If rsTemp.Item("lngReturn") > 0 Then
    '                    MsgBox("Save Successful", MsgBoxStyle.OkOnly, "System Message")
    '                End If
    '            End While

    '        Catch ex As Exception
    '            HandleException(Me.Name, ex)
    '        Finally
    '            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
    '            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
    '            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
    '        End Try
    '    Next
    'End Sub
    Private Sub GetHeaders()
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

            qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbPartType)))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                strCategory1Header = rsTemp.Item("txtCategory1")
                strCategory2Header = rsTemp.Item("txtCategory2")
                strCategory3Header = rsTemp.Item("txtCategory3")
                strCategory4Header = rsTemp.Item("txtCategory4")
                strCategory5Header = rsTemp.Item("txtCategory5")
                strCategory6Header = rsTemp.Item("txtCategory6")
                strCategory7Header = rsTemp.Item("txtCategory7")
            End While
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub OpenPartsAddEdit()
        Dim frmRefPartsAddEdit As frmPartsAddEdit
        Dim lngSelectedRowID As Integer
        Try
            If grdParts.Rows.Count > 0 Then
                lngSelectedRowID = NZ(grdParts.SelectedCells(0).Value, 0)
            Else
                lngSelectedRowID = 0
            End If
            frmRefPartsAddEdit = New frmPartsAddEdit()
            frmRefPartsAddEdit.PartID = lngSelectedRowID
            frmRefPartsAddEdit.PartType = GetStringID(cmbPartType)
            frmRefPartsAddEdit.PartTypeID = GetIntegerID(cmbPartType)
            frmRefPartsAddEdit.ShowDialog()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    'Private Function LoadDGVCombo(ByRef cmb As DataGridViewComboBoxColumn) As DataGridViewComboBoxColumn
    '    Dim objConn As SqlConnection = Nothing
    '    Dim qryTemp As SqlCommand = Nothing
    '    Dim rsTemp As SqlDataReader = Nothing
    '    Dim dt As DataTable = Nothing
    '    Dim dr As DataRow = Nothing
    '    Dim lngIndex As Integer = Nothing
    '    Dim strDescription As String = Nothing
    '    Dim Item As clsItemData
    '    Dim i As Integer = 0

    '    Try
    '        cmb.Items.Clear()

    '        objConn = New SqlConnection()
    '        objConn.ConnectionString = g_ConnectionString

    '        qryTemp = New SqlCommand()
    '        qryTemp.Connection = objConn
    '        qryTemp.CommandType = CommandType.StoredProcedure
    '        qryTemp.CommandTimeout = 60
    '        qryTemp.CommandText = "qryCBOManufacturer_Populate"

    '        'qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, 0))
    '        objConn.Open()

    '        rsTemp = qryTemp.ExecuteReader()

    '        dt = New DataTable("General")
    '        dt.Columns.Add("PK_autItemID", GetType(Integer))
    '        dt.Columns.Add("txtDescription", GetType(String))
    '        While rsTemp.Read()
    '            dr = dt.NewRow()
    '            dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
    '            dr("txtDescription") = rsTemp.Item("txtDescription")
    '            lngIndex = CInt(dr("PK_autItemID"))
    '            strDescription = dr("txtDescription")
    '            Item = New clsItemData(strDescription, lngIndex, strDescription)

    '            cmb.Items.Add(Item)
    '            dt.Rows.Add(dr)
    '            i += 1
    '        End While

    '        objConn.Close()

    '        Return cmb
    '    Catch ex As Exception
    '        HandleException(Me.Name, ex)
    '        Return cmb
    '    Finally
    '        Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
    '        Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
    '        Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
    '    End Try
    'End Function
    'Private Function GetDVGIntegerID(ByVal objDVGComboBox As DataGridViewComboBoxCell) As Integer
    '    Dim lngResult As Integer = 0
    '    Try
    '        If objDVGComboBox.Value > -1 Then
    '            If objDVGComboBox.Value.GetType() Is GetType(clsItemData) Then
    '                lngResult = CType(objDVGComboBox.Value, clsItemData).IntegerID
    '            End If
    '        End If
    '        Return lngResult
    '    Catch ex As Exception
    '        HandleException("modMain.GetIntegerID", ex)
    '        Return 0
    '    End Try
    'End Function
#End Region
End Class