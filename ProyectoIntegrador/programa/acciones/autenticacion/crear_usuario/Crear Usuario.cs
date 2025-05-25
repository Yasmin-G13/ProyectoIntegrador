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
            try
            {
                // Establecer conexión a la base de datos MySQL usando la clase ConexionMySQL
                ConexionMySQL conexionMySQL = new ConexionMySQL();
                MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

