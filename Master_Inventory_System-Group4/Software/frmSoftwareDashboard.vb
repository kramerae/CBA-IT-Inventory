Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient
Public Class frmSoftwareDashboard
    Private Sub frmSoftwareDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadComboBox(cmbSoftwareName, "qryCBOSoftwareName_Populate")
            LoadComboBox(cmbSoftwareType, "qryCBOSoftwareType_Populate")
            LoadComboBox(cmbSoftwareVersion, "qryCBOSoftwareVersion_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub frmHardwareDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            lblSoftwareName.Top = 5
            lblSoftwareName.Left = 15

            cmbSoftwareName.Top = lblSoftwareName.Bottom + 5
            cmbSoftwareName.Left = lblSoftwareName.Left
            cmbSoftwareName.Width = 152

            grdSoftware.Top = cmbSoftwareName.Bottom + 5
            grdSoftware.Left = cmbSoftwareName.Left
            grdSoftware.Width = Me.Width - grdSoftware.Left - 15
            grdSoftware.Height = Me.Height - grdSoftware.Top - 40

            cmbSoftwareType.Left = cmbSoftwareName.Right + 5
            cmbSoftwareType.Top = cmbSoftwareName.Top
            cmbSoftwareType.Width = 145

            lblSoftwareType.Top = lblSoftwareName.Top
            lblSoftwareType.Left = cmbSoftwareType.Left

            cmbSoftwareVersion.Left = cmbSoftwareType.Right + 5
            cmbSoftwareVersion.Top = cmbSoftwareType.Top
            cmbSoftwareVersion.Width = 145

            lblSoftwareVersion.Top = lblSoftwareType.Top
            lblSoftwareVersion.Left = cmbSoftwareVersion.Left

            btnSearch.Top = cmbSoftwareVersion.Top
            btnSearch.Left = cmbSoftwareVersion.Right + 5

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            grdSoftware_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub grdSoftware_Format()
        Try
            grdSoftware.Columns.Clear()

            grdSoftware_Populate()

            If grdSoftware.ColumnCount > 0 Then
                grdSoftware.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grdSoftware.AllowUserToAddRows = False
                grdSoftware.EditMode = False
                grdSoftware.RowHeadersWidth = 5

                'Format the grid

                'Primary Key
                With grdSoftware.Columns("PK_autSoftwareID")
                    .Width = 50
                    .Visible = False
                End With

                'Hardware Name
                With grdSoftware.Columns("txtSoftwareName")
                    .HeaderText = "Software Name"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdSoftware.Columns("txtSoftwareVersion")
                    .HeaderText = "Version"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdSoftware.Columns("txtSoftwareType")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 150
                End With


            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub grdSoftware_Populate()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim rsTemp As SqlDataReader = Nothing

        Try
            dt = New DataTable
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString

            qryTemp = New SqlCommand()
            qryTemp.Connection = objConn
            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qrySoftwareDashboard_Populate"
            qryTemp.Parameters.Add(CreateParameter("lngType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbSoftwareType)))
            qryTemp.Parameters.Add(CreateParameter("txtSoftwareName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSoftwareName)))
            qryTemp.Parameters.Add(CreateParameter("txtSoftwareVersion", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSoftwareVersion)))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()
            dt.Columns.Add("PK_autSoftwareID", GetType(Integer))
            dt.Columns.Add("txtSoftwareName", GetType(String))
            dt.Columns.Add("txtSoftwareVersion", GetType(String))
            dt.Columns.Add("txtSoftwareType", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autSoftwareID") = rsTemp.Item("PK_autSoftwareID")
                dr("txtSoftwareName") = rsTemp.Item("txtSoftwareName")
                dr("txtSoftwareVersion") = rsTemp.Item("txtSofwareVersion")
                dr("txtSoftwareType") = rsTemp.Item("txtSoftwareType")
                dt.Rows.Add(dr)

            End While

            grdSoftware.DataSource = dt
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
End Class