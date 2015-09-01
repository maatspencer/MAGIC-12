Imports System.IO
Imports MAGIC_12.Globals
Imports MAGIC_12.initialBuild

Public Class Update

    Public Shared Sub Start(name As String, pos As String, isDraft As Boolean)
        globalVars(pos, isDraft)
        CSRValues()
        Lists(name)
    End Sub
	
    Private Shared Sub Lists(name As String)
        ' Overall
        For i = 0 To oOvr.Count - 1
            Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oOvr.RemoveAt(index)
                Exit For
            End If
        Next

        ' QB
        For i = 0 To oQB.Count - 1
            Dim index As Integer = oQB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oQB.RemoveAt(index)
                Exit For
            End If
        Next

        oQB.Sort(Function(x, y) y.MattsPoints.CompareTo(x.MattsPoints))

        For i = 0 To oQB.Count - 1
            oQB.Item(i).CSRPoints = oQB.Item(i).MattsPoints() - oQB.Item(cQB - 1).MattsPoints
        Next

        oQB.Sort(Function(x, y) y.CSRPoints.CompareTo(x.CSRPoints))

        For i = 0 To oQB.Count - 1
            oQB.Item(i).PosRank = i + 1
        Next

        ' RB
        For i = 0 To oQB.Count - 1
            Dim index As Integer = oRB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oRB.RemoveAt(index)
                Exit For
            End If
        Next

        ' WR
        For i = 0 To oWR.Count - 1
            Dim index As Integer = oWR.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oWR.RemoveAt(index)
                Exit For
            End If
        Next

        ' TE
        For i = 0 To oTE.Count - 1
            Dim index As Integer = oTE.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oTE.RemoveAt(index)
                Exit For
            End If
        Next

        ' FLEX
        For i = 0 To oFlex.Count - 1
            Dim index As Integer = oFlex.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oFlex.RemoveAt(index)
                Exit For
            End If
        Next

        ' Kicker
        For i = 0 To oPK.Count - 1
            Dim index As Integer = oPK.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oPK.RemoveAt(index)
                Exit For
            End If
        Next

        ' DEF
        For i = 0 To oDEF.Count - 1
            Dim index As Integer = oDEF.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oDEF.RemoveAt(index)
                Exit For
            End If
        Next



    End Sub
	
    Private Shared Sub globalVars(pos As String, isDraft As Boolean)
        Select Case pos
            Case "QB"
                If isDraft Then
                    mQB += 1
                    aQB += 1
                Else
                    aQB += 1
                End If
            Case "WR"
                If isDraft Then
                    mWR += 1
                    aWR += 1
                Else
                    aWR += 1
                End If
            Case "RB"
                If isDraft Then
                    mRB += 1
                    aRB += 1
                Else
                    aRB += 1
                End If
            Case "TE"
                If isDraft Then
                    mTE += 1
                    aTE += 1
                Else
                    aTE += 1
                End If
            Case "PK"
                If isDraft Then
                    mPK += 1
                    aPK += 1
                Else
                    aPK += 1
                End If
            Case "DEF"
                If isDraft Then
                    mDEF += 1
                    aDEF += 1
                Else
                    aDEF += 1
                End If
        End Select

        If isDraft Then
            mRoster += 1
            aRoster += 1
        Else
            aRoster += 1
        End If
    End Sub

    Private Shared Sub CSRValues()
        ' Check for starters
        If mRoster < 8 Then
            cQB = 12 - aQB
            cPK = 12 - aPK
            cDEF = 12 - aDEF
            cFLEX = 60 - aFLEX
        End If
    End Sub
End Class
