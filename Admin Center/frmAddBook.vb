Imports System.Data.SqlClient

Public Class frmAddBook

    Dim con = New SqlConnection("Data Source=YONGCHUN_VICTUS\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim manageBook As New frmManageBooks
        manageBook.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click

        If txtBookID.Text = "" Or txtBookName.Text = "" Or txtAuthorName.Text = "" Or updQuantity.Text = "" Or cboCategory.Text = "" Then
            MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf IsNumeric(txtBookID.Text) = False Then

            MessageBox.Show("Please key in number only in Book ID.", "Book ID Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            con.Open()
            Dim query = "INSERT into Books VALUES('" & txtBookID.Text & "','" & txtBookName.Text & "',
                                                        '" & txtAuthorName.Text & "','" & updQuantity.Text & "',
                                                        '" & cboCategory.Text & "') "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book Saved", "Saved Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()

            txtBookID.Clear()
            txtBookName.Clear()
            txtAuthorName.Clear()
            updQuantity.ResetText()
            cboCategory.ResetText()
        End If

    End Sub
    Private Sub txtBookID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBookID.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAddBook_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub
    Private Sub txtBookName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBookName.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAddBook_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtAuthorName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAuthorName.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAddBook_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub cboCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCategory.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAddBook_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub updQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles updQuantity.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAddBook_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

        Dim signOut As New frmLogin

        Dim verify As DialogResult = MessageBox.Show("Are you sure want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verify = DialogResult.Yes Then

            signOut.Show()
            Me.Close()

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim verify As DialogResult = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verify = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click

        Dim mainMenu As New frmDashboard
        mainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click

        Dim manageBooks As New frmManageBooks
        manageBooks.Show()
        Me.Hide()

    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click

        Dim addBooks As New frmAddBook
        addBooks.Show()
        Me.Hide()

    End Sub

    Private Sub UpdateBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookToolStripMenuItem.Click

        Dim updateBook As New frmUpdateBook
        updateBook.Show()
        Me.Hide()

    End Sub

    Private Sub DeleteBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookToolStripMenuItem.Click

        Dim deleteBook As New frmDeleteBook
        deleteBook.Show()
        Me.Hide()

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click

        Dim manageUsers As New frmManageUser
        manageUsers.Show()
        Me.Hide()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

        Dim addUser As New frmAddUser
        addUser.Show()
        Me.Hide()

    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click

        Dim editUser As New frmEditUser
        editUser.Show()
        Me.Hide()

    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click

        Dim deleteUser As New frmDeleteUser
        deleteUser.Show()
        Me.Hide()

    End Sub

    Private Sub HowToUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUserToolStripMenuItem.Click

        MessageBox.Show("Please refer to the user manual supplied with the system.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        MessageBox.Show("Library Management System is a VB.Net assignment created for the DVB1134N - VB Programming.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class