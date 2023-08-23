Imports System.Data.SqlClient
Public Class frmLogin

    Dim connection As SqlConnection = New SqlConnection("Data Source=YONGCHUN_VICTUS\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim command As SqlCommand = New SqlCommand("SELECT username, password FROM AdminUser WHERE username ='" + txtUsername.Text +
                                              "' and password='" + txtPassword.Text + "'", connection)

        Dim sda As SqlDataAdapter = New SqlDataAdapter(command)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success!", "Verifrication", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim dashboard As New frmDashboard
            dashboard.Show()
            Me.Hide()

        Else

            MessageBox.Show("Wrong Username or Password!", "Verifrication", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked = True Then

            txtPassword.PasswordChar = ""

        ElseIf chkShowPassword.Checked = False Then

            txtPassword.PasswordChar = "*"

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim cancelConfirm As DialogResult = MessageBox.Show("Are you sure want to quit this program?", "Quit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancelConfirm = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim forgotPass As New frmForgetPassword
        forgotPass.Show()
        Me.Hide()

    End Sub
End Class
