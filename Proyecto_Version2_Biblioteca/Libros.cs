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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
            LLenarCombo_Autor();
            LLenarCombo_Genero();
            LLenarCombo_Editorial();
            LLenarCombo_Letra();
            LLenarCombo_Estado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtClave.Text == "" || cmbGenero.Text == "--SELECCIONE--" || cmbLetra.Text == "--S--" || cmbEditorial.Text == "--SELECCIONE--" || cmbAutor.Text == "--SELECCIONE--" || cmbEstado.Text == "--SELECCIONE--" || txtUbic.Text == "" || txtMin.Text == "" || txtMaximo.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("FALTAN ELEMENTOS POR COMPLETAR");
            }
            else
            {
                ConexionMaestra_Memo.ejecutar("EXEC Insertar_Libros '" + txtClave.Text + "','" + txtNombre.Text + "'," +
                "'" + cmbGenero.Text + "','" + cmbEditorial.Text + "','" + cmbAutor.Text + "','" + cmbLetra.Text + "'," +
                "" + txtCantidad.Text + "," + txtMin.Text + "," + txtMaximo.Text + ",'" + txtUbic.Text + "','" + cmbEstado.Text + "'");
                while (ConexionMaestra_Memo.leer_Memo2.Read())
                {
                    MessageBox.Show(ConexionMaestra_Memo.leer_Memo2["mensaje2"].ToString());
                }
                ConexionMaestra_Memo.leer_Memo2.Close();
                AgregarISB frm = new AgregarISB();
                AddOwnedForm(frm);
                frm.nombre = txtNombre.Text;
                frm.clave = txtClave.Text;
                frm.genero = cmbGenero.Text;
                frm.editorial = cmbEditorial.Text;
                frm.autor = cmbAutor.Text;
                frm.letra = cmbLetra.Text;
                frm.cantidad = Convert.ToInt32(txtCantidad.Text);
                frm.Show();
            }
        }
        public void LLenarCombo_Letra()
        {
            ConexionMaestra_Memo.ejecutar("SELECT LETRA_MEMO.LETRA_MEMO FROM LETRA_MEMO");
            while (ConexionMaestra_Memo.leer_Memo2.Read())
            {
                cmbLetra.Items.Add(ConexionMaestra_Memo.leer_Memo2[0].ToString());
            }
            ConexionMaestra_Memo.leer_Memo2.Close();
        }

        private void cmbLetra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LLenarCombo_Autor()
        {
            ConexionMaestra_Memo.ejecutar("SELECT NOMBRE_AUTOR_MEMO FROM AUTOR_MEMO");
            while (ConexionMaestra_Memo.leer_Memo2.Read())
            {
                cmbAutor.Items.Add(ConexionMaestra_Memo.leer_Memo2[0].ToString());
            }
            ConexionMaestra_Memo.leer_Memo2.Close();
        }
        public void LLenarCombo_Genero()
        {
            ConexionMaestra_Memo.ejecutar("SELECT NOMBRE_GENERO_MEMO FROM GENERO_MEMO");
            while (ConexionMaestra_Memo.leer_Memo2.Read())
            {
                cmbGenero.Items.Add(ConexionMaestra_Memo.leer_Memo2[0].ToString());
            }
            ConexionMaestra_Memo.leer_Memo2.Close();
        }
        public void LLenarCombo_Editorial()
        {
            ConexionMaestra_Memo.ejecutar("SELECT NOMBRE_EDITORIAL_MEMO FROM EDITORIAL_MEMO");
            while (ConexionMaestra_Memo.leer_Memo2.Read())
            {
                cmbEditorial.Items.Add(ConexionMaestra_Memo.leer_Memo2[0].ToString());
            }
            ConexionMaestra_Memo.leer_Memo2.Close();
        }
        public void LLenarCombo_Estado()
        {
            ConexionMaestra_Memo.ejecutar("SELECT [DESCRIPCION_ESTADO] FROM [dbo].[ESTADO_LIBRO]");
            while (ConexionMaestra_Memo.leer_Memo2.Read())
            {
                cmbEstado.Items.Add(ConexionMaestra_Memo.leer_Memo2[0].ToString());
            }
            ConexionMaestra_Memo.leer_Memo2.Close();
        }
        public void Actualizar_Tabla_Datos()
        {
            Form1 frm = Owner as Form1;
            ConexionMaestra_Memo.grid_memo(frm.dtLibros, "EXEC Buscar_Libros2 ''");
        }
    }
}
