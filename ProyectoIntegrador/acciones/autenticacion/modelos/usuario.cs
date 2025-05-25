using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esta clase representa un usuario de nuestro sistema de autenticación.
public class Usuario
{
    // [ID] es un identificador único para cada usuario.
    public int ID;
    // [nombre] es el nombre del usuario.
    public String nombre;
    // [correo] es el correo electrónico del usuario.
    public String correo;
    // [contraseña] es la contraseña del usuario.
    public String contraseña;
    // [fechaDeRegistro] es la fecha en que el usuario se registró en el sistema.
    public DateTime fechaDeRegsitro;
    // [rol] es el rol del usuario en el sistema (por ejemplo, 0 = admin, 1 = usuario normal).
    public int rol;

    // Constructor de la clase Usuario que inicializa todos los campos.
    public Usuario(int id, string nombre, string correo, string contraseña, DateTime fechaDeRegistro, int rol)
    {
        ID = id;
        this.nombre = nombre;
        this.correo = correo;
        this.contraseña = contraseña;
        this.fechaDeRegsitro = fechaDeRegistro;
        this.rol = rol;
    }


}

