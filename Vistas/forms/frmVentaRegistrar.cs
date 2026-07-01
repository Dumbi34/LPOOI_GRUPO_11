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
    public partial class frmVentaRegistrar : Form
    {
        private DataTable dtCarrito = new DataTable(); 
        private decimal precioTotal = 0;
        public frmVentaRegistrar()
        {
            InitializeComponent();
        }

        private void frmVentaRegistrar_Load(object sender, EventArgs e)
        {
            Load_Clientes();
            Load_Productos();
            cbCodigoProductos_SelectedIndexChanged(sender,e);

            dtCarrito.Columns.Add("Código", typeof(string));
            dtCarrito.Columns.Add("Precio U.", typeof(decimal));
            dtCarrito.Columns.Add("Cantidad", typeof(int));
            dtCarrito.Columns.Add("SubTotal", typeof(decimal));
            dgwVentas.DataSource = dtCarrito;
        }
        private void Load_Clientes()
        {
            cbClientes.DataSource = ClienteService.listar_ClientesNombreCompleto();
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "Cli_DNI";
        }
        private void Load_Productos()
        {
            cbCodigoProductos.DataSource = ProductoService.Listar_Productos("");
            cbCodigoProductos.DisplayMember = "Prod_Codigo";
            cbCodigoProductos.ValueMember = "Prod_Precio";

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1)
            {
                int id;
                Venta nueva = new Venta(dateFecha.Value, cbClientes.SelectedValue.ToString());
                VentaService.insertarVenta(nueva);
                id = VentaService.obtenerUltimaVenta();
                agregarVentaDetalle(id);
                MessageBox.Show("Venta Registrada exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe agregar un cliente para registrar la venta");
            }
        }

        private void btnAñadirCarrito_Click(object sender, EventArgs e)
        {
            if (cbCodigoProductos.SelectedIndex != -1 || verificarCantidad(txtCantidad.Text))
            {
                decimal precioU = Convert.ToDecimal(cbCodigoProductos.SelectedValue);
                string codigo = cbCodigoProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal subtotal = precioU * cantidad;
                calcularTotal(subtotal);
                dtCarrito.Rows.Add(codigo, precioU, cantidad, subtotal);

                txtCantidad.Clear();
                cbCodigoProductos.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un valor correcto en los campos");
            }

        }
        private void agregarVentaDetalle(int numeroDeVenta)
        {
            VentaDetalle nueva;
            foreach (DataRow fila in dtCarrito.Rows)
            {
                string codigo = fila["Código"].ToString();
                decimal precio = Convert.ToDecimal(fila["Precio U."]);
                decimal cantidad = Convert.ToDecimal(fila["Cantidad"]);
                decimal subtotal = Convert.ToDecimal(fila["SubTotal"]);

                nueva = new VentaDetalle(numeroDeVenta, codigo, precio, cantidad, subtotal);

                VentaDetalleService.insertarVentaDetalle(nueva);
            }
        }
        private bool verificarCantidad(string dato)
        {
            int cantidadConvertida;
            if (int.TryParse(dato, out cantidadConvertida) && cantidadConvertida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cbCodigoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoProductos.SelectedIndex != -1 && cbCodigoProductos.SelectedValue != null)
            {
                decimal precio;
                if (decimal.TryParse(cbCodigoProductos.SelectedValue.ToString(), out precio))
                {
                    txtPrecioUnidad.Text = Convert.ToString(precio); 
                }
            }
        }
        private void calcularTotal(decimal dato)
        {
            precioTotal = precioTotal + dato;
            txtPrecioTotal.Text = Convert.ToString(precioTotal);
        }

        private void buscarclientebc_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscador = new FrmBuscarCliente();

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                
                string dniElegido = buscador.Tag.ToString();

               
                cbClientes.SelectedValue = dniElegido;
            }
        }

    }
}
