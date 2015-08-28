Imports System.IO

Public Class Main

    Public Shared oWR As List(Of Offense)
    Public Shared oQB As List(Of Offense)
    Public Shared oRB As List(Of Offense)
    Public Shared oTE As List(Of Offense)
    Public Shared oOvr As List(Of Player)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Quarterback
        oQB = readOffense(My.Application.Info.DirectoryPath & "/Tables/QB.csv", 12)
        For i = 0 To oQB.Count - 1
            ListBox2.Items.Add(oQB.Item(i).CSRPoints & vbTab & oQB.Item(i).MattsPoints & vbTab & oQB.Item(i).name)
        Next
        ListBox2.Update()

        ' Wide Recievers
        oWR = readOffense(My.Application.Info.DirectoryPath & "/Tables/WR.csv", 24)
        For i = 0 To oWR.Count - 1
            ListBox3.Items.Add(oWR.Item(i).CSRPoints & vbTab & oWR.Item(i).MattsPoints & vbTab & oWR.Item(i).name)
        Next
        ListBox3.Update()

        ' Running Backs
        oRB = readOffense(My.Application.Info.DirectoryPath & "/Tables/RB.csv", 24)
        For i = 0 To oRB.Count - 1
            ListBox4.Items.Add(oRB.Item(i).CSRPoints & vbTab & oRB.Item(i).MattsPoints & vbTab & oRB.Item(i).name)
        Next
        ListBox4.Update()

        ' Tight Ends
        oTE = readOffense(My.Application.Info.DirectoryPath & "/Tables/TE.csv", 12)
        For i = 0 To oTE.Count - 1
            ListBox5.Items.Add(oTE.Item(i).CSRPoints & vbTab & oTE.Item(i).MattsPoints & vbTab & oTE.Item(i).name)
        Next
        ListBox5.Update()

        ' Overall
        buildOverall()
        For i = 0 To oOvr.Count - 1
            ListBox1.Items.Add(oOvr.Item(i).CSRPoints & vbTab & oOvr.Item(i).Pos & vbTab & oOvr.Item(i).name)
        Next
        ListBox5.Update()


    End Sub

    Private Function readOffense(MyFile As String, RosterCount As Integer) As IList(Of Offense)
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

        ' WR
        For i = 0 To oWR.Count - 1
            Dim t As Player = New Player
            t.name = oWR.Item(i).name
            t.CSRPoints = oWR.Item(i).CSRPoints
            t.MattsPoints = oWR.Item(i).MattsPoints
            t.NFLPoints = oWR.Item(i).NFLPoints
            t.OvrRank = oWR.Item(i).OvrRank
            t.PosRank = oWR.Item(i).PosRank
            t.Pos = "WR"

            oOvr.Add(t)
        Next

        ' TE
        For i = 0 To oTE.Count - 1
            Dim t As Player = New Player
            t.name = oTE.Item(i).name
            t.CSRPoints = oTE.Item(i).CSRPoints
            t.MattsPoints = oTE.Item(i).MattsPoints
            t.NFLPoints = oTE.Item(i).NFLPoints
            t.OvrRank = oTE.Item(i).OvrRank
            t.PosRank = oTE.Item(i).PosRank
            t.Pos = "TE"

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
