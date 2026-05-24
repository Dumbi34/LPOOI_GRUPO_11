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
namespace Vistas.forms
{
    public partial class FrmProductoDelMod : Form
    {
        bool modo;
        public FrmProductoDelMod(bool mod)
        {
            InitializeComponent();
            modo = mod;
        }

        private void FrmProductoEliminar_Load(object sender, EventArgs e)
        {
            Load_Productos();
            Load_CodigosProductos();
            if (modo)
            {
                tbcGestion.SelectedTab = tbEliminar;
                tbcGestion.TabPages.Remove(tbModificar);
            }
            else
            {
                tbcGestion.SelectedTab = tbModificar;
                tbcGestion.TabPages.Remove(tbEliminar); 
            }
        }
        private void Load_Productos()
        {
            dgwProductos.DataSource = ProductoService.Listar_Productos("");

        }
        private void Load_CodigosProductos()
        {
            cbCodigoEliminar.DataSource = ProductoService.Listar_Productos("");
            cbCodigoEliminar.DisplayMember = "Prod_Codigo";
            cbCodigoEliminar.ValueMember = "Prod_Codigo";
        }

        private void cbCodigoEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgwProductos.DataSource;
            string filtro = "Prod_Codigo = '" + cbCodigoEliminar.Text + "'";
            DataRow[] filas = dt.Select(filtro);

            if (filas.Length > 0)
            {
                txtEliminarCategoria.Text = filas[0]["Prod_Categoria"].ToString();
                txtEliminarDescripcion.Text = filas[0]["Prod_Descripcion"].ToString();
                txtEliminarPrecio.Text = filas[0]["Prod_Precio"].ToString();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto pe = new Producto(cbCodigoEliminar.SelectedValue.ToString(), txtEliminarCategoria.Text, txtEliminarDescripcion.Text, Convert.ToDecimal(txtEliminarPrecio.Text));
            DialogResult resultado = MessageBox.Show("Estas seguro de Eliminar el Producto?", "confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                ProductoService.EliminarProducto(pe);
                MessageBox.Show("Producto Eliminado Correctamente!");
                this.Close();
            }
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            Producto pm = new Producto(txtModificarCod.Text, txtModificarCat.Text, txtModificarDes.Text, Convert.ToDecimal(txtModificarPrecio.Text));
            DialogResult resultado = MessageBox.Show("Estas seguro de Modificar el Producto?", "confirmar", MessageBoxButtons.YesNo);
            if (DatosNoNull(txtModificarCod.Text, txtModificarCat.Text, txtModificarDes.Text, txtModificarPrecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (resultado == DialogResult.Yes)
                {
                    ProductoService.ActualizarProducto(pm);
                    MessageBox.Show("Producto Modificado Correctamente!");
                    this.Close();
                }
            }
        }

        private void dgwProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgwProductos.Rows[e.RowIndex];

                txtModificarCat.Text = fila.Cells["Prod_Categoria"].Value.ToString();
                txtModificarDes.Text = fila.Cells["Prod_Descripcion"].Value.ToString();
                txtModificarPrecio.Text = fila.Cells["Prod_Precio"].Value.ToString();
                txtModificarCod.Text = fila.Cells["Prod_Codigo"].Value.ToString();

                txtEliminarCategoria.Text = fila.Cells["Prod_Categoria"].Value.ToString();
                txtEliminarDescripcion.Text = fila.Cells["Prod_Descripcion"].Value.ToString();
                txtEliminarPrecio.Text = fila.Cells["Prod_Precio"].Value.ToString();
                cbCodigoEliminar.SelectedValue = fila.Cells["Prod_Codigo"].Value.ToString();
            }
        }
        private bool DatosNoNull(string cod, string cat, string des, string precio)
        {
            if (string.IsNullOrEmpty(cod) || string.IsNullOrEmpty(cat) || string.IsNullOrEmpty(des) || string.IsNullOrEmpty(precio))
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
