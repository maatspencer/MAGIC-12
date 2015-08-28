Enter file contents herePublic Class Player
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
	
	' extraPoints
    Public Property extraPoints() As Integer
        Get
            Return mextraPoints
        End Get
        Set(value As Integer)
            mextraPoints = value
        End Set
    End Property
    Private mextraPoints As Integer
	
	' fieldGoal_0_19
    Public Property fieldGoal_0_19() As Integer
        Get
            Return mfieldGoal_0_19
        End Get
        Set(value As Integer)
            mfieldGoal_0_19 = value
        End Set
    End Property
    Private mfieldGoal_0_19 As Integer
	
	' fieldGoal_20_29
    Public Property fieldGoal_20_29() As Integer
        Get
            Return mfieldGoal_20_29
        End Get
        Set(value As Integer)
            mfieldGoal_20_29 = value
        End Set
    End Property
    Private mfieldGoal_20_29 As Integer
	
	' fieldGoal_30_39
    Public Property fieldGoal_30_39() As Integer
        Get
            Return mfieldGoal_30_39
        End Get
        Set(value As Integer)
            mfieldGoal_30_39 = value
        End Set
    End Property
    Private mfieldGoal_30_39 As Integer
	
	' fieldGoal_40_49
    Public Property fieldGoal_40_49() As Integer
        Get
            Return mfieldGoal_40_49
        End Get
        Set(value As Integer)
            mfieldGoal_40_49 = value
        End Set
    End Property
    Private mfieldGoal_40_49 As Integer
	
	' fieldGoal_50
    Public Property fieldGoal_50() As Integer
        Get
            Return mfieldGoal_50
        End Get
        Set(value As Integer)
            mfieldGoal_50 = value
        End Set
    End Property
    Private mfieldGoal_50 As Integer

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
