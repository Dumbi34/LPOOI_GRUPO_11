using ClaseBase.model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClaseBase.service
{
    public class VentaService
    {
        private string cadenaConexion = @"Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\OpticaG11.mdf;Integrated Security=True;User Instance=True";

        public List<Venta> ObtenerVentas()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string query = @"
                SELECT
                    v.Ven_Id,
                    v.Ven_Fecha,
                    c.Cli_Nombre,
                    v.Ven_Total
                FROM Venta v
                INNER JOIN Cliente c
                    ON v.Cli_Id = c.Cli_Id";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Venta venta = new Venta();

                    venta.Id = (int)reader["Ven_Id"];
                    venta.Fecha = (System.DateTime)reader["Ven_Fecha"];
                    venta.ClienteNombre = reader["Cli_Nombre"].ToString();
                    venta.Total = (decimal)reader["Ven_Total"];

                    lista.Add(venta);
                }
            }

            return lista;
        }
    }
}
