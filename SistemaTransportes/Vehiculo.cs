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
    public partial class Vehiculo : Form
    {
        public Vehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoVehiculo nuevoVehiculoV = new NuevoVehiculo();
            nuevoVehiculoV.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InformacionVehiculo informacionVehiculov = new InformacionVehiculo();
            informacionVehiculov.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
