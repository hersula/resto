<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncOthers
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
        Me.btnOwerCover = New Janus.Windows.EditControls.UIButton()
        Me.btnWaiterSubsitution = New Janus.Windows.EditControls.UIButton()
        Me.btnSoldOut = New Janus.Windows.EditControls.UIButton()
        Me.btnViewTrans = New Janus.Windows.EditControls.UIButton()
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.btnPLUViewer = New Janus.Windows.EditControls.UIButton()
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
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseThemes = False
        '
        'btnOwerCover
        '
        Me.btnOwerCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwerCover.Location = New System.Drawing.Point(239, 117)
        Me.btnOwerCover.Name = "btnOwerCover"
        Me.btnOwerCover.Size = New System.Drawing.Size(240, 77)
        Me.btnOwerCover.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Green
        Me.btnOwerCover.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnOwerCover.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnOwerCover.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnOwerCover.TabIndex = 20
        Me.btnOwerCover.Text = "Owner Cover Operator"
        Me.btnOwerCover.UseThemes = False
        '
        'btnWaiterSubsitution
        '
        Me.btnWaiterSubsitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaiterSubsitution.Location = New System.Drawing.Point(477, 41)
        Me.btnWaiterSubsitution.Name = "btnWaiterSubsitution"
        Me.btnWaiterSubsitution.Size = New System.Drawing.Size(240, 77)
        Me.btnWaiterSubsitution.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWaiterSubsitution.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWaiterSubsitution.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnWaiterSubsitution.TabIndex = 19
        Me.btnWaiterSubsitution.Text = "Waiter Subsitution"
        Me.btnWaiterSubsitution.UseThemes = False
        '
        'btnSoldOut
        '
        Me.btnSoldOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoldOut.Location = New System.Drawing.Point(239, 41)
        Me.btnSoldOut.Name = "btnSoldOut"
        Me.btnSoldOut.Size = New System.Drawing.Size(240, 77)
        Me.btnSoldOut.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSoldOut.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnSoldOut.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnSoldOut.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSoldOut.TabIndex = 18
        Me.btnSoldOut.Text = "Sold Out"
        Me.btnSoldOut.UseThemes = False
        '
        'btnViewTrans
        '
        Me.btnViewTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTrans.Location = New System.Drawing.Point(1, 41)
        Me.btnViewTrans.Name = "btnViewTrans"
        Me.btnViewTrans.Size = New System.Drawing.Size(240, 77)
        Me.btnViewTrans.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnViewTrans.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnViewTrans.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnViewTrans.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnViewTrans.TabIndex = 17
        Me.btnViewTrans.Text = "View Transaction"
        Me.btnViewTrans.UseThemes = False
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
        Me.lblHDR.TabIndex = 16
        Me.lblHDR.Text = "Others Function"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPLUViewer
        '
        Me.btnPLUViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPLUViewer.Location = New System.Drawing.Point(1, 117)
        Me.btnPLUViewer.Name = "btnPLUViewer"
        Me.btnPLUViewer.Size = New System.Drawing.Size(240, 77)
        Me.btnPLUViewer.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gray
        Me.btnPLUViewer.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnPLUViewer.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnPLUViewer.TabIndex = 22
        Me.btnPLUViewer.Text = "PLU Viewer"
        Me.btnPLUViewer.UseThemes = False
        '
        'frmFuncOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPLUViewer)
        Me.Controls.Add(Me.btnOwerCover)
        Me.Controls.Add(Me.btnWaiterSubsitution)
        Me.Controls.Add(Me.btnSoldOut)
        Me.Controls.Add(Me.btnViewTrans)
        Me.Controls.Add(Me.lblHDR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnOwerCover As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnWaiterSubsitution As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSoldOut As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnViewTrans As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblHDR As System.Windows.Forms.Label
    Friend WithEvents btnPLUViewer As Janus.Windows.EditControls.UIButton
End Class
