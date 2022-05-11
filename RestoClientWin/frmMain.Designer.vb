<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbFloor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogInOut = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnFunc = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbFloor
        '
        Me.cmbFloor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFloor.FormattingEnabled = True
        Me.cmbFloor.Location = New System.Drawing.Point(85, 5)
        Me.cmbFloor.Name = "cmbFloor"
        Me.cmbFloor.Size = New System.Drawing.Size(216, 28)
        Me.cmbFloor.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Floor ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Yellow
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1253, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 92)
        Me.btnClose.TabIndex = 19
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Plum
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(0, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1358, 653)
        Me.Panel1.TabIndex = 14
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ImageIndex = 5
        Me.btnLoad.ImageList = Me.ImageList1
        Me.btnLoad.Location = New System.Drawing.Point(321, 1)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(93, 94)
        Me.btnLoad.TabIndex = 13
        Me.btnLoad.Text = "Load"
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "OTHER_ACCESSORIES.png")
        Me.ImageList1.Images.SetKeyName(1, "icon_joinUs.gif")
        Me.ImageList1.Images.SetKeyName(2, "Login_Icon.png")
        Me.ImageList1.Images.SetKeyName(3, "Resto Reservatation.png")
        Me.ImageList1.Images.SetKeyName(4, "Gembok.png")
        Me.ImageList1.Images.SetKeyName(5, "OK3.png")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.lblDay)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnLogInOut)
        Me.Panel2.Controls.Add(Me.btnReserve)
        Me.Panel2.Controls.Add(Me.btnLock)
        Me.Panel2.Controls.Add(Me.btnFunc)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbFloor)
        Me.Panel2.Controls.Add(Me.btnLoad)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 97)
        Me.Panel2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(420, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 45)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Running"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Lime
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(420, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 45)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Open"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1103, 67)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(144, 26)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1103, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(144, 26)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date"
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(1103, 3)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(144, 26)
        Me.lblDay.TabIndex = 26
        Me.lblDay.Text = "Day"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Floor ID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "O/P ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnLogInOut
        '
        Me.btnLogInOut.BackgroundImage = CType(resources.GetObject("btnLogInOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLogInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogInOut.ImageIndex = 2
        Me.btnLogInOut.ImageList = Me.ImageList1
        Me.btnLogInOut.Location = New System.Drawing.Point(967, 1)
        Me.btnLogInOut.Name = "btnLogInOut"
        Me.btnLogInOut.Size = New System.Drawing.Size(130, 94)
        Me.btnLogInOut.TabIndex = 23
        Me.btnLogInOut.Text = "Log In"
        Me.btnLogInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogInOut.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.BackgroundImage = CType(resources.GetObject("btnReserve.BackgroundImage"), System.Drawing.Image)
        Me.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ImageIndex = 3
        Me.btnReserve.ImageList = Me.ImageList1
        Me.btnReserve.Location = New System.Drawing.Point(790, 1)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(171, 94)
        Me.btnReserve.TabIndex = 22
        Me.btnReserve.Text = "Reservation"
        Me.btnReserve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.BackgroundImage = CType(resources.GetObject("btnLock.BackgroundImage"), System.Drawing.Image)
        Me.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ImageIndex = 4
        Me.btnLock.ImageList = Me.ImageList1
        Me.btnLock.Location = New System.Drawing.Point(662, 1)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(122, 94)
        Me.btnLock.TabIndex = 21
        Me.btnLock.Text = "Lock"
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnFunc
        '
        Me.btnFunc.BackgroundImage = CType(resources.GetObject("btnFunc.BackgroundImage"), System.Drawing.Image)
        Me.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFunc.ImageIndex = 0
        Me.btnFunc.ImageList = Me.ImageList1
        Me.btnFunc.Location = New System.Drawing.Point(527, 1)
        Me.btnFunc.Name = "btnFunc"
        Me.btnFunc.Size = New System.Drawing.Size(129, 94)
        Me.btnFunc.TabIndex = 20
        Me.btnFunc.Text = "Function"
        Me.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFunc.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbFloor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogInOut As System.Windows.Forms.Button
    Friend WithEvents btnReserve As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnFunc As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
