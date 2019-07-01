Public Class Form4

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (RadioButton5.Checked = True) Then
            MessageBox.Show("Respuesta correcta", "¡felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Module1.pregunta2 = "SI"
            Me.Hide()
            Form5.Show()
        Else
            MessageBox.Show("La respuesta correcta es la opción E", "¡Lo siento!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Module1.pregunta2 = "NO"
            Me.Hide()
            Form5.Show()
        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (ancho / 2) - (Panel1.Width / 2)
        Panel1.Top = (Height / 2) - (Panel1.Height / 2)
    End Sub
End Class