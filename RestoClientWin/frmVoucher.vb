Public Class frmVoucher

    Private Sub picCancel_Click(sender As System.Object, e As System.EventArgs) Handles picCancel.Click
        Me.Close()

    End Sub

    Private Sub picOK_Click(sender As System.Object, e As System.EventArgs) Handles picOK.Click



        Me.Close()

    End Sub

    Private Sub lblVcrNo_Click(sender As System.Object, e As System.EventArgs) Handles lblVcrNo.Click

    End Sub

    Private Sub lblVcrNo_DoubleClick(sender As Object, e As System.EventArgs) Handles lblVcrNo.DoubleClick
        frmNumPad.pubDigitGrouping = False
        frmNumPad.ShowDialog()
        lblVcrNo.Text = frmNumPad.pubText
        frmNumPad.Dispose()

    End Sub
End Class