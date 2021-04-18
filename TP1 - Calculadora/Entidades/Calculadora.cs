using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza las operaciones matematicas basicas
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char.TryParse(operador, out char charOperador);
            switch (ValidarOperador(charOperador))
            {
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }

        /// <summary>
        /// Valida que se haya ingresado un operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si no hay operador se lo tomara como suma</returns>
        private static string ValidarOperador(char operador)
        {
            if(operador.Equals('-') || operador.Equals('/') || operador.Equals('*'))
            {
                return operador.ToString();
            }
            return "+";
        }
    }
}
