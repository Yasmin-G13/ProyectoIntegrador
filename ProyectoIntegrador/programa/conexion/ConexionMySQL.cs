using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Esta clase establece una conexión a una base de datos MySQL utilizando la biblioteca MySql.Data.MySqlClient.
public class ConexionMySQL
{
    private MySqlConnection? conexion;

    private static String servidor = "localhost";
    private static String usuario = "root";
    private static String password = "tics";
    private static String bd = "nyas";
    private static String puerto = "3306";

    private static String cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

    // Es un método que establece la conexión a la base de datos MySQL
    // y devuelve un objeto MySqlConnection.
    public MySqlConnection establecerConexion()
    {
        try
        {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            // Si ocurre un error al intentar conectar, se muestra un mensaje de error.
            MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            throw new Exception("Error al conectar a la base de datos: " + ex.Message);
        }

    }

    // Este método cierra la conexión a la base de datos MySQL si está abierta.
    // Si ocurre un error al cerrar la conexión, se muestra un mensaje de error.
    public void cerrarConexion()
    {
        try
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                //MessageBox.Show("Conexión cerrada");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
        }
    }

    // Este método inserta en la base de datos los datos del usuario que se le pasan como parámetros.
    public void insertarUsuario(string nombre, string correo, string contraseña, DateTime fechaRegistro)
    {
        try
        {
            establecerConexion();

            string peticion = "INSERT INTO usuarios (nombre, correo, contraseña, fecha_registro, rol) VALUES (@nombre, @correo, @contraseña, @fecha_registro, @rol)";

            MySqlCommand comando = new MySqlCommand(peticion, conexion);


            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@fecha_registro", fechaRegistro.Date);
            comando.Parameters.AddWithValue("@rol", 0); // Asignar rol 0 por defecto (usuario admin)

            comando.ExecuteNonQuery();

            // Muestra un mensaje de exito al insertar el usuario.
            MessageBox.Show("Usuario insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al insertar usuario: " + ex.Message);
        }

        cerrarConexion();

    }
    public bool usuarioExiste(string nombre)
    {
        bool existe = false;
        try
        {
            establecerConexion();
            string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            int count = Convert.ToInt32(comando.ExecuteScalar());
            existe = count > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al verificar usuario: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
        return existe;
    }
}