using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;

namespace Entidades
{
    public class Fabrica
    {
        private Inventario inventario;
        private string nombre;

        public Fabrica()
        {
            inventario = new Inventario();
            nombre = "Puzzlesito";
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                
                nombre = String.IsNullOrEmpty(value) ? "Puzzlesito" : value;
            }
        }
        public Inventario Inventario 
        {
            get
            {
                return inventario;
            }
        }

        public bool CrearRompecabezas(int cantidad, Imagen imagen, ECantPiezas eCantPiezas)
        {
            if(inventario.QuitarCarton(cantidad, eCantPiezas) > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    inventario.PuzzleTerminado.Add(new Rompecabezas(eCantPiezas, nombre, imagen));
                }
                return true;
            }
            return false;
        }

        public void GuardarEnCaja()
        {
            foreach (Rompecabezas rompecabezas in inventario.PuzzleTerminado)
            {
                if (rompecabezas.Caja == null)
                {
                    rompecabezas.Caja = inventario.CajasImpresas.Pop();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>Numero de cajas creadas, si no hay carton devuelve 0 </returns>
        public int ArmarCajas(int cantidad)
        {
            int cantidadCarton = cantidad % 2 == 0 ? cantidad / 2 : (cantidad - 1) / 2;
            int cantidadCajas = cantidadCarton * 2;
            if (cantidad > 1 && inventario.QuitarCarton(cantidadCarton))
            {
                for (int i = 0; i < cantidadCajas; i++)
                {
                    inventario.Cajas.Push(new Caja());
                }
                return cantidadCajas;
            }
            return 0;
        }

        public Stack<Caja> ImprimirCajas(int cantidad, Imagen imagen)
        {
            if(cantidad <= inventario.Cajas.Count)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    inventario.Cajas.Peek().Imagen = imagen;
                    inventario.CajasImpresas.Push(inventario.Cajas.Pop());
                }
            }
            return inventario.CajasImpresas;
        }


    }
}
