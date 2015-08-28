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
