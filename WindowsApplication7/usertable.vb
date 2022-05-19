Public Class usertable

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub usertable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Ban' table. You can move, or remove it, as needed.
        Me.BanTableAdapter.Fill(Me.Database2DataSet.Ban)
        'TODO: This line of code loads data into the 'Database2DataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet.admin)
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UserBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            UserBindingSource.EndEdit()
            UserTableAdapter.Update(Database2DataSet.user)
        Catch ex As Exception
            MsgBox("error please make sure that there is no textbox not filled or a username already exists", vbOKOnly, "error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UserBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AdminBindingSource.AddNew()
        Admin_usernameTextBox.Text = UsernameTextBox.Text
        Admin_passwordTextBox.Text = PasswordTextBox.Text
        First_nameTextBox1.Text = First_nameTextBox.Text
        Last_nameTextBox1.Text = Last_nameTextBox.Text
        PhoneTextBox1.Text = PhoneTextBox.Text
        AdminBindingSource.EndEdit()
        AdminTableAdapter.Update(Database2DataSet.admin)
        UserBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BanBindingSource.AddNew()
        UsernameTextBox1.Text = UsernameTextBox.Text
        BanBindingSource.EndEdit()
        BanTableAdapter.Update(Database2DataSet.Ban)
    End Sub

    Private Sub PhoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        UserDataGridView.DataSource = Me.Database2DataSet.user.Select("username like'" & TextBox1.Text & "'")
    End Sub
End Class