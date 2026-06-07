using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.model
{
    public class Venta
    {
        public DateTime ven_Fecha { get; set; }
        public string cli_dni { get; set; }
        public Venta(DateTime fecha, string dni)
        {
            ven_Fecha = fecha;
            cli_dni = dni;
        }
    }
}
