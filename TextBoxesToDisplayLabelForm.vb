Public Class TextBoxesToDisplayLabelForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Display()
    End Sub

    Sub Display()
        'TODO Validate Textbox data
        If EmailTextBox.Text = "" Then
            CreateEmail()
        End If
        DisplayLabel.Text = FirstNameTextBox.Text _
                            & vbNewLine & LastNameTextBox.Text _
                            & vbNewLine & EmailTextBox.Text
    End Sub

    Sub CreateEmail()
        EmailTextBox.Text = FirstNameTextBox.Text _
                            & "." & LastNameTextBox.Text _
                            & "@acme.com"
    End Sub


End Class
