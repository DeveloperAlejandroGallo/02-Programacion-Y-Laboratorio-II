using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public abstract class Base
    {
        public delegate void DelegadoBase(List<Base> list);
        public static event DelegadoBase EventoBase;

        #region Atributos
        static int subversion;
        static int version;

        #endregion

        #region Constructores
        static Base()
        {
            version = 1;
            subversion = 0;

            
        }

        public Base(int version, int subversion)
        {
            Version = version;
            Base.subversion = subversion;
        }

        #endregion

        public int Version
        {
            get
            {
                return version;
            }
            set
            {
                Int32.TryParse(value.ToString(), out version);
            }
        }

        public abstract string VersionFull
        {
            get;
        }    

        public virtual string MostrarVersion()
        {
            return string.Format("{0}.{1}", Base.version,Base.subversion);
        }

        public static string operator ~(Base b)
        {
            int punto = b.MostrarVersion().IndexOf('.');
            return string.Format("{0}.{1}", b.MostrarVersion().Substring(punto), b.MostrarVersion().Substring(0, punto));
        }

        public override int GetHashCode()
        {
            return version + subversion;
        }


        //generics
        public static bool GuardarDatos<T>(T dato)
            where T : Base
        {
            SqlConnection connString = new SqlConnection("Data Source=DRAGONAUTA\\SQLEXPRESS;Initial Catalog=final-20171207;Integrated Security=True");
            SqlCommand command =  new SqlCommand();
            try
            { 
                command.Connection = connString;
                command.CommandType = System.Data.CommandType.Text;
                connString.Open();
                if(dato is DerivadaUno)
                    command.CommandText = string.Format("Insert into Datos values({0},{1},{2},{3}", version, subversion, dato.VersionFull.Substring(dato.VersionFull.LastIndexOf('.')), 1);
                else
                    command.CommandText = string.Format("Insert into Datos values({0},{1},{2},{3}", version, subversion, 0, 2);

                command.ExecuteNonQuery();
            }
            catch(Exception )
            {
                return false;
            }
            finally
            {
                connString.Close();
            }

            return true;
        }

        public static Queue<T> LeerDatos<T>()
            where T: Base, new()
        {
            Queue<T> datos = new Queue<T>();
            Queue<Base> datosBase = new Queue<Base>();
            SqlConnection connString = new SqlConnection("Data Source=DRAGONAUTA\\SQLEXPRESS;Initial Catalog=final-20171207;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = connString;
                command.CommandType = System.Data.CommandType.Text;
                connString.Open();
                command.CommandText = "Select * from Datos";
                SqlDataReader oDr = command.ExecuteReader();

                while (oDr.Read())
                {
                    if(oDr["derivada"].ToString() == "1")
                    {
                        
                        datosBase.Enqueue(new DerivadaUno(Convert.ToInt32(oDr["version"]), Convert.ToInt32(oDr["subversion"]), Convert.ToInt32(oDr["revision"])));
                    }
                    else
                    {
                        datosBase.Enqueue(new DerivadaDos());
                    }

                }

                datos = (Queue<T>)Convert.ChangeType(datosBase, typeof(Queue<T>));


            }
            catch
            {
                return datos;
            }

            return datos;
        }


        public static void EjecutarEvento(List<Base> list)
        {
            foreach(Base b in list)
            {
                if (b is DerivadaUno)
                    Base.GuardarDatos<DerivadaUno>((DerivadaUno)b);
                else
                    Base.GuardarDatos<DerivadaDos>((DerivadaDos)b);
            }
            EventoBase(list);

        }


    }
}
