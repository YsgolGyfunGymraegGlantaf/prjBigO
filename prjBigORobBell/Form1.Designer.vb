<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnO_1 = New System.Windows.Forms.Button()
        Me.txtMewnbwn = New System.Windows.Forms.TextBox()
        Me.btn_O_N = New System.Windows.Forms.Button()
        Me.btnO_N2 = New System.Windows.Forms.Button()
        Me.btnO_2N = New System.Windows.Forms.Button()
        Me.btnO_log_N = New System.Windows.Forms.Button()
        Me.btnO_N_log_N = New System.Windows.Forms.Button()
        Me.lblAllbwn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnO_1
        '
        Me.btnO_1.Location = New System.Drawing.Point(25, 51)
        Me.btnO_1.Name = "btnO_1"
        Me.btnO_1.Size = New System.Drawing.Size(74, 28)
        Me.btnO_1.TabIndex = 0
        Me.btnO_1.Text = "O(1)"
        Me.btnO_1.UseVisualStyleBackColor = True
        '
        'txtMewnbwn
        '
        Me.txtMewnbwn.Location = New System.Drawing.Point(25, 14)
        Me.txtMewnbwn.Name = "txtMewnbwn"
        Me.txtMewnbwn.Size = New System.Drawing.Size(163, 20)
        Me.txtMewnbwn.TabIndex = 1
        '
        'btn_O_N
        '
        Me.btn_O_N.Location = New System.Drawing.Point(25, 85)
        Me.btn_O_N.Name = "btn_O_N"
        Me.btn_O_N.Size = New System.Drawing.Size(74, 28)
        Me.btn_O_N.TabIndex = 2
        Me.btn_O_N.Text = "O(N)"
        Me.btn_O_N.UseVisualStyleBackColor = True
        '
        'btnO_N2
        '
        Me.btnO_N2.Location = New System.Drawing.Point(24, 119)
        Me.btnO_N2.Name = "btnO_N2"
        Me.btnO_N2.Size = New System.Drawing.Size(75, 28)
        Me.btnO_N2.TabIndex = 3
        Me.btnO_N2.Text = "O(N^2)"
        Me.btnO_N2.UseVisualStyleBackColor = True
        '
        'btnO_2N
        '
        Me.btnO_2N.Location = New System.Drawing.Point(25, 153)
        Me.btnO_2N.Name = "btnO_2N"
        Me.btnO_2N.Size = New System.Drawing.Size(74, 28)
        Me.btnO_2N.TabIndex = 4
        Me.btnO_2N.Text = "O(2^N)"
        Me.btnO_2N.UseVisualStyleBackColor = True
        '
        'btnO_log_N
        '
        Me.btnO_log_N.Location = New System.Drawing.Point(25, 187)
        Me.btnO_log_N.Name = "btnO_log_N"
        Me.btnO_log_N.Size = New System.Drawing.Size(74, 28)
        Me.btnO_log_N.TabIndex = 5
        Me.btnO_log_N.Text = "O(log N)"
        Me.btnO_log_N.UseVisualStyleBackColor = True
        '
        'btnO_N_log_N
        '
        Me.btnO_N_log_N.Location = New System.Drawing.Point(25, 221)
        Me.btnO_N_log_N.Name = "btnO_N_log_N"
        Me.btnO_N_log_N.Size = New System.Drawing.Size(74, 28)
        Me.btnO_N_log_N.TabIndex = 6
        Me.btnO_N_log_N.Text = "O(N log N)"
        Me.btnO_N_log_N.UseVisualStyleBackColor = True
        '
        'lblAllbwn
        '
        Me.lblAllbwn.AutoSize = True
        Me.lblAllbwn.Location = New System.Drawing.Point(267, 25)
        Me.lblAllbwn.Name = "lblAllbwn"
        Me.lblAllbwn.Size = New System.Drawing.Size(38, 13)
        Me.lblAllbwn.TabIndex = 7
        Me.lblAllbwn.Text = "Allbwn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 411)
        Me.Controls.Add(Me.lblAllbwn)
        Me.Controls.Add(Me.btnO_N_log_N)
        Me.Controls.Add(Me.btnO_log_N)
        Me.Controls.Add(Me.btnO_2N)
        Me.Controls.Add(Me.btnO_N2)
        Me.Controls.Add(Me.btn_O_N)
        Me.Controls.Add(Me.txtMewnbwn)
        Me.Controls.Add(Me.btnO_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnO_1 As System.Windows.Forms.Button
    Friend WithEvents txtMewnbwn As System.Windows.Forms.TextBox
    Friend WithEvents btn_O_N As System.Windows.Forms.Button
    Friend WithEvents btnO_N2 As System.Windows.Forms.Button
    Friend WithEvents btnO_2N As System.Windows.Forms.Button
    Friend WithEvents btnO_log_N As System.Windows.Forms.Button
    Friend WithEvents btnO_N_log_N As System.Windows.Forms.Button
    Friend WithEvents lblAllbwn As System.Windows.Forms.Label

End Class
