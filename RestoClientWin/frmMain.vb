Public Class frmMain
    Dim dtFloor As New DataTable


    Private Sub fill_floor()
        cekKoneksi()

        Dim DA As New SqlClient.SqlDataAdapter("select * from mstfloor order by floorid", CN)
        dtFloor.Dispose()
        dtFloor = Nothing
        dtFloor = New DataTable
        DA.Fill(dtFloor)
        DA.Dispose()
        DA = Nothing

        cmbFloor.DataSource = dtFloor
        cmbFloor.DisplayMember = dtFloor.Columns("floordesc").ToString
        cmbFloor.ValueMember = dtFloor.Columns("floorid").ToString


    End Sub


    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        setParameter()
        loadLayout(cmbFloor.SelectedValue)
    End Sub

    Private Function cekUsedTable(ByVal lcLocation As String, ByVal lcTableNo As String) As Boolean
        Dim isTerus As Boolean = False
        Dim CMD As New SqlClient.SqlCommand("select top 1 LocationID,Table_number from TrxOrderTable where LocationID='" & lcLocation & "' and table_number='" & lcTableNo & "'", CN)
        Dim DR As SqlClient.SqlDataReader = CMD.ExecuteReader
        If DR.HasRows Then
            If DR.Read Then
                isTerus = True
            Else
                isTerus = False
            End If
        End If
        DR.Close()
        CMD.Dispose()
        DR = Nothing
        CMD = Nothing

        Return isTerus

    End Function

    Private Sub loadLayout(ByVal lcFlor As String)
        cekKoneksi()

        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("select * from mstfloorlayout where floorid='" & lcFlor & "'", CN)
        da.Fill(dt)
        da.Dispose()

        Panel1.Controls.Clear()

        If dt.Rows.Count <= 0 Then Exit Sub

        For i As Byte = 0 To dt.Rows.Count - 1
            If Microsoft.VisualBasic.Left(dt.Rows(i)("btnName"), 6) = "button" Then
                Dim btnLayout As New Button
                btnLayout.Name = dt.Rows(i)("btnName")
                btnLayout.Text = dt.Rows(i)("btnText")
                btnLayout.Tag = dt.Rows(i)("floorid") & "#" & dt.Rows(i)("btnText")

                Dim TableLocation As String()
                TableLocation = Split(btnLayout.Tag, "#")

                If cekUsedTable(TableLocation(0), TableLocation(1)) Then
                    btnLayout.BackColor = Color.Red
                    btnLayout.ForeColor = Color.White
                Else
                    btnLayout.BackColor = Color.FromArgb(128, 255, 128)
                    btnLayout.ForeColor = Color.Black
                End If
                TableLocation = Nothing

                btnLayout.Location = New Point(dt.Rows(i)("btnx"), dt.Rows(i)("btny"))
                btnLayout.Size = New Size(dt.Rows(i)("btnw"), dt.Rows(i)("btnh"))

                btnLayout.BringToFront()

                Dim rc As New clsResizeButton(btnLayout)

                Me.Panel1.Controls.Add(btnLayout)

                AddHandler btnLayout.Click, AddressOf btnLayout_Click
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

            End If


        Next
        'CN.Close()

    End Sub

    Private Sub btnLayout_Click(sender As System.Object, e As System.EventArgs)
        Form1.txtFloorID.Text = cmbFloor.Text
        Form1.txtFloorID.Tag = cmbFloor.SelectedValue
        Form1.txtTable.Text = CType(sender, Button).Text
        Form1.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        fill_floor()

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbFloor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFloor.SelectedIndexChanged

    End Sub

    Private Sub btnLock_Click(sender As System.Object, e As System.EventArgs) Handles btnLock.Click
        frmNumPad.txtReturnNumber.PasswordChar = "@"
        frmNumPad.pubDigitGrouping = False
        frmNumPad.ShowDialog()

        'ToDo Here
        '
        '

        frmLockedScreen.ShowDialog()

        frmLockedScreen.Dispose()

    End Sub

    Private Sub btnLogInOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogInOut.Click
        If LCase(btnLogInOut.Text) = "log in" Then
            frmNumPad.txtReturnNumber.PasswordChar = "@"
            frmNumPad.pubDigitGrouping = False
            frmNumPad.ShowDialog()

            'ToDo Here
            '
            '
            btnLogInOut.Text = "Log Out"
        Else
            frmNumPad.txtReturnNumber.PasswordChar = "@"
            frmNumPad.ShowDialog()

            'ToDo Here
            '
            '
            btnLogInOut.Text = "Log In"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDay.Text = Format(Date.Now, "dddd")
        lblDate.Text = Format(Date.Now, "dd MMM yyyy")
        lblTime.Text = Format(Date.Now, "HH:mm:ss")
    End Sub
End Class