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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtContacto.Text == "" || txtCorreo.Text == "" || txtDireccion.Text == "" || txtRazon.Text == "" || txtxTelefono.Text == "")
            {
                MessageBox.Show("FALTAN ELEMENTOS POR AGREGAR");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("EXEC Insertar_Proveedores'" + txtClave.Text + "','" + txtRazon.Text + "','" + txtxTelefono.Text + "','" + txtCorreo.Text + "','" + txtDireccion.Text + "','" + txtContacto.Text + "'");
                while (ConexionMaestra_Memo.leer_Memo2.Read())
                {
                    MessageBox.Show(ConexionMaestra_Memo.leer_Memo2["mensaje5"].ToString());
                }
                ConexionMaestra_Memo.leer_Memo2.Close();
                txtClave.Text = "";
                txtContacto.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                txtRazon.Text = "";
                txtxTelefono.Text = "";
            }
        }
    }
}
