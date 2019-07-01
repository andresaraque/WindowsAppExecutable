Imports System.Text.RegularExpressions
Public Class Form2

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f3 As New Form3()

        If (NombreTextBox.Text = Nothing Or CelularMaskedTextBox.Text = Nothing Or EmailTextBox.Text = Nothing Or Usuario_InstagramTextBox.Text = Nothing) Then
            MsgBox("Los campos no pueden quedar vacios", vbExclamation)
        ElseIf (validar_Mail(EmailTextBox.Text) = False) Then
            MsgBox("Digite el correo de forma correcta", vbExclamation)
        Else
            Module1.nombre = NombreTextBox.Text
            Module1.celular = CelularMaskedTextBox.Text
            Module1.email = EmailTextBox.Text
            Module1.usuario = Usuario_InstagramTextBox.Text
            Me.Hide()
            f3.Show()
        End If
    End Sub

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (ancho / 2) - (Panel1.Width / 2)
        Panel1.Top = (Height / 2) - (Panel1.Height / 2)
    End Sub
End Class