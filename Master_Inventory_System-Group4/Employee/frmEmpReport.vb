Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmEmpReport
    Private m_lngEmployeeID As Integer

#Region "Properties"
    Public Property Employee() As Integer
        Get
            Employee = m_lngEmployeeID
        End Get
        Set(value As Integer)
            m_lngEmployeeID = value

        End Set
    End Property
#End Region
    Private Sub frmEmpReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Dim rpt As EmployeeReport = Nothing

        Try
            objConn = New SqlConnection()
            objConn.ConnectionString = g_ConnectionString
            objConn.Open()

            sqlDa = New SqlDataAdapter("qryEmployeeReport_Populate", objConn)
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure
            sqlDa.SelectCommand.Parameters.AddWithValue("FK_lngEmployee", m_lngEmployeeID)

            dt = New DataTable()

            sqlDa.Fill(dt)
            objConn.Close()

            rpt = New EmployeeReport()
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