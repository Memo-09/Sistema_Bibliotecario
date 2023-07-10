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
    public partial class Historial_Libros : Form
    {
        public Historial_Libros()
        {
            InitializeComponent();
        }

        private void Historial_Libros_Load(object sender, EventArgs e)
        {
            ConexionMaestra_Memo.grid_memo(dtLibros, "EXEC Mostrar_Libros4");
        }
    }
}
