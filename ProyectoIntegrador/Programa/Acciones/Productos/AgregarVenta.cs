using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    //public partial class AgregarVentas : Form
    //{
    //    private string nombreUsuario;

    //    public AgregarVentas()
    //    {
    //        InitializeComponent();
    //    }

    //    private void butnRegresar_Click(object sender, EventArgs e)
    //    {
    //        this.Hide();
    //        Registro_Ventas registroVentas = new Registro_Ventas();
    //        registroVentas.Show();
    //    }

    //    private void butnAñadirventa_Click(object sender, EventArgs e)
    //    {
    //        string cliente = textCliente.Text.Trim();
    //        string producto = textProducto.Text.Trim();
    //        string cantidadStr = textCantidad.Text.Trim();
    //        string detalles = textDetalles.Text.Trim();
    //        string precioStr = textPrecio.Text.Trim();

    //        if (string.IsNullOrEmpty(cliente) || string.IsNullOrEmpty(producto) ||
    //            string.IsNullOrEmpty(cantidadStr) || string.IsNullOrEmpty(precioStr) || string.IsNullOrEmpty(detalles))
    //        {
    //            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (!int.TryParse(cantidadStr, out int cantidad))
    //        {
    //            MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (!decimal.TryParse(precioStr, out decimal precio))
    //        {
    //            MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        ConexionMySQL conexion = new ConexionMySQL();

    //        int idProducto = conexion.obtenerIdProducto(producto);
    //        int idUsuario = conexion.obtenerIdUsuario(nombreUsuario);

    //        if (idProducto == -1)
    //        {
    //            MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        if (idUsuario == -1)
    //        {
    //            MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return;
    //        }

    //        conexion.añadirVenta(cliente, idProducto, idUsuario, cantidad, precio, detalles, DateTime.Now);

    //        MessageBox.Show("Venta añadida correctamente.");
    //    }

    //}
    public partial class AgregarVentas : Form
    {
        public AgregarVentas()
        {
            InitializeComponent();
            ConfigurarAutoCompletarProductos();
            ConfigurarAutoCompletarUsuarios();
        }

        private void butnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Ventas registroVentas = new Registro_Ventas();
            registroVentas.Show();
        }

        private void butnAñadirventa_Click(object sender, EventArgs e)
        {
            string cliente = textCliente.Text.Trim();
            string producto = textProducto.Text.Trim();
            string cantidadStr = textCantidad.Text.Trim();
            string detalles = textDetalles.Text.Trim();
            string precioStr = textPrecio.Text.Trim();

            if (string.IsNullOrEmpty(cliente) || string.IsNullOrEmpty(producto) ||
                string.IsNullOrEmpty(cantidadStr) || string.IsNullOrEmpty(precioStr) || string.IsNullOrEmpty(detalles))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(cantidadStr, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precioStr, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionMySQL conexion = new ConexionMySQL();

            int idProducto = conexion.obtenerIdProducto(producto);

            if (idProducto == -1)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            conexion.añadirVenta(cliente, idProducto, cantidad, precio, detalles, DateTime.Now);
            MessageBox.Show("Venta añadida correctamente.");
        }

        private void ConfigurarAutoCompletarProductos()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            try
            {
                MySqlConnection conn = conexion.establecerConexion(); // Usar la conexión devuelta
                string query = "SELECT nombre FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader.GetString("nombre"));
                }

                textProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textProducto.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        private void ConfigurarAutoCompletarUsuarios()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            try
            {
                MySqlConnection conn = conexion.establecerConexion(); // Usar la conexión devuelta
                string query = "SELECT nombre FROM usuarios";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader.GetString("nombre"));
                }

                textCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textCliente.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }

}
