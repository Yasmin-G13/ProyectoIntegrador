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
using ProyectoIntegrador.Programa.Acciones.Productos.Ajustes_Seguridad;

namespace ProyectoIntegrador.Resources
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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

                    // Compara ambas contraseñas eliminando espacios y en minúscula
                    if (contrasenaAlmacenada.Trim() == contraseña.Trim())
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

        private void btnRecuperar_Contraseña_Click(object sender, EventArgs e)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            if (conexion.usuarioExiste(textUsuario.Text))
            {
                Ajustes actualizarConta = new Ajustes(textUsuario.Text);
                actualizarConta.Show();
                this.Hide();
                return;
            }



        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
