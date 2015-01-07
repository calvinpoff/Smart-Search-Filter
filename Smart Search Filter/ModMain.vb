'Smart Search Email Filtering Software
'The function of this software is to read from a text file to acquire a list of email addresses, and then allow a user to select an email address.  While typing into the text box, the user will be given a list
'of up to ten partial matches to what they have already entered.  The user may continue to type, single click a suggestion, or double click a suggestion.  By continuing to type, the user can either manually
'type the desired email address, or narrow down the list of partial matches.  By single clicking a suggestion from the list box, the user selects (but not yet confirms) the email address.  The text box will
'automatically fill with the chosen email address.  By double clicking a suggestion from the list box, the user selects and automatically confirms the email address.

'If an email address has been selected by single clicking, the user may then confirm the email address either by clicking the confirm button or by hitting enter.  The user will not be able to confirm an
'email address by hitting enter if it has not been selected from the list box, however they may still confirm it by clicking the confirm button.  This design decision was used to lower the chance of a user
'accidentally confirming an invalid email address, while still allowing confirmation of an email address which may not yet register in the company's system.

'The list box of partial matches contains up to ten suggestions, and will only display if there is text currently in the text box.  The limit of ten suggestions is because with larger amounts of suggestions,
'it may become difficult for a user to search for the appropriate one.  This limit gives a good number of suggestions, but without cluttering the list.  The list will not display while there is no text in it,
'as it is unlikely that there will be fewer than ten suggestions.



Option Explicit On
Module ModMain      'The purpose of this module is to remove most of the processing from the form, in order to make it easier to manipulate.


    Dim CurrentRead() As String     'This array of strings contains each email address, read directly from the text file.
    Dim Counter As Integer          'This integer is a basic counter variable to be used in for loops.
    Dim SuggestCap As Integer       'This integer is used to determine the upper limit of suggestions which will appear in the list box.
    Dim Suggests As Integer         'This integer is used to determine whether or not the upper limit of suggestions for the list box has been reached.

    Sub Main()                      'The main subroutine.  This is called by the form startup.  It currently calls the initialize subroutine on startup.
        Call Initialize()                   'Calls the initialize subroutine.
    End Sub

    Sub Initialize()                                                                                                        'The subroutine which reads the file and prepares the array of addresses for use.
        Using Read As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Calvin\Documents\VB Stuff\TestFile.txt")       'Uses variable Read to open the given text file.

            Read.TextFieldType = FileIO.FieldType.Delimited         'This and the below line set commas to be the delimiters in the text file.
            Read.SetDelimiters(",")                                 'This decision was made because commas do not appear in email addresses.

            While Not Read.EndOfData                                'While the Read variable, which now contains the text file, is not out of data,
                CurrentRead = Read.ReadFields()                     'the CurrentRead array will begin to acquire each address separately.
            End While
            Array.Sort(CurrentRead)                                 'The CurrentRead array is then sorted alphabetically.
            For Counter = 0 To UBound(CurrentRead)
                CurrentRead(Counter) = LCase(CurrentRead(Counter))  'All Addresses are converted to lower case.
            Next Counter
        End Using
    End Sub
    Sub DetermineInput()                                'This subroutine will determine the nature of the user's input into the text box.
        If frmUIForm.txtInputText.Text = "" Then            'The text box is first checked to see if it contains text or not.  If not...
            SuggestCap = 0                                      'The integer SuggestCap is set to zero.  This will prevent the list box from giving any suggestions.
            Call UpdateEmails()                                 'The UpdateEmails subroutine is called.
        Else                                                'If the text box does contain text...
            SuggestCap = 10                                     'A limit of ten is set on the listbox for suggestions.
            Call UpdateEmails()                                 'The UpdateEmails subroutine is called.
        End If
    End Sub
    Sub UpdateEmails()                                                                                                  'This subroutine updates the list box of suggested emails.
        frmUIForm.lstSuggestEmails.Items.Clear()                                                                            'First, the list box of suggestions is cleared out.
        Suggests = 0                                                                                                        'Suggests is reset, indicating currently no suggestions are in the list box

        For Counter = 0 To UBound(CurrentRead)                                                                              'This for loop running on counter will repeat for each address
            If InStr(CurrentRead(Counter), LCase(frmUIForm.txtInputText.Text)) = 1 And Suggests < SuggestCap Then               'If the text in the text box is the start of the address currently being looked
                frmUIForm.lstSuggestEmails.Items.Add(CurrentRead(Counter))                                                      'at by the program, and there are currently open slots in the list box, the address
                Suggests = Suggests + 1                                                                                         'being looked at will be added to the list box.  Suggests goes up by one.
            End If
            If Suggests = SuggestCap Then                                                                                       'If suggests has reached its cap, and no more suggestions are allowed in the
                Exit For                                                                                                        'list box, then the for loop exits, to save processing time.
            End If
        Next Counter
    End Sub

End Module
