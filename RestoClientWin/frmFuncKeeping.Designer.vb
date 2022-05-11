<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncKeeping
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
        Me.btnStore = New Janus.Windows.EditControls.UIButton()
        Me.btnLoad = New Janus.Windows.EditControls.UIButton()
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(0, 191)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(716, 59)
        Me.btnClose.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gold
        Me.btnClose.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnClose.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnClose.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseThemes = False
        '
        'btnStore
        '
        Me.btnStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStore.Location = New System.Drawing.Point(239, 41)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(240, 77)
        Me.btnStore.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Green
        Me.btnStore.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnStore.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnStore.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnStore.TabIndex = 19
        Me.btnStore.Text = "Keep Bottle"
        Me.btnStore.UseThemes = False
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(1, 41)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(240, 77)
        Me.btnLoad.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gray
        Me.btnLoad.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnLoad.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "Take Bottle"
        Me.btnLoad.UseThemes = False
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
        Me.lblHDR.Text = "Bottle Management Function"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmFuncKeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStore)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lblHDR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncKeeping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnStore As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLoad As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblHDR As System.Windows.Forms.Label
End Class
