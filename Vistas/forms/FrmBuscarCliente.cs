using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas.forms
{
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarbc_Click(object sender, EventArgs e)
        {
            
            string texto = txtBusquedabc.Text;

            
            string criterio = cmbCriterio.SelectedItem != null ? cmbCriterio.SelectedItem.ToString() : "Apellido";
            string orden = cmbOrden.SelectedItem != null ? cmbOrden.SelectedItem.ToString() : "Ascendente";

            
            dgvClientesbc.DataSource = ClaseBase.service.ClienteService.BuscarClientesDinamico(texto, criterio, orden);
        }

        private void dgvClientesbc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
               
                string dniSeleccionado = dgvClientesbc.Rows[e.RowIndex].Cells["Cli_DNI"].Value.ToString();

                
                this.Tag = dniSeleccionado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
