Imports System.IO
Imports MAGIC_12.Globals
Imports MAGIC_12.initialBuild

Public Class Main

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
        For i = 0 To oFlex.Count - 1
            ListBox8.Items.Add(oFlex.Item(i).CSRPoints & vbTab & oFlex.Item(i).Pos & vbTab & oFlex.Item(i).name)
        Next
        ListBox8.Update()


        ' Overall
        buildOverall()
        For i = 0 To oOvr.Count - 1
            ListBox1.Items.Add(oOvr.Item(i).CSRPoints & vbTab & oOvr.Item(i).Pos & vbTab & oOvr.Item(i).name)
        Next
        ListBox5.Update()

        ' Update Overall rank in all lists
        updateOverallRank()

        ' Set initial Selection
        ListBox1.SetSelected(0, True)
    End Sub

    'Overall
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim t As Player = oOvr.Item(ListBox1.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        labelToggle(0)
    End Sub

    ' Quarterback
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim t As Offense = oQB.Item(ListBox2.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        Label12.Text = t.PassingYards
        Label14.Text = t.PassingTD
        Label16.Text = t.PassingINT

        Label26.Text = t.RushingYD
        Label24.Text = t.RushingTD

        Label28.Text = t.RecievingYD
        Label22.Text = t.RecievingTD

        Label34.Text = t.FumbleTD
        Label32.Text = t.twoPT
        Label30.Text = t.Fumble

        labelToggle(1)
    End Sub

    ' Wide Reciever
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim t As Offense = oWR.Item(ListBox3.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        Label12.Text = t.PassingYards
        Label14.Text = t.PassingTD
        Label16.Text = t.PassingINT

        Label26.Text = t.RushingYD
        Label24.Text = t.RushingTD

        Label28.Text = t.RecievingYD
        Label22.Text = t.RecievingTD

        Label34.Text = t.FumbleTD
        Label32.Text = t.twoPT
        Label30.Text = t.Fumble

        labelToggle(1)

    End Sub

    ' Running Back
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        Dim t As Offense = oRB.Item(ListBox4.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        Label12.Text = t.PassingYards
        Label14.Text = t.PassingTD
        Label16.Text = t.PassingINT

        Label26.Text = t.RushingYD
        Label24.Text = t.RushingTD

        Label28.Text = t.RecievingYD
        Label22.Text = t.RecievingTD

        Label34.Text = t.FumbleTD
        Label32.Text = t.twoPT
        Label30.Text = t.Fumble

        labelToggle(1)

    End Sub

    ' Tight End
    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        Dim t As Offense = oTE.Item(ListBox5.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        Label12.Text = t.PassingYards
        Label14.Text = t.PassingTD
        Label16.Text = t.PassingINT

        Label26.Text = t.RushingYD
        Label24.Text = t.RushingTD

        Label28.Text = t.RecievingYD
        Label22.Text = t.RecievingTD

        Label34.Text = t.FumbleTD
        Label32.Text = t.twoPT
        Label30.Text = t.Fumble

        labelToggle(1)

    End Sub

    ' Kicker
    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged
        Dim t As Kicker = oPK.Item(ListBox6.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        labelToggle(1)

    End Sub

    ' Def
    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox7.SelectedIndexChanged
        Dim t As Defense = oDEF.Item(ListBox7.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        labelToggle(1)

    End Sub

    ' Flex
    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged
        Dim t As Offense = oFlex.Item(ListBox8.SelectedIndex)

        Label11.Text = t.Pos

        Label2.Text = t.name
        Label20.Text = t.team
        Label18.Text = t.gamesPlayed

        Label3.Text = t.NFLPoints
        Label5.Text = t.MattsPoints

        Label7.Text = t.OvrRank
        Label9.Text = t.PosRank

        Label12.Text = t.PassingYards
        Label14.Text = t.PassingTD
        Label16.Text = t.PassingINT

        Label26.Text = t.RushingYD
        Label24.Text = t.RushingTD

        Label28.Text = t.RecievingYD
        Label22.Text = t.RecievingTD

        Label34.Text = t.FumbleTD
        Label32.Text = t.twoPT
        Label30.Text = t.Fumble

        labelToggle(1)
    End Sub


    Private Sub labelToggle(isOn As Integer)
        If isOn = 1 Then
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True

            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label25.Visible = True
            Label26.Visible = True
            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            Label35.Visible = True
        Else
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False

            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            Label35.Visible = False
        End If
    End Sub

    Private Sub updateOverallRank()
        For i = 0 To oRB.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oRB.Item(i).name, StringComparison.Ordinal))
            oRB.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oWR.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oWR.Item(i).name, StringComparison.Ordinal))
            oWR.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oTE.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oTE.Item(i).name, StringComparison.Ordinal))
            oTE.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oQB.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oQB.Item(i).name, StringComparison.Ordinal))
            oQB.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oFlex.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oFlex.Item(i).name, StringComparison.Ordinal))
            oFlex.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oPK.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oPK.Item(i).name, StringComparison.Ordinal))
            oPK.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

        For i = 0 To oDEF.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(oDEF.Item(i).name, StringComparison.Ordinal))
            oDEF.Item(i).OvrRank = oOvr.Item(index).OvrRank
        Next

    End Sub
    ' Ovr
    Private Sub oDraft_Click(sender As Object, e As EventArgs) Handles oDraft.Click

    End Sub

    Private Sub oRemove_Click(sender As Object, e As EventArgs) Handles oRemove.Click

    End Sub

    ' QB
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    ' Flex
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

End Class
