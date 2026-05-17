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
    public partial class frmEliminarUsuario : Form
    {
        string userActivo;
        public frmEliminarUsuario(string nameUser)
        {
            InitializeComponent();
            userActivo = nameUser;
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            load_Users();
        }
        private void load_Users()
        {
            dgwEliminarUser.DataSource = UsuarioService.Listar_Usuarios();
            dgwEliminarUser.Columns["Rol_Codigo"].Visible = false;
            dgwEliminarUser.Columns["Usu_ID"].Visible = false;
        }

        private void btnElimianrUser_Click(object sender, EventArgs e)
        {

            if (userActivo != txtUserEliminar.Text)
            {
                if (!UsuarioService.EsUltimoAdministrador(txtUserEliminar.Text))
                {
                    DialogResult resultado = MessageBox.Show("Estas seguro de Eliminar a " + txtUserEliminar.Text + "?", "confirmar", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {

                        UsuarioService.EliminarUsuario(txtUserEliminar.Text);
                        MessageBox.Show("Usuario Eliminado Correctamente!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No puede elimiar a " + txtUserEliminar.Text + ", Es el ultimo usuario Administrativo");
                }
            }
            else
            {
                MessageBox.Show("No puede elimiar a " + txtUserEliminar.Text + ", el Usuario esta activo");
            }      
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
          
            if (txtEliminarUser.Text != "")
            {

                DataTable dt = UsuarioService.buscar_usuario(txtEliminarUser.Text);

                dgwEliminarUser.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    txtNombreEliminar.Text = fila["nombre"].ToString();
                    txtUserEliminar.Text = fila["user"].ToString();
                    txtRoleliminar.Text = fila["Rol"].ToString();
                }
                else
                {
                    txtNombreEliminar.Text = "";
                    txtUserEliminar.Text = "";
                    txtRoleliminar.Text = "";
                }
               

            }
            else
            {
                load_Users();
            }
        }
    }
}
