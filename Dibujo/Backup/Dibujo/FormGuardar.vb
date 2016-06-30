Public Class FormGuardar
    Dim conexion As String = "Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID='';Initial Catalog=TP_Com;Data Source=ROMAN-PC\SQLEXPRESS;Initial File Name='';Server SPN=''"
    Dim vector() As Point


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub


    Public Sub recibir(ByRef arreglo() As Point)
        vector = arreglo
    End Sub

    Private Sub registrar(ByRef nombre As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim recorrido As String
        Dim recta As String
        Dim rectaxRecorrido As String
        conexion.ConnectionString = Me.conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        Dim MaxRecorrido As Integer = maRecorrido() + 1
        recorrido = "INSERT INTO Recorrido VALUES (" & MaxRecorrido & ",'" & txtNombre.Text & "')"
        cmd.CommandText = recorrido
        cmd.ExecuteNonQuery()
        For x = 0 To vector.Length - 1
            Dim MaxRecta As Integer = maRecta() + 1
            recta = "INSERT INTO Recta VALUES (" & MaxRecta & "," & vector(x).X & "," & vector(x).Y & "," & vector(x + 1).X & "," & vector(x + 1).Y & ")"
            cmd.CommandText = recta
            cmd.ExecuteNonQuery()
            rectaxRecorrido = "INSERT INTO RecorridoXRecta VALUES (" & MaxRecorrido & "," & MaxRecta & ")"
            cmd.CommandText = rectaxRecorrido
            cmd.ExecuteNonQuery()
            x = x + 1
        Next
        conexion.Close()
    End Sub


    Private Function maRecta() As Integer
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        Dim max As String = ""
        conexion.Open()
        max = "SELECT * FROM Recta"
        cmd.CommandText = max
        cmd.Connection = conexion
        tabla.Load(cmd.ExecuteReader())
        cmd.CommandType = CommandType.Text
        conexion.Close()
        Return tabla.Rows.Count
    End Function 'Metodo que devuelve el ultimo id de recta'


    Private Function maRecorrido() As Integer
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        Dim max As String = ""
        conexion.Open()
        max = "SELECT * FROM Recorrido"
        cmd.CommandText = max
        cmd.Connection = conexion
        tabla.Load(cmd.ExecuteReader())
        cmd.CommandType = CommandType.Text
        conexion.Close()
        Return tabla.Rows.Count
    End Function 'Metodo que devuelve el ultimo id de recorrido'

    Private Function maRecorridoxRecta() As Integer
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        Dim max As String = ""
        conexion.Open()
        max = "SELECT * FROM RecorridoXRecta"
        cmd.CommandText = max
        cmd.Connection = conexion
        tabla.Load(cmd.ExecuteReader())
        cmd.CommandType = CommandType.Text
        conexion.Close()
        Return tabla.Rows.Count
    End Function 'Metodo que devuelve el ultimo id de recorridoXRecta'

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        registrar(txtNombre.Text)
        MsgBox("Se ha guardado correctamente")
        Dispose()
    End Sub
End Class
