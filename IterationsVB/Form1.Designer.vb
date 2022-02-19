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
        Me.btnLooper = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnConditional = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLooper
        '
        Me.btnLooper.Location = New System.Drawing.Point(327, 177)
        Me.btnLooper.Name = "btnLooper"
        Me.btnLooper.Size = New System.Drawing.Size(157, 86)
        Me.btnLooper.TabIndex = 0
        Me.btnLooper.Text = "Loop Start"
        Me.btnLooper.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSum.Location = New System.Drawing.Point(164, 177)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(157, 86)
        Me.btnSum.TabIndex = 1
        Me.btnSum.Text = "Odd or Even Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(490, 177)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(157, 86)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "DoWhiles"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(245, 269)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(157, 86)
        Me.btnDoUntil.TabIndex = 3
        Me.btnDoUntil.Text = "DoUntil"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnConditional
        '
        Me.btnConditional.Location = New System.Drawing.Point(408, 269)
        Me.btnConditional.Name = "btnConditional"
        Me.btnConditional.Size = New System.Drawing.Size(157, 86)
        Me.btnConditional.TabIndex = 4
        Me.btnConditional.Text = "Conditional"
        Me.btnConditional.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConditional)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnLooper)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLooper As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnConditional As Button
End Class
