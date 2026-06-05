using System;
using System.Data;
using System.Windows.Forms;
using ClaseBase.service; // Esto es clave para que encuentre tu VentaService

namespace Vistas // O el nombre que tenga tu proyecto de interfaces
{
    public partial class FormularioVentas : Form
    {
        // ¡Acá está la magia! Con esto C# ya sabe qué es "verificar"
        VentaService verificar = new VentaService();

        public FormularioVentas()
        {
            InitializeComponent();
        }

        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que las fechas tengan sentido
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamamos al Stored Procedure usando el método de tu Service
                DataTable dtVentas = verificar.BuscarVentasPorFechas(dtpDesde.Value.Date, dtpHasta.Value.Date);

                // Llenamos la grilla que renombramos en el Paso 1
                dgvVentas.DataSource = dtVentas;

                if (dtVentas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas registradas en ese rango de fechas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar por fechas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}