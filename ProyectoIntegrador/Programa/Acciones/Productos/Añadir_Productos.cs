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
            string Cantidad = textBox2.Text.Trim();
            string Precio = textBox3.Text.Trim();
            string Descripcion = textBox4.Text.Trim();
            string Detalles = textBox5.Text.Trim();
            decimal PrecioNum = decimal.Parse(Precio);

            //MessageBox.Show(""+Nombre+ Precio+ Cantidad ,"datos",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Validar campos vacíos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Cantidad) || string.IsNullOrEmpty(Precio))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ConexionMySQL conexion = new ConexionMySQL();
            // Verifica si el usuario ya existe
          if (conexion.productoExiste(Nombre))
            {
                MessageBox.Show("El producto ya existe ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserta si pasa todo
            try
            {
                //conexion.añadirproductos(Nombre, Cantidad, Precio, Descripcion, Detalles);
                conexion.añadirProducto(Nombre, Cantidad, PrecioNum, Descripcion, Detalles);
                MessageBox.Show("Producto creado exitosamente ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }
        private void btn_Catálogo_Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close(); // o this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Añadir_Productos_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
