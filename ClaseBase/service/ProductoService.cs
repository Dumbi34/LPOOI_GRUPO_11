using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;
namespace ClaseBase.service
{
    public class ProductoService
    {
        public static void insertarProducto(Producto nuevo)
        {  
            SqlConnection nc = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Producto(Prod_Codigo,Prod_Categoria,Prod_Descripcion, Prod_Precio) values(@Cod,@Cat,@Des,@Pre)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;

            cmd.Parameters.AddWithValue("@Cod",nuevo.Prod_Codigo);
            cmd.Parameters.AddWithValue("@Cat", nuevo.Prod_Categoria);
            cmd.Parameters.AddWithValue("@Des", nuevo.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@Pre", nuevo.Prod_Precio);

            nc.Open();
            cmd.ExecuteNonQuery();
            nc.Close();
        }
        public static bool codigoRegistrado(string code)
        {
            bool existe = false;
            SqlConnection nc = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Producto WHERE RTRIM(LTRIM(Prod_Codigo)) = RTRIM(LTRIM(@Cod))";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;

            cmd.Parameters.AddWithValue("@Cod", code.Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                existe = true;
            }

            return existe;
        }
        public static DataTable Listar_Productos(string ordenar)
        {
            SqlConnection nc = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ProductoListarOrden"; 
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Connection = nc;

            cmd.Parameters.AddWithValue("@OrdenarPor", ordenar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public static DataTable buscar_producto(string dato)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Codigo as 'Código', Prod_Categoria as 'Categoría', Prod_Descripcion as 'Descripción', Prod_Precio as 'Precio' FROM Producto WHERE Prod_Codigo LIKE @datobuscar";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@datobuscar", "%" + dato + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void EliminarProducto(Producto p)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ProductoEliminar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Prod_Codigo", p.Prod_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void ActualizarProducto(Producto p)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ProductoActualizar"; 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Prod_Codigo", p.Prod_Codigo);
            cmd.Parameters.AddWithValue("@Prod_Descripcion", p.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@Prod_Categoria", p.Prod_Categoria);
            cmd.Parameters.AddWithValue("@Prod_Precio", p.Prod_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
      