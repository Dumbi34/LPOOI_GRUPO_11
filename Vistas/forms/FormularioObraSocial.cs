using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.model;


namespace Vistas
{
    public partial class FormularioObraSocial : Form
    {
        ObraSocial nueva; 
        public FormularioObraSocial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuit.Text) || string.IsNullOrEmpty(txtRazonSocial.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos!");
            }
            else
            {
                nueva= new ObraSocial(txtCuit.Text,txtRazonSocial.Text,txtDireccion.Text,txtTelefono.Text);
                MessageBox.Show("Registro Completado  "+
                     "Cuit:: " + txtCuit.Text +
                     " Razon Social:  " +txtRazonSocial.Text + 
                     "  Direccion:  " + txtDireccion.Text + 
                     "   Telefono:  " + txtTelefono.Text);
            }
        }

    }
}
