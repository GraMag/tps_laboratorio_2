using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;

namespace Entidades
{
    public class Tamanio
    {
        int largo;
        int ancho;

        public Tamanio(int ancho, int largo )
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public string ToString(bool horientacion)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Medidas: ");
            if (horientacion)
            {
                sb.Append($"{ancho}x{largo}cm.");
            } else
            {
                sb.Append($"{largo}x{ancho}cm.");
            }

            return sb.ToString();
        }
    }
}
