<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim PhoneLabel1 As System.Windows.Forms.Label
        Dim UsernameLabel2 As System.Windows.Forms.Label
        Dim PhoneLabel2 As System.Windows.Forms.Label
        Me.Database2DataSet = New WindowsApplication7.Database2DataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter()
        Me.TableAdapterManager = New WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BanTableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Program_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Program_1TableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.Program_1TableAdapter()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Program_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Program_2TableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.Program_2TableAdapter()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.Program_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Program_3TableAdapter = New WindowsApplication7.Database2DataSetTableAdapters.Program_3TableAdapter()
        Me.UsernameTextBox2 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox2 = New System.Windows.Forms.TextBox()
        PhoneLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        UsernameLabel1 = New System.Windows.Forms.Label()
        PhoneLabel1 = New System.Windows.Forms.Label()
        UsernameLabel2 = New System.Windows.Forms.Label()
        PhoneLabel2 = New System.Windows.Forms.Label()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Program_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Program_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Program_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanTableAdapter = Me.BanTableAdapter
        Me.TableAdapterManager.Program_1TableAdapter = Me.Program_1TableAdapter
        Me.TableAdapterManager.Program_2TableAdapter = Me.Program_2TableAdapter
        Me.TableAdapterManager.Program_3TableAdapter = Me.Program_3TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(215, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(215, 264)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 6
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "program 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "program 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(161, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "program 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Program_1BindingSource
        '
        Me.Program_1BindingSource.DataMember = "Program 1"
        Me.Program_1BindingSource.DataSource = Me.Database2DataSet
        '
        'Program_1TableAdapter
        '
        Me.Program_1TableAdapter.ClearBeforeFill = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_1BindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(536, 152)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 12
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_1BindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(536, 180)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 14
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(455, 183)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(52, 17)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "phone:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(455, 155)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 11
        UsernameLabel.Text = "username:"
        '
        'Program_2BindingSource
        '
        Me.Program_2BindingSource.DataMember = "Program 2"
        Me.Program_2BindingSource.DataSource = Me.Database2DataSet
        '
        'Program_2TableAdapter
        '
        Me.Program_2TableAdapter.ClearBeforeFill = True
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Location = New System.Drawing.Point(455, 220)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(75, 17)
        UsernameLabel1.TabIndex = 16
        UsernameLabel1.Text = "username:"
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_2BindingSource, "username", True))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(536, 217)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox1.TabIndex = 17
        '
        'PhoneLabel1
        '
        PhoneLabel1.AutoSize = True
        PhoneLabel1.Location = New System.Drawing.Point(455, 248)
        PhoneLabel1.Name = "PhoneLabel1"
        PhoneLabel1.Size = New System.Drawing.Size(52, 17)
        PhoneLabel1.TabIndex = 18
        PhoneLabel1.Text = "phone:"
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_2BindingSource, "phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(536, 245)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox1.TabIndex = 19
        '
        'Program_3BindingSource
        '
        Me.Program_3BindingSource.DataMember = "Program 3"
        Me.Program_3BindingSource.DataSource = Me.Database2DataSet
        '
        'Program_3TableAdapter
        '
        Me.Program_3TableAdapter.ClearBeforeFill = True
        '
        'UsernameLabel2
        '
        UsernameLabel2.AutoSize = True
        UsernameLabel2.Location = New System.Drawing.Point(455, 288)
        UsernameLabel2.Name = "UsernameLabel2"
        UsernameLabel2.Size = New System.Drawing.Size(75, 17)
        UsernameLabel2.TabIndex = 21
        UsernameLabel2.Text = "username:"
        '
        'UsernameTextBox2
        '
        Me.UsernameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_3BindingSource, "username", True))
        Me.UsernameTextBox2.Location = New System.Drawing.Point(536, 285)
        Me.UsernameTextBox2.Name = "UsernameTextBox2"
        Me.UsernameTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox2.TabIndex = 22
        '
        'PhoneLabel2
        '
        PhoneLabel2.AutoSize = True
        PhoneLabel2.Location = New System.Drawing.Point(455, 316)
        PhoneLabel2.Name = "PhoneLabel2"
        PhoneLabel2.Size = New System.Drawing.Size(52, 17)
        PhoneLabel2.TabIndex = 23
        PhoneLabel2.Text = "phone:"
        '
        'PhoneTextBox2
        '
        Me.PhoneTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Program_3BindingSource, "phone", True))
        Me.PhoneTextBox2.Location = New System.Drawing.Point(536, 313)
        Me.PhoneTextBox2.Name = "PhoneTextBox2"
        Me.PhoneTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox2.TabIndex = 24
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 376)
        Me.Controls.Add(UsernameLabel2)
        Me.Controls.Add(Me.UsernameTextBox2)
        Me.Controls.Add(PhoneLabel2)
        Me.Controls.Add(Me.PhoneTextBox2)
        Me.Controls.Add(UsernameLabel1)
        Me.Controls.Add(Me.UsernameTextBox1)
        Me.Controls.Add(PhoneLabel1)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Program_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Program_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Program_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database2DataSet As WindowsApplication7.Database2DataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.userTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication7.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BanTableAdapter As WindowsApplication7.Database2DataSetTableAdapters.BanTableAdapter
    Friend WithEvents BanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Program_1TableAdapter As WindowsApplication7.Database2DataSetTableAdapters.Program_1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Program_1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Program_2TableAdapter As WindowsApplication7.Database2DataSetTableAdapters.Program_2TableAdapter
    Friend WithEvents Program_2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Program_3TableAdapter As WindowsApplication7.Database2DataSetTableAdapters.Program_3TableAdapter
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Program_3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox2 As System.Windows.Forms.TextBox
End Class
