using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ClaseBase.service;
namespace Vistas
{
    public partial class FormularioCliente : Form
    {

        ClienteService verificar = new ClienteService();

        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verificar.ClienteNotNull(txtApellido.Text, txtNombre.Text, txtDNI.Text, txtDireccion.Text, txtCuitOS.Text, txtNroCliente.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos!");
            }
            else
            {
                try
                {
                    verificar.InsertarCliente(txtDNI.Text, txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtCuitOS.Text, txtNroCliente.Text);

                    MessageBox.Show("¡Registro Exitoso en la base de datos!\n" +
                                    "Apellido: " + txtApellido.Text + "\n" +
                                    "Nombre: " + txtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al guardar en la base de datos: " + ex.Message);
                }
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = verificar.BuscarClientesCombinado(txtBuscaApe.Text, txtBuscaDni.Text);
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al consultar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cancelar el registro y salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // --- ACÁ ESTABA EL ERROR: Agregué el nombre del método y completé la línea del Enabled ---
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                txtModDni.Text = dgvClientes.CurrentRow.Cells["Cli_DNI"].Value.ToString();
                txtModApellido.Text = dgvClientes.CurrentRow.Cells["Cli_Apellido"].Value.ToString();
                txtModNombre.Text = dgvClientes.CurrentRow.Cells["Cli_Nombre"].Value.ToString();
                txtModDireccion.Text = dgvClientes.CurrentRow.Cells["Cli_Direccion"].Value.ToString();
                txtModCuit.Text = dgvClientes.CurrentRow.Cells["OS_CUIT"].Value.ToString();
                txtModCarnet.Text = dgvClientes.CurrentRow.Cells["Cli_NroCarnet"].Value.ToString();

                txtModDni.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtModDni.Text != "")
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        verificar.EliminarCliente(txtModDni.Text);
                        MessageBox.Show("¡Cliente eliminado con éxito!");

                        txtModDni.Text = "";
                        txtModApellido.Text = "";
                        txtModNombre.Text = "";
                        txtModDireccion.Text = "";
                        txtModCarnet.Text = "";
                        txtModCuit.Text = "";

                        btnConsultar.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un cliente de la tabla primero.");
            }
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            if (txtModDni.Text != "")
            {
                try
                {
                    verificar.ModificarCliente(txtModDni.Text, txtModApellido.Text, txtModNombre.Text, txtModDireccion.Text, txtModCuit.Text, txtModCarnet.Text);

                    MessageBox.Show("¡Datos del cliente actualizados!");

                    txtModDni.Text = "";
                    txtModApellido.Text = "";
                    txtModNombre.Text = "";
                    txtModDireccion.Text = "";
                    txtModCuit.Text = "";
                    txtModCarnet.Text = "";

                    txtModDni.Enabled = true;

                    btnConsultar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un cliente de la tabla primero.");
            }
        }

    }
}