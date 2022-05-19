Public Class admin_table

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub


    Private Sub AdminBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub admin_table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Ban' table. You can move, or remove it, as needed.
        Me.BanTableAdapter.Fill(Me.Database2DataSet.Ban)
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)
        'TODO: This line of code loads data into the 'Database2DataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet.admin)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AdminBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            AdminBindingSource.EndEdit()
            AdminTableAdapter.Update(Database2DataSet.admin)
        Catch ex As Exception
            MsgBox("error please make sure that there is no textbox not filled or a username already exists", vbOKOnly, "error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AdminBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UserBindingSource.AddNew()
        UsernameTextBox.Text = Admin_usernameTextBox.Text
        PasswordTextBox.Text = Admin_passwordTextBox.Text
        First_nameTextBox1.Text = First_nameTextBox.Text
        Last_nameTextBox1.Text = Last_nameTextBox.Text
        PhoneTextBox1.Text = PhoneTextBox.Text
        UserBindingSource.EndEdit()
        UserTableAdapter.Update(Database2DataSet.user)
        AdminBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BanBindingSource.AddNew()
        UsernameTextBox1.Text = Admin_usernameTextBox.Text
        BanBindingSource.EndEdit()
        BanTableAdapter.Update(Database2DataSet.Ban)
    End Sub

    Private Sub PhoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class