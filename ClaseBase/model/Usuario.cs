using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.model
{
    public class Usuario
    {
        public int Usu_Id { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contrasenia { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public string Usu_Correo { get; set; }
        public int Rol_codigo { get; set; }
        
        public Usuario(string nombreUsuario, string contrasenia, string apellidonombre, int rol_codigo,string correo)
        {
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contrasenia = contrasenia;
            Usu_ApellidoNombre = apellidonombre;
            Rol_codigo = rol_codigo;
            Usu_Correo = correo;
        }
        public Usuario(int id, string nombreUsuario, string contrasenia, string apellidonombre, int rol_codigo, string correo)
        {
            Usu_Id = id; 
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contrasenia = contrasenia;
            Usu_ApellidoNombre = apellidonombre;
            Rol_codigo = rol_codigo;
            Usu_Correo = correo;
        }
    }
}
