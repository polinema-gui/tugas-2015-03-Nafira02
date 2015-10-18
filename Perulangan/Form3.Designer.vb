<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Matriks1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mat1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mat2 = New System.Windows.Forms.TextBox()
        Me.hasilText = New System.Windows.Forms.TextBox()
        Me.ComboBox1_operasi = New System.Windows.Forms.ComboBox()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Matriks1
        '
        Me.Matriks1.AutoSize = True
        Me.Matriks1.Location = New System.Drawing.Point(12, 26)
        Me.Matriks1.Name = "Matriks1"
        Me.Matriks1.Size = New System.Drawing.Size(50, 13)
        Me.Matriks1.TabIndex = 0
        Me.Matriks1.Text = "Matriks 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matriks 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'mat1
        '
        Me.mat1.Location = New System.Drawing.Point(76, 23)
        Me.mat1.Multiline = True
        Me.mat1.Name = "mat1"
        Me.mat1.Size = New System.Drawing.Size(300, 72)
        Me.mat1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 5
        '
        'mat2
        '
        Me.mat2.Location = New System.Drawing.Point(76, 149)
        Me.mat2.Multiline = True
        Me.mat2.Name = "mat2"
        Me.mat2.Size = New System.Drawing.Size(300, 72)
        Me.mat2.TabIndex = 6
        '
        'hasilText
        '
        Me.hasilText.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.hasilText.Location = New System.Drawing.Point(76, 236)
        Me.hasilText.Multiline = True
        Me.hasilText.Name = "hasilText"
        Me.hasilText.Size = New System.Drawing.Size(300, 108)
        Me.hasilText.TabIndex = 7
        '
        'ComboBox1_operasi
        '
        Me.ComboBox1_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1_operasi.FormattingEnabled = True
        Me.ComboBox1_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.ComboBox1_operasi.Location = New System.Drawing.Point(76, 112)
        Me.ComboBox1_operasi.Name = "ComboBox1_operasi"
        Me.ComboBox1_operasi.Size = New System.Drawing.Size(300, 21)
        Me.ComboBox1_operasi.TabIndex = 8
        '
        'Hitung
        '
        Me.Hitung.Location = New System.Drawing.Point(326, 362)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(75, 27)
        Me.Hitung.TabIndex = 9
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Hitung)
        Me.Controls.Add(Me.ComboBox1_operasi)
        Me.Controls.Add(Me.hasilText)
        Me.Controls.Add(Me.mat2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mat1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Matriks1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Matriks1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mat1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mat2 As System.Windows.Forms.TextBox
    Friend WithEvents hasilText As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Hitung As System.Windows.Forms.Button
End Class
