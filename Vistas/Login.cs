using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;

namespace Vistas
{
    public partial class Login : Form
    {
        Rol Administrador = new Rol(1111,"Administrador");
        Rol Auditor = new Rol(2222,"Auditor");
        Rol Operador = new Rol(3333,"Operador");


        Usuario Manolito = new Usuario(20111110,"ManolitoR","manolito","Manolito Ramirez",2222);
        Usuario Benito = new Usuario(21000001,"BenitoG","benito","Garcia Benito",1111);
        Usuario Felipe = new Usuario(19000111,"FelipeG","felipe","Gonzales felipe",3333);
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string passw = txtContraseña.Text;

            if (user == Manolito.Usu_NombreUsuario && passw == Manolito.Usu_Contrasenia ||
                 user == Benito.Usu_NombreUsuario && passw == Benito.Usu_Contrasenia ||
                  user == Felipe.Usu_NombreUsuario && passw == Felipe.Usu_Contrasenia)
            {
                Principal home = new Principal();
                home.Show();
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos");
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
    }
}
