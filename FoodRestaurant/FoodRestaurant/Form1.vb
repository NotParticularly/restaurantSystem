Public Class Form1
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

        Dim result = MessageBox.Show("Are u sure u want to exit the application?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
        pnlPizza.Visible = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj = New Beverages
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New Chickens
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblPasta_Click(sender As Object, e As EventArgs) Handles lblPasta.Click
        Dim obj = New Pasta
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub txtBundle_Click(sender As Object, e As EventArgs) Handles txtBundle.Click
        Dim obj = New Bundles
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbQuantity.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 499
            paymentfunction.order = "Extreme Hawaiian Overload"
            paymentfunction.qty = cbQuantity.Text
            paymentfunction.quantity = Val(cbQuantity.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity


            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cbQty2.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 459
            paymentfunction.order = "Extreme All-in Overload"
            paymentfunction.qty = cbQty2.Text
            paymentfunction.quantity = Val(cbQty2.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cbQty3.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 399
            paymentfunction.order = "Extreme Pepperoni Overload"
            paymentfunction.qty = cbQty3.Text
            paymentfunction.quantity = Val(cbQty3.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cbQty4.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 599
            paymentfunction.order = "Extreme All meat overload"
            paymentfunction.qty = cbQty4.Text
            paymentfunction.quantity = Val(cbQty4.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cbQty5.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 329
            paymentfunction.order = "Hawaiian Overload"
            paymentfunction.qty = cbQty5.Text
            paymentfunction.quantity = Val(cbQty5.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cbQty6.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 489
            paymentfunction.order = "All-in Overload"
            paymentfunction.qty = cbQty6.Text
            paymentfunction.quantity = Val(cbQty6.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub
End Class
