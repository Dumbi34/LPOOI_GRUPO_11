using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.model
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string ClienteNombre { get; set; }
        public decimal Total { get; set; }
    }
}
