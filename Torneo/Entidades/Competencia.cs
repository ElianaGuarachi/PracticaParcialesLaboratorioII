using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        public int CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                cantidadCompetidores = value;
            }
        }

        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        private Competencia(string nombre):this(nombre,5)
        {
            
        }

        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia: {torneo.nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.equipos.Count}");
            //VER
            return sb.ToString();
        }

        public static implicit operator Competencia(string nombre)
        {
            //Competencia competencia = new Competencia(nombre);
            
            return new Competencia(nombre);
        }

        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            if (torneo is not null && equipo is not null)
            {
                foreach (Equipo item in torneo.equipos)
                {
                    if (item == equipo) //Usa una sobrecarga
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }


        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if (torneo is not null && equipo is not null)
            {
                if (torneo != equipo && torneo.cantidadCompetidores > torneo.equipos.Count)
                {
                    torneo.Equipos.Add(equipo);
                }
            }
            return torneo;
        }

    }
}
