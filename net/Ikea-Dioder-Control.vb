Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel




Public Class Form1

    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames
        ComboBox1.Items.AddRange(myPort)
        writeBtn.Enabled = False



    End Sub

    Private Sub initBtn_Click(sender As Object, e As EventArgs) Handles initBtn.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        initBtn.Enabled = False
        writeBtn.Enabled = True

    End Sub

    Private Sub writeBtn_Click(sender As Object, e As EventArgs) Handles writeBtn.Click
        SerialPort1.Write(RichTextBox1.Text)


    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        SerialPort1.Close()
        initBtn.Enabled = True
        writeBtn.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Write("a")
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.Write("b")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialPort1.Write("c")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SerialPort1.Write("d")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SerialPort1.Write("e")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SerialPort1.Write("f")
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SerialPort1.Write("g")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SerialPort1.Write("g")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SerialPort1.Write("o")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SerialPort1.Write("r")
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SerialPort1.Write("h")
    End Sub

End Class
