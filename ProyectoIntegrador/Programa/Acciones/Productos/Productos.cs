using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Productos : Form
    {
        ConexionMySQL funcion = new ConexionMySQL();
        public Productos()
        {
            InitializeComponent();
            MostrarProductos();

        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dar_de_Baja_Producto bajaproductos = new Dar_de_Baja_Producto();
            bajaproductos.Show();
        }

        private void btnAñadirProducto_Click_1(object sender, EventArgs e)
        {
            Añadir_Productos añadir = new Añadir_Productos();
            añadir.Show();
            this.Close(); // o this.Hide();
        }

        //<<<<<<< HEAD
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Close(); // o this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Registro_Ventas ventas = new Registro_Ventas();
            ventas.Show();
            this.Close(); // o this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion cerrar = new CerrarSesion();
            cerrar.Show();
            this.Close(); // o this.Hide();
        }
        //=======
        // Método para cargar todos los productos en tu DataGridView
        public void MostrarProductos()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "tics";
            string bd = "nyas"; // Asegúrate que sea igual a tu base
            string puerto = "3306"; // Puerto predeterminado
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

            string consulta = "SELECT * FROM productos";

            try
            {
                using (MySqlConnection cargar = new MySqlConnection(cadenaConexion))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(consulta, cargar))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt; // tu DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void productos_load(object sender, EventArgs e)
        {
            MostrarProductos(); // Aquí llama a tu método que carga en la vista
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiDridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarProductos modificarproductos = new ModificarProductos();
            modificarproductos.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public DataTable ObtenerTodosProductos()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        establecerConexion();
        //        string query = "SELECT * FROM productos"; // ajusta a tu tabla
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
        //        adapter.Fill(dt);
        //        MiGridView.DataSource
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al obtener datos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return dt;
        //}
        //>>>>>>> datawritview no funciona
    }
}
