using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test_Unitario_Kata_Peliculas
{
    public class FicheroEntrada : Test_Unitario_Kata_Peliculas.IFicheroEntrada
    {        
        public bool Existe(string nombreFichero)
        {
            return File.Exists(nombreFichero);
        }
    }
}
