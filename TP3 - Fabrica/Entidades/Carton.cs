using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carton
    {
        private Tamanio tamanio;

        public Carton()
        {
            tamanio = new Tamanio(70, 100);
        }
    }
}
