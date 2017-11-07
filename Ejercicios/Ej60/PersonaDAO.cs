using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Ej60
{
    public class PersonaDAO
    {
        static SqlConnection conexion; 
        static SqlCommand ejecutarSQL;

        public PersonaDAO()
        {
            conexion = new SqlConnection("Data Source=DRAGONAUTA\\SQLEXPRESS;Initial Catalog=LaboratorioII;Integrated Security=True");
            ejecutarSQL = new SqlCommand();
            ejecutarSQL.CommandType = CommandType.Text;
            ejecutarSQL.Connection = conexion;

        }

        public bool Guardar(Persona p)
        {
            return EjecutoNonQuery("Insert into Persona values('"
                    + p.Nombre + "','" + p.Apellido + "')");
        }

        public bool Modificar(int id, Persona p)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Update Persona set nombre = '{0}', apellido = '{1}' ",p.Nombre, p.Apellido);
            str.AppendFormat("Where id = {0}", id);
            return EjecutoNonQuery(str.ToString());
        }

        public bool Borrar(int id)
        {
            return EjecutoNonQuery("Delete from Persona where id = "+id);
        }

        public List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            // LE PASO LA INSTRUCCION SQL
            ejecutarSQL.CommandText = "SELECT ID,Nombre,Apellido FROM Persona";

            // ABRO LA CONEXION A LA BD
            conexion.Open();

            // EJECUTO EL COMMAND                 
            SqlDataReader oDr = ejecutarSQL.ExecuteReader();

            // MIENTRAS TENGA REGISTROS...
            while (oDr.Read())
            {
                // ACCEDO POR NOMBRE O POR INDICE
                personas.Add(new Persona( oDr["Nombre"].ToString(), oDr["Apellido"].ToString() ));
            }
            
            return personas;
                 
        }

        public Persona LeerPorID(int id)
        {
            Persona personaBuscada=null;

            // LE PASO LA INSTRUCCION SQL
            ejecutarSQL.CommandText = "SELECT ID,Nombre,Apellido FROM Persona where ID = " + id;

            // ABRO LA CONEXION A LA BD
            conexion.Open();

            // EJECUTO EL COMMAND                 
            SqlDataReader oDr = ejecutarSQL.ExecuteReader();

            // Si hay un registro guardo el primero.
            if (oDr.Read())
            {
                // ACCEDO POR NOMBRE O POR INDICE
                personaBuscada = new Persona(oDr["Nombre"].ToString(), oDr["Apellido"].ToString());
            }
            else
            {
                throw new Exception("Persona con id " + id + ", no encontrada.");
            }

            return personaBuscada;
            
        }


        public bool EjecutoNonQuery(string query)
        {
            try
            { 
                ejecutarSQL.CommandText = query;
                conexion.Open();
                ejecutarSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

    }
}
