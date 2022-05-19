Public Class User

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Program_3' table. You can move, or remove it, as needed.
        Me.Program_3TableAdapter.Fill(Me.Database2DataSet.Program_3)
        'TODO: This line of code loads data into the 'Database2DataSet.Program_2' table. You can move, or remove it, as needed.
        Me.Program_2TableAdapter.Fill(Me.Database2DataSet.Program_2)
        'TODO: This line of code loads data into the 'Database2DataSet.Program_2' table. You can move, or remove it, as needed.
        Me.Program_2TableAdapter.Fill(Me.Database2DataSet.Program_2)
        'TODO: This line of code loads data into the 'Database2DataSet.Program_1' table. You can move, or remove it, as needed.
        Me.Program_1TableAdapter.Fill(Me.Database2DataSet.Program_1)
        'TODO: This line of code loads data into the 'Database2DataSet.Ban' table. You can move, or remove it, as needed.
        Me.BanTableAdapter.Fill(Me.Database2DataSet.Ban)
        'TODO: This line of code loads data into the 'Database2DataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database2DataSet.user)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim j As Integer = Program_1BindingSource.Count + Program_2BindingSource.Count + Program_3BindingSource.Count
        For n = 1 To j
            If UsernameTextBox1.Text = TextBox1.Text Or UsernameTextBox.Text = TextBox1.Text Or UsernameTextBox2.Text = TextBox1.Text Then
                MsgBox("you already registered", , "error")
                Exit For
            Else
                Program_1BindingSource.AddNew()
                UsernameTextBox.Text = TextBox1.Text
                PhoneTextBox.Text = TextBox2.Text
                Program_1BindingSource.EndEdit()
                Program_1TableAdapter.Update(Database2DataSet.Program_1)
                MsgBox("you have now registered", , "register completed")
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim j As Integer = Program_1BindingSource.Count + Program_2BindingSource.Count + Program_3BindingSource.Count
        For n = 1 To j
            If UsernameTextBox1.Text = TextBox1.Text Or UsernameTextBox.Text = TextBox1.Text Or UsernameTextBox2.Text = TextBox1.Text Then
                MsgBox("you already registered", , "error")
                Exit For
            Else
                Program_2BindingSource.AddNew()
                UsernameTextBox1.Text = TextBox1.Text
                PhoneTextBox1.Text = TextBox2.Text
                Program_2BindingSource.EndEdit()
                Program_2TableAdapter.Update(Database2DataSet.Program_2)
                MsgBox("you have now registered", , "register completed")
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim j As Integer = Program_1BindingSource.Count + Program_2BindingSource.Count + Program_3BindingSource.Count
        For n = 1 To j
            If UsernameTextBox1.Text = TextBox1.Text Or UsernameTextBox.Text = TextBox1.Text Or UsernameTextBox2.Text = TextBox1.Text Then
                MsgBox("you already registered", , "error")
                Exit For
            Else
                Program_2BindingSource.AddNew()
                UsernameTextBox2.Text = TextBox1.Text
                PhoneTextBox2.Text = TextBox2.Text
                Program_3BindingSource.EndEdit()
                Program_3TableAdapter.Update(Database2DataSet.Program_3)
                MsgBox("you have now registered", , "register completed")
                Me.Close()
                Exit For
            End If
        Next
    End Sub
End Class