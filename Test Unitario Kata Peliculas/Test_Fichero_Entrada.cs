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

            Rhino.Mocks.Expect.Call(ficheroEntrada.Existe(ficheroEntrada.nombreFicheroEntrada)).IgnoreArguments().Return(true);

            mock.Replay(ficheroEntrada);

            Assert.IsTrue(ficheroEntrada.Existe(ficheroEntrada.nombreFicheroEntrada));

            mock.Verify(ficheroEntrada);

        }

        
    }
}
