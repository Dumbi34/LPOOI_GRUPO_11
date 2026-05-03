using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vistas.Service
{
    class ClienteService
    {
         public bool ClienteNotNull(string apellido,string nombre, string dni, string direccion,string cuitOs, string nroCliente)
        {
            if (string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(dni)
                 || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(cuitOs) || string.IsNullOrEmpty(nroCliente))
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
