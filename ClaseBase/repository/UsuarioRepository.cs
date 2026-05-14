using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;
namespace ClaseBase.repository
{
    public class UsuarioRepository
    {
        public static bool UserExiste(string user, string psswd)
        {
            bool existe = false;
            SqlConnection lus = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario AND Usu_Contraseña = @password";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = lus;

            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@password", psswd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                existe = true;
            }

            return existe;
        }

        public static DataTable Listar_Roles()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static void InsertarUsuario(Usuario usu){
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_nombreUsuario,Usu_contraseña,Usu_ApellidoNombre,Rol_Codigo,Usu_Correo) values(@User,@pass,@nombre,@rol,@correo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@User", usu.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usu.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nombre", usu.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usu.Rol_codigo);
            cmd.Parameters.AddWithValue("@correo", usu.Usu_Correo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();  
        }
    }
}
