using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;
using Vistas.Service;

namespace Vistas
{
    public partial class FormularioProducto : Form
    {
        Producto nuevo;
        ProductoService verif = new ProductoService();

        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verif.productoNotNull(txtCategoria.Text,txtCategoria.Text,txtDescripcion.Text,txtPrecio.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos!");
            }
            else
            {
                if (verif.productoPrecioValido(txtPrecio.Text))
                {
                    nuevo = new Producto(txtCodigo.Text, txtCategoria.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text));
                    MessageBox.Show("Producto Guardado!   " +
                           "codigo:  " + txtCodigo.Text +
                           "  Categoria: " + txtCategoria.Text +
                           " Descripcion: " + txtDescripcion.Text +
                           " Precio: " + txtPrecio.Text);
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido. Escriba solo números.");
                }
              
            }
        }
    }
}
