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
using ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad;
using ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{

    public partial class Pedidos : Form
    {
        private int idPedidoSeleccionado = -1;

        public Pedidos()
        {
            InitializeComponent();
            MostrarPedidos();
            this.Load += pedidos_load;
        }

        private void btn_Catálogo_Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Registro_Ventas ventas = new Registro_Ventas();
            ventas.Show();
            this.Close();
        }

        private void btn_Ajustes_Seguridad_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrarsesion = new CerrarSesion();
            cerrarsesion.Show();
            this.Close();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Close();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Close();
        }

        public void MostrarPedidos()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "tics";
            string bd = "nyas";    // Asegúrate que sea tu base de datos
            string puerto = "3306";    // Puerto predeterminado
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario};Pwd={password}";

            // Consulta con JOIN y columna calculada PrecioTotal
            string consulta = @"
SELECT 
    p.id_pedido          AS ID, 
    p.cliente            AS Cliente, 
    prod.nombre          AS Producto, 
    p.cantidad           AS Cantidad, 
    p.detalles           AS Detalles, 
    p.fecha_pedido       AS Fecha, 
    p.status             AS Estado,
    (prod.precio * p.cantidad) AS PrecioTotal
FROM pedidos p
LEFT JOIN productos prod 
    ON p.id_producto = prod.id_producto;";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(lector);
                        dataPedidos.DataSource = dt;  // Asegúrate que tu DataGridView se llame dataPedidos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los pedidos: " + ex.Message);
            }
        }



        private void pedidos_load(object sender, EventArgs e)
        {
            MostrarPedidos(); // Aquí llama a tu método que carga en la vista
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadirPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            AñadirPedido Añadirpedidos = new AñadirPedido();
            Añadirpedidos.Show();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un pedido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditarPedidos editar = new EditarPedidos(idPedidoSeleccionado);
            editar.Show();
            this.Hide();
        }

        private void dataPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataPedidos.Rows[e.RowIndex];
                object valorID = fila.Cells["ID"].Value;

                if (valorID != null)
                {
                    idPedidoSeleccionado = Convert.ToInt32(valorID);
                }
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un pedido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este pedido?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                string servidor = "localhost";
                string usuario = "root";
                string password = "tics";
                string bd = "nyas";
                string puerto = "3306";
                string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario};Pwd={password}";

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();

                        string consulta = "DELETE FROM pedidos WHERE id_pedido = @id";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idPedidoSeleccionado);
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Pedido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MostrarPedidos(); // Refrescar la tabla
                                idPedidoSeleccionado = -1; // Resetear selección
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el pedido a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
