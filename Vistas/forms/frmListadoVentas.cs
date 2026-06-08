using System;
using System.Windows.Forms;
using ClaseBase.service;
using Vistas.forms;

namespace Vistas.Forms
{
    public partial class frmListadoVentas : Form
    {
        //VentaService ventaService = new VentaService();

        public frmListadoVentas()
        {
            InitializeComponent();
        }

        private void Load_Clientes()
        {
            cmbClientes.DataSource = ClienteService.listar_ClientesNombreCompleto();
            cmbClientes.DisplayMember = "Cli_DNI";
            cmbClientes.ValueMember = "Cli_DNI";
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null && cmbClientes.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dgvVentas.DataSource = VentaService.Listar_VentasPorCliente(cmbClientes.SelectedValue.ToString());
            }
        }

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            Load_Clientes();
        }
      
    }
}