Public Class Offense
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

    ' Player Team
    Public Property team() As String
        Get
            Return m_team
        End Get
        Set(value As String)
            m_team = value
        End Set
    End Property
    Private m_team As String

    ' Passing Yards
    Public Property PassingYards() As Integer
        Get
            Return mPassingYards
        End Get
        Set(value As Integer)
            mPassingYards = value
        End Set
    End Property
    Private mPassingYards As Integer

    ' Games Played
    Public Property gamesPlayed() As Integer
        Get
            Return mGamesPlayed
        End Get
        Set(value As Integer)
            mGamesPlayed = value
        End Set
    End Property
    Private mGamesPlayed As Integer

    ' Passing TDs
    Public Property PassingTD() As Integer
        Get
            Return mPassingTD
        End Get
        Set(value As Integer)
            mPassingTD = value
        End Set
    End Property
    Private mPassingTD As Integer

    ' Passing INTs
    Public Property PassingINT() As Integer
        Get
            Return mPassingINT
        End Get
        Set(value As Integer)
            mPassingINT = value
        End Set
    End Property
    Private mPassingINT As Integer

    ' Rushing Yards
    Public Property RushingYD() As Integer
        Get
            Return mRushingYD
        End Get
        Set(value As Integer)
            mRushingYD = value
        End Set
    End Property
    Private mRushingYD As Integer

    ' Rushing TDs
    Public Property RushingTD() As Integer
        Get
            Return mRushingTD
        End Get
        Set(value As Integer)
            mRushingTD = value
        End Set
    End Property
    Private mRushingTD As Integer

    ' Recieving Yards
    Public Property RecievingYD() As Integer
        Get
            Return mRecievingYD
        End Get
        Set(value As Integer)
            mRecievingYD = value
        End Set
    End Property
    Private mRecievingYD As Integer

    ' Recieving TDs
    Public Property RecievingTD() As Integer
        Get
            Return mRecievingTD
        End Get
        Set(value As Integer)
            mRecievingTD = value
        End Set
    End Property
    Private mRecievingTD As Integer

    ' Fumble TDs
    Public Property FumbleTD() As Integer
        Get
            Return mFumbleTD
        End Get
        Set(value As Integer)
            mFumbleTD = value
        End Set
    End Property
    Private mFumbleTD As Integer

    ' twoPT
    Public Property twoPT() As Integer
        Get
            Return mtwoPT
        End Get
        Set(value As Integer)
            mtwoPT = value
        End Set
    End Property
    Private mtwoPT As Integer

    ' Fumble
    Public Property Fumble() As Integer
        Get
            Return mFumble
        End Get
        Set(value As Integer)
            mFumble = value
        End Set
    End Property
    Private mFumble As Integer

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
