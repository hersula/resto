<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncVoid
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
        Me.btnVoidItems = New Janus.Windows.EditControls.UIButton()
        Me.btnVoidPromo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoidALL = New Janus.Windows.EditControls.UIButton()
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
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseThemes = False
        '
        'btnVoidItems
        '
        Me.btnVoidItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidItems.Location = New System.Drawing.Point(239, 41)
        Me.btnVoidItems.Name = "btnVoidItems"
        Me.btnVoidItems.Size = New System.Drawing.Size(240, 77)
        Me.btnVoidItems.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Green
        Me.btnVoidItems.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnVoidItems.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnVoidItems.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnVoidItems.TabIndex = 13
        Me.btnVoidItems.Text = "Void Items"
        Me.btnVoidItems.UseThemes = False
        '
        'btnVoidPromo
        '
        Me.btnVoidPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidPromo.Location = New System.Drawing.Point(1, 41)
        Me.btnVoidPromo.Name = "btnVoidPromo"
        Me.btnVoidPromo.Size = New System.Drawing.Size(240, 77)
        Me.btnVoidPromo.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gray
        Me.btnVoidPromo.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnVoidPromo.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnVoidPromo.TabIndex = 12
        Me.btnVoidPromo.Text = "Void Promo"
        Me.btnVoidPromo.UseThemes = False
        '
        'btnVoidALL
        '
        Me.btnVoidALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidALL.Location = New System.Drawing.Point(477, 41)
        Me.btnVoidALL.Name = "btnVoidALL"
        Me.btnVoidALL.Size = New System.Drawing.Size(240, 77)
        Me.btnVoidALL.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVoidALL.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVoidALL.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnVoidALL.TabIndex = 11
        Me.btnVoidALL.Text = "Void All"
        Me.btnVoidALL.UseThemes = False
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
        Me.lblHDR.Text = "Void Function"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmFuncVoid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnVoidItems)
        Me.Controls.Add(Me.btnVoidPromo)
        Me.Controls.Add(Me.btnVoidALL)
        Me.Controls.Add(Me.lblHDR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncVoid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoidItems As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoidPromo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoidALL As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblHDR As System.Windows.Forms.Label
End Class
