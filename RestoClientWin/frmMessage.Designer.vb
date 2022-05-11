<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblHeaderMessage = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(5, 42)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(862, 263)
        Me.txtMessage.TabIndex = 0
        Me.txtMessage.TabStop = False
        Me.txtMessage.Text = "Text Message Here"
        '
        'lblHeaderMessage
        '
        Me.lblHeaderMessage.BackColor = System.Drawing.Color.Maroon
        Me.lblHeaderMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeaderMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMessage.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderMessage.Name = "lblHeaderMessage"
        Me.lblHeaderMessage.Size = New System.Drawing.Size(875, 39)
        Me.lblHeaderMessage.TabIndex = 1
        Me.lblHeaderMessage.Text = "lblHeaderMessage"
        Me.lblHeaderMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(5, 323)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(199, 89)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(668, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(199, 89)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close / Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblHeaderMessage)
        Me.Controls.Add(Me.txtMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMessage"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderMessage As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
