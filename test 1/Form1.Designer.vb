<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        btnSignUp = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(442, 44)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(125, 47)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Reotel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(346, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 1
        Label1.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(346, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(346, 180)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(326, 23)
        txtEmail.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(346, 257)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(326, 23)
        txtPassword.TabIndex = 4
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(311, 304)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(450, 19)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "By ticking this box, I confirm that I agree to these                                        of Reotel"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.ForeColor = SystemColors.ActiveCaption
        Label3.LiveSetting = Automation.AutomationLiveSetting.Polite
        Label3.Location = New Point(588, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 15)
        Label3.TabIndex = 6
        Label3.Text = "terms and conditions"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(326, 341)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(111, 36)
        btnSignUp.TabIndex = 7
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(574, 341)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(111, 36)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 419)
        Controls.Add(btnLogin)
        Controls.Add(btnSignUp)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHeading)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogin As Button

End Class
