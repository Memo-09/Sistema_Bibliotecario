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
    public partial class AgregarISB : Form
    {
        public string nombre;
        public string clave;
        public string genero;
        public string editorial;
        public string autor;
        public string letra;
        public int cantidad;
        public int a = 0, b = 1;
        public AgregarISB()
        {
            InitializeComponent();
            lbNumero.Text = Convert.ToString(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIBS.Text == "")
            {
                MessageBox.Show("FAVOR DE AGREGAR EL IBS DEL LIBRO");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("INSERT DETALLE_LIBRO_MEMO VALUES('" + txtIBS.Text + "', '" + clave + "',1)");
                ConexionMaestra_Memo.leer_Memo2.Close();
                a = a + 1;
                b = b + 1;
                lbNumero.Text = "";
                lbNumero.Text = Convert.ToString(b);
                txtIBS.Text = "";
                Libros frm = Owner as Libros;
                if (a == cantidad)
                {
                    frm.txtCantidad.Text = "";
                    frm.txtClave.Text = "";
                    frm.txtMaximo.Text = "";
                    frm.txtMin.Text = "";
                    frm.txtNombre.Text = "";
                    frm.txtUbic.Text = "";
                    frm.cmbEstado.Text = "--SELECCIONE--";
                    frm.cmbAutor.Text = "--SELECCIONE--";
                    frm.cmbEditorial.Text = "--SELECCIONE--";
                    frm.cmbGenero.Text = "--SELECCIONE--";
                    frm.cmbLetra.Text = "--S--";
                    AgregarISB.ActiveForm.Visible = false;
                    frm.Actualizar_Tabla_Datos();
                }
            }
        }
    }
}
