<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelPrincipal
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
        Me.components = New System.ComponentModel.Container
        Me.PanelControles = New System.Windows.Forms.Panel
        Me.cbxMostrarValores = New System.Windows.Forms.CheckBox
        Me.btnLaberinto = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnConectar = New System.Windows.Forms.Button
        Me.cbxPuerto = New System.Windows.Forms.ComboBox
        Me.PanelControl = New System.Windows.Forms.Panel
        Me.btnParar = New System.Windows.Forms.Button
        Me.btnAdelante = New System.Windows.Forms.Button
        Me.btnDerecha = New System.Windows.Forms.Button
        Me.btnAtras = New System.Windows.Forms.Button
        Me.btnIzquierda = New System.Windows.Forms.Button
        Me.btnControlRemoto = New System.Windows.Forms.Button
        Me.PanelRobot = New System.Windows.Forms.Panel
        Me.lblIzquierdaSuperior = New System.Windows.Forms.Label
        Me.lblInfrarrojoIzquierdo = New System.Windows.Forms.Label
        Me.lblInfrarrojoDerecho = New System.Windows.Forms.Label
        Me.lblDerechaSuperior = New System.Windows.Forms.Label
        Me.lblUltrasonido = New System.Windows.Forms.Label
        Me.btnInferiorDerecha = New System.Windows.Forms.Button
        Me.btnSuperiorDerecha = New System.Windows.Forms.Button
        Me.btnSuperiorIzquierda = New System.Windows.Forms.Button
        Me.btnInferiorIzquierda = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TimerC = New System.Windows.Forms.Timer(Me.components)
        Me.serialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnUltrasonido = New System.Windows.Forms.Button
        Me.PanelControles.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelRobot.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControles
        '
        Me.PanelControles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControles.Controls.Add(Me.cbxMostrarValores)
        Me.PanelControles.Controls.Add(Me.btnLaberinto)
        Me.PanelControles.Controls.Add(Me.Panel1)
        Me.PanelControles.Controls.Add(Me.PanelControl)
        Me.PanelControles.Controls.Add(Me.btnControlRemoto)
        Me.PanelControles.Controls.Add(Me.PanelRobot)
        Me.PanelControles.Location = New System.Drawing.Point(0, 24)
        Me.PanelControles.Name = "PanelControles"
        Me.PanelControles.Size = New System.Drawing.Size(231, 701)
        Me.PanelControles.TabIndex = 22
        '
        'cbxMostrarValores
        '
        Me.cbxMostrarValores.AutoSize = True
        Me.cbxMostrarValores.Location = New System.Drawing.Point(11, 341)
        Me.cbxMostrarValores.Name = "cbxMostrarValores"
        Me.cbxMostrarValores.Size = New System.Drawing.Size(130, 21)
        Me.cbxMostrarValores.TabIndex = 35
        Me.cbxMostrarValores.Text = "Mostrar Valores"
        Me.cbxMostrarValores.UseVisualStyleBackColor = True
        '
        'btnLaberinto
        '
        Me.btnLaberinto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLaberinto.Location = New System.Drawing.Point(46, 375)
        Me.btnLaberinto.Name = "btnLaberinto"
        Me.btnLaberinto.Size = New System.Drawing.Size(139, 35)
        Me.btnLaberinto.TabIndex = 34
        Me.btnLaberinto.Text = "Laberinto"
        Me.btnLaberinto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnConectar)
        Me.Panel1.Controls.Add(Me.cbxPuerto)
        Me.Panel1.Location = New System.Drawing.Point(34, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 77)
        Me.Panel1.TabIndex = 34
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(13, 43)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(121, 23)
        Me.btnConectar.TabIndex = 1
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'cbxPuerto
        '
        Me.cbxPuerto.FormattingEnabled = True
        Me.cbxPuerto.Location = New System.Drawing.Point(13, 13)
        Me.cbxPuerto.MaximumSize = New System.Drawing.Size(121, 0)
        Me.cbxPuerto.MinimumSize = New System.Drawing.Size(121, 0)
        Me.cbxPuerto.Name = "cbxPuerto"
        Me.cbxPuerto.Size = New System.Drawing.Size(121, 24)
        Me.cbxPuerto.TabIndex = 0
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControl.Controls.Add(Me.btnParar)
        Me.PanelControl.Controls.Add(Me.btnAdelante)
        Me.PanelControl.Controls.Add(Me.btnDerecha)
        Me.PanelControl.Controls.Add(Me.btnAtras)
        Me.PanelControl.Controls.Add(Me.btnIzquierda)
        Me.PanelControl.Location = New System.Drawing.Point(3, 480)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(220, 165)
        Me.PanelControl.TabIndex = 9
        '
        'btnParar
        '
        Me.btnParar.Image = Global.Dibujo.My.Resources.Resources.plus
        Me.btnParar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnParar.Location = New System.Drawing.Point(74, 62)
        Me.btnParar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(75, 41)
        Me.btnParar.TabIndex = 13
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'btnAdelante
        '
        Me.btnAdelante.Image = Global.Dibujo.My.Resources.Resources.Up
        Me.btnAdelante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdelante.Location = New System.Drawing.Point(74, 17)
        Me.btnAdelante.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(75, 41)
        Me.btnAdelante.TabIndex = 9
        Me.btnAdelante.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Image = Global.Dibujo.My.Resources.Resources.Forward
        Me.btnDerecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDerecha.Location = New System.Drawing.Point(153, 62)
        Me.btnDerecha.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(65, 41)
        Me.btnDerecha.TabIndex = 12
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Dibujo.My.Resources.Resources.Down
        Me.btnAtras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtras.Location = New System.Drawing.Point(74, 107)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 41)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Image = Global.Dibujo.My.Resources.Resources.Back
        Me.btnIzquierda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIzquierda.Location = New System.Drawing.Point(2, 62)
        Me.btnIzquierda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(67, 41)
        Me.btnIzquierda.TabIndex = 11
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'btnControlRemoto
        '
        Me.btnControlRemoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnControlRemoto.Location = New System.Drawing.Point(46, 431)
        Me.btnControlRemoto.Name = "btnControlRemoto"
        Me.btnControlRemoto.Size = New System.Drawing.Size(139, 35)
        Me.btnControlRemoto.TabIndex = 9
        Me.btnControlRemoto.Text = "Control Remoto"
        Me.btnControlRemoto.UseVisualStyleBackColor = True
        '
        'PanelRobot
        '
        Me.PanelRobot.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelRobot.Controls.Add(Me.btnUltrasonido)
        Me.PanelRobot.Controls.Add(Me.lblIzquierdaSuperior)
        Me.PanelRobot.Controls.Add(Me.lblInfrarrojoIzquierdo)
        Me.PanelRobot.Controls.Add(Me.lblInfrarrojoDerecho)
        Me.PanelRobot.Controls.Add(Me.lblDerechaSuperior)
        Me.PanelRobot.Controls.Add(Me.lblUltrasonido)
        Me.PanelRobot.Controls.Add(Me.btnInferiorDerecha)
        Me.PanelRobot.Controls.Add(Me.btnSuperiorDerecha)
        Me.PanelRobot.Controls.Add(Me.btnSuperiorIzquierda)
        Me.PanelRobot.Controls.Add(Me.btnInferiorIzquierda)
        Me.PanelRobot.Controls.Add(Me.PictureBox1)
        Me.PanelRobot.Location = New System.Drawing.Point(5, 123)
        Me.PanelRobot.Name = "PanelRobot"
        Me.PanelRobot.Size = New System.Drawing.Size(216, 211)
        Me.PanelRobot.TabIndex = 8
        '
        'lblIzquierdaSuperior
        '
        Me.lblIzquierdaSuperior.AutoSize = True
        Me.lblIzquierdaSuperior.ForeColor = System.Drawing.Color.White
        Me.lblIzquierdaSuperior.Location = New System.Drawing.Point(3, 58)
        Me.lblIzquierdaSuperior.MinimumSize = New System.Drawing.Size(20, 17)
        Me.lblIzquierdaSuperior.Name = "lblIzquierdaSuperior"
        Me.lblIzquierdaSuperior.Size = New System.Drawing.Size(20, 17)
        Me.lblIzquierdaSuperior.TabIndex = 42
        Me.lblIzquierdaSuperior.Visible = False
        '
        'lblInfrarrojoIzquierdo
        '
        Me.lblInfrarrojoIzquierdo.AutoSize = True
        Me.lblInfrarrojoIzquierdo.ForeColor = System.Drawing.Color.White
        Me.lblInfrarrojoIzquierdo.Location = New System.Drawing.Point(3, 147)
        Me.lblInfrarrojoIzquierdo.MinimumSize = New System.Drawing.Size(20, 17)
        Me.lblInfrarrojoIzquierdo.Name = "lblInfrarrojoIzquierdo"
        Me.lblInfrarrojoIzquierdo.Size = New System.Drawing.Size(20, 17)
        Me.lblInfrarrojoIzquierdo.TabIndex = 41
        Me.lblInfrarrojoIzquierdo.Visible = False
        '
        'lblInfrarrojoDerecho
        '
        Me.lblInfrarrojoDerecho.AutoSize = True
        Me.lblInfrarrojoDerecho.ForeColor = System.Drawing.Color.White
        Me.lblInfrarrojoDerecho.Location = New System.Drawing.Point(187, 147)
        Me.lblInfrarrojoDerecho.MinimumSize = New System.Drawing.Size(20, 17)
        Me.lblInfrarrojoDerecho.Name = "lblInfrarrojoDerecho"
        Me.lblInfrarrojoDerecho.Size = New System.Drawing.Size(20, 17)
        Me.lblInfrarrojoDerecho.TabIndex = 40
        Me.lblInfrarrojoDerecho.Visible = False
        '
        'lblDerechaSuperior
        '
        Me.lblDerechaSuperior.AutoSize = True
        Me.lblDerechaSuperior.ForeColor = System.Drawing.Color.White
        Me.lblDerechaSuperior.Location = New System.Drawing.Point(187, 58)
        Me.lblDerechaSuperior.MinimumSize = New System.Drawing.Size(20, 17)
        Me.lblDerechaSuperior.Name = "lblDerechaSuperior"
        Me.lblDerechaSuperior.Size = New System.Drawing.Size(20, 17)
        Me.lblDerechaSuperior.TabIndex = 39
        Me.lblDerechaSuperior.Visible = False
        '
        'lblUltrasonido
        '
        Me.lblUltrasonido.AutoSize = True
        Me.lblUltrasonido.ForeColor = System.Drawing.Color.White
        Me.lblUltrasonido.Location = New System.Drawing.Point(80, 4)
        Me.lblUltrasonido.MinimumSize = New System.Drawing.Size(100, 17)
        Me.lblUltrasonido.Name = "lblUltrasonido"
        Me.lblUltrasonido.Size = New System.Drawing.Size(100, 17)
        Me.lblUltrasonido.TabIndex = 38
        '
        'btnInferiorDerecha
        '
        Me.btnInferiorDerecha.BackColor = System.Drawing.Color.Red
        Me.btnInferiorDerecha.Location = New System.Drawing.Point(167, 125)
        Me.btnInferiorDerecha.MinimumSize = New System.Drawing.Size(13, 53)
        Me.btnInferiorDerecha.Name = "btnInferiorDerecha"
        Me.btnInferiorDerecha.Size = New System.Drawing.Size(13, 53)
        Me.btnInferiorDerecha.TabIndex = 37
        Me.btnInferiorDerecha.UseVisualStyleBackColor = False
        Me.btnInferiorDerecha.Visible = False
        '
        'btnSuperiorDerecha
        '
        Me.btnSuperiorDerecha.BackColor = System.Drawing.Color.Red
        Me.btnSuperiorDerecha.Location = New System.Drawing.Point(167, 42)
        Me.btnSuperiorDerecha.MinimumSize = New System.Drawing.Size(13, 53)
        Me.btnSuperiorDerecha.Name = "btnSuperiorDerecha"
        Me.btnSuperiorDerecha.Size = New System.Drawing.Size(13, 53)
        Me.btnSuperiorDerecha.TabIndex = 37
        Me.btnSuperiorDerecha.UseVisualStyleBackColor = False
        Me.btnSuperiorDerecha.Visible = False
        '
        'btnSuperiorIzquierda
        '
        Me.btnSuperiorIzquierda.BackColor = System.Drawing.Color.Red
        Me.btnSuperiorIzquierda.Location = New System.Drawing.Point(30, 42)
        Me.btnSuperiorIzquierda.MinimumSize = New System.Drawing.Size(13, 53)
        Me.btnSuperiorIzquierda.Name = "btnSuperiorIzquierda"
        Me.btnSuperiorIzquierda.Size = New System.Drawing.Size(13, 53)
        Me.btnSuperiorIzquierda.TabIndex = 36
        Me.btnSuperiorIzquierda.UseVisualStyleBackColor = False
        Me.btnSuperiorIzquierda.Visible = False
        '
        'btnInferiorIzquierda
        '
        Me.btnInferiorIzquierda.BackColor = System.Drawing.Color.Red
        Me.btnInferiorIzquierda.Location = New System.Drawing.Point(30, 125)
        Me.btnInferiorIzquierda.MinimumSize = New System.Drawing.Size(13, 53)
        Me.btnInferiorIzquierda.Name = "btnInferiorIzquierda"
        Me.btnInferiorIzquierda.Size = New System.Drawing.Size(13, 53)
        Me.btnInferiorIzquierda.TabIndex = 35
        Me.btnInferiorIzquierda.UseVisualStyleBackColor = False
        Me.btnInferiorIzquierda.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dibujo.My.Resources.Resources.robot
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(29, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 163)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.AbrirToolStripMenuItem1, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.AbrirToolStripMenuItem.Text = "Guardar"
        '
        'AbrirToolStripMenuItem1
        '
        Me.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1"
        Me.AbrirToolStripMenuItem1.Size = New System.Drawing.Size(131, 24)
        Me.AbrirToolStripMenuItem1.Text = "Abrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(719, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Norte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(235, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Oeste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1322, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Este"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(708, 680)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Sur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1146, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Referencia de escala: 1 Cuadrado = 4 cm"
        '
        'TimerC
        '
        Me.TimerC.Enabled = True
        Me.TimerC.Interval = 250
        '
        'serialPort
        '
        Me.serialPort.PortName = "COM3"
        '
        'btnUltrasonido
        '
        Me.btnUltrasonido.BackColor = System.Drawing.Color.Red
        Me.btnUltrasonido.Location = New System.Drawing.Point(75, 18)
        Me.btnUltrasonido.MinimumSize = New System.Drawing.Size(53, 13)
        Me.btnUltrasonido.Name = "btnUltrasonido"
        Me.btnUltrasonido.Size = New System.Drawing.Size(53, 13)
        Me.btnUltrasonido.TabIndex = 38
        Me.btnUltrasonido.UseVisualStyleBackColor = False
        Me.btnUltrasonido.Visible = False
        '
        'PanelPrincipal
        '
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelControles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 2000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "PanelPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recorrido -Robot"
        Me.PanelControles.ResumeLayout(False)
        Me.PanelControles.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelRobot.ResumeLayout(False)
        Me.PanelRobot.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControles As System.Windows.Forms.Panel
    Friend WithEvents btnControlRemoto As System.Windows.Forms.Button
    Friend WithEvents PanelRobot As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Friend WithEvents btnAdelante As System.Windows.Forms.Button
    Friend WithEvents btnDerecha As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIzquierda As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents cbxPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents TimerC As System.Windows.Forms.Timer
    Friend WithEvents serialPort As System.IO.Ports.SerialPort
    Friend WithEvents btnLaberinto As System.Windows.Forms.Button
    Friend WithEvents btnInferiorDerecha As System.Windows.Forms.Button
    Friend WithEvents btnSuperiorDerecha As System.Windows.Forms.Button
    Friend WithEvents btnSuperiorIzquierda As System.Windows.Forms.Button
    Friend WithEvents btnInferiorIzquierda As System.Windows.Forms.Button
    Friend WithEvents lblUltrasonido As System.Windows.Forms.Label
    Friend WithEvents lblInfrarrojoDerecho As System.Windows.Forms.Label
    Friend WithEvents lblDerechaSuperior As System.Windows.Forms.Label
    Friend WithEvents lblInfrarrojoIzquierdo As System.Windows.Forms.Label
    Friend WithEvents lblIzquierdaSuperior As System.Windows.Forms.Label
    Friend WithEvents cbxMostrarValores As System.Windows.Forms.CheckBox
    Friend WithEvents btnUltrasonido As System.Windows.Forms.Button

End Class
