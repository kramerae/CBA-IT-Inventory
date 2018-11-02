Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class modMain
    'Public Shared g_ConnectionString As String = My.Settings.InventoryLaptop
    Public Shared g_ConnectionString As String = My.Settings.CBAInventoryConnectionString
    'Public Shared g_ConnectionString As String = My.Settings.Group4ConnectionStringHome

    Public Shared g_lngLoggedUser As Integer

#Region "NZ Functions"
    Public Shared Function NZ(ByVal inputValue As Object, ByVal valueIfNull As Integer)
        Try
            If Not IsDBNull(inputValue) Then
                If Not IsNumeric(inputValue) Then
                    Return valueIfNull
                Else
                    Return inputValue
                End If
            Else
                Return valueIfNull
            End If
        Catch ex As Exception
            MsgBox("NZ: " & ex.Message, MsgBoxStyle.Critical, "modMain")
            Return Nothing
        End Try
    End Function

    Public Shared Function NZ(ByVal inputValue As Object, ByVal valueIfNull As String)
        Try
            If Not IsDBNull(inputValue) Then
                Return inputValue
            Else
                Return valueIfNull
            End If
        Catch ex As Exception
            MsgBox("NZ: String " & ex.Message, MsgBoxStyle.Critical, "modMain")
            Return Nothing
        End Try
    End Function

    Public Shared Function NZ(ByVal inputValue As Object, ByVal valueIfNull As Boolean)
        Try
            If Not IsDBNull(inputValue) Then
                Return inputValue
            Else
                Return valueIfNull
            End If
        Catch ex As Exception
            MsgBox("NZ: Boolean " & ex.Message, MsgBoxStyle.Critical, "modMain")
            Return Nothing
        End Try
    End Function
    Public Shared Function NZ(ByVal inputValue As Object, ByVal valueIfNull As Decimal)
        Try
            If Not IsDBNull(inputValue) Then
                Return inputValue
            Else
                Return valueIfNull
            End If
        Catch ex As Exception
            MsgBox("NZ: Decimal " & ex.Message, MsgBoxStyle.Critical, "modMain")
            Return Nothing
        End Try
    End Function
#End Region

#Region "HandleException"
    Public Shared Sub HandleException(ByVal strFormName As String, ByVal except As Exception)
        Dim strStackTrace As String = ""
        Dim strMessage As String = ""
        Dim qryTemp As SqlCommand = Nothing
        Dim objConn As SqlConnection = Nothing
        Try
            strStackTrace = except.StackTrace.ToString
            strMessage = except.Message.ToString
            MsgBox(strMessage & vbCrLf & strStackTrace, MsgBoxStyle.Critical, strFormName)
            If strFormName <> "frmLogin" Then
                objConn = New SqlConnection()
                objConn.ConnectionString = g_ConnectionString

                qryTemp = New SqlCommand()
                qryTemp.Connection = objConn
                qryTemp.CommandType = CommandType.StoredProcedure
                qryTemp.CommandTimeout = 60
                qryTemp.CommandText = "qryErrorLog"

                qryTemp.Parameters.Add(CreateParameter("@txtFormName", SqlDbType.VarChar, ParameterDirection.Input, strFormName))
                qryTemp.Parameters.Add(CreateParameter("@txtErrorMessage", SqlDbType.VarChar, ParameterDirection.Input, strMessage))
                qryTemp.Parameters.Add(CreateParameter("@txtErrorStack", SqlDbType.VarChar, ParameterDirection.Input, strStackTrace))
                qryTemp.Parameters.Add(CreateParameter("@lngLoggedUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))

                objConn.Open()
                If objConn.State = ConnectionState.Open Then
                    qryTemp.ExecuteNonQuery()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Handle Exception")
        End Try
    End Sub
#End Region
#Region "SQL"
    Public Shared Function CreateParameter(ByVal ParamName As String, ByVal SQLType As SqlDbType, ByVal SQLDirection As ParameterDirection, ByVal Value As Object) As SqlClient.SqlParameter
        Dim para As SqlClient.SqlParameter
        Try
            If ParamName.Contains("@") Then
                ParamName = ParamName
            Else
                ParamName = "@" & ParamName
            End If
            para = New SqlClient.SqlParameter()
            para.ParameterName = ParamName
            para.SqlDbType = SQLType
            para.Direction = SQLDirection
            para.Value = Value

            Return para
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "modMain: CreateParameter")
            Return Nothing
        End Try
    End Function
#End Region
#Region "ComboBoxes"
    Public Shared Sub LoadComboBox(ByVal objComboBox As ComboBox, ByVal strQuery As String, Optional ByVal strParam As String = "-99")
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Dim Item As clsItemData
        Dim i As Integer = 0
        Try
            objComboBox.Items.Clear()
            'Department Auto Complete
            'cboSearchDepartment.AutoCompleteMode = AutoCompleteMode.Append
            'cboSearchDepartment.DropDownStyle = ComboBoxStyle.DropDown
            'cboSearchDepartment.AutoCompleteSource = AutoCompleteSource.ListItems

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = strQuery



            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable(objComboBox.Name.ToString)
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")
                Item = New clsItemData(strDescription, lngIndex, strDescription)

                objComboBox.Items.Insert(i, Item)
                dt.Rows.Add(dr)
                i += 1
            End While
            If objComboBox.Items.Count > 0 Then
                objComboBox.SelectedIndex = 0
            End If
            objConn.Close()
        Catch ex As Exception
            HandleException("modMain.LoadCombobox", ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Public Shared Sub LoadIPComboBox(ByVal objComboBox As ComboBox, ByVal strQuery As String, ByVal lngParam As Integer)
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Dim Item As clsItemData
        Dim i As Integer = 0
        Try
            objComboBox.Items.Clear()
            'Department Auto Complete
            'cboSearchDepartment.AutoCompleteMode = AutoCompleteMode.Append
            'cboSearchDepartment.DropDownStyle = ComboBoxStyle.DropDown
            'cboSearchDepartment.AutoCompleteSource = AutoCompleteSource.ListItems

            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = strQuery
            qryTemp.Parameters.Add(CreateParameter("@lngParam", SqlDbType.Int, ParameterDirection.Input, lngParam))



            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable(objComboBox.Name.ToString)
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")
                Item = New clsItemData(strDescription, lngIndex, strDescription)

                objComboBox.Items.Insert(i, Item)
                dt.Rows.Add(dr)
                i += 1
            End While
            If objComboBox.Items.Count > 0 Then
                objComboBox.SelectedIndex = 0
            End If
            objConn.Close()
        Catch ex As Exception
            HandleException("modMain.LoadCombobox", ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Public Shared Function LoadChildCombo(ByRef cmbCombo As ComboBox, strName As String, strTag As String) As ComboBox
        Dim Item As clsItemData
        Try
            Item = New clsItemData(strTag, 0, strName)
            cmbCombo.Items.Add(Item)

            Return cmbCombo
        Catch ex As Exception
            HandleException("modMain.LoadChildCombo", ex)
            Return cmbCombo
        End Try
    End Function
    Public Shared Sub LoadDataGridViewComboBoxColumn(ByVal objComboBox As DataGridViewComboBoxColumn, ByVal strQuery As String, Optional ByVal strParam As String = "-99")
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim lngIndex As Integer = Nothing
        Dim strDescription As String = Nothing
        Dim Item As clsItemData
        Dim i As Integer = 0
        Try
            objComboBox.Items.Clear()
            'Department Auto Complete
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = strQuery

            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()

            dt = New DataTable("General")
            dt.Columns.Add("PK_autItemID", GetType(Integer))
            dt.Columns.Add("txtDescription", GetType(String))
            While rsTemp.Read()
                dr = dt.NewRow()
                dr("PK_autItemID") = rsTemp.Item("PK_autItemID")
                dr("txtDescription") = rsTemp.Item("txtDescription")
                lngIndex = CInt(dr("PK_autItemID"))
                strDescription = dr("txtDescription")
                Item = New clsItemData(strDescription, lngIndex, strDescription)

                objComboBox.Items.Add(Item)
                dt.Rows.Add(dr)
                i += 1
            End While
            'objComboBox.DataSource = dt
            objConn.Close()
        Catch ex As Exception
            HandleException("modMain.LoadDataGridViewComboboxColumn", ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
    Public Shared Function GetStringID(ByVal objComboBox As ComboBox) As String
        Dim strResult As String = ""
        Try
            If objComboBox.SelectedIndex > 0 Then
                If TypeOf (objComboBox.SelectedItem) Is clsItemData Then
                    strResult = CType(objComboBox.SelectedItem, clsItemData).StringID
                End If
            End If
            Return strResult
        Catch ex As Exception
            HandleException("modMain.GetStringID", ex)
            Return ""
        End Try
    End Function
    Public Shared Function GetIntegerID(ByVal objComboBox As ComboBox) As Integer
        Dim lngResult As Integer = 0
        Try
            If objComboBox.SelectedIndex > -1 Then
                If objComboBox.SelectedItem.GetType() Is GetType(clsItemData) Then
                    lngResult = CType(objComboBox.SelectedItem, clsItemData).IntegerID
                End If
            End If
            Return lngResult
        Catch ex As Exception
            HandleException("modMain.GetIntegerID", ex)
            Return 0
        End Try
    End Function
    Public Shared Function SetIntegerID(objComboBox As ComboBox, lngID As Integer) As ComboBox
        Dim i As Integer = 0
        Try
            For Each Item As clsItemData In objComboBox.Items
                If lngID = Item.IntegerID Then
                    objComboBox.SelectedIndex = i
                    Exit For
                Else
                    i = i + 1
                End If
            Next
            Return objComboBox
        Catch ex As Exception
            HandleException("modMain", ex)
            Return objComboBox
        End Try
    End Function
    Public Shared Function SetStringID(objComboBox As ComboBox, strID As String) As ComboBox
        Dim i As Integer = 0
        Try
            For Each Item As clsItemData In objComboBox.Items
                If strID = Item.StringID Then
                    objComboBox.SelectedIndex = i
                    Exit For
                Else
                    i = i + 1
                End If

            Next
            Return objComboBox
        Catch ex As Exception
            HandleException("modMain.SetStringID", ex)
            Return objComboBox
        End Try
    End Function
#End Region
#Region "Utilities"
    Public Shared Function StripPhone(ByVal strPhone As String) As String
        Dim strStripPhone As String = ""

        strStripPhone = strPhone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "")

        Return strStripPhone
    End Function
    Public Shared Function FormatPhone(ByVal strPhone As String) As String
        If strPhone.Trim.Length > 0 Then
            Dim strFormatPhone As String = ""

            strPhone = StripPhone(strPhone)

            strFormatPhone = Convert.ToInt64(strPhone).ToString("(000) 000-0000")

            Return strFormatPhone
        Else
            Return strPhone
        End If
    End Function
#End Region
End Class
