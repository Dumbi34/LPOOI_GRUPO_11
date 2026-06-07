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
    public partial class FrmUsuarioModificar : Form
    {
        public FrmUsuarioModificar()
        {
            InitializeComponent();
        }
        private void Load_Roles()
        {

            cmbRol.DataSource = UsuarioService.Listar_Roles();

            cmbRol.DisplayMember = "Rol_descripcion";

            cmbRol.ValueMember = "Rol_codigo";

        }
        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            Load_Roles();
            load_Users();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarUser.Text != "")
            {
                DataTable dt = UsuarioService.buscar_usuario(txtBuscarUser.Text);

                dgwUserMdf.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    txtUsuarioMod.Text = fila["user"].ToString();
                    txtNombreAmodf.Text = fila["nombre"].ToString();
                    txtConntraModf.Text = fila["contra"].ToString();
                    txtCorreoMdf.Text = fila["email"].ToString();
                    cmbRol.Text = fila["Rol"].ToString();
                
                }
                else
                {
                    txtUsuarioMod.Text = "";
                    txtNombreAmodf.Text = "";
                    txtConntraModf.Text = "";
                    txtCorreoMdf.Text = "";
                    cmbRol.SelectedIndex = -1;
                }
            }
            else
            {
                load_Users();
            }
        }
        private void load_Users()
        {
            dgwUserMdf.DataSource = UsuarioService.Listar_Usuarios();
            dgwUserMdf.Columns["Rol_Codigo"].Visible = false;
            dgwUserMdf.Columns["Usu_ID"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (datosNoNull(txtUsuarioMod.Text, txtConntraModf.Text, txtNombreAmodf.Text, cmbRol.SelectedValue, txtCorreoMdf.Text))
            { 
                 DialogResult resultado = MessageBox.Show("Estas seguro de modificar a " + txtUsuarioMod.Text + "?", "confirmar", MessageBoxButtons.YesNo);
                 if (resultado == DialogResult.Yes)
                 {
                    int rol_id = Convert.ToInt32(cmbRol.SelectedValue);
                    UsuarioService.ModificarUsuario(txtUsuarioMod.Text, txtConntraModf.Text, txtNombreAmodf.Text, rol_id, txtCorreoMdf.Text);
                    load_Users();
                    txtUsuarioMod.Text = "";
                    txtConntraModf.Text = "";
                    txtNombreAmodf.Text = "";
                    txtCorreoMdf.Text = "";

                 }
            }
            else
            {
                MessageBox.Show("Todos los campos de modificar deben estar rellenos");
            }
        }
        private bool datosNoNull(string usuario,string contra,string nombre,object rol,string correo)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra) || string.IsNullOrEmpty(nombre)
                || rol ==null || string.IsNullOrEmpty(correo))
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
