using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitario_Kata_Peliculas
{
    [TestClass]
    public class Test_Sobre_Registros
    {
        [TestMethod]
        public void Validar_ID_Registro_leido_De_Fichero()
        {
            Pelicula pelicula = new Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
            Assert.AreEqual(1, pelicula.ID);         
        }
    }
}
