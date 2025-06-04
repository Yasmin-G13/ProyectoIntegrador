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
        private bool EsCorreoGmailValido(string correo)
        {
            // Verifica si el correo contiene '@gmail.com' y tiene más de 7 caracteres antes de '@'
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            correo = correo.Trim();

            if (correo.Length <= 7) // muy corto para un correo válido
                return false;

            // Validar que tenga '@gmail.com' al final
            if (!correo.EndsWith("@gmail.com"))
                return false;

            // Validar que tenga '@' en alguna parte (que no sea la última)
            int atIndex = correo.IndexOf('@');
            if (atIndex <= 0 || atIndex > correo.Length - 10) // '@' no debe estar muy cerca del final
                return false;

            return true;
        }


        // Este m�todo nos abre el Form para que el usuario pueda crear su cuenta.0

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

            // Validar que el correo sea válido antes de insertar
            if (!EsCorreoGmailValido(correo))
            {
                MessageBox.Show("Por favor ingresa un correo Gmail válido");
                return; // Aquí se detiene si el correo no es válido
            }

            ConexionMySQL conexion = new ConexionMySQL();

            // Verifica si el usuario ya existe
            if (conexion.usuarioExiste(nombre))
            {
                MessageBox.Show("El usuario ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserta solo si pasa todo
            try
            {
                conexion.insertarUsuario(nombre, correo, contraseña, DateTime.Now);
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

