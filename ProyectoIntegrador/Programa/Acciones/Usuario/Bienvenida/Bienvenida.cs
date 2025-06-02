using ProyectoIntegrador.Resources;
using System.Data.SqlClient;

namespace ProyectoIntegrador
{
    //    using MySql.Data.MySqlClient;

    //public class ConexionBD
    //{
    //    private string connectionString = "server=localhost;user=root;password=;database=muebleria_nyas";

    //    public MySqlConnection Conectar()
    //    {
    //        return new MySqlConnection(connectionString);
    //    }
    //}
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void btn_ir_a_iniciar_sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        // Este método nos abre el Form para que el usuario pueda crear su cuenta.
        private void btn_ir_a_crear_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario();
            formCrearUsuario.Show();

        }
    }

}