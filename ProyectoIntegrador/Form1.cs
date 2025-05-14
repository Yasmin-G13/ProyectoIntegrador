using ProyectoIntegrador.Resources;
using System.Data.SqlClient;
using MySqlConnecion.Data.MSqlClient;

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
    public partial class Form1 : Form
    {
        public Form1()
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
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        
        MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=muebleria_nyas ");
        public MySqlConnection Conectar()
        {
            return new MySqlConnection(connectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}