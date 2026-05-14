using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ClaseBase.repository;
using ClaseBase.model;
using System.Windows.Forms;
namespace Vistas.Service
{
    class UsuarioService
    {
        public static bool UsuarioExiste(string nombre, string contra)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(contra))
            {
                return UsuarioRepository.UserExiste(nombre, contra); 
            }
            return false;
        }

        public static DataTable Lista_Roles()
        {
            return UsuarioRepository.Listar_Roles();
        }

        public static void GuardarUser(string nombreU, string contraU, string nyaU, int rol_id,string correo)
        {
            Usuario nu = new Usuario(nombreU,contraU,nyaU,rol_id,correo);
            UsuarioRepository.InsertarUsuario(nu);
            MessageBox.Show("Usuario Guardado correctamente");
        }
    }
}
