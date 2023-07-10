using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Version2_Biblioteca
{
    public partial class Historial_Prestamos : Form
    {
        public string clave3;
        public Historial_Prestamos()
        {
            InitializeComponent();
        }

        private void Historial_Prestamos_Load(object sender, EventArgs e)
        {

        }
        public void Mostrar_Prestamos()
        {
            ConexionMaestra_Memo.grid_memo(dtPrestamos, "EXEC Mostrar_Deudas '" + clave3 + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dtPrestamos.CurrentRow == null)
            {
                MessageBox.Show("NO HAY NINGUN ELEMENTO EN DEUDA");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("EXEC Devolver_Libros " + dtPrestamos.CurrentRow.Cells[0].Value.ToString() + "");
                while (ConexionMaestra_Memo.leer_Memo2.Read())
                {
                    MessageBox.Show(ConexionMaestra_Memo.leer_Memo2["mensaje3"].ToString());
                }
                ConexionMaestra_Memo.leer_Memo2.Close();
                ConexionMaestra_Memo.grid_memo(dtPrestamos, "EXEC Mostrar_Deudas '" + clave3 + "'");
                Form1 dato = Owner as Form1;
                dato.Actualizar_Tabla_Datos2();
            }
        }
    }
}
