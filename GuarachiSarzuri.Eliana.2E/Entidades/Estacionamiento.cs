using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e.nombre);
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {

            if (e is not null && v is not null)
            {
                foreach (Vehiculo item in e.vehiculos) //NUll XQ
                {
                    if (item == v)
                    {
                        return true;
                    }
                }        
            }

            return false;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            
                if (estacionamiento is not null && vehiculo is not null && estacionamiento == vehiculo)
                {
                    return vehiculo.ImprimirTicket();
                }
                else
                {
                    return "El vehiculo no es parte del estacionamiento";
                }
   
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento is not null && vehiculo is not null)
            {
                if (estacionamiento != vehiculo && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }
            return estacionamiento;
        }



    }
}
