Public Class Form6

    Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
    Public ancho = CInt(pantalla.Bounds.Width.ToString())
    Public alto = CInt(pantalla.Bounds.Height.ToString())

    Public XMLFile As String = My.Application.Info.DirectoryPath & "\BaseDeDatos.xml"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (RespuestaAleatoriaRichTextBox.Text = "") Then
            MessageBox.Show("Debe completar el campo", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (NombreTextBox.Text = Nothing Or CelularTextBox.Text = Nothing Or EmailTextBox.Text = Nothing Or Usuario_InstagramTextBox.Text = Nothing) Then
            MsgBox("Error en envio de datos", vbExclamation)
        Else
            Me.Validate()
            DataTable1BindingSource.EndEdit()
            DataSet1.WriteXml(XMLFile)
            Me.Hide()
            Form7.Show()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Left = (ancho / 2) - (Panel1.Width / 2)
        Panel1.Top = (Height / 2) - (Panel1.Height / 2)

        If My.Computer.FileSystem.FileExists(XMLFile) = True Then 'Comprobar si existe el archivo xml
            DataSet1.ReadXml(XMLFile)
        End If
        DataTable1BindingSource.AddNew()

        NombreTextBox.Text = Module1.nombre
        CelularTextBox.Text = Module1.celular
        EmailTextBox.Text = Module1.email
        Usuario_InstagramTextBox.Text = Module1.usuario
        Pregunta1TextBox.Text = Module1.pregunta1
        Pregunta2TextBox.Text = Module1.pregunta2
        Pregunta3TextBox.Text = Module1.pregunta3

        NombreTextBox.Hide()
        CelularTextBox.Hide()
        EmailTextBox.Hide()
        Usuario_InstagramTextBox.Hide()
        Pregunta1TextBox.Hide()
        Pregunta2TextBox.Hide()
        Pregunta3TextBox.Hide()
        PreguntaAleatoriaLabel1.Hide()

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 7.
        Dim value As Integer = CInt(Int((7 * Rnd()) + 1))
        Select Case value
            Case 1
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta5
                PreguntaAleatoriaLabel1.Text = "Estas en ese momento del día en el que el cansancio te abruma y esta con tu energía abajo y de repente recibes a una cliente que llega con tinte negro aplicado a decirte que quiere un rubio platinado. ¿QUÉ HACES?"
            Case 2
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta6
                PreguntaAleatoriaLabel1.Text = "Una de esas clientes que no había regresado y llevabas tiempo sin ver porque decidió ir a una peluquería más económica por varios meses, llega con su cabello estropeado por malos tratamientos y uso de químicos y te pide que la dejes como nueva. ¿QUÉ HACES?"
            Case 3
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta7
                PreguntaAleatoriaLabel1.Text = "Le haces la keratina a tu cliente y 3 días después regresa pidiendo garantía porque a su marido no le gusto. ¿QUÉ HACES?"
            Case 4
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta8
                PreguntaAleatoriaLabel1.Text = "Le haces a tu cliente la keratina, cejas, manicure y pedicure y al momento de pagar te dice que el dinero lo dejo en su casa en el otro bolso y que otro día te paga, Tu sabes que es muy probable que no la vuelvas a ver en toda tu vida. ¿QUÉ HACES?"
            Case 5
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta9
                PreguntaAleatoriaLabel1.Text = "Una de tus clientes te dice : ¿y si somos 3 en cuanto nos queda?. ¿QUÉ HACES?"
            Case 6
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta10
                PreguntaAleatoriaLabel1.Text = "Tu cliente peleo con su esposo y llego deprimida a desquitarse contigo, te critica todo lo que haces, te pide que lo hagas más rápido y habla por su celular contándole su tragedia a su mejor amiga y no te deja hacer bien el trabajo. ¿QUÉ HACES?"
            Case 7
                Panel1.BackgroundImage = My.Resources._1304x1087_px_Pregunta11
                PreguntaAleatoriaLabel1.Text = "Tu cliente te pidió que le cortaras el cabello hasta los hombros, horas después llega su esposo furioso a hacerte el reclamo porque no le gusta el pelo corto y su esposa le dijo que a ti se te fue la mano con el corte. ¿QUÉ HACES?"
        End Select

    End Sub

    Private Sub PreguntaAleatoriaLabel1_Click(sender As Object, e As EventArgs) Handles PreguntaAleatoriaLabel1.Click

    End Sub
End Class

