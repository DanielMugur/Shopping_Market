Public Class Form1

    Dim dblProducts As Double
    Dim stSymbol As String = "€"
    Dim DateAndTime As DataSetDateTime

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click

        If cbProducts.Text = "Makeup Pack" Then
            btnDetails.Enabled = False
        End If

        Dim dtResults As Date
        dtResults = Now

        Dim stSee As String
        Dim decBasic, decGold, decBasicPack, decLuxuryPack, decHaircarePack, decOverall As Decimal
        Dim stDisplay As String

        stSee = ""

        If cbOutfitStyle.Text = "" Then
            MsgBox("Must select an Outfit Style", MsgBoxStyle.Exclamation)
        ElseIf cbMakeUpStyle.Text = "" Then
            MsgBox("Must select a MakeUp Style", MsgBoxStyle.Exclamation)
        ElseIf cbHairStyle.Text = "" Then
            MsgBox("Must select a Hair Style", MsgBoxStyle.Exclamation)
        ElseIf cbClotingStyle.Text = "" Then
            MsgBox("Must select Clothing Style", MsgBoxStyle.Exclamation)
        ElseIf cbProducts.Text = "" Then
            MsgBox("Must select a Product", MsgBoxStyle.Exclamation)
        Else

            If ckbBasicPack.Checked = True Then
                decBasic = 29
                stSee &= ckbBasicPack.Text & ControlChars.Tab & ControlChars.Tab & decBasic & ".00" & stSymbol & ControlChars.NewLine
                stSee &= ""
            End If

            If ckbGoldPack.Checked = True Then
                decGold = 189
                stSee &= ckbGoldPack.Text & ControlChars.Tab & ControlChars.Tab & decGold & ".00" & stSymbol & ControlChars.NewLine
                stSee &= ""
            End If

            If rbLuxuryPack.Checked = True Then
                decLuxuryPack = 249
                stSee &= rbLuxuryPack.Text & ControlChars.Tab & ControlChars.Tab & decLuxuryPack & ".00" & stSymbol & ControlChars.NewLine
                stSee &= ""
            End If

            If rbBasicPack.Checked = True Then
                decBasicPack = 129
                stSee &= rbBasicPack.Text & ControlChars.Tab & ControlChars.Tab & decBasicPack & ".00" & stSymbol & ControlChars.NewLine
                stSee &= ""
            End If

            If cbProducts.Text = "Haircare Pack" Then
                decHaircarePack = 39
                stSee &= cbProducts.Text & ControlChars.Tab & ControlChars.Tab & decHaircarePack & ".00" & stSymbol & ControlChars.NewLine
                stSee &= ""
            End If

            decOverall = decBasic + decGold + decBasicPack + decLuxuryPack + decHaircarePack + dblProducts

            stDisplay = "Outfit Style" & ControlChars.Tab & ControlChars.Tab & cbOutfitStyle.Text & ControlChars.NewLine &
                    "MakeUp Style" & ControlChars.Tab & ControlChars.Tab & cbMakeUpStyle.Text & ControlChars.NewLine &
                    "HairStyle" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & cbHairStyle.Text & ControlChars.NewLine &
                    "Clothing Style" & ControlChars.Tab & ControlChars.Tab & cbClotingStyle.Text & ControlChars.NewLine & ControlChars.NewLine & stSee &
                    "---------------------------------------------" & ControlChars.NewLine & "TOTAL" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & decOverall & stSymbol


            Select Case MessageBox.Show("Welcome to Makeovers" & ControlChars.NewLine & ControlChars.NewLine &
                                    dtResults & ControlChars.Tab & ControlChars.NewLine & ControlChars.NewLine &
                                    stDisplay, "Makeovers", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                Case MsgBoxResult.Yes
                    Me.Hide()
                    MessageBox.Show("Do you want to proceed?", "makeovers" & MessageBoxButtons.YesNo & MessageBoxIcon.Question)
                    PayForm.Show()
                Case MsgBoxResult.No

            End Select
            Exit Sub

        End If

    End Sub

    Private Sub cbOutfitStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutfitStyle.SelectedIndexChanged

        If cbOutfitStyle.SelectedItem = " " Then
            MessageBox.Show("Choose outfit style", "Makeovers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbMakeUpStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMakeUpStyle.SelectedIndexChanged

        If cbMakeUpStyle.SelectedItem = " " Then
            MessageBox.Show("Choose makeup style", "Makeovers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbHairStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHairStyle.SelectedIndexChanged

        If cbHairStyle.SelectedItem = " " Then
            MessageBox.Show("Choose hair style", "Makeovers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbClotingStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClotingStyle.SelectedIndexChanged

        If cbClotingStyle.SelectedItem = " " Then
            MessageBox.Show("Choose clothing style", "Makeovers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducts.SelectedIndexChanged

        If cbProducts.SelectedItem = "Makeup Pack" Then
            lblAmountProducts.Text = 59 & stSymbol
            Select Case MessageBox.Show("pack out of stock" & ControlChars.NewLine & "Select another pack", "makeover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok
                    btnDetails.Enabled = False
                Case Else
                    btnDetails.Enabled = True
                    lblAmountProducts.Text = Nothing
                    lblPriceProducts.Visible = True
            End Select
        End If
        If cbProducts.SelectedItem = "Haircare Pack" Then
            lblAmountProducts.Text = 39 & stSymbol
            MessageBox.Show("containing the haircare products used for the makeover", "makeover", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            btnDetails.Enabled = False
            lblAmountProducts.Text = ("OUT OF STOCK")
            lblPriceProducts.Visible = False
        End If

    End Sub

    Private Sub ckbSilverPack_CheckedChanged(sender As Object, e As EventArgs) Handles ckbSilverPack.CheckedChanged

        If ckbSilverPack.Checked = True Then
            MessageBox.Show("PACK OUT OF STOCK", "makeover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ckbSilverPack.Checked = False
            lblAmountSP.Text = ""
        Else
            lblAmountSP.Text = Nothing
        End If

    End Sub

    Private Sub ckbBasicPack_CheckedChanged(sender As Object, e As EventArgs) Handles ckbBasicPack.CheckedChanged

        If ckbBasicPack.Checked = True Then
            MessageBox.Show("DETAILS: 2 unframed 12x16 prints", "makeover", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            ckbSilverPack.Checked = False
            lblAmountBP.Text = ""
        Else
            lblAmountBP.Text = Nothing
        End If

    End Sub

    Private Sub ckbGoldPack_CheckedChanged(sender As Object, e As EventArgs) Handles ckbGoldPack.CheckedChanged

        If ckbGoldPack.Checked = True Then
            MessageBox.Show("DETAILS: 2 unframed 12x16 gloss prints, 2 framed 16x24 prints and 1 framed 24x30 print", "makeover", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            ckbSilverPack.Checked = False
            lblAmountGP.Text = ""
        Else
            lblAmountGP.Text = Nothing
        End If

    End Sub

    Private Sub rbLuxuryPack_CheckedChanged(sender As Object, e As EventArgs) Handles rbLuxuryPack.CheckedChanged

        If rbLuxuryPack.Checked = True Then
            MessageBox.Show("DETAILS: 5 hours: makeover, 45 min photo session, three-course lunch and 3 framed pictures (8x12)", "makeover", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            lblAmountLuxuryPack.Text = 249 & stSymbol
            btnDetails.Enabled = True
        Else
            lblAmountLuxuryPack.Text = Nothing
        End If

    End Sub

    Private Sub rbBasicPack_CheckedChanged(sender As Object, e As EventArgs) Handles rbBasicPack.CheckedChanged

        If rbBasicPack.Checked = True Then
            MessageBox.Show("DETAILS: 3 hours: includes makeover and 15 min photo session and 2 pictures (8x12)", "makeover", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            lblAmountBasicPack.Text = 129 & stSymbol
            btnDetails.Enabled = True
        Else
            lblAmountBasicPack.Text = Nothing
        End If

    End Sub

End Class
