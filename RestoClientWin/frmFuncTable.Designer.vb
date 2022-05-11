<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncTable
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
        Me.lblHDR = New System.Windows.Forms.Label()
        Me.btnSplitTable = New Janus.Windows.EditControls.UIButton()
        Me.btnJoinTable = New Janus.Windows.EditControls.UIButton()
        Me.btnTableRelease = New Janus.Windows.EditControls.UIButton()
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton()
        Me.btnTransferItems = New Janus.Windows.EditControls.UIButton()
        Me.btnMoveTable = New Janus.Windows.EditControls.UIButton()
        Me.btnClose = New Janus.Windows.EditControls.UIButton()
        Me.SuspendLayout()
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
        Me.lblHDR.TabIndex = 0
        Me.lblHDR.Text = "Table Function"
        Me.lblHDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSplitTable
        '
        Me.btnSplitTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitTable.Location = New System.Drawing.Point(1, 40)
        Me.btnSplitTable.Name = "btnSplitTable"
        Me.btnSplitTable.Size = New System.Drawing.Size(240, 77)
        Me.btnSplitTable.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSplitTable.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnSplitTable.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnSplitTable.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnSplitTable.TabIndex = 1
        Me.btnSplitTable.Text = "Split Table"
        Me.btnSplitTable.UseThemes = False
        '
        'btnJoinTable
        '
        Me.btnJoinTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJoinTable.Location = New System.Drawing.Point(239, 40)
        Me.btnJoinTable.Name = "btnJoinTable"
        Me.btnJoinTable.Size = New System.Drawing.Size(240, 77)
        Me.btnJoinTable.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Fuchsia
        Me.btnJoinTable.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Yellow
        Me.btnJoinTable.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnJoinTable.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnJoinTable.TabIndex = 2
        Me.btnJoinTable.Text = "Join Table"
        Me.btnJoinTable.UseThemes = False
        '
        'btnTableRelease
        '
        Me.btnTableRelease.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTableRelease.Location = New System.Drawing.Point(1, 115)
        Me.btnTableRelease.Name = "btnTableRelease"
        Me.btnTableRelease.Size = New System.Drawing.Size(240, 77)
        Me.btnTableRelease.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTableRelease.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTableRelease.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnTableRelease.TabIndex = 3
        Me.btnTableRelease.Text = "Release Table"
        Me.btnTableRelease.UseThemes = False
        '
        'UiButton4
        '
        Me.UiButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiButton4.Location = New System.Drawing.Point(477, 115)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(240, 77)
        Me.UiButton4.TabIndex = 6
        Me.UiButton4.UseThemes = False
        '
        'btnTransferItems
        '
        Me.btnTransferItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferItems.Location = New System.Drawing.Point(239, 115)
        Me.btnTransferItems.Name = "btnTransferItems"
        Me.btnTransferItems.Size = New System.Drawing.Size(240, 77)
        Me.btnTransferItems.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Green
        Me.btnTransferItems.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.btnTransferItems.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnTransferItems.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.btnTransferItems.TabIndex = 5
        Me.btnTransferItems.Text = "Transfer Items"
        Me.btnTransferItems.UseThemes = False
        '
        'btnMoveTable
        '
        Me.btnMoveTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveTable.Location = New System.Drawing.Point(477, 39)
        Me.btnMoveTable.Name = "btnMoveTable"
        Me.btnMoveTable.Size = New System.Drawing.Size(240, 77)
        Me.btnMoveTable.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gray
        Me.btnMoveTable.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnMoveTable.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnMoveTable.TabIndex = 4
        Me.btnMoveTable.Text = "Move Table"
        Me.btnMoveTable.UseThemes = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1, 190)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(716, 59)
        Me.btnClose.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Gold
        Me.btnClose.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.btnClose.StateStyles.FormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical
        Me.btnClose.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseThemes = False
        '
        'frmFuncTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMoveTable)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.UiButton4)
        Me.Controls.Add(Me.btnTransferItems)
        Me.Controls.Add(Me.btnTableRelease)
        Me.Controls.Add(Me.btnJoinTable)
        Me.Controls.Add(Me.btnSplitTable)
        Me.Controls.Add(Me.lblHDR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFuncTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHDR As System.Windows.Forms.Label
    Friend WithEvents btnSplitTable As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnJoinTable As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTableRelease As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTransferItems As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMoveTable As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
End Class
