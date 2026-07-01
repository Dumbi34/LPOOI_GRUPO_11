using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.service
{
    public class ClienteService
    {
        public bool ClienteNotNull(string apellido, string nombre, string dni, string direccion, string cuitOs, string nroCliente)
        {
            if (string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(dni)
                 || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(cuitOs) || string.IsNullOrEmpty(nroCliente))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable BuscarClientesCombinado(string apellido, string dni)
        {
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Cliente WHERE Cli_Apellido LIKE @ape AND Cli_DNI LIKE @dni";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ape", "%" + apellido + "%");
                cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertarCliente(string dni, string apellido, string nombre, string direccion, string cuitOS, string nroCarnet)
        {
            //string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Usuario\OneDrive\Documentos\GitHub\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Cliente (Cli_DNI, Cli_Apellido, Cli_Nombre, Cli_Direccion, OS_CUIT, Cli_NroCarnet) " +
                               "VALUES (@dni, @ape, @nom, @dir, @cuit, @carnet)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@ape", apellido);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@dir", direccion);
                cmd.Parameters.AddWithValue("@cuit", cuitOS);
                cmd.Parameters.AddWithValue("@carnet", nroCarnet);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(string dni)
        {
            //string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Usuario\OneDrive\Documentos\GitHub\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Cliente WHERE Cli_DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", dni);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarCliente(string dni, string apellido, string nombre, string direccion, string cuitOS, string nroCarnet)
        {
            //string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Cliente SET Cli_Apellido = @ape, Cli_Nombre = @nom, Cli_Direccion = @dir, " +
                               "OS_CUIT = @cuit, Cli_NroCarnet = @carnet WHERE Cli_DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@ape", apellido);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@dir", direccion);
                cmd.Parameters.AddWithValue("@cuit", cuitOS);
                cmd.Parameters.AddWithValue("@carnet", nroCarnet);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerClientesOrdenadosPorApellido()
        {
            //SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente ORDER BY Cli_Apellido ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_ClientesNombreCompleto()
        {
            //SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Cli_DNI, Cli_Apellido + ' ' + Cli_Nombre AS NombreCompleto FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarClientesDinamico(string textoBusqueda, string criterio, string orden)
        {
            // Usamos tu conexión universal que arreglamos antes
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                // 1. Decidimos en qué columna buscar
                string columnaFiltro = "Cli_Apellido"; // Por defecto
                if (criterio == "DNI") columnaFiltro = "Cli_DNI";
                else if (criterio == "Nombre") columnaFiltro = "Cli_Nombre";

                // 2. Decidimos cómo ordenar
                string direccionOrden = (orden == "Descendente") ? "DESC" : "ASC";

                // 3. Armamos la consulta SQL combinando todo
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Cliente WHERE " + columnaFiltro + " LIKE @Texto ORDER BY " + columnaFiltro + " " + direccionOrden;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                // Le agregamos los % para que busque coincidencias parciales (ej: si ponés "Flo", te trae "Flores")
                cmd.Parameters.AddWithValue("@Texto", "%" + textoBusqueda + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}