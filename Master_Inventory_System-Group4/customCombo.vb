Imports Master_Inventory_System_Group4.modMain
Imports System.Data
Imports System.Data.DataColumnCollection
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO.Directory
Public Class customCombo
    Inherits System.Windows.Forms.ComboBox
#Region "Declarations"
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_KEYUP As Integer = &H101
    Private Const VK_F3 As Integer = 114
    Private Const VK_CONTROL As Integer = 17

    Public Event validatedata(ByVal intclickedindex As Integer, ByRef ysnReturn As Boolean)
    Public Event searchindex(ByVal intselectedindex As Integer)

    Private m_bolValidate As Boolean
    Private m_bolApplyPermissions As Boolean
    Private m_bolPopupEnabled As Boolean
    Private m_bolAutoCompleteEnabled As Boolean
    Private m_lngNormalColor As System.Drawing.Color
    Private m_lngAlteredColor As System.Drawing.Color
    Private m_bolFreeText As Boolean

    Private PressedKey As Boolean = False
    '
    '   Our DropDownStyle to manage the DropDownList with Autocomplete
    '
    Private Enum CustomDropDownStyle
        [DropDown]
        [DropDownList]
    End Enum
#End Region
#Region "Properties"
    '
    '   Set the parameter that determines the default background color of the control when unchanged.
    '
    Public Property NormalColor() As System.Drawing.Color
        Get
            NormalColor = m_lngNormalColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            m_lngNormalColor = Value
        End Set
    End Property
    '
    '   Set the parameter that determines the default background color of the control when changed.
    '
    Public Property AlteredColor() As System.Drawing.Color
        Get
            AlteredColor = m_lngAlteredColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            m_lngAlteredColor = Value
        End Set
    End Property
    '
    '   Set the parameter that determines if a popup lookup form is enabled for the control.
    '
    Public Property PopupEnabled() As Boolean
        Get
            PopupEnabled = m_bolPopupEnabled
        End Get
        Set(ByVal Value As Boolean)
            m_bolPopupEnabled = Value
        End Set
    End Property
    '
    '   Set the parameter that determines if a popup lookup form is enabled for the control.
    '
    Public Property AutoCompleteEnabled() As Boolean
        Get
            AutoCompleteEnabled = m_bolAutoCompleteEnabled
        End Get
        Set(ByVal Value As Boolean)
            m_bolAutoCompleteEnabled = Value
        End Set
    End Property

    Public Property ValidateControl() As Boolean
        Get
            ValidateControl = m_bolValidate
        End Get
        Set(ByVal Value As Boolean)
            m_bolValidate = Value
        End Set
    End Property

    Public Property ApplyPermissions() As Boolean
        Get
            ApplyPermissions = m_bolApplyPermissions
        End Get
        Set(ByVal Value As Boolean)
            m_bolApplyPermissions = Value
        End Set
    End Property

    Public Property FreeText() As Boolean
        Get
            FreeText = m_bolFreeText
        End Get
        Set(ByVal Value As Boolean)
            m_bolFreeText = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Sub New()
        '
        '   By default a popup is not enabled for the control.
        '
        m_bolPopupEnabled = False
        '
        '   By default autocomplete is not enabled for the control.
        '
        m_bolAutoCompleteEnabled = False
        '
        '   By default validate all controls of this type.
        '
        m_bolValidate = True
        '
        '   By default validate all controls of this type.
        '
        m_bolApplyPermissions = True
        '
        '   Set default color behavior for control.
        '
        m_lngNormalColor = System.Drawing.Color.White
        m_lngAlteredColor = System.Drawing.Color.Cyan
        '
        '   By default FreeText is not enabled.
        '
        m_bolFreeText = False
        '
        '   Create a blank entry
        '
        'Me.Items.Add(New clsItemData("", 0, "", 0.0))
        Me.Items.Add("")
    End Sub 'New 

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Dim index As Integer
        Dim ysnReturn As Boolean

        Try
            '
            '   By default pass the message.
            '
            ysnReturn = True
            If m.Msg = WM_LBUTTONDOWN Then
                RaiseEvent validatedata(index, ysnReturn)
            End If
            '
            '   If the data could be validated, then pass on message.
            '
            'If ysnReturn = True Then
            '    '
            '    '   Check to see if the user clicked on the F3 key.
            '    '
            '    If m.Msg = WM_KEYUP Then
            '        If m.WParam.ToInt32 = VK_F3 Then
            '            Dim frmRefCustomComboLookup As frmCustomComboLookup

            '            frmRefCustomComboLookup = New frmCustomComboLookup
            '            '
            '            '   Pass the unbound recordsource.
            '            '
            '            frmRefCustomComboLookup.ComboWidth = MyBase.Width
            '            frmRefCustomComboLookup.ItemData = MyBase.Items

            '            If frmRefCustomComboLookup.ShowDialog = DialogResult.OK Then
            '                RaiseEvent searchindex(frmRefCustomComboLookup.TSelectedIndex)
            '                ysnReturn = False
            '            End If
            '        ElseIf m.WParam.ToInt32 = VK_CONTROL Then
            '            System.Windows.Forms.Clipboard.SetDataObject(NZ(MyBase.SelectedItem.stringid, MyBase.SelectedItem.ToString), True)
            '        End If
            '    End If
            '    MyBase.WndProc(m)
            'End If

        Catch ex As Exception
            If InStr(Err.Description, "Index was out of range") > 0 Then

            Else
                Beep()
                MsgBox("customCombo\WndProc: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
            End If
        End Try

    End Sub

    Private Sub clsCustomCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SelectedIndexChanged
        Try
            '
            '   Use different validation for dropdown combos versus dropdown lists.
            '
            If sender.DropDownStyle = ComboBoxStyle.DropDownList Or m_bolAutoCompleteEnabled = True Then
                If sender.SelectedIndex = CInt(NZ(sender.Tag, "0")) Then
                    sender.BackColor = m_lngNormalColor
                Else
                    sender.BackColor = m_lngAlteredColor
                End If
            End If

        Catch ex As Exception
            Beep()
            MsgBox("customCombo_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
        End Try
    End Sub

    'Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'AUTOCOMPLETE: we have to know when a key has been really pressed
    '    'If m_bolAutoCompleteEnabled = True Then
    '    If Me.DropDownStyle = CustomDropDownStyle.DropDown OrElse m_bolFreeText Then
    '        PressedKey = True
    '    Else
    '        'ReadOnly AutoComplete Management
    '        Dim sTypedText As String
    '        Dim iFoundIndex As Integer
    '        Dim currentText As String
    '        Dim Start, selLength As Integer

    '        If Asc(e.KeyChar) = 8 Then
    '            If Me.SelectedText = Me.Text Then
    '                PressedKey = True
    '                Exit Sub
    '            End If
    '        End If
    '        If Me.DroppedDown Then
    '            Me.DroppedDown = False
    '        End If
    '        If Me.SelectionLength > 0 Then
    '            Start = Me.SelectionStart
    '            selLength = Me.SelectionLength

    '            'This is equivalent to Me.Text, but sometimes
    '            ' using Me.Text it doesn't work
    '            currentText = Me.AccessibilityObject.Value

    '            Try
    '                currentText = currentText.Remove(Start, selLength)
    '            Catch
    '                '
    '                '   the accessibility object does not work with dropdown lists that
    '                '   include &, so use the me.text instead.
    '                '
    '                currentText = Me.Text
    '                currentText = currentText.Remove(Start, selLength)
    '            End Try

    '            currentText = currentText.Insert(Start, e.KeyChar)
    '            sTypedText = currentText
    '        Else
    '            Start = Me.SelectionStart
    '            sTypedText = Me.Text.Insert(Start, e.KeyChar)
    '        End If
    '        iFoundIndex = Me.FindString(sTypedText)
    '        If (iFoundIndex >= 0) Then
    '            PressedKey = True
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    '    'End If
    'End Sub

    'Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
    '    'Selecting the item which text is showed in the text area of the ComboBox
    '    Dim iFoundIndex As Integer
    '    Try
    '        If Not m_bolFreeText Then
    '            ' If m_bolAutoCompleteEnabled = True Then
    '            'The Me.AccessibilityObject.Value is used instead of Me.Text to manage
    '            'the event when you write in the combobox text and the DropDownList
    '            'is open. In this case, if you click outside the combo, Me.Text mantains 
    '            'the old value and not the current one
    '            Try
    '                iFoundIndex = Me.FindStringExact(Me.AccessibilityObject.Value)
    '            Catch
    '                iFoundIndex = -1
    '            End Try
    '            '
    '            '   the accessibility object does not work with dropdown lists that
    '            '   include &, so use the me.text instead.
    '            '
    '            If iFoundIndex < 0 Then
    '                iFoundIndex = Me.FindStringExact(Me.Text)
    '            End If

    '            If iFoundIndex >= 0 Then
    '                Me.SelectedIndex = iFoundIndex
    '            Else
    '                iFoundIndex = Me.FindString(Me.Text)
    '                If iFoundIndex >= 0 Then
    '                    Me.SelectedIndex = iFoundIndex
    '                Else
    '                    MsgBox("Selection could not be found.  Defaulting to first entry in the list", MsgBoxStyle.Information, "System Message")
    '                    Me.SelectedIndex = 0
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Beep()
    '        MsgBox("customCombo_OnLeave: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
    '    End Try
    'End Sub

    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        'AUTOCOMPLETING

        'WARNING: With VB.Net 2003 there is a strange behaviour. 
        'This event is raised not just when any key is pressed
        'but also when the Me.Text property changes. Particularly, 
        'it happens when you write in a fast way (for example you
        'you press 2 keys and the event is raised 3 times). 
        'To manage this we have added a boolean variable PressedKey that
        'is set to true in the OnKeyPress Event

        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'If m_bolAutoCompleteEnabled = True Then
        If PressedKey Then
            If Not m_bolFreeText Then
                'Ignoring alphanumeric chars
                Select Case e.KeyCode
                    Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down, Keys.End, Keys.Home
                        Return
                End Select

                'Get the Typed Text and Find it in the list
                sTypedText = Me.Text
                iFoundIndex = Me.FindString(sTypedText)

                'If we found the Typed Text in the list then Autocomplete
                If iFoundIndex >= 0 Then

                    'Get the Item from the list (Return Type depends if Datasource was bound 
                    ' or List Created)
                    oFoundItem = Me.Items(iFoundIndex)

                    'Use the ListControl.GetItemText to resolve the Name in case the Combo 
                    ' was Data bound
                    sFoundText = Me.GetItemText(oFoundItem)

                    'Append then found text to the typed text to preserve case
                    sAppendText = sFoundText.Substring(sTypedText.Length)
                    Me.Text = sTypedText & sAppendText

                    'Select the Appended Text
                    Me.SelectionStart = sTypedText.Length
                    Me.SelectionLength = sAppendText.Length

                    If e.KeyCode = Keys.Enter Then
                        iFoundIndex = Me.FindStringExact(Me.Text)
                        Me.SelectedIndex = iFoundIndex
                        SendKeys.Send(vbTab)
                        e.Handled = True
                    End If
                End If
            End If
        End If
        PressedKey = False
        'End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        'If m_bolAutoCompleteEnabled = True Then
        If Me.DropDownStyle = CustomDropDownStyle.DropDownList AndAlso e.KeyCode = Keys.Delete Then
            If Me.Text <> Me.SelectedText Then
                e.Handled = True
            End If
        End If

        MyBase.OnKeyDown(e)
        'End If
    End Sub
    '
    '   Disable the arrow keys to prevent from moving to the next tab when clicking on these keys.
    '
    Protected Overrides Function IsInputKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            Select Case keyData
                Case Keys.Up
                    Return False
                Case Keys.Down
                    Return False
                Case Keys.Right
                    Return False
                Case Keys.Left
                    Return False
            End Select

            Return MyBase.IsInputKey(keyData)

        Catch ex As Exception
            Beep()
            MsgBox("customCombo_IsInputKey: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
            Return False
        End Try
    End Function
    '
    '   Disable the delete key to prevent blank entries.
    '
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            Select Case keyData
                Case Keys.Delete
                    Return True
            End Select

            Return False

        Catch ex As Exception
            Beep()
            MsgBox("customCombo_ProcessCmdKey: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
            Return False
        End Try
    End Function

    Protected Overrides Sub RefreshItem(ByVal index As Integer)

    End Sub

    Protected Overrides Sub SetItemsCore(ByVal items As System.Collections.IList)

    End Sub

    Public Function SetIntegerID(ByVal lngID As Integer, Optional ByVal bolSetTag As Boolean = False) As Integer
        Dim i As Integer

        Try
            i = 0
            If Me.Items.Count > 0 Then
                For i = 0 To Items.Count - 1
                    If TypeOf (Items(i)) Is clsItemData AndAlso Items(i).IntegerID = lngID Then
                        If bolSetTag Then
                            Tag = i
                        End If
                        SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
            Return i
        Catch ex As Exception
            Beep()
            MsgBox("customCombo_SetIntegerID: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
            Return Nothing
        End Try
    End Function

    Public Shared Sub Load(ByVal strQueryName As String, _
                    Optional ByVal bolBlankAllowed As Boolean = False, _
                    Optional ByVal bolNewOption As Boolean = False, _
                    Optional ByVal strNewOption As String = "", _
                    Optional ByVal bolSelectOption As Boolean = False, _
                    Optional ByVal strSelectOption As String = "", _
                    Optional ByVal lngSelection As Integer = -99, _
                    Optional ByVal bolUseFloat As Boolean = False, _
                    Optional ByVal ysnDisplaySelectionIfInactive As Boolean = False, _
                    Optional ByVal lngParam As Integer = -99, _
                    Optional ByVal lngParam2 As Integer = -99, _
                    Optional ByVal bolSetTagValue As Boolean = False, _
                    Optional ByVal lngParam3 As Integer = -99, _
                    Optional ByVal bolNoDataDefault As Boolean = False, _
                    Optional ByVal strNoDataDefault As String = "", _
                    Optional ByVal strParam4 As String = "-99", _
                    Optional ByVal lngParam4Len As Integer = -99, _
                    Optional ByVal bolUseBoolean As Boolean = False, _
                    Optional ByVal lngParam4 As Integer = -99, _
                    Optional ByVal bolUseString2 As Boolean = False)
        Dim objConn As SqlConnection = Nothing
        Dim qryTemp As SqlCommand = Nothing
        Dim rsTemp As SqlDataReader = Nothing
        Dim i As Integer
        Dim lngErrorCount As Integer

        Try
            '
            '  clear the list
            '
            Me.Items.Clear()

            objConn = New SqlConnection
            '
            '   Do retry here to try to deal with deadlock errors.
            '
            lngErrorCount = 0
            Do
                Try
                    Dim para As SqlClient.SqlParameter
                    para = New SqlParameter()
                    qryTemp = New SqlCommand

                    qryTemp.CommandText = strQueryName
                    qryTemp.Connection = objConn
                    qryTemp.CommandType = CommandType.StoredProcedure
                    qryTemp.CommandTimeout = 60
                    If lngParam <> -99 Then
                        para = CreateParameter("lngParam", SqlDbType.Int, ParameterDirection.Input, NZ(lngParam, 0))
                        qryTemp.Parameters.Add(para)
                        'qryTemp.AddParam("lngParam", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, NZ(lngParam, 0))
                    End If
                    If lngParam2 <> -99 Then
                        para = CreateParameter("lngParam2", SqlDbType.Int, ParameterDirection.Input, NZ(lngParam, 0))
                        qryTemp.Parameters.Add(para)
                        'qryTemp.AddParam("lngParam2", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, NZ(lngParam2, 0))
                    End If
                    If lngParam3 <> -99 Then
                        para = CreateParameter("lngParam3", SqlDbType.Int, ParameterDirection.Input, NZ(lngParam, 0))
                        qryTemp.Parameters.Add(para)
                        'qryTemp.AddParam("lngParam3", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, NZ(lngParam3, 0))
                    End If
                    If lngParam4 <> -99 Then
                        para = CreateParameter("lngParam4", SqlDbType.Int, ParameterDirection.Input, NZ(lngParam, 0))
                        qryTemp.Parameters.Add(para)
                        'qryTemp.AddParam("lngParam4", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, NZ(lngParam4, 0))
                    End If
                    If strParam4 <> "-99" Then
                        para = CreateParameter("txtParam4", SqlDbType.Int, ParameterDirection.Input, NZ(strParam4, ""))
                        qryTemp.Parameters.Add(para)
                        'qryTemp.AddParam("txtParam4", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, lngParam4Len, NZ(strParam4, ""))
                    End If
                    'If ysnDisplaySelectionIfInactive Then
                    '    qryTemp.AddParam("lngSelection", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, NZ(lngSelection, 0))
                    'End If
                    rsTemp = qryTemp.ExecuteReader()
                    Exit Do
                Catch exZ As Exception When (lngErrorCount < 10 And InStr(exZ.StackTrace, "deadlocked") > 0)
                    lngErrorCount = lngErrorCount + 1

                Catch exZ As Exception
                    '
                    '   Probogate error to subroutine error handler.
                    '
                    Throw
                End Try
            Loop

            If Not IsNothing(rsTemp) Then
                If bolSelectOption Then
                    Me.Items.Add(New clsItemData(strSelectOption, -1, ""))
                ElseIf bolNewOption Then
                    Me.Items.Add(New clsItemData(strNewOption, 0, ""))
                ElseIf bolBlankAllowed Then
                    Me.Items.Add(New clsItemData("", 0, ""))
                End If
                Do Until rsTemp.HasRows
                    '
                    '   Allow extra float criteria to be stored as part of dropdown list.
                    '
                    If bolUseString2 And bolUseFloat And bolUseBoolean Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), NZ(rsTemp.Item("fltID"), 0), , NZ(rsTemp.Item("txtString2"), ""), , , NZ(rsTemp.Item("bolID"), 0)))
                    ElseIf bolUseFloat And bolUseBoolean Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), NZ(rsTemp.Item("fltID"), 0), , , , , NZ(rsTemp.Item("bolID"), 0)))
                    ElseIf bolUseString2 And bolUseFloat Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), NZ(rsTemp.Item("fltID"), 0), , NZ(rsTemp.Item("txtString2"), "")))
                    ElseIf bolUseString2 And bolUseBoolean Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), , , NZ(rsTemp.Item("txtString2"), ""), , , NZ(rsTemp.Item("bolID"), 0)))
                    ElseIf bolUseFloat Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), NZ(rsTemp.Item("fltID"), 0)))
                    ElseIf bolUseBoolean Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), , , , , , NZ(rsTemp.Item("bolID"), 0)))
                    ElseIf bolUseString2 Then
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), ""), , , NZ(rsTemp.Item("txtString2"), "")))
                    Else
                        Me.Items.Add(New clsItemData(NZ(rsTemp.Item("txtDescription"), ""), NZ(rsTemp.Item("PK_autItemID"), 0), NZ(rsTemp.Item("txtCode"), "")))
                    End If
                    rsTemp.NextResult()
                Loop
            Else
                If bolSelectOption Then
                    Me.Items.Add(New clsItemData(strSelectOption, -1, ""))
                ElseIf bolNewOption Then
                    Me.Items.Add(New clsItemData(strNewOption, 0, ""))
                ElseIf bolNoDataDefault Then
                    Me.Items.Add(New clsItemData(strNoDataDefault, 0, ""))
                Else
                    Me.Items.Add(New clsItemData("", 0, ""))
                End If
            End If
            '
            '   Set the current selection.
            '
            If lngSelection <> -99 AndAlso Me.Items.Count > 0 Then
                For i = 0 To Me.Items.Count - 1
                    If Me.Items(i).IntegerID = lngSelection Then
                        If bolSetTagValue Then
                            Me.Tag = i
                        End If
                        Me.SelectedIndex = i
                        Exit For
                    End If
                Next i
                If Me.SelectedIndex = -1 Then
                    If bolSetTagValue Then
                        Me.Tag = 0
                    End If
                    Me.SelectedIndex = 0
                End If
            ElseIf Me.Items.Count > 0 Then
                If bolSetTagValue Then
                    Me.Tag = 0
                End If
                Me.SelectedIndex = 0
            Else
                Me.Items.Add(New clsItemData("", -1, ""))
                If bolSetTagValue Then
                    Me.Tag = 0
                End If
                Me.SelectedIndex = 0
            End If

        Catch ex As Exception
            Beep()
            MsgBox("customCombo_Load: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
        Finally
            qryTemp = Nothing
            Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
            Try : objConn.Close() : objConn = Nothing : Catch : End Try
        End Try

    End Sub

    'Public Sub PreLoad(ByVal cntlBase As System.Windows.Forms.ComboBox, _
    '                    ByVal strQueryBase As String, _
    '                    Optional ByVal bolBlankAllowed As Boolean = False, _
    '                    Optional ByVal bolNewOption As Boolean = False, _
    '                    Optional ByVal strNewOption As String = "", _
    '                    Optional ByVal bolSelectOption As Boolean = False, _
    '                    Optional ByVal strSelectOption As String = "", _
    '                    Optional ByVal lngSelection As Integer = -99, _
    '                    Optional ByVal bolUseFloat As Boolean = False, _
    '                    Optional ByVal ysnDisplaySelectionIfInactive As Boolean = False, _
    '                    Optional ByVal lngParam As Integer = -99, _
    '                    Optional ByVal lngParam2 As Integer = -99, _
    '                    Optional ByVal bolSetTagValue As Boolean = False, _
    '                    Optional ByVal lngParam3 As Integer = -99, _
    '                    Optional ByVal bolNoDataDefault As Boolean = False, _
    '                    Optional ByVal strNoDataDefault As String = "", _
    '                    Optional ByVal strParam4 As String = "-99", _
    '                    Optional ByVal lngParam4Len As Integer = -99, _
    '                    Optional ByVal bolUseBoolean As Boolean = False, _
    '                    Optional ByVal lngParam4 As Integer = -99)
    '    Dim objConn As ADODB.Connection = Nothing
    '    Dim qryTemp As ADODB.Command
    '    Dim rsTemp As ADODB.Recordset = Nothing
    '    Dim i As Integer
    '    Dim objTemp(cntlBase.Items.Count - 1) As Object
    '    Dim bolDataFound As Boolean = False

    '    Try
    '        '
    '        '   Use the normal load if the preload combo is empty.
    '        '
    '        If cntlBase Is Nothing Then
    '            Me.Load(strQueryBase & "_STA", _
    '                    bolBlankAllowed, _
    '                    bolNewOption, _
    '                    strNewOption, _
    '                    bolSelectOption, _
    '                    strSelectOption, _
    '                    lngSelection, _
    '                    bolUseFloat, _
    '                    ysnDisplaySelectionIfInactive, _
    '                    lngParam, _
    '                    lngParam2, _
    '                    bolSetTagValue, _
    '                    lngParam3, _
    '                    bolNoDataDefault, _
    '                    strNoDataDefault, _
    '                    strParam4, _
    '                    lngParam4Len, _
    '                    bolUseBoolean, _
    '                    lngParam4)
    '        Else
    '            '
    '            '  clear the list
    '            '
    '            Me.Items.Clear()
    '            '
    '            '   Display selection/add/blank option if desired.
    '            '
    '            If bolSelectOption Then
    '                Me.Items.Add(New clsItemData(strSelectOption, -1, ""))
    '            ElseIf bolNewOption Then
    '                Me.Items.Add(New clsItemData(strNewOption, 0, ""))
    '            ElseIf bolBlankAllowed Then
    '                Me.Items.Add(New clsItemData("", 0, ""))
    '            End If
    '            '
    '            '   Copy the entire base collection into an existing array of objects 
    '            '
    '            cntlBase.Items.CopyTo(objTemp, 0)
    '            '
    '            '   Set the combo to the reference for the preloaded control.
    '            '
    '            Me.Items.AddRange(objTemp)
    '            '
    '            '   See is selection exists in the preload dataset.
    '            '
    '            If lngSelection <> -99 AndAlso Me.Items.Count > 0 Then
    '                For i = 0 To Me.Items.Count - 1
    '                    If Me.Items(i).IntegerID = lngSelection Then
    '                        bolDataFound = True
    '                        Exit For
    '                    End If
    '                Next i
    '            End If
    '            '
    '            '   Query for the selection if it is not found.
    '            '
    '            If bolDataFound = False AndAlso lngSelection <> -99 Then
    '                objConn = New ADODB.Connection
    '                objConn.ConnectionString = "File Name=" & GetPath() & "\Breweries.udl;"
    '                objConn.Open()

    '                qryTemp = New ADODB.Command
    '                qryTemp.let_ActiveConnection(objConn)

    '                qryTemp.CommandText = strQueryBase & "BySelection_STA"

    '                qryTemp.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
    '                qryTemp.CommandTimeout = 60
    '                qryTemp.AddParam("lngSelection", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngSelection, 0))
    '                rsTemp = qryTemp.Execute

    '                If Not rsTemp.EOF Then
    '                    '
    '                    '   Allow extra float criteria to be stored as part of dropdown list.
    '                    '
    '                    If bolUseFloat And bolUseBoolean Then
    '                        Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), varADOfltNZ(rsTemp.Fields("fltID"), 0), , , , , varADOBolNZ(rsTemp.Fields("bolID"), 0)))
    '                    ElseIf bolUseFloat Then
    '                        Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), varADOfltNZ(rsTemp.Fields("fltID"), 0)))
    '                    ElseIf bolUseBoolean Then
    '                        Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), , , , , , varADOBolNZ(rsTemp.Fields("bolID"), 0)))
    '                    Else
    '                        Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), "")))
    '                    End If
    '                End If
    '            End If
    '            '
    '            '   Set the current selection.
    '            '
    '            If lngSelection <> -99 AndAlso Me.Items.Count > 0 Then
    '                For i = 0 To Me.Items.Count - 1
    '                    If Me.Items(i).IntegerID = lngSelection Then
    '                        If bolSetTagValue Then
    '                            Me.Tag = i
    '                        End If
    '                        Me.SelectedIndex = i
    '                        Exit For
    '                    End If
    '                Next i
    '                If Me.SelectedIndex = -1 Then
    '                    If bolSetTagValue Then
    '                        Me.Tag = 0
    '                    End If
    '                    Me.SelectedIndex = 0
    '                End If
    '            ElseIf Me.Items.Count > 0 Then
    '                If bolSetTagValue Then
    '                    Me.Tag = 0
    '                End If
    '                Me.SelectedIndex = 0
    '            Else
    '                Me.Items.Add(New clsItemData("", -1, ""))
    '                If bolSetTagValue Then
    '                    Me.Tag = 0
    '                End If
    '                Me.SelectedIndex = 0
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Beep()
    '        MsgBox("customCombo_PreLoad: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
    '    Finally
    '        qryTemp = Nothing
    '        Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
    '        Try : objConn.Close() : objConn = Nothing : Catch : End Try
    '    End Try

    'End Sub

    'Public Sub LoadReplicatedData(ByVal strConnectionString As String, _
    '                ByVal strQueryName As String, _
    '                Optional ByVal bolBlankAllowed As Boolean = False, _
    '                Optional ByVal bolNewOption As Boolean = False, _
    '                Optional ByVal strNewOption As String = "", _
    '                Optional ByVal bolSelectOption As Boolean = False, _
    '                Optional ByVal strSelectOption As String = "", _
    '                Optional ByVal lngSelection As Integer = -99, _
    '                Optional ByVal bolUseFloat As Boolean = False, _
    '                Optional ByVal ysnDisplaySelectionIfInactive As Boolean = False, _
    '                Optional ByVal lngParam As Integer = -99, _
    '                Optional ByVal lngParam2 As Integer = -99, _
    '                Optional ByVal bolSetTagValue As Boolean = False, _
    '                Optional ByVal lngParam3 As Integer = -99, _
    '                Optional ByVal bolNoDataDefault As Boolean = False, _
    '                Optional ByVal strNoDataDefault As String = "", _
    '                Optional ByVal strParam4 As String = "-99", _
    '                Optional ByVal lngParam4Len As Integer = -99, _
    '                Optional ByVal bolUseBoolean As Boolean = False, _
    '                Optional ByVal lngParam4 As Integer = -99)
    '    Dim objConn As ADODB.Connection = Nothing
    '    Dim qryTemp As ADODB.Command
    '    Dim rsTemp As ADODB.Recordset = Nothing
    '    Dim i As Integer
    '    Dim lngErrorCount As Integer

    '    Try
    '        '
    '        '  clear the list
    '        '
    '        Me.Items.Clear()

    '        objConn = New ADODB.Connection(True)
    '        objConn.ConnectionString = strConnectionString
    '        '
    '        '   Do retry here to try to deal with deadlock errors.
    '        '
    '        lngErrorCount = 0
    '        Do
    '            Try
    '                qryTemp = New ADODB.Command(objConn)

    '                qryTemp.CommandText = strQueryName

    '                qryTemp.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
    '                qryTemp.CommandTimeout = 60
    '                If lngParam <> -99 Then
    '                    qryTemp.AddParam("lngParam", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngParam, 0))
    '                End If
    '                If lngParam2 <> -99 Then
    '                    qryTemp.AddParam("lngParam2", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngParam2, 0))
    '                End If
    '                If lngParam3 <> -99 Then
    '                    qryTemp.AddParam("lngParam3", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngParam3, 0))
    '                End If
    '                If lngParam4 <> -99 Then
    '                    qryTemp.AddParam("lngParam4", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngParam4, 0))
    '                End If
    '                If strParam4 <> "-99" Then
    '                    qryTemp.AddParam("txtParam4", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, lngParam4Len, varStrNZ(strParam4, ""))
    '                End If
    '                If ysnDisplaySelectionIfInactive Then
    '                    qryTemp.AddParam("lngSelection", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 4, varIntNZ(lngSelection, 0))
    '                End If
    '                rsTemp = qryTemp.Execute
    '                Exit Do
    '            Catch exZ As Exception When (lngErrorCount < 10 And InStr(exZ.StackTrace, "deadlocked") > 0)
    '                lngErrorCount = lngErrorCount + 1
    '                Pause(1)
    '            Catch exZ As Exception
    '                '
    '                '   Probogate error to subroutine error handler.
    '                '
    '                Throw
    '            End Try
    '        Loop

    '        If Not rsTemp.EOF Then
    '            If bolSelectOption Then
    '                Me.Items.Add(New clsItemData(strSelectOption, -1, ""))
    '            ElseIf bolNewOption Then
    '                Me.Items.Add(New clsItemData(strNewOption, 0, ""))
    '            ElseIf bolBlankAllowed Then
    '                Me.Items.Add(New clsItemData("", 0, ""))
    '            End If
    '            Do Until rsTemp.EOF
    '                '
    '                '   Allow extra float criteria to be stored as part of dropdown list.
    '                '
    '                If bolUseFloat And bolUseBoolean Then
    '                    Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), varADOfltNZ(rsTemp.Fields("fltID"), 0), , , , , varADOBolNZ(rsTemp.Fields("bolID"), 0)))
    '                ElseIf bolUseFloat Then
    '                    Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), varADOfltNZ(rsTemp.Fields("fltID"), 0)))
    '                ElseIf bolUseBoolean Then
    '                    Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), ""), , , , , , varADOBolNZ(rsTemp.Fields("bolID"), 0)))
    '                Else
    '                    Me.Items.Add(New clsItemData(varADOStrNZ(rsTemp.Fields("txtDescription"), ""), varADOIntNZ(rsTemp.Fields("PK_autItemID"), 0), varADOStrNZ(rsTemp.Fields("txtCode"), "")))
    '                End If
    '                rsTemp.MoveNext()
    '            Loop
    '        Else
    '            If bolSelectOption Then
    '                Me.Items.Add(New clsItemData(strSelectOption, -1, ""))
    '            ElseIf bolNewOption Then
    '                Me.Items.Add(New clsItemData(strNewOption, 0, ""))
    '            ElseIf bolNoDataDefault Then
    '                Me.Items.Add(New clsItemData(strNoDataDefault, 0, ""))
    '            Else
    '                Me.Items.Add(New clsItemData("", 0, ""))
    '            End If
    '        End If
    '        '
    '        '   Set the current selection.
    '        '
    '        If lngSelection <> -99 AndAlso Me.Items.Count > 0 Then
    '            For i = 0 To Me.Items.Count - 1
    '                If Me.Items(i).IntegerID = lngSelection Then
    '                    If bolSetTagValue Then
    '                        Me.Tag = i
    '                    End If
    '                    Me.SelectedIndex = i
    '                    Exit For
    '                End If
    '            Next i
    '            If Me.SelectedIndex = -1 Then
    '                If bolSetTagValue Then
    '                    Me.Tag = 0
    '                End If
    '                Me.SelectedIndex = 0
    '            End If
    '        ElseIf Me.Items.Count > 0 Then
    '            If bolSetTagValue Then
    '                Me.Tag = 0
    '            End If
    '            Me.SelectedIndex = 0
    '        Else
    '            Me.Items.Add(New clsItemData("", -1, ""))
    '            If bolSetTagValue Then
    '                Me.Tag = 0
    '            End If
    '            Me.SelectedIndex = 0
    '        End If

    '    Catch ex As Exception
    '        Beep()
    '        MsgBox("customCombo_LoadReplicatedData: " & ex.Message, MsgBoxStyle.Critical, "System Exception")
    '    Finally
    '        qryTemp = Nothing
    '        Try : rsTemp.Close() : rsTemp = Nothing : Catch : End Try
    '        Try : objConn.Close() : objConn = Nothing : Catch : End Try
    '    End Try

    'End Sub

    Public Function IntegerID() As Integer
        Try
            If TypeOf (Me.SelectedItem) Is clsItemData AndAlso Me.SelectedItem IsNot Nothing AndAlso Me.SelectedItem.IntegerID > 0 Then
                Return Me.SelectedItem.IntegerID
            Else
                Return 0
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return 0
        End Try
    End Function

    Public Function StringID() As String
        Try
            If TypeOf (Me.SelectedItem) Is clsItemData AndAlso Me.SelectedItem IsNot Nothing AndAlso Me.SelectedItem.StringID <> "" Then
                Return Me.SelectedItem.StringID
            Else
                Return ""
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return 0
        End Try
    End Function

    Public Function ItemName() As String
        Try
            If TypeOf (Me.SelectedItem) Is clsItemData AndAlso Me.SelectedItem IsNot Nothing AndAlso Me.SelectedItem.Name <> "" Then
                Return Me.SelectedItem.Name
            Else
                Return ""
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
            Return 0
        End Try
    End Function

    Public Sub LoadCountCombo(ByVal lngMinNumber As Integer, ByVal lngMaxNumber As Integer, ByVal lngSelection As Integer, Optional ByVal bolSetTagValue As Boolean = False)
        Dim i As Integer

        Try
            '
            '  clear the list
            '
            Me.Items.Clear()

            If lngMinNumber > lngMaxNumber Then
                For i = lngMaxNumber To lngMinNumber Step -1
                    Me.Items.Add(New clsItemData(i.ToString, i))
                Next
            Else
                For i = lngMinNumber To lngMaxNumber
                    Me.Items.Add(New clsItemData(i.ToString, i))
                Next
            End If
            '
            '   Set the current selection.
            '
            If Me.Items.Count > 0 Then
                SetIntegerID(lngSelection, bolSetTagValue)
            Else
                Me.Items.Add(New clsItemData("0", 0))
                If bolSetTagValue Then
                    Me.Tag = 0
                End If
                Me.SelectedIndex = 0
            End If
        Catch ex As Exception
            Beep()
            HandleException(Me.Name, ex)
        End Try
    End Sub

    Public Sub ReadOnlyStatus(ByVal bolReadOnly As Boolean)
        Try
            If m_bolApplyPermissions Then
                Me.Enabled = Not bolReadOnly

                If bolReadOnly Then
                    Me.BackColor = System.Drawing.SystemColors.Control
                Else
                    Me.BackColor = Color.White
                End If
            End If
        Catch ex As Exception
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region
#Region "Dispose"
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        Try
            '
            '   Clear collection to avoid memory leak
            '
            Me.Items.Clear()

        Catch ex As Exception
            Beep()
            HandleException(Me.Name, ex)
        End Try
    End Sub
#End Region



End Class
