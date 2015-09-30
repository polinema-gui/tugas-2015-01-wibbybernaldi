Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.CadetBlue Then
            MyBase.BackColor = Color.FloralWhite
        Else : MyBase.BackColor = Color.CadetBlue
        End If
    End Sub
End Class
