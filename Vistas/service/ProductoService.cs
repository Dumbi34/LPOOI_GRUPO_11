using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas.Service
{
    class ProductoService
    {
        decimal preciovalido;
        public bool productoNotNull(string codigo, string categoria, string descripcion, string precio)
        {
            if (string.IsNullOrEmpty(codigo) && string.IsNullOrEmpty(categoria) && string.IsNullOrEmpty(descripcion) &&
                string.IsNullOrEmpty(precio))
            {
                return false;
            }
            else
            {
                return true;
            }    
        }
        public bool productoPrecioValido(string precio)
        {
            decimal temporal;
            return decimal.TryParse(precio, out temporal);
        }
    }
}
