Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmUnassignedDevices
    Private Sub frmUnassignedDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As UnassignedReport = Nothing

        objConn = New SqlConnection()
        objConn.ConnectionString = g_ConnectionString
        objConn.Open()

        sqlDa = New SqlDataAdapter("qryExcessInventory_Populate", objConn)
        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure
        sqlDa.SelectCommand.Parameters.AddWithValue("lngtype", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("txtSerialNumber", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("txtHardwareName", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("txtServiceTag", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("txtModelName", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("txtModelNumber", "")
        sqlDa.SelectCommand.Parameters.AddWithValue("ysnAssigned", "0")
        sqlDa.SelectCommand.Parameters.AddWithValue("lngManufacturer", "")

        dt = New DataTable()

        sqlDa.Fill(dt)
        objConn.Close()

        rpt = New UnassignedReport()
        rpt.SetDataSource(dt)
        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt

        rpt.Refresh()
        CrystalReportViewer1.Refresh()
    End Sub
End Class