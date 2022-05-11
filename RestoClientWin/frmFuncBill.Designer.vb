<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncBill
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
        Me.btnClose = New Janus.Windows.EditControls.UIButton()
        Me.btnTransferBill = New Janus.Windows.EditControls.UIButton()
        Me.btnJoinBill = New Janus.Windows.EditControls.UIButton()
        Me.btnSplitBill = New Janus.Windows.EditControls.UIButton()
        Me.btnPreBill = New Janus.Windows.EditControls.UIButton()
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.btnPayBill = New Janus.Windows.EditControls.UIButton()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1, 191)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(716, 59)
        Me.btnClose.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gold
        Me.btnClose.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnClose.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnClose.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseThemes = False
        '
        'btnTransferBill
        '
        Me.btnTransferBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferBill.Location = New System.Drawing.Point(1, 116)
        Me.btnTransferBill.Name = "btnTransferBill"
        Me.btnTransferBill.Size = New System.Drawing.Size(240, 77)
        Me.btnTransferBill.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Green
        Me.btnTransferBill.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnTransferBill.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnTransferBill.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnTransferBill.TabIndex = 13
        Me.btnTransferBill.Text = "Transfer Bill"
        Me.btnTransferBill.UseThemes = False
        '
        'btnJoinBill
        '
        Me.btnJoinBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJoinBill.Location = New System.Drawing.Point(477, 41)
        Me.btnJoinBill.Name = "btnJoinBill"
        Me.btnJoinBill.Size = New System.Drawing.Size(240, 77)
        Me.btnJoinBill.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJoinBill.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJoinBill.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnJoinBill.TabIndex = 11
        Me.btnJoinBill.Text = "Join Bill"
        Me.btnJoinBill.UseThemes = False
        '
        'btnSplitBill
        '
        Me.btnSplitBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitBill.Location = New System.Drawing.Point(239, 41)
        Me.btnSplitBill.Name = "btnSplitBill"
        Me.btnSplitBill.Size = New System.Drawing.Size(240, 77)
        Me.btnSplitBill.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSplitBill.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnSplitBill.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnSplitBill.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSplitBill.TabIndex = 10
        Me.btnSplitBill.Text = "Split Bill"
        Me.btnSplitBill.UseThemes = False
        '
        'btnPreBill
        '
        Me.btnPreBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreBill.Location = New System.Drawing.Point(1, 41)
        Me.btnPreBill.Name = "btnPreBill"
        Me.btnPreBill.Size = New System.Drawing.Size(240, 77)
        Me.btnPreBill.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPreBill.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnPreBill.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnPreBill.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnPreBill.TabIndex = 9
        Me.btnPreBill.Text = "Pre Bill"
        Me.btnPreBill.UseThemes = False
        '
        'lblHDR
        '
        Me.lblHDR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHDR.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHDR.ForeColor = System.Drawing.Color.White
        Me.lblHDR.Location = New System.Drawing.Point(0, 0)
        Me.lblHDR.Name = "lblHDR"
        Me.lblHDR.Size = New System.Drawing.Size(718, 41)
        Me.lblHDR.TabIndex = 8
        Me.lblHDR.Text = "Bill Function"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPayBill
        '
        Me.btnPayBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayBill.Location = New System.Drawing.Point(239, 116)
        Me.btnPayBill.Name = "btnPayBill"
        Me.btnPayBill.Size = New System.Drawing.Size(240, 77)
        Me.btnPayBill.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Blue
        Me.btnPayBill.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPayBill.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnPayBill.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnPayBill.TabIndex = 16
        Me.btnPayBill.Text = "Pay My Billing"
        Me.btnPayBill.UseThemes = False
        '
        'frmFuncBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTransferBill)
        Me.Controls.Add(Me.btnJoinBill)
        Me.Controls.Add(Me.btnSplitBill)
        Me.Controls.Add(Me.btnPreBill)
        Me.Controls.Add(Me.lblHDR)
        Me.Controls.Add(Me.btnPayBill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTransferBill As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnJoinBill As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSplitBill As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPreBill As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblHDR As System.Windows.Forms.Label
    Friend WithEvents btnPayBill As Janus.Windows.EditControls.UIButton
End Class
