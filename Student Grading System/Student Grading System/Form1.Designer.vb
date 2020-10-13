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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mainlabel = New System.Windows.Forms.Label()
        Me.sublabel = New System.Windows.Forms.Label()
        Me.markslabel = New System.Windows.Forms.Label()
        Me.gradelabel = New System.Windows.Forms.Label()
        Me.convertbtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"System Analysis And Design (ITU501)", "Database And Management System (ITU502)", "System Programming (CSU501)", "Theory Of Computation (CSU502)", "Principles Of Management (CSU503)"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(449, 31)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select The Subject-"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(509, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 30)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(722, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 30)
        Me.TextBox2.TabIndex = 1
        '
        'mainlabel
        '
        Me.mainlabel.AutoSize = True
        Me.mainlabel.Font = New System.Drawing.Font("Times New Roman", 20.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.mainlabel.Location = New System.Drawing.Point(272, 9)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(343, 38)
        Me.mainlabel.TabIndex = 2
        Me.mainlabel.Text = "Student Grade System"
        '
        'sublabel
        '
        Me.sublabel.AutoSize = True
        Me.sublabel.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sublabel.Location = New System.Drawing.Point(164, 78)
        Me.sublabel.Name = "sublabel"
        Me.sublabel.Size = New System.Drawing.Size(105, 32)
        Me.sublabel.TabIndex = 2
        Me.sublabel.Text = "Subject"
        '
        'markslabel
        '
        Me.markslabel.AutoSize = True
        Me.markslabel.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markslabel.Location = New System.Drawing.Point(547, 78)
        Me.markslabel.Name = "markslabel"
        Me.markslabel.Size = New System.Drawing.Size(93, 32)
        Me.markslabel.TabIndex = 2
        Me.markslabel.Text = "Marks"
        '
        'gradelabel
        '
        Me.gradelabel.AutoSize = True
        Me.gradelabel.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradelabel.Location = New System.Drawing.Point(761, 78)
        Me.gradelabel.Name = "gradelabel"
        Me.gradelabel.Size = New System.Drawing.Size(91, 32)
        Me.gradelabel.TabIndex = 2
        Me.gradelabel.Text = "Grade"
        '
        'convertbtn
        '
        Me.convertbtn.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertbtn.Location = New System.Drawing.Point(402, 207)
        Me.convertbtn.Name = "convertbtn"
        Me.convertbtn.Size = New System.Drawing.Size(145, 39)
        Me.convertbtn.TabIndex = 3
        Me.convertbtn.Text = "Convert"
        Me.convertbtn.UseVisualStyleBackColor = True
        '
        'clearbtn
        '
        Me.clearbtn.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(402, 281)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(145, 39)
        Me.clearbtn.TabIndex = 3
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.Location = New System.Drawing.Point(402, 349)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(145, 39)
        Me.exitbtn.TabIndex = 4
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(904, 418)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.convertbtn)
        Me.Controls.Add(Me.gradelabel)
        Me.Controls.Add(Me.markslabel)
        Me.Controls.Add(Me.sublabel)
        Me.Controls.Add(Me.mainlabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents mainlabel As System.Windows.Forms.Label
    Friend WithEvents sublabel As System.Windows.Forms.Label
    Friend WithEvents markslabel As System.Windows.Forms.Label
    Friend WithEvents gradelabel As System.Windows.Forms.Label
    Friend WithEvents convertbtn As System.Windows.Forms.Button
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents exitbtn As System.Windows.Forms.Button

End Class
