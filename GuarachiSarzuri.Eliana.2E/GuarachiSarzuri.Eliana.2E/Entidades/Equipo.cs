using System;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int PE
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }

        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }

        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }


        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }


        public string Tipo
        {
            get
            {
                return this.GetType().Name;//this es la instancia
            }
        }

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);

            return sb.ToString();
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool auxBool = false;
            if (equipoA is not null && equipoB is not null)
            {
                if (equipoA.Equals(equipoB))
                {
                    auxBool = true;
                    equipoA.PJ++;
                    equipoB.PJ++;
                    int numA = equipoA.GetDificultad();
                    int numB = equipoB.GetDificultad();
                    if ( numA > numB)
                    {
                        equipoA.PG++;
                        equipoA.Puntuacion += 3;
                        equipoB.PP++;
                        
                    }
                    else if(numB > numA)
                    {
                        equipoB.PG++;
                        equipoB.Puntuacion += 3;
                        equipoA.PP++;
                    }
                    else
                    {
                        equipoA.PE++;
                        equipoB.PE++;
                        equipoA.Puntuacion += 1;
                        equipoB.Puntuacion += 1;
                    }
                }
            }
            return auxBool;
        }

        public abstract int GetDificultad();

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA is not null && equipoB is not null)
            {
                if(equipoA.nombre == equipoB.nombre && equipoA.Equals(equipoB))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

        public override bool Equals(object obj) 
        {
             return obj is not null && this.GetType() == obj.GetType(); //COMPARA LOS TIPOS
        }


    }
}
