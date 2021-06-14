using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;
namespace Entidades
{
    public class Inventario
    {
        Stack<Carton> cartones;
        Stack<Caja> cajas;
        List<Imagen> galeria;
        Stack<Caja> cajasImpresas;
        List<Rompecabezas> puzzleTerminado;
       // List<Rompecabezas> puzzleTerminado;

        public Inventario()
        {
            cartones = new Stack<Carton>();
            cajas = new Stack<Caja>();
            cajasImpresas = new Stack<Caja>();
            galeria = new List<Imagen>();
            puzzleTerminado = new List<Rompecabezas>();
            
        }

        public int Carton
        {
            get
            {
                return cartones.Count();
            }
        }

        public List<Rompecabezas> PuzzleTerminado 
        {
            get
            {
                return puzzleTerminado;
            }

            set
            {
                puzzleTerminado = value;
            }
        }

        public Stack<Caja> Cajas
        {
            get
            {
                return cajas;
            }

            set
            {
                cajas = value;
            }
        }

        public Stack<Caja> CajasImpresas
        {
            get
            {
                return cajasImpresas;
            }
            set
            {
                cajasImpresas = value;
            }
        }
        public int QuitarCarton(int cantidad, ECantPiezas eCantPiezas)
        {
           
            switch (eCantPiezas)
            {
                case ECantPiezas.PIEZAS_500:
                    while(cantidad % 4 != 0)
                    {
                        cantidad--;
                    }
                    for (int i = 0; i < cantidad / 4; i++)
                    {
                        cartones.Pop();
                    }
                    break;
                case ECantPiezas.PIEZAS_1000:
                    if (cantidad % 2 != 0 && cantidad > 0)
                    {
                        cantidad--;
                    }
                    for (int i = 0; i < cantidad / 2; i++)
                    {
                        cartones.Pop();
                    }
                    break;
                default:
                    for (int i = 0; i < cantidad; i++)
                    {
                        cartones.Pop();
                    }
                    break;
                }
            return cantidad;
        }

        /// <summary>
        /// Quita cartones de la pila
        /// </summary>
        /// <param name="cantidad">Cantidad de cartones que se eliminaran</param>
        /// <returns>TRUE si se sacaron cartones, FALSE si no</returns>
        public bool QuitarCarton(int cantidad)
        {
            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cartones.Pop();
                }
                return true;
            }
            catch
            {

            }
            return false;
        }

        /// <summary>
        /// Agrega carton a la pila
        /// </summary>
        /// <param name="cantidad">Cantidad de cartones</param>
        public bool AgregarCarton(int cantidad)
        {
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cartones.Push(new Carton());
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            int cantPuzzles = puzzleTerminado.Count;
            int total = 1;
            List<Rompecabezas> miniLista = new List<Rompecabezas>();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("====== STOCK =====");
            sb.AppendLine($"Cartón: {cartones.Count}");
            sb.AppendLine($"Cajas vacias: {cajas.Count}");
            sb.AppendLine($"Rompecabezas en stock: {puzzleTerminado.Count}\n");
            if (cantPuzzles > 0)
            {
                sb.AppendLine("**Catalogo**");

                for (int i = 0; i < cantPuzzles - 1; i++)
                {
                    sb.Append(puzzleTerminado.ElementAt(i).ToString());
                    for (int j = 1; j < cantPuzzles; j++)
                    {
                        if (puzzleTerminado.ElementAt(i) == puzzleTerminado.ElementAt(j))
                        {
                            total++;
                            i++;
                        }
                    }
                    sb.AppendLine($"Cantidad: {total}");
                    total = 0;
                }
                sb.AppendLine("\n");
            }
            return sb.ToString();
        }

        
    }
}   
