Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmHardwareDashboard




    Private Sub frmHardwareDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadComboBox(cmbAssigned, "qryCBOAssigned_Populate")
            LoadComboBox(cmbHardwareName, "qryCBOHardwareName_Populate")
            LoadComboBox(cmbHardwareType, "qryCBOHardwareType_Populate")
            LoadComboBox(cmbSerialNumber, "qryCBOSerialNumber_Populate")
            LoadComboBox(cmbServiceTag, "qryCBOtxtServiceTag_Populate")

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub frmHardwareDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            lblHardwareName.Top = 5
            lblHardwareName.Left = 15

            cmbHardwareName.Top = lblHardwareName.Bottom + 5
            cmbHardwareName.Left = lblHardwareName.Left
            cmbHardwareName.Width = 152

            grdHardware.Top = cmbHardwareName.Bottom + 5
            grdHardware.Left = cmbHardwareName.Left
            grdHardware.Width = Me.Width - grdHardware.Left - 15
            grdHardware.Height = Me.Height - grdHardware.Top - 40

            cmbHardwareType.Left = cmbHardwareName.Right + 5
            cmbHardwareType.Top = cmbHardwareName.Top
            cmbHardwareType.Width = 145

            lblType.Top = lblHardwareName.Top
            lblType.Left = cmbHardwareType.Left

            cmbManufacturer.Top = cmbHardwareType.Top
            cmbManufacturer.Left = cmbHardwareType.Right + 5
            cmbManufacturer.Width = 145

            lblManufacturer.Top = lblType.Top
            lblManufacturer.Left = cmbManufacturer.Left

            cmbModelName.Top = cmbManufacturer.Top
            cmbModelName.Left = cmbManufacturer.Right + 5
            cmbModelName.Width = 145

            lblModelName.Top = lblManufacturer.Top
            lblModelName.Left = cmbModelName.Left

            cmbModelNumber.Top = cmbModelName.Top
            cmbModelNumber.Left = cmbModelName.Right + 5
            cmbModelNumber.Width = 145

            lblModelNumber.Top = lblModelName.Top
            lblModelNumber.Left = cmbModelNumber.Left

            cmbSerialNumber.Top = cmbModelNumber.Top
            cmbSerialNumber.Left = cmbModelNumber.Right + 5
            cmbSerialNumber.Width = 145

            lblSerialNumber.Top = lblType.Top
            lblSerialNumber.Left = cmbSerialNumber.Left

            cmbServiceTag.Top = cmbSerialNumber.Top
            cmbServiceTag.Left = cmbSerialNumber.Right + 5
            cmbServiceTag.Width = 145

            lblServiceTag.Top = lblSerialNumber.Top
            lblServiceTag.Left = cmbServiceTag.Left

            cmbAssigned.Top = cmbServiceTag.Top
            cmbAssigned.Left = cmbServiceTag.Right + 5
            cmbAssigned.Width = 145

            lblAssigned.Top = lblServiceTag.Top
            lblAssigned.Left = cmbAssigned.Left

            btnSearch.Top = cmbAssigned.Top
            btnSearch.Left = cmbAssigned.Right + 5

        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            grdHardware_Format()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub grdHardware_Format()
        Try
            grdHardware.Columns.Clear()

            grdHardware_Populate()

            If grdHardware.ColumnCount > 0 Then
                grdHardware.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grdHardware.AllowUserToAddRows = False
                grdHardware.EditMode = False
                grdHardware.RowHeadersWidth = 5

                'Format the grid

                'Primary Key
                With grdHardware.Columns("PK_autHardwareID")
                    .Width = 50
                    .Visible = False
                End With

                'Hardware Name
                With grdHardware.Columns("txtHardwareName")
                    .HeaderText = "Hardware Name"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtHardwareTypeName")
                    .HeaderText = "Type"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtManufacturerName")
                    .HeaderText = "Manufacturer"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtModelName")
                    .HeaderText = "Model"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtModelNumber")
                    .HeaderText = "Model Number"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtSerialNumber")
                    .HeaderText = "Serial Number"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtServiceTag")
                    .HeaderText = "Service Tag"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtExpressServiceTag")
                    .HeaderText = "Exp. Service Tag"
                    .ReadOnly = True
                    .Width = 150
                    .Visible = False
                End With

                With grdHardware.Columns("txtIPAddress")
                    .HeaderText = "IP Address"
                    .ReadOnly = True
                    .Width = 150
                End With

                With grdHardware.Columns("txtAssign")
                    .HeaderText = "Assigned"
                    .ReadOnly = True
                    .Width = 150
                End With

            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub grdHardware_Populate()
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
            qryTemp.CommandText = "qryExcessInventory_Populate"
            qryTemp.Parameters.Add(CreateParameter("lngType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbHardwareType)))
            qryTemp.Parameters.Add(CreateParameter("txtSerialNumber", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbSerialNumber)))
            qryTemp.Parameters.Add(CreateParameter("txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbHardwareName)))
            qryTemp.Parameters.Add(CreateParameter("txtServiceTag", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbServiceTag)))
            qryTemp.Parameters.Add(CreateParameter("txtModelName", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbModelName)))
            qryTemp.Parameters.Add(CreateParameter("txtModelNumber", SqlDbType.VarChar, ParameterDirection.Input, GetStringID(cmbModelNumber)))
            qryTemp.Parameters.Add(CreateParameter("ysnAssigned", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbAssigned)))
            qryTemp.Parameters.Add(CreateParameter("lngManufacturer", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbManufacturer)))
            objConn.Open()

            rsTemp = qryTemp.ExecuteReader()
            dt.Columns.Add("PK_autHardwareID", GetType(Integer))
            dt.Columns.Add("txtHardwareName", GetType(String))
            dt.Columns.Add("txtHardwareTypeName", GetType(String))
            dt.Columns.Add("txtManufacturerName", GetType(String))
            dt.Columns.Add("txtModelName", GetType(String))
            dt.Columns.Add("txtModelNumber", GetType(String))
            dt.Columns.Add("txtSerialNumber", GetType(String))
            dt.Columns.Add("txtServiceTag", GetType(String))
            dt.Columns.Add("txtExpressServiceTag", GetType(String))
            dt.Columns.Add("txtAssign", GetType(String))
            dt.Columns.Add("txtIPAddress", GetType(String))
            While rsTemp.Read
                dr = dt.NewRow()
                dr("PK_autHardwareID") = rsTemp.Item("PK_autHardwareID")
                dr("txtHardwareName") = rsTemp.Item("txtHardwareName")
                dr("txtHardwareTypeName") = rsTemp.Item("txtHardwareTypeName")
                dr("txtManufacturerName") = rsTemp.Item("txtManufacturerName")
                dr("txtModelName") = rsTemp.Item("txtModelName")
                dr("txtModelNumber") = rsTemp.Item("txtModelNumber")
                dr("txtSerialNumber") = rsTemp.Item("txtSerialNumber")
                dr("txtServiceTag") = rsTemp.Item("txtServiceTag")
                dr("txtExpressServiceTag") = rsTemp.Item("txtExpressServiceTag")
                dr("txtIPAddress") = rsTemp.Item("txtIPAddress")
                dr("txtAssign") = rsTemp.Item("txtAssign")

                dt.Rows.Add(dr)

            End While

            grdHardware.DataSource = dt
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub grdHardware_CellDoubleClick(sender As Object, e As EventArgs) Handles grdHardware.CellDoubleClick
        Dim lngHardware As Integer = 0
        Dim row As DataGridViewRow = Nothing
        Try
            If grdHardware.Rows.Count > 0 Then
                row = grdHardware.SelectedRows(0)
                lngHardware = CInt(NZ(row.Cells("PK_autHardwareID").Value, 0))
                frmHardwareOpen(lngHardware)
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub frmHardwareOpen(ByVal lngHardware As Integer)
        Dim frmRefHardware As frmHardware2
        Try
            frmRefHardware = New frmHardware2()
            frmRefHardware.Name = "Hardware"
            frmRefHardware.Tag = "Hardware"
            frmRefHardware.Hardware = lngHardware
            frmMDIChildAdd(frmRefHardware)
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

    
    
End Class