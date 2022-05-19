Public Class Register

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)
        'TODO: This line of code loads data into the 'Database2DataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Database2DataSet.admin)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then
            MsgBox("please fill the other textbox", , "error")
            j = 1
            TextBox1.ResetText()
            TextBox2.ResetText()
            TextBox3.ResetText()
            TextBox4.ResetText()
            TextBox5.ResetText()
            TextBox6.ResetText()
            Me.Show()
        End If
        If j = 0 Then
            For i = 1 To UserBindingSource.Count
                If TextBox4.Text = UsernameTextBox.Text Then
                    j = 1
                    MsgBox("username is already exists", , "Error")
                    TextBox4.ResetText()
                    m = 0
                    Exit For
                ElseIf TextBox4.Text = Admin_usernameTextBox.Text Then
                    j = 1
                    MsgBox("username is already exists", , "Error")
                    TextBox4.ResetText()
                    m = 0
                    Exit For
                Else
                    UserBindingSource.MoveNext()
                    AdminBindingSource.MoveNext()
                    j = 0

                End If

            Next
        End If
        If j = 0 Then
            If TextBox5.Text <> TextBox6.Text Then
                MsgBox("password not confirmed", , "error")
                TextBox5.ResetText()
                TextBox6.ResetText()
                m = 0
            Else
                m = 1
            End If
        End If
        If m = 0 Then
            UserBindingSource.MoveFirst()
            i = 1
            Me.Show()
        ElseIf m = 1 And j = 0 Then
            'Me.UserTableAdapter.Insert(Me.TextBox4.Text, Me.TextBox5.Text, Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
            'Me.UserTableAdapter.Fill(Me.Database2DataSet.user)
            'UserBindingSource.AddNew()

            UserBindingSource.AddNew()
            First_nameTextBox1.Text = TextBox1.Text
            Last_nameTextBox1.Text = TextBox2.Text
            PhoneTextBox1.Text = TextBox3.Text
            UsernameTextBox.Text = TextBox4.Text
            PasswordTextBox.Text = TextBox5.Text
            'UserBindingSource.AddNew()
            UserBindingSource.EndEdit()
            UserTableAdapter.Update(Database2DataSet.user)
            Application.Restart()
        Else
            Me.Show()
        End If


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class