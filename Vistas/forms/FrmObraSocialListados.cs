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
    public partial class FrmObraSocialListados : Form
    {
        public FrmObraSocialListados()
        {
            InitializeComponent();
        }

        private void FrmObraSocialListados_Load(object sender, EventArgs e)
        {
            load_OS();
        }
        private void load_OS()
        {
            cmbObraSocial.DataSource = ObraSocialService.Listado_OS();
            cmbObraSocial.DisplayMember = "OS_RazonSocial";
            cmbObraSocial.ValueMember = "OS_CUIT";
        }

        private void cmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbObraSocial.SelectedValue != null && cmbObraSocial.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                dgvOS.DataSource = ObraSocialService.Listado_OSclientes(cmbObraSocial.SelectedValue.ToString());
                txtCantidadOS.Text = Convert.ToString(ObraSocialService.Cantidad_ClientesPorObraSocial(cmbObraSocial.SelectedValue.ToString()));
            }
        }
    }
}
