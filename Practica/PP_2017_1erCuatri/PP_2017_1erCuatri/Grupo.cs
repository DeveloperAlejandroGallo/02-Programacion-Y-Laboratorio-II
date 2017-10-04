using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_2017_1erCuatri
{
    public class Grupo
    {


        #region Atributos
        
        List<Mascota> manada;
        string nomnbre;
        static TipoManada tipo;

        #endregion

        #region Propiedades
        
        public TipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }

        #endregion

        #region Constructores

        static Grupo()
        {
            Grupo.tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) 
            : this()
        {
            this.nomnbre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }
        
        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Grupo unGrupo, Mascota unaMascota)
        {
            foreach(Mascota otraMascota in unGrupo.manada)
            {
                if (unaMascota == otraMascota)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Grupo unGrupo, Mascota unaMascota)
        {
            return !(unGrupo == unaMascota);
        }

        public static Grupo operator +(Grupo unGrupo, Mascota unaMascota)
        {
            if (unGrupo != unaMascota)
                unGrupo.manada.Add(unaMascota);

            return unGrupo;
        }
        public static Grupo operator -(Grupo unGrupo, Mascota unaMascota)
        {
            if (unGrupo == unaMascota)
                unGrupo.manada.Remove(unaMascota);

            return unGrupo;
        }

        public static implicit operator string(Grupo unGrupo)
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("**{0}**\n", unGrupo.nomnbre);
            str.AppendLine("Integrantes:");
            
            foreach(Mascota mascota in unGrupo.manada)
            {
                str.AppendLine(mascota.ToString());
            }

            return str.ToString();
        }


        #endregion
    }
}
