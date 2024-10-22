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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void btnAbrirProveedorNuevo_Click(object sender, EventArgs e)
        {
            ProveedorNuevo ventanaProveedorNuevo = new ProveedorNuevo();
            ventanaProveedorNuevo.Show();
        }
    }
}
