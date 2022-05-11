Public Class frmFuncOthers

 
    Private Sub btnPLUViewer_Click(sender As System.Object, e As System.EventArgs) Handles btnPLUViewer.Click
        lblHDR.Text = "Others Function - [PLU Viewer]"
    End Sub
    Private Sub btnSoldOut_Click(sender As System.Object, e As System.EventArgs) Handles btnSoldOut.Click
        lblHDR.Text = "Others Function - [Sold Out]"
    End Sub
    Private Sub btnWaiterSubsitution_Click(sender As System.Object, e As System.EventArgs) Handles btnWaiterSubsitution.Click
        lblHDR.Text = "Others Function - [Waiter Subsitution]"
    End Sub
    Private Sub btnOwerCover_Click(sender As System.Object, e As System.EventArgs) Handles btnOwerCover.Click
        lblHDR.Text = "Others Function - [Owner Cover Operator"
    End Sub
    Private Sub btnViewTrans_Click(sender As System.Object, e As System.EventArgs) Handles btnViewTrans.Click
        lblHDR.Text = "Others Function - [View Transaction]"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class