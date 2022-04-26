using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga
        {
            NBA, Euroleague,ACB
        }

        private ELiga liga;

        public EquipoBasket(string nombre):this(nombre, ELiga.NBA)
        {
            
        }

        public EquipoBasket(string nombre, ELiga liga):base(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random random = new Random();
            int numero;
            if (this.liga == ELiga.NBA) //SWITCH
            {
                numero = random.Next(8, 10);
            }
            else if (this.liga == ELiga.ACB)
            {
                numero = random.Next(1, 7);
            }
            else
            {
                numero = random.Next(5, 10);
            }
            return numero;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basket - ");
            sb.Append(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }



    }
}
