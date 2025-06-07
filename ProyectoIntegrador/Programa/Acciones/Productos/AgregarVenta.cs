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
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void butnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Ventas Añadirpedidos = new Registro_Ventas();
            Añadirpedidos.Show();
        }

        private void butnAñadirventa_Click(object sender, EventArgs e)
        {
            string Cliente = textCliente.Text.Trim();
            string Producto = textProducto.Text.Trim();
            string Cantidad = textCantidad.Text.Trim();
            string Detalles = textDetalles.Text.Trim();
            string Precio = textPrecio.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(Cliente) || string.IsNullOrEmpty(Producto) ||
                string.IsNullOrEmpty(Cantidad) || string.IsNullOrEmpty(Precio) || string.IsNullOrEmpty(Detalles))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que cantidad sea número entero
            if (!int.TryParse(Cantidad, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que precio sea decimal
            if (!decimal.TryParse(Precio, out decimal PrecioNum))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionMySQL conexion = new ConexionMySQL();


            // Inserta en la base de datos
            try
            {
                conexion.añadirProducto(Cliente, Cantidad.ToString(), PrecioNum, Producto, Detalles);
                MessageBox.Show("Producto creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia los controles
                textCliente.Clear();
                textProducto.Clear();
                textCantidad.Clear();
                textDetalles.Clear();
                textPrecio.Clear();

                // Refresca la vista del DataGrid
                // Asegúrate de tener un método como MostrarProductos()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
