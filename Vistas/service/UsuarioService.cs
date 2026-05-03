using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClaseBase.BDsimulador;
namespace Vistas.Service
{
    class UsuarioService
    {
        public bool UsuarioExiste(string nombre, string contra)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(contra))
            {
                foreach (var usu in DatosPrueba.Usuarios)
                {
                    if (usu.Usu_NombreUsuario.Equals(nombre) && usu.Usu_Contrasenia.Equals(contra))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
