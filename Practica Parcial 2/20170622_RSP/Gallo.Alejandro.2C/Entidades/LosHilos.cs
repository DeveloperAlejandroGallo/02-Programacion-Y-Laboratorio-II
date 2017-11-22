using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;
using System.Threading;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        static string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"bitacora.txt";

        public delegate void delegaHilos(string mensaje);
        public event delegaHilos AvisoFin;


        static int id;
        List<InfoHilo> misHilos;
      
        public LosHilos()
        {
            LosHilos.id = 0;
            misHilos = new List<InfoHilo>();
        }

        #region Propiedades

        public string Bitacora
        {
            get
            {
                return LeerTxt();
            }
            set
            {
                GuardarEntxt(value);
            }
        }
        #endregion
        
        static LosHilos AgregarHilo(LosHilos hilos)
        {
            ++LosHilos.id;
            IRespuesta<int> callback = null;
            //como le mando el callback?
            InfoHilo nuevoHilo = new InfoHilo(LosHilos.id, null);
            hilos.misHilos.Add(nuevoHilo);

            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            Thread.CurrentThread.Abort();
            string msg = string.Format("Terminó el hilo {0}.", id);
            this.Bitacora = msg;//Guardo en el archivo
            this.AvisoFin(msg);//Lanzo el evento
        }


        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    AgregarHilo(hilos);
                }
            }
            else
                throw new CantidadInvalidaException();


            return hilos;
        }


        #region Archivos
        private void GuardarEntxt(string dato)
        {
            StreamWriter file = null;
            try
            {
                if (File.Exists(archivo))
                    file = new StreamWriter(archivo, true);
                else
                    file = new StreamWriter(archivo);

                file.WriteLine(dato);
            }
            catch (IOException ex)
            {
                throw new IOException("Error al guardar en la ruta " + archivo, ex);
            }
            finally
            {
                file.Close();
            }


        }


        private string LeerTxt()
        {
            StreamReader file = null;
            string data = "";
            try
            {
                if (File.Exists(archivo))
                    data = file.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la ruta " + archivo, ex);
            }
            finally
            {
                file.Close();
            }
            return data;
        } 
        #endregion

    }
}
