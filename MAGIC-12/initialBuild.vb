Imports System.IO
Imports MAGIC_12.Globals

Public Class initialBuild
    ' Read CSV file to Offense Object
    Public Shared Function readOffense(MyFile As String, RosterCount As Integer, pos As String) As IList(Of Offense)
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
    Public Shared Function readDefense(MyFile As String, RosterCount As Integer) As IList(Of Defense)
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
    Public Shared Function readKicker(MyFile As String, RosterCount As Integer) As IList(Of Kicker)
        ' Loop Variables
        Dim CurrentLine As String = ""
        Dim LinetoWrite As String = ""
        Dim Count As Integer = 0

        Dim o As List(Of Kicker) = New List(Of Kicker)

        Using sr As StreamReader = New StreamReader(MyFile)
            CurrentLine = sr.ReadLine
            Do While (Not CurrentLine Is Nothing)
                Dim t As Kicker = New Kicker
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
    Public Shared Sub buildFlex()
        oFlex = New List(Of Offense)

        ' WR
        For i = 0 To oWR.Count - 1
            oFlex.Add(oWR.Item(i))
        Next

        ' RB
        For i = 0 To oRB.Count - 1
            oFlex.Add(oRB.Item(i))
        Next

        ' TE
        For i = 0 To oTE.Count - 1
            oFlex.Add(oTE.Item(i))
        Next

        oFlex.Sort(Function(x, y) y.MattsPoints.CompareTo(x.MattsPoints))
        For i = 0 To oFlex.Count - 1
            oFlex.Item(i).CSRPoints = oFlex.Item(i).MattsPoints - oFlex.Item(60).MattsPoints
        Next

    End Sub


    ' Build overall object
    Public Shared Sub buildOverall()
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

        ' Flex
        For i = 0 To oFlex.Count - 1
            Dim t As Player = New Player
            t.name = oFlex.Item(i).name
            t.CSRPoints = oFlex.Item(i).CSRPoints
            t.MattsPoints = oFlex.Item(i).MattsPoints
            t.NFLPoints = oFlex.Item(i).NFLPoints
            t.OvrRank = oFlex.Item(i).OvrRank
            t.PosRank = oFlex.Item(i).PosRank
            t.Pos = oFlex.Item(i).Pos

            oOvr.Add(t)
        Next

        ' Kicker
        For i = 0 To oPK.Count - 1
            Dim t As Player = New Player
            t.name = oPK.Item(i).name
            t.CSRPoints = oPK.Item(i).CSRPoints
            t.MattsPoints = oPK.Item(i).MattsPoints
            t.NFLPoints = oPK.Item(i).NFLPoints
            t.OvrRank = oPK.Item(i).OvrRank
            t.PosRank = oPK.Item(i).PosRank
            t.Pos = oPK.Item(i).Pos

            oOvr.Add(t)
        Next

        oOvr.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

    End Sub
End Class
