using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Programa.Acciones.Productos;

namespace ProyectoIntegrador.Programa.Acciones.Usuario.Cerrar_Sesion
{
    public partial class CerrarSesion : Form
    {
        public CerrarSesion()
        {
            InitializeComponent();
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Close(); // o this.Hide();
        }
    }
}
