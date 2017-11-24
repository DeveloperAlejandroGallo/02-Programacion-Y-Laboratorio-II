using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace EntidadesHechas
{
    public static class PaqueteDAO
    {
        static SqlConnection conexion;
        static SqlCommand ejecutarSQL;

        static PaqueteDAO()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
            ejecutarSQL = new SqlCommand();
            ejecutarSQL.CommandType = CommandType.Text;
            ejecutarSQL.Connection = conexion;

        }

        public static bool InsertarPaquete(Paquete p)
        {
            try
            {
                StringBuilder sql= new StringBuilder();
                sql.AppendFormat("Insert into Paquetes values('{0}','{1}','Gallo, Alejandro')"
                    ,p.DireccionEntrega.ToString(),p.TrackingID.ToString());

                ejecutarSQL.CommandText = sql.ToString();
                conexion.Open();
                ejecutarSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar en la tabla Persona.", e) ;
            }
            finally
            {
                conexion.Close();
            }
            return true;
            
        }
    }
}
