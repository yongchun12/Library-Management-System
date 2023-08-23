Imports System.Data.SqlClient
Public Class frmForgetPassword

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Dim connection As SqlConnection = New SqlConnection("Data Source=YONGCHUN_VICTUS\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True")
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Dim command As SqlCommand = New SqlCommand("SELECT username, email FROM AdminUser WHERE username ='" + txtUsername.Text +
                                              "' and email='" + txtEmail.Text + "'", connection)

        Dim sda As SqlDataAdapter = New SqlDataAdapter(command)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then

            If txtPassword.Text <> txtConfirmPass.Text Then

                MessageBox.Show("The password confirmation does not match.", "Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                Dim updateCommand As String = "UPDATE AdminUser SET password = '" & txtPassword.Text &
                    "'WHERE username = '" & txtUsername.Text & "'AND email = '" & txtEmail.Text & "'"

                MessageBox.Show("Change Password Completed!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ExecuteQuery(updateCommand)

                txtUsername.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                txtConfirmPass.Clear()

            End If

        Else

            MessageBox.Show("The E-Mail and your Username is not match, Please Try Again.", "Verifrication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim loginPage As New frmLogin
        loginPage.Show()
        Me.Hide()

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnChange_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnChange_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnChange_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtConfirmPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPass.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnChange_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub
End Class