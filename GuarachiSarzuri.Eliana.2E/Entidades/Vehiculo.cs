using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this.patente = value;
                }  
            }
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.patente = patente;
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vehiculo: {patente}");
            sb.AppendLine($"Fecha de ingreso: {ingreso}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", this.patente);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente == v2.patente && v1.Equals(v2))
            {
                return true;
            }
            return false;
        }


    }
}
