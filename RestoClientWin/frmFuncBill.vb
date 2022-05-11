Public Class frmFuncBill

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnPreBill_Click(sender As System.Object, e As System.EventArgs) Handles btnPreBill.Click
        lblHDR.Text = "Bill Function - [Pre Bill]"
    End Sub

    Private Sub btnJoinBill_Click(sender As System.Object, e As System.EventArgs) Handles btnJoinBill.Click
        lblHDR.Text = "Bill Function - [Join Bill]"
    End Sub

    Private Sub btnSplitBill_Click(sender As System.Object, e As System.EventArgs) Handles btnSplitBill.Click
        lblHDR.Text = "Bill Function - [Split Bill]"
    End Sub

    Private Sub btnTransferBill_Click(sender As System.Object, e As System.EventArgs) Handles btnTransferBill.Click
        lblHDR.Text = "Bill Function - [Transfer Bill]"
    End Sub
End Class