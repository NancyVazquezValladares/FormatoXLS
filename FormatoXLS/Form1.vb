Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIdCurso.Text <> "" And txtDescripcion.Text <> "" And txtDuracionHrs.Text <> "" And txtDuracionDias.Text <> "" Then
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                cmd = conexion.CreateCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "RegistroCurso"
                cmd.Parameters.Add("@IdCurso", SqlDbType.Char).Value = txtIdCurso.Text()
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
                cmd.Parameters.Add("@DuracionHoras", SqlDbType.SmallInt).Value = txtDuracionHrs.Text()
                cmd.Parameters.Add("@DuracionDias", SqlDbType.SmallInt).Value = txtDuracionDias.Text
                cmd.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Cursos Registrado")
                Limpiar()
            End If
        End If


    End Sub

    Private Sub Limpiar()
        txtIdCurso.Clear()
        txtDescripcion.Clear()
        txtDuracionHrs.Clear()
        txtDuracionDias.Clear()
        txtIdCurso.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Conexión a la base de datos SQL Server
        Dim connStr As String = "Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Capacitacion; integrated security= SSPI; persist security info= false; trusted_connection = yes;"
        Dim conn As New SqlConnection(connStr)
        conn.Open()

        ' Consulta SQL para obtener los datos
        Dim sql As String = "select * from cursos "
        Dim cmd As New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        ' Crear una instancia de Excel
        Dim excelApp As New Application()
        Dim excelWorkbook As Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Worksheet = CType(excelWorkbook.Sheets(1), Worksheet)

        ' Escribir datos en Excel
        Dim row As Integer = 1
        While dr.Read()
            For col As Integer = 1 To dr.FieldCount
                excelWorksheet.Cells(row, col) = dr(col - 1).ToString()
            Next
            row += 1
        End While

        ' Aplicar formato y calcular sumatorias
        excelWorksheet.Range("A1").CurrentRegion.NumberFormat = "0.00" ' Formato de celda
        excelWorksheet.Range("A1").CurrentRegion.Columns.AutoFit() ' Ajustar ancho de columnas
        excelWorksheet.Cells(row, 1).Value = "Total:"
        excelWorksheet.Cells(row, 2).Formula = "=SUM(B2:B" & (row - 1) & ")" ' Sumatoria

        ' Agregar números de línea
        Dim rowCount As Integer = row - 2
        Dim lineNumbers As Range = excelWorksheet.Range("A2:A" & (rowCount + 1))
        lineNumbers.FormulaR1C1 = "=ROW()-1"

        ' Configurar el archivo de Excel para abrir en modo de solo lectura
        excelWorkbook.Protect(Password:="1234", Structure:=True, Windows:=False)

        ' Guardar el archivo de Excel y mostrarlo
        Dim savePath As String = "D:\9 semestre\Tecnologias de Informacion\cursos.xlsx"
        excelWorkbook.SaveAs(savePath)
        excelApp.Visible = True

        ' Cerrar conexiones y liberar recursos
        dr.Close()
        conn.Close()
        excelApp = Nothing

    End Sub
End Class
