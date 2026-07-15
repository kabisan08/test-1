Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sign Up"
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse
           String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("All fields are required")
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match")
            Return
        End If

        If password.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters")
            Return
        End If

        If CsvHelper.RegisterUser(firstName, lastName, email, password) Then
            MessageBox.Show("Account created successfully!")
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            Me.Close()
        Else
            MessageBox.Show("Email already exists")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class