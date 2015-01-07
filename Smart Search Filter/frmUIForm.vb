Option Explicit On
Public Class frmUIForm      'This is the main form which contains the inputs and outputs.  Very little processing is done here.


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load        'This subroutine begins as soon as the form loads.  It calls the main subroutine in the main module.
        Call Main()                                                                             'Calls the main subroutine.
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInputText.TextChanged     'This subroutine is called if the text in the textbox is changed.
        Call DetermineInput()                                                                                       'This calls the subroutine on the main module which determines the nature of the input.
    End Sub
    Private Sub lstSuggestEmails_DoubleClick(sender As Object, e As EventArgs) Handles lstSuggestEmails.DoubleClick     'This subroutine is called if the user double clicks on a suggestion in the list box.
        MsgBox("User has selected " & txtInputText.Text & " as their choice of email")                                          'A message box indicates to the user that their selected address is confirmed.
    End Sub
    Private Sub lstSuggestEmails_KeyDown(sender As Object, e As KeyEventArgs) Handles lstSuggestEmails.KeyDown          'This subroutine is called if the user presses a key while the list box is selected.
        If e.KeyCode = Keys.Enter Then                                                                                      'If the key which has been pressed is the enter key...
            MsgBox("User has selected " & txtInputText.Text & " as their choice of email")                                  'A message box indicates to the user that their selected address is confirmed.
        End If
    End Sub
    Private Sub lstSuggestEmails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSuggestEmails.SelectedIndexChanged   'This subroutine is called if the user single clicks a suggestion in the list box.
        txtInputText.Text = lstSuggestEmails.SelectedItem                                                                                   'The text in the text box is changed to the selected email.
    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click     'This subroutine is called if the user clicks the confirm button.
        MessageBox.Show("User has selected " & txtInputText.Text & " as their choice of email")              'A message box indicates to the user that their selected address or typed address is confirmed.
    End Sub
End Class
