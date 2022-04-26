using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre):this(nombre,false)
        {

        }

        public EquipoFutbol (string nombre, bool jugadoresEstrellas):base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }

        public override int GetDificultad()
        {
            Random ramdon = new Random();
            int numero = ramdon.Next(7, 10);
            if (this.jugadoresEstrellas == true)
            {
                numero *= 2;
            }
            return numero;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Futbol -");
            sb.Append(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}
