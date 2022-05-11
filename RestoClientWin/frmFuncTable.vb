Public Class frmFuncTable

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSplitTable_Click(sender As System.Object, e As System.EventArgs) Handles btnSplitTable.Click
        lblHDR.Text = "Table Function - [Split Table]"
    End Sub

    Private Sub btnTransferItems_Click(sender As System.Object, e As System.EventArgs) Handles btnTransferItems.Click
        lblHDR.Text = "Table Function - [Transfer Items]"
    End Sub

    Private Sub btnTableRelease_Click(sender As System.Object, e As System.EventArgs) Handles btnTableRelease.Click
        lblHDR.Text = "Table Function - [Table Release]"
    End Sub

    Private Sub btnJoinTable_Click(sender As System.Object, e As System.EventArgs) Handles btnJoinTable.Click
        lblHDR.Text = "Table Function - [Join Table]"
    End Sub

    Private Sub btnMoveTable_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveTable.Click
        lblHDR.Text = "Table Function - [Move Table]"
    End Sub
End Class