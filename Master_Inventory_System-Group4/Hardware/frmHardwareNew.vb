﻿Imports Master_Inventory_System_Group4.modMain
Imports Master_Inventory_System_Group4.frmMain
Imports System.Data.SqlClient

Public Class frmHardwareNew
#Region "Declarations"
    Private m_lngHardwareID As Integer
    Private m_bolLoading As Boolean = False
    Private m_lngEmployeeID As Integer
#End Region

#Region "Properties"
    Public Property Hardware() As Integer
        Get
            Hardware = m_lngHardwareID
        End Get
        Set(value As Integer)
            m_lngHardwareID = value

        End Set
    End Property
#End Region

#Region "Form Events"

    Private Sub frmHardwareNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            m_bolLoading = True

            cmbHardwareType_Load()
            cmbIPAddress_Load()
            cmbManufacturer_Load()
            cmbOSType_Load()

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            m_bolLoading = False
        End Try
    End Sub
#End Region

#Region "Control Events"

#End Region

#Region "Button Events"
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Hardware_Save()
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub

#End Region

#Region "Populate/Save/Validate"
    Private Sub Hardware_Save()
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim para As SqlParameter = Nothing
        Dim lngAD As Integer = 0
        Dim ysnAssign As Boolean = False
        Try
            objConn = New SqlConnection()
            qryTemp = New SqlCommand()

            objConn.ConnectionString = g_ConnectionString

            qryTemp.CommandType = CommandType.StoredProcedure
            qryTemp.CommandTimeout = 60
            qryTemp.CommandText = "qryAddHardware"
            qryTemp.Connection = objConn

            qryTemp.Parameters.Add(CreateParameter("@FK_lngEmployee", SqlDbType.Int, ParameterDirection.Input, m_lngEmployeeID))
            qryTemp.Parameters.Add(CreateParameter("@lngHardwareType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbHardwareType)))
            qryTemp.Parameters.Add(CreateParameter("@lngManufacturer", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbManufacturer)))
            qryTemp.Parameters.Add(CreateParameter("@txtServiceTag", SqlDbType.VarChar, ParameterDirection.Input, txtServiceTag.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtExpServiceTag", SqlDbType.VarChar, ParameterDirection.Input, txtExprServiceTag.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtModelNumber", SqlDbType.VarChar, ParameterDirection.Input, txtModelNumber.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtModelName", SqlDbType.VarChar, ParameterDirection.Input, txtModelName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtSerialNumber", SqlDbType.VarChar, ParameterDirection.Input, txtSerialNum.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtHardwareName", SqlDbType.VarChar, ParameterDirection.Input, txtDeviceName.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMACAddress", SqlDbType.VarChar, ParameterDirection.Input, txtMACAddress.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngIPAddress", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbIPAddress)))
            qryTemp.Parameters.Add(CreateParameter("@txtBarcode", SqlDbType.VarChar, ParameterDirection.Input, txtBarcode.Text))
            qryTemp.Parameters.Add(CreateParameter("@lngOSType", SqlDbType.Int, ParameterDirection.Input, GetIntegerID(cmbOS)))
            qryTemp.Parameters.Add(CreateParameter("@lngUser", SqlDbType.Int, ParameterDirection.Input, g_lngLoggedUser))
            If txtPurchaseDate.Text IsNot "" Then
                Dim dtpurchase As DateTime = CType(txtPurchaseDate.Text, Date)
                qryTemp.Parameters.Add(CreateParameter("@dtiPurchase", SqlDbType.Date, ParameterDirection.Input, dtpurchase))
            Else
                qryTemp.Parameters.Add(CreateParameter("@dtiPurchase", SqlDbType.Date, ParameterDirection.Input, DBNull.Value))
            End If
            If txtWarrantyExpDate.Text IsNot "" Then
                Dim dtwarranty As DateTime = CType(txtWarrantyExpDate.Text, Date)
                qryTemp.Parameters.Add(CreateParameter("@dtiWarranty", SqlDbType.Date, ParameterDirection.Input, dtwarranty))
            Else
                qryTemp.Parameters.Add(CreateParameter("@dtiWarranty", SqlDbType.Date, ParameterDirection.Input, DBNull.Value))
            End If
            If txtCurCost.Text IsNot "" Then
                Dim cost As Decimal
                Decimal.TryParse(txtCurCost.Text, cost)
                qryTemp.Parameters.Add(CreateParameter("@monCurCost", SqlDbType.Money, ParameterDirection.Input, cost))
            Else
                qryTemp.Parameters.Add(CreateParameter("@monCurCost", SqlDbType.Money, ParameterDirection.Input, DBNull.Value))
            End If
            qryTemp.Parameters.Add(CreateParameter("@txtCPU", SqlDbType.VarChar, ParameterDirection.Input, txtCPU.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMemory", SqlDbType.VarChar, ParameterDirection.Input, txtMemory.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtHDD", SqlDbType.VarChar, ParameterDirection.Input, txtHDD.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtResolution", SqlDbType.VarChar, ParameterDirection.Input, txtResolution.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtAspectRatio", SqlDbType.VarChar, ParameterDirection.Input, txtAspectRatio.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtMount", SqlDbType.VarChar, ParameterDirection.Input, txtMount.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtInput", SqlDbType.VarChar, ParameterDirection.Input, txtInput.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtPrinterType", SqlDbType.VarChar, ParameterDirection.Input, txtPrinterType.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtBlackInk", SqlDbType.VarChar, ParameterDirection.Input, txtBlackInk.Text))
            qryTemp.Parameters.Add(CreateParameter("@txtColorInk", SqlDbType.VarChar, ParameterDirection.Input, txtColorInk.Text))

            objConn.Open()
            rsTemp = qryTemp.ExecuteReader()

            MsgBox("Hardware added successfully.", MsgBoxStyle.OkOnly, "System Message")

        Catch ex As Exception
            HandleException(Me.Name, ex)
        Finally
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : qryTemp.Dispose() : qryTemp = Nothing : Catch : End Try
            Try : If objConn.State <> System.Data.ConnectionState.Closed Then : objConn.Close() : End If : objConn = Nothing : Catch : End Try
        End Try
    End Sub
#End Region

#Region "Utility"
    Private Sub cmbIPAddress_Load()
        Try
            LoadComboBox(cmbIPAddress, "qryCBOIPAddress_Load")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbManufacturer_Load()
        Try
            LoadComboBox(cmbManufacturer, "qryCBOManufacturer_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbOSType_Load()
        Try
            LoadComboBox(cmbOS, "qryCBOOSType_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
    Private Sub cmbHardwareType_Load()
        Try
            LoadComboBox(cmbHardwareType, "qryCBOHardwareType_Populate")
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub



#End Region





End Class