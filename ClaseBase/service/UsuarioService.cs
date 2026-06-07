using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;
namespace ClaseBase.service
{
    public class UsuarioService
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

        public static void InsertarUsuario(string nombreU, string contraU, string nyaU, int rol_id, string correo)
        {
            Usuario nu = new Usuario(nombreU, contraU, nyaU, rol_id, correo);
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_nombreUsuario,Usu_contraseña,Usu_ApellidoNombre,Rol_Codigo,Usu_Correo) values(@User,@pass,@nombre,@rol,@correo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@User", nu.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", nu.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nombre", nu.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", nu.Rol_codigo);
            cmd.Parameters.AddWithValue("@correo", nu.Usu_Correo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable Listar_Usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
                             SELECT  u.Usu_ID,  u.Rol_Codigo,r.Rol_Descripcion,  u.Usu_NombreUsuario,  u.Usu_Contraseña, u.Usu_ApellidoNombre,  u.Usu_Correo                         
                             FROM Usuario u
                             INNER JOIN Roles r ON u.Rol_Codigo = r.Rol_Codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscar_usuario(string dato)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "R.Rol_Descripcion as 'Rol', ";
            cmd.CommandText += "U.Usu_NombreUsuario as 'user', U.Usu_Contraseña as 'contra', ";
            cmd.CommandText += "U.Usu_ApellidoNombre as 'nombre', U.Usu_Correo as 'email', ";
            cmd.CommandText += "U.Rol_Codigo ";
            cmd.CommandText += "FROM Usuario as U ";
            cmd.CommandText += "LEFT JOIN Roles as R ON (R.Rol_Codigo = U.Rol_Codigo) ";
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "U.Usu_NombreUsuario LIKE @datobuscar";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("datobuscar", "%" + dato + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void EliminarUsuario(string nombreUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_NombreUsuario = @user";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", nombreUsuario);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void ModificarUsuario(string nombreU, string contraU, string nyaU, int rol_id, string correo)
        {
            Usuario usu = new Usuario(nombreU, contraU, nyaU, rol_id, correo);
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Usuario SET Usu_contraseña = @pass, Usu_ApellidoNombre = @nombre, Rol_Codigo = @rol, Usu_Correo = @correo WHERE Usu_nombreUsuario = @User";
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
        public static int IdRolUsuario(string nombreUsuario)
        {
            int rol_id = 0;

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Rol_Codigo FROM Usuario WHERE Usu_nombreUsuario = @user";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", nombreUsuario);

            cnn.Open();

            object resultado = cmd.ExecuteScalar();

            if (resultado != null)
            {
                rol_id = Convert.ToInt32(resultado);
            }

            cnn.Close();

            return rol_id;
        }
        public static bool EsUltimoAdministrador(string nombreUsuario)
        {
            bool esUltimoAdmin = false;

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE Rol_Codigo = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();

            int cantidadAdministradores = Convert.ToInt32(cmd.ExecuteScalar());

            cnn.Close();
            if (IdRolUsuario(nombreUsuario) == 1 && cantidadAdministradores == 1)
            {
                esUltimoAdmin = true;
            }

            return esUltimoAdmin;
        }
        public static bool nombreUsuarioExiste(string user)
        {
            bool existe = false;
            SqlConnection lus = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = lus;

            cmd.Parameters.AddWithValue("@usuario", user);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                existe = true;
            }

            return existe;
        }
        public static string obtenerCorreoUsuario(string user)
        {
            string correo = "";
            SqlConnection lus = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_Correo FROM Usuario WHERE Usu_NombreUsuario = @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = lus;

            cmd.Parameters.AddWithValue("@usuario", user);

            lus.Open();
            object resultado = cmd.ExecuteScalar();
            if (resultado != null && resultado != DBNull.Value)
            {
                correo = resultado.ToString();
            }

            lus.Close();

            return correo;
        }
        public static bool actualizarContraseña(string usuario, string nuevaPass)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Usuario SET Usu_Contraseña = @Pass WHERE Usu_NombreUsuario = @User";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                cmd.Parameters.AddWithValue("@Pass", nuevaPass);
                cmd.Parameters.AddWithValue("@User", usuario);

                conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                conexion.Close();

                return filasAfectadas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
