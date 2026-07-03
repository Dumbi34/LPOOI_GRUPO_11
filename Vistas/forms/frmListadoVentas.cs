using System;
using System.Windows.Forms;
using ClaseBase.service;
using Vistas.forms;


namespace Vistas.Forms
{
    public partial class frmListadoVentas : Form
    {
      

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
                System.Data.DataTable tablaVentas = VentaService.Listar_VentasPorCliente(cmbClientes.SelectedValue.ToString());
                dgvVentas.DataSource = tablaVentas;
                txtCantidad.Text = tablaVentas.Rows.Count.ToString();
            }
        }

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            Load_Clientes();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            
            if (dgvVentas.CurrentRow != null)
            {
                
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {

                    int nroVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["Nro. Venta"].Value);

                   
                    if (VentaService.EliminarVenta(nroVenta))
                    {
                        
                        MessageBox.Show("La venta ha sido eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        dgvVentas.DataSource = VentaService.Listar_VentasPorCliente(cmbClientes.SelectedValue.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta de la lista.");
            }
        }
      
    }
}