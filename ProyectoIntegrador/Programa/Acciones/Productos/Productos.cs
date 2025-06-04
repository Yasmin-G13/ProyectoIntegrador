using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion;

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

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Close(); // o this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Registro_Ventas ventas = new Registro_Ventas();
            ventas.Show();
            this.Close(); // o this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrar = new CerrarSesion();
            cerrar.Show();
            this.Close(); // o this.Hide();
        }
    }
}
