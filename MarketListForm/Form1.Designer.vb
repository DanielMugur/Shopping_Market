<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpbMakeOver = New System.Windows.Forms.GroupBox()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.gpbPackages = New System.Windows.Forms.GroupBox()
        Me.lblAmountLuxuryPack = New System.Windows.Forms.Label()
        Me.lblPriceLuxuryPack = New System.Windows.Forms.Label()
        Me.lblAmountBasicPack = New System.Windows.Forms.Label()
        Me.lblPriceBasicPack = New System.Windows.Forms.Label()
        Me.rbLuxuryPack = New System.Windows.Forms.RadioButton()
        Me.rbBasicPack = New System.Windows.Forms.RadioButton()
        Me.gpbProducts = New System.Windows.Forms.GroupBox()
        Me.lblAmountProducts = New System.Windows.Forms.Label()
        Me.lblPriceProducts = New System.Windows.Forms.Label()
        Me.cbProducts = New System.Windows.Forms.ComboBox()
        Me.gpbPhotoPack = New System.Windows.Forms.GroupBox()
        Me.lblAmountGP = New System.Windows.Forms.Label()
        Me.lblPriceGP = New System.Windows.Forms.Label()
        Me.lblAmountSP = New System.Windows.Forms.Label()
        Me.lblPriceSP = New System.Windows.Forms.Label()
        Me.lblAmountBP = New System.Windows.Forms.Label()
        Me.lblPriceBP = New System.Windows.Forms.Label()
        Me.ckbGoldPack = New System.Windows.Forms.CheckBox()
        Me.ckbSilverPack = New System.Windows.Forms.CheckBox()
        Me.ckbBasicPack = New System.Windows.Forms.CheckBox()
        Me.gpbStyles = New System.Windows.Forms.GroupBox()
        Me.cbClotingStyle = New System.Windows.Forms.ComboBox()
        Me.cbHairStyle = New System.Windows.Forms.ComboBox()
        Me.cbMakeUpStyle = New System.Windows.Forms.ComboBox()
        Me.cbOutfitStyle = New System.Windows.Forms.ComboBox()
        Me.lblClothingStyle = New System.Windows.Forms.Label()
        Me.lblOutfitStyle = New System.Windows.Forms.Label()
        Me.lblHairStyle = New System.Windows.Forms.Label()
        Me.lblMakeUpStyle = New System.Windows.Forms.Label()
        Me.pcbDetails = New System.Windows.Forms.PictureBox()
        Me.gpbMakeOver.SuspendLayout()
        Me.gpbPackages.SuspendLayout()
        Me.gpbProducts.SuspendLayout()
        Me.gpbPhotoPack.SuspendLayout()
        Me.gpbStyles.SuspendLayout()
        CType(Me.pcbDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbMakeOver
        '
        Me.gpbMakeOver.Controls.Add(Me.btnDetails)
        Me.gpbMakeOver.Controls.Add(Me.gpbPackages)
        Me.gpbMakeOver.Controls.Add(Me.gpbProducts)
        Me.gpbMakeOver.Controls.Add(Me.gpbPhotoPack)
        Me.gpbMakeOver.Controls.Add(Me.gpbStyles)
        Me.gpbMakeOver.Location = New System.Drawing.Point(13, 12)
        Me.gpbMakeOver.Name = "gpbMakeOver"
        Me.gpbMakeOver.Size = New System.Drawing.Size(1004, 426)
        Me.gpbMakeOver.TabIndex = 0
        Me.gpbMakeOver.TabStop = False
        Me.gpbMakeOver.Text = "Makeover"
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.SpringGreen
        Me.btnDetails.Location = New System.Drawing.Point(676, 309)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(283, 99)
        Me.btnDetails.TabIndex = 4
        Me.btnDetails.Text = "View Details"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'gpbPackages
        '
        Me.gpbPackages.Controls.Add(Me.lblAmountLuxuryPack)
        Me.gpbPackages.Controls.Add(Me.lblPriceLuxuryPack)
        Me.gpbPackages.Controls.Add(Me.lblAmountBasicPack)
        Me.gpbPackages.Controls.Add(Me.lblPriceBasicPack)
        Me.gpbPackages.Controls.Add(Me.rbLuxuryPack)
        Me.gpbPackages.Controls.Add(Me.rbBasicPack)
        Me.gpbPackages.Location = New System.Drawing.Point(6, 294)
        Me.gpbPackages.Name = "gpbPackages"
        Me.gpbPackages.Size = New System.Drawing.Size(606, 126)
        Me.gpbPackages.TabIndex = 3
        Me.gpbPackages.TabStop = False
        Me.gpbPackages.Text = "Packages"
        '
        'lblAmountLuxuryPack
        '
        Me.lblAmountLuxuryPack.AutoSize = True
        Me.lblAmountLuxuryPack.Location = New System.Drawing.Point(444, 66)
        Me.lblAmountLuxuryPack.Name = "lblAmountLuxuryPack"
        Me.lblAmountLuxuryPack.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountLuxuryPack.TabIndex = 5
        '
        'lblPriceLuxuryPack
        '
        Me.lblPriceLuxuryPack.AutoSize = True
        Me.lblPriceLuxuryPack.Location = New System.Drawing.Point(397, 66)
        Me.lblPriceLuxuryPack.Name = "lblPriceLuxuryPack"
        Me.lblPriceLuxuryPack.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceLuxuryPack.TabIndex = 4
        Me.lblPriceLuxuryPack.Text = "Price:"
        '
        'lblAmountBasicPack
        '
        Me.lblAmountBasicPack.AutoSize = True
        Me.lblAmountBasicPack.Location = New System.Drawing.Point(142, 66)
        Me.lblAmountBasicPack.Name = "lblAmountBasicPack"
        Me.lblAmountBasicPack.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountBasicPack.TabIndex = 3
        '
        'lblPriceBasicPack
        '
        Me.lblPriceBasicPack.AutoSize = True
        Me.lblPriceBasicPack.Location = New System.Drawing.Point(95, 66)
        Me.lblPriceBasicPack.Name = "lblPriceBasicPack"
        Me.lblPriceBasicPack.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceBasicPack.TabIndex = 2
        Me.lblPriceBasicPack.Text = "Price:"
        '
        'rbLuxuryPack
        '
        Me.rbLuxuryPack.AutoSize = True
        Me.rbLuxuryPack.Location = New System.Drawing.Point(378, 34)
        Me.rbLuxuryPack.Name = "rbLuxuryPack"
        Me.rbLuxuryPack.Size = New System.Drawing.Size(100, 20)
        Me.rbLuxuryPack.TabIndex = 1
        Me.rbLuxuryPack.TabStop = True
        Me.rbLuxuryPack.Text = "Luxury Pack"
        Me.rbLuxuryPack.UseVisualStyleBackColor = True
        '
        'rbBasicPack
        '
        Me.rbBasicPack.AutoSize = True
        Me.rbBasicPack.Location = New System.Drawing.Point(76, 34)
        Me.rbBasicPack.Name = "rbBasicPack"
        Me.rbBasicPack.Size = New System.Drawing.Size(96, 20)
        Me.rbBasicPack.TabIndex = 0
        Me.rbBasicPack.TabStop = True
        Me.rbBasicPack.Text = "Basic Pack"
        Me.rbBasicPack.UseVisualStyleBackColor = True
        '
        'gpbProducts
        '
        Me.gpbProducts.Controls.Add(Me.lblAmountProducts)
        Me.gpbProducts.Controls.Add(Me.lblPriceProducts)
        Me.gpbProducts.Controls.Add(Me.cbProducts)
        Me.gpbProducts.Location = New System.Drawing.Point(618, 147)
        Me.gpbProducts.Name = "gpbProducts"
        Me.gpbProducts.Size = New System.Drawing.Size(380, 141)
        Me.gpbProducts.TabIndex = 2
        Me.gpbProducts.TabStop = False
        Me.gpbProducts.Text = "Products"
        '
        'lblAmountProducts
        '
        Me.lblAmountProducts.AutoSize = True
        Me.lblAmountProducts.Location = New System.Drawing.Point(228, 88)
        Me.lblAmountProducts.Name = "lblAmountProducts"
        Me.lblAmountProducts.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountProducts.TabIndex = 2
        '
        'lblPriceProducts
        '
        Me.lblPriceProducts.AutoSize = True
        Me.lblPriceProducts.Location = New System.Drawing.Point(174, 88)
        Me.lblPriceProducts.Name = "lblPriceProducts"
        Me.lblPriceProducts.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceProducts.TabIndex = 1
        Me.lblPriceProducts.Text = "Price:"
        '
        'cbProducts
        '
        Me.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProducts.FormattingEnabled = True
        Me.cbProducts.Items.AddRange(New Object() {"Makeup Pack", "Haircare Pack"})
        Me.cbProducts.Location = New System.Drawing.Point(120, 46)
        Me.cbProducts.Name = "cbProducts"
        Me.cbProducts.Size = New System.Drawing.Size(221, 24)
        Me.cbProducts.TabIndex = 0
        '
        'gpbPhotoPack
        '
        Me.gpbPhotoPack.Controls.Add(Me.lblAmountGP)
        Me.gpbPhotoPack.Controls.Add(Me.lblPriceGP)
        Me.gpbPhotoPack.Controls.Add(Me.lblAmountSP)
        Me.gpbPhotoPack.Controls.Add(Me.lblPriceSP)
        Me.gpbPhotoPack.Controls.Add(Me.lblAmountBP)
        Me.gpbPhotoPack.Controls.Add(Me.lblPriceBP)
        Me.gpbPhotoPack.Controls.Add(Me.ckbGoldPack)
        Me.gpbPhotoPack.Controls.Add(Me.ckbSilverPack)
        Me.gpbPhotoPack.Controls.Add(Me.ckbBasicPack)
        Me.gpbPhotoPack.Location = New System.Drawing.Point(6, 147)
        Me.gpbPhotoPack.Name = "gpbPhotoPack"
        Me.gpbPhotoPack.Size = New System.Drawing.Size(606, 141)
        Me.gpbPhotoPack.TabIndex = 1
        Me.gpbPhotoPack.TabStop = False
        Me.gpbPhotoPack.Text = "Photograph Packages"
        '
        'lblAmountGP
        '
        Me.lblAmountGP.AutoSize = True
        Me.lblAmountGP.Location = New System.Drawing.Point(508, 88)
        Me.lblAmountGP.Name = "lblAmountGP"
        Me.lblAmountGP.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountGP.TabIndex = 8
        '
        'lblPriceGP
        '
        Me.lblPriceGP.AutoSize = True
        Me.lblPriceGP.Location = New System.Drawing.Point(454, 88)
        Me.lblPriceGP.Name = "lblPriceGP"
        Me.lblPriceGP.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceGP.TabIndex = 7
        Me.lblPriceGP.Text = "Price:"
        '
        'lblAmountSP
        '
        Me.lblAmountSP.AutoSize = True
        Me.lblAmountSP.Location = New System.Drawing.Point(303, 88)
        Me.lblAmountSP.Name = "lblAmountSP"
        Me.lblAmountSP.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountSP.TabIndex = 6
        '
        'lblPriceSP
        '
        Me.lblPriceSP.AutoSize = True
        Me.lblPriceSP.Location = New System.Drawing.Point(249, 88)
        Me.lblPriceSP.Name = "lblPriceSP"
        Me.lblPriceSP.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceSP.TabIndex = 5
        Me.lblPriceSP.Text = "Price:"
        '
        'lblAmountBP
        '
        Me.lblAmountBP.AutoSize = True
        Me.lblAmountBP.Location = New System.Drawing.Point(109, 88)
        Me.lblAmountBP.Name = "lblAmountBP"
        Me.lblAmountBP.Size = New System.Drawing.Size(0, 16)
        Me.lblAmountBP.TabIndex = 4
        '
        'lblPriceBP
        '
        Me.lblPriceBP.AutoSize = True
        Me.lblPriceBP.Location = New System.Drawing.Point(55, 88)
        Me.lblPriceBP.Name = "lblPriceBP"
        Me.lblPriceBP.Size = New System.Drawing.Size(41, 16)
        Me.lblPriceBP.TabIndex = 3
        Me.lblPriceBP.Text = "Price:"
        '
        'ckbGoldPack
        '
        Me.ckbGoldPack.AutoSize = True
        Me.ckbGoldPack.Location = New System.Drawing.Point(435, 48)
        Me.ckbGoldPack.Name = "ckbGoldPack"
        Me.ckbGoldPack.Size = New System.Drawing.Size(130, 20)
        Me.ckbGoldPack.TabIndex = 2
        Me.ckbGoldPack.Text = "Gold Photo Pack"
        Me.ckbGoldPack.UseVisualStyleBackColor = True
        '
        'ckbSilverPack
        '
        Me.ckbSilverPack.AutoSize = True
        Me.ckbSilverPack.Location = New System.Drawing.Point(232, 48)
        Me.ckbSilverPack.Name = "ckbSilverPack"
        Me.ckbSilverPack.Size = New System.Drawing.Size(135, 20)
        Me.ckbSilverPack.TabIndex = 1
        Me.ckbSilverPack.Text = "Silver Photo Pack"
        Me.ckbSilverPack.UseVisualStyleBackColor = True
        '
        'ckbBasicPack
        '
        Me.ckbBasicPack.AutoSize = True
        Me.ckbBasicPack.Location = New System.Drawing.Point(37, 48)
        Me.ckbBasicPack.Name = "ckbBasicPack"
        Me.ckbBasicPack.Size = New System.Drawing.Size(135, 20)
        Me.ckbBasicPack.TabIndex = 0
        Me.ckbBasicPack.Text = "Basic Photo Pack"
        Me.ckbBasicPack.UseVisualStyleBackColor = True
        '
        'gpbStyles
        '
        Me.gpbStyles.Controls.Add(Me.cbClotingStyle)
        Me.gpbStyles.Controls.Add(Me.cbHairStyle)
        Me.gpbStyles.Controls.Add(Me.cbMakeUpStyle)
        Me.gpbStyles.Controls.Add(Me.cbOutfitStyle)
        Me.gpbStyles.Controls.Add(Me.lblClothingStyle)
        Me.gpbStyles.Controls.Add(Me.lblOutfitStyle)
        Me.gpbStyles.Controls.Add(Me.lblHairStyle)
        Me.gpbStyles.Controls.Add(Me.lblMakeUpStyle)
        Me.gpbStyles.Location = New System.Drawing.Point(6, 21)
        Me.gpbStyles.Name = "gpbStyles"
        Me.gpbStyles.Size = New System.Drawing.Size(992, 120)
        Me.gpbStyles.TabIndex = 0
        Me.gpbStyles.TabStop = False
        Me.gpbStyles.Text = "Styles"
        '
        'cbClotingStyle
        '
        Me.cbClotingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClotingStyle.FormattingEnabled = True
        Me.cbClotingStyle.Items.AddRange(New Object() {"6", "8", "10", "12", "14", "16", "18", "20", "22"})
        Me.cbClotingStyle.Location = New System.Drawing.Point(843, 46)
        Me.cbClotingStyle.Name = "cbClotingStyle"
        Me.cbClotingStyle.Size = New System.Drawing.Size(121, 24)
        Me.cbClotingStyle.TabIndex = 10
        '
        'cbHairStyle
        '
        Me.cbHairStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHairStyle.FormattingEnabled = True
        Me.cbHairStyle.Items.AddRange(New Object() {"Sleek", "Voluminous", "Simple Updo", "Glamorous Updo"})
        Me.cbHairStyle.Location = New System.Drawing.Point(587, 46)
        Me.cbHairStyle.Name = "cbHairStyle"
        Me.cbHairStyle.Size = New System.Drawing.Size(121, 24)
        Me.cbHairStyle.TabIndex = 9
        '
        'cbMakeUpStyle
        '
        Me.cbMakeUpStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMakeUpStyle.FormattingEnabled = True
        Me.cbMakeUpStyle.Items.AddRange(New Object() {"Natural", "Glamorous", "Professional"})
        Me.cbMakeUpStyle.Location = New System.Drawing.Point(357, 46)
        Me.cbMakeUpStyle.Name = "cbMakeUpStyle"
        Me.cbMakeUpStyle.Size = New System.Drawing.Size(121, 24)
        Me.cbMakeUpStyle.TabIndex = 8
        '
        'cbOutfitStyle
        '
        Me.cbOutfitStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutfitStyle.FormattingEnabled = True
        Me.cbOutfitStyle.Items.AddRange(New Object() {"Evening dress", "Party dress", "Formal"})
        Me.cbOutfitStyle.Location = New System.Drawing.Point(109, 46)
        Me.cbOutfitStyle.Name = "cbOutfitStyle"
        Me.cbOutfitStyle.Size = New System.Drawing.Size(121, 24)
        Me.cbOutfitStyle.TabIndex = 7
        '
        'lblClothingStyle
        '
        Me.lblClothingStyle.AutoSize = True
        Me.lblClothingStyle.Location = New System.Drawing.Point(746, 49)
        Me.lblClothingStyle.Name = "lblClothingStyle"
        Me.lblClothingStyle.Size = New System.Drawing.Size(88, 16)
        Me.lblClothingStyle.TabIndex = 6
        Me.lblClothingStyle.Text = "Clothing Style"
        '
        'lblOutfitStyle
        '
        Me.lblOutfitStyle.AutoSize = True
        Me.lblOutfitStyle.Location = New System.Drawing.Point(34, 49)
        Me.lblOutfitStyle.Name = "lblOutfitStyle"
        Me.lblOutfitStyle.Size = New System.Drawing.Size(69, 16)
        Me.lblOutfitStyle.TabIndex = 5
        Me.lblOutfitStyle.Text = "Outfit Style"
        '
        'lblHairStyle
        '
        Me.lblHairStyle.AutoSize = True
        Me.lblHairStyle.Location = New System.Drawing.Point(519, 49)
        Me.lblHairStyle.Name = "lblHairStyle"
        Me.lblHairStyle.Size = New System.Drawing.Size(62, 16)
        Me.lblHairStyle.TabIndex = 1
        Me.lblHairStyle.Text = "HairStyle"
        '
        'lblMakeUpStyle
        '
        Me.lblMakeUpStyle.AutoSize = True
        Me.lblMakeUpStyle.Location = New System.Drawing.Point(259, 49)
        Me.lblMakeUpStyle.Name = "lblMakeUpStyle"
        Me.lblMakeUpStyle.Size = New System.Drawing.Size(92, 16)
        Me.lblMakeUpStyle.TabIndex = 0
        Me.lblMakeUpStyle.Text = "MakeUp Style"
        '
        'pcbDetails
        '
        Me.pcbDetails.BackColor = System.Drawing.Color.SpringGreen
        Me.pcbDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbDetails.Location = New System.Drawing.Point(-4, 444)
        Me.pcbDetails.Name = "pcbDetails"
        Me.pcbDetails.Size = New System.Drawing.Size(1038, 56)
        Me.pcbDetails.TabIndex = 1
        Me.pcbDetails.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1028, 517)
        Me.Controls.Add(Me.pcbDetails)
        Me.Controls.Add(Me.gpbMakeOver)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Makeover"
        Me.gpbMakeOver.ResumeLayout(False)
        Me.gpbPackages.ResumeLayout(False)
        Me.gpbPackages.PerformLayout()
        Me.gpbProducts.ResumeLayout(False)
        Me.gpbProducts.PerformLayout()
        Me.gpbPhotoPack.ResumeLayout(False)
        Me.gpbPhotoPack.PerformLayout()
        Me.gpbStyles.ResumeLayout(False)
        Me.gpbStyles.PerformLayout()
        CType(Me.pcbDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbMakeOver As GroupBox
    Friend WithEvents btnDetails As Button
    Friend WithEvents gpbPackages As GroupBox
    Friend WithEvents gpbProducts As GroupBox
    Friend WithEvents lblAmountProducts As Label
    Friend WithEvents lblPriceProducts As Label
    Friend WithEvents cbProducts As ComboBox
    Friend WithEvents gpbPhotoPack As GroupBox
    Friend WithEvents lblAmountGP As Label
    Friend WithEvents lblPriceGP As Label
    Friend WithEvents lblAmountSP As Label
    Friend WithEvents lblPriceSP As Label
    Friend WithEvents lblAmountBP As Label
    Friend WithEvents lblPriceBP As Label
    Friend WithEvents ckbGoldPack As CheckBox
    Friend WithEvents ckbSilverPack As CheckBox
    Friend WithEvents ckbBasicPack As CheckBox
    Friend WithEvents gpbStyles As GroupBox
    Friend WithEvents cbClotingStyle As ComboBox
    Friend WithEvents cbHairStyle As ComboBox
    Friend WithEvents cbMakeUpStyle As ComboBox
    Friend WithEvents cbOutfitStyle As ComboBox
    Friend WithEvents lblClothingStyle As Label
    Friend WithEvents lblOutfitStyle As Label
    Friend WithEvents lblHairStyle As Label
    Friend WithEvents lblMakeUpStyle As Label
    Friend WithEvents pcbDetails As PictureBox
    Friend WithEvents lblAmountLuxuryPack As Label
    Friend WithEvents lblPriceLuxuryPack As Label
    Friend WithEvents lblAmountBasicPack As Label
    Friend WithEvents lblPriceBasicPack As Label
    Friend WithEvents rbLuxuryPack As RadioButton
    Friend WithEvents rbBasicPack As RadioButton
End Class
