Imports System.Data.SqlClient
Public Class frmDashboard

    Dim connection = New SqlConnection("Data Source=YONGCHUN_VICTUS\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True")
    Private Sub CountBooks()

        Dim bookNum As Integer
        connection.Open()
        Dim command = "SELECT COUNT(*) from Books"
        Dim countBooks As New SqlCommand(command, connection)
        bookNum = countBooks.ExecuteScalar
        lblBooks.Text = bookNum
        connection.Close()

    End Sub

    Private Sub CountUsers()

        Dim userNum As Integer
        connection.Open()
        Dim command = "SELECT COUNT(*) from AdminUser"
        Dim countUsers As New SqlCommand(command, connection)
        userNum = countUsers.ExecuteScalar
        lblUsers.Text = userNum
        connection.Close()

    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Dim signOut As New frmLogin

        Dim verify As DialogResult = MessageBox.Show("Are you sure want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verify = DialogResult.Yes Then

            signOut.Show()
            Me.Close()

        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim verify As DialogResult = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verify = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CountBooks()
        CountUsers()

    End Sub

    Private Sub btnManageBooks_Click(sender As Object, e As EventArgs) Handles btnManageBooks.Click

        Dim manageBooks As New frmManageBooks
        manageBooks.Show()
        Me.Hide()

    End Sub

    Private Sub lnkManageBooks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkManageBooks.LinkClicked

        Dim manageBooks As New frmManageBooks
        manageBooks.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click

        Dim addBooks As New frmAddBook
        addBooks.Show()
        Me.Hide()

    End Sub

    Private Sub lnkAddBook_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAddBook.LinkClicked

        Dim addBooks As New frmAddBook
        addBooks.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click

        Dim updateBook As New frmUpdateBook
        updateBook.Show()
        Me.Hide()

    End Sub

    Private Sub lnkUpdateBook_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUpdateBook.LinkClicked

        Dim updateBook As New frmUpdateBook
        updateBook.Show()
        Me.Hide()

    End Sub
    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click

        Dim deleteBook As New frmDeleteBook
        deleteBook.Show()
        Me.Hide()

    End Sub

    Private Sub lnkDeleteBook_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeleteBook.LinkClicked

        Dim deleteBook As New frmDeleteBook
        deleteBook.Show()
        Me.Hide()

    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click

        Dim manageUsers As New frmManageUser
        manageUsers.Show()
        Me.Hide()

    End Sub

    Private Sub lnkManageUsers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkManageUsers.LinkClicked

        Dim manageUsers As New frmManageUser
        manageUsers.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddBooks_Click(sender As Object, e As EventArgs) Handles btnAddBooks.Click

        Dim addUser As New frmAddUser
        addUser.Show()
        Me.Hide()

    End Sub

    Private Sub InkaddUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InkaddUser.LinkClicked

        Dim addUser As New frmAddUser
        addUser.Show()
        Me.Hide()

    End Sub
    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click

        Dim editUser As New frmEditUser
        editUser.Show()
        Me.Hide()

    End Sub

    Private Sub lnkEditUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditUser.LinkClicked

        Dim editUser As New frmEditUser
        editUser.Show()
        Me.Hide()

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

        Dim deleteUser As New frmDeleteUser
        deleteUser.Show()
        Me.Hide()

    End Sub

    Private Sub lnkDeleteUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeleteUser.LinkClicked

        Dim deleteUser As New frmDeleteUser
        deleteUser.Show()
        Me.Hide()

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