using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClaseBase.model;
namespace ClaseBase.service
{
    public class VentaDetalleService
    {
        public static void insertarVentaDetalle(VentaDetalle nuevoDetalle)
        {
            //SqlConnection nc = new SqlConnection(ClaseBase.Properties.Settings.Default.OpticaG11ConnectionString);
            string cadenaConexion = ClaseBase.service.Conexion.ObtenerCadena();
            SqlConnection nc = new SqlConnection(cadenaConexion);


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) VALUES(@VenNro, @ProdCod, @Precio, @Cant, @Total)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = nc;

            cmd.Parameters.AddWithValue("@VenNro", nuevoDetalle.ven_num);
            cmd.Parameters.AddWithValue("@ProdCod", nuevoDetalle.prod_codigo);
            cmd.Parameters.AddWithValue("@Precio", nuevoDetalle.det_precio);
            cmd.Parameters.AddWithValue("@Cant", nuevoDetalle.det_cantidad);
            cmd.Parameters.AddWithValue("@Total", nuevoDetalle.det_total);

            nc.Open();
            cmd.ExecuteNonQuery();
            nc.Close(); 
        }
    }
}
