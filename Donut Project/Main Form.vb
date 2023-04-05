Public Class Form1

    Dim glazed As Decimal = 1.05
    Dim sugar As Decimal = 1.05
    Dim chocolate As Decimal = 1.25
    Dim filled As Decimal = 1.5

    Dim regular As Decimal = 1.5
    Dim cappuccino As Decimal = 2.75

    Dim price As Decimal
    Dim tax As Decimal
    Dim total As Decimal
    Dim subtotal As Decimal



    Private Sub lblSubtotal_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click, lblTotalDue.Click, lblSalesTax.Click, txtSubTotal.Click, Label2.Click, Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Calculations()
        If radChocolate.Checked = True Then
            price = chocolate
        End If

        If radGlazed.Checked = True Then
            price = glazed

        End If

        If radFilled.Checked = True Then
            price = filled
        End If

        If radSugar.Checked = True Then
            price = sugar
        End If






    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculations()
    End Sub
End Class
