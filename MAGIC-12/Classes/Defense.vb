Public Class Defense
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
	
	' Sacks
    Public Property Sacks() As Integer
        Get
            Return mSacks
        End Get
        Set(value As Integer)
            mSacks = value
        End Set
    End Property
    Private mSacks As Integer
	
	' Interceptions
    Public Property Interceptions() As Integer
        Get
            Return mInterceptions
        End Get
        Set(value As Integer)
            mInterceptions = value
        End Set
    End Property
    Private mInterceptions As Integer
	
	' fumbleRec
    Public Property fumbleRec() As Integer
        Get
            Return mfumbleRec
        End Get
        Set(value As Integer)
            mfumbleRec = value
        End Set
    End Property
    Private mfumbleRec As Integer
	
	' Safety
    Public Property Safety() As Integer
        Get
            Return mSafety
        End Get
        Set(value As Integer)
            mSafety = value
        End Set
    End Property
    Private mSafety As Integer
	
	' turnoverTD
    Public Property turnoverTD() As Integer
        Get
            Return mturnoverTD
        End Get
        Set(value As Integer)
            mturnoverTD = value
        End Set
    End Property
    Private mturnoverTD As Integer
	
	' returnTD
    Public Property returnTD() As Integer
        Get
            Return mreturnTD
        End Get
        Set(value As Integer)
            mreturnTD = value
        End Set
    End Property
    Private mreturnTD As Integer
	
	' pointsAllowed
    Public Property pointsAllowed() As Integer
        Get
            Return mpointsAllowed
        End Get
        Set(value As Integer)
            mpointsAllowed = value
        End Set
    End Property
    Private mpointsAllowed As Integer

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
