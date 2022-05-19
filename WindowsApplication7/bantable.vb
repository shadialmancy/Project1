Public Class bantable

    Private Sub BanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub bantable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)
        'TODO: This line of code loads data into the 'Database2DataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet.admin)
        'TODO: This line of code loads data into the 'Database2DataSet.Ban' table. You can move, or remove it, as needed.
        Me.BanTableAdapter.Fill(Me.Database2DataSet.Ban)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BanBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            BanBindingSource.EndEdit()
            BanTableAdapter.Update(Database2DataSet.Ban)
        Catch ex As Exception
            MsgBox("error please make sure that there is no textbox not filled or a username already exists", vbOKOnly, "error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BanBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AdminBindingSource.AddNew()
        Admin_usernameTextBox.Text = UsernameTextBox.Text
        AdminBindingSource.EndEdit()
        AdminTableAdapter.Update(Database2DataSet.admin)
        BanBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        UserBindingSource.AddNew()
        UsernameTextBox1.Text = UsernameTextBox.Text
        UserBindingSource.EndEdit()
        UserTableAdapter.Update(Database2DataSet.user)
        BanBindingSource.RemoveCurrent()
    End Sub

End Class