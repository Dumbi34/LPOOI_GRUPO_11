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
    public partial class FrmUsuarioRegistrar : Form
    {
        public FrmUsuarioRegistrar()
        {
            InitializeComponent();
            txtNyAuser.KeyPress += txtNyAuser_KeyPress; // Suscribimos el evento a mano, sin tocar el Designer
        }

        private void txtNyAuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dejamos pasar: letras (incluye tildes y ñ automático), espacios, y la tecla de borrar.
            // Todo lo demás (números, símbolos) se cancela ANTES de llegar a la pantalla.
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            Load_Roles();
            dgvUsuarios.DataSource = UsuarioService.Listar_Usuarios();
            dgvUsuarios.Columns["Usu_ID"].Visible = false;
            dgvUsuarios.Columns["Rol_Codigo"].Visible = false;
            dgvUsuarios.Columns["Rol_Descripcion"].HeaderText = "Rol";
            dgvUsuarios.Columns["Usu_NombreUsuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["Usu_Contraseña"].HeaderText = "Contraseña";
            dgvUsuarios.Columns["Usu_ApellidoNombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Usu_Correo"].HeaderText = "Email";
        }

        private void Load_Roles()
        {
            cmbRol.DataSource = UsuarioService.Listar_Roles();

            cmbRol.DisplayMember = "Rol_descripcion";

            cmbRol.ValueMember = "Rol_codigo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (datosNoNull(txtNombreUser.Text, txtContraUser.Text, txtNyAuser.Text, cmbRol.SelectedValue, txtCorreoUser.Text))
            {
                // El correo es opcional (datosNoNull no lo exige), pero SI escribió algo, tiene que tener @
                if (!string.IsNullOrEmpty(txtCorreoUser.Text) && !txtCorreoUser.Text.Contains("@"))
                {
                    MessageBox.Show("El correo ingresado no es válido. Debe contener un @.");
                    return;
                }

                if (!UsuarioService.nombreUsuarioExiste(txtNombreUser.Text))
                {
                    UsuarioService.InsertarUsuario(txtNombreUser.Text, txtContraUser.Text, txtNyAuser.Text, Convert.ToInt32(cmbRol.SelectedValue), txtCorreoUser.Text);
                    MessageBox.Show("Usuario registrado con éxito.");
                    frmCrearUsuario_Load(sender, e);
                    txtNombreUser.Text = "";
                    txtContraUser.Text = "";
                    txtNyAuser.Text = "";
                    txtCorreoUser.Text = "";
                }
                else
                {
                    MessageBox.Show("El nombre del usuario ya esta registrado! ingrese uno nuevo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un rol.");
            }

        }
        private bool datosNoNull(string user, string contra, string nombreApellido, object rol, string correo)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(contra) || string.IsNullOrEmpty(nombreApellido)
                || rol == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}