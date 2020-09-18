Public Class frmPreferences

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Populate form with current settings
        Select Case My.Settings.Player1Hum1Cmp2
            Case 0
                rbP1None.Checked = True
            Case 1
                rbP1Human.Checked = True
            Case 2
                rbP1Comp.Checked = True
        End Select
        Select Case My.Settings.Player2Hum1Cmp2
            Case 0
                rbP2None.Checked = True
            Case 1
                rbP2Human.Checked = True
            Case 2
                rbP2Comp.Checked = True
        End Select
        Select Case My.Settings.Player3Hum1Cmp2
            Case 0
                rbP3None.Checked = True
            Case 1
                rbP3Human.Checked = True
            Case 2
                rbP3Comp.Checked = True
        End Select
        Select Case My.Settings.Player4Hum1Cmp2
            Case 0
                rbP4None.Checked = True
            Case 1
                rbP4Human.Checked = True
            Case 2
                rbP4Comp.Checked = True
        End Select
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub RbP1Human_CheckedChanged(sender As Object, e As EventArgs) Handles rbP1Human.CheckedChanged
        My.Settings.Player1Hum1Cmp2 = 1
    End Sub

    Private Sub RbP1Comp_CheckedChanged(sender As Object, e As EventArgs) Handles rbP1Comp.CheckedChanged
        My.Settings.Player1Hum1Cmp2 = 2
    End Sub

    Private Sub RbP1None_CheckedChanged(sender As Object, e As EventArgs) Handles rbP1None.CheckedChanged
        My.Settings.Player1Hum1Cmp2 = 0
    End Sub

    Private Sub RbP2Human_CheckedChanged(sender As Object, e As EventArgs) Handles rbP2Human.CheckedChanged
        My.Settings.Player2Hum1Cmp2 = 1
    End Sub

    Private Sub RbP2Comp_CheckedChanged(sender As Object, e As EventArgs) Handles rbP2Comp.CheckedChanged
        My.Settings.Player2Hum1Cmp2 = 2
    End Sub

    Private Sub RbP2None_CheckedChanged(sender As Object, e As EventArgs) Handles rbP2None.CheckedChanged
        My.Settings.Player2Hum1Cmp2 = 0
    End Sub

    Private Sub RbP3Human_CheckedChanged(sender As Object, e As EventArgs) Handles rbP3Human.CheckedChanged
        My.Settings.Player3Hum1Cmp2 = 1
    End Sub

    Private Sub RbP3Comp_CheckedChanged(sender As Object, e As EventArgs) Handles rbP3Comp.CheckedChanged
        My.Settings.Player3Hum1Cmp2 = 2
    End Sub

    Private Sub RbP3None_CheckedChanged(sender As Object, e As EventArgs) Handles rbP3None.CheckedChanged
        My.Settings.Player3Hum1Cmp2 = 0
    End Sub

    Private Sub RbP4Human_CheckedChanged(sender As Object, e As EventArgs) Handles rbP4Human.CheckedChanged
        My.Settings.Player4Hum1Cmp2 = 1
    End Sub

    Private Sub RbP4Comp_CheckedChanged(sender As Object, e As EventArgs) Handles rbP4Comp.CheckedChanged
        My.Settings.Player4Hum1Cmp2 = 2
    End Sub

    Private Sub RbP4None_CheckedChanged(sender As Object, e As EventArgs) Handles rbP4None.CheckedChanged
        My.Settings.Player4Hum1Cmp2 = 0
    End Sub
End Class