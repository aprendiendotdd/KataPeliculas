using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test_Unitario_Kata_Peliculas
{
    public class FakeStreamContenidoFichero
    {
        public FakeStreamContenidoFichero(bool erroneo)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);

            if (!erroneo)
            {
                sw.WriteLine("1|REGRESO AL FUTURO|ROBERT ZEMECKIS|3|9.99");
                sw.WriteLine("2|STAR WARS|GEORGE LUCAS|6|5.49");
                sw.WriteLine("3|TITANIC|JAMES CAMERON|1|10");
                sw.WriteLine("4|INDIANA JONES|STEVEN SPIELBERG|4|4.95");
                sw.WriteLine("5|PARQUE JURASICO|STEVEN SPIELBERG|3|2.5");
                sw.WriteLine("6|TERMINATOR|JAMES CAMERON|5|6.05");
                sw.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                contenidoFichero = new StreamReader(ms);
            }
            else
            {
                contenidoFichero = new StreamReader(new MemoryStream());
            }
        }

        public StreamReader contenidoFichero { get; private set; }
    }
}
