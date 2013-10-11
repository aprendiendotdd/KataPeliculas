using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Unitario_Kata_Peliculas
{
    public class FicheroEntradaStub : KataPeliculas.FicheroEntrada
    {
        public override bool Existe()
        {
            return true;
        }
    }
}
