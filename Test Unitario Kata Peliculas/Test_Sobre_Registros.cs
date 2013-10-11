using System;
using KataPeliculas;

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

        [TestMethod]
        public void Validar_Titulo_Registro_leido_De_Fichero()
        {
            Pelicula pelicula = new Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
            Assert.AreEqual("REGRESO AL FUTURO", pelicula.Titulo);
        }

        [TestMethod]
        public void Validar_Director_Registro_leido_De_Fichero()
        {
            Pelicula pelicula = new Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
            Assert.AreEqual("ROBERT ZEMECKIS", pelicula.Director);
        }

        [TestMethod]
        public void Validar_Cantidad_Registro_leido_De_Fichero()
        {
            Pelicula pelicula = new Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
            Assert.AreEqual(3, pelicula.Cantidad);
        }

        [TestMethod]
        public void Validar_Precio_Registro_leido_De_Fichero()
        {
            Pelicula pelicula = new Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9,99");
            Assert.AreEqual("9,99", pelicula.Precio.ToString());
        }
    }
}
