<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxesToDisplayLabelForm
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(28, 29)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.FirstNameTextBox.TabIndex = 0
        Me.FirstNameTextBox.Text = "Tim"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(28, 50)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.LastNameTextBox.TabIndex = 1
        Me.LastNameTextBox.Text = "Rossiter"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(28, 71)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(217, 20)
        Me.EmailTextBox.TabIndex = 2
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(255, 29)
        Me.DisplayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(144, 148)
        Me.DisplayLabel.TabIndex = 3
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(28, 106)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(101, 71)
        Me.DisplayButton.TabIndex = 4
        Me.DisplayButton.Text = "&Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(143, 106)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 71)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TextBoxesToDisplayLabelForm
        '
        Me.AcceptButton = Me.DisplayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(416, 190)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TextBoxesToDisplayLabelForm"
        Me.Text = "Display Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ExitButton As Button
End Class
