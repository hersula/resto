Public Class frmFlootEditLayout

    Private _isMoved As Boolean
    Private _x As Integer
    Private _y As Integer

    Dim RS As Boolean

    Dim _Object As String



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dim rc As New Class1(Button1)

    End Sub

    Private Sub btnObject_Click(sender As System.Object, e As System.EventArgs) Handles btnObject.Click
        _Object = "button"

    End Sub

    Private Sub btn_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        'If RS Then Exit Sub
        'Dim strString As String
        'strString = "X = " & e.Location.X & vbCrLf & _
        '            "Y = " & e.Location.Y

        'MsgBox(strString)
        ' CType(sender, Button).BringToFront()

    End Sub


    'Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    '    RS = True
    'End Sub

    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    RS = False
    'End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim CN As New SqlClient.SqlConnection
        CN.ConnectionString = "Server=localhost;database=resto;user id=sa;password=sa123456a@;"
        CN.Open()


        Dim strSQL As String
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CN
        cmd.CommandText = "delete mstfloorlayout"
        cmd.ExecuteNonQuery()

        For Each lcBtn As Control In Panel1.Controls
            If Microsoft.VisualBasic.Left(LCase(lcBtn.Name), 6) = "button" Then
                strSQL = "insert into mstfloorlayout(btnName,btnText,btnTag,btnX,btnY,btnW,btnH) values ('" & lcBtn.Name & "','" & lcBtn.Text & "','" & lcBtn.Tag & "'," & lcBtn.Location.X & "," & lcBtn.Location.Y & "," & lcBtn.Size.Width & "," & lcBtn.Size.Height & ")"
                cmd.CommandText = strSQL
                cmd.ExecuteNonQuery()
            End If
        Next

        For Each lclbl As Control In Panel1.Controls
            If Microsoft.VisualBasic.Left(LCase(lclbl.Name), 5) = "label" Then
                strSQL = "insert into mstfloorlayout(btnName,btnText,btnTag,btnX,btnY,btnW,btnH) values ('" & lclbl.Name & "','" & lclbl.Text & "','" & lclbl.Tag & "'," & lclbl.Location.X & "," & lclbl.Location.Y & "," & lclbl.Size.Width & "," & lclbl.Size.Height & ")"
                cmd.CommandText = strSQL
                cmd.ExecuteNonQuery()
            End If
        Next

        CN.Close()

        MessageBox.Show("Saved")
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        loadLayout()
    End Sub

    Private Sub loadLayout()
        Dim CN As New SqlClient.SqlConnection
        CN.ConnectionString = "Server=localhost;database=resto;user id=sa;password=sa123456a@;"
        CN.Open()

        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("select * from mstfloorlayout", CN)
        da.Fill(dt)
        da.Dispose()

        For i As Byte = 0 To dt.Rows.Count - 1
            If Microsoft.VisualBasic.Left(dt.Rows(i)("btnName"), 6) = "button" Then
                Dim btnLayout As New Button
                btnLayout.Name = dt.Rows(i)("btnName")
                btnLayout.Text = dt.Rows(i)("btnText")
                btnLayout.Location = New Point(dt.Rows(i)("btnx"), dt.Rows(i)("btny"))
                btnLayout.Size = New Size(dt.Rows(i)("btnw"), dt.Rows(i)("btnh"))

                btnLayout.BringToFront()

                Dim rc As New clsResizeButton(btnLayout)

                Me.Panel1.Controls.Add(btnLayout)

                AddHandler btnLayout.KeyDown, AddressOf btnLayout_KeyDown
            End If

            If Microsoft.VisualBasic.Left(dt.Rows(i)("btnName"), 5) = "label" Then
                Dim lblLayout As New Label
                lblLayout.Name = dt.Rows(i)("btnName")
                lblLayout.Text = dt.Rows(i)("btnText")
                lblLayout.Location = New Point(dt.Rows(i)("btnx"), dt.Rows(i)("btny"))
                lblLayout.Size = New Size(dt.Rows(i)("btnw"), dt.Rows(i)("btnh"))
                lblLayout.AutoSize = False
                lblLayout.BorderStyle = BorderStyle.FixedSingle

                Dim rc As New clsResizeButton(lblLayout)

                Me.Panel1.Controls.Add(lblLayout)

                AddHandler lblLayout.MouseClick, AddressOf lblLayout_MouseClick
            End If


        Next
        CN.Close()

    End Sub


    Private Sub btnLayout_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            CType(sender, Button).Text = InputBox("Enter Text :")
        ElseIf e.KeyCode = Keys.F3 Then
            Dim dlgColor As New ColorDialog
            dlgColor.ShowDialog()
            CType(sender, Button).BackColor = dlgColor.Color
        End If
    End Sub




    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Dim ctl As Byte = 1
        For Each lclbl As Control In Panel1.Controls
            If Microsoft.VisualBasic.Left(LCase(lclbl.Name), 5) = "label" Then
                ctl = ctl + 1
            End If
        Next

        'If ctl = 0 Then ctl = 1

        Dim lbl As New Label

        lbl.Name = "label" & ctl
        lbl.Text = lbl.Name
        lbl.Location = New Point(5, 5)
        lbl.Size = New Size(150, 150)
        lbl.AutoSize = False
        lbl.BorderStyle = BorderStyle.FixedSingle

        Dim rc As New clsResizeButton(lbl)

        Me.Panel1.Controls.Add(lbl)


        AddHandler lbl.mouseClick, AddressOf lblLayout_MouseClick

    End Sub

    Private Sub lblLayout_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CType(sender, Label).Text = InputBox("Enter Text :")
        End If
    End Sub


    Private Sub Button1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles btnObject.DragDrop

    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btnObject.MouseClick

    End Sub

 
    Private Sub btnObject_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btnObject.MouseUp
        Dim ctl As Byte = 1

        For Each lcBtn As Control In Panel1.Controls
            If Microsoft.VisualBasic.Left(LCase(lcBtn.Name), 6) = "button" Then
                ctl = ctl + 1
            End If
        Next

        'If ctl = 0 Then ctl = 1

        Dim btn As New Button

        btn.Name = "button" & ctl
        btn.Text = btn.Name

        'If e.Y <= Panel1.Location.X + 10 Then
        '    btn.Location = New Point(10, 10)
        'Else
        '    btn.Location = New Point(e.X - (-50), e.Y - 50)
        'End If

        btn.Location = New Point(10, 10)
        btn.Size = New Size(50, 50)

        Dim rc As New clsResizeButton(btn)

        Me.Panel1.Controls.Add(btn)


        '     btnGrpHDR.Location = New Point(3 + (ctlW * 78), ctlH)
        'btnGrpHDR.Size = New Size(78, 78)
        'btnGrpHDR.Text = dtBtnGrp.Rows(i).Item("Name").ToString
        'btnGrpHDR.BackColor = Color.FromArgb(255, 92, 0)
        'btnGrpHDR.Tag = dtBtnGrp.Rows(i).Item("dep").ToString

        'Me.PictureBox2.Controls.Add(btnGrpHDR)
        'AddHandler btn.MouseDown, AddressOf btn_MouseDown
        'AddHandler btn.MouseUp, AddressOf btn_MouseUp
        'AddHandler btn.MouseMove, AddressOf btn_MouseMove
        AddHandler btn.MouseDown, AddressOf btn_MouseDown
        'AddHandler btn.Resize, AddressOf btn_Resize

    End Sub

    Private Sub btn_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CType(sender, Button).Text = InputBox("Enter Text :")
        End If
    End Sub

 
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
