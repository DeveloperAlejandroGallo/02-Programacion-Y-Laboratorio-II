using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        #region Atributos

        protected float monto;
        protected DateTime vencimiento;

        #endregion


        #region Propiedades
        public float Monto
        {
            get
            {
                return this.monto;
            }
            set
            {
                this.monto = value;
            }
        }


        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now.Date;
                }
                
            }
        }
        
        #endregion

        #region Constructores
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.Monto = monto;
            this.Vencimiento = vencimiento;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Compara las fechas de 2 prestamos.
        /// </summary>
        /// <param name="unPrestamo"></param>
        /// <param name="otroPrestamo"></param>
        /// <returns>
        /// 1 - si unPrestamos > a otroPrestamo
        /// 0 - si tienen misma fecha
        ///-1 - si unPrestamos < a otroPrestamo</returns>
        public static int OrdenarPorFecha(Prestamo unPrestamo, Prestamo otroPrestamo) //lleva public?
        {
            int ret = 0;

            if (unPrestamo.Vencimiento > otroPrestamo.Vencimiento)
                ret = 1;
            else
                if (unPrestamo.Vencimiento < otroPrestamo.Vencimiento)
                    ret = -1;

            return ret;
        }

        public abstract void ExtenderPlazo(DateTime plazo);

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("PRESTAMO PERSONAL");
            str.AppendFormat("Monto: {0}\n",this.Monto);
            str.AppendFormat("Vencimiento: {0}\n", this.Vencimiento);

            return str.ToString();

        }








        
        #endregion


    }
}
