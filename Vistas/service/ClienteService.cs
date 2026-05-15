using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Vistas.Service
{
    class ClienteService
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
            
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mauro\Documents\LPOO\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

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
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mauro\Documents\LPOO\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

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
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mauro\Documents\LPOO\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

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
            string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mauro\Documents\LPOO\LPOOI_GRUPO_11\ClaseBase\OpticaG11.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

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


    } 
} 