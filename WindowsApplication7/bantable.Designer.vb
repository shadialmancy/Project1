<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bantable
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim Admin_usernameLabel As System.Windows.Forms.Label
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Me.Database2DataSet = New WindowsApplication7.Database2DataSet()
        Me.BanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BanTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter()
        Me.TableAdapterManager = New WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager()
        Me.BanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter()
        Me.Admin_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        UsernameLabel = New System.Windows.Forms.Label()
        Admin_usernameLabel = New System.Windows.Forms.Label()
        UsernameLabel1 = New System.Windows.Forms.Label()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(395, 68)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "username:"
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanTableAdapter = Me.BanTableAdapter
        Me.TableAdapterManager.Program_1TableAdapter = Nothing
        Me.TableAdapterManager.Program_2TableAdapter = Nothing
        Me.TableAdapterManager.Program_3TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'BanDataGridView
        '
        Me.BanDataGridView.AutoGenerateColumns = False
        Me.BanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.BanDataGridView.DataSource = Me.BanBindingSource
        Me.BanDataGridView.Location = New System.Drawing.Point(49, 45)
        Me.BanDataGridView.Name = "BanDataGridView"
        Me.BanDataGridView.RowTemplate.Height = 24
        Me.BanDataGridView.Size = New System.Drawing.Size(245, 309)
        Me.BanDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BanBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(476, 65)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(470, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 34)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(545, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "move to user"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "move to admin"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(559, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "add new"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Admin_usernameLabel
        '
        Admin_usernameLabel.AutoSize = True
        Admin_usernameLabel.Location = New System.Drawing.Point(775, 87)
        Admin_usernameLabel.Name = "Admin_usernameLabel"
        Admin_usernameLabel.Size = New System.Drawing.Size(117, 17)
        Admin_usernameLabel.TabIndex = 34
        Admin_usernameLabel.Text = "admin username:"
        '
        'Admin_usernameTextBox
        '
        Me.Admin_usernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "admin username", True))
        Me.Admin_usernameTextBox.Location = New System.Drawing.Point(898, 84)
        Me.Admin_usernameTextBox.Name = "Admin_usernameTextBox"
        Me.Admin_usernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Admin_usernameTextBox.TabIndex = 35
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
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Location = New System.Drawing.Point(820, 148)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(75, 17)
        UsernameLabel1.TabIndex = 35
        UsernameLabel1.Text = "username:"
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "username", True))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(901, 145)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox1.TabIndex = 36
        '
        'bantable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 460)
        Me.Controls.Add(UsernameLabel1)
        Me.Controls.Add(Me.UsernameTextBox1)
        Me.Controls.Add(Admin_usernameLabel)
        Me.Controls.Add(Me.Admin_usernameTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.BanDataGridView)
        Me.Name = "bantable"
        Me.Text = "bantable"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database2DataSet As WindowsApplication7.Database2DataSet
    Friend WithEvents BanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BanTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.adminTableAdapter
    Friend WithEvents Admin_usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
End Class
