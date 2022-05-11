Public Class frmKeyboard
    Public isiKeyboard As String = ""
    Dim isShift As Boolean = False
    Public judul As String = "Form Input"

    Private Sub frmNumPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = judul
        shiftmode()
        TextBox1.Text = isiKeyboard.Trim
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isShift = IIf(isShift = False, True, False)
        shiftmode()
        'Button1.Text = IIf(isShift = False, "Shift : OFF", "Shift : ON")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        isiKeyboard = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub pb1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb1.MouseDown
        pb1.Image = IIf(isShift = False, ImageList2.Images.Item(0), ImageList2.Images.Item(22))
    End Sub

    Private Sub pb1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb1.MouseUp
        pb1.Image = IIf(isShift = False, ImageList1.Images.Item(0), ImageList1.Images.Item(22))
    End Sub

    Private Sub pb2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb2.MouseDown
        pb2.Image = IIf(isShift = False, ImageList2.Images.Item(1), ImageList2.Images.Item(23))
    End Sub

    Private Sub pb2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb2.MouseUp
        pb2.Image = IIf(isShift = False, ImageList1.Images.Item(1), ImageList1.Images.Item(23))
    End Sub

    Private Sub pb3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb3.MouseDown
        pb3.Image = IIf(isShift = False, ImageList2.Images.Item(2), ImageList2.Images.Item(24))
    End Sub

    Private Sub pb3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb3.MouseUp
        pb3.Image = IIf(isShift = False, ImageList1.Images.Item(2), ImageList1.Images.Item(24))
    End Sub

    Private Sub pb4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb4.MouseDown
        pb4.Image = IIf(isShift = False, ImageList2.Images.Item(3), ImageList2.Images.Item(25))
    End Sub

    Private Sub pb4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb4.MouseUp
        pb4.Image = IIf(isShift = False, ImageList1.Images.Item(3), ImageList1.Images.Item(25))
    End Sub

    Private Sub pb5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb5.MouseDown
        pb5.Image = IIf(isShift = False, ImageList2.Images.Item(4), ImageList2.Images.Item(26))
    End Sub

    Private Sub pb5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb5.MouseUp
        pb5.Image = IIf(isShift = False, ImageList1.Images.Item(4), ImageList1.Images.Item(26))
    End Sub

    Private Sub pb6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb6.MouseDown
        pb6.Image = IIf(isShift = False, ImageList2.Images.Item(5), ImageList2.Images.Item(27))
    End Sub

    Private Sub pb6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb6.MouseUp
        pb6.Image = IIf(isShift = False, ImageList1.Images.Item(5), ImageList1.Images.Item(27))
    End Sub

    Private Sub pb7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb7.MouseDown
        pb7.Image = IIf(isShift = False, ImageList2.Images.Item(6), ImageList2.Images.Item(28))
    End Sub

    Private Sub pb7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb7.MouseUp
        pb7.Image = IIf(isShift = False, ImageList1.Images.Item(6), ImageList1.Images.Item(28))
    End Sub

    Private Sub pb8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb8.MouseDown
        pb8.Image = IIf(isShift = False, ImageList2.Images.Item(7), ImageList2.Images.Item(29))
    End Sub

    Private Sub pb8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb8.MouseUp
        pb8.Image = IIf(isShift = False, ImageList1.Images.Item(7), ImageList1.Images.Item(29))
    End Sub

    Private Sub pb9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb9.MouseDown
        pb9.Image = IIf(isShift = False, ImageList2.Images.Item(8), ImageList2.Images.Item(30))
    End Sub

    Private Sub pb9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb9.MouseUp
        pb9.Image = IIf(isShift = False, ImageList1.Images.Item(8), ImageList1.Images.Item(30))
    End Sub

    Private Sub pb0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb0.MouseDown
        pb0.Image = IIf(isShift = False, ImageList2.Images.Item(9), ImageList2.Images.Item(31))
    End Sub

    Private Sub pb0_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pb0.MouseUp
        pb0.Image = IIf(isShift = False, ImageList1.Images.Item(9), ImageList1.Images.Item(31))
    End Sub

    Private Sub pba_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA.MouseDown
        pbA.Image = ImageList4.Images.Item(0)
    End Sub

    Private Sub pba_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA.MouseUp
        pbA.Image = ImageList3.Images.Item(0)
    End Sub

    Private Sub pbb_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB.MouseDown
        pbB.Image = ImageList4.Images.Item(1)
    End Sub

    Private Sub pbb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB.MouseUp
        pbB.Image = ImageList3.Images.Item(1)
    End Sub

    Private Sub pbc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC.MouseDown
        pbC.Image = ImageList4.Images.Item(2)
    End Sub

    Private Sub pbc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC.MouseUp
        pbC.Image = ImageList3.Images.Item(2)
    End Sub

    Private Sub pbd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD.MouseDown
        pbD.Image = ImageList4.Images.Item(3)
    End Sub

    Private Sub pbd_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD.MouseUp
        pbD.Image = ImageList3.Images.Item(3)
    End Sub

    Private Sub pbe_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE.MouseDown
        pbE.Image = ImageList4.Images.Item(4)
    End Sub

    Private Sub pbe_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE.MouseUp
        pbE.Image = ImageList3.Images.Item(4)
    End Sub

    Private Sub pbf_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF.MouseDown
        pbF.Image = ImageList4.Images.Item(5)
    End Sub

    Private Sub pbf_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF.MouseUp
        pbF.Image = ImageList3.Images.Item(5)
    End Sub

    Private Sub pbg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG.MouseDown
        pbG.Image = ImageList4.Images.Item(6)
    End Sub

    Private Sub pbg_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG.MouseUp
        pbG.Image = ImageList3.Images.Item(6)
    End Sub

    Private Sub pbh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH.MouseDown
        pbH.Image = ImageList4.Images.Item(7)
    End Sub

    Private Sub pbh_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH.MouseUp
        pbH.Image = ImageList3.Images.Item(7)
    End Sub

    Private Sub pbi_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI.MouseDown
        pbI.Image = ImageList4.Images.Item(8)
    End Sub

    Private Sub pbi_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI.MouseUp
        pbI.Image = ImageList3.Images.Item(8)
    End Sub

    Private Sub pbj_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbJ.MouseDown
        pbJ.Image = ImageList4.Images.Item(9)
    End Sub

    Private Sub pbj_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbJ.MouseUp
        pbJ.Image = ImageList3.Images.Item(9)
    End Sub

    Private Sub pbk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbK.MouseDown
        pbK.Image = ImageList4.Images.Item(10)
    End Sub

    Private Sub pbk_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbK.MouseUp
        pbK.Image = ImageList3.Images.Item(10)
    End Sub

    Private Sub pbl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbL.MouseDown
        pbL.Image = ImageList4.Images.Item(11)
    End Sub

    Private Sub pbl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbL.MouseUp
        pbL.Image = ImageList3.Images.Item(11)
    End Sub

    Private Sub pbm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbM.MouseDown
        pbM.Image = ImageList4.Images.Item(12)
    End Sub

    Private Sub pbm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbM.MouseUp
        pbM.Image = ImageList3.Images.Item(12)
    End Sub

    Private Sub pbn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbN.MouseDown
        pbN.Image = ImageList4.Images.Item(13)
    End Sub

    Private Sub pbn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbN.MouseUp
        pbN.Image = ImageList3.Images.Item(13)
    End Sub

    Private Sub pbo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbO.MouseDown
        pbO.Image = ImageList4.Images.Item(14)
    End Sub

    Private Sub pbo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbO.MouseUp
        pbO.Image = ImageList3.Images.Item(14)
    End Sub

    Private Sub pbp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbP.MouseDown
        pbP.Image = ImageList4.Images.Item(15)
    End Sub

    Private Sub pbp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbP.MouseUp
        pbP.Image = ImageList3.Images.Item(15)
    End Sub

    Private Sub pbq_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbQ.MouseDown
        pbQ.Image = ImageList4.Images.Item(16)
    End Sub

    Private Sub pbq_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbQ.MouseUp
        pbQ.Image = ImageList3.Images.Item(16)
    End Sub

    Private Sub pbr_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbR.MouseDown
        pbR.Image = ImageList4.Images.Item(17)
    End Sub

    Private Sub pbr_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbR.MouseUp
        pbR.Image = ImageList3.Images.Item(17)
    End Sub

    Private Sub pbs_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbS.MouseDown
        pbS.Image = ImageList4.Images.Item(18)
    End Sub

    Private Sub pbs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbS.MouseUp
        pbS.Image = ImageList3.Images.Item(18)
    End Sub

    Private Sub pbt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbT.MouseDown
        pbT.Image = ImageList4.Images.Item(19)
    End Sub

    Private Sub pbt_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbT.MouseUp
        pbT.Image = ImageList3.Images.Item(19)
    End Sub

    Private Sub pbu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbU.MouseDown
        pbU.Image = ImageList4.Images.Item(20)
    End Sub

    Private Sub pbu_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbU.MouseUp
        pbU.Image = ImageList3.Images.Item(20)
    End Sub

    Private Sub pbv_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbV.MouseDown
        pbV.Image = ImageList4.Images.Item(21)
    End Sub

    Private Sub pbv_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbV.MouseUp
        pbV.Image = ImageList3.Images.Item(21)
    End Sub

    Private Sub pbw_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbW.MouseDown
        pbW.Image = ImageList4.Images.Item(22)
    End Sub

    Private Sub pbw_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbW.MouseUp
        pbW.Image = ImageList3.Images.Item(22)
    End Sub

    Private Sub pbx_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbX.MouseDown
        pbX.Image = ImageList4.Images.Item(23)
    End Sub

    Private Sub pbx_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbX.MouseUp
        pbX.Image = ImageList3.Images.Item(23)
    End Sub

    Private Sub pby_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbY.MouseDown
        pbY.Image = ImageList4.Images.Item(24)
    End Sub

    Private Sub pby_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbY.MouseUp
        pbY.Image = ImageList3.Images.Item(24)
    End Sub

    Private Sub pbz_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbZ.MouseDown
        pbZ.Image = ImageList4.Images.Item(25)
    End Sub

    Private Sub pbz_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbZ.MouseUp
        pbZ.Image = ImageList3.Images.Item(25)
    End Sub

    Private Sub pbSpace_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbSpace.MouseDown
        pbSpace.Image = ImageList5.Images.Item(1)
    End Sub

    Private Sub pbSpace_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbSpace.MouseUp
        pbSpace.Image = ImageList5.Images.Item(0)
    End Sub

    Private Sub pbBackSpace_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBackSpace.MouseDown
        pbBackSpace.Image = ImageList4.Images.Item(27)
    End Sub

    Private Sub pbBackSpace_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBackSpace.MouseUp
        pbBackSpace.Image = ImageList3.Images.Item(27)
    End Sub

    Private Sub pbtilde_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbtilde.MouseDown
        pbtilde.Image = IIf(isShift = False, ImageList2.Images.Item(10), ImageList2.Images.Item(21))
    End Sub

    Private Sub pbtilde_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbtilde.MouseUp
        pbtilde.Image = IIf(isShift = False, ImageList1.Images.Item(10), ImageList1.Images.Item(21))
    End Sub

    Private Sub pbmin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbmin.MouseDown
        pbmin.Image = IIf(isShift = False, ImageList2.Images.Item(11), ImageList2.Images.Item(32))
    End Sub

    Private Sub pbmin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbmin.MouseUp
        pbmin.Image = IIf(isShift = False, ImageList1.Images.Item(11), ImageList1.Images.Item(32))
    End Sub

    Private Sub pbplus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbplus.MouseDown
        pbplus.Image = IIf(isShift = False, ImageList2.Images.Item(12), ImageList2.Images.Item(33))
    End Sub

    Private Sub pbplus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbplus.MouseUp
        pbplus.Image = IIf(isShift = False, ImageList1.Images.Item(12), ImageList1.Images.Item(33))
    End Sub

    Private Sub pbKb_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKb.MouseDown
        pbKb.Image = IIf(isShift = False, ImageList2.Images.Item(14), ImageList2.Images.Item(35))
    End Sub

    Private Sub pbKb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKb.MouseUp
        pbKb.Image = IIf(isShift = False, ImageList1.Images.Item(14), ImageList1.Images.Item(35))
    End Sub

    Private Sub pbKT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKT.MouseDown
        pbKT.Image = IIf(isShift = False, ImageList2.Images.Item(15), ImageList2.Images.Item(36))
    End Sub

    Private Sub pbKT_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKT.MouseUp
        pbKT.Image = IIf(isShift = False, ImageList1.Images.Item(15), ImageList1.Images.Item(36))
    End Sub

    Private Sub pbt2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbt2.MouseDown
        pbt2.Image = IIf(isShift = False, ImageList2.Images.Item(16), ImageList2.Images.Item(37))
    End Sub

    Private Sub pbt2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbt2.MouseUp
        pbt2.Image = IIf(isShift = False, ImageList1.Images.Item(16), ImageList1.Images.Item(37))
    End Sub

    Private Sub pbptk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbptk.MouseDown
        pbptk.Image = IIf(isShift = False, ImageList2.Images.Item(17), ImageList2.Images.Item(38))
    End Sub

    Private Sub pbptk_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbptk.MouseUp
        pbptk.Image = IIf(isShift = False, ImageList1.Images.Item(17), ImageList1.Images.Item(38))
    End Sub

    Private Sub pbkoma_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbkoma.MouseDown
        pbkoma.Image = IIf(isShift = False, ImageList2.Images.Item(18), ImageList2.Images.Item(39))
    End Sub

    Private Sub pbkoma_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbkoma.MouseUp
        pbkoma.Image = IIf(isShift = False, ImageList1.Images.Item(18), ImageList1.Images.Item(39))
    End Sub

    Private Sub pbtitik_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbtitik.MouseDown
        pbtitik.Image = IIf(isShift = False, ImageList2.Images.Item(19), ImageList2.Images.Item(40))
    End Sub

    Private Sub pbtitik_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbtitik.MouseUp
        pbtitik.Image = IIf(isShift = False, ImageList1.Images.Item(19), ImageList1.Images.Item(40))
    End Sub

    Private Sub pbslash_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbslash.MouseDown
        pbslash.Image = IIf(isShift = False, ImageList2.Images.Item(20), ImageList2.Images.Item(41))
    End Sub

    Private Sub pbslash_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbslash.MouseUp
        pbslash.Image = IIf(isShift = False, ImageList1.Images.Item(20), ImageList1.Images.Item(41))
    End Sub

    Private Sub PBShift_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBShift.MouseDown
        PBShift.Image = IIf(isShift = False, ImageList4.Images.Item(28), ImageList4.Images.Item(29))
    End Sub

    Private Sub PBShift_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBShift.MouseUp
        PBShift.Image = IIf(isShift = False, ImageList3.Images.Item(28), ImageList3.Images.Item(29))
    End Sub
    '---limit procedure for image

    Private Sub pbtilde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtilde.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "`", "~")
    End Sub

    Private Sub pb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "1", "!")
    End Sub

    Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb2.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "2", "@")
    End Sub

    Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb3.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "3", "#")
    End Sub

    Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb4.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "4", "$")
    End Sub

    Private Sub pb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "5", "%")
    End Sub

    Private Sub pb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb6.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "6", "^")
    End Sub

    Private Sub pb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb7.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "7", Chr(38))
    End Sub

    Private Sub pb8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb8.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "8", "*")
    End Sub

    Private Sub pb9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb9.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "9", "(")
    End Sub

    Private Sub pb0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb0.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "0", ")")
    End Sub

    Private Sub pbA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbA.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "a", "A")
    End Sub

    Private Sub pbB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbB.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "b", "B")
    End Sub

    Private Sub pbC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbC.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "c", "C")
    End Sub

    Private Sub pbD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbD.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "d", "D")
    End Sub

    Private Sub pbE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbE.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "e", "E")
    End Sub

    Private Sub pbF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbF.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "f", "F")
    End Sub

    Private Sub pbG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbG.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "g", "G")
    End Sub

    Private Sub pbH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbH.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "h", "H")
    End Sub

    Private Sub pbI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbI.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "i", "I")
    End Sub

    Private Sub pbJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbJ.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "j", "J")
    End Sub

    Private Sub pbK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbK.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "k", "K")
    End Sub

    Private Sub pbL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbL.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "l", "L")
    End Sub

    Private Sub pbM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbM.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "m", "M")
    End Sub

    Private Sub pbN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbN.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "n", "N")
    End Sub

    Private Sub pbO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbO.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "o", "O")
    End Sub

    Private Sub pbP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbP.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "p", "P")
    End Sub

    Private Sub pbQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbQ.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "q", "Q")
    End Sub

    Private Sub pbR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbR.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "r", "R")
    End Sub

    Private Sub pbS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbS.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "s", "S")
    End Sub

    Private Sub pbT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbT.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "t", "T")
    End Sub

    Private Sub pbU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbU.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "u", "U")
    End Sub

    Private Sub pbV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbV.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "v", "V")
    End Sub

    Private Sub pbW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbW.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "w", "W")
    End Sub

    Private Sub pbX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbX.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "x", "X")
    End Sub

    Private Sub pbY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbY.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "y", "Y")
    End Sub

    Private Sub pbZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbZ.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "z", "Z")
    End Sub

    Private Sub pbmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmin.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "-", "_")
    End Sub

    Private Sub pbplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbplus.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "=", "+")
    End Sub

    Private Sub pbKb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbKb.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "[", "{")
    End Sub

    Private Sub pbKT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbKT.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "]", "}")
    End Sub

    Private Sub pbt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbt2.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, ";", ":")
    End Sub

    Private Sub pbptk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbptk.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, Chr(39), Chr(34))
    End Sub

    Private Sub pbkoma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbkoma.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, ",", "<")
    End Sub

    Private Sub pbtitik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbtitik.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, ".", ">")
    End Sub

    Private Sub pbslash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbslash.Click
        TextBox1.Text = TextBox1.Text + IIf(isShift = False, "/", "?")
    End Sub

    Private Sub PBShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBShift.Click
        isShift = IIf(isShift = False, True, False)
        shiftmode()
    End Sub

    Private Sub pbSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSpace.Click
        TextBox1.Text = TextBox1.Text + " "
    End Sub

    Private Sub pbBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBackSpace.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub

    Sub shiftmode()
        If isShift = True Then
            pbtilde.Image = ImageList1.Images.Item(21)
            pb1.Image = ImageList1.Images.Item(22)
            pb2.Image = ImageList1.Images.Item(23)
            pb3.Image = ImageList1.Images.Item(24)
            pb4.Image = ImageList1.Images.Item(25)
            pb5.Image = ImageList1.Images.Item(26)
            pb6.Image = ImageList1.Images.Item(27)
            pb7.Image = ImageList1.Images.Item(28)
            pb8.Image = ImageList1.Images.Item(29)
            pb9.Image = ImageList1.Images.Item(30)
            pb0.Image = ImageList1.Images.Item(31)
            pbmin.Image = ImageList1.Images.Item(32)
            pbplus.Image = ImageList1.Images.Item(33)
            pbKb.Image = ImageList1.Images.Item(35)
            pbKT.Image = ImageList1.Images.Item(36)
            pbt2.Image = ImageList1.Images.Item(37)
            pbptk.Image = ImageList1.Images.Item(38)
            pbkoma.Image = ImageList1.Images.Item(39)
            pbtitik.Image = ImageList1.Images.Item(40)
            pbslash.Image = ImageList1.Images.Item(41)
        Else
            pb1.Image = ImageList1.Images.Item(0)
            pb2.Image = ImageList1.Images.Item(1)
            pb3.Image = ImageList1.Images.Item(2)
            pb4.Image = ImageList1.Images.Item(3)
            pb5.Image = ImageList1.Images.Item(4)
            pb6.Image = ImageList1.Images.Item(5)
            pb7.Image = ImageList1.Images.Item(6)
            pb8.Image = ImageList1.Images.Item(7)
            pb9.Image = ImageList1.Images.Item(8)
            pb0.Image = ImageList1.Images.Item(9)
            pbtilde.Image = ImageList1.Images.Item(10)
            pbmin.Image = ImageList1.Images.Item(11)
            pbplus.Image = ImageList1.Images.Item(12)
            pbKb.Image = ImageList1.Images.Item(14)
            pbKT.Image = ImageList1.Images.Item(15)
            pbt2.Image = ImageList1.Images.Item(16)
            pbptk.Image = ImageList1.Images.Item(17)
            pbkoma.Image = ImageList1.Images.Item(18)
            pbtitik.Image = ImageList1.Images.Item(19)
            pbslash.Image = ImageList1.Images.Item(20)
        End If
        pbA.Image = ImageList3.Images.Item(0)
        pbB.Image = ImageList3.Images.Item(1)
        pbC.Image = ImageList3.Images.Item(2)
        pbD.Image = ImageList3.Images.Item(3)
        pbE.Image = ImageList3.Images.Item(4)
        pbF.Image = ImageList3.Images.Item(5)
        pbG.Image = ImageList3.Images.Item(6)
        pbH.Image = ImageList3.Images.Item(7)
        pbI.Image = ImageList3.Images.Item(8)
        pbJ.Image = ImageList3.Images.Item(9)
        pbK.Image = ImageList3.Images.Item(10)
        pbL.Image = ImageList3.Images.Item(11)
        pbM.Image = ImageList3.Images.Item(12)
        pbN.Image = ImageList3.Images.Item(13)
        pbO.Image = ImageList3.Images.Item(14)
        pbP.Image = ImageList3.Images.Item(15)
        pbQ.Image = ImageList3.Images.Item(16)
        pbR.Image = ImageList3.Images.Item(17)
        pbS.Image = ImageList3.Images.Item(18)
        pbT.Image = ImageList3.Images.Item(19)
        pbU.Image = ImageList3.Images.Item(20)
        pbV.Image = ImageList3.Images.Item(21)
        pbW.Image = ImageList3.Images.Item(22)
        pbX.Image = ImageList3.Images.Item(23)
        pbY.Image = ImageList3.Images.Item(24)
        pbZ.Image = ImageList3.Images.Item(25)
        pbSpace.Image = ImageList3.Images.Item(26)
        pbBackSpace.Image = ImageList3.Images.Item(27)
        PBShift.Image = ImageList3.Images.Item(28)
    End Sub

End Class

