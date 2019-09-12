Public Class Form2
    Dim Ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Bd.txt"
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()


    End Sub
   
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        My.Computer.FileSystem.WriteAllText(Ruta, vbCrLf & CIText.Text & " " & NameTxt.Text & " " & SurnameTxt.Text & " " & MovilTxt.Text & " " & TelephoneTxt.Text & " " & AddressTxt.Text & DateHappy.Value & vbCrLf, True)
        MsgBox("Se guardo con exito")
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        CIText.Text = ""
        NameTxt.Text = ""
        SurnameTxt.Text = ""
        MovilTxt.Text = ""
        TelephoneTxt.Text = ""
        AddressTxt.Text = ""


        ButtonSave.Enabled = True
    End Sub
End Class