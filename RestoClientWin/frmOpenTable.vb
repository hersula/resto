Public Class frmOpenTable
    Private Sub fill_Btn_Grp()
        Dim ctlW As Integer = 0
        Dim ctlH As Integer = 20
        
        GroupBox1.Controls.Clear()

        Dim dtBtn As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("select top 54 * from trxusedtable order by tableno", CN)
        If Not dtBtn Is Nothing Then dtBtn.Clear()
        DA.Fill(dtBtn)
        DA.Dispose()



        For i As Byte = 0 To dtBtn.Rows.Count - 1    'CDbl(TextBox1.Text)

            ' Dim dtBtnGrp As DataTable = Fill_Data_Group()

            If ctlW > 8 Then
                ctlW = 0
                ctlH = ctlH + 70
            End If

            Dim btn As New Button
            btn.Name = "btn" & i
            btn.Text = "Table [ " & dtBtn.Rows(i).Item("tableno") & " ]"
            btn.Tag = dtBtn.Rows(i).Item("TableSign") & dtBtn.Rows(i).Item("Tableno").ToString.Trim

            If dtBtn.Rows(i).Item("TableSign") = "Z" Then
                btn.BackColor = Color.GreenYellow
                btn.ForeColor = Color.Black
            ElseIf dtBtn.Rows(i).Item("TableSign") = "U" Then
                btn.BackColor = Color.Red
                btn.ForeColor = Color.Ivory
            End If

            btn.Location = New Point(10 + (ctlW * 100), ctlH)
            btn.Size = New Size(100, 70)
            Me.GroupBox1.Controls.Add(btn)

            AddHandler btn.Click, AddressOf btnTable_Click

            ctlW += 1

        Next

    End Sub

    Private Sub btnTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        nSignTable = CType(sender, Button).Tag.ToString.Substring(0, 1)
        nTableNumber = CType(sender, Button).Tag.ToString.Substring(1)


        If nSignTable = "Z" And txtGuestname.Text = "" Then    'new table
            MessageBox.Show("Warning......" & vbCrLf & vbCrLf & "Guest Name can not be EMPTY....")
            Exit Sub
        End If



        If CN Is Nothing Then
            CN = New SqlClient.SqlConnection
            CN.ConnectionString = strConn
            CN.Open()
        Else
            If CN.State = ConnectionState.Closed Then
                CN.ConnectionString = strConn
                CN.Open()
            End If
        End If

        Dim CMD2 As SqlClient.SqlCommand

        Dim isLocked As Boolean = False
        CMD2 = New SqlClient.SqlCommand("select * from trxusedtable where tableno='" & nTableNumber & "'", CN)
        Dim dr As SqlClient.SqlDataReader = CMD2.ExecuteReader
        If dr.Read Then
            If dr.Item("locked") = "Y" Then
                MessageBox.Show("Table [ " & nTableNumber.ToString.Trim & " ] is LOCKED by another, please choose another table or wait until this table is release....")
                isLocked = True
            End If
        End If
        dr.Close()
        If isLocked Then
            fill_Btn_Grp()
            Exit Sub
        End If

        'Dim DR As SqlClient.SqlDataReader
        If nSignTable = "U" Then
            CMD2 = New SqlClient.SqlCommand("select customer from trxordertable where table_number='" & nTableNumber & "'", CN)
            dr = CMD2.ExecuteReader
            If dr.HasRows Then
                If dr.Read Then
                    txtGuestname.Text = dr.Item(0).ToString
                Else
                    txtGuestname.Text = "Table " & nTableNumber.ToString.Trim
                End If
            End If
            DR.Close()
            CMD2.Dispose()
        End If


        Form1.txtTable.Text = nTableNumber
        Form1.txtCustomer.Text = txtGuestname.Text


        Dim CMD As New SqlClient.SqlCommand("update trxusedtable set tablesign='U',locked='Y' where tableno=" & nTableNumber, CN)

        Try
            CMD.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error...." & vbCrLf & vbCrLf & ex.Message)
        End Try

        CMD.Dispose()

        CN.Close()

        Me.Hide()
        Form1.ShowDialog()
        Me.Show()
        fill_Btn_Grp()
    End Sub

    Private Sub frmOpenTable_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If Format(Date.Now, "dd-MMM-yyyy") = "30-Nov-2014" Or Format(Date.Now, "dd-MMM-yyyy") = "30-NOV-2014" Or Format(Date.Now, "dd-MMM-yyyy") = "30-nov-2014" Then
        '    End
        'End If
        'fill_Btn_Grp()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtGuestname.Text = "" Then
            MessageBox.Show("Guest Name can not be EMPTY......")
            Exit Sub
        End If

        If CN Is Nothing Then
            CN = New SqlClient.SqlConnection
            CN.ConnectionString = strConn
            CN.Open()
        Else
            If CN.State = ConnectionState.Closed Then
                CN.ConnectionString = strConn
                CN.Open()
            End If
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("select a.*,b.acct_name from mstuser as a inner join mstacct as b ON a.acct_type=b.acct_type where a.user_id='" & txtUID.Text & "' and a.user_pwd='" & txtPwd.Text & "'", CN)
        If Not DT Is Nothing Then DT.Clear()
        DA.Fill(DT)
        DA.Dispose()
        'CN.Close()
        'CN.Dispose()

        If DT.Rows.Count > 0 Then
            Form1.lblDateTime.Text = Format(Date.Now, "dd MMMM yyyy HH:mm:ss")
            Form1.lblAsUser.Text = txtUID.Text.Trim & " - " & DT.Rows(0).Item("user_name").ToString.Trim
            'lblAcctType.Text = DT.Rows(0).Item("acct_name").ToString.Trim


            DT.Dispose()

            GroupBox1.Visible = True
            fill_Btn_Grp()

        Else
            DT.Dispose()
            MessageBox.Show("Incorrect Username or Password.....")
        End If

        CN.Close()

    End Sub

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        txtUID.Text = ""
        txtPwd.Text = ""
        txtGuestname.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub txtUID_DoubleClick(sender As Object, e As System.EventArgs) Handles txtUID.DoubleClick
        Dim f As New frmKeyboard
        f.Text = "Input Cashier ID...."
        f.TextBox1.PasswordChar = ""
        f.ShowDialog()
        txtUID.Text = f.isiKeyboard
        f.TextBox1.PasswordChar = ""
        f.Close()
        f.Dispose()
    End Sub



    Private Sub txtPwd_DoubleClick(sender As Object, e As System.EventArgs) Handles txtPwd.DoubleClick
        Dim f As New frmKeyboard
        f.Text = "Input Cashier Password...."
        f.TextBox1.PasswordChar = "*"
        f.ShowDialog()
        txtPwd.Text = f.isiKeyboard
        f.TextBox1.PasswordChar = ""
        f.Close()
        f.Dispose()
    End Sub

 

    Private Sub txtGuestname_DoubleClick(sender As Object, e As System.EventArgs) Handles txtGuestname.DoubleClick
        Dim f As New frmKeyboard
        f.Text = "Input Guest Name...."
        f.TextBox1.PasswordChar = ""
        f.ShowDialog()
        txtGuestname.Text = f.isiKeyboard
        f.TextBox1.PasswordChar = ""
        f.Close()
        f.Dispose()
    End Sub

   
    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        fill_Btn_Grp()
    End Sub
  
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        frmFlootEditLayout.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        frmMain.Show()
    End Sub
End Class