using System;
using System.Collections.Generic;
using System.Text;

namespace GuarachiSarzuri.Eli._2E
{
    

    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }

        protected abstract int Tamanio { get; }
        

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int tam = int.MinValue;
            Aplicacion aux = null;
            if (listaApp is not null)
            {
                foreach (Aplicacion item in listaApp)
                {
                    if (item.tamanioMb > tam)
                    {
                        aux = item;
                        tam = item.tamanioMb;
                    }
                }
            }
            return aux;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"SistemaOperativo: {sistemaOperativo}");
            sb.AppendLine($"Tamanio: {tamanioMb}");

            return sb.ToString();
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            bool auxBoleano = false;
            if (listaApp is not null && app is not null)
            {
                foreach (Aplicacion aplicacion in listaApp)
                {
                    if (aplicacion.nombre == app.nombre)
                    {
                        auxBoleano = true;
                        break;
                    }
                }
            }
            return auxBoleano;
        }


        public static bool operator +(List <Aplicacion> listaApp, Aplicacion app)
        {
            bool auxBoleano = false;
            if (listaApp is not null && app is not null && listaApp != app)
            {
                listaApp.Add(app);
                auxBoleano = true;
            }
            return auxBoleano;
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }
}
