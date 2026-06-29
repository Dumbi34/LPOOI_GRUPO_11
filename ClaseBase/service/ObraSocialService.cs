using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;
namespace ClaseBase.service
{
    public class ObraSocialService
    {
        public bool ObraSocialNotNull(string cuit, string razonsocial, string direccion, string telefono)
        {
            if (string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(razonsocial) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono))
            {
                return false;
            }
            return true;
        }
        public static DataTable Listado_OS()
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public static DataTable Listado_OSclientes(string cuit)
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ViewClienteObraSocial WHERE OS_CUIT = @cuit";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public static int Cantidad_ClientesPorObraSocial(string cuit)
        {
            int cant;
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "OSclientes";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            cmd.Parameters.Add("@cant", SqlDbType.Int);
            cmd.Parameters["@cant"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            cant = (int)cmd.Parameters["@cant"].Value;

            return cant;
        }
    }
}
