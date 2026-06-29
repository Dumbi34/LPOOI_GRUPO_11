using System;
using System.IO;

namespace ClaseBase.service
{
    public static class Conexion
    {
        public static string ObtenerCadena()
        {
            /*/ 1. Detecta en qué carpeta está corriendo el programa (Vistas\bin\Debug)
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            // 2. Viaja 3 carpetas para atrás automáticamente y entra a ClaseBase a buscar el .mdf
            string rutaMdf = Path.GetFullPath(Path.Combine(rutaBase, @"..\..\..\ClaseBase\OpticaG11.mdf"));

            // 3. Devuelve la cadena de conexión perfecta armada con la ruta de la compu actual
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + rutaMdf + @";Integrated Security=True;Connect Timeout=30;User Instance=True";
            */
            // 1. Detecta en qué carpeta está corriendo el programa
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            // 2. Armamos las dos rutas posibles
            // Ruta A: Para cuando el programa ya está instalado (el .mdf está junto al .exe)
            string rutaProduccion = Path.Combine(rutaBase, "OpticaG11.mdf");

            // Ruta B: Para cuando están programando en Visual Studio (la de ustedes)
            string rutaDesarrollo = Path.GetFullPath(Path.Combine(rutaBase, @"..\..\..\ClaseBase\OpticaG11.mdf"));

            string rutaFinal = "";

            // 3. Inteligencia: ¿Existe el archivo al lado del .exe?
            if (System.IO.File.Exists(rutaProduccion))
            {
                // Si existe, estamos en el programa instalado
                rutaFinal = rutaProduccion;
            }
            else
            {
                // Si no existe, estamos en Visual Studio programando
                rutaFinal = rutaDesarrollo;
            }

            // 4. Devuelve la cadena con la ruta correcta
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + rutaFinal + @";Integrated Security=True;Connect Timeout=30;User Instance=True";
       }
    }
}