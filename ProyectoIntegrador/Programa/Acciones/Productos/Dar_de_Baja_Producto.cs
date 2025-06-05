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
    public partial class Dar_de_Baja_Producto : Form
    {
        public Dar_de_Baja_Producto()
        {
            InitializeComponent();
        }
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
