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
    public partial class Editorial : Form
    {
        public Editorial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUbicacion.Text == "")
            {
                MessageBox.Show("FALTAN ELEMENTOS POR AGREGAR");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("INSERT EDITORIAL_MEMO VALUES('" + txtNombre.Text + "','" + txtUbicacion.Text + "',1)");
                ConexionMaestra_Memo.leer_Memo2.Read();
                MessageBox.Show("GUARDADO CON EXITO");
                ConexionMaestra_Memo.leer_Memo2.Close();
                txtNombre.Text = "";
                txtUbicacion.Text = "";
            }
        }
    }
}
