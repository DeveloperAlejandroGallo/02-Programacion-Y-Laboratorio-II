using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        #region Atributos
        float porcentajeInteres;

        #endregion

        #region Propiedades
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        #endregion

        #region Constructores

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
            : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        { }

        #endregion

        #region Metodos

        private float CalcularInteres()
        {
            return base.Monto + ((base.Monto * this.porcentajeInteres) / 100); 
        }

        

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double diasExtendidos = (nuevoVencimiento - base.Vencimiento).TotalDays;
            base.Vencimiento = nuevoVencimiento;

            for (int i = 0; i < diasExtendidos; i++)
                base.Monto += (base.Monto * 25)/100;


        }


        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}Interes: {1}\n", base.Mostrar(),this.Interes);

            return str.ToString();

        }






        #endregion





    }
}
