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

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Productos : Form
    {
        ConexionMySQL funcion = new ConexionMySQL();
        public Productos()
        {
            InitializeComponent();

        }
        private void productos_load(object sender, EventArgs e)
        {
            CargarProductos();
        }
         
        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

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
        private void CargarProductos()
        {
            String servidor = "localhost";//"192.168.0.246";
            String usuario = "root";
            String password = "tics";
            String bd = "nyas2";
            String puerto = "3306";
            String cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";
            String consulta = "select * from productos";
         //   return mostrar(MySqlConnection);
         //   funcion.CargarDatos(MiDridView, consulta);
            try {
                using (MySqlConnection cargar = new MySqlConnection(cadenaConexion)) {
                    using (MySqlDataAdapter sda= new MySqlDataAdapter(consulta,cargar))
                    {
                        DataTable dt = new DataTable();
                      MiDridView.DataSource = dt;
                    }
                }
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error al cargar los datos: " + ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiDridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
