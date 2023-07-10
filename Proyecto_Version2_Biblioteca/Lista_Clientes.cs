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
    public partial class Lista_Clientes : Form
    {
        String Nombre1, Clave;
        public Lista_Clientes()
        {
            InitializeComponent();
        }

        private void Lista_Clientes_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Memo.grid_memo(dtClientes, "EXEC Mostrar_Clientes");
        }

        private void dtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 dato = Owner as Form1;
            dato.txtLector.Text = "";
            dato.txtClave.Text = "";
            Nombre1 = dtClientes.CurrentRow.Cells[1].Value.ToString() + " " + dtClientes.CurrentRow.Cells[2].Value.ToString() + " " + dtClientes.CurrentRow.Cells[3].Value.ToString();
            Clave = dtClientes.CurrentRow.Cells[0].Value.ToString();
            dato.txtLector.Text = Nombre1;
            dato.txtClave.Text = Clave;
            dato.txtClave.Enabled = false;
            Lista_Clientes.ActiveForm.Visible = false;
        }
    }
}
