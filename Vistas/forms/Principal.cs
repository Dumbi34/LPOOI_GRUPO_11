using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vistas.forms;

using ClaseBase.service;
namespace Vistas
{
    public partial class Principal : Form
    {
        public Principal(string nameUser)
        {
            InitializeComponent();
            lblUserActive.Text = nameUser;
        }
        private void Principal_Load_1(object sender, EventArgs e)
        {
            int rol = UsuarioService.IdRolUsuario(lblUserActive.Text);
            if (rol == 1)
            {

                menuCliente.Visible = false;
                menuVentas.Visible = false;
                menuOS.Visible = false;
            }
            else
            {
                if (rol == 2)
                {
                    menuUsuario.Visible = false;
                    menuProducto.Visible = false;
                    menuOS.Visible = false;
                }
            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormularioProducto fp = new FormularioProducto();
            fp.Show();
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            FormularioObraSocial fo = new FormularioObraSocial();
            fo.Show();
        }

        //Gestion Usuarios
        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            FrmUsuarioRegistrar cu = new FrmUsuarioRegistrar();
            cu.Show();
        }
        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            FrmUsuarioEliminar eu = new FrmUsuarioEliminar(lblUserActive.Text);
            eu.Show();
        }
        private void btnConsultaUser_Click(object sender, EventArgs e)
        {
            FrmUsuarioConsultar cu = new FrmUsuarioConsultar();
            cu.Show();
        }
        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            FrmUsuarioModificar mu = new FrmUsuarioModificar();
            mu.Show();
        }
        //cliente
        private void manuRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente fc = new FormularioCliente();
            fc.Show();
        }
        //producto
        private void menuRegistrarProducto_Click(object sender, EventArgs e)
        {
            FormularioProducto pn = new FormularioProducto();
            pn.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductoConsulta pc = new FrmProductoConsulta();
            pc.Show();
        }
        //venta
        private void menuVentaAgregar_Click(object sender, EventArgs e)
        {
            frmVentaRegistrar nv = new frmVentaRegistrar();
            nv.Show();
        }
        private void menuVentaLista_Click(object sender, EventArgs e)
        {
            FrmVentaListado vl = new FrmVentaListado();
            vl.Show();
        }
        //botonos
        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = SystemColors.Control;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir de la aplicacion?", "confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbSalida_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro de cerrar sesion", "confirmar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gbSistema_Enter(object sender, EventArgs e)
        {

        }

        private void menuOS_Click(object sender, EventArgs e)
        {

        }

        private void menuCliente_Click(object sender, EventArgs e)
        {

        }
        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoVentas frm = new frmListadoVentas();

            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
