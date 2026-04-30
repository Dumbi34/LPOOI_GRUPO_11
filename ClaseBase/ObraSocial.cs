using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class ObraSocial
    {
        public string OS_CUIT { get; set; }
        public string OS_RazonSocial { get; set; }
        public string OS_Direccion { get; set; }
        public string OS_Telefono { get; set; }

        public ObraSocial(string cuit,string razonsocial, string direccion, string telefono)
        {
            OS_CUIT = cuit;
            OS_RazonSocial = razonsocial;
            OS_Direccion = direccion;
            OS_Telefono = telefono;
        }
    }
}
