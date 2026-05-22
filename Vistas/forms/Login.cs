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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string passw = txtContraseña.Text;

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(passw))
            {
                if (UsuarioService.UserExiste(user, passw))
                {
                    Principal home = new Principal(user);
                    home.Show();
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir de la aplicacion?","confirmar",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.GreenYellow;

        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control ;
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Red;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = SystemColors.Control;
        }

        private void lblRecuperarContraseña_Click(object sender, EventArgs e)
        {
            LoginRecuperacionPssw recuperar = new LoginRecuperacionPssw();
            recuperar.Show();
        }

        private void lblRecuperarContraseña_MouseHover(object sender, EventArgs e)
        {
            lblRecuperarContraseña.BackColor = Color.Aqua;
        }

        private void lblRecuperarContraseña_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperarContraseña.BackColor = SystemColors.ActiveBorder;
        }
    }
}
