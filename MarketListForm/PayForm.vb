Public Class PayForm

    Private Sub btnCompletePayment_Click(sender As Object, e As EventArgs) Handles btnCompletePayment.Click

        If txtCreditCardNumber.Text = String.Empty Then
            MessageBox.Show("Please input your card details", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtStreetName.Text = String.Empty Then
            MessageBox.Show("Please input your street name", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCity.Text = String.Empty Then
            MessageBox.Show("Please input your city", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPostCode.Text = String.Empty Then
            MessageBox.Show("Please input your post code", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtHouseNumber.Text = String.Empty Then
            MessageBox.Show("Please input your ouse number", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thanks for shoping with us", "mekaover", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Form1.Close()
        End If

    End Sub

    Private Sub txtCreditCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditCardNumber.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtStreetName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStreetName.KeyPress

        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress

        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPostCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostCode.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtHouseNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHouseNumber.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

End Class