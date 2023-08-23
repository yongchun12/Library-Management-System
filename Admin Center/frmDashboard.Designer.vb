<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.lnkEditUser = New System.Windows.Forms.LinkLabel()
        Me.lnkDeleteUser = New System.Windows.Forms.LinkLabel()
        Me.lnkManageUsers = New System.Windows.Forms.LinkLabel()
        Me.InkaddUser = New System.Windows.Forms.LinkLabel()
        Me.btnAddBooks = New System.Windows.Forms.Button()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lbTitleUsers = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnUpdateBook = New System.Windows.Forms.Button()
        Me.btnManageBooks = New System.Windows.Forms.Button()
        Me.lnkUpdateBook = New System.Windows.Forms.LinkLabel()
        Me.lnkDeleteBook = New System.Windows.Forms.LinkLabel()
        Me.lnkManageBooks = New System.Windows.Forms.LinkLabel()
        Me.lnkAddBook = New System.Windows.Forms.LinkLabel()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.lblTotalBooks = New System.Windows.Forms.Label()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.lblTitleBooks = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(494, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Library Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.Panel1.Controls.Add(Me.btnEditUser)
        Me.Panel1.Controls.Add(Me.btnManageUsers)
        Me.Panel1.Controls.Add(Me.lnkEditUser)
        Me.Panel1.Controls.Add(Me.lnkDeleteUser)
        Me.Panel1.Controls.Add(Me.lnkManageUsers)
        Me.Panel1.Controls.Add(Me.InkaddUser)
        Me.Panel1.Controls.Add(Me.btnAddBooks)
        Me.Panel1.Controls.Add(Me.lblTotalUsers)
        Me.Panel1.Controls.Add(Me.lblUsers)
        Me.Panel1.Location = New System.Drawing.Point(12, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 121)
        Me.Panel1.TabIndex = 5
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackgroundImage = CType(resources.GetObject("btnDeleteUser.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteUser.Location = New System.Drawing.Point(675, 12)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(74, 63)
        Me.btnDeleteUser.TabIndex = 8
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.BackgroundImage = Global.Assignment_1.My.Resources.Resources.Update
        Me.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditUser.Location = New System.Drawing.Point(509, 12)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(74, 63)
        Me.btnEditUser.TabIndex = 6
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.BackgroundImage = CType(resources.GetObject("btnManageUsers.BackgroundImage"), System.Drawing.Image)
        Me.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageUsers.Location = New System.Drawing.Point(190, 12)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(74, 63)
        Me.btnManageUsers.TabIndex = 2
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'lnkEditUser
        '
        Me.lnkEditUser.AutoSize = True
        Me.lnkEditUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lnkEditUser.Location = New System.Drawing.Point(504, 78)
        Me.lnkEditUser.Name = "lnkEditUser"
        Me.lnkEditUser.Size = New System.Drawing.Size(79, 20)
        Me.lnkEditUser.TabIndex = 7
        Me.lnkEditUser.TabStop = True
        Me.lnkEditUser.Text = "Edit User"
        '
        'lnkDeleteUser
        '
        Me.lnkDeleteUser.AutoSize = True
        Me.lnkDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lnkDeleteUser.Location = New System.Drawing.Point(664, 78)
        Me.lnkDeleteUser.Name = "lnkDeleteUser"
        Me.lnkDeleteUser.Size = New System.Drawing.Size(99, 20)
        Me.lnkDeleteUser.TabIndex = 9
        Me.lnkDeleteUser.TabStop = True
        Me.lnkDeleteUser.Text = "Delete User"
        '
        'lnkManageUsers
        '
        Me.lnkManageUsers.AutoSize = True
        Me.lnkManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lnkManageUsers.Location = New System.Drawing.Point(174, 78)
        Me.lnkManageUsers.Name = "lnkManageUsers"
        Me.lnkManageUsers.Size = New System.Drawing.Size(118, 20)
        Me.lnkManageUsers.TabIndex = 3
        Me.lnkManageUsers.TabStop = True
        Me.lnkManageUsers.Text = "Manage Users"
        '
        'InkaddUser
        '
        Me.InkaddUser.AutoSize = True
        Me.InkaddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InkaddUser.Location = New System.Drawing.Point(345, 78)
        Me.InkaddUser.Name = "InkaddUser"
        Me.InkaddUser.Size = New System.Drawing.Size(79, 20)
        Me.InkaddUser.TabIndex = 5
        Me.InkaddUser.TabStop = True
        Me.InkaddUser.Text = "Add User"
        '
        'btnAddBooks
        '
        Me.btnAddBooks.BackgroundImage = Global.Assignment_1.My.Resources.Resources.Add___Edited
        Me.btnAddBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddBooks.Location = New System.Drawing.Point(350, 12)
        Me.btnAddBooks.Name = "btnAddBooks"
        Me.btnAddBooks.Size = New System.Drawing.Size(74, 63)
        Me.btnAddBooks.TabIndex = 4
        Me.btnAddBooks.UseVisualStyleBackColor = True
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalUsers.Location = New System.Drawing.Point(23, 78)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(96, 20)
        Me.lblTotalUsers.TabIndex = 0
        Me.lblTotalUsers.Text = "Total Users"
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUsers.Location = New System.Drawing.Point(41, 15)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(57, 61)
        Me.lblUsers.TabIndex = 0
        Me.lblUsers.Text = "0"
        '
        'lbTitleUsers
        '
        Me.lbTitleUsers.AutoSize = True
        Me.lbTitleUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lbTitleUsers.Location = New System.Drawing.Point(12, 265)
        Me.lbTitleUsers.Name = "lbTitleUsers"
        Me.lbTitleUsers.Size = New System.Drawing.Size(63, 25)
        Me.lbTitleUsers.TabIndex = 4
        Me.lbTitleUsers.Text = "Users"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnDeleteBook)
        Me.Panel2.Controls.Add(Me.btnUpdateBook)
        Me.Panel2.Controls.Add(Me.btnManageBooks)
        Me.Panel2.Controls.Add(Me.lnkUpdateBook)
        Me.Panel2.Controls.Add(Me.lnkDeleteBook)
        Me.Panel2.Controls.Add(Me.lnkManageBooks)
        Me.Panel2.Controls.Add(Me.lnkAddBook)
        Me.Panel2.Controls.Add(Me.btnAddBook)
        Me.Panel2.Controls.Add(Me.lblTotalBooks)
        Me.Panel2.Controls.Add(Me.lblBooks)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(12, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 121)
        Me.Panel2.TabIndex = 3
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.BackgroundImage = CType(resources.GetObject("btnDeleteBook.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteBook.Location = New System.Drawing.Point(675, 15)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(74, 63)
        Me.btnDeleteBook.TabIndex = 8
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'btnUpdateBook
        '
        Me.btnUpdateBook.BackgroundImage = Global.Assignment_1.My.Resources.Resources.Update
        Me.btnUpdateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateBook.Location = New System.Drawing.Point(509, 12)
        Me.btnUpdateBook.Name = "btnUpdateBook"
        Me.btnUpdateBook.Size = New System.Drawing.Size(74, 63)
        Me.btnUpdateBook.TabIndex = 6
        Me.btnUpdateBook.UseVisualStyleBackColor = True
        '
        'btnManageBooks
        '
        Me.btnManageBooks.BackgroundImage = CType(resources.GetObject("btnManageBooks.BackgroundImage"), System.Drawing.Image)
        Me.btnManageBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageBooks.Location = New System.Drawing.Point(190, 12)
        Me.btnManageBooks.Name = "btnManageBooks"
        Me.btnManageBooks.Size = New System.Drawing.Size(74, 63)
        Me.btnManageBooks.TabIndex = 2
        Me.btnManageBooks.UseVisualStyleBackColor = True
        '
        'lnkUpdateBook
        '
        Me.lnkUpdateBook.AutoSize = True
        Me.lnkUpdateBook.Location = New System.Drawing.Point(497, 78)
        Me.lnkUpdateBook.Name = "lnkUpdateBook"
        Me.lnkUpdateBook.Size = New System.Drawing.Size(105, 20)
        Me.lnkUpdateBook.TabIndex = 7
        Me.lnkUpdateBook.TabStop = True
        Me.lnkUpdateBook.Text = "Update Book"
        '
        'lnkDeleteBook
        '
        Me.lnkDeleteBook.AutoSize = True
        Me.lnkDeleteBook.Location = New System.Drawing.Point(664, 78)
        Me.lnkDeleteBook.Name = "lnkDeleteBook"
        Me.lnkDeleteBook.Size = New System.Drawing.Size(101, 20)
        Me.lnkDeleteBook.TabIndex = 9
        Me.lnkDeleteBook.TabStop = True
        Me.lnkDeleteBook.Text = "Delete Book"
        '
        'lnkManageBooks
        '
        Me.lnkManageBooks.AutoSize = True
        Me.lnkManageBooks.Location = New System.Drawing.Point(174, 78)
        Me.lnkManageBooks.Name = "lnkManageBooks"
        Me.lnkManageBooks.Size = New System.Drawing.Size(120, 20)
        Me.lnkManageBooks.TabIndex = 3
        Me.lnkManageBooks.TabStop = True
        Me.lnkManageBooks.Text = "Manage Books"
        '
        'lnkAddBook
        '
        Me.lnkAddBook.AutoSize = True
        Me.lnkAddBook.Location = New System.Drawing.Point(345, 78)
        Me.lnkAddBook.Name = "lnkAddBook"
        Me.lnkAddBook.Size = New System.Drawing.Size(81, 20)
        Me.lnkAddBook.TabIndex = 5
        Me.lnkAddBook.TabStop = True
        Me.lnkAddBook.Text = "Add Book"
        '
        'btnAddBook
        '
        Me.btnAddBook.BackgroundImage = Global.Assignment_1.My.Resources.Resources.Add___Edited
        Me.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddBook.Location = New System.Drawing.Point(350, 12)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(74, 63)
        Me.btnAddBook.TabIndex = 4
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'lblTotalBooks
        '
        Me.lblTotalBooks.AutoSize = True
        Me.lblTotalBooks.Location = New System.Drawing.Point(23, 76)
        Me.lblTotalBooks.Name = "lblTotalBooks"
        Me.lblTotalBooks.Size = New System.Drawing.Size(98, 20)
        Me.lblTotalBooks.TabIndex = 1
        Me.lblTotalBooks.Text = "Total Books"
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBooks.Location = New System.Drawing.Point(41, 15)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(57, 61)
        Me.lblBooks.TabIndex = 0
        Me.lblBooks.Text = "0"
        '
        'lblTitleBooks
        '
        Me.lblTitleBooks.AutoSize = True
        Me.lblTitleBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblTitleBooks.Location = New System.Drawing.Point(12, 98)
        Me.lblTitleBooks.Name = "lblTitleBooks"
        Me.lblTitleBooks.Size = New System.Drawing.Size(67, 25)
        Me.lblTitleBooks.TabIndex = 2
        Me.lblTitleBooks.Text = "Books"
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogOut.Location = New System.Drawing.Point(12, 437)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(125, 39)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "&Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(663, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BooksToolStripMenuItem, Me.UsersToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.LogOutToolStripMenuItem.Text = "&Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageBooksToolStripMenuItem, Me.AddBookToolStripMenuItem, Me.UpdateBookToolStripMenuItem, Me.DeleteBookToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.BooksToolStripMenuItem.Text = "B&ooks"
        '
        'ManageBooksToolStripMenuItem
        '
        Me.ManageBooksToolStripMenuItem.Name = "ManageBooksToolStripMenuItem"
        Me.ManageBooksToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ManageBooksToolStripMenuItem.Text = "Ma&nage Books"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.AddBookToolStripMenuItem.Text = "&Add Book"
        '
        'UpdateBookToolStripMenuItem
        '
        Me.UpdateBookToolStripMenuItem.Name = "UpdateBookToolStripMenuItem"
        Me.UpdateBookToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.UpdateBookToolStripMenuItem.Text = "U&pdate Book"
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.DeleteBookToolStripMenuItem.Text = "&Delete Book"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.AddUserToolStripMenuItem, Me.EditUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.UsersToolStripMenuItem.Text = "&Users"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ManageUsersToolStripMenuItem.Text = "&Manage Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.AddUserToolStripMenuItem.Text = "A&dd User"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.EditUserToolStripMenuItem.Text = "&Edit User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.DeleteUserToolStripMenuItem.Text = "&Delete User"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUserToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToUserToolStripMenuItem
        '
        Me.HowToUserToolStripMenuItem.Name = "HowToUserToolStripMenuItem"
        Me.HowToUserToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.HowToUserToolStripMenuItem.Text = "H&ow to Use"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.AboutToolStripMenuItem.Text = "Abou&t"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblTitleBooks)
        Me.Controls.Add(Me.lbTitleUsers)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents lnkEditUser As LinkLabel
    Friend WithEvents lnkDeleteUser As LinkLabel
    Friend WithEvents lnkManageUsers As LinkLabel
    Friend WithEvents InkaddUser As LinkLabel
    Friend WithEvents btnAddBooks As Button
    Friend WithEvents lbTitleUsers As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents btnUpdateBook As Button
    Friend WithEvents btnManageBooks As Button
    Friend WithEvents lnkUpdateBook As LinkLabel
    Friend WithEvents lnkDeleteBook As LinkLabel
    Friend WithEvents lnkManageBooks As LinkLabel
    Friend WithEvents lnkAddBook As LinkLabel
    Friend WithEvents btnAddBook As Button
    Friend WithEvents lblTotalBooks As Label
    Friend WithEvents lblBooks As Label
    Friend WithEvents lblTitleBooks As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
