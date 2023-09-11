using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace FormatoXLSxd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtIdCurso.Text != "" & txtDescripcion.Text != "" & txtDuracionHrs.Text != "" & txtDuracionDias.Text != "")
            {
                conexionxd.Open();
                if (conexionxd.State == ConnectionState.Open)
                {
                    cmd = conexion.CreateCommand;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "RegistroCurso";
                    cmd.Parameters.Add("@IdCurso", SqlDbType.Char).Value = txtIdCurso.Text();
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                    cmd.Parameters.Add("@DuracionHoras", SqlDbType.SmallInt).Value = txtDuracionHrs.Text();
                    cmd.Parameters.Add("@DuracionDias", SqlDbType.SmallInt).Value = txtDuracionDias.Text;
                    cmd.ExecuteNonQuery();
                    conexionxd.Close();
                    Interaction.MsgBox("Cursos Registrado");
                    Limpiar();
                }
            }

        }
        private void Limpiar()
        {
            txtIdCurso.Clear();
            txtDescripcion.Clear();
            txtDuracionHrs.Clear();
            txtDuracionDias.Clear();
            txtIdCurso.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=LAPTOP-9KA9VTM6\SQLEXPRESS01;Initial Catalog=Capacitacion; integrated security= SSPI; persist security info= false; trusted_connection = yes;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select * from cursos ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Add();
            Worksheet excelWorksheet = (Worksheet)excelWorkbook.Sheets(1);
            int row = 1;
            while (dr.Read())
            {
                for (int col = 1; col <= dr.FieldCount; col++)
                    excelWorksheet.Cells(row, col) = dr(col - 1).ToString();
                row += 1;
            }
            excelWorksheet.Range("A1").CurrentRegion.NumberFormat = "0.00"; // Formato de celda
            excelWorksheet.Range("A1").CurrentRegion.Columns.AutoFit(); // Ajustar ancho de columnas
            excelWorksheet.Cells(row, 1).Value = "Total:";
            excelWorksheet.Cells(row, 2).Formula = "=SUM(B2:B" + (row - 1) + ")"; // Sumatoria
            int rowCount = row - 2;
            Range lineNumbers = excelWorksheet.Range("A2:A" + (rowCount + 1));
            lineNumbers.FormulaR1C1 = "=ROW()-1";
            excelWorkbook.Protect(Password: "1234", Structure: true, Windows: false);
            string savePath = @"D:\9 semestre\Tecnologias de Informacion\cursos.xlsx";
            excelWorkbook.SaveAs(savePath);
            excelApp.Visible = true;
            dr.Close();
            conn.Close();
            excelApp = null;

        }
    }
}
