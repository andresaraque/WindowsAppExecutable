﻿Public Class Form1

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (ancho / 2) - (Panel1.Width / 2)
        Panel1.Top = (Height / 2) - (Panel1.Height / 2)
    End Sub
End Class
