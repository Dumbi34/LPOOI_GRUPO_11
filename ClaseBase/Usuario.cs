using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Usuario
    {
        public int Usu_CUIT { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contrasenia { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol_codigo { get; set; }
        
        
        public Usuario(int cuit, string nombreUsuario, string contrasenia, string apellidonombre, int rol_codigo)
        {
            Usu_CUIT = cuit;
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contrasenia = contrasenia;
            Usu_ApellidoNombre = apellidonombre;
            Rol_codigo = rol_codigo;
        }
    }
}
