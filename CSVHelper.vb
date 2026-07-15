Imports System
Imports System.IO
Imports System.Collections.Generic

Public Class CSVHelper
    Private Shared csvPath As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "UserApp",
        "users.txt"
    )

    Public Shared Sub InitializeFile()
        Dim dir As String = Path.GetDirectoryName(csvPath)
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        End If

        If Not File.Exists(csvPath) Then
            File.WriteAllText(csvPath, "FirstName|LastName|Email|Password" & vbCrLf)
        End If
    End Sub

    Public Shared Function RegisterUser(fname As String, lname As String, email As String, pwd As String) As Boolean
        Try
            InitializeFile()

            If EmailExists(email) Then
                Return False
            End If

            Dim entry As String = fname & "|" & lname & "|" & email & "|" & pwd
            File.AppendAllText(csvPath, entry & vbCrLf)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function EmailExists(email As String) As Boolean
        Try
            InitializeFile()
            Dim allLines As String() = File.ReadAllLines(csvPath)

            For Each line In allLines
                If line.Contains("|") Then
                    Dim parts As String() = line.Split("|"c)
                    If parts.Length >= 3 Then
                        If parts(2).ToLower() = email.ToLower() Then
                            Return True
                        End If
                    End If
                End If
            Next

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function AuthenticateUser(email As String, pwd As String) As Boolean
        Try
            InitializeFile()
            Dim allLines As String() = File.ReadAllLines(csvPath)

            For Each line In allLines
                If line.Contains("|") Then
                    Dim parts As String() = line.Split("|"c)
                    If parts.Length >= 4 Then
                        If parts(2).ToLower() = email.ToLower() AndAlso parts(3) = pwd Then
                            Return True
                        End If
                    End If
                End If
            Next

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function FetchUserData(email As String) As Dictionary(Of String, String)
        Try
            InitializeFile()
            Dim userData As New Dictionary(Of String, String)
            Dim allLines As String() = File.ReadAllLines(csvPath)

            For Each line In allLines
                If line.Contains("|") Then
                    Dim parts As String() = line.Split("|"c)
                    If parts.Length >= 4 Then
                        If parts(2).ToLower() = email.ToLower() Then
                            userData("FirstName") = parts(0)
                            userData("LastName") = parts(1)
                            userData("Email") = parts(2)
                            Return userData
                        End If
                    End If
                End If
            Next

            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class