Public Class Form1

    Private Sub simpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
        Dim frm As New Form2
        EditorsHelper.SetStyleController(frm, styleController1)
        frm.Show()
    End Sub
End Class
