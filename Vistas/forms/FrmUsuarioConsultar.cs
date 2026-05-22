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
    public partial class FrmUsuarioConsultar : Form
    {
        public FrmUsuarioConsultar()
        {
            InitializeComponent();
        }
        private void frmConsultaruser_Load(object sender, EventArgs e)
        {
            Load_usuarios();

        }
        private void Load_usuarios()
        {
            dgwConsultaUser.DataSource = UsuarioService.Listar_Usuarios();
            dgwConsultaUser.Columns["Rol_Codigo"].Visible = false;
            dgwConsultaUser.Columns["Usu_ID"].Visible = false;
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            if (txtBuscarUser.Text != "")
            {
                dgwConsultaUser.DataSource = UsuarioService.buscar_usuario(txtBuscarUser.Text);
                dgwConsultaUser.Columns["Rol_Codigo"].Visible = false;
                
            }
            else
            {
                Load_usuarios();
            }
        }
    }
}
