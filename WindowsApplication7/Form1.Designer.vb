<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Database2DataSet = New WindowsApplication7.Database2DataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter()
        Me.TableAdapterManager = New WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager()
        Me.UserTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter()
        Me.Admin_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Admin_passwordTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BanTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(424, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(332, 215)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 21)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(401, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(401, 178)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 6
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
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Admin_usernameTextBox
        '
        Me.Admin_usernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "admin username", True))
        Me.Admin_usernameTextBox.Location = New System.Drawing.Point(401, 139)
        Me.Admin_usernameTextBox.Name = "Admin_usernameTextBox"
        Me.Admin_usernameTextBox.ReadOnly = True
        Me.Admin_usernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Admin_usernameTextBox.TabIndex = 9
        '
        'Admin_passwordTextBox
        '
        Me.Admin_passwordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "admin password", True))
        Me.Admin_passwordTextBox.Location = New System.Drawing.Point(401, 139)
        Me.Admin_passwordTextBox.Name = "Admin_passwordTextBox"
        Me.Admin_passwordTextBox.ReadOnly = True
        Me.Admin_passwordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Admin_passwordTextBox.TabIndex = 11
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "first name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(401, 139)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.ReadOnly = True
        Me.First_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.First_nameTextBox.TabIndex = 13
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "last name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(401, 139)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.ReadOnly = True
        Me.Last_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Last_nameTextBox.TabIndex = 15
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(401, 139)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 17
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.Database2DataSet
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(401, 139)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 19
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(401, 139)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PasswordTextBox.TabIndex = 21
        '
        'First_nameTextBox1
        '
        Me.First_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "first name", True))
        Me.First_nameTextBox1.Location = New System.Drawing.Point(401, 139)
        Me.First_nameTextBox1.Name = "First_nameTextBox1"
        Me.First_nameTextBox1.ReadOnly = True
        Me.First_nameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.First_nameTextBox1.TabIndex = 23
        '
        'Last_nameTextBox1
        '
        Me.Last_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "last name", True))
        Me.Last_nameTextBox1.Location = New System.Drawing.Point(401, 139)
        Me.Last_nameTextBox1.Name = "Last_nameTextBox1"
        Me.Last_nameTextBox1.ReadOnly = True
        Me.Last_nameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Last_nameTextBox1.TabIndex = 25
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(401, 139)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.ReadOnly = True
        Me.PhoneTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Create account"
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
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BanBindingSource, "username", True))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(401, 139)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.ReadOnly = True
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox1.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 428)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UsernameTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.First_nameTextBox1)
        Me.Controls.Add(Me.Last_nameTextBox1)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(Me.Admin_usernameTextBox)
        Me.Controls.Add(Me.Admin_passwordTextBox)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Database2DataSet As WindowsApplication7.Database2DataSet
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter
    Friend WithEvents Admin_usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Admin_passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BanTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox

End Class
