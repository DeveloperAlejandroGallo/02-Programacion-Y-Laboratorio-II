using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        #region Atributos
        PeriodicidadDePagos PeriodicidadDePagos;

        #endregion

        #region Propiedades
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }


        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.PeriodicidadDePagos;
            }
        }

        #endregion

        #region Constructores

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos PeriodicidadDePagos)
            : base(monto, vencimiento)
        {
            this.PeriodicidadDePagos = PeriodicidadDePagos;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos PeriodicidadDePagos)
            : this(prestamo.Monto, prestamo.Vencimiento, PeriodicidadDePagos)
        { }

        #endregion

        #region Metodos
        /// <summary>
        /// Calcula el interes en base al monto y la periodicidad
        /// </summary>
        /// <returns></returns>
        private float CalcularInteres()
        {
            return base.Monto + ((base.Monto * (int)this.Periodicidad) / 100);
        }
        /// <summary>
        /// Extiende el plazo a un nuevo vencimiento, calculando el interes con 2.5 por cada dia.
        /// </summary>
        /// <param name="nuevoVencimiento"></param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double diasExtendidos = (nuevoVencimiento - base.Vencimiento).TotalDays;
            base.Vencimiento = nuevoVencimiento;

            for (int i = 0; i < diasExtendidos; i++)
                base.Monto += 2.5f;
        }

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}Interes: {1}\n", base.Mostrar(), this.Interes);

            return str.ToString();
        }


        #endregion





    }
}
