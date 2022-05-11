Public Class frmFuncVoid

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnVoidItems_Click(sender As System.Object, e As System.EventArgs) Handles btnVoidItems.Click
        lblHDR.Text = "Void Function - [Void Items]"
        frmVoidQty.isFlagVoid = "QTY"
        frmVoidQty.ShowDialog()


        Me.Close()
    End Sub

    Private Sub btnVoidALL_Click(sender As System.Object, e As System.EventArgs) Handles btnVoidALL.Click
        lblHDR.Text = "Void Function - [Void ALL]"
        frmVoidALL.ShowDialog()


        Me.Close()
    End Sub


    Private Sub btnVoidPromo_Click(sender As System.Object, e As System.EventArgs) Handles btnVoidPromo.Click
        lblHDR.Text = "Void Function - [Void Promo]"
        frmVoidQty.isFlagVoid = "PROMO"
        frmVoidQty.ShowDialog()


        Me.Close()
    End Sub
End Class