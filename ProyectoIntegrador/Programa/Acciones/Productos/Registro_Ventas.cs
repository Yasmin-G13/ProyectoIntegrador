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
    public partial class Registro_Ventas : Form
    {
        public Registro_Ventas()
        {
            InitializeComponent();
            MostrarVentas();
        }

        private void btn_Catálogo_Productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close(); // o this.Hide();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Close();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            Inventario pedidos = new Inventario();
            pedidos.Show();
            this.Close();
        }

        private void btn_Ajustes_Seguridad_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
            this.Close();
        }

        private void btn_Cerrar_Sesion_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrarsesion = new CerrarSesion();
            cerrarsesion.Show();
            this.Close();
        }
        public void MostrarVentas()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "tics";
            string bd = "nyas"; // Asegúrate que sea igual a tu base
            string puerto = "3306"; // Puerto predeterminado
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

            string consulta = "SELECT  c.nombre AS Cliente,    p.nombre AS Producto,   v.cantidad AS Cantidad, v.detalles AS Detalles,   v.precio AS Precio,   v.fecha_venta  FROM    ventas v JOIN     clientes c ON v.id_cliente = c.id_cliente JOIN  productos p ON v.id_producto = p.id_producto;";

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
                            dgvVentas.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void ventas_load(object sender, EventArgs e)
        {
            MostrarVentas(); // Aquí llama a tu método que carga en la vista
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarVenta agregarventa = new AgregarVenta();
            agregarventa.Show();
        }
    }
}
