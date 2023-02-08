<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayForm
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
        Me.gpbPayDetails = New System.Windows.Forms.GroupBox()
        Me.btnCompletePayment = New System.Windows.Forms.Button()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.txtCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.lblCreditCardNumber = New System.Windows.Forms.Label()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gpbPayDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbPayDetails
        '
        Me.gpbPayDetails.Controls.Add(Me.btnCompletePayment)
        Me.gpbPayDetails.Controls.Add(Me.txtHouseNumber)
        Me.gpbPayDetails.Controls.Add(Me.txtPostCode)
        Me.gpbPayDetails.Controls.Add(Me.txtCity)
        Me.gpbPayDetails.Controls.Add(Me.txtStreetName)
        Me.gpbPayDetails.Controls.Add(Me.txtCreditCardNumber)
        Me.gpbPayDetails.Controls.Add(Me.lblCreditCardNumber)
        Me.gpbPayDetails.Controls.Add(Me.lblStreetName)
        Me.gpbPayDetails.Controls.Add(Me.lblCity)
        Me.gpbPayDetails.Controls.Add(Me.lblPostCode)
        Me.gpbPayDetails.Controls.Add(Me.lblHouseNumber)
        Me.gpbPayDetails.Location = New System.Drawing.Point(12, 12)
        Me.gpbPayDetails.Name = "gpbPayDetails"
        Me.gpbPayDetails.Size = New System.Drawing.Size(374, 403)
        Me.gpbPayDetails.TabIndex = 0
        Me.gpbPayDetails.TabStop = False
        Me.gpbPayDetails.Text = "Payment Details"
        '
        'btnCompletePayment
        '
        Me.btnCompletePayment.BackColor = System.Drawing.Color.SpringGreen
        Me.btnCompletePayment.Location = New System.Drawing.Point(165, 351)
        Me.btnCompletePayment.Name = "btnCompletePayment"
        Me.btnCompletePayment.Size = New System.Drawing.Size(173, 46)
        Me.btnCompletePayment.TabIndex = 11
        Me.btnCompletePayment.Text = "Complete Payment"
        Me.btnCompletePayment.UseVisualStyleBackColor = False
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(165, 296)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(173, 22)
        Me.txtHouseNumber.TabIndex = 10
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(165, 231)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(173, 22)
        Me.txtPostCode.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(165, 168)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(173, 22)
        Me.txtCity.TabIndex = 8
        '
        'txtStreetName
        '
        Me.txtStreetName.Location = New System.Drawing.Point(165, 104)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(173, 22)
        Me.txtStreetName.TabIndex = 7
        '
        'txtCreditCardNumber
        '
        Me.txtCreditCardNumber.Location = New System.Drawing.Point(165, 43)
        Me.txtCreditCardNumber.MaxLength = 16
        Me.txtCreditCardNumber.Name = "txtCreditCardNumber"
        Me.txtCreditCardNumber.Size = New System.Drawing.Size(173, 22)
        Me.txtCreditCardNumber.TabIndex = 6
        '
        'lblCreditCardNumber
        '
        Me.lblCreditCardNumber.AutoSize = True
        Me.lblCreditCardNumber.Location = New System.Drawing.Point(33, 46)
        Me.lblCreditCardNumber.Name = "lblCreditCardNumber"
        Me.lblCreditCardNumber.Size = New System.Drawing.Size(126, 16)
        Me.lblCreditCardNumber.TabIndex = 1
        Me.lblCreditCardNumber.Text = "Credir Card Number"
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Location = New System.Drawing.Point(33, 107)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(82, 16)
        Me.lblStreetName.TabIndex = 2
        Me.lblStreetName.Text = "Street Name"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(33, 171)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(29, 16)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(33, 234)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(70, 16)
        Me.lblPostCode.TabIndex = 4
        Me.lblPostCode.Text = "Post Code"
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Location = New System.Drawing.Point(33, 299)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(98, 16)
        Me.lblHouseNumber.TabIndex = 5
        Me.lblHouseNumber.Text = "House Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 421)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 37)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(398, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gpbPayDetails)
        Me.Name = "PayForm"
        Me.ShowIcon = False
        Me.Text = "PayForm"
        Me.gpbPayDetails.ResumeLayout(False)
        Me.gpbPayDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbPayDetails As GroupBox
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents txtCreditCardNumber As TextBox
    Friend WithEvents lblCreditCardNumber As Label
    Friend WithEvents lblStreetName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents lblHouseNumber As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCompletePayment As Button
End Class
