using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class EditarPedidos : Form
    {
        private int idPedido;

        public EditarPedidos(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            ConfigurarAutoCompletarProductos();
            ConfigurarAutoCompletarUsuarios();
            CargarDatosPedido();
        }

        private void CargarDatosPedido()
        {
            var conexion = new global::ConexionMySQL();
            try
            {
                using (MySqlConnection conn = conexion.establecerConexion())
                {
                    string sql = @"
    SELECT 
        p.cliente, 
        pr.nombre, 
        p.cantidad, 
        p.detalles, 
        p.status
    FROM pedidos p
    JOIN productos pr ON pr.id_producto = p.id_producto
    WHERE p.id_pedido = @idPedido";


                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textNombredelcliente.Text = reader.GetString("cliente");
                                textNombredelproducto.Text = reader.GetString("nombre");
                                textCantidad.Text = reader.GetInt32("cantidad").ToString();
                                textDetalles.Text = reader.GetString("detalles");
                                textStatus.Text = reader.GetString("status");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del pedido: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }


        private void butnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfigurarAutoCompletarProductos()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            try
            {
                MySqlConnection conn = conexion.establecerConexion();
                string query = "SELECT nombre FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader.GetString("nombre"));
                }

                textNombredelproducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textNombredelproducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textNombredelproducto.AutoCompleteCustomSource = coleccion;

                reader.Close();
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
            // Puedes implementar esto si tienes una tabla de usuarios
        }

        private void butnGuardar_Click_1(object sender, EventArgs e)
        {
            string cliente = textNombredelcliente.Text.Trim();
            string producto = textNombredelproducto.Text.Trim();
            string cantidadStr = textCantidad.Text.Trim();
            string detalles = textDetalles.Text.Trim();
            string status = textStatus.Text.Trim();

            if (string.IsNullOrEmpty(cliente)
             || string.IsNullOrEmpty(producto)
             || string.IsNullOrEmpty(cantidadStr)
             || string.IsNullOrEmpty(detalles)
             || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(cantidadStr, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var conexion = new global::ConexionMySQL();
            int idProducto = conexion.obtenerIdProducto(producto);
            if (idProducto == -1)
            {
                MessageBox.Show("Producto no encontrado.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama a tu método existente que usa NOW() en el SQL
            conexion.actualizarPedido(
                idPedido,
                cliente,
                idProducto,
                cantidad,
                detalles,
                status
            );

            this.Hide();
            new Pedidos().Show();
        }
    }
}
