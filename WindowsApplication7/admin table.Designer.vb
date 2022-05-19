<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_table
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
        Me.components = New System.ComponentModel.Container()
        Dim Admin_usernameLabel As System.Windows.Forms.Label
        Dim Admin_passwordLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Me.Database2DataSet = New WindowsApplication7.Database2DataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter()
        Me.TableAdapterManager = New WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager()
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Admin_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Admin_passwordTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.BanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BanTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Admin_usernameLabel = New System.Windows.Forms.Label()
        Admin_passwordLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Admin_usernameLabel
        '
        Admin_usernameLabel.AutoSize = True
        Admin_usernameLabel.Location = New System.Drawing.Point(614, 55)
        Admin_usernameLabel.Name = "Admin_usernameLabel"
        Admin_usernameLabel.Size = New System.Drawing.Size(117, 17)
        Admin_usernameLabel.TabIndex = 1
        Admin_usernameLabel.Text = "admin username:"
        '
        'Admin_passwordLabel
        '
        Admin_passwordLabel.AutoSize = True
        Admin_passwordLabel.Location = New System.Drawing.Point(614, 83)
        Admin_passwordLabel.Name = "Admin_passwordLabel"
        Admin_passwordLabel.Size = New System.Drawing.Size(114, 17)
        Admin_passwordLabel.TabIndex = 3
        Admin_passwordLabel.Text = "admin password:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(614, 111)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(74, 17)
        First_nameLabel.TabIndex = 5
        First_nameLabel.Text = "first name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(614, 139)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(73, 17)
        Last_nameLabel.TabIndex = 7
        Last_nameLabel.Text = "last name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(614, 167)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(52, 17)
        PhoneLabel.TabIndex = 9
        PhoneLabel.Text = "phone:"
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        Me.AdminBindingSource.DataSource = Me.Database2DataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanTableAdapter = Nothing
        Me.TableAdapterManager.Program_1TableAdapter = Nothing
        Me.TableAdapterManager.Program_2TableAdapter = Nothing
        Me.TableAdapterManager.Program_3TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AutoGenerateColumns = False
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AdminDataGridView.DataSource = Me.AdminBindingSource
        Me.AdminDataGridView.Location = New System.Drawing.Point(12, 43)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.RowTemplate.Height = 24
        Me.AdminDataGridView.Size = New System.Drawing.Size(547, 305)
        Me.AdminDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "admin username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "admin username"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "admin password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "admin password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "first name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "first name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "last name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "last name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Admin_usernameTextBox
        '
        Me.Admin_usernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "admin username", True))
        Me.Admin_usernameTextBox.Location = New System.Drawing.Point(737, 52)
        Me.Admin_usernameTextBox.Name = "Admin_usernameTextBox"
        Me.Admin_usernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Admin_usernameTextBox.TabIndex = 2
        '
        'Admin_passwordTextBox
        '
        Me.Admin_passwordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "admin password", True))
        Me.Admin_passwordTextBox.Location = New System.Drawing.Point(737, 80)
        Me.Admin_passwordTextBox.Name = "Admin_passwordTextBox"
        Me.Admin_passwordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Admin_passwordTextBox.TabIndex = 4
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "first name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(737, 108)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.First_nameTextBox.TabIndex = 6
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "last name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(737, 136)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Last_nameTextBox.TabIndex = 8
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(737, 164)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "add new"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(772, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(590, 287)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "move to user"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(772, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "ban"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(591, 336)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.Database2DataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(737, 52)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 17
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(737, 52)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PasswordTextBox.TabIndex = 19
        '
        'First_nameTextBox1
        '
        Me.First_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "first name", True))
        Me.First_nameTextBox1.Location = New System.Drawing.Point(737, 52)
        Me.First_nameTextBox1.Name = "First_nameTextBox1"
        Me.First_nameTextBox1.ReadOnly = True
        Me.First_nameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.First_nameTextBox1.TabIndex = 21
        '
        'Last_nameTextBox1
        '
        Me.Last_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "last name", True))
        Me.Last_nameTextBox1.Location = New System.Drawing.Point(737, 52)
        Me.Last_nameTextBox1.Name = "Last_nameTextBox1"
        Me.Last_nameTextBox1.ReadOnly = True
        Me.Last_nameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Last_nameTextBox1.TabIndex = 23
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(737, 52)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.ReadOnly = True
        Me.PhoneTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox1.TabIndex = 25
        '
        'BanBindingSource
        '
        Me.BanBindingSource.DataMember = "Ban"
        Me.BanBindingSource.DataSource = Me.Database2DataSet
        '
        'BanTableAdapter
        '
        Me.BanTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BanBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(737, 52)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 27
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BanBindingSource, "username", True))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(737, 52)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.ReadOnly = True
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox1.TabIndex = 29
        '
        'admin_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 436)
        Me.Controls.Add(Me.Admin_usernameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.UsernameTextBox1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.First_nameTextBox1)
        Me.Controls.Add(Me.Last_nameTextBox1)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Admin_usernameLabel)
        Me.Controls.Add(Admin_passwordLabel)
        Me.Controls.Add(Me.Admin_passwordTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.AdminDataGridView)
        Me.Name = "admin_table"
        Me.Text = "admin_table"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database2DataSet As WindowsApplication7.Database2DataSet
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdminDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Admin_usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Admin_passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BanTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
End Class
