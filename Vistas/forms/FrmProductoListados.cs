using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClaseBase.service;
namespace Vistas.forms
{
    public partial class FrmProductoListados : Form
    {
        public FrmProductoListados()
        {
            InitializeComponent();
        }

        private void FrmProductoListados_Load(object sender, EventArgs e)
        {
            cbClientes.DataSource = ClienteService.listar_ClientesNombreCompleto();
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "Cli_DNI";
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedValue != null && cbClientes.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dgwListadoProductos.DataSource = ProductoService.ListarProductoporCliente(cbClientes.SelectedValue.ToString());
            }
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            if (dtpFecha1.Value.Date > dtpFecha2.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Fechas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgwListadoProductos.DataSource = ProductoService.ListarProductosPorFechas(dtpFecha1.Value.Date, dtpFecha2.Value.Date);
                txtCantidadVentas.Text = Convert.ToString(ProductoService.Cantidad_VentasPorFechas(dtpFecha1.Value.Date, dtpFecha2.Value.Date));
            }
        }  
    }
}
