using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoIntegrador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
public partial class Form1 : Form
        {
            Conexion conexion = new Conexion();

            public Form1()
            {
                InitializeComponent();
            }

            private void CargarProductos()
            {
                using (var conn = conexion.Conectar())
                {
                    conn.Open();
                    string query = "SELECT * FROM productos";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvProductos.DataSource = tabla;
                }
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                using (var conn = conexion.Conectar())
                {
                    conn.Open();
                    string query = @"INSERT INTO productos (nombre, categoria, descripcion, precio, cantidad, estado)
                             VALUES (@nombre, @categoria, @descripcion, @precio, @cantidad, @estado)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                        cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                CargarProductos();
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["id"].Value);
                    using (var conn = conexion.Conectar())
                    {
                        conn.Open();
                        string query = "DELETE FROM productos WHERE id = @id";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    CargarProductos();
                }
            }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["id"].Value);
                    using (var conn = conexion.Conectar())
                    {
                        conn.Open();
                        string query = @"UPDATE productos SET nombre=@nombre, categoria=@categoria, descripcion=@descripcion,
                                precio=@precio, cantidad=@cantidad, estado=@estado WHERE id=@id";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    CargarProductos();
                }
            }

            private void btnCargar_Click(object sender, EventArgs e)
            {
                CargarProductos();
            }

            private void dgvProductos_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    var row = dgvProductos.SelectedRows[0];
                    txtNombre.Text = row.Cells["nombre"].Value.ToString();
                    txtCategoria.Text = row.Cells["categoria"].Value.ToString();
                    txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                    txtPrecio.Text = row.Cells["precio"].Value.ToString();
                    txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                    txtEstado.Text = row.Cells["estado"].Value.ToString();
                }
            }
        }
    }
    }
}
