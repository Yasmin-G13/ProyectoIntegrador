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

namespace ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad
{
    public partial class Ajustes : Form
    {
        string usuarioActual = "nombre_usuario_actual"; // En un sistema real, obtén esto al login
        public Ajustes()
        {
            InitializeComponent();
            textNuevaContraseña.UseSystemPasswordChar = true;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrarsesion = new CerrarSesion();
            cerrarsesion.Show();
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = textNuevaContraseña.Text.Trim();
            string repetirContraseña = textRepetirContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Por favor, ingresa la nueva contraseña.");
                return;
            }

            // Llamada para actualizar y verificar en base
            ConexionMySQL conexion = new ConexionMySQL();
            conexion.ActualizarContraseña(usuarioActual, nuevaContraseña);
        }

    }
}
