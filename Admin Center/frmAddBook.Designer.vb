<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBook
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.updQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblAddBooks = New System.Windows.Forms.Label()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1.SuspendLayout()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.updQuantity)
        Me.Panel1.Controls.Add(Me.cboCategory)
        Me.Panel1.Controls.Add(Me.btnAddBook)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.txtAuthorName)
        Me.Panel1.Controls.Add(Me.txtBookName)
        Me.Panel1.Controls.Add(Me.txtBookID)
        Me.Panel1.Controls.Add(Me.lblCategory)
        Me.Panel1.Controls.Add(Me.lblQuantity)
        Me.Panel1.Controls.Add(Me.lblAuthorName)
        Me.Panel1.Controls.Add(Me.lblBookName)
        Me.Panel1.Controls.Add(Me.lblBookID)
        Me.Panel1.Location = New System.Drawing.Point(12, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 286)
        Me.Panel1.TabIndex = 0
        '
        'updQuantity
        '
        Me.updQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.updQuantity.Location = New System.Drawing.Point(208, 144)
        Me.updQuantity.Name = "updQuantity"
        Me.updQuantity.Size = New System.Drawing.Size(325, 27)
        Me.updQuantity.TabIndex = 7
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Fiction", "Non-Fiction"})
        Me.cboCategory.Location = New System.Drawing.Point(208, 183)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(325, 28)
        Me.cboCategory.TabIndex = 9
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddBook.Location = New System.Drawing.Point(424, 234)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(125, 39)
        Me.btnAddBook.TabIndex = 10
        Me.btnAddBook.Text = "&Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(16, 234)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 39)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAuthorName.Location = New System.Drawing.Point(208, 105)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(325, 27)
        Me.txtAuthorName.TabIndex = 5
        '
        'txtBookName
        '
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookName.Location = New System.Drawing.Point(208, 65)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(325, 27)
        Me.txtBookName.TabIndex = 3
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBookID.Location = New System.Drawing.Point(208, 26)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(325, 27)
        Me.txtBookID.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategory.Location = New System.Drawing.Point(80, 186)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(81, 20)
        Me.lblCategory.TabIndex = 8
        Me.lblCategory.Text = "Category:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblQuantity.Location = New System.Drawing.Point(85, 146)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 20)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAuthorName.Location = New System.Drawing.Point(49, 108)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(112, 20)
        Me.lblAuthorName.TabIndex = 4
        Me.lblAuthorName.Text = "Author Name:"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBookName.Location = New System.Drawing.Point(60, 68)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(101, 20)
        Me.lblBookName.TabIndex = 2
        Me.lblBookName.Text = "Book Name:"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBookID.Location = New System.Drawing.Point(87, 29)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(74, 20)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "Book ID:"
        '
        'lblAddBooks
        '
        Me.lblAddBooks.AutoSize = True
        Me.lblAddBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblAddBooks.Location = New System.Drawing.Point(12, 37)
        Me.lblAddBooks.Name = "lblAddBooks"
        Me.lblAddBooks.Size = New System.Drawing.Size(185, 38)
        Me.lblAddBooks.TabIndex = 1
        Me.lblAddBooks.Text = "Add Books"
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
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MainMenuToolStripMenuItem.Text = "&Main Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LogOutToolStripMenuItem.Text = "&Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.ManageBooksToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManageBooksToolStripMenuItem.Text = "Ma&nage Books"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddBookToolStripMenuItem.Text = "&Add Book"
        '
        'UpdateBookToolStripMenuItem
        '
        Me.UpdateBookToolStripMenuItem.Name = "UpdateBookToolStripMenuItem"
        Me.UpdateBookToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UpdateBookToolStripMenuItem.Text = "U&pdate Book"
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.HowToUserToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HowToUserToolStripMenuItem.Text = "H&ow to Use"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "Abou&t"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BooksToolStripMenuItem, Me.UsersToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(590, 390)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblAddBooks)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Book"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAuthorName As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblAddBooks As Label
    Friend WithEvents updQuantity As NumericUpDown
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
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
