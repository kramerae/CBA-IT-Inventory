Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmSoftwareReport
    Private Sub frmSoftwareReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As SoftwareReport = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString
            objConn.Open()

            sqlDa = New SqlDataAdapter("qrySoftwareReport_Populate", objConn)
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure

            dt = New DataTable()

            sqlDa.Fill(dt)
            objConn.Close()

            rpt = New SoftwareReport()
            rpt.SetDataSource(dt)
            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt

            rpt.Refresh()
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
End Class