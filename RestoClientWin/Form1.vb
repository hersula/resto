Public Class Form1
 
    Dim pageIDX_Group As Byte
    Dim pageIDX_Group2 As Byte
    Dim pageIDX_DTL As Byte

    Dim Total_Rec_H As Byte = 12
    Dim Total_Rec_D As Byte = 30

    Dim dtMenu As New DataTable

    Dim varMenuGrpHdr As String
    Dim varMenuGrpID As String

    Dim varKP As String
    Dim varPersenDisc As Decimal = 0
    Dim varDiscount As Single = 0

    Dim varIsPriomo As Char
    Dim varPromoDesc As String


    Private Sub orderList()
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

        txtTable.Text = "1"
        If Not DataSet11.Tables("trxordertable") Is Nothing Then DataSet11.Tables("trxordertable").Clear()
        'Dim DA As New SqlClient.SqlDataAdapter("select menu_group_id+menu_id+' - '+menu_name+' - '+catatan as menu_name,itemqty ,dine from TrxOrderTable where table_number=" & txtTable.Text & "", CN)
        Dim DA As New SqlClient.SqlDataAdapter("select * from TrxOrderTable where table_number='" & txtTable.Text & "'", CN)
        DA.Fill(DataSet11, "trxordertable")
        DA.Dispose()

        GridEX1.SetDataBinding(DataSet11, "trxordertable")

        lblTotPurchase.Text = "0"
        lblTotVoucher.Text = "0"
        lblTotDisc.Text = "0"
        lblTotService.Text = "0"
        lblTotTax.Text = "0"
        lblGrandTotal.Text = "0"

        For i As Int16 = 0 To GridEX1.RowCount - 1
            lblTotPurchase.Text = Format(CDbl(lblTotPurchase.Text) + (GridEX1.GetRow(i).Cells("itemQty").Value * GridEX1.GetRow(i).Cells("Price").Value), "###,###,##0")
            lblTotDisc.Text = Format(CDbl(lblTotDisc.Text) + GridEX1.GetRow(i).Cells("Discount").Value, "###,###,##0")


        Next
        lblTotService.Text = Format((CDbl(lblTotPurchase.Text) - CDbl(lblTotDisc.Text)) * _pubValSC, "###,###,##0")
        lblTotTax.Text = Format((CDbl(lblTotPurchase.Text) - CDbl(lblTotDisc.Text) + CDbl(lblTotService.Text)) * _pubValPPn, "###,###,##0")
        lblGrandTotal.Text = Format(CDbl(lblTotPurchase.Text) - CDbl(lblTotDisc.Text) + CDbl(lblTotService.Text) + CDbl(lblTotTax.Text), "###,###,##0")

        If CN.State = ConnectionState.Open Then CN.Close()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CN = New SqlClient.SqlConnection
        CN.ConnectionString = strConn
        CN.Open()
        lblDateTime.Text = Format(Date.Now, "dd MMM yyyy HH:mm:ss")

        pageIDX_Group = 1
        pageIDX_Group2 = 1
        pageIDX_DTL = 1

        fill_Btn_Grp()

        Dim DA As SqlClient.SqlDataAdapter
        DA = New SqlClient.SqlDataAdapter("select * from mstmenuitem order by menu_group_id,menu_id", CN)
        If Not dtMenu Is Nothing Then dtMenu.Clear()
        DA.Fill(dtMenu)
        DA.Dispose()

        orderList()
        Timer1.Enabled = True
    End Sub


    Private Function Fill_Data_Group() As DataTable
        Dim Total_Pages As Byte
        'pageIDX_Group = 1
        Dim CMD As SqlClient.SqlCommand = New SqlClient.SqlCommand
        CMD.CommandText = "pResultGroup"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.Parameters.Add(New SqlClient.SqlParameter("@Total_Rows", SqlDbType.SmallInt)).Direction = ParameterDirection.ReturnValue
        CMD.Parameters.Add(New SqlClient.SqlParameter("@PageNumber", SqlDbType.SmallInt)).Value = pageIDX_Group
        CMD.Parameters.Add(New SqlClient.SqlParameter("@RecPerPage", SqlDbType.SmallInt)).Value = Total_Rec_H

        Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)
        DA.Dispose()
        CMD.Dispose()

        Total_Pages = IIf(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H > Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H), (Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H)) + 1, Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H))
        lblPageGrp.Text = pageIDX_Group.ToString.Trim & " of " & Total_Pages.ToString.Trim
        'CheckPageAll()
        'Tot_Pages = divi
        'lblIdxPageGrp.Text = "Halaman: " & IIf(pageIDX_Group >= Tot_Pages, Tot_Pages, pageIDX_Group) & " / " & Tot_Pages
        'lblIdxPageGrp.Refresh()
        Return dt
    End Function

    Private Function Fill_Data_Group2(ByVal lcMenu_group_hdr As String) As DataTable
        Dim Total_Pages As Byte
        'pageIDX_Group2 = 1
        Dim CMD As SqlClient.SqlCommand = New SqlClient.SqlCommand
        CMD.CommandText = "pResultGroup2"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.Parameters.Add(New SqlClient.SqlParameter("@Total_Rows", SqlDbType.SmallInt)).Direction = ParameterDirection.ReturnValue
        CMD.Parameters.Add(New SqlClient.SqlParameter("@PageNumber", SqlDbType.SmallInt)).Value = pageIDX_Group2
        CMD.Parameters.Add(New SqlClient.SqlParameter("@RecPerPage", SqlDbType.SmallInt)).Value = Total_Rec_D
        CMD.Parameters.Add(New SqlClient.SqlParameter("@menu_group_hdr", SqlDbType.VarChar)).Value = lcMenu_group_hdr.Trim

        Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)
        DA.Dispose()
        CMD.Dispose()

        Total_Pages = IIf(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H > Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H), (Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H)) + 1, Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H))
        lblPageDtl.Text = pageIDX_Group.ToString.Trim & " of " & Total_Pages.ToString.Trim
        varMenuGrpHdr = lcMenu_group_hdr
        'CheckPageAll()
        'Tot_Pages = divi
        'lblIdxPageGrp.Text = "Halaman: " & IIf(pageIDX_Group >= Tot_Pages, Tot_Pages, pageIDX_Group) & " / " & Tot_Pages
        'lblIdxPageGrp.Refresh()
        Return dt
    End Function

    Private Function Fill_Data_Detil(ByVal lcMenu_group_id As String) As DataTable
        Dim Total_Pages As Byte
        'pageIDX_DTL = 1
        Dim CMD As SqlClient.SqlCommand = New SqlClient.SqlCommand
        CMD.CommandText = "pResultDetil"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Connection = CN
        CMD.Parameters.Add(New SqlClient.SqlParameter("@Total_Rows", SqlDbType.SmallInt)).Direction = ParameterDirection.ReturnValue
        CMD.Parameters.Add(New SqlClient.SqlParameter("@PageNumber", SqlDbType.SmallInt)).Value = pageIDX_DTL
        CMD.Parameters.Add(New SqlClient.SqlParameter("@RecPerPage", SqlDbType.SmallInt)).Value = Total_Rec_D
        CMD.Parameters.Add(New SqlClient.SqlParameter("@menu_group_id", SqlDbType.VarChar)).Value = lcMenu_group_id.Trim


        Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)
        DA.Dispose()
        CMD.Dispose()

        Total_Pages = IIf(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H > Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H), (Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H)) + 1, Int(CMD.Parameters.Item("@Total_Rows").Value / Total_Rec_H))
        lblPageDtl.Text = pageIDX_Group.ToString.Trim & " of " & Total_Pages.ToString.Trim
        varMenuGrpID = lcMenu_group_id
        'CheckPageAll()
        'Tot_Pages = divi
        'lblIdxPageGrp.Text = "Halaman: " & IIf(pageIDX_Group >= Tot_Pages, Tot_Pages, pageIDX_Group) & " / " & Tot_Pages
        'lblIdxPageGrp.Refresh()
        Return dt
    End Function


    Private Sub fill_Btn_Grp()
        Dim ctlW As Integer = 0
        Dim ctlH As Integer = 4
        Dim ctlMod As Byte
        Dim bolMod As Boolean

        Panel1.Controls.Clear()

        Dim dtBtn As DataTable = Fill_Data_Group()

        If dtBtn.Rows.Count = 0 Then
            Panel1.Controls.Clear()
            Exit Sub
        End If

        For i As Byte = 0 To dtBtn.Rows.Count - 1    'CDbl(TextBox1.Text)

            ' Dim dtBtnGrp As DataTable = Fill_Data_Group()

            If ctlW > 5 Then
                ctlW = 0
                ctlH = ctlH + 70
            End If

            Dim btn As New Button
            btn.Name = "btn" & i
            btn.Text = dtBtn.Rows(i).Item("Menu_group_name")
            btn.Tag = dtBtn.Rows(i).Item("Menu_group_hdr")
            btn.Location = New Point(3 + (ctlW * 100), ctlH)
            btn.Size = New Size(100, 70)
            btn.Font = New Font(btn.Font.Name.ToString, 11)
            Me.Panel1.Controls.Add(btn)


            '     btnGrpHDR.Location = New Point(3 + (ctlW * 78), ctlH)
            'btnGrpHDR.Size = New Size(78, 78)
            'btnGrpHDR.Text = dtBtnGrp.Rows(i).Item("Name").ToString
            'btnGrpHDR.BackColor = Color.FromArgb(255, 92, 0)
            'btnGrpHDR.Tag = dtBtnGrp.Rows(i).Item("dep").ToString

            'Me.PictureBox2.Controls.Add(btnGrpHDR)
            AddHandler btn.Click, AddressOf btnGrpHdr_Click

            ctlW += 1

        Next

    End Sub


    Private Sub btnGrpHdr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblHdrGrp.Text = CType(sender, Button).Text
        lblGroupDtl.Text = ""
        btnQTY.Text = "0"
        lblMenuItem.Text = ""
        txtCatatan.Text = ""
        btnDine.Text = "IN"

        Panel2.Controls.Clear()

        Dim dt As DataTable = Fill_Data_Group2(CType(sender, Button).Tag)    '@MENU_GROUP_HDR

        Dim ctlW As Integer = 0
        Dim ctlH As Integer = 4
        Dim ctlMod As Byte
        Dim bolMod As Boolean
        Panel2.Controls.Clear()

        If dt.Rows.Count = 0 Then
            Panel2.Controls.Clear()
            Exit Sub
        End If

        For i As Byte = 0 To dt.Rows.Count - 1    'CDbl(TextBox1.Text)

            ' Dim dtBtnGrp As DataTable = Fill_Data_Group()

            If ctlW > 5 Then
                ctlW = 0
                ctlH = ctlH + 70
            End If

            Dim btnD As New Button
            btnD.Name = "btn" & i
            btnD.Text = dt.Rows(i).Item("Menu_group_name")
            btnD.Tag = dt.Rows(i).Item("Menu_group_HDR") & dt.Rows(i).Item("Menu_group_id")    '@MENU_GROUP_HDR+MENU_GROUP_ID = MENU_GROUP_ID YG BARU
            btnD.Location = New Point(3 + (ctlW * 100), ctlH)
            btnD.Size = New Size(100, 70)
            btnD.Font = New Font(btnD.Font.Name.ToString, 11)
            Me.Panel2.Controls.Add(btnD)

            AddHandler btnD.Click, AddressOf btnGrpDtl_Click

            ctlW += 1

        Next
    End Sub

    Private Sub btnGrpDtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblGroupDtl.Text = CType(sender, Button).Text
        Panel2.Controls.Clear()

        Dim dt As DataTable = Fill_Data_Detil(CType(sender, Button).Tag)    '@MENU_GROUP_ID(GRP+ID) FROM MENU-GROUP_HDR REFERENCE

        Dim ctlW As Integer = 0
        Dim ctlH As Integer = 4
        Dim ctlMod As Byte
        Dim bolMod As Boolean
        Panel2.Controls.Clear()

        If dt.Rows.Count = 0 Then
            Panel2.Controls.Clear()
            Exit Sub
        End If

        For i As Byte = 0 To dt.Rows.Count - 1    'CDbl(TextBox1.Text)

            If ctlW > 5 Then
                ctlW = 0
                ctlH = ctlH + 70
            End If

            Dim btnD As New Button
            btnD.Name = "btn" & i
            btnD.Text = dt.Rows(i).Item("Menu_name")
            btnD.Tag = dt.Rows(i).Item("ITEMCODE")
            btnD.Location = New Point(3 + (ctlW * 100), ctlH)
            btnD.Size = New Size(100, 70)
            btnD.Font = New Font(btnD.Font.Name.ToString, 11)
            Me.Panel2.Controls.Add(btnD)

            AddHandler btnD.Click, AddressOf btnGrpDtl2_Click

            ctlW += 1

        Next
    End Sub

    Private Sub btnGrpDtl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblGroupDtl.Text = CType(sender, Button).Text
        If lblMenuItem.Text <> CType(sender, Button).Tag & " - " & CType(sender, Button).Text Then
            btnQTY.Text = "0"
            lblMenuItem.Text = ""
            txtCatatan.Text = ""
            btnDine.Text = "IN"
        End If

        btnQTY.Text = CDbl(btnQTY.Text) + 1
        lblMenuItem.Text = CType(sender, Button).Tag & " - " & CType(sender, Button).Text

    End Sub


    Private Sub btnQTY_Click(sender As System.Object, e As System.EventArgs) Handles btnQTY.Click
        'If btnQTY.Text = "0" Then Exit Sub
        btnQTY.Text = CDbl(btnQTY.Text) - 1
        If btnQTY.Text <= "0" Then
            btnQTY.Text = "0"
            lblMenuItem.Text = ""
            txtCatatan.Text = ""
            btnDine.Text = "IN"
        Else

        End If
    End Sub

    Private Sub btnPosting_Click(sender As System.Object, e As System.EventArgs) Handles btnPosting.Click
        'If btnPosting.Text = "Menu Posting" Or btnPosting.Text = "Menu Posting . . ." Then
        '    Exit Sub
        'End If

        If btnQTY.Text = "0" Then Exit Sub

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


        Dim strSql As String = ""


        '        If nGroupID.Trim <> "" And nMenuID.Trim <> "" Then
        Dim DR As SqlClient.SqlDataReader


     
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = CN

        Try

            Dim varPrice As Integer = 0
            Dim varTotPrice As Integer = 0

            'search price
            cmd.CommandText = "select * from mstmenuitem where menu_group_id='" & lblMenuItem.Text.Substring(0, 5) & "' AND menu_id='" & lblMenuItem.Text.Substring(5, 4) & "'"
            DR = cmd.ExecuteReader
            If DR.HasRows Then
                If DR.Read Then
                    varPrice = DR.Item("price")
                End If
            End If
            DR.Close()
            varTotPrice = CDbl(btnQTY.Text) * varPrice


            strSql = "insert into trxordertable(CabangID,Datapos,LocationID,ComputerID,trx_date,table_number,waiter_id,customer,SeqNo,itemQTY,dine,menu_group_id,menu_id,menu_name,catatan,pairpac,Price,PersenDisc,Discount,TotalPrice,OprID,isPromo,PromoDesc) values " & _
                    "('" & _pubCabangID & "','" & _pubDataposID & "','" & _pubLocationID & "','" & _pubComputerID & "','" & Format(CDate(lblDateTime.Text), "dd MMM yyyy") & "','" & txtTable.Text & "','" & lblAsUser.Text & "','" & txtCustomer.Text & "',dbo.fnSeqNo('" & _pubLocationID & "','" & txtTable.Text & "','" & _pubCurSalesDate & "'), " & _
                    CDbl(btnQTY.Text) & ",'" & btnDine.Text.Trim & "','" & lblMenuItem.Text.Substring(0, 5) & "','" & lblMenuItem.Text.Substring(5, 4) & "','" & lblMenuItem.Text.Substring(12) & "','" & txtCatatan.Text & "',0," & _
                  varPrice & "," & varPersenDisc & "," & varDiscount & "," & varTotPrice & ",'" & _pubOprID & "','" & varIsPriomo & "','" & varPromoDesc & "')"  'sementara di nol kan dulu = " & IIf(bolPac, nPairPac, 0) & "

            cmd.CommandText = strSql   'exec for insert
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            orderList()
            'init_posting()

            'If bolPac Then
            '    gvMenu.Visible = False
            '    gvPaket.Visible = True
            '    ListPaket(nPacID, pacFB)
            '    'btnOrderList.Enabled = False
            'End If
        Catch ex As SqlClient.SqlException
            If CN.State = ConnectionState.Open Then CN.Close()
            MessageBox.Show("Error....." & vbCrLf & vbCrLf & ex.Message)
            'Session("lastPage") = Request.Url.PathAndQuery
            'Response.Redirect("~/error.aspx?message=Please TAKE a menu first before you click Posting Button....")
        Finally
            If CN.State = ConnectionState.Open Then CN.Close()
            initVar()
        End Try

        'Else
        'If CN.State = ConnectionState.Open Then CN.Close()
        'Session("lastPage") = Request.Url.PathAndQuery
        'Response.Redirect("~/error.aspx?message=Item Code [" & btnPosting.Text.Trim & "] failed to fill, Please Repeat this menu item for order ....")
        'End If

    End Sub

    Private Sub btnDine_Click(sender As System.Object, e As System.EventArgs) Handles btnDine.Click
        If btnDine.Text = "IN" Then
            btnDine.Text = "OUT"
        Else
            btnDine.Text = "IN"
        End If
    End Sub

    Private Sub txtTable_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTable.KeyPress
        If e.KeyChar = vbCr Then
            orderList()
        End If
    End Sub

    Private Sub txtTable_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTable.TextChanged

    End Sub


    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
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

        Dim transCN As SqlClient.SqlTransaction
        transCN = CN.BeginTransaction

        Dim CMD As New SqlClient.SqlCommand
        CMD.Connection = CN
        CMD.Transaction = transCN

        Dim isError As Boolean = False
        Dim DT As New DataTable

        Try
            ' '' ''If GridEX1.RowCount = 0 Then
            ' '' ''    '    CMD.Connection = CN
            ' '' ''    CMD.CommandText = "update trxusedtable set tablesign='Z',locked='N' where tableno= " & CDbl(txtTable.Text)
            ' '' ''    CMD.ExecuteNonQuery()
            ' '' ''    transCN.Commit()
            ' '' ''    CMD.Dispose()

            ' '' ''    Me.Close()
            ' '' ''    GC.Collect()
            ' '' ''    frmOpenTable.Show()
            ' '' ''    Exit Sub
            ' '' ''End If




            CMD.CommandText = "select * from trxOrderTable  where posting='N' and locationID = '" & _pubLocationID & "' and table_number='" & txtTable.Text & "'"
            Dim DA As New SqlClient.SqlDataAdapter(CMD)
            If Not DT Is Nothing Then DT.Clear()
            DA.Fill(DT)
            DA.Dispose()


            Dim strSql As String
            Dim mFB As String = ""
            Dim mPrice As Long
            Dim varPostDate As DateTime


            For i As Integer = 0 To DT.Rows.Count - 1
                dtMenu.DefaultView.RowFilter = Nothing
                dtMenu.DefaultView.RowFilter = "menu_group_id='" & DT.Rows(i).Item("menu_group_id").ToString.Trim & "' and menu_id='" & DT.Rows(i).Item("menu_id").ToString.Trim & "'"

                If DT.Rows(i).Item("menu_group_id").ToString.Substring(2, 3) >= "500" And DT.Rows(i).Item("menu_group_id").ToString.Substring(0, 3) < "600" Then
                    mFB = "B"
                Else
                    mFB = "F"
                End If

                mPrice = 0
                'mPrice = IIf(DT.Rows(i).Item("dine").ToString.Trim = "PKT", 0, dtMenu.DefaultView(0).Item("price"))
                mPrice = IIf(DT.Rows(i).Item("dine").ToString.Trim = "PKT", 0, DT.Rows(i).Item("price"))

                varPostDate = DT.Rows(i).Item("post_date")
                strSql = ""
                strSql = "insert into trxorder(trx_date,table_number,waiter_id,customer,itemQTY,Price,PriceTotal,dine,menu_group_id,menu_id,menu_name,trxsign,catatan,fb,post_date) values "
                strSql = strSql & "('" & Format(DT.Rows(i).Item("trx_date"), "dd-MMM-yyyy") & "'," & DT.Rows(i).Item("table_number") & ",'" & lblAsUser.Text.Substring(0, 10) & "','" & DT.Rows(i).Item("customer").ToString.Trim & "'," & DT.Rows(i).Item("itemQTY") & "," & mPrice & "," & DT.Rows(i).Item("itemQTY") * mPrice & ",'" & DT.Rows(i).Item("dine").ToString.Trim & "',"
                strSql = strSql & "'" & DT.Rows(i).Item("menu_group_id").ToString.Trim & "','" & DT.Rows(i).Item("menu_id").ToString.Trim & "','" & DT.Rows(i).Item("menu_name").ToString.Trim & "','" & IIf(DT.Rows(i).Item("dine").ToString.Trim = "PKT", "P", "") & "','" & DT.Rows(i).Item("catatan").ToString.Trim & "','" & mFB & "','" & varPostDate.ToString("dd MMM yyyy HH:mm:ss.fff") & "')"

                CMD.CommandText = strSql
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()

                If DT.Rows(i).Item("menu_group_id").ToString.Substring(2, 1) <> "6" And DT.Rows(i).Item("menu_group_id").ToString.Substring(0, 1) <> "7" And DT.Rows(i).Item("menu_group_id").ToString.Substring(0, 1) <> "8" Then
                    If nSignTable <> "O" Then    'sign table "O" untuk order
                        'For j As Integer = 0 To DT.Rows(i).Item("itemqty") - 1   'di batalin gak jadi di breakdown detil nya.23-jan-2013 permintaan emi
                        strSql = ""
                        strSql = "insert into trxorder" & mFB & "(trx_date,table_number,waiter_id,customer,itemQTY,dine,menu_group_id,menu_id,menu_name,catatan) values "
                        strSql = strSql & "('" & Format(DT.Rows(i).Item("trx_date"), "dd-MMM-yyyy") & "'," & DT.Rows(i).Item("table_number") & ",'" & lblAsUser.Text.Substring(0, 10) & "','" & DT.Rows(i).Item("customer").ToString.Trim & "'," & DT.Rows(i).Item("itemQTY") & ",'" & DT.Rows(i).Item("dine").ToString.Trim & "',"
                        strSql = strSql & "'" & DT.Rows(i).Item("menu_group_id").ToString.Trim & "','" & DT.Rows(i).Item("menu_id").ToString.Trim & "','" & DT.Rows(i).Item("menu_name").ToString.Trim & "','" & DT.Rows(i).Item("catatan").ToString.Trim & "')"

                        CMD.CommandText = strSql
                        CMD.CommandType = CommandType.Text
                        CMD.ExecuteNonQuery()
                        'Next
                    End If
                End If


            Next

            'CMD.CommandText = "delete from trxordertable where table_number=" & txtTable.Text & " and waiter_id='" & Left(lblWaiter.Text, 10) & "'"
            'CMD.ExecuteNonQuery()

            CMD.CommandText = "update trxordertable set posting='Y' where table_number=" & txtTable.Text
            CMD.ExecuteNonQuery()

            CMD.CommandText = "update trxusedtable set locked='N' where tableno= " & CDbl(txtTable.Text)
            CMD.ExecuteNonQuery()
            'CMD.CommandText = "select * from trxordertable where table_number=" & txtTable.Text
            'Dim DR As SqlClient.SqlDataReader
            'DR = CMD.ExecuteReader
            'If DR.Read Then
            '    DT.DefaultView.RowFilter
            'End If

            transCN.Commit()


        Catch ex As Exception
            isError = True
            transCN.Rollback()
            MessageBox.Show("Error....." & vbCrLf & vbCrLf & ex.Message)

        Finally
            CMD.Dispose()
            DT.Dispose()

            transCN.Dispose()

            CMD = New SqlClient.SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "delete from trxordertable where menu_group_id='' or menu_id=''"
            CMD.ExecuteNonQuery()
            CMD.Dispose()

            GC.Collect()

            If Not isError Then
                Me.Close()
                frmMain.Show()
                ' nnt di pake ke table list 
            End If

            If CN.State = ConnectionState.Open Then CN.Close()

        End Try

    End Sub

 

    Private Sub initVar()
        btnQTY.Text = "0"
        lblMenuItem.Text = ""
        txtCatatan.Text = ""
        btnDine.Text = "IN"

    End Sub

  
    Private Sub btnUP_Click(sender As System.Object, e As System.EventArgs) Handles btnUP.Click
        If GridEX1.RowCount = 0 Then Exit Sub

        Try
            GridEX1.Focus()
            GridEX1.MovePrevious()
        Catch ex As Exception
            GridEX1.MoveFirst()
        End Try
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        If GridEX1.RowCount = 0 Then Exit Sub
        Try
            GridEX1.Focus()
            GridEX1.MoveNext()

        Catch ex As Exception
            GridEX1.MoveLast()
        End Try

    End Sub

    Private Sub btnGrpPrev_Click(sender As System.Object, e As System.EventArgs) Handles btnGrpPrev.Click
        pageIDX_Group = pageIDX_Group - 1
        If pageIDX_Group = 0 Then pageIDX_Group = 1

        fill_Btn_Grp()

        lblPageGrp.Text = pageIDX_Group.ToString.Trim & " of " & lblPageGrp.Text.Substring(5, 1)
    End Sub

    Private Sub btnGrpNext_Click(sender As System.Object, e As System.EventArgs) Handles btnGrpNext.Click
        pageIDX_Group = pageIDX_Group + 1
        If pageIDX_Group > lblPageGrp.Text.Substring(5, 1) Then pageIDX_Group = lblPageGrp.Text.Substring(5, 1)

        fill_Btn_Grp()

        lblPageGrp.Text = pageIDX_Group.ToString.Trim & " of " & lblPageGrp.Text.Substring(5, 1)
    End Sub

    Private Sub btnDtlPrev_Click(sender As System.Object, e As System.EventArgs) Handles btnDtlPrev.Click

    End Sub

    Private Sub txtCatatan_DoubleClick(sender As Object, e As System.EventArgs) Handles txtCatatan.DoubleClick
        Dim f As New frmKeyboard
        f.Text = "Input Order Note....."
        f.ShowDialog()
        txtCatatan.Text = f.isiKeyboard.Trim
        f.Close()
        f.Dispose()

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'If CN Is Nothing Then
        '    CN = New SqlClient.SqlConnection
        '    CN.ConnectionString = strConn
        '    CN.Open()
        'Else
        '    If CN.State = ConnectionState.Closed Then
        '        CN.ConnectionString = strConn
        '        CN.Open()
        '    End If
        'End If

        'Dim cmd As New SqlClient.SqlCommand("delete trxordertable where posting='N' and table_number='" & txtTable.Text & "'")
        'cmd.Connection = CN
        'cmd.ExecuteNonQuery()

        'If GridEX1.RowCount = 0 Then
        '    cmd.CommandText = "update trxusedtable set tablesign = 'Z',locked='N' where tableno = '" & txtTable.Text & "'"
        'Else
        '    cmd.CommandText = "update trxusedtable set locked = 'N' where tableno = '" & txtTable.Text & "'"
        'End If

        'cmd.ExecuteNonQuery()

        'cmd.Dispose()

        'If CN.State = ConnectionState.Open Then CN.Close()

        Me.Close()
        GC.Collect()
        frmMain.Show()

    End Sub

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnMainTable_Click(sender As System.Object, e As System.EventArgs) Handles btnMainTable.Click
        frmFuncTable.ShowDialog()
        'Todo
        'here

        frmFuncTable.Dispose()

    End Sub

    Private Sub btnMainVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnMainVoid.Click
        frmFuncVoid.ShowDialog()
        'Todo
        'here

        frmFuncVoid.Dispose()

    End Sub

    Private Sub btnMainBill_Click(sender As System.Object, e As System.EventArgs) Handles btnMainBill.Click
        frmFuncBill.ShowDialog()
        'Todo
        'here

        frmFuncBill.Dispose()

    End Sub

    Private Sub btnMainOthers_Click(sender As System.Object, e As System.EventArgs) Handles btnMainOthers.Click
        frmFuncOthers.ShowDialog()
        'Todo
        'here

        frmFuncOthers.Dispose()

    End Sub

    Private Sub picOthersTrans_Click(sender As System.Object, e As System.EventArgs) Handles picOthersTrans.Click
        btnMainOthers_Click(Nothing, Nothing)

    End Sub

    Private Sub picBillFunc_Click(sender As System.Object, e As System.EventArgs) Handles picBillFunc.Click
        btnMainBill_Click(Nothing, Nothing)
    End Sub

    Private Sub picReservation_Click(sender As System.Object, e As System.EventArgs) Handles picReservation.Click
        btnMainKeeping_Click(Nothing, Nothing)
    End Sub

    Private Sub btnMainKeeping_Click(sender As System.Object, e As System.EventArgs) Handles btnMainKeeping.Click
        frmFuncKeeping.ShowDialog()
        'Todo
        'here

        frmFuncKeeping.Dispose()

    End Sub

    Private Sub picVoidFunc_Click(sender As System.Object, e As System.EventArgs) Handles picVoidFunc.Click
        btnMainVoid_Click(Nothing, Nothing)
    End Sub

    Private Sub picTableFunc_Click(sender As System.Object, e As System.EventArgs) Handles picTableFunc.Click
        btnMainTable_Click(Nothing, Nothing)
    End Sub

    Private Sub btnMainVoucher_Click(sender As System.Object, e As System.EventArgs) Handles btnMainVoucher.Click
        frmVoucher.ShowDialog()
        'to do here

        frmVoucher.Dispose()



    End Sub

    Private Sub btnMainDiscount_Click(sender As System.Object, e As System.EventArgs) Handles btnMainDiscount.Click
        frmFuncDiscount.ShowDialog()
        'To Do Here
        '
        '
        frmFuncDiscount.Dispose()

    End Sub

    Private Sub btnMainCompliment_Click(sender As System.Object, e As System.EventArgs) Handles btnMainCompliment.Click

    End Sub

    Private Sub btnMainMship_Click(sender As System.Object, e As System.EventArgs) Handles btnMainMship.Click

    End Sub

    Private Sub picMShip_Click(sender As System.Object, e As System.EventArgs) Handles picMShip.Click
        btnMainMship_Click(Nothing, Nothing)
    End Sub

    Private Sub picCompliment_Click(sender As System.Object, e As System.EventArgs) Handles picCompliment.Click
        btnMainCompliment_Click(Nothing, Nothing)
    End Sub

    Private Sub picDiscount_Click(sender As System.Object, e As System.EventArgs) Handles picDiscount.Click
        btnMainDiscount_Click(Nothing, Nothing)
    End Sub

    Private Sub picVoucher_Click(sender As System.Object, e As System.EventArgs) Handles picVoucher.Click
        btnMainVoucher_Click(Nothing, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
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

        If GridEX1.RowCount = 0 Then Exit Sub

        Try
            If GridEX1.GetValue("posting") = "Y" Then
                MessageBox.Show("Posted Order can't be Deleting.... Please Cantact Your Supervisor ..." & vbCrLf & vbCrLf & _
                                "[ " & GridEX1.GetValue("menu_name") & " ]")
            Else
                Dim strSQL As String = ""
                If GridEX1.GetValue("menu_group_id").ToString.Substring(2, 1) = "7" Then
                    strSQL = "delete from trxordertable where table_number='" & txtTable.Text & "' AND pairpac IN (select top 1 pairpac from trxordertable where table_number='" & txtTable.Text & "' and menu_group_id+menu_id='" & GridEX1.GetValue("menu_group_id").ToString.Trim & GridEX1.GetValue("menu_id").ToString.Trim & "' and catatan='" & GridEX1.GetValue("catatan").ToString.Trim & "' and dine='" & GridEX1.GetValue("dine").ToString.Trim & "')"
                Else
                    strSQL = "delete from trxordertable where rowguid IN (select top 1 rowguid from trxordertable where table_number='" & txtTable.Text & "' and menu_group_id+menu_id='" & GridEX1.GetValue("menu_group_id").ToString.Trim & GridEX1.GetValue("menu_id").ToString.Trim & "' and catatan='" & GridEX1.GetValue("catatan").ToString.Trim & "' and dine='" & GridEX1.GetValue("dine").ToString.Trim & "')"
                End If

                Dim CMD As New SqlClient.SqlCommand(strSQL, CN)
                CMD.ExecuteNonQuery()

                CMD.Dispose()

                orderList()
            End If
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error...." & vbCrLf & vbCrLf & ex.Message)
        Finally
            If CN.State = ConnectionState.Open Then CN.Close()

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Format(Date.Now, "dd MMM yyyy HH:mm:ss")
    End Sub

    Private Sub btnDtlNext_Click(sender As System.Object, e As System.EventArgs) Handles btnDtlNext.Click

    End Sub
End Class
