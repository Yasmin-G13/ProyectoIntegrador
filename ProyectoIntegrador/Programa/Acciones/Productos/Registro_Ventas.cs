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
    public partial class Registro_Ventas : Form
    {
        public Registro_Ventas()
        {
            InitializeComponent();
        }

        private void btn_Catálogo_Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close(); // o this.Hide();
        }
    }
}
