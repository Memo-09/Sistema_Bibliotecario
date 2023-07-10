using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Version2_Biblioteca
{
    class ConexionMaestra_Memo
    {
        static String Servidor_Memo = @"DESKTOP-C92F43V";
        static String user_memo = "memo";
        static String password = "crash";
        static String databaseName = @"biblioteca_guillermo";
        static String cadena_conexion_memo = "data source=" + Servidor_Memo + "; initial catalog=" + databaseName + "; user id=" +
            user_memo + "; password=" + password;
        public static SqlConnection conectar_Memo2 = new SqlConnection(cadena_conexion_memo);
        public static SqlCommand consulta_memo = new SqlCommand();
        public static SqlDataReader leer_Memo2;
        public static void abrir_memo()
        {
            if (conectar_Memo2.State == ConnectionState.Closed)
            {
                conectar_Memo2.Open();
                consulta_memo = new SqlCommand();
                consulta_memo.Connection = conectar_Memo2;
            }
        }
        public static void ejecutar(string sql_Memo)
        {
            consulta_memo.Connection = conectar_Memo2;
            consulta_memo.CommandType = System.Data.CommandType.Text;
            consulta_memo.CommandText = sql_Memo;
            leer_Memo2 = consulta_memo.ExecuteReader();
        }
        public static void llenar_dataGrid(DataGridView tabla1, string sql)
        {
            ejecutar(sql);
            while (leer_Memo2.Read())
            {
                tabla1.Rows.Add();
                tabla1.Rows[tabla1.RowCount - 2].Cells[1].Value = leer_Memo2[0];
            }
            leer_Memo2.Close();
            conectar_Memo2.Close();
        }
        public static void grid_memo(DataGridView tabla_memo, string sql_memo)
        {
            ejecutar(sql_memo);
            leer_Memo2.Close();
            DataSet tabla_memo2 = new DataSet();
            SqlDataAdapter adaptador_memo = new SqlDataAdapter(consulta_memo);
            adaptador_memo.Fill(tabla_memo2, "datos");
            tabla_memo.DataSource = tabla_memo2;
            tabla_memo.DataMember = "datos";
            tabla_memo2.AcceptChanges();
        }
    }
}
