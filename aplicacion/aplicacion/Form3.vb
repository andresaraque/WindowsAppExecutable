Public Class Form3

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (RadioButton2.Checked = True) Then
            MessageBox.Show("Respuesta correcta", "¡felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Module1.pregunta1 = "SI"
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("La respuesta correcta es la opción B", "¡Lo siento!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Module1.pregunta1 = "NO"
            Me.Hide()
            Form4.Show()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (ancho / 2) - (Panel1.Width / 2)
        Panel1.Top = (Height / 2) - (Panel1.Height / 2)
    End Sub
End Class