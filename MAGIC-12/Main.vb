Imports System.IO

Public Class Main

	' Instances
    Public Shared oWR As List(Of Offense)
    Public Shared oQB As List(Of Offense)
    Public Shared oRB As List(Of Offense)
    Public Shared oTE As List(Of Offense)
	Public Shared oFlex As List(Of Offense)
	
	Public Shared oPK As List(Of Kicker)
	
	Public Shared oDEF As List(Of Defense)
	
    Public Shared oOvr As List(Of Player)

	
	' Load event
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Quarterback
        oQB = readOffense(My.Application.Info.DirectoryPath & "/Tables/QB.csv", 12, "QB")
        For i = 0 To oQB.Count - 1
            ListBox2.Items.Add(oQB.Item(i).CSRPoints & vbTab & oQB.Item(i).MattsPoints & vbTab & oQB.Item(i).name)
        Next
        ListBox2.Update()

        ' Wide Recievers
        oWR = readOffense(My.Application.Info.DirectoryPath & "/Tables/WR.csv", 24, "WR")
        For i = 0 To oWR.Count - 1
            ListBox3.Items.Add(oWR.Item(i).CSRPoints & vbTab & oWR.Item(i).MattsPoints & vbTab & oWR.Item(i).name)
        Next
        ListBox3.Update()

        ' Running Backs
        oRB = readOffense(My.Application.Info.DirectoryPath & "/Tables/RB.csv", 24, "RB")
        For i = 0 To oRB.Count - 1
            ListBox4.Items.Add(oRB.Item(i).CSRPoints & vbTab & oRB.Item(i).MattsPoints & vbTab & oRB.Item(i).name)
        Next
        ListBox4.Update()

        ' Tight Ends
        oTE = readOffense(My.Application.Info.DirectoryPath & "/Tables/TE.csv", 12, "TE")
        For i = 0 To oTE.Count - 1
            ListBox5.Items.Add(oTE.Item(i).CSRPoints & vbTab & oTE.Item(i).MattsPoints & vbTab & oTE.Item(i).name)
        Next
        ListBox5.Update()
		
		' Kicker
        oPK = readKicker(My.Application.Info.DirectoryPath & "/Tables/K.csv", 12)
        For i = 0 To oPK.Count - 1
            ListBox6.Items.Add(oPK.Item(i).CSRPoints & vbTab & oPK.Item(i).MattsPoints & vbTab & oPK.Item(i).name)
        Next
        ListBox6.Update()
		
		' Defense
        oDEF = readDefense(My.Application.Info.DirectoryPath & "/Tables/DEF.csv", 12)
        For i = 0 To oDEF.Count - 1
            ListBox7.Items.Add(oDEF.Item(i).CSRPoints & vbTab & oDEF.Item(i).MattsPoints & vbTab & oDEF.Item(i).name)
        Next
        ListBox7.Update()
		
		' Flex
		buildFlex()
		

        ' Overall
        buildOverall()
        For i = 0 To oOvr.Count - 1
            ListBox1.Items.Add(oOvr.Item(i).CSRPoints & vbTab & oOvr.Item(i).Pos & vbTab & oOvr.Item(i).name)
        Next
        ListBox5.Update()


    End Sub

	' Read CSV file to Offense Object
    Private Function readOffense(MyFile As String, RosterCount As Integer, pos As String) As IList(Of Offense)
        ' Loop Variables
        Dim CurrentLine As String = ""
        Dim LinetoWrite As String = ""
        Dim Count As Integer = 0

        Dim o As List(Of Offense) = New List(Of Offense)

        Using sr As StreamReader = New StreamReader(MyFile)
            CurrentLine = sr.ReadLine
            Do While (Not CurrentLine Is Nothing)
                Dim t As Offense = New Offense
                t.name = CurrentLine.Split(",")(0)
                t.team = CurrentLine.Split(",")(1)
                t.gamesPlayed = CurrentLine.Split(",")(2)

                t.PassingYards = CurrentLine.Split(",")(3)
                t.PassingTD = CurrentLine.Split(",")(4)
                t.PassingINT = CurrentLine.Split(",")(5)

                t.RushingYD = CurrentLine.Split(",")(6)
                t.RushingTD = CurrentLine.Split(",")(7)

                t.RecievingYD = CurrentLine.Split(",")(8)
                t.RecievingTD = CurrentLine.Split(",")(9)

                t.FumbleTD = CurrentLine.Split(",")(10)
                t.twoPT = CurrentLine.Split(",")(11)
                t.Fumble = CurrentLine.Split(",")(12)

                t.NFLPoints = CurrentLine.Split(",")(13)
                t.MattsPoints = CurrentLine.Split(",")(18)
				
				t.Pos = pos

                o.Add(t)

                CurrentLine = sr.ReadLine
            Loop
        End Using

        o.Sort(Function(x, y) y.MattsPoints.CompareTo(x.MattsPoints))

        For i = 0 To o.Count - 1
            o.Item(i).CSRPoints = o.Item(i).MattsPoints() - o.Item(RosterCount - 1).MattsPoints
        Next

        o.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

        Return o
    End Function
	
	' Read CSV file to Defense Object
	Private Function readDefense(MyFile As String, RosterCount As Integer) As IList(Of Defense)
        ' Loop Variables
        Dim CurrentLine As String = ""
        Dim LinetoWrite As String = ""
        Dim Count As Integer = 0

        Dim o As List(Of Defense) = New List(Of Defense)

        Using sr As StreamReader = New StreamReader(MyFile)
            CurrentLine = sr.ReadLine
            Do While (Not CurrentLine Is Nothing)
                Dim t As Defense = New Defense
                t.name = CurrentLine.Split(",")(0)
                t.team = CurrentLine.Split(",")(1)
                t.gamesPlayed = CurrentLine.Split(",")(2)

                t.Sacks = CurrentLine.Split(",")(3)
                t.Interceptions = CurrentLine.Split(",")(4)
                t.fumbleRec = CurrentLine.Split(",")(5)
                t.Safety = CurrentLine.Split(",")(6)
                t.turnoverTD = CurrentLine.Split(",")(7)
                t.returnTD = CurrentLine.Split(",")(8)
                t.pointsAllowed = CurrentLine.Split(",")(9)

                t.NFLPoints = CurrentLine.Split(",")(10)
                t.MattsPoints = CurrentLine.Split(",")(11)
				
				t.Pos = "DEF"

                o.Add(t)

                CurrentLine = sr.ReadLine
            Loop
        End Using

        o.Sort(Function(x, y) y.MattsPoints.CompareTo(x.MattsPoints))

        For i = 0 To o.Count - 1
            o.Item(i).CSRPoints = o.Item(i).MattsPoints() - o.Item(RosterCount - 1).MattsPoints
        Next

        o.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

        Return o
    End Function
	
		' Read CSV file to Kicker Object
	Private Function readKicker(MyFile As String, RosterCount As Integer) As IList(Of Kicker)
        ' Loop Variables
        Dim CurrentLine As String = ""
        Dim LinetoWrite As String = ""
        Dim Count As Integer = 0

        Dim o As List(Of Kicker) = New List(Of Kicker)

        Using sr As StreamReader = New StreamReader(MyFile)
            CurrentLine = sr.ReadLine
            Do While (Not CurrentLine Is Nothing)
                Dim t As Defense = New Defense
                t.name = CurrentLine.Split(",")(0)
                t.team = CurrentLine.Split(",")(1)
                t.gamesPlayed = CurrentLine.Split(",")(2)

                t.extraPoints = CurrentLine.Split(",")(3)
				
                t.fieldGoal_0_19 = CurrentLine.Split(",")(4)
                t.fieldGoal_20_29 = CurrentLine.Split(",")(5)
                t.fieldGoal_30_39 = CurrentLine.Split(",")(6)
                t.fieldGoal_40_49 = CurrentLine.Split(",")(7)
                t.fieldGoal_50 = CurrentLine.Split(",")(8)

                t.NFLPoints = CurrentLine.Split(",")(9)
                t.MattsPoints = CurrentLine.Split(",")(10)
				
				t.Pos = "PK"

                o.Add(t)

                CurrentLine = sr.ReadLine
            Loop
        End Using

        o.Sort(Function(x, y) y.MattsPoints.CompareTo(x.MattsPoints))

        For i = 0 To o.Count - 1
            o.Item(i).CSRPoints = o.Item(i).MattsPoints() - o.Item(RosterCount - 1).MattsPoints
        Next

        o.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

        Return o
    End Function
	
	' Build flex Object
	Private Sub buildFlex()
        oFlex = New List(Of Offense)

        ' QB
        For i = 0 To oQB.Count - 1
            oFlex.Add(oQB.Item(i))
        Next

        ' RB
        For i = 0 To oRB.Count - 1
            oFlex.Add(oRB.Item(i))
        Next
		
		' TE
        For i = 0 To oTE.Count - 1
            oFlex.Add(oTE.Item(i))
        Next

        oFlex.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

    End Sub
	

	' Build overall object
    Private Sub buildOverall()
        oOvr = New List(Of Player)

        ' QB
        For i = 0 To oQB.Count - 1
            Dim t As Player = New Player
            t.name = oQB.Item(i).name
            t.CSRPoints = oQB.Item(i).CSRPoints
            t.MattsPoints = oQB.Item(i).MattsPoints
            t.NFLPoints = oQB.Item(i).NFLPoints
            t.OvrRank = oQB.Item(i).OvrRank
            t.PosRank = oQB.Item(i).PosRank
            t.Pos = "QB"

            oOvr.Add(t)
        Next

        ' RB
        For i = 0 To oRB.Count - 1
            Dim t As Player = New Player
            t.name = oRB.Item(i).name
            t.CSRPoints = oRB.Item(i).CSRPoints
            t.MattsPoints = oRB.Item(i).MattsPoints
            t.NFLPoints = oRB.Item(i).NFLPoints
            t.OvrRank = oRB.Item(i).OvrRank
            t.PosRank = oRB.Item(i).PosRank
            t.Pos = "RB"

            oOvr.Add(t)
        Next

        oOvr.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged

    End Sub
    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged

    End Sub
    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged

    End Sub
    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox7.SelectedIndexChanged

    End Sub
End Class
