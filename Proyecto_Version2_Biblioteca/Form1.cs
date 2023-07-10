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
    public partial class Form1 : Form
    {
        int i = 0;
        public String Nombre;
        public Form1()
        {
            InitializeComponent();
            ConexionMaestra_Memo.conectar_Memo2.Open();
            ConexionMaestra_Memo.grid_memo(dtLibros, "EXEC Buscar_Libros2 ''");
            DateTime date = DateTime.Now;
            txtFecEntrega.Text = "";
            txtFecEntrega.Text= Convert.ToString(date.ToString("yyyy/MM/dd"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (i < 4)
            {
                dataGridView1.Rows.Add(dtLibros.Rows[e.RowIndex].Cells[0].Value.ToString(), dtLibros.Rows[e.RowIndex].Cells[1].Value.ToString(), dtLibros.Rows[e.RowIndex].Cells[2].Value.ToString(), dtLibros.Rows[e.RowIndex].Cells[3].Value.ToString());
                i = i + 1;
                txtNumeroLibros.Text = "";
                txtNumeroLibros.Text = Convert.ToString(i);
            }
            else
            {
                MessageBox.Show("EL LIMITE MAXIMO PARA PRESTARTE LIBROS SON DE 4");
            }
        }

        private void btnlector_Click(object sender, EventArgs e)
        {
            Lista_Clientes frm = new Lista_Clientes();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || txtNumeroLibros.Text == Convert.ToString(0))
            {
                MessageBox.Show("NO CUENTA CON ELEMENTOS EN SU TRAMITE");
            }
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                i = i - 1;
                txtNumeroLibros.Text = "";
                txtNumeroLibros.Text = Convert.ToString(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || txtNumeroLibros.Text == Convert.ToString(0))
            {
                MessageBox.Show("NO CUENTA CON ELEMENTOS EN SU TRAMITE");
            }
            else
            {
                if (txtClave.Text == "")
                {
                    MessageBox.Show("FALTA ELEMENTOS POR LLENAR");
                }
                else
                {
                    int filas,a=0;
                    filas = dataGridView1.RowCount - 2;
                    int fila;
                    for (fila = 0; fila <= filas; fila++)
                    {
                        ConexionMaestra_Memo.ejecutar("EXEC Agregar_Prestamos '" + txtClave.Text + "'," + dataGridView1.Rows[fila].Cells[0].Value.ToString() + ",'" + txtFecEntrega.Text + "','" + dtDevolucion.Text + "'");
                        while (ConexionMaestra_Memo.leer_Memo2.Read() && a == filas)
                        {
                            MessageBox.Show(ConexionMaestra_Memo.leer_Memo2["mensaje4"].ToString());
                        }
                        ConexionMaestra_Memo.leer_Memo2.Close();
                        a = a + 1;
                    }
                    ConexionMaestra_Memo.leer_Memo2.Close();
                    dataGridView1.Rows.Clear();
                    i = 0;
                    txtNumeroLibros.Text = "";
                    txtNumeroLibros.Text = Convert.ToString(i);
                    ConexionMaestra_Memo.grid_memo(dtLibros, "EXEC Buscar_Libros2 ''");
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra_Memo.grid_memo(dtLibros, "EXEC Buscar_Libros2 '" + txtBuscar.Text + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                MessageBox.Show("NECESITAMOS EL USUARIO PARA PODER VER SUS DEUDAS");
            }
            else
            {
                Historial_Prestamos frm = new Historial_Prestamos();
                AddOwnedForm(frm);
                frm.txtClave.Text = txtClave.Text;
                frm.txtClave.Enabled = false;
                frm.clave3 = txtClave.Text;
                frm.Mostrar_Prestamos();
                frm.Show();
            }
        }
        public void Actualizar_Tabla_Datos2()
        {
            ConexionMaestra_Memo.grid_memo(dtLibros, "EXEC Buscar_Libros2 ''");
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void lIBROSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Libros frm = new Libros();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void pROVEEDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores frm5 = new Proveedores();
            AddOwnedForm(frm5);
            frm5.Show();
        }

        private void lIBROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Libros frm = new Historial_Libros();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Lista_Clientes frm = new Lista_Clientes();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Proveedores dt1 = new Lista_Proveedores();
            AddOwnedForm(dt1);
            dt1.Show();
        }

        private void dtLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aUTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor dt1 = new Autor();
            AddOwnedForm(dt1);
            dt1.Show();
        }

        private void gENEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciar_Secion dt1 = new Iniciar_Secion();
            AddOwnedForm(dt1);
            dt1.Show();
        }

        private void eDITORIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editorial dt1 = new Editorial();
            AddOwnedForm(dt1);
            dt1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConexionMaestra_Memo.conectar_Memo2.Close();
            Form1 dt2 = new Form1();
            AddOwnedForm(dt2);
            dt2.Show();
        }
    }
}
