Public Class frmNumPad
    Public pubText As String
    Public pubDigitGrouping As Boolean

    Private Sub fill_NumPad(sender As System.Object)
        'If txtReturnNumber.Text = "" Then txtReturnNumber.Text = ""
        'txtReturnNumber.Text = CDbl(txtReturnNumber.Text).ToString.Trim

        If txtReturnNumber.Text <> "" Then txtReturnNumber.Text = CDbl(txtReturnNumber.Text).ToString.Trim

        If CType(sender, Button).Text = "C" Then
            'txtReturnNumber.Text = "0"
            txtReturnNumber.Text = ""
        ElseIf CType(sender, Button).Text = "<<" Then
            If Microsoft.VisualBasic.Len(txtReturnNumber.Text) - 1 > 0 Then
                txtReturnNumber.Text = Microsoft.VisualBasic.Left(txtReturnNumber.Text, Len(txtReturnNumber.Text) - 1)
            Else
                'txtReturnNumber.Text = "0"
                txtReturnNumber.Text = ""
            End If
            If txtReturnNumber.Text <> "" Then
                If pubDigitGrouping Then
                    txtReturnNumber.Text = Format(CDbl(txtReturnNumber.Text), "###,###,##0")
                End If
            End If
            'label1.Text = ""
        Else
            txtReturnNumber.Text = txtReturnNumber.Text & CType(sender, Button).Text
            If pubDigitGrouping Then
                txtReturnNumber.Text = Format(CDbl(txtReturnNumber.Text), "###,###,##0")
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        pubText = ""
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        pubText = txtReturnNumber.Text
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        fill_NumPad(sender)
    End Sub

    Private Sub ButtonC_Click(sender As System.Object, e As System.EventArgs) Handles ButtonC.Click
        fill_NumPad(sender)
    End Sub

    Private Sub Button0_Click(sender As System.Object, e As System.EventArgs) Handles Button0.Click
        fill_NumPad(sender)
    End Sub

    Private Sub ButtonBck_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBck.Click
        fill_NumPad(sender)
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        fill_NumPad(sender)
    End Sub
End Class