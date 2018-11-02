Public Class clsItemData
    Private m_strName As String
    Private m_intID As Integer
    Private m_intID2 As Integer
    Private m_intID3 As Integer
    Private m_strID As String
    Private m_strID2 As String
    Private m_strID3 As String
    Private m_strID4 As String
    Private m_dblID As Double
    Private m_dblID2 As Double
    Private m_bolID As Boolean
    '
    '   Default empty constructor. 
    '
    Public Sub New()
        m_strName = ""
        '
        '   This would need to be changed if you modified the declaration above. 
        '
        m_intID = 0
        m_intID2 = 0
        m_intID3 = 0
        m_strID = ""
        m_strID2 = ""
        m_strID3 = ""
        m_strID4 = ""
        m_dblID = 0
        m_dblID2 = 0
        m_bolID = False
    End Sub

    Public Sub New(ByVal strName As String, _
                    Optional ByVal intID As Integer = 0, Optional ByVal strID As String = "", Optional ByVal dblID As Double = 0, _
                    Optional ByVal intID2 As Integer = 0, Optional ByVal strID2 As String = "", _
                    Optional ByVal intID3 As Integer = 0, Optional ByVal strID3 As String = "", _
                    Optional ByVal bolID As Boolean = False, Optional ByVal strID4 As String = "", _
                    Optional ByVal dblID2 As Double = 0)
        m_strName = strName
        m_intID = intID
        m_intID2 = intID2
        m_intID3 = intID3
        m_strID = strID
        m_strID2 = strID2
        m_strID3 = strID3
        m_strID4 = strID4
        m_dblID = dblID
        m_dblID2 = dblID2
        m_bolID = bolID
    End Sub

    Public Property Name() As String
        Get
            Return m_strName
        End Get
        Set(ByVal strValue As String)
            m_strName = strValue
        End Set
    End Property

    Public ReadOnly Property DisplayName() As String
        Get
            Return m_strName
        End Get
    End Property
    '
    '   This is the property that holds the extra data. 
    '
    Public Property IntegerID() As Int32
        Get
            Return m_intID
        End Get
        Set(ByVal intValue As Int32)
            m_intID = intValue
        End Set
    End Property

    '   This is the property that holds the extra data. 
    '
    Public Property IntegerID2() As Int32
        Get
            Return m_intID2
        End Get
        Set(ByVal intValue As Int32)
            m_intID2 = intValue
        End Set
    End Property

    '   This is the property that holds the extra data. 
    '
    Public Property IntegerID3() As Int32
        Get
            Return m_intID3
        End Get
        Set(ByVal intValue As Int32)
            m_intID3 = intValue
        End Set
    End Property
    '
    '   This is the property that holds the extra data. 
    '
    Public Property StringID() As String
        Get
            Return m_strID
        End Get
        Set(ByVal strValue As String)
            m_strID = strValue
        End Set
    End Property
    '
    '   This is the property that holds the extra data. 
    '
    Public Property StringID2() As String
        Get
            Return m_strID2
        End Get
        Set(ByVal strValue As String)
            m_strID2 = strValue
        End Set
    End Property
    '
    '   This is the property that holds the extra data. 
    '
    Public Property StringID3() As String
        Get
            Return m_strID3
        End Get
        Set(ByVal strValue As String)
            m_strID3 = strValue
        End Set
    End Property

    Public Property StringID4() As String
        Get
            Return m_strID4
        End Get
        Set(ByVal strValue As String)
            m_strID4 = strValue
        End Set
    End Property

    Public Property dblID() As Double
        Get
            Return m_dblID
        End Get
        Set(ByVal dblValue As Double)
            m_dblID = dblValue
        End Set
    End Property

    Public Property dblID2() As Double
        Get
            Return m_dblID2
        End Get
        Set(ByVal dblValue As Double)
            m_dblID2 = dblValue
        End Set
    End Property

    Public Property bolID() As Boolean
        Get
            Return m_bolID
        End Get
        Set(ByVal bolValue As Boolean)
            m_bolID = bolValue
        End Set
    End Property
    '
    '   This is neccessary because the ListBox and ComboBox rely 
    '   on this method when determining the text to display. 
    '
    Public Overrides Function ToString() As String
        Return m_strName
    End Function
End Class
