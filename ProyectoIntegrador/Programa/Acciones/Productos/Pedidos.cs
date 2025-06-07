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
            string bd = "nyas"; // Asegúrate que sea igual a tu base
            string puerto = "3306"; // Puerto predeterminado
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

            string consulta = "SELECT c.nombre AS Nombre, p.nombre AS Producto, pe.cantidad AS Cantidad, pe.detalles AS Detalles,  pe.fecha_pedido as Fecha, pe.status AS Estatus FROM  pedidos pe JOIN clientes c ON pe.id_cliente = c.id_cliente JOIN  productos p ON pe.id_producto = p.id_producto";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open(); // Muy importante: abrir la conexión

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(lector); // Cargar los datos del DataReader al DataTable
                            dataPedidos.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
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
    }
}
