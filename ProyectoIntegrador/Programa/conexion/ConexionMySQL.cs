﻿//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSType;


//// Esta clase establece una conexión a una base de datos MySQL utilizando la biblioteca MySql.Data.MySqlClient.
//public class ConexionMySQL
//{
//    private MySqlConnection? conexion;

//    private static string servidor = "localhost";//"192.168.0.246";
//    private static string usuario = "root";
//    private static string password = "tics";
//    private static string bd = "nyas";
//    private static string puerto = "3306";
//    MySqlDataAdapter MiAdap;
//    DataTable MiData;

//    private static string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};Uid={usuario}; Pwd={password}";

//    // Es un método que establece la conexión a la base de datos MySQL
//    // y devuelve un objeto MySqlConnection.
//    public MySqlConnection establecerConexion()
//    {
//        try
//        {
//            conexion = new MySqlConnection(cadenaConexion);
//            conexion.Open();
//            return conexion;
//        }
//        catch (Exception ex)
//        {
//            // Si ocurre un error al intentar conectar, se muestra un mensaje de error.
//            MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
//            throw new Exception("Error al conectar a la base de datos: " + ex.Message);
//        }

//    }

//    // Este método cierra la conexión a la base de datos MySQL si está abierta.
//    // Si ocurre un error al cerrar la conexión, se muestra un mensaje de error.
//    public void cerrarConexion()
//    {
//        try
//        {
//            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
//            {
//                conexion.Close();
//                //MessageBox.Show("Conexión cerrada");
//            }
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
//        }
//    }

//    // Este método inserta en la base de datos los datos del usuario que se le pasan como parámetros.
//    public void insertarUsuario(string nombre, string correo, string contraseña, DateTime fechaRegistro)
//    {
//        try
//        {
//            establecerConexion();

//            string peticion = "INSERT INTO usuarios (nombre, correo, contraseña, fecha_registro, rol) VALUES (@nombre, @correo, @contraseña, @fecha_registro, @rol)";

//            MySqlCommand comando = new MySqlCommand(peticion, conexion);
//            comando.Parameters.AddWithValue("@nombre", nombre);
//            comando.Parameters.AddWithValue("@correo", correo);
//            comando.Parameters.AddWithValue("@contraseña", contraseña);
//            comando.Parameters.AddWithValue("@fecha_registro", fechaRegistro);
//            comando.Parameters.AddWithValue("@rol", 0); // Asumiendo rol predeterminado 0

//            comando.ExecuteNonQuery();

//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al insertar usuario: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//    }
//    public void añadirProducto(string Nombre, string Cantidad, decimal Precio, string Categoria, string Detalles)
//    {
//        try
//        {
//            establecerConexion();

//            string peticion = "INSERT INTO productos (Nombre, Cantidad, Precio, Categoria, Detalles) VALUES (@Nombre, @Cantidad, @Precio, @Categoria, @Detalles)";

//            MySqlCommand comando = new MySqlCommand(peticion, conexion);
//            comando.Parameters.AddWithValue("@Nombre", Nombre);
//            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
//            comando.Parameters.AddWithValue("@Precio", Precio);
//            comando.Parameters.AddWithValue("@Categoria", Categoria);
//            comando.Parameters.AddWithValue("@Detalles", Detalles);

//            comando.ExecuteNonQuery();

//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al añadir el Producto: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//    }
//    public void ModificarProductos(int id_producto, string nombre, string cantidad, decimal precio, string categoria, string detalles)
//    {
//        try
//        {
//            establecerConexion();

//            string peticion = "UPDATE productos SET nombre = @nombre, cantidad = @cantidad, detalles = @detalles, categoria = @categoria, precio = @precio WHERE id_producto = @id";

//            MySqlCommand comando = new MySqlCommand(peticion, conexion);
//            comando.Parameters.AddWithValue("@nombre", nombre);
//            comando.Parameters.AddWithValue("@cantidad", cantidad);
//            comando.Parameters.AddWithValue("@precio", precio);
//            comando.Parameters.AddWithValue("@categoria", categoria);
//            comando.Parameters.AddWithValue("@detalles", detalles);
//            comando.Parameters.AddWithValue("@id", id_producto);

//            comando.ExecuteNonQuery();
//            MessageBox.Show("Producto agregado correctamente");

//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al modificar el Producto: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//    }
//    public bool usuarioExiste(string nombre)
//    {
//        bool existe = false;
//        try
//        {
//            establecerConexion();
//            string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre";
//            MySqlCommand comando = new MySqlCommand(query, conexion);
//            comando.Parameters.AddWithValue("@nombre", nombre);
//            int count = Convert.ToInt32(comando.ExecuteScalar());
//            existe = count > 0;
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al verificar usuario: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//        return existe;
//    }
//    public bool productoExiste(string Nombre)
//    {
//        bool existe = false;
//        try
//        {
//            establecerConexion();
//            string query = "SELECT COUNT(*) FROM productos WHERE Nombre = @Nombre";
//            MySqlCommand comando = new MySqlCommand(query, conexion);
//            comando.Parameters.AddWithValue("@Nombre", Nombre);
//            int count = Convert.ToInt32(comando.ExecuteScalar());
//            existe = count > 0;
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error el producto ya existe: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//        return existe;
//    }
//    public string obtenerContraseñaUsuario(string usuario)
//    {
//        string contraseña = null;
//        try
//        {
//            establecerConexion();
//            string query = "SELECT contraseña FROM usuarios WHERE nombre = @nombre";
//            MySqlCommand cmd = new MySqlCommand(query, conexion);
//            cmd.Parameters.AddWithValue("@nombre", usuario);
//            var reader = cmd.ExecuteReader();
//            if (reader.Read())
//            {
//                contraseña = reader["contraseña"].ToString();
//            }
//            reader.Close();
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error al obtener contraseña: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//        return contraseña;
//    }
//    // Método en tu clase de acceso a base de datos
//    public void CargarDatos(DataGridView MiDridView, string sqlString)

//    { 
//        MySqlConnection connection = establecerConexion ();
//        MiAdap = new MySqlDataAdapter(sqlString, connection);
//        MiData = new DataTable();
//        MiAdap.Fill(MiData);
//        MessageBox.Show(" ","datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        MiDridView.DataSource = MiData;
//        connection.Close();

//    }
//    public void ActualizarContraseña(string nombreUsuario, string nuevaContra)
//    {
//        try
//        {
//            establecerConexion();

//            string query = "UPDATE usuarios SET contraseña = @contraseña WHERE nombre = @nombre";
//            MySqlCommand cmd = new MySqlCommand(query, conexion);
//            cmd.Parameters.AddWithValue("@contraseña", nuevaContra);
//            cmd.Parameters.AddWithValue("@nombre", nombreUsuario);

//            // Línea de depuración
//            MessageBox.Show("Comando: " + cmd.CommandText);

//            cmd.ExecuteNonQuery();

//            // Verificación para confirmar
//            string verificarQuery = "SELECT contraseña FROM usuarios WHERE nombre = @nombre";
//            MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conexion);
//            verificarCmd.Parameters.AddWithValue("@nombre", nombreUsuario);
//            string valorEnBase = verificarCmd.ExecuteScalar()?.ToString();

//            MessageBox.Show("Contraseña en base después de actualizar: " + valorEnBase);
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error en actualización: " + ex.Message);
//        }
//        finally
//        {
//            cerrarConexion();
//        }
//    }
//}
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

public class ConexionMySQL
{
    private MySqlConnection conexion;

    private static string servidor = "localhost";
    private static string usuario = "root";
    private static string password = "tics";
    private static string bd = "nyas";
    private static string puerto = "3306";

    private static string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};User ID={usuario};Password={password}";

    public MySqlConnection establecerConexion()
    {
        try
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
            }

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            return conexion;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            throw;
        }
    }

    public void cerrarConexion()
    {
        try
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
        }
    }

    public void insertarUsuario(string nombre, string correo, string contraseña, DateTime fechaRegistro)
    {
        try
        {
            establecerConexion();

            string sql = "INSERT INTO usuarios (nombre, correo, contraseña, fecha_registro, rol) VALUES (@nombre, @correo, @contraseña, @fecha_registro, @rol)";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Parameters.AddWithValue("@fecha_registro", fechaRegistro);
            cmd.Parameters.AddWithValue("@rol", 0);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al insertar usuario: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
    }

    public void añadirProducto(string nombre, string cantidad, decimal precio, string categoria, string detalles)
    {
        try
        {
            establecerConexion();

            string sql = "INSERT INTO productos (Nombre, Cantidad, Precio, Categoria, Detalles) VALUES (@Nombre, @Cantidad, @Precio, @Categoria, @Detalles)";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@Detalles", detalles);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al añadir el producto: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
    }

    public void ModificarProductos(int id_producto, string nombre, string cantidad, decimal precio, string categoria, string detalles)
    {
        try
        {
            establecerConexion();

            string sql = "UPDATE productos SET nombre = @nombre, cantidad = @cantidad, detalles = @detalles, categoria = @categoria, precio = @precio WHERE id_producto = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@detalles", detalles);
            cmd.Parameters.AddWithValue("@id", id_producto);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto modificado correctamente");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al modificar el producto: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
    }

    public bool usuarioExiste(string nombre)
    {
        bool existe = false;
        try
        {
            establecerConexion();

            string sql = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
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

    public bool productoExiste(string nombre)
    {
        bool existe = false;
        try
        {
            establecerConexion();

            string sql = "SELECT COUNT(*) FROM productos WHERE Nombre = @Nombre";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            existe = count > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al verificar producto: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
        return existe;
    }

    public string obtenerContraseñaUsuario(string usuario)
    {
        string contraseña = null;
        try
        {
            establecerConexion();

            string sql = "SELECT contraseña FROM usuarios WHERE nombre = @nombre";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", usuario);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    contraseña = reader["contraseña"].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al obtener contraseña: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
        return contraseña;
    }

    public void CargarDatos(DataGridView gridView, string sql)
    {
        try
        {
            establecerConexion();

            using (var adapter = new MySqlDataAdapter(sql, conexion))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gridView.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar datos: " + ex.Message);
        }
        finally
        {
            cerrarConexion();
        }
    }

    //public void ActualizarContraseña(string nombreUsuario, string nuevaContra)
    //{
    //    try
    //    {
    //        establecerConexion();

    //        string sql = "UPDATE usuarios SET contraseña = @nuevaContra WHERE usuario = @usuario";
    //        MySqlCommand cmd = new MySqlCommand(sql, conexion);
    //        cmd.Parameters.AddWithValue("@contraseña", nuevaContra);
    //        cmd.Parameters.AddWithValue("@nombre", nombreUsuario);

    //        cmd.ExecuteNonQuery();
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Error en actualización: " + ex.Message);
    //    }
    //    finally
    //    {
    //        cerrarConexion();
    //    }
    //}
    public void ActualizarContraseña(string usuario, string nuevaContraseña)
    {
        try
        {
            using (MySqlConnection conn = establecerConexion())
            {
                MessageBox.Show($"Correo: {usuario}, Nueva contraseña: {nuevaContraseña}");
                string query = "UPDATE usuarios SET contraseña = @nuevaContraseña WHERE nombre = @usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Contraseña actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o no se actualizó la contraseña.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
        }
    }
}

