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
    public partial class Inventario : Form

    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close();
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

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrarsesion = new CerrarSesion();
            cerrarsesion.Show();
            this.Close();
        }
        public void MostrarInventario()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "tics";
            string bd = "nyas"; 
            string puerto = "3306"; 
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

            string consulta = "SELECT nombre AS Producto,  detalles AS Detalles, cantidad AS Cantidad FROM  productos;";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open(); 

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(lector); 
                            dgvInventario.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }
        private void inventario_load(object sender, EventArgs e)
        {
            CargarInventario(); 
        }

        //private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string servidor = "localhost";
        //    string usuario = "root";
        //    string password = "tics";
        //    string bd = "nyas"; // Asegúrate que sea igual a tu base
        //    string puerto = "3306"; // Puerto predeterminado
        //    string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

        //    string consulta = "SELECT nombre AS Nombre, cantidad AS Cantidad, detalles AS Detalles from productos where cantidad > 0";

        //    try
        //    {
        //        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
        //        {
        //            conexion.Open(); // Muy importante: abrir la conexión

        //            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
        //            {
        //                using (MySqlDataReader lector = comando.ExecuteReader())
        //                {
        //                    DataTable dt = new DataTable();
        //                    dt.Load(lector); // Cargar los datos del DataReader al DataTable
        //                    dgvInventario.DataSource = dt;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
        //    }
        //}
        private void CargarInventario()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "tics";
            string bd = "nyas";
            string puerto = "3306";
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario};Pwd={password}";

            string consulta = "SELECT nombre AS Nombre, cantidad AS Cantidad, detalles AS Detalles FROM productos WHERE cantidad > 0";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(lector);
                            dgvInventario.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }
    }
}
