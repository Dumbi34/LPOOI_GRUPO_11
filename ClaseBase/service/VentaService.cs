using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.service
{
    public class VentaService
    {
        public DataTable BuscarVentasPorFechas(DateTime desde, DateTime hasta)
        {
            // Tu cadena de conexión exacta a la base OpticaG11
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mauro\Documents\LPOO\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                // Llamamos al Stored Procedure por su nombre exacto
                SqlCommand cmd = new SqlCommand("SP_BuscarVentasPorFechas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Le pasamos las fechas para que filtre
                cmd.Parameters.AddWithValue("@FechaDesde", desde);
                cmd.Parameters.AddWithValue("@FechaHasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}