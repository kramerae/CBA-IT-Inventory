Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Master_Inventory_System_Group4.Main

Public Class Reporting

    Private m_lngHardware As Integer = 0

    Public Property HardwareID As Integer
        Get
            Return m_lngHardware
        End Get
        Set(value As Integer)
            m_lngHardware = value
        End Set
    End Property
    Public Sub showReport()

        'Dim cryRtp As ReportDocument
        'Dim param As ParameterField
        'Dim discreteVal As New ParameterDiscreteValue
        'Dim paramFields As New ParameterFields
        'Try
        '    cryRtp = New rptHardwareChecklist
        '    'CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        '    CrystalReportViewer1.ReportSource = cryRtp

        '    param = New ParameterField
        '    param.ParameterFieldName = "@test"
        '    discreteVal.Value = m_lngHardware
        '    param.CurrentValues.Add(discreteVal)
        '    paramFields.Add(param)

        '    'CrystalReportViewer1.ParameterFieldInfo.Clear()
        '    'cryRtp = New rptHardwareChecklist1
        '    'cryRtp.Load("rptHardwareChecklist1")
        '    'cryRtp.ParameterFields.Add(paramFields)
        '    CrystalReportViewer1.ParameterFieldInfo = paramFields
        '    CrystalReportViewer1.Show()
        '    'CrystalReportViewer1.Refresh()

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Report Error")
        'End Try
    End Sub

    Private Sub Reporting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call showReport()
    End Sub
End Class