using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        
            
        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float ganancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.Append(Environment.NewLine);
            sb.AppendLine("------------------------------");
            foreach (Publicacion item in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION:");
                sb.Append(Environment.NewLine);
                sb.AppendLine(item.ObtenerInformacion());
                ganancia += item.Importe;
                sb.AppendLine("------------------------------");

            }
            sb.AppendLine($"GANANCIA TOTAL: ${ganancia}");
            return sb.ToString();
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }

    }
}
