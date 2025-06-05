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
            string Nombre = textBox1.Text.Trim();
            string CantidadStr = textBox2.Text.Trim();
            string PrecioStr = textBox3.Text.Trim();
            string Categoria = textBox4.Text.Trim();
            string Detalles = textBox5.Text.Trim();

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
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

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
    }

}
