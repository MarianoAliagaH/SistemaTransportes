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
    public partial class Flete : Form
    {
        public Flete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Hacer que el formulario no sea redimensionable
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
        }

        private void btnAbrirFleteNuevo_Click(object sender, EventArgs e)
        {
            FleteNuevo abrirfleteNuevo = new FleteNuevo();
            abrirfleteNuevo.Show();
        }

        private void btnAbrir_AdjuntarPDF_Click(object sender, EventArgs e)
        {
            Flete_AdjuntarPDF abrirFlete_AdjuntarPDF = new Flete_AdjuntarPDF();
            abrirFlete_AdjuntarPDF.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
