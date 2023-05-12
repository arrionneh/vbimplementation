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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.picShoe = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBrown = New System.Windows.Forms.RadioButton()
        Me.radBlack = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        CType(Me.picShoe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personal Shopper App"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(422, 521)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(483, 93)
        Me.lblResult.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(80, 461)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 21)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(22, 521)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(116, 21)
        Me.lblNumber.TabIndex = 3
        Me.lblNumber.Text = "Phone Number:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(53, 586)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(81, 21)
        Me.lblSize.TabIndex = 4
        Me.lblSize.Text = "Shoe Size:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(64, 671)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(201, 42)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(393, 671)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 42)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoop
        '
        Me.btnLoop.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoop.Location = New System.Drawing.Point(704, 671)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(201, 42)
        Me.btnLoop.TabIndex = 7
        Me.btnLoop.Text = "Submit Another Order"
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'picShoe
        '
        Me.picShoe.BackColor = System.Drawing.Color.DarkOrange
        Me.picShoe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picShoe.Location = New System.Drawing.Point(561, 139)
        Me.picShoe.Name = "picShoe"
        Me.picShoe.Size = New System.Drawing.Size(344, 343)
        Me.picShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShoe.TabIndex = 8
        Me.picShoe.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.radBrown)
        Me.GroupBox1.Controls.Add(Me.radBlack)
        Me.GroupBox1.Controls.Add(Me.radRed)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(123, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 113)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shoe Options:"
        '
        'radBrown
        '
        Me.radBrown.AutoSize = True
        Me.radBrown.Location = New System.Drawing.Point(7, 80)
        Me.radBrown.Name = "radBrown"
        Me.radBrown.Size = New System.Drawing.Size(166, 25)
        Me.radBrown.TabIndex = 2
        Me.radBrown.TabStop = True
        Me.radBrown.Text = "Brown Hiking Boots"
        Me.radBrown.UseVisualStyleBackColor = True
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(7, 53)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(125, 25)
        Me.radBlack.TabIndex = 1
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "Black Loafers"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(7, 27)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(190, 25)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red Running Sneakers"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox2.Controls.Add(Me.radDelivery)
        Me.GroupBox2.Controls.Add(Me.radPickup)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(123, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 83)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pickup or Delivery?"
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(7, 50)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(132, 25)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.TabStop = True
        Me.radDelivery.Text = "Home Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(7, 22)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(138, 25)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "In-store Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(175, 461)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(145, 28)
        Me.txtName.TabIndex = 11
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(175, 518)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(145, 28)
        Me.txtNumber.TabIndex = 12
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(175, 586)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 28)
        Me.txtSize.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(989, 742)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picShoe)
        Me.Controls.Add(Me.btnLoop)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Personal Shopper App"
        CType(Me.picShoe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLoop As Button
    Friend WithEvents picShoe As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBrown As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radDelivery As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtSize As TextBox
End Class
