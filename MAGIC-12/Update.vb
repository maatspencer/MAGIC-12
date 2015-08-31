Imports System.IO
Imports MAGIC_12.Globals
Imports MAGIC_12.initialBuild

Public Class Update

	Public Shared Sub Start(name As String, pos As String, isDraft As Boolean)
		Lists(name)
		globalVars(pos, isDraft)
	End Sub
	
	Private Sub Lists(name As String)
		' Overall
		For i = 0 to oOvr.Count - 1
			Dim index As Integer = oOvr.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oOvr.Items.Remove(index)
				Exit For
			End If
		Next
		
		' QB
		For i = 0 to oQB.Count - 1
			Dim index As Integer = oQB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oQB.Items.Remove(index)
				Exit For
			End If
		Next
		
		' RB
		For i = 0 to oQB.Count - 1
			Dim index As Integer = oRB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oRB.Items.Remove(index)
				Exit For
			End If
		Next
		
		' WR
		For i = 0 to oWR.Count - 1
			Dim index As Integer = oWR.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oWR.Items.Remove(index)
				Exit For
			End If
		Next
		
		' TE
		For i=0 to oTE.Count - 1
			Dim index As Integer = oTE.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oTE.Items.Remove(index)
				Exit For
			End If
		Next
		
		' FLEX
		For i=0 to oFLEX.Count - 1
			Dim index As Integer = oFLEX.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oFLEX.Items.Remove(index)
				Exit For
			End If
		Next
		
		' Kicker
		For i=0 to oPK.Count - 1
			Dim index As Integer = oPK.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oPK.Items.Remove(index)
				Exit For
			End If
		Next
		
		' DEF
		For i=0 to oDEF.Count - 1
			Dim index As Integer = oDEF.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
			If Not index = -1 Then
				oDEF.Items.Remove(index)
				Exit For
			End If
		Next
		
	End Sub
	
	Private Sub globalVars(pos As String, isDraft As Boolean)
		Select Case pos
			case "QB"
				
				
		End Select
	End Sub	
End Class
