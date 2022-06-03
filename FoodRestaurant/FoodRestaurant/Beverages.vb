Public Class Beverages
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj = New Beverages
        obj.Show()
        Me.Hide()
        pnlBeverages.Visible = True
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim result = MessageBox.Show("Are u sure u want to exit the application?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQty1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbQty1.Text = "" Then
            MsgBox("Please specify the quantity.")
        Else
            paymentfunction.pizza1 = 25
            paymentfunction.order = "Iced Tea"
            paymentfunction.qty = cbQty1.Text
            paymentfunction.quantity = Val(cbQty1.Text)
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
            paymentfunction.pizza1 = 25
            paymentfunction.order = "Coke"
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
            paymentfunction.pizza1 = 109
            paymentfunction.order = "Coke 1L Solo"
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
            paymentfunction.pizza1 = 25
            paymentfunction.order = "Coke Zero"
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
            paymentfunction.pizza1 = 25
            paymentfunction.order = "Sprite"
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
            paymentfunction.pizza1 = 25
            paymentfunction.order = "Royal"
            paymentfunction.qty = cbQty6.Text
            paymentfunction.quantity = Val(cbQty6.Text)
            paymentfunction.total = paymentfunction.pizza1 * paymentfunction.quantity

            Dim obj = New CustomerInfo
            obj.Show()
            Me.Hide()
        End If
    End Sub
End Class