using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration.Assemblies;

namespace TecnoSmart
{
    class Conexion
    {
        SqlConnection cnn;
        string miConexion = "Data Source=(local);Initial Catalog=TecnoSmart;Integrated Security=True";

        public Conexion()
        {
        }

        #region
        public DataTable CargarComboProducto()
        {
            try
            {
                cnn = new SqlConnection(miConexion);
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Listar_Prodcuto", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataTable CargarComboReparacionProducto(int repPro)
        {
            try
            {
                cnn = new SqlConnection(miConexion);
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Listar_Reparacion_Pro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@pro_id", SqlDbType.VarChar, 255);
                cmd.Parameters["@pro_id"].Value = repPro;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
