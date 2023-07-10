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
    public partial class Lista_Proveedores : Form
    {
        public Lista_Proveedores()
        {
            InitializeComponent();
            ConexionMaestra_Memo.grid_memo(dtProveedores, "EXEC Mostar_Proveedores");
        }

        private void Lista_Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
