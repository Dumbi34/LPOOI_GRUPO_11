using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vistas.Service
{
    class ObraSocialService
    {
        public bool ObraSocialNotNull(string cuit, string razonsocial, string direccion, string telefono)
        {
            if (string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(razonsocial) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono))
            {
                return false;
            }
            return true;
        }
    }
}
