Public Class Form9

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form1.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Left = (ancho / 2) - (PictureBox1.Width / 2)
    End Sub
End Class