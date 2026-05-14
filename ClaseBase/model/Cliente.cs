using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase.model
{
    public class Cliente
    {
        #region Public

        public string Cli_DNI { get; set; }
        public string Cli_Apellido { get; set; }
        public string Cli_Nombre { get; set; }
        public string Cli_Direccion { get; set; }
        public string OS_CUIT { get; set; }
        public string Cli_NroCarnet { get; set; }

        public Cliente(string dni, string apellido, string nombre,string direccion, string os_cuit, string nroCarnet)
        {
            Cli_DNI = dni;
            Cli_Apellido = apellido;
            Cli_Nombre = nombre;
            OS_CUIT = os_cuit;
            Cli_NroCarnet = nroCarnet;
            Cli_Direccion = direccion;
        }

        #endregion  

    }
}
