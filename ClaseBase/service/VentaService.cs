using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;

namespace ClaseBase.service
{
    public class VentaService
    {
        public DataTable BuscarVentasPorFechas(DateTime desde, DateTime hasta)
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand();

                // Con CAST(... AS DATE) obligamos a SQL a mirar solo el día/mes/año e ignorar la hora
                cmd.CommandText = "SELECT * FROM Venta WHERE CAST(Ven_Fecha AS DATE) BETWEEN CAST(@FechaInicio AS DATE) AND CAST(@FechaFin AS DATE)";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                cmd.Parameters.AddWithValue("@FechaInicio", desde);
                cmd.Parameters.AddWithValue("@FechaFin", hasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        
        /*private string cadenaConexion = @"Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\OpticaG11.mdf;Integrated Security=True;User Instance=True";

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
        }*/

        public static void insertarVenta(Venta nuevaVenta)
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection nc = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha, Cli_DNI) VALUES(@Fecha, @Dni)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;
            cmd.Parameters.AddWithValue("@Fecha", nuevaVenta.ven_Fecha);
            cmd.Parameters.AddWithValue("@Dni", nuevaVenta.cli_dni);

            nc.Open();
            cmd.ExecuteNonQuery();
            nc.Close();
        }

        public static int obtenerUltimaVenta()
        {
            int ultimoNro = 0;
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection nc = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(Ven_Nro) FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;

            nc.Open();

            object resultado = cmd.ExecuteScalar();
            if (resultado != DBNull.Value)
            {
                ultimoNro = Convert.ToInt32(resultado);
            }

            nc.Close();
            return ultimoNro;
        }

        public static DataTable Listar_Ventas()
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection nc = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Ven_Nro as 'Nro. Venta', Ven_Fecha as 'Fecha', Cli_DNI as 'DNI Cliente' FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}