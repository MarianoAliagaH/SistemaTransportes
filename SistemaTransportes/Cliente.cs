using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTransportes
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Hacer que el formulario no sea redimensionable
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
        }

        private void btnAbrirClienteNuevo_Click(object sender, EventArgs e)

        {
            ClienteNuevo ventanaClienteNuevo = new ClienteNuevo();
            ventanaClienteNuevo.Show();
        }

        private void btnAbrirFlete_Click(object sender, EventArgs e)
        {
            Flete ventanaflete = new Flete();
            ventanaflete.Show();
        }

        private void btnClienteInformacion_Click(object sender, EventArgs e)
        {
            ClienteInformacion ventanaClienteInformacion = new ClienteInformacion();
            ventanaClienteInformacion.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
