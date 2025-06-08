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
using ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad;
using MySqlConnector;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class Productos : Form
    {
        ConexionMySQL funcion = new ConexionMySQL();
        public Productos()
        {
            InitializeComponent();
            MostrarProductos();
            this.Load += productos_load;

        }


        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {

        }
        public void cargarDatos()
        {
            controladores.ControladorProductos controladorProducto = new controladores.ControladorProductos();
            controladorProducto.consultarProductos(dgvProductos);
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener el registro seleccionado
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                int id_producto = Convert.ToInt32(row.Cells["id_producto"].Value);
                string nombreCurso = row.Cells["nombre"].Value.ToString();

                // Mostrar diálogo de confirmación
                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // Proceder con la eliminación si el usuario confirma
                    controladores.ControladorProductos ControladorBa = new controladores.ControladorProductos();
                    ControladorBa.DarBaja(id_producto);
                    cargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un curso para eliminar.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open(); // Muy importante: abrir la conexión

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(lector); // Cargar los datos del DataReader al DataTable
                            dgvProductos.DataSource = dt;
                        }
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
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
                ModificarProductos modificar = new ModificarProductos(idProducto);
                modificar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona un producto primero.");
            }
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
