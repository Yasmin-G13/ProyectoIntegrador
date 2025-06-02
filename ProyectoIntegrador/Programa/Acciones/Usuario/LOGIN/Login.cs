using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Programa.Acciones.Productos;

namespace ProyectoIntegrador.Resources
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Close(); // o this.Hide();
        }

       
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombre = textUsuario.Text.Trim();
            string contraseña = textContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación");
                return;
            }

            ConexionMySQL conexion = new ConexionMySQL();

            try
            {
                // Verifica si el usuario existe
                if (conexion.usuarioExiste(nombre))
                {
                    // Obtener contraseña almacenada
                    string contrasenaAlmacenada = conexion.obtenerContraseñaUsuario(nombre);

                    if (contrasenaAlmacenada == null)
                    {
                        MessageBox.Show("Error al verificar contraseña.");
                        return;
                    }

                    if (contrasenaAlmacenada == contraseña)
                    {
                        // Contraseña correcta, abre formulario productos
                        Productos productos = new Productos(); 
                        productos.Show();
                        this.Hide(); // Ocultar login
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
