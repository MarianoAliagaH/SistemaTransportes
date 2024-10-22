﻿using System;
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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Hacer que el formulario no sea redimensionable
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente ventanaCliente = new Cliente();
            ventanaCliente.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            AccesoSistema ventanaCccesoSistema = new AccesoSistema();
            ventanaCccesoSistema.Show();
            this.Dispose();

        }

<<<<<<< HEAD
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesTrabajo ventanaOrdenesTrabajo = new OrdenesTrabajo();
            ventanaOrdenesTrabajo.Show();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

=======
        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal personalV = new Personal();
            personalV.Show();
          
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoV = new Vehiculo();
            vehiculoV.Show();
>>>>>>> 7fbfe98924e0d01dfc88256861f15205f54a9498
        }
    }
}
