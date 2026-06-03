using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.model
{
    public class VentaDetalle
    {
        public int ven_num { get; set; }
        public string prod_codigo { get; set; }
        public decimal det_precio { get; set; }
        public decimal det_cantidad { get; set; }
        public decimal det_total { get; set; }

        public VentaDetalle(int num_ven, string cod_prod, decimal precio, decimal cant, decimal total)
        {
            ven_num = num_ven;
            prod_codigo = cod_prod;
            det_precio = precio;
            det_cantidad = cant;
            det_total = total;
        }
    }
}
