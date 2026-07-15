Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userEmail As String = txtEmail.Text.Trim()
        Dim userPassword As String = txtPassword.Text

        If String.IsNullOrEmpty(userEmail) OrElse String.IsNullOrEmpty(userPassword) Then
            MessageBox.Show("Please enter email and password")
            Return
        End If

        If CsvHelper.AuthenticateUser(userEmail, userPassword) Then
            MessageBox.Show("Login successful!")
            GlobalVariables.LoggedInUser = userEmail
            txtEmail.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Invalid credentials")
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim signupForm As New Form2()
        signupForm.ShowDialog()
    End Sub
End Class