using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada):base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            :this(patente, cilindrada)
        {
            
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
            :this(patente,cilindrada)
        {

        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Valor Hora: {valorHora}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(this.GetType() == obj.GetType())
            {
                return true;
            }
            return false;
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Costo de la estadia: ");
            
            return sb.ToString();
        }

    }
}
