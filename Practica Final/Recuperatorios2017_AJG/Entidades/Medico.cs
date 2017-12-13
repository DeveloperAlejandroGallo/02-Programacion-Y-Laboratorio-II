using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        #region Atributos
        Paciente pacienteActual;
        protected static Random tiempoAleatorio;
        #endregion

        #region Constructores

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            : base(nombre, apellido)
        {
            AtencionFinalizada += Medico_AtencionFinalizada;
        }



        #endregion

        #region Propiedades

        public virtual string EstaAtendiendoA
        {
            get
            {
                return pacienteActual.ToString();
            }
        }
            
        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }
        #endregion

        #region Metodos

        public abstract void Atender();

        public delegate void FinAtencionPaciente();
        public event FinAtencionPaciente AtencionFinalizada;

        public void FinalizarAtencion()
        {

            this.AtencionFinalizada();
            
        }

        private void Medico_AtencionFinalizada()
        {
            StreamWriter file = null;
            string archivo = "pacientes_atendidos.txt";
            try
            {
                if (File.Exists(archivo))
                    file = new StreamWriter(archivo, true);
                else
                    file = new StreamWriter(archivo);

                file.WriteLine(pacienteActual.ToString());
            }
            catch (IOException ex)
            {
                throw new IOException("Error al guardar en la ruta " + archivo, ex);
            }
            finally
            {
                file.Close();
                this.pacienteActual = null;
            }
        }

        #endregion

    }
}
