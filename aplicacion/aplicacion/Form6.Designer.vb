<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataSet1 = New aplicacion.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Usuario_InstagramTextBox = New System.Windows.Forms.TextBox()
        Me.Pregunta1TextBox = New System.Windows.Forms.TextBox()
        Me.Pregunta2TextBox = New System.Windows.Forms.TextBox()
        Me.Pregunta3TextBox = New System.Windows.Forms.TextBox()
        Me.PreguntaAleatoriaLabel1 = New System.Windows.Forms.Label()
        Me.RespuestaAleatoriaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.aplicacion.My.Resources.Resources.siguiente
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.aplicacion.My.Resources.Resources.siguiente
        Me.PictureBox1.Location = New System.Drawing.Point(345, 564)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 66)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(20, 496)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 24
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(20, 522)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 25
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(20, 548)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 26
        '
        'Usuario_InstagramTextBox
        '
        Me.Usuario_InstagramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Usuario Instagram", True))
        Me.Usuario_InstagramTextBox.Location = New System.Drawing.Point(20, 574)
        Me.Usuario_InstagramTextBox.Name = "Usuario_InstagramTextBox"
        Me.Usuario_InstagramTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Usuario_InstagramTextBox.TabIndex = 27
        '
        'Pregunta1TextBox
        '
        Me.Pregunta1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Pregunta1", True))
        Me.Pregunta1TextBox.Location = New System.Drawing.Point(135, 496)
        Me.Pregunta1TextBox.Name = "Pregunta1TextBox"
        Me.Pregunta1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pregunta1TextBox.TabIndex = 28
        '
        'Pregunta2TextBox
        '
        Me.Pregunta2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Pregunta2", True))
        Me.Pregunta2TextBox.Location = New System.Drawing.Point(135, 522)
        Me.Pregunta2TextBox.Name = "Pregunta2TextBox"
        Me.Pregunta2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pregunta2TextBox.TabIndex = 29
        '
        'Pregunta3TextBox
        '
        Me.Pregunta3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Pregunta3", True))
        Me.Pregunta3TextBox.Location = New System.Drawing.Point(135, 548)
        Me.Pregunta3TextBox.Name = "Pregunta3TextBox"
        Me.Pregunta3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pregunta3TextBox.TabIndex = 30
        '
        'PreguntaAleatoriaLabel1
        '
        Me.PreguntaAleatoriaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "PreguntaAleatoria", True))
        Me.PreguntaAleatoriaLabel1.Location = New System.Drawing.Point(132, 67)
        Me.PreguntaAleatoriaLabel1.Name = "PreguntaAleatoriaLabel1"
        Me.PreguntaAleatoriaLabel1.Size = New System.Drawing.Size(471, 23)
        Me.PreguntaAleatoriaLabel1.TabIndex = 31
        Me.PreguntaAleatoriaLabel1.Text = resources.GetString("PreguntaAleatoriaLabel1.Text")
        '
        'RespuestaAleatoriaRichTextBox
        '
        Me.RespuestaAleatoriaRichTextBox.BackColor = System.Drawing.Color.White
        Me.RespuestaAleatoriaRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RespuestaAleatoriaRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "RespuestaAleatoria", True))
        Me.RespuestaAleatoriaRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespuestaAleatoriaRichTextBox.Location = New System.Drawing.Point(53, 323)
        Me.RespuestaAleatoriaRichTextBox.Name = "RespuestaAleatoriaRichTextBox"
        Me.RespuestaAleatoriaRichTextBox.Size = New System.Drawing.Size(664, 154)
        Me.RespuestaAleatoriaRichTextBox.TabIndex = 32
        Me.RespuestaAleatoriaRichTextBox.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.aplicacion.My.Resources.Resources._1304x1087_px_Pregunta7
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.RespuestaAleatoriaRichTextBox)
        Me.Panel1.Controls.Add(Me.Pregunta3TextBox)
        Me.Panel1.Controls.Add(Me.PreguntaAleatoriaLabel1)
        Me.Panel1.Controls.Add(Me.Pregunta2TextBox)
        Me.Panel1.Controls.Add(Me.Pregunta1TextBox)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Usuario_InstagramTextBox)
        Me.Panel1.Controls.Add(Me.NombreTextBox)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(Me.CelularTextBox)
        Me.Panel1.Location = New System.Drawing.Point(29, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 644)
        Me.Panel1.TabIndex = 33
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta Abierta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet1 As aplicacion.DataSet1
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuario_InstagramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pregunta1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pregunta2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pregunta3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreguntaAleatoriaLabel1 As System.Windows.Forms.Label
    Friend WithEvents RespuestaAleatoriaRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
