Public Class FormAbrir
    Dim vector() As Point
    Dim conexion As String = "Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TP_Com;Data Source=ROMAN-PC\SQLEXPRESS"
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        cargaCombo(Me.cmbRecorrido, consultaSQL("Recorrido"), "id_recorrido", "nombre")
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByRef resul As Data.DataTable, ByVal pk As String, ByVal nombre As String)
        combo.Items.Clear()
        combo.DataSource = resul
        combo.ValueMember = pk
        combo.DisplayMember = nombre
    End Sub

    Private Function consultaSQL(ByVal table As String) As Data.DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & table & ""
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abrir.Click
        Dim tablaIdRectas As Data.DataTable = recuperarId_Rectas(cmbRecorrido.SelectedValue) 'El PK de recorrido es selectedValue' 
        Dim tablaRectas As Data.DataTable = recuperarRectas(tablaIdRectas)
        vector = rellenarVector(tablaRectas)
        PanelPrincipal.componer(vector)
        Me.Dispose()
    End Sub

    Private Function recuperarRectas(ByVal valor As Data.DataTable) As Data.DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        Dim consulta As String = ""
        Dim row As Integer
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        For i = 0 To valor.Rows.Count - 1
            row = valor.Rows(i).Item("id_Recta")
            consulta = "select codigo_x1,codigo_y1,codigo_x2,codigo_y2 From Recta Where id_Recta= " & row & ""
            cmd.CommandText = consulta
            cmd.ExecuteNonQuery()
            tabla.Load(cmd.ExecuteReader())
        Next
        conexion.Close()
        Return tabla

    End Function 'Metodo que me devuelve una tabla con todas las rectas'

    Private Function rellenarVector(ByVal valor As Data.DataTable) As Point()
        Dim arreglo(1) As Point
        Dim x1 As Integer
        Dim y1 As Integer
        Dim x2 As Integer
        Dim y2 As Integer
        Dim contador As Integer = 0
        Dim puntoInicial As Point
        Dim puntoFinal As Point
        For i = 0 To valor.Rows.Count - 1
            If i = 0 Then
                x1 = valor.Rows(i).Item("codigo_x1")
                y1 = valor.Rows(i).Item("codigo_y1")
                puntoInicial = New Point(x1, y1)
                arreglo(contador) = puntoInicial
                contador = contador + 1
                x2 = valor.Rows(i).Item("codigo_x2")
                y2 = valor.Rows(i).Item("codigo_y2")
                puntoFinal = New Point(x2, y2)
                arreglo(contador) = puntoFinal
                contador = contador + 1
            Else
                ReDim Preserve arreglo(0 To UBound(arreglo) + 1)
                x1 = valor.Rows(i).Item("codigo_x1")
                y1 = valor.Rows(i).Item("codigo_y1")
                puntoInicial = New Point(x1, y1)
                arreglo(contador) = puntoInicial
                contador = contador + 1
                ReDim Preserve arreglo(0 To UBound(arreglo) + 1)
                x2 = valor.Rows(i).Item("codigo_x2")
                y2 = valor.Rows(i).Item("codigo_y2")
                puntoFinal = New Point(x2, y2)
                arreglo(contador) = puntoFinal
                contador = contador + 1
            End If
        Next
        Return arreglo
    End Function 'Metodo que restaura el vector de puntos leido de la base de datos'


    Private Function recuperarId_Rectas(ByVal valor As Integer) As Data.DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.conexion
        Dim consulta As String = ""
        conexion.Open()
        cmd.Connection = conexion
        consulta = "select id_recta from RecorridoXRecta Where id_Recorrido= " & valor & ""
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        cmd.CommandType = CommandType.Text
        conexion.Close()
        Return tabla
    End Function 'Metodo que me devuelve una tabla con todos los ids de las rectas asociados al recorrido seleccionado'


End Class