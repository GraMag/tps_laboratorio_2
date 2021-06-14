using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;
namespace Entidades
{
    public class Rompecabezas
    {
        private ECantPiezas cantidadDePiezas;
        private string marca;
        private string modelo;
        private int anio;
        private Imagen imagen;
        private Tamanio tamanio;
        private Caja caja; 

        public Rompecabezas()
        {
            anio = DateTime.Today.Year;
            modelo = GeneradorDeModelo();
            tamanio = AjustarTamanio(cantidadDePiezas);
            caja = null;
        }

        public Rompecabezas(ECantPiezas cantidadDePiezas, string marca, Imagen imagen)
            : this()
        {
            this.cantidadDePiezas = cantidadDePiezas;
            this.imagen = imagen;
            this.marca = marca;
        }

        public Caja Caja
        {
            get
            {
                return caja;
            }
            set
            {
                caja = value;
            }
        }
        private static string GeneradorDeModelo()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            do
            {
                sb.Append(random.Next(0, 9));
            } while (sb.Length < 6);
            return sb.ToString();
        }

        private static Tamanio AjustarTamanio(ECantPiezas cantPiezas)
        {
            switch (cantPiezas)
            {
                case ECantPiezas.PIEZAS_500:
                    return new Tamanio(48, 35);
                case ECantPiezas.PIEZAS_1000:
                    return new Tamanio(70, 50);
                default:
                    return new Tamanio(93, 70);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {marca.ToUpper()}");
            sb.Append(imagen.ToString());
            sb.AppendLine($"Año: {anio}");
            sb.AppendLine($"Cantidad de piezas: {cantidadDePiezas.ToString().ToLower()}");
            sb.AppendLine(tamanio.ToString(imagen.EsHorizontal));
            sb.AppendLine($"Modelo {modelo}");

            return sb.ToString();
        }

        public static bool operator ==(Rompecabezas r1, Rompecabezas r2)
        {
            return r1.cantidadDePiezas == r2.cantidadDePiezas && r1.modelo == r2.modelo;
        }
        public static bool operator !=(Rompecabezas r1, Rompecabezas r2)
        {
            return !(r1 == r2);
        }
    }
}
