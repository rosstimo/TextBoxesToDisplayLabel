Public Class TextBoxesToDisplayLabelForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ValidateTextBoxes()

        If AccumulateMessage("", False) <> "" Then 'TODO ugly, fix?
            AlertUser(AccumulateMessage("", False))
        End If

        'CreateEmail() 'Don't generate if alert user
        Display()

    End Sub

    Sub ValidateTextBoxes()

        If LastNameTextBox.Text = "" Then
            AccumulateMessage("Last Name is a required field", False)
            LastNameTextBox.Focus()
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessage("First Name is a required field", False)
            FirstNameTextBox.Focus()
        End If


        If EmailTextBox.Text = "" Then
            CreateEmail()
        End If

    End Sub

    Sub AlertUser(ByVal message As String)
        MsgBox(message)
        AccumulateMessage("", True) 'TODO move?
    End Sub

    Function AccumulateMessage(ByVal newMessage As String, ByVal Clear As Boolean) As String
        Static message As String

        If Clear Then
            message = ""
        Else
            message &= newMessage & vbNewLine
        End If

        Return message
    End Function

    Sub CreateEmail()
        EmailTextBox.Text = FirstNameTextBox.Text _
                            & "." & LastNameTextBox.Text _
                            & "@acme.com"
    End Sub

    Sub Display()
        DisplayLabel.Text = FirstNameTextBox.Text _
                            & vbNewLine & LastNameTextBox.Text _
                            & vbNewLine & EmailTextBox.Text
    End Sub



End Class
