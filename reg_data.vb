Public Class reg_data
    Private Sub reg_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.save_btn.Enabled = False
        Me.info_grpbx.Enabled = False
    End Sub

    Private Sub new_btn_Click(sender As Object, e As EventArgs) Handles new_btn.Click
        Me.new_btn.Enabled = False
        Me.save_btn.Enabled = True
        '--------------------
        Me.info_grpbx.Enabled = True
        '--------------------reset the text of all txtbxes--------
        Me.id_txtbx.ResetText()
        Me.fn_txtbx.ResetText()
        Me.ln_txtbx.ResetText()
        Me.tel_txtbx.ResetText()
        Me.cell_txtbx.ResetText()
        Me.email_txtbx.ResetText()
        Me.addy_txtbx.ResetText()
        Me.comment_txtbx.ResetText()
        '---------------------------------------------------------
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        '--------------------
        If (Me.id_txtbx.Text = "") Then
            MessageBox.Show("Please enter your ID!")
            Exit Sub
        End If
        '--------------------
        Me.new_btn.Enabled = True
        Me.save_btn.Enabled = False
        '--------------------
        Me.info_grpbx.Enabled = False
        '--------------------
        Dim fn As String
        fn = "C:\Users\janif\Desktop\projects\pb_class\" + Me.id_txtbx.Text
        '--------------------
        Dim p As String
        '--------------------first name-------------------
        p = fn + "_fn.txt"
        System.IO.File.WriteAllText(p, Me.fn_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------last name--------------------
        p = fn + "_ln.txt"
        System.IO.File.WriteAllText(p, Me.ln_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------tel--------------------
        p = fn + "_tel.txt"
        System.IO.File.WriteAllText(p, Me.tel_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------cell--------------------
        p = fn + "_cell.txt"
        System.IO.File.WriteAllText(p, Me.cell_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------email--------------------
        p = fn + "_email.txt"
        System.IO.File.WriteAllText(p, Me.email_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------addy--------------------
        p = fn + "_addy.txt"
        System.IO.File.WriteAllText(p, Me.addy_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        '--------------------comments--------------------
        p = fn + "_comments.txt"
        System.IO.File.WriteAllText(p, Me.comment_txtbx.Text, System.Text.Encoding.UTF8)
        '-------------------------------------------------
        MessageBox.Show("Saved!")
    End Sub
End Class