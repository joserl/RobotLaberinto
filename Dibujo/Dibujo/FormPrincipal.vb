Imports System.Drawing.Graphics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Math

Public Class PanelPrincipal
    Dim PuntoInicial As Point = New Point(720, 410) 'siempre va ser el inicial'
    Dim PuntoFinal As Point
    Dim PuntoAuxiliar As Point
    Dim arreglo(1) As Point
    Dim contador As Integer = 0
    Dim conLabel As Integer = 0
    Dim contadorDerecha As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboPuerto()
        habilitarControles(False)
        TimerC.Stop()

        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.WindowState = 2
        DibujaGrid()
        generarOrigen()
    End Sub

    Private Sub DibujaGrid()
        Dim Lienzo As Graphics = Me.CreateGraphics
        Lienzo.PageUnit = GraphicsUnit.Display  'Define la unidad en display
        Lienzo.DrawPath(New Pen(Color.LightGray, 1), Grid(Me, 20)) 'Cuadricula
        Lienzo.Dispose()
    End Sub

    Private Function Grid(ByVal f As Form, ByVal Intervalo As Integer) As GraphicsPath
        Dim i As Short
        Dim MargenXInicial As Integer = (f.ClientSize.Width Mod Intervalo) / 2
        Dim MargenYInicial As Integer = (f.ClientSize.Height Mod Intervalo) / 2
        Dim GridPath As New GraphicsPath()
        With GridPath
            For i = MargenXInicial To Me.Width - MargenXInicial Step Intervalo
                .AddLine(New Point(i, 0), New Point(i, Me.ClientSize.Height))
                .StartFigure()
            Next
            For i = MargenYInicial To Me.Height - MargenYInicial Step Intervalo
                .AddLine(New Point(0, i), New Point(Me.ClientSize.Width, i))
                .StartFigure()
            Next
        End With
        Return GridPath
    End Function

    Private Sub guardarPuntos(ByVal inicial As Point, ByVal final As Point)
        If arreglo.Length = 2 Then
            arreglo(contador) = inicial
            contador = contador + 1
            arreglo(contador) = final
            contador = contador + 1
        Else
            arreglo(contador) = inicial
            contador = contador + 1
            arreglo(contador) = final
            contador = contador + 1
        End If
        ReDim Preserve arreglo(0 To arreglo.Length + 1)
    End Sub

    Private Sub dibujarArriba(ByVal valor As Double)

        If PuntoInicial.Y = 410 Then
            PuntoFinal = New Point(PuntoInicial.X, 410 - valor)
            PuntoAuxiliar = PuntoInicial
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        Else
            PuntoFinal = New Point(PuntoInicial.X, PuntoInicial.Y - valor)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        End If
        PuntoAuxiliar = PuntoFinal
        guardarPuntos(PuntoInicial, PuntoFinal)
        PuntoInicial = PuntoFinal
    End Sub

    Private Sub dibujarAbajo(ByVal valor As Double)

        If PuntoInicial.Y = 410 Then
            PuntoFinal = New Point(PuntoInicial.X, 410 + valor)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        Else
            PuntoFinal = New Point(PuntoInicial.X, PuntoInicial.Y + valor)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        End If
        PuntoAuxiliar = PuntoFinal
        guardarPuntos(PuntoInicial, PuntoFinal)
        PuntoInicial = PuntoFinal
    End Sub

    Private Sub dibujarDerecha(ByVal valor As Double)

        If PuntoInicial.X = 720 Then
            PuntoFinal = New Point(valor + 720, PuntoInicial.Y)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        Else
            PuntoFinal = New Point(PuntoInicial.X + valor, PuntoInicial.Y)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        End If
        PuntoAuxiliar = PuntoFinal
        guardarPuntos(PuntoInicial, PuntoFinal)
        PuntoInicial = PuntoFinal
    End Sub

    Private Sub dibujarIzquierda(ByVal valor As Double)

        If PuntoInicial.X = 720 Then
            PuntoFinal = New Point(720 - valor, PuntoInicial.Y)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        Else
            PuntoFinal = New Point(PuntoInicial.X - valor, PuntoInicial.Y)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
        End If
        PuntoAuxiliar = PuntoFinal
        guardarPuntos(PuntoInicial, PuntoFinal)
        PuntoInicial = PuntoFinal
    End Sub

    Private Sub borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CreateGraphics.Clear(Me.BackColor)
        DibujaGrid()
    End Sub

    Private Sub redibujar(ByRef arreglo() As Point)
        Me.CreateGraphics.Clear(Me.BackColor)
        DibujaGrid()
        conLabel = 0
        For x = 0 To arreglo.Length - 1
            PuntoInicial = arreglo(x)
            PuntoFinal = arreglo(x + 1)
            Dim Lienzo As Graphics = Me.CreateGraphics
            Dim Lapiz As New Pen(Color.Red, 2)
            Lienzo.PageUnit = GraphicsUnit.Display
            Lienzo.DrawLine(Lapiz, PuntoInicial, PuntoFinal)
            x = x + 1
        Next
        PuntoInicial = PuntoFinal
    End Sub 'Metodo que dibuja el vector leido desde la base de datos'

    Private Sub AbrirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem1.Click
        FormAbrir.ShowDialog()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        If (arreglo.Length = 2) Then
            MsgBox("No hay ningun recorrido para guardar")
        Else

            FormGuardar.recibir(arreglo)
            FormGuardar.ShowDialog()
        End If
    End Sub

    Public Sub componer(ByRef vector As Point())
        redibujar(vector)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        serialPort.Close()
        Me.Close()
    End Sub

    Private Sub generarLabel(ByVal punto As Point)
        If conLabel < 9 Then
            Dim MyLabel01 As New Label
            conLabel = conLabel + 1
            MyLabel01.Name = "label" & conLabel
            MyLabel01.Width = 8
            MyLabel01.Height = 6
            MyLabel01.Text = conLabel
            MyLabel01.TextAlign = ContentAlignment.BottomCenter
            MyLabel01.Font = New Font(MyLabel01.Font.FontFamily, 5)
            MyLabel01.Location = New Point(punto.X, punto.Y)
            Me.Controls.Add(MyLabel01)

        Else
            Dim MyLabel01 As New Label
            conLabel = conLabel + 1
            MyLabel01.Name = "label" & conLabel
            MyLabel01.Width = 12
            MyLabel01.Height = 6
            MyLabel01.Text = conLabel
            MyLabel01.TextAlign = ContentAlignment.BottomCenter
            MyLabel01.Font = New Font(MyLabel01.Font.FontFamily, 5)
            MyLabel01.Location = New Point(punto.X, punto.Y)
            Me.Controls.Add(MyLabel01)
        End If


    End Sub 'Metodo que genera el label consecutivo con un numero' 

    Private Sub btnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdelante.Click
        Select Case contadorDerecha
            Case -3
                dibujarDerecha(10)
            Case -2
                dibujarAbajo(10)
            Case -1
                dibujarIzquierda(10)
            Case 0
                dibujarArriba(10)
            Case 1
                dibujarDerecha(10)
            Case 2
                dibujarAbajo(10)
            Case 3
                dibujarIzquierda(10)
        End Select

        Try
            pararTimer()
            serialPort.Open()
            serialPort.DiscardOutBuffer()
            serialPort.Write(8)
            serialPort.Close()
            habilitarTimer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If (TimerC.Enabled) Then
            Else
                habilitarTimer()
            End If
        End Try
    End Sub

    Private Sub btnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerecha.Click
        generarLabel(PuntoAuxiliar)
        If (contadorDerecha < 0) Then
            If contadorDerecha = -3 Then
                contadorDerecha = 0
            End If
            If contadorDerecha = 0 Then
                contadorDerecha = contadorDerecha + 1
            End If
            If contadorDerecha = -1 Then
                contadorDerecha = contadorDerecha + 1
            End If
            If contadorDerecha = -2 Then
                contadorDerecha = contadorDerecha + 1
            End If
        Else
            If contadorDerecha = 0 Then
                contadorDerecha = contadorDerecha + 1
            Else
                If contadorDerecha = 1 Then
                    contadorDerecha = contadorDerecha + 1
                Else
                    If contadorDerecha = 2 Then
                        contadorDerecha = contadorDerecha + 1
                    Else
                        If contadorDerecha = 3 Then
                            contadorDerecha = 0
                        End If
                    End If
                End If
            End If
        End If
        'MsgBox("El robot a girado 90 grados a la derecha")

        Try
            pararTimer()
            serialPort.Open()
            serialPort.DiscardOutBuffer()
            serialPort.Write(6)
            serialPort.Close()
            habilitarTimer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If (TimerC.Enabled) Then
            Else
                habilitarTimer()
            End If
        End Try
    End Sub

    Private Sub btnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzquierda.Click
        generarLabel(PuntoAuxiliar)
        If (contadorDerecha <= 0) Then
            If contadorDerecha = -3 Then
                contadorDerecha = 0
            End If
            If contadorDerecha = -2 Then
                contadorDerecha = contadorDerecha - 1
            End If
            If contadorDerecha = -1 Then
                contadorDerecha = contadorDerecha - 1
            End If
            If contadorDerecha = 0 Then
                contadorDerecha = contadorDerecha - 1
            End If
        Else
            If contadorDerecha = 1 Then
                contadorDerecha = contadorDerecha - 1
            Else
                If contadorDerecha = 2 Then
                    contadorDerecha = contadorDerecha - 1
                Else
                    If contadorDerecha = 3 Then
                        contadorDerecha = contadorDerecha - 1
                    End If
                End If
            End If
        End If
        'MsgBox("El robot a girado 90 grados a la izquierda")

        Try
            pararTimer()
            serialPort.Open()
            serialPort.DiscardOutBuffer()
            serialPort.Write(4)
            serialPort.Close()
            habilitarTimer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If (TimerC.Enabled) Then
            Else
                habilitarTimer()
            End If
        End Try
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        If (contadorDerecha <= 0) Then
            If contadorDerecha = -3 Then
                contadorDerecha = -1
            Else
                If contadorDerecha = -2 Then
                    contadorDerecha = 0
                Else
                    If contadorDerecha = -1 Then
                        contadorDerecha = 1
                    Else
                        If contadorDerecha = 0 Then
                            contadorDerecha = -2
                        End If
                    End If
                End If
            End If

        Else
            If contadorDerecha = 1 Then
                contadorDerecha = -1
            Else
                If contadorDerecha = 2 Then
                    contadorDerecha = 0
                Else
                    If contadorDerecha = 3 Then
                        contadorDerecha = 1
                    End If
                End If
            End If
        End If
        'MsgBox("El robot a girado 180 grados")

        Try
            pararTimer()
            serialPort.Open()
            serialPort.DiscardOutBuffer()
            serialPort.Write(2)
            serialPort.Close()
            habilitarTimer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If (TimerC.Enabled) Then
            Else
                habilitarTimer()
            End If
        End Try
    End Sub

    Private Sub generarOrigen()
        Dim MyLabel01 As New Label
        MyLabel01.Name = "origen"
        MyLabel01.Width = 8
        MyLabel01.Height = 10
        MyLabel01.BackColor = Color.Red
        MyLabel01.Text = "X"
        MyLabel01.TextAlign = ContentAlignment.BottomCenter
        MyLabel01.Font = New Font(MyLabel01.Font.FontFamily, 8)
        MyLabel01.Location = PuntoInicial
        Me.Controls.Add(MyLabel01)
    End Sub

    Private Sub limpiarLabels()
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is Label Then
                Me.Controls.RemoveAt(i)
            End If
        Next
    End Sub 'borra el contenido de las etiquetas pero no el backcolor'

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Try
            serialPort.PortName = cbxPuerto.Text
            'habilitarControles(True)
            cbxPuerto.Enabled = False
            btnConectar.Enabled = False
            habilitarTimer()
        Catch ex As Exception
            MessageBox.Show("Ya se encuentra seteado un puerto o há ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pararTimer()
        End Try
    End Sub

    Private Sub cargarComboPuerto()
        cbxPuerto.Items.Clear()
        'For Each puerto As String In My.Computer.Ports.SerialPortNames
        cbxPuerto.Items.Add("COM3") 'puerto)
        'Next

        'If cbxPuerto.Items.Count > 0 Then
        cbxPuerto.Text = cbxPuerto.Items(0)
        'End If
    End Sub

    Private Sub TimerC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerC.Tick
        Try
            'ultrasonido
            serialPort.Open()

            serialPort.DiscardOutBuffer()
            serialPort.Write(0)
            Dim ultrasonido = serialPort.ReadLine()
            lblUltrasonido.Text = (ultrasonido)
            If ultrasonido < 400 Then
                btnUltrasonido.Visible = True
            Else
                btnUltrasonido.Visible = False
            End If

            serialPort.DiscardOutBuffer()
            serialPort.Write(7)
            Dim izquierdaSuperior = serialPort.ReadLine
            lblIzquierdaSuperior.Text = (izquierdaSuperior)
            If izquierdaSuperior < 13 Then
                btnSuperiorIzquierda.Visible = True
            Else
                btnSuperiorIzquierda.Visible = False
            End If

            serialPort.DiscardOutBuffer()
            serialPort.Write(9)
            Dim derechaSuperior = serialPort.ReadLine()
            lblDerechaSuperior.Text = (derechaSuperior)
            If derechaSuperior < 9 Then
                btnSuperiorDerecha.Visible = True
            Else
                btnSuperiorDerecha.Visible = False
            End If

            serialPort.DiscardOutBuffer()
            serialPort.Write(1)
            Dim infrarrojoIzquierdo = serialPort.ReadLine()
            lblInfrarrojoIzquierdo.Text = (infrarrojoIzquierdo)
            If infrarrojoIzquierdo < 6 Then
                btnInferiorIzquierda.Visible = True
            Else
                btnInferiorIzquierda.Visible = False
            End If

            serialPort.DiscardOutBuffer()
            serialPort.Write(3)
            Dim infrarrojoDerecho = serialPort.ReadLine()
            lblInfrarrojoDerecho.Text = (infrarrojoDerecho)
            If infrarrojoDerecho < 9 Then
                btnInferiorDerecha.Visible = True
            Else
                btnInferiorDerecha.Visible = False
            End If

            serialPort.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ErrorSDFSDFSDFSD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'TimerC.Stop()
            If serialPort.IsOpen Then
                serialPort.Close()
            End If
        End Try
    End Sub

    Private Sub habilitarTimer()
        TimerC.Start()
    End Sub

    Private Sub pararTimer()
        TimerC.Stop()
    End Sub

    Private Sub habilitarControles(ByVal opcion As Boolean)
        btnAdelante.Enabled = opcion
        btnAtras.Enabled = opcion
        btnIzquierda.Enabled = opcion
        btnDerecha.Enabled = opcion
        btnParar.Enabled = opcion
    End Sub

    Private Sub cargarCombo()
        cbxPuerto.Items.Clear()
        For Each puerto As String In My.Computer.Ports.SerialPortNames
            cbxPuerto.Items.Add(puerto)
        Next

        If cbxPuerto.Items.Count > 0 Then
            cbxPuerto.Text = cbxPuerto.Items(0)
        End If
    End Sub

    Private Sub cbxMostrarValores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMostrarValores.CheckedChanged
        If Me.cbxMostrarValores.Checked Then
            mostrarValoresSensores(True)
        Else
            mostrarValoresSensores(False)
        End If
    End Sub

    Private Sub mostrarValoresSensores(ByVal opcion As Boolean)
        lblDerechaSuperior.Visible = opcion
        lblInfrarrojoDerecho.Visible = opcion
        lblInfrarrojoIzquierdo.Visible = opcion
        lblIzquierdaSuperior.Visible = opcion
    End Sub

    Private Sub btnControlRemoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlRemoto.Click
        habilitarControles(True)
    End Sub
End Class
