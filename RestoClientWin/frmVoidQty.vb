Public Class frmVoidQty
    Public isFlagVoid As String

    Private Sub picCancel_Click(sender As System.Object, e As System.EventArgs) Handles picCancel.Click


        Me.Close()

    End Sub

    Private Sub frmVoidQty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If isFlagVoid = "QTY" Then
            lblHDR.Text = "VOID Items / Qty"
            btnMin.Visible = True
            btnPlus.Visible = True
        Else
            lblHDR.Text = "VOID Promo"
            btnMin.Visible = False
            btnPlus.Visible = False
        End If
    End Sub
End Class