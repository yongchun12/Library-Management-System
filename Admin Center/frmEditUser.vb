Imports System.Data.SqlClient

Public Class frmEditUser

    Dim connection As New SqlConnection("Data Source=YONGCHUN_VICTUS\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT name As 'Name', username As 'Username', password As 'Password',
                                    email As 'E-Mail', phone_number As 'Phone Number'
                                    FROM AdminUser WHERE CONCAT (username, password, name,
                                    email, phone_number) LIKE '%" & valueToSearch & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgvUsers.DataSource = table

    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        connection.Open()
        FilterData(txtSearch.Text)

        Dim selectQuery As String = "SELECT * FROM AdminUser WHERE name = '" & txtSearch.Text & "'"
        Dim command As New SqlCommand(selectQuery, connection)
        Dim myReader As SqlDataReader 'reading data
        myReader = command.ExecuteReader 'execute sql command

        If myReader.Read() Then
            Dim verify As DialogResult = MessageBox.Show("Are you sure want to edit '" & (CType(myReader("name"), String)) & "' information?",
                            "Vefrication", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If verify = DialogResult.Yes Then
                txtSearch.ReadOnly = True

            ElseIf verify = DialogResult.No Then

                txtSearch.ReadOnly = False
                txtSearch.Clear()

            End If
        Else
            MessageBox.Show("No Data Found")
        End If

        connection.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtSearch.Clear()

        txtName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtEmail.Clear()
        txtPhoneNum.Clear()

        dgvUsers.ClearSelection()

        txtSearch.ReadOnly = False

        FilterData(txtSearch.Text)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim updateQuery As String = "UPDATE AdminUser SET name = '" & txtName.Text & "', username = '" & txtUsername.Text & "',
        password = '" & txtPassword.Text & "', email = '" & txtEmail.Text & "', phone_number = '" & txtPhoneNum.Text & "' 
        WHERE name = '" & txtSearch.Text & "'"

        If IsNumeric(txtPhoneNum.Text) = False Then

            MessageBox.Show("Please key in number only for Phone Number.", "Phone Number Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim verify As DialogResult = MessageBox.Show("Are you sure want to update " & txtSearch.Text & " Information?",
                            "Vefrication", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If verify = DialogResult.Yes Then

                ExecuteQuery(updateQuery)
                MessageBox.Show("Update Complete", "Vefrication", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtSearch.Clear()

                txtName.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtEmail.Clear()
                txtPhoneNum.Clear()

                dgvUsers.ClearSelection()

                txtSearch.ReadOnly = False

                FilterData(txtSearch.Text)

            ElseIf verify = DialogResult.No Then

                txtSearch.ReadOnly = True

            End If

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim manageUsers As New frmManageUser
        manageUsers.Show()
        Me.Hide()

    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        Dim i As Integer
        i = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvUsers.Rows(i)

        txtName.Text = selectedRow.Cells(0).Value.ToString()
        txtUsername.Text = selectedRow.Cells(1).Value.ToString()
        txtPassword.Text = selectedRow.Cells(2).Value.ToString()
        txtEmail.Text = selectedRow.Cells(3).Value.ToString()
        txtPhoneNum.Text = selectedRow.Cells(4).Value.ToString()

    End Sub

    Private Sub frmEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData(txtSearch.Text)

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnUpdate_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnUpdate_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnUpdate_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnUpdate_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtPhoneNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhoneNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnUpdate_Click(Nothing, Nothing)
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