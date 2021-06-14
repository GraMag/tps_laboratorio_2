using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        private Tamanio tamanio;
        private int altura;
        private Imagen imagen;
        private int tapas;

        public Caja()
        {
            tamanio = new Tamanio(30,20);
            altura = 3;
            tapas = 2;
            imagen = null;
        }

        public Imagen Imagen 
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
            }
        }


    }
}
