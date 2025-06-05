using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad;
using ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Registro_Ventas ventas = new Registro_Ventas();
            ventas.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Close();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
            this.Close();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrarsesion = new CerrarSesion();
            cerrarsesion.Show();
            this.Close();
        }
    }
}
