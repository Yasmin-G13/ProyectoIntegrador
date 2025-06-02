using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirProducto_Click_1(object sender, EventArgs e)
        {
            Añadir_Productos añadir = new Añadir_Productos();
            añadir.Show();
            this.Close(); // o this.Hide();
        }
    }
}
