using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Imagen
    {
        private string titulo;
        private string autor;
        private string tematica;
        private bool esHorizontal;


        public Imagen(string titulo, string tematica)
        {
            this.titulo = titulo;
            this.tematica = tematica;
            esHorizontal = true;
        }

        public Imagen(string titulo, string autor, string tematica)
            :this(titulo, tematica)
        {
            Autor = autor;
        }

        public Imagen(string titulo, string autor, string tematica, bool esHorizontal)
            :this(titulo, autor, tematica)
        {
            this.esHorizontal = esHorizontal;
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = String.IsNullOrEmpty(value) ? null : value;
            }
        }

        public bool EsHorizontal
        {
            get
            {
                return esHorizontal;
            }
        }

        public static Imagen SeleccionarImagen(string titulo)
        {
            
            switch (titulo)
            {
                case "Kume and Hobsyllwin":
                    return new Imagen("Kume and Hobsyllwin", "Ciruelo", "Fantasía");
                case "El Grito":
                    return new Imagen("El Grito", "Munch", "Arte", false);
                case "Gatitos":
                    return new Imagen("Gatitos", "Animales");
                case "El castillo de Neuschwanstein":
                    return new Imagen("El castillo de Neuschwanstein", "Paisajes");
                case "Casa Batllo":
                    return new Imagen("Casa Batllo", "Gaudi", "Edificios", false);
                case "Azul y Oro":
                    return new Imagen("Azul y Oro", "Deportes");
                default:
                    return null;
            }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titulo: {titulo}");
            if (!String.IsNullOrWhiteSpace(autor))
            {
                sb.AppendLine($"Autor: {autor}");
            }
            sb.AppendLine($"Tematica: {tematica}");
            
            return sb.ToString();

        }
    }
}
