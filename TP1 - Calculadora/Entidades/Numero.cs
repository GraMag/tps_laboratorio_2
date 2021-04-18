using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this()
        {
            this.numero = numero;     
        }

        public Numero(string strNumero) : this()
        {
            {
                this.SetNumero = strNumero;
            }
        }

        public string SetNumero 
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Numero en decimal. En caso de no ser posible devuelve el mensaj "Valor invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double numDecimal = 0;
                int numBin = binario.Length - 1;
               
                for (int i = numBin; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        numDecimal += Math.Pow(2, numBin - i);
                    }
                }
                return numDecimal.ToString();
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Numero en binario. En caso de no ser posible devuelve el mensaj "Valor invalido"</returns>
        public static string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);
            if (numero >= 1)
            {
                StringBuilder numeroBinario = new StringBuilder();     
                while (numero > 1)
                {
                    numeroBinario.Insert(0, (int)numero % 2);
                    numero = (int)numero / 2;
                }
                numeroBinario.Insert(0, "1");
                return numeroBinario.ToString();
            }
            return "0";
        }

        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Numero en binario. En caso de no ser posible devuelve el mensaj "Valor invalido"</returns>
        public static string DecimalBinario(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero) || !double.TryParse(numero, out double esNumero))
            {
                return "Valor invalido";
            }
            else
            {
                return DecimalBinario(esNumero);
            }
        }

        /// <summary>
        /// Valida si el numero es un binario valido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Devuelve:
        /// true si binario se compone de 1 y/o 0, de lo contrario, false </returns>
        private static bool EsBinario(string binario)
        {
            foreach (char bin in binario)
            {
                if(bin != '0' && bin != '1')
                {
                    return false;
                }
            }          
            return true;
        }

        /// <summary>   
        /// Resta 2 atributos Numero.numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Resultado de la resta</returns>
        public static double operator - (Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Suma 2 atributos Numero.numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Resultado de la suma</returns>
        public static double operator + (Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Multiplica 2 atributos Numero.numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Resultado de la multiplicacion</returns>
        public static double operator * (Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide 2 atributos Numero.numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Resultado de la division En caso de que el divisor sea 0 se devuelve double.MinValue</returns>
        public static double operator / (Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Valida que dato ingresado sea un numero de lo contrario devolvera 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Devuelve
        ///     el numero ingresado. En caso de que no sea un numero valido, este será 0 </returns>
        private double ValidarNumero(string strNumero)
        {
            if (strNumero.Contains("."))
            {
                strNumero = strNumero.Replace('.', ',');
            }
            double.TryParse(strNumero, out double num);

            return num;
        }
    }
}
