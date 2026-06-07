using System;
using System.IO;

namespace ClaseBase.service
{
    public static class Conexion
    {
        public static string ObtenerCadena()
        {
            // 1. Detecta en qué carpeta está corriendo el programa (Vistas\bin\Debug)
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            // 2. Viaja 3 carpetas para atrás automáticamente y entra a ClaseBase a buscar el .mdf
            string rutaMdf = Path.GetFullPath(Path.Combine(rutaBase, @"..\..\..\ClaseBase\OpticaG11.mdf"));

            // 3. Devuelve la cadena de conexión perfecta armada con la ruta de la compu actual
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + rutaMdf + @";Integrated Security=True;Connect Timeout=30;User Instance=True";
        }
    }
}