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
        Me.btnLinSearch = New System.Windows.Forms.Button()
        Me.btn2DArray = New System.Windows.Forms.Button()
        Me.btnRow = New System.Windows.Forms.Button()
        Me.btnColumn = New System.Windows.Forms.Button()
        Me.btnFullArray = New System.Windows.Forms.Button()
        Me.btnSearch2D = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLinSearch
        '
        Me.btnLinSearch.Location = New System.Drawing.Point(176, 181)
        Me.btnLinSearch.Name = "btnLinSearch"
        Me.btnLinSearch.Size = New System.Drawing.Size(118, 88)
        Me.btnLinSearch.TabIndex = 0
        Me.btnLinSearch.Text = "Start Linear Search"
        Me.btnLinSearch.UseVisualStyleBackColor = True
        '
        'btn2DArray
        '
        Me.btn2DArray.Location = New System.Drawing.Point(440, 42)
        Me.btn2DArray.Name = "btn2DArray"
        Me.btn2DArray.Size = New System.Drawing.Size(130, 29)
        Me.btn2DArray.TabIndex = 1
        Me.btn2DArray.Text = "2D Array Build"
        Me.btn2DArray.UseVisualStyleBackColor = True
        '
        'btnRow
        '
        Me.btnRow.Location = New System.Drawing.Point(369, 77)
        Me.btnRow.Name = "btnRow"
        Me.btnRow.Size = New System.Drawing.Size(75, 23)
        Me.btnRow.TabIndex = 2
        Me.btnRow.Text = "Row Output"
        Me.btnRow.UseVisualStyleBackColor = True
        '
        'btnColumn
        '
        Me.btnColumn.Location = New System.Drawing.Point(462, 77)
        Me.btnColumn.Name = "btnColumn"
        Me.btnColumn.Size = New System.Drawing.Size(92, 23)
        Me.btnColumn.TabIndex = 3
        Me.btnColumn.Text = "Column Output"
        Me.btnColumn.UseVisualStyleBackColor = True
        '
        'btnFullArray
        '
        Me.btnFullArray.Location = New System.Drawing.Point(369, 107)
        Me.btnFullArray.Name = "btnFullArray"
        Me.btnFullArray.Size = New System.Drawing.Size(75, 23)
        Me.btnFullArray.TabIndex = 4
        Me.btnFullArray.Text = "Full Array"
        Me.btnFullArray.UseVisualStyleBackColor = True
        '
        'btnSearch2D
        '
        Me.btnSearch2D.Location = New System.Drawing.Point(462, 107)
        Me.btnSearch2D.Name = "btnSearch2D"
        Me.btnSearch2D.Size = New System.Drawing.Size(92, 23)
        Me.btnSearch2D.TabIndex = 5
        Me.btnSearch2D.Text = "Search Array"
        Me.btnSearch2D.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSearch2D)
        Me.Controls.Add(Me.btnFullArray)
        Me.Controls.Add(Me.btnColumn)
        Me.Controls.Add(Me.btnRow)
        Me.Controls.Add(Me.btn2DArray)
        Me.Controls.Add(Me.btnLinSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLinSearch As Button
    Friend WithEvents btn2DArray As Button
    Friend WithEvents btnRow As Button
    Friend WithEvents btnColumn As Button
    Friend WithEvents btnFullArray As Button
    Friend WithEvents btnSearch2D As Button
End Class
