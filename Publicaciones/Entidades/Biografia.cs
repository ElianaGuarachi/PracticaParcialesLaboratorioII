using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                if (this.stock > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Biografia(string nombre):this(nombre,0)
        {

        }

        public Biografia(string nombre, int stock):this(nombre,stock,0)
        {

        }

        public Biografia(string nombre, int stock, float valor)
            :base(nombre,stock,valor)
        {

        }

        public static implicit operator Biografia(string nombre)
        {
            return new Biografia(nombre); ;
        }








    }
}
