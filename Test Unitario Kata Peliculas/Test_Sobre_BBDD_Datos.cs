using System;
using KataPeliculas;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitario_Kata_Peliculas
{
    [TestClass]
    public class Test_Sobre_BBDD_Datos
    {
        [TestMethod]
        public void Insertar_En_Base_De_Datos()
        {
            try
            {
                Rhino.Mocks.MockRepository mock = new Rhino.Mocks.MockRepository();
                KataPeliculas.IDbContexto context = mock.DynamicMock<IDbContexto>();

                Rhino.Mocks.Expect.Call<IDbContexto>(context).IgnoreArguments().Throw(new Exception("Error al insertar pelicula"));

                KataPeliculas.Pelicula pelicula = new KataPeliculas.Pelicula("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
                context.Insertar(pelicula);               
            }
            catch
            {
                //Ok
            }
        }

      


    }
}
