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

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = VentaService.Listar_Ventas();
        }

    }
}