using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivos
    {
        private readonly string path;

        public Archivos(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Guarda textos en un archivo
        /// </summary>
        /// <param name="texto"></param>
        public void Guardar(string texto)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                writer.WriteLine($"Ultima modificacion: {DateTime.Now}");
                writer.WriteLine(texto);
            }
        }

        /// <summary>
        /// Lee archivos de texto
        /// </summary>
        /// <returns>Texto contenido en un archivo de texto.</returns>
        public string Leer()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
