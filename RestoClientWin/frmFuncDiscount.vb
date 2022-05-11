Public Class frmFuncDiscount

    Private Sub frmFuncDiscount_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UiTab1.ShowTabs = False
    End Sub

    Private Sub frmFuncDiscount_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        lblHDR.Text = "DISCOUNT ITEM"
        UiTab1.TabPages("tabMain").Selected = True
    End Sub

    Private Sub btnRegular_Click(sender As System.Object, e As System.EventArgs) Handles btnRegular.Click
        UiTab1.TabPages("tabRegular").Selected = True
        lblHDR.Text = "DISCOUNT ITEM [REGULAR]"
    End Sub

    Private Sub btnSpecial_Click(sender As System.Object, e As System.EventArgs) Handles btnSpecial.Click
        UiTab1.TabPages("tabSpecial").Selected = True
        lblHDR.Text = "DISCOUNT ITEM [SPECIAL]"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        lblPersenDisc.Text = btn5.Text
    End Sub

    Private Sub btn10_Click(sender As System.Object, e As System.EventArgs) Handles btn10.Click
        lblPersenDisc.Text = btn10.Text
    End Sub
End Class