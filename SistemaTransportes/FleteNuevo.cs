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
    public partial class FleteNuevo : Form
    {
        public FleteNuevo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Hacer que el formulario no sea redimensionable
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
        }

        private void btnAbrir_IngresarTramo_Click(object sender, EventArgs e)
        {
            Flete_IngresarTramo ventanaFlete_IngresarTramo = new Flete_IngresarTramo();
            ventanaFlete_IngresarTramo.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
