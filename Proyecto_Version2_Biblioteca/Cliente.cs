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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAp1.Text == "" || txtAp2.Text == "" || txtClave.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("FALTAN ELEMENTOS POR AGREGAR");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("EXEC Insertar_Cliente '" + txtClave.Text + "','" + txtNombre.Text + "','" + txtAp1.Text + "','" + txtAp2.Text + "'");
                while (ConexionMaestra_Memo.leer_Memo2.Read())
                {
                    MessageBox.Show(ConexionMaestra_Memo.leer_Memo2["mensaje5"].ToString());
                }
                ConexionMaestra_Memo.leer_Memo2.Close();
                txtAp1.Text = "";
                txtAp2.Text = "";
                txtClave.Text = "";
                txtNombre.Text = "";
            }
        }
    }
}
