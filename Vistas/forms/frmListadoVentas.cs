using System;
using System.Windows.Forms;
using ClaseBase.service;
using Vistas.forms;

namespace Vistas.Forms
{
    public partial class frmListadoVentas : Form
    {
        VentaService ventaService = new VentaService();

        public frmListadoVentas()
        {
            InitializeComponent();

            this.Load += frmListadoVentas_Load;
        }

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ventaService.ObtenerVentas();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}