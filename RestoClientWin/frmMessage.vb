Public Class frmMessage
    Public isReturn As Boolean
    Public isOkButton As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        isReturn = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        isReturn = True
        Me.Close()
    End Sub

    Private Sub frmMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnOK.Visible = isOkButton
    End Sub
End Class