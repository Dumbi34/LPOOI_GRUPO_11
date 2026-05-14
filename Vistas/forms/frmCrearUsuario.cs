using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Vistas.Service;
namespace Vistas.forms
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            Load_Roles();
        }

        private void Load_Roles()
        {
            cmbRol.DataSource = UsuarioService.Lista_Roles();

            cmbRol.DisplayMember = "Rol_descripcion";
            
            cmbRol.ValueMember = "Rol_codigo";
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioService.GuardarUser(txtNombreUser.Text, txtContraUser.Text, txtNyAuser.Text, Convert.ToInt32(cmbRol.SelectedValue),txtCorreoUser.Text);
            this.Close();
        }
   
    }
}
