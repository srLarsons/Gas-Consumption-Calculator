﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.UcHome2 = New Calcuate_Gas_Consumption.ucHome()
        Me.SuspendLayout()
        '
        'UcHome2
        '
        Me.UcHome2.Location = New System.Drawing.Point(1, 1)
        Me.UcHome2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcHome2.Name = "UcHome2"
        Me.UcHome2.Size = New System.Drawing.Size(716, 511)
        Me.UcHome2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 512)
        Me.Controls.Add(Me.UcHome2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Gas Consumption Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcHome1 As ucHome
    Friend WithEvents UcHome2 As ucHome
End Class
