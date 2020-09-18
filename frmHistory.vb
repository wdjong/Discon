Public Class frmHistory

    Public Sub Cout(ByRef s As String)
        'Display output on screen
        Const MAXTEXTBOX As Short = 2048

        On Error GoTo errCout
        If s = "CLS" Then
            txtHistory.Text = ""
        Else
            If (txtHistory.Text & s).Length > MAXTEXTBOX Then
                txtHistory.Text = (txtHistory.Text & s).Substring((txtHistory.Text & s).Length - MAXTEXTBOX, MAXTEXTBOX)
            Else
                txtHistory.Text = txtHistory.Text & s
            End If
            System.Windows.Forms.SendKeys.Send("^{END}")
        End If
exitCout:
        Exit Sub
errCout:
        MsgBox("Cout error: " & Err.Description) ' & " " & Err.Number)
    End Sub
End Class