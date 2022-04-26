using System;
using System.Text;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if (this.stock > 0 && this.importe > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe):this(nombre,stock)
        {
            this.importe = importe;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public string ObtenerInformacion()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre.ToUpper()}");
            sb.AppendLine($"Stock: {this.stock}");
            sb.AppendLine($"Es color: {this.EsColor}");
            sb.AppendLine($"Valor: ${this.importe}");

            return sb.ToString();
        }

    }
}
