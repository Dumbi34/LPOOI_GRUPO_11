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
            frmCrearUsuario cu = new frmCrearUsuario();
            cu.Show();
        }
        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario eu = new frmEliminarUsuario(lblUserActive.Text);
            eu.Show();
        }
        private void btnConsultaUser_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario cu = new frmConsultarUsuario();
            cu.Show();
        }
        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            frmModificarUsuario mu = new frmModificarUsuario();
            mu.Show();
        }
        //cliente
        private void manuRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente fc = new FormularioCliente();
            fc.Show();
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

        private void menuVentas_Click(object sender, EventArgs e)
        {
            FormularioVentas pantallaVentas = new FormularioVentas();
            pantallaVentas.ShowDialog();
        }  
    }
}
