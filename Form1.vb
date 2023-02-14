Public Class frmBurger

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        btnSelectMeal.Enabled = True
        picVeggie.Visible = True
        picPrime.Visible = False
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnVeggie.Enabled = False
        btnPrime.Enabled = False
        btnSelectMeal.Enabled = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
        lblInstructions.Visible = False
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        btnSelectMeal.Enabled = True
        picPrime.Visible = True
        picVeggie.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
