Public Class search_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn As String
        fn = "C:\Users\janif\Desktop\projects\pb_class\" + Me.id_search_txtbx.Text
        '--------------------
        Dim p As String
        Dim r As String
        '--------------------first name-------------------
        p = fn + "_fn.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.fn_txtbx.Text = r
        Else
            Me.fn_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------last name-------------------
        p = fn + "_ln.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.ln_txtbx.Text = r
        Else
            Me.ln_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------tel-------------------
        p = fn + "_tel.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.tel_txtbx.Text = r
        Else
            Me.tel_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------cell-------------------
        p = fn + "_cell.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.cell_txtbx.Text = r
        Else
            Me.cell_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------email-------------------
        p = fn + "_email.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.email_txtbx.Text = r
        Else
            Me.email_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------address-------------------
        p = fn + "_addy.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.addy_txtbx.Text = r
        Else
            Me.addy_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        '--------------------comments-------------------
        p = fn + "_comments.txt"

        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.comment_txtbx.Text = r
        Else
            Me.comment_txtbx.Text = "Not Found"
        End If
        '--------------------------------------------------

        Me.id_txtbx.Text = Me.id_search_txtbx.Text


    End Sub
End Class