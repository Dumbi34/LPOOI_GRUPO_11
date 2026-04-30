using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;

namespace Vistas
{
    public partial class FormularioCliente : Form
    {
        Cliente nuevo;
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDNI.Text)
                 || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtCuitOS.Text) || string.IsNullOrEmpty(txtNroCliente.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos!");
            }
            else
            {
                nuevo = new Cliente(txtDNI.Text,txtApellido.Text,txtNombre.Text,txtDireccion.Text, txtCuitOS.Text,txtNroCliente.Text);
                MessageBox.Show(
                    "Registro Exitoso!"+ 
                    "Apellido: " + txtApellido.Text +
                    "Nombre: " + txtNombre.Text +
                    "DNI: " + txtDNI.Text +
                    "Direccion: " + txtDireccion.Text + 
                    "Numero de Cliente: " + txtNroCliente.Text + 
                    "Cuit OS:: " + txtCuitOS.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir de la aplicacion?", "confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

  
   
    }
}
