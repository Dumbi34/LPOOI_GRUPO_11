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
    public partial class FormularioProducto : Form
    {
        Producto nuevo;

        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos!");
            }
            else
            {
                nuevo = new Producto(txtCodigo.Text , txtCategoria.Text,txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text));
                MessageBox.Show("Producto Guardado!   "+
                   "codigo:  " + txtCodigo.Text +
                   "  Categoria: " + txtCategoria.Text + 
                   " Descripcion: " + txtDescripcion.Text + 
                   " Precio: " + txtPrecio.Text);
            }
        }

  
    }
}
