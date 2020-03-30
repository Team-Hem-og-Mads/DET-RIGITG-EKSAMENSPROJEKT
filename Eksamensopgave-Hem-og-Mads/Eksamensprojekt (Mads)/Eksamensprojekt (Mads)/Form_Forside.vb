Public Class Form_Forside
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Opgaver.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles But_Formelsamling.Click
        Form_Formelsamling.Show()
        Me.Hide()
    End Sub
End Class
