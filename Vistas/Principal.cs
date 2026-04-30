using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente fc = new FormularioCliente();
            fc.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormularioProducto fp = new FormularioProducto();
            fp.Show();
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            FormularioObraSocial fo = new FormularioObraSocial();
            fo.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir de la aplicacion?", "confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

     
  
    }
}
