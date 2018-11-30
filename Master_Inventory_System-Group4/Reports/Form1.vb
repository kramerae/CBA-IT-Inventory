Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class Form1

    Private Sub btnMethod1_Click(sender As Object, e As EventArgs)

        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As CrystalReport1 = Nothing


        objConn = New SqlConnection()
        objConn.ConnectionString = g_ConnectionString
        objConn.Open()

        sqlDa = New SqlDataAdapter("qryTest", objConn)
        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure
        dt = New DataTable()

        sqlDa.Fill(dt)
        objConn.Close()

        rpt = New CrystalReport1()
        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt

        rpt.Refresh()
        CrystalReportViewer1.Refresh()


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As CrystalReport1 = Nothing

        objConn = New SqlConnection()
        objConn.ConnectionString = g_ConnectionString
        objConn.Open()

        sqlDa = New SqlDataAdapter("qryTest", objConn)
        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure
        dt = New DataTable()

        sqlDa.Fill(dt)
        objConn.Close()

        rpt = New CrystalReport1()
        rpt.SetDataSource(dt)
        rpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rpt

        rpt.Refresh()
        CrystalReportViewer1.Refresh()
    End Sub
End Class