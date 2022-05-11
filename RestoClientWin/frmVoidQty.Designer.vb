<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidQty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoidQty))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCatatanVoid = New System.Windows.Forms.TextBox()
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.lblQtyVoid = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblDine = New System.Windows.Forms.Label()
        Me.lblMenuName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVoidBy = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picCancel = New System.Windows.Forms.PictureBox()
        Me.picVoid = New System.Windows.Forms.PictureBox()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVoid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 29)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Void Note :"
        '
        'txtCatatanVoid
        '
        Me.txtCatatanVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCatatanVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatanVoid.Location = New System.Drawing.Point(15, 280)
        Me.txtCatatanVoid.Multiline = True
        Me.txtCatatanVoid.Name = "txtCatatanVoid"
        Me.txtCatatanVoid.Size = New System.Drawing.Size(432, 172)
        Me.txtCatatanVoid.TabIndex = 28
        '
        'lblHDR
        '
        Me.lblHDR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHDR.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHDR.Location = New System.Drawing.Point(0, 0)
        Me.lblHDR.Name = "lblHDR"
        Me.lblHDR.Size = New System.Drawing.Size(575, 35)
        Me.lblHDR.TabIndex = 27
        Me.lblHDR.Text = "VOID Item / Qty"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 37.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.Yellow
        Me.btnMin.Location = New System.Drawing.Point(476, 157)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(79, 70)
        Me.btnMin.TabIndex = 24
        Me.btnMin.Text = "-"
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.BackgroundImage = CType(resources.GetObject("btnPlus.BackgroundImage"), System.Drawing.Image)
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.Color.Yellow
        Me.btnPlus.Location = New System.Drawing.Point(299, 157)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(79, 70)
        Me.btnPlus.TabIndex = 23
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'lblQtyVoid
        '
        Me.lblQtyVoid.BackColor = System.Drawing.Color.DarkOrange
        Me.lblQtyVoid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQtyVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyVoid.Location = New System.Drawing.Point(384, 156)
        Me.lblQtyVoid.Name = "lblQtyVoid"
        Me.lblQtyVoid.Size = New System.Drawing.Size(85, 70)
        Me.lblQtyVoid.TabIndex = 22
        Me.lblQtyVoid.Text = "1"
        Me.lblQtyVoid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.DarkOrange
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(37, 156)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(85, 70)
        Me.lblQty.TabIndex = 21
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDine
        '
        Me.lblDine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDine.Location = New System.Drawing.Point(468, 84)
        Me.lblDine.Name = "lblDine"
        Me.lblDine.Size = New System.Drawing.Size(88, 36)
        Me.lblDine.TabIndex = 20
        Me.lblDine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMenuName
        '
        Me.lblMenuName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMenuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuName.Location = New System.Drawing.Point(15, 84)
        Me.lblMenuName.Name = "lblMenuName"
        Me.lblMenuName.Size = New System.Drawing.Size(453, 36)
        Me.lblMenuName.TabIndex = 19
        Me.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(357, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Will be Void"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Current Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(468, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Item Name"
        '
        'lblVoidBy
        '
        Me.lblVoidBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVoidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoidBy.Location = New System.Drawing.Point(92, 465)
        Me.lblVoidBy.Name = "lblVoidBy"
        Me.lblVoidBy.Size = New System.Drawing.Size(483, 25)
        Me.lblVoidBy.TabIndex = 31
        Me.lblVoidBy.Text = "Void Operator"
        Me.lblVoidBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Void By"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picCancel
        '
        Me.picCancel.BackColor = System.Drawing.Color.Transparent
        Me.picCancel.BackgroundImage = CType(resources.GetObject("picCancel.BackgroundImage"), System.Drawing.Image)
        Me.picCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCancel.Location = New System.Drawing.Point(460, 369)
        Me.picCancel.Name = "picCancel"
        Me.picCancel.Size = New System.Drawing.Size(96, 83)
        Me.picCancel.TabIndex = 45
        Me.picCancel.TabStop = False
        '
        'picVoid
        '
        Me.picVoid.BackColor = System.Drawing.Color.Transparent
        Me.picVoid.BackgroundImage = CType(resources.GetObject("picVoid.BackgroundImage"), System.Drawing.Image)
        Me.picVoid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVoid.Location = New System.Drawing.Point(460, 280)
        Me.picVoid.Name = "picVoid"
        Me.picVoid.Size = New System.Drawing.Size(96, 83)
        Me.picVoid.TabIndex = 44
        Me.picVoid.TabStop = False
        '
        'frmVoidQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCancel)
        Me.Controls.Add(Me.picVoid)
        Me.Controls.Add(Me.lblVoidBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCatatanVoid)
        Me.Controls.Add(Me.lblHDR)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblQtyVoid)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblDine)
        Me.Controls.Add(Me.lblMenuName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmVoidQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVoid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCatatanVoid As System.Windows.Forms.TextBox
    Friend WithEvents lblHDR As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents lblQtyVoid As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblDine As System.Windows.Forms.Label
    Friend WithEvents lblMenuName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVoidBy As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents picCancel As System.Windows.Forms.PictureBox
    Friend WithEvents picVoid As System.Windows.Forms.PictureBox
End Class
