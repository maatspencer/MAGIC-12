Public Class Player
    ' Name
    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String

    ' Played Team
    Public Property team() As String
        Get
            Return m_team
        End Get
        Set(value As String)
            m_team = value
        End Set
    End Property
    Private m_team As String

    ' gamesPlayed
    Public Property gamesPlayed() As Integer
        Get
            Return mgamesPlayed
        End Get
        Set(value As Integer)
            mgamesPlayed = value
        End Set
    End Property
    Private mgamesPlayed As Integer

    ' NFL Points
    Public Property NFLPoints() As Decimal
        Get
            Return mNFLPoints
        End Get
        Set(value As Decimal)
            mNFLPoints = value
        End Set
    End Property
    Private mNFLPoints As Decimal

    ' Matts Points
    Public Property MattsPoints() As Decimal
        Get
            Return mMattsPoints
        End Get
        Set(value As Decimal)
            mMattsPoints = value
        End Set
    End Property
    Private mMattsPoints As Decimal

    ' CSR
    Public Property CSRPoints() As Decimal
        Get
            Return mCSRPoints
        End Get
        Set(value As Decimal)
            mCSRPoints = value
        End Set
    End Property
    Private mCSRPoints As Decimal

    ' Pos Rank
    Public Property PosRank() As Integer
        Get
            Return mPosRank
        End Get
        Set(value As Integer)
            mPosRank = value
        End Set
    End Property
    Private mPosRank As Integer

    ' Overall Rank
    Public Property OvrRank() As Integer
        Get
            Return mOvrRank
        End Get
        Set(value As Integer)
            mOvrRank = value
        End Set
    End Property
    Private mOvrRank As Integer

    ' Position
    Public Property Pos() As String
        Get
            Return mPos
        End Get
        Set(value As String)
            mPos = value
        End Set
    End Property
    Private mPos As String
End Class
