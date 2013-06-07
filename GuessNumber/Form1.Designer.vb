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
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumberBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SubmitButton = New System.Windows.Forms.Button
        Me.HintLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "请输入你要猜的数字"
        '
        'NumberBox
        '
        Me.NumberBox.Location = New System.Drawing.Point(156, 27)
        Me.NumberBox.Name = "NumberBox"
        Me.NumberBox.Size = New System.Drawing.Size(100, 21)
        Me.NumberBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "系统提示："
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(156, 65)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 4
        Me.SubmitButton.Text = "确定"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'HintLabel
        '
        Me.HintLabel.AutoSize = True
        Me.HintLabel.Location = New System.Drawing.Point(109, 140)
        Me.HintLabel.Name = "HintLabel"
        Me.HintLabel.Size = New System.Drawing.Size(17, 12)
        Me.HintLabel.TabIndex = 5
        Me.HintLabel.Text = "无"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 308)
        Me.Controls.Add(Me.HintLabel)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumberBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents HintLabel As System.Windows.Forms.Label

End Class
