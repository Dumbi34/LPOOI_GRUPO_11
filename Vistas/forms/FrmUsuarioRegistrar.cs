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
                MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un rol.");
            }
        
        }
        private bool datosNoNull(string user, string contra, string nombreApellido, object rol, string correo)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(contra) || string.IsNullOrEmpty(nombreApellido)
                || rol==null)
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
