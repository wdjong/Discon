Public Class frmPreferences

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Populate form with current settings
        chkPlayer1.Checked = My.Settings.Player1Human
        chkPlayer2.Checked = My.Settings.Player2Human
        chkPlayer3.Checked = My.Settings.Player3Human
        chkPlayer4.Checked = My.Settings.Player4Human
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ' Update Settings.settings
        My.Settings.Player1Human = chkPlayer1.Checked
        My.Settings.Player2Human = chkPlayer2.Checked
        My.Settings.Player3Human = chkPlayer3.Checked
        My.Settings.Player4Human = chkPlayer4.Checked
        My.Settings.Save()
        Me.Close()
    End Sub

End Class