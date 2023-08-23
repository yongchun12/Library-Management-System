<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteBook
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblDeleteBook = New System.Windows.Forms.Label()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(812, 175)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 39)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(666, 175)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 39)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategory.Location = New System.Drawing.Point(544, 136)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(81, 20)
        Me.lblCategory.TabIndex = 10
        Me.lblCategory.Text = "Category:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblQuantity.Location = New System.Drawing.Point(549, 92)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 20)
        Me.lblQuantity.TabIndex = 8
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAuthorName.Location = New System.Drawing.Point(22, 184)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(112, 20)
        Me.lblAuthorName.TabIndex = 6
        Me.lblAuthorName.Text = "Author Name:"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBookName.Location = New System.Drawing.Point(33, 140)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(101, 20)
        Me.lblBookName.TabIndex = 4
        Me.lblBookName.Text = "Book Name:"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBookID.Location = New System.Drawing.Point(60, 95)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(74, 20)
        Me.lblBookID.TabIndex = 2
        Me.lblBookID.Text = "Book ID:"
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAuthorName.Location = New System.Drawing.Point(157, 181)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.ReadOnly = True
        Me.txtAuthorName.Size = New System.Drawing.Size(289, 27)
        Me.txtAuthorName.TabIndex = 7
        '
        'txtBookName
        '
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookName.Location = New System.Drawing.Point(157, 137)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.ReadOnly = True
        Me.txtBookName.Size = New System.Drawing.Size(289, 27)
        Me.txtBookName.TabIndex = 5
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSearch.Location = New System.Drawing.Point(186, 23)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(101, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Book Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearch.Location = New System.Drawing.Point(310, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(289, 27)
        Me.txtSearch.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(745, 18)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 29)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(628, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 29)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvBooks
        '
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(19, 73)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 51
        Me.dgvBooks.RowTemplate.Height = 29
        Me.dgvBooks.Size = New System.Drawing.Size(935, 258)
        Me.dgvBooks.TabIndex = 4
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookID.Location = New System.Drawing.Point(157, 92)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(289, 27)
        Me.txtBookID.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.lblSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dgvBooks)
        Me.Panel1.Location = New System.Drawing.Point(12, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 350)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BooksToolStripMenuItem, Me.UsersToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(994, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.MainMenuToolStripMenuItem.Text = "&Main Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.LogOutToolStripMenuItem.Text = "&Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
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
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtQuantity.Location = New System.Drawing.Point(648, 89)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(289, 27)
        Me.txtQuantity.TabIndex = 9
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCategory.Location = New System.Drawing.Point(648, 133)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(289, 27)
        Me.txtCategory.TabIndex = 11
        '
        'lblDeleteBook
        '
        Me.lblDeleteBook.AutoSize = True
        Me.lblDeleteBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDeleteBook.Location = New System.Drawing.Point(12, 41)
        Me.lblDeleteBook.Name = "lblDeleteBook"
        Me.lblDeleteBook.Size = New System.Drawing.Size(206, 38)
        Me.lblDeleteBook.TabIndex = 1
        Me.lblDeleteBook.Text = "Delete Book"
        '
        'frmDeleteBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(994, 597)
        Me.Controls.Add(Me.lblDeleteBook)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblAuthorName)
        Me.Controls.Add(Me.lblBookName)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDeleteBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Book"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAuthorName As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblDeleteBook As Label
End Class
