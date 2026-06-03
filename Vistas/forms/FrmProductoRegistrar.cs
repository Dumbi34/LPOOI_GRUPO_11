using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClaseBase.model;
using ClaseBase.service;
namespace Vistas
{
    public partial class FormularioProducto : Form
    {
        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!DatosNoNull(txtCodigo.Text,txtCategoria.Text,txtDescripcion.Text,txtPrecio.Text))
            {
                if(!ProductoService.codigoRegistrado(txtCodigo.Text))
                {
                    Producto nuevo = new Producto(txtCodigo.Text, txtCategoria.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text));
                    ProductoService.insertarProducto(nuevo);
                    MessageBox.Show("¡Producto registrado con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡El codigo ya esta Registrado!");
                }
            }
            else
            {
                MessageBox.Show("¡Debe rellenar todos los campos!");
            }
        }

        //Control de datos formulario
        private bool DatosNoNull(string cod,string cat,string des,string precio)
        {
            if(string.IsNullOrEmpty(cod) || string.IsNullOrEmpty(cat) || string.IsNullOrEmpty(des) || string.IsNullOrEmpty (precio))
            {
                return true;
            }
            else
            {
                decimal precioConvertido;
                if (!decimal.TryParse(precio, out precioConvertido))
                {
                    MessageBox.Show("El precio ingresado no es válido. Asegúrese de ingresar solo números (use coma para los decimales).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true; 
                }
                else
                {
                    return false;
                }                    
            }
        }
    }
}
