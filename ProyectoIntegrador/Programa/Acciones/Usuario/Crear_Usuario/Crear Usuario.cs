using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_a_bienvenida(object sender, EventArgs e)
        {

            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Hide();

        }


        // Este m�todo nos abre el Form para que el usuario pueda crear su cuenta.

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string contraseña = textContraseña.Text.Trim();
            string repetirContraseña = textRepetirContraseña.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(repetirContraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas coincidan
            if (contraseña != repetirContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionMySQL conexion = new ConexionMySQL();

            // Verifica si el usuario ya existe
            if (conexion.usuarioExiste(nombre))
            {
                MessageBox.Show("El usuario ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserta si pasa todo
            try
            {
                conexion.insertarUsuario(nombre, " ", contraseña, DateTime.Now);
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

