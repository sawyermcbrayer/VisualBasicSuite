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
        Me.lblUserNum = New System.Windows.Forms.Label()
        Me.txtUserNum = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserNum
        '
        Me.lblUserNum.AutoSize = True
        Me.lblUserNum.Location = New System.Drawing.Point(310, 218)
        Me.lblUserNum.Name = "lblUserNum"
        Me.lblUserNum.Size = New System.Drawing.Size(75, 13)
        Me.lblUserNum.TabIndex = 0
        Me.lblUserNum.Text = "Enter # 1-100:"
        '
        'txtUserNum
        '
        Me.txtUserNum.Location = New System.Drawing.Point(401, 215)
        Me.txtUserNum.MaxLength = 3
        Me.txtUserNum.Name = "txtUserNum"
        Me.txtUserNum.Size = New System.Drawing.Size(40, 20)
        Me.txtUserNum.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(391, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(62, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtUserNum)
        Me.Controls.Add(Me.lblUserNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserNum As Label
    Friend WithEvents txtUserNum As TextBox
    Friend WithEvents btnCalculate As Button
End Class
