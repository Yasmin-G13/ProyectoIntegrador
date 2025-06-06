using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Añadir_Productos : Form
    {
        public Añadir_Productos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            string Nombre = tbNombre.Text.Trim();
            string CantidadStr = tbCantidad.Text.Trim();
            string PrecioStr = tbPrecio.Text.Trim();
            string Categoria = tbCategoria.Text.Trim();
            string Detalles = tbDetalles.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(CantidadStr) ||
                string.IsNullOrEmpty(PrecioStr) || string.IsNullOrEmpty(Categoria) || string.IsNullOrEmpty(Detalles))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que cantidad sea número entero
            if (!int.TryParse(CantidadStr, out int Cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que precio sea decimal
            if (!decimal.TryParse(PrecioStr, out decimal PrecioNum))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionMySQL conexion = new ConexionMySQL();

            // Verifica si el producto ya existe
            if (conexion.productoExiste(Nombre))
            {
                MessageBox.Show("El producto ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserta en la base de datos
            try
            {
                conexion.añadirProducto(Nombre, Cantidad.ToString(), PrecioNum, Categoria, Detalles);
                MessageBox.Show("Producto creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia los controles
                tbNombre.Clear();
                tbCantidad.Clear();
                tbPrecio.Clear();
                tbCategoria.Clear();
                tbDetalles.Clear();

                // Refresca la vista del DataGrid
                // Asegúrate de tener un método como MostrarProductos()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Catálogo_Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close(); // o this.Hide();
        }


        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
