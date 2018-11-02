Imports System.Data
Imports System.Data.SqlClient
Imports Master_Inventory_System_Group4.modMain


Public Class frmHardwareParts

#Region "Declarations"
    Private dtPartType As DataTable
    Private lngPartType As Integer = 0
    Dim strCategory1Header As String = ""
    Dim strCategory2Header As String = ""
    Dim strCategory3Header As String = ""
    Dim strCategory4Header As String = ""
    Dim strCategory5Header As String = ""
    Dim strCategory6Header As String = ""
    Dim strCategory7Header As String = ""
#End Region
#Region "Properties"

#End Region
#Region "Form Events"
    Private Sub frmHardwareParts_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBox(cmbHardwarePartName, "CMBqyrGetAllActiveHardwareConfig")
        txtHardwarePartName.Text = GetStringID(cmbHardwarePartName)
        txtHardwarePartName.Tag = GetIntegerID(cmbHardwarePartName)
        GetPartType()
        BuildComponents()
    End Sub

    Private Sub frmHardwareParts_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Panel1.Height = Me.Height - 100
            Panel1.Width = Me.Width - 50
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Control Events"

#End Region
#Region "Button Events"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            SaveBuild()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Utilities"
    Private Sub GetPartType()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Try
            dtPartType = New DataTable()

            objConn = New SqlConnection()
            qryTemp = New SqlCommand()

            objConn.ConnectionString = g_ConnectionString

            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandText = "qryGetAllActivePartType"
            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            dtPartType.Load(rsTemp)
            lngPartType = dtPartType.Rows.Count


        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Private Sub BuildComponents()
        Dim lngTop As Integer = 10
        Try
            If lngPartType > 0 Then
                For Each dr As DataRow In dtPartType.Rows
                    Dim lbl As New Label()
                    Dim grd As New DataGridView()

                    lbl.Top = lngTop
                    lbl.Left = 7
                    lbl.Text = dr.Item("txtDescription").ToString()

                    lbl.Name = "lbl" & dr.Item("txtDescription").ToString()
                    grd.Name = "grd" & dr.Item("txtDescription").ToString()
                    grd.Tag = dr.Item("PK_autID")

                    Panel1.Controls.Add(lbl)
                    Panel1.Controls.Add(grd)

                    FormatGrid(grd, dr.Item("PK_autID"))
                   
                    grd.Top = lbl.Bottom + 5
                    grd.Left = 5
                    If grd.RowCount > 8 Then
                        grd.Height = 90
                    Else
                        grd.Height = grd.RowCount * 8 + 10
                    End If
                    grd.Height = 100
                    grd.Width = Panel1.Width - 40

                    lngTop = grd.Bottom + 10

                Next
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#Region "Grid"
    Public Sub FormatGrid(ByRef grid As DataGridView, ByVal lngType As Integer)
        Dim dt As New DataTable()
        Try
            grid.Columns.Clear()

            dt = PopulateGrid(lngType)
            grid.DataSource = dt



            GetHeaders(lngType)

            If dt.Columns.Count > 0 Then
                grid.AllowUserToAddRows = False
                grid.AllowUserToDeleteRows = False
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                'Primary Key
                With grid.Columns("PK_autID")
                    .Width = 0
                    .Visible = False
                End With

                'Assign checkbox column
                With grid.Columns("Assign")
                    .CellTemplate = New DataGridViewCheckBoxCell()
                    .HeaderText = "Assign"
                    .ReadOnly = False
                    .Width = 50
                End With

                With grid.Columns("PK_autManufacturerID")
                    .Width = 0
                    .Visible = False

                End With

                With grid.Columns("txtManufacturer")
                    .HeaderText = "Manufacturer"
                    .ReadOnly = True
                    .Width = 150

                End With

                With grid.Columns("txtCategory1")
                    .HeaderText = strCategory1Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory1Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory2")
                    .HeaderText = strCategory2Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory2Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory3")
                    .HeaderText = strCategory3Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory3Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory4")
                    .HeaderText = strCategory4Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory4Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory5")
                    .HeaderText = strCategory5Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory5Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory6")
                    .HeaderText = strCategory6Header
                    .ReadOnly = True
                    .Width = 150
                    If strCategory6Header <> "" Then
                        .Visible = True
                    Else
                        .Visible = False
                    End If
                End With

                With grid.Columns("txtCategory7")
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
    Public Function PopulateGrid(ByVal lngType As Integer) As DataTable
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

            qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, lngType))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable()
            dt.Columns.Add("PK_autID", GetType(Integer))
            dt.Columns.Add("Assign", GetType(Boolean))
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
                dr("Assign") = False
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
    Public Sub GetHeaders(ByVal lngType As Integer)
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            strCategory1Header = ""
            strCategory2Header = ""
            strCategory3Header = ""
            strCategory4Header = ""
            strCategory5Header = ""
            strCategory6Header = ""
            strCategory7Header = ""
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryPartsCategoryGetHeaders"

            qryTemp.Parameters.Add(CreateParameter("@FK_lngPartType", SqlDbType.Int, ParameterDirection.Input, lngType))
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
    Public Sub SaveBuild()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim lngHardwareConfig As Integer
        Dim grdXML As String = ""
        Try
            objConn = New SqlConnection()
            qryTemp = New SqlCommand()
            'Update the HardwareConfig Name and ID
            objConn.ConnectionString = g_ConnectionString
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandText = "qryUpdateHardwareConfigName"
            qryTemp.Parameters.Add(CreateParameter("@FK_lngHardwareConfigID", SqlDbType.Int, ParameterDirection.Input, txtHardwarePartName.Tag))
            qryTemp.Parameters.Add(CreateParameter("@txtHardwareConfigName", SqlDbType.VarChar, ParameterDirection.Input, txtHardwarePartName.Text))
            qryTemp.Parameters.Add(CreateParameter("@FK_lngUserID", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            While rsTemp.Read
                lngHardwareConfig = rsTemp.Item("HardwareConfigID")
            End While

            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try

            For Each grd As DataGridView In Panel1.Controls
                If grd.Rows.Count > 0 Then
                    grdXML = "<Parts>"
                    For Each row As DataGridViewRow In grd.Rows
                        grdXML = grdXML & "<Part><PK_autID>" & row.Cells("PK_autID").ToString() & "</PK_autID>"
                        grdXML = grdXML & "<ysnAssign>" & row.Cells("ysnAssign").ToString() & "</ysnAssign></Part>"
                    Next
                    grdXML = grdXML & "</Parts>"

                    objConn = New SqlConnection()
                    qryTemp = New SqlCommand()

                    objConn.ConnectionString = g_ConnectionString
                    qryTemp.Connection = objConn
                    qryTemp.CommandType = CommandType.StoredProcedure
                    qryTemp.CommandText = "qryUpdateHardwarePartsConfigByHardwareConfigID"
                    qryTemp.Parameters.Add(CreateParameter("@FK_lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
                    qryTemp.Parameters.Add(CreateParameter("@grdXML", SqlDbType.VarChar, ParameterDirection.Input, grdXML))
                    qryTemp.Parameters.Add(CreateParameter("@FK_lngHardwareConfig", SqlDbType.Int, ParameterDirection.Input, lngHardwareConfig))
                    qryTemp.Parameters.Add(CreateParameter("@FK_PartType", SqlDbType.Int, ParameterDirection.Input, grd.Tag))

                    qryTemp.ExecuteNonQuery()

                    Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
                    Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
                    Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try

                End If
            Next
        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rstemp.Close() : rstemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region
#End Region
End Class