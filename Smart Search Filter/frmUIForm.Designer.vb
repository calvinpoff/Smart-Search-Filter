<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUIForm
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
        Me.txtInputText = New System.Windows.Forms.TextBox()
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.lstSuggestEmails = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.lblListTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputText
        '
        Me.txtInputText.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputText.Location = New System.Drawing.Point(76, 218)
        Me.txtInputText.Name = "txtInputText"
        Me.txtInputText.Size = New System.Drawing.Size(225, 27)
        Me.txtInputText.TabIndex = 0
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Font = New System.Drawing.Font("BankGothic Lt BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterText.Location = New System.Drawing.Point(39, 175)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(311, 22)
        Me.lblEnterText.TabIndex = 1
        Me.lblEnterText.Text = "Enter Email Address Here"
        '
        'lstSuggestEmails
        '
        Me.lstSuggestEmails.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSuggestEmails.FormattingEnabled = True
        Me.lstSuggestEmails.ItemHeight = 19
        Me.lstSuggestEmails.Location = New System.Drawing.Point(454, 218)
        Me.lstSuggestEmails.Name = "lstSuggestEmails"
        Me.lstSuggestEmails.Size = New System.Drawing.Size(217, 194)
        Me.lstSuggestEmails.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("BankGothic Md BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(744, 50)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Smart Search Email Filter"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("BankGothic Lt BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(112, 379)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(160, 47)
        Me.cmdConfirm.TabIndex = 4
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'lblListTitle
        '
        Me.lblListTitle.AutoSize = True
        Me.lblListTitle.Font = New System.Drawing.Font("BankGothic Lt BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListTitle.Location = New System.Drawing.Point(462, 175)
        Me.lblListTitle.Name = "lblListTitle"
        Me.lblListTitle.Size = New System.Drawing.Size(196, 22)
        Me.lblListTitle.TabIndex = 5
        Me.lblListTitle.Text = "Partial Matches"
        '
        'frmUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 522)
        Me.Controls.Add(Me.lblListTitle)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstSuggestEmails)
        Me.Controls.Add(Me.lblEnterText)
        Me.Controls.Add(Me.txtInputText)
        Me.Name = "frmUIForm"
        Me.Text = "Smart Search Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputText As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterText As System.Windows.Forms.Label
    Friend WithEvents lstSuggestEmails As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents lblListTitle As System.Windows.Forms.Label

End Class
