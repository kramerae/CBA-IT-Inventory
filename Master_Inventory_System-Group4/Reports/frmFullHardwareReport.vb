Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmFullHardwareReport
    Private Sub frmFullHardwareReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As HardwareFullReport = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString
            objConn.Open()

            sqlDa = New SqlDataAdapter("qryHardwareFullReport_Populate", objConn)
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure

            dt = New DataTable()

            sqlDa.Fill(dt)
            objConn.Close()

            rpt = New HardwareFullReport()
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