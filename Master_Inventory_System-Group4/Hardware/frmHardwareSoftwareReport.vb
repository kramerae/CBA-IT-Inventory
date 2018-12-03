Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmHardwareSoftwareReport
    Private m_lngHardwareID As Integer

    Public Property Hardware() As Integer
        Get
            Hardware = m_lngHardwareID
        End Get
        Set(value As Integer)
            m_lngHardwareID = value

        End Set
    End Property

    Private Sub frmHardwareSoftwareReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As HardwareSoftwareReport = Nothing
        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString
            objConn.Open()

            sqlDa = New SqlDataAdapter("qryHardwareSoftwareReport_Populate", objConn)
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure
            sqlDa.SelectCommand.Parameters.AddWithValue("FK_lngHardware", m_lngHardwareID)

            dt = New DataTable()

            sqlDa.Fill(dt)
            objConn.Close()

            rpt = New HardwareSoftwareReport()
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