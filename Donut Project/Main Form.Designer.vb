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
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpPrice.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(6, 30)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(113, 20)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(6, 79)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(106, 20)
        Me.radSugar.TabIndex = 0
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(6, 128)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(131, 20)
        Me.radChocolate.TabIndex = 0
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(6, 174)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(103, 20)
        Me.radFilled.TabIndex = 0
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGlazed)
        Me.GroupBox1.Controls.Add(Me.radFilled)
        Me.GroupBox1.Controls.Add(Me.radSugar)
        Me.GroupBox1.Controls.Add(Me.radChocolate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 207)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doughnut Choices"
        '
        'grpPrice
        '
        Me.grpPrice.Controls.Add(Me.lblTotalDue)
        Me.grpPrice.Controls.Add(Me.lblSalesTax)
        Me.grpPrice.Controls.Add(Me.Label2)
        Me.grpPrice.Controls.Add(Me.Label1)
        Me.grpPrice.Controls.Add(Me.txtSubTotal)
        Me.grpPrice.Controls.Add(Me.lblSubtotal)
        Me.grpPrice.Location = New System.Drawing.Point(314, 12)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Size = New System.Drawing.Size(215, 207)
        Me.grpPrice.TabIndex = 1
        Me.grpPrice.TabStop = False
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(46, 160)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(41, 16)
        Me.lblTotalDue.TabIndex = 0
        Me.lblTotalDue.Text = "Total:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(16, 101)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(71, 16)
        Me.lblSalesTax.TabIndex = 0
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(98, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(96, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSubTotal.Location = New System.Drawing.Point(97, 45)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(69, 25)
        Me.txtSubTotal.TabIndex = 0
        Me.txtSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(28, 49)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(59, 16)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.radNone)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Doughnut Choices"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 102)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 20)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&Cappuccino ($2.75)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(118, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Regular ($1.50)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(6, 30)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(61, 20)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(314, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 41)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(314, 265)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(117, 41)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpPrice)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Donut Shoppe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpPrice As GroupBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubTotal As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
End Class
