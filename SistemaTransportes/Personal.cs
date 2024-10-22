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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoPersonal nuevoPersonalV = new NuevoPersonal();
            nuevoPersonalV.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Baja bajaV = new Baja();
            bajaV.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HistorialDocumento historialDocumentoV = new HistorialDocumento();
            historialDocumentoV.Show();

        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }
    }
}
