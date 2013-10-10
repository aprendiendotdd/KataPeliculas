using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitario_Kata_Peliculas
{
    [TestClass]
    public class Test_Fichero_Entrada
    {
        [TestMethod]
        public void Existe()
        {
            Rhino.Mocks.MockRepository mock = new Rhino.Mocks.MockRepository();

            IFicheroEntrada ficheroEntrada = mock.Stub<IFicheroEntrada>();

            Rhino.Mocks.Expect.Call(ficheroEntrada.Existe()).IgnoreArguments().Return(true);

            mock.Replay(ficheroEntrada);

            Assert.IsTrue(ficheroEntrada.Existe());

            mock.Verify(ficheroEntrada);

        }

        [TestMethod]
        public void Existe_Con_Stub_Artesanal()
        {
            FicheroEntradaStub fakeFicheroEntrada = new FicheroEntradaStub();

            IFicheroEntrada ficheroEntrada = fakeFicheroEntrada;
            
            Assert.IsTrue(ficheroEntrada.Existe());

        }

        [TestMethod]
        public void Abrir()
        {
            Rhino.Mocks.MockRepository mock = new Rhino.Mocks.MockRepository();

            IFicheroEntrada ficheroEntrada = mock.DynamicMock<IFicheroEntrada>();

            Rhino.Mocks.Expect.Call(ficheroEntrada.Abrir()).Return(mock.Stub<StreamReader>());
                       
            mock.Replay(ficheroEntrada);

            StreamReader contenidoFichero = ficheroEntrada.Abrir();

            Assert.IsNotNull(contenidoFichero);

            mock.Verify(ficheroEntrada);
        }

      



      

    }
}
