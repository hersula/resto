<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucher))
        Me.picCancel = New System.Windows.Forms.PictureBox()
        Me.picOK = New System.Windows.Forms.PictureBox()
        Me.lblVoidBy = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtVcrDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblVcrNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnValidate = New Janus.Windows.EditControls.UIButton()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCancel
        '
        Me.picCancel.BackColor = System.Drawing.Color.Transparent
        Me.picCancel.BackgroundImage = CType(resources.GetObject("picCancel.BackgroundImage"), System.Drawing.Image)
        Me.picCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCancel.Location = New System.Drawing.Point(455, 268)
        Me.picCancel.Name = "picCancel"
        Me.picCancel.Size = New System.Drawing.Size(96, 83)
        Me.picCancel.TabIndex = 52
        Me.picCancel.TabStop = False
        '
        'picOK
        '
        Me.picOK.BackColor = System.Drawing.Color.Transparent
        Me.picOK.BackgroundImage = CType(resources.GetObject("picOK.BackgroundImage"), System.Drawing.Image)
        Me.picOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOK.Location = New System.Drawing.Point(455, 179)
        Me.picOK.Name = "picOK"
        Me.picOK.Size = New System.Drawing.Size(96, 83)
        Me.picOK.TabIndex = 51
        Me.picOK.TabStop = False
        '
        'lblVoidBy
        '
        Me.lblVoidBy.BackColor = System.Drawing.Color.Transparent
        Me.lblVoidBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVoidBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoidBy.ForeColor = System.Drawing.Color.White
        Me.lblVoidBy.Location = New System.Drawing.Point(92, 370)
        Me.lblVoidBy.Name = "lblVoidBy"
        Me.lblVoidBy.Size = New System.Drawing.Size(468, 25)
        Me.lblVoidBy.TabIndex = 49
        Me.lblVoidBy.Text = "Void Operator"
        Me.lblVoidBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(18, 146)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(230, 29)
        Me.lbl1.TabIndex = 48
        Me.lbl1.Text = "Voucher Description"
        '
        'txtVcrDesc
        '
        Me.txtVcrDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVcrDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVcrDesc.Location = New System.Drawing.Point(15, 179)
        Me.txtVcrDesc.Multiline = True
        Me.txtVcrDesc.Name = "txtVcrDesc"
        Me.txtVcrDesc.ReadOnly = True
        Me.txtVcrDesc.Size = New System.Drawing.Size(434, 172)
        Me.txtVcrDesc.TabIndex = 47
        Me.txtVcrDesc.Text = "Test"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(565, 35)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Voucher Validation"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVcrNo
        '
        Me.lblVcrNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVcrNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVcrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVcrNo.Location = New System.Drawing.Point(15, 90)
        Me.lblVcrNo.Name = "lblVcrNo"
        Me.lblVcrNo.Size = New System.Drawing.Size(434, 36)
        Me.lblVcrNo.TabIndex = 45
        Me.lblVcrNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Voucher #"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Void By"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnValidate
        '
        Me.btnValidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidate.Location = New System.Drawing.Point(445, 91)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(108, 36)
        Me.btnValidate.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gold
        Me.btnValidate.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnValidate.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnValidate.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnValidate.TabIndex = 53
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseThemes = False
        '
        'frmVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(565, 396)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.picCancel)
        Me.Controls.Add(Me.picOK)
        Me.Controls.Add(Me.lblVoidBy)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtVcrDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblVcrNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCancel As System.Windows.Forms.PictureBox
    Friend WithEvents picOK As System.Windows.Forms.PictureBox
    Friend WithEvents lblVoidBy As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtVcrDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVcrNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnValidate As Janus.Windows.EditControls.UIButton
End Class
