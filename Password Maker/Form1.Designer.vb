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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChar = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chkLetters = New System.Windows.Forms.CheckBox()
        Me.chkSpecial = New System.Windows.Forms.CheckBox()
        Me.chkNumbers = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# of Characters"
        '
        'txtChar
        '
        Me.txtChar.Location = New System.Drawing.Point(98, 6)
        Me.txtChar.Name = "txtChar"
        Me.txtChar.Size = New System.Drawing.Size(34, 20)
        Me.txtChar.TabIndex = 1
        Me.txtChar.Text = "5"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 101)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(117, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create Password"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(2, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 3
        '
        'chkLetters
        '
        Me.chkLetters.AutoSize = True
        Me.chkLetters.Location = New System.Drawing.Point(37, 32)
        Me.chkLetters.Name = "chkLetters"
        Me.chkLetters.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLetters.Size = New System.Drawing.Size(58, 17)
        Me.chkLetters.TabIndex = 4
        Me.chkLetters.Text = "Letters"
        Me.chkLetters.UseVisualStyleBackColor = True
        '
        'chkSpecial
        '
        Me.chkSpecial.AutoSize = True
        Me.chkSpecial.Location = New System.Drawing.Point(34, 78)
        Me.chkSpecial.Name = "chkSpecial"
        Me.chkSpecial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSpecial.Size = New System.Drawing.Size(61, 17)
        Me.chkSpecial.TabIndex = 5
        Me.chkSpecial.Text = "Special"
        Me.chkSpecial.UseVisualStyleBackColor = True
        '
        'chkNumbers
        '
        Me.chkNumbers.AutoSize = True
        Me.chkNumbers.Location = New System.Drawing.Point(27, 55)
        Me.chkNumbers.Name = "chkNumbers"
        Me.chkNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkNumbers.Size = New System.Drawing.Size(68, 17)
        Me.chkNumbers.TabIndex = 6
        Me.chkNumbers.Text = "Numbers"
        Me.chkNumbers.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(141, 161)
        Me.Controls.Add(Me.chkNumbers)
        Me.Controls.Add(Me.chkSpecial)
        Me.Controls.Add(Me.chkLetters)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtChar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Password Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChar As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chkLetters As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpecial As System.Windows.Forms.CheckBox
    Friend WithEvents chkNumbers As System.Windows.Forms.CheckBox

End Class
