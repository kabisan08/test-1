<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnCancel = New Button()
        btnSignUp = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(185, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 3
        Label4.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(185, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 15)
        Label5.TabIndex = 4
        Label5.Text = "Confirm Password:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(185, 69)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(265, 23)
        txtFirstName.TabIndex = 5
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(185, 126)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(265, 23)
        txtLastName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(185, 187)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(265, 23)
        txtEmail.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(185, 250)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(265, 23)
        txtPassword.TabIndex = 8
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(185, 317)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(265, 23)
        txtConfirmPassword.TabIndex = 9
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(608, 84)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(158, 65)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(608, 207)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(158, 65)
        btnSignUp.TabIndex = 11
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 450)
        Controls.Add(btnSignUp)
        Controls.Add(btnCancel)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSignUp As Button
End Class
