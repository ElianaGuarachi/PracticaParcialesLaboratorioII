using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            :this(patente, color)
        {

        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Valor Hora: {valorHora}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ImprimirTicket()
        {
             
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Costo estadia: {valorHora}");
            return "";
        }

    }
}
