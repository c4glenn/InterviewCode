<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lblHue = New System.Windows.Forms.Label()
        Me.lblSaturation = New System.Windows.Forms.Label()
        Me.lblLightness = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHPrompt = New System.Windows.Forms.Label()
        Me.lblSPrompt = New System.Windows.Forms.Label()
        Me.lblLPrompt = New System.Windows.Forms.Label()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectImage
        '
        Me.btnSelectImage.Location = New System.Drawing.Point(12, 12)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(107, 23)
        Me.btnSelectImage.TabIndex = 0
        Me.btnSelectImage.Text = "Select Image"
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picImage.Enabled = False
        Me.picImage.Location = New System.Drawing.Point(12, 41)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(528, 397)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 1
        Me.picImage.TabStop = False
        '
        'lblHue
        '
        Me.lblHue.AutoSize = True
        Me.lblHue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHue.Location = New System.Drawing.Point(205, 13)
        Me.lblHue.Name = "lblHue"
        Me.lblHue.Size = New System.Drawing.Size(24, 25)
        Me.lblHue.TabIndex = 2
        Me.lblHue.Text = "0"
        '
        'lblSaturation
        '
        Me.lblSaturation.AutoSize = True
        Me.lblSaturation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaturation.Location = New System.Drawing.Point(346, 12)
        Me.lblSaturation.Name = "lblSaturation"
        Me.lblSaturation.Size = New System.Drawing.Size(24, 25)
        Me.lblSaturation.TabIndex = 3
        Me.lblSaturation.Text = "0"
        '
        'lblLightness
        '
        Me.lblLightness.AutoSize = True
        Me.lblLightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLightness.Location = New System.Drawing.Point(485, 12)
        Me.lblLightness.Name = "lblLightness"
        Me.lblLightness.Size = New System.Drawing.Size(24, 25)
        Me.lblLightness.TabIndex = 4
        Me.lblLightness.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblHPrompt
        '
        Me.lblHPrompt.AutoSize = True
        Me.lblHPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPrompt.Location = New System.Drawing.Point(166, 12)
        Me.lblHPrompt.Name = "lblHPrompt"
        Me.lblHPrompt.Size = New System.Drawing.Size(33, 25)
        Me.lblHPrompt.TabIndex = 5
        Me.lblHPrompt.Text = "H:"
        '
        'lblSPrompt
        '
        Me.lblSPrompt.AutoSize = True
        Me.lblSPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPrompt.Location = New System.Drawing.Point(308, 12)
        Me.lblSPrompt.Name = "lblSPrompt"
        Me.lblSPrompt.Size = New System.Drawing.Size(32, 25)
        Me.lblSPrompt.TabIndex = 6
        Me.lblSPrompt.Text = "S:"
        '
        'lblLPrompt
        '
        Me.lblLPrompt.AutoSize = True
        Me.lblLPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPrompt.Location = New System.Drawing.Point(447, 11)
        Me.lblLPrompt.Name = "lblLPrompt"
        Me.lblLPrompt.Size = New System.Drawing.Size(30, 25)
        Me.lblLPrompt.TabIndex = 7
        Me.lblLPrompt.Text = "L:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 450)
        Me.Controls.Add(Me.lblLPrompt)
        Me.Controls.Add(Me.lblSPrompt)
        Me.Controls.Add(Me.lblHPrompt)
        Me.Controls.Add(Me.lblLightness)
        Me.Controls.Add(Me.lblSaturation)
        Me.Controls.Add(Me.lblHue)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnSelectImage)
        Me.Name = "Form1"
        Me.Text = "HSL Value Finder"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectImage As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblHue As Label
    Friend WithEvents lblSaturation As Label
    Friend WithEvents lblLightness As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHPrompt As Label
    Friend WithEvents lblSPrompt As Label
    Friend WithEvents lblLPrompt As Label
End Class
