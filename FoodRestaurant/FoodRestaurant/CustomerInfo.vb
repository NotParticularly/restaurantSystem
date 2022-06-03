Public Class CustomerInfo

    Private Sub CustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtPurchase.Text = "Php " & paymentfunction.total & ".00"





    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click


        If Val(txtAmount.Text) < Val(paymentfunction.total) Then
            MessageBox.Show("Insuficient balance, Please provide a valid amount.", "Message")
            txtAmount.Clear()
        ElseIf Val(txtAmount.Text) > Val(paymentfunction.total) Then
            MessageBox.Show("Thank you for choosing our service ^^", "Message")
            Dim change As Integer
            change = Val(txtAmount.Text) - Val(paymentfunction.total)
            MessageBox.Show("Here's your receipt" & vbCrLf & "Name : " & txtName.Text & vbCrLf & "Email : " & txtEmail.Text & vbCrLf & "Contact No. : " & txtContact.Text & vbCrLf & "Nat'l : " & txtNatId.Text & vbCrLf & "Address : " & txtAddress.Text & vbCrLf & vbCrLf & "Order" & vbCrLf & paymentfunction.pizza1 & " x " & paymentfunction.qty & " x " & paymentfunction.order & vbCrLf & vbCrLf & "Amount : " & txtAmount.Text & vbCrLf & "Total : " & paymentfunction.total & vbCrLf & "Change : " & change, "Payutyot's Pizza")
        ElseIf txtName.Text = "" Or txtEmail.Text = "" Or txtContact.Text = "" Or txtNatId.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("Please fill the missing blank in Customer information", "Message")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim result = MessageBox.Show("Are u sure u want to exit the application?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class