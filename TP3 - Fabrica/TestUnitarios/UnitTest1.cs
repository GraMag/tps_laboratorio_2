using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using UI;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Usar_Carton_Con_Valido()
        {
            Inventario inventario = new Inventario();
            inventario.AgregarCarton(10);
            
            Assert.IsTrue(inventario.QuitarCarton(4, Enum.ECantPiezas.PIEZAS_500));
        }
     
        [TestMethod]
        public void Crear_Rompecabezas()
        {
            Fabrica fabrica = new Fabrica();
            fabrica.Inventario.AgregarCarton(10);
            fabrica.CrearRompecabezas(10, new Imagen("El Grito", "Munch", "Arte", false), Enum.ECantPiezas.PIEZAS_1000);
            Assert.AreEqual(fabrica.Inventario.SinCaja.Count, 10);

        }

        public void Tocar_Boton_Agregar_Carton_Excepcion()
        {
            Fabrica fabrica = new Fabrica();
            
            
        }
    }
}
