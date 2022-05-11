Public Class frmLockedScreen

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        frmNumPad.txtReturnNumber.PasswordChar = "@"
        frmNumPad.ShowDialog()

        Me.Close()

    End Sub
End Class
