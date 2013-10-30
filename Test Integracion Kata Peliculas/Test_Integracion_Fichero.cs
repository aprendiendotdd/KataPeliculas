using System;
using KataPeliculas;
using NUnit.Framework;

namespace Test_Integracion_Kata_Peliculas
{
  [TestFixture]
  public class Test_Integracion_Fichero_Entrada
  {
    [Test]
    public void DevuelveTrueSiExisteFichero()
    {
      var ficheroEntrada = new FicheroEntrada(@"C:\Temp\prueba2.txt");
      Assert.IsTrue(ficheroEntrada.Existe());
    }

    [Test]
    public void DevuelveFalseSiNoExisteFichero()
    {
      var ficheroEntrada = new FicheroEntrada(@"c:\temp\ficheroNoExiste.txt");
      Assert.IsFalse(ficheroEntrada.Existe());
    }

    [Test]
    public void DevuelveElContenidoDelFicheroSiSePuedeAbrirFichero()
    {
      var fileInput = new FicheroEntrada(@"c:\temp\prueba2.txt");
      var result = fileInput.Abrir();
      Assert.IsNotNull(result);
    }

    [Test]
    public void ElevaExcepcionSiElFicheroEstaVacio()
    {
      var fileInput = new FicheroEntrada(@"c:\temp\prueba2.txt");
      var exception = Assert.Throws<Exception>(() => fileInput.ObtenerRegistro(fileInput.Abrir()));
      Assert.That(exception, Has.Message.EqualTo("Fichero Vacio"));
    }

    [Test]
    public void LosRegistrosSonPeliculas()
    {
      var fileInput = new FicheroEntrada(@"c:\temp\Prueba2Datos.txt");
      const string esperado = "1|titulo|director|1|1.0";
      Assert.AreEqual(esperado, fileInput.ObtenerRegistro(fileInput.Abrir()));
    }

    [Test]
    public void InsertaRegistroLeidoEnBasedatos()
    {
      var fileInput = new FicheroEntrada(@"c:\temp\Prueba2Datos.txt");
      var stringPelicula = fileInput.ObtenerRegistro(fileInput.Abrir());
      

      IDbContexto iDbContexto = new DbContexto();
      var numDirector = iDbContexto.ObtenerCantidadPeliculasPorDirector("director");
      iDbContexto.Insertar(new Pelicula(stringPelicula));
      iDbContexto.Commit();
      Assert.AreEqual(numDirector + 1, iDbContexto.ObtenerCantidadPeliculasPorDirector("director"));
    }

    


  }
}
