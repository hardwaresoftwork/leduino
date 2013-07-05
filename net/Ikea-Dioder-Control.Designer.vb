<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.initBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.writeBtn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'initBtn
        '
        Me.initBtn.Location = New System.Drawing.Point(595, 161)
        Me.initBtn.Name = "initBtn"
        Me.initBtn.Size = New System.Drawing.Size(194, 21)
        Me.initBtn.TabIndex = 0
        Me.initBtn.Text = "Init"
        Me.initBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(795, 161)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(194, 21)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'writeBtn
        '
        Me.writeBtn.Location = New System.Drawing.Point(595, 478)
        Me.writeBtn.Name = "writeBtn"
        Me.writeBtn.Size = New System.Drawing.Size(194, 21)
        Me.writeBtn.TabIndex = 0
        Me.writeBtn.Text = "Write"
        Me.writeBtn.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(23, 478)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(394, 20)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(23, 161)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"9600"})
        Me.ComboBox2.Location = New System.Drawing.Point(223, 161)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(23, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Red"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Fuchsia
        Me.Button2.Location = New System.Drawing.Point(79, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Pink"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(135, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Yellow"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(191, 251)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "White"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(247, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Green"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(303, 251)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 50)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Teal"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Blue
        Me.Button7.Location = New System.Drawing.Point(359, 251)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 50)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Blue"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orator Std", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Serial Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Orator Std", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(219, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Baudrate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Orator Std", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(559, 63)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ikea Dioder Control"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Orator Std", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Arduino Setup"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orator Std", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LED Control"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(415, 251)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 50)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Blue"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Orator Std", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LED Command Line"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(23, 307)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 50)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Fade In"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Red
        Me.Button10.Location = New System.Drawing.Point(23, 362)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 50)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "Fade Out"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(795, 252)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(113, 50)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "Blue"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 574)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.writeBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.initBtn)
        Me.Name = "Form1"
        Me.Text = "Ikea Dioder Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents initBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents writeBtn As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button

End Class
