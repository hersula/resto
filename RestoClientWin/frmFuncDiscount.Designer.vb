<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncDiscount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.tabMain = New Janus.Windows.UI.Tab.UITabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabRegular = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabSpecial = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnRegular = New Janus.Windows.EditControls.UIButton()
        Me.btnSpecial = New Janus.Windows.EditControls.UIButton()
        Me.btnClose = New Janus.Windows.EditControls.UIButton()
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.btnApprove = New Janus.Windows.EditControls.UIButton()
        Me.lblDiscBy = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCatatanDisc = New System.Windows.Forms.TextBox()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.lblPersenDisc = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblDine = New System.Windows.Forms.Label()
        Me.lblMenuName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabRegular.SuspendLayout()
        Me.tabSpecial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.BackColor = System.Drawing.Color.OrangeRed
        Me.UiTab1.Location = New System.Drawing.Point(3, 38)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(748, 473)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabMain, Me.tabRegular, Me.tabSpecial})
        Me.UiTab1.UseThemes = False
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.Label3)
        Me.tabMain.Controls.Add(Me.Label2)
        Me.tabMain.Controls.Add(Me.Label1)
        Me.tabMain.Key = "tabMain"
        Me.tabMain.Location = New System.Drawing.Point(1, 21)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(746, 451)
        Me.tabMain.TabStop = True
        Me.tabMain.Text = "Main"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(697, 76)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TAP  the SPEACIAL to give Special Discount items for Guest"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(697, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TAP  the REGULAR to give Regular Discount items for Guest"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 134)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount Items's is valid for per item only. This Function can not be use for Glo" & _
    "bal Discount."
        '
        'tabRegular
        '
        Me.tabRegular.Controls.Add(Me.lblDiscBy)
        Me.tabRegular.Controls.Add(Me.Label6)
        Me.tabRegular.Controls.Add(Me.txtCatatanDisc)
        Me.tabRegular.Controls.Add(Me.btn10)
        Me.tabRegular.Controls.Add(Me.btn5)
        Me.tabRegular.Controls.Add(Me.lblPersenDisc)
        Me.tabRegular.Controls.Add(Me.lblQty)
        Me.tabRegular.Controls.Add(Me.lblDine)
        Me.tabRegular.Controls.Add(Me.lblMenuName)
        Me.tabRegular.Controls.Add(Me.Label4)
        Me.tabRegular.Controls.Add(Me.Label7)
        Me.tabRegular.Controls.Add(Me.Label8)
        Me.tabRegular.Controls.Add(Me.Label9)
        Me.tabRegular.Controls.Add(Me.Label10)
        Me.tabRegular.Key = "tabRegular"
        Me.tabRegular.Location = New System.Drawing.Point(1, 21)
        Me.tabRegular.Name = "tabRegular"
        Me.tabRegular.Size = New System.Drawing.Size(746, 451)
        Me.tabRegular.TabStop = True
        Me.tabRegular.Text = "Regular"
        '
        'tabSpecial
        '
        Me.tabSpecial.Controls.Add(Me.Label11)
        Me.tabSpecial.Controls.Add(Me.Label12)
        Me.tabSpecial.Controls.Add(Me.TextBox1)
        Me.tabSpecial.Controls.Add(Me.Button1)
        Me.tabSpecial.Controls.Add(Me.Button2)
        Me.tabSpecial.Controls.Add(Me.Label13)
        Me.tabSpecial.Controls.Add(Me.Label14)
        Me.tabSpecial.Controls.Add(Me.Label15)
        Me.tabSpecial.Controls.Add(Me.Label16)
        Me.tabSpecial.Controls.Add(Me.Label17)
        Me.tabSpecial.Controls.Add(Me.Label18)
        Me.tabSpecial.Controls.Add(Me.Label19)
        Me.tabSpecial.Controls.Add(Me.Label20)
        Me.tabSpecial.Controls.Add(Me.Label21)
        Me.tabSpecial.Key = "tabSpecial"
        Me.tabSpecial.Location = New System.Drawing.Point(1, 21)
        Me.tabSpecial.Name = "tabSpecial"
        Me.tabSpecial.Size = New System.Drawing.Size(746, 451)
        Me.tabSpecial.TabStop = True
        Me.tabSpecial.Text = "Special"
        '
        'btnRegular
        '
        Me.btnRegular.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnRegular.FlatBorderColor = System.Drawing.Color.White
        Me.btnRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegular.Location = New System.Drawing.Point(770, 59)
        Me.btnRegular.Name = "btnRegular"
        Me.btnRegular.Size = New System.Drawing.Size(153, 61)
        Me.btnRegular.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegular.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Goldenrod
        Me.btnRegular.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Diagonal
        Me.btnRegular.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnRegular.TabIndex = 1
        Me.btnRegular.Text = "REGULAR"
        Me.btnRegular.UseThemes = False
        '
        'btnSpecial
        '
        Me.btnSpecial.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnSpecial.FlatBorderColor = System.Drawing.Color.Yellow
        Me.btnSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecial.Location = New System.Drawing.Point(770, 164)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(153, 61)
        Me.btnSpecial.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Blue
        Me.btnSpecial.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnSpecial.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Diagonal
        Me.btnSpecial.StateStyles.FormatStyle.BlendGradient = 0.0!
        Me.btnSpecial.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Yellow
        Me.btnSpecial.TabIndex = 2
        Me.btnSpecial.Text = "SPECIAL"
        Me.btnSpecial.UseThemes = False
        '
        'btnClose
        '
        Me.btnClose.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnClose.FlatBorderColor = System.Drawing.Color.Yellow
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(770, 443)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(153, 61)
        Me.btnClose.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Red
        Me.btnClose.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseThemes = False
        '
        'lblHDR
        '
        Me.lblHDR.BackColor = System.Drawing.Color.DarkOrange
        Me.lblHDR.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDR.ForeColor = System.Drawing.Color.White
        Me.lblHDR.Location = New System.Drawing.Point(0, 0)
        Me.lblHDR.Name = "lblHDR"
        Me.lblHDR.Size = New System.Drawing.Size(947, 35)
        Me.lblHDR.TabIndex = 38
        Me.lblHDR.Text = "DISCOUNT ITEM"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnApprove
        '
        Me.btnApprove.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnApprove.FlatBorderColor = System.Drawing.Color.White
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(770, 340)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(153, 61)
        Me.btnApprove.StateStyles.FormatStyle.BackColor = System.Drawing.Color.DarkGreen
        Me.btnApprove.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnApprove.TabIndex = 39
        Me.btnApprove.Text = "APPROVE"
        Me.btnApprove.UseThemes = False
        '
        'lblDiscBy
        '
        Me.lblDiscBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscBy.ForeColor = System.Drawing.Color.White
        Me.lblDiscBy.Location = New System.Drawing.Point(175, 423)
        Me.lblDiscBy.Name = "lblDiscBy"
        Me.lblDiscBy.Size = New System.Drawing.Size(465, 25)
        Me.lblDiscBy.TabIndex = 58
        Me.lblDiscBy.Text = "Disc Operator"
        Me.lblDiscBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(98, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 29)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Disc Note :"
        '
        'txtCatatanDisc
        '
        Me.txtCatatanDisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCatatanDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatanDisc.Location = New System.Drawing.Point(98, 238)
        Me.txtCatatanDisc.Multiline = True
        Me.txtCatatanDisc.Name = "txtCatatanDisc"
        Me.txtCatatanDisc.Size = New System.Drawing.Size(542, 172)
        Me.txtCatatanDisc.TabIndex = 56
        '
        'btn10
        '
        Me.btn10.BackColor = System.Drawing.Color.LightCoral
        Me.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn10.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10.ForeColor = System.Drawing.Color.Yellow
        Me.btn10.Location = New System.Drawing.Point(549, 114)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(91, 70)
        Me.btn10.TabIndex = 55
        Me.btn10.Text = "10%"
        Me.btn10.UseVisualStyleBackColor = False
        '
        'lblPersenDisc
        '
        Me.lblPersenDisc.BackColor = System.Drawing.Color.DarkOrange
        Me.lblPersenDisc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPersenDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersenDisc.Location = New System.Drawing.Point(432, 114)
        Me.lblPersenDisc.Name = "lblPersenDisc"
        Me.lblPersenDisc.Size = New System.Drawing.Size(110, 70)
        Me.lblPersenDisc.TabIndex = 53
        Me.lblPersenDisc.Text = "1"
        Me.lblPersenDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.DarkOrange
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(120, 114)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(85, 70)
        Me.lblQty.TabIndex = 52
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDine
        '
        Me.lblDine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDine.Location = New System.Drawing.Point(551, 42)
        Me.lblDine.Name = "lblDine"
        Me.lblDine.Size = New System.Drawing.Size(88, 36)
        Me.lblDine.TabIndex = 51
        Me.lblDine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMenuName
        '
        Me.lblMenuName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMenuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuName.Location = New System.Drawing.Point(98, 42)
        Me.lblMenuName.Name = "lblMenuName"
        Me.lblMenuName.Size = New System.Drawing.Size(453, 36)
        Me.lblMenuName.TabIndex = 50
        Me.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(410, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 29)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "% - Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(95, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 29)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Current Order"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(551, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 29)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(97, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 29)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Item Name"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(98, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Disc By"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.LightCoral
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Yellow
        Me.btn5.Location = New System.Drawing.Point(335, 114)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(91, 70)
        Me.btn5.TabIndex = 54
        Me.btn5.Text = "5%"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(175, 423)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(465, 25)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Disc Operator"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(98, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 29)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Disc Note :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 238)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(542, 172)
        Me.TextBox1.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(549, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 70)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(360, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 70)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkOrange
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(457, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 70)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DarkOrange
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 70)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "1"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(551, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 36)
        Me.Label15.TabIndex = 65
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(98, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(453, 36)
        Me.Label16.TabIndex = 64
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(426, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(148, 29)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "% - Discount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(95, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(161, 29)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Current Order"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(551, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 29)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Type"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(97, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 29)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Item Name"
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(98, 423)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 25)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Disc By"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFuncDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(947, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.lblHDR)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSpecial)
        Me.Controls.Add(Me.btnRegular)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabRegular.ResumeLayout(False)
        Me.tabRegular.PerformLayout()
        Me.tabSpecial.ResumeLayout(False)
        Me.tabSpecial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabRegular As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabSpecial As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnRegular As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSpecial As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblHDR As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnApprove As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDiscBy As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCatatanDisc As System.Windows.Forms.TextBox
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents lblPersenDisc As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblDine As System.Windows.Forms.Label
    Friend WithEvents lblMenuName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
