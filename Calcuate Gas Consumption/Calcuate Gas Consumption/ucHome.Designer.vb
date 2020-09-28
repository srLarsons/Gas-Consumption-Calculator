<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucHome
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvInput = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbAvgConOTotDist = New System.Windows.Forms.Label()
        Me.lbTotCost = New System.Windows.Forms.Label()
        Me.lbCurrCost = New System.Windows.Forms.Label()
        Me.lbAvgConPKm = New System.Windows.Forms.Label()
        Me.lbDistance = New System.Windows.Forms.Label()
        Me.lbAvConUnits = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbCost = New System.Windows.Forms.TextBox()
        Me.tbFuelQuantity = New System.Windows.Forms.TextBox()
        Me.tbNewMileage = New System.Windows.Forms.TextBox()
        Me.tbOldMileage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgvInput)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 612)
        Me.Panel1.TabIndex = 0
        '
        'dgvInput
        '
        Me.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInput.Location = New System.Drawing.Point(13, 369)
        Me.dgvInput.Name = "dgvInput"
        Me.dgvInput.RowHeadersWidth = 51
        Me.dgvInput.RowTemplate.Height = 24
        Me.dgvInput.Size = New System.Drawing.Size(889, 218)
        Me.dgvInput.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbAvgConOTotDist)
        Me.Panel3.Controls.Add(Me.lbTotCost)
        Me.Panel3.Controls.Add(Me.lbCurrCost)
        Me.Panel3.Controls.Add(Me.lbAvgConPKm)
        Me.Panel3.Controls.Add(Me.lbDistance)
        Me.Panel3.Controls.Add(Me.lbAvConUnits)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(344, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 348)
        Me.Panel3.TabIndex = 1
        '
        'lbAvgConOTotDist
        '
        Me.lbAvgConOTotDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAvgConOTotDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAvgConOTotDist.Location = New System.Drawing.Point(306, 288)
        Me.lbAvgConOTotDist.Name = "lbAvgConOTotDist"
        Me.lbAvgConOTotDist.Size = New System.Drawing.Size(120, 34)
        Me.lbAvgConOTotDist.TabIndex = 22
        Me.lbAvgConOTotDist.Text = "0,00"
        '
        'lbTotCost
        '
        Me.lbTotCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotCost.Location = New System.Drawing.Point(306, 223)
        Me.lbTotCost.Name = "lbTotCost"
        Me.lbTotCost.Size = New System.Drawing.Size(120, 34)
        Me.lbTotCost.TabIndex = 21
        Me.lbTotCost.Text = "0,00"
        '
        'lbCurrCost
        '
        Me.lbCurrCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCurrCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCurrCost.Location = New System.Drawing.Point(306, 166)
        Me.lbCurrCost.Name = "lbCurrCost"
        Me.lbCurrCost.Size = New System.Drawing.Size(120, 34)
        Me.lbCurrCost.TabIndex = 20
        Me.lbCurrCost.Text = "0,00"
        '
        'lbAvgConPKm
        '
        Me.lbAvgConPKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAvgConPKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAvgConPKm.Location = New System.Drawing.Point(306, 100)
        Me.lbAvgConPKm.Name = "lbAvgConPKm"
        Me.lbAvgConPKm.Size = New System.Drawing.Size(120, 34)
        Me.lbAvgConPKm.TabIndex = 19
        Me.lbAvgConPKm.Text = "0,00"
        '
        'lbDistance
        '
        Me.lbDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDistance.Location = New System.Drawing.Point(306, 29)
        Me.lbDistance.Name = "lbDistance"
        Me.lbDistance.Size = New System.Drawing.Size(120, 34)
        Me.lbDistance.TabIndex = 18
        Me.lbDistance.Text = "0,00"
        '
        'lbAvConUnits
        '
        Me.lbAvConUnits.AutoSize = True
        Me.lbAvConUnits.Location = New System.Drawing.Point(436, 299)
        Me.lbAvConUnits.Name = "lbAvConUnits"
        Me.lbAvConUnits.Size = New System.Drawing.Size(67, 17)
        Me.lbAvConUnits.TabIndex = 17
        Me.lbAvConUnits.Text = "Liters/Km"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Euros"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Euros"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Liters/Km"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(436, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Km"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(265, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Average consumption over total distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total costs for all recorded distances"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Costs for current distance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Aaverage consumption per kilometer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Distance"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnCalculate)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.tbCost)
        Me.Panel2.Controls.Add(Me.tbFuelQuantity)
        Me.Panel2.Controls.Add(Me.tbNewMileage)
        Me.Panel2.Controls.Add(Me.tbOldMileage)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(13, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 348)
        Me.Panel2.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(194, 288)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 39)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(250, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Euros"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(250, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Liters"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(250, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Km"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(250, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 17)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Km"
        '
        'tbCost
        '
        Me.tbCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCost.Location = New System.Drawing.Point(144, 225)
        Me.tbCost.Name = "tbCost"
        Me.tbCost.Size = New System.Drawing.Size(100, 38)
        Me.tbCost.TabIndex = 7
        '
        'tbFuelQuantity
        '
        Me.tbFuelQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFuelQuantity.Location = New System.Drawing.Point(144, 163)
        Me.tbFuelQuantity.Name = "tbFuelQuantity"
        Me.tbFuelQuantity.Size = New System.Drawing.Size(100, 38)
        Me.tbFuelQuantity.TabIndex = 6
        '
        'tbNewMileage
        '
        Me.tbNewMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewMileage.Location = New System.Drawing.Point(144, 97)
        Me.tbNewMileage.Name = "tbNewMileage"
        Me.tbNewMileage.Size = New System.Drawing.Size(100, 38)
        Me.tbNewMileage.TabIndex = 5
        '
        'tbOldMileage
        '
        Me.tbOldMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOldMileage.Location = New System.Drawing.Point(144, 26)
        Me.tbOldMileage.Name = "tbOldMileage"
        Me.tbOldMileage.Size = New System.Drawing.Size(100, 38)
        Me.tbOldMileage.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fueled Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Mileage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Mileage"
        '
        'ucHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucHome"
        Me.Size = New System.Drawing.Size(929, 616)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbAvConUnits As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tbCost As TextBox
    Friend WithEvents tbFuelQuantity As TextBox
    Friend WithEvents tbNewMileage As TextBox
    Friend WithEvents tbOldMileage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbAvgConOTotDist As Label
    Friend WithEvents lbTotCost As Label
    Friend WithEvents lbCurrCost As Label
    Friend WithEvents lbAvgConPKm As Label
    Friend WithEvents lbDistance As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents dgvInput As DataGridView
End Class
