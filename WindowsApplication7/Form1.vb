Public Class Form1

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Ban' table. You can move, or remove it, as needed.
        Me.BanTableAdapter.Fill(Me.Database2DataSet.Ban)
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)
        'TODO: This line of code loads data into the 'Database2DataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet.admin)
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim j As Integer
        For i = 1 To UserBindingSource.Count
            If TextBox1.Text = UsernameTextBox1.Text Then
                MsgBox("you have been banned", vbOKOnly, "banned")
                j = 1
                Exit For
            ElseIf TextBox1.Text = UsernameTextBox.Text And TextBox2.Text = PasswordTextBox.Text Then
                j = 1
                User.TextBox1.Text = Me.UsernameTextBox.Text
                User.TextBox2.Text = Me.PhoneTextBox1.Text
                User.Show()
                Me.Hide()
            ElseIf TextBox1.Text = Admin_usernameTextBox.Text And TextBox2.Text = Admin_passwordTextBox.Text Then
                j = 1
                Admin.Show()
                Me.Hide()
            Else
                UserBindingSource.MoveNext()
                AdminBindingSource.MoveNext()
                BanBindingSource.MoveNext()
                j = 0
            End If
        Next

        If j = 0 Then
            Me.Hide()
            MsgBox("Failed to login", , "Login Failed")
            

           
            Me.Show()


        End If
        TextBox1.ResetText()
        TextBox2.ResetText()
        i = 1
        UserBindingSource.MoveFirst()
        AdminBindingSource.MoveFirst()
        BanBindingSource.MoveFirst()
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class
