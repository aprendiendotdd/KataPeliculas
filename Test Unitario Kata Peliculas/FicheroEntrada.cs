using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test_Unitario_Kata_Peliculas
{
    public class FicheroEntrada : Test_Unitario_Kata_Peliculas.IFicheroEntrada
    {
        public FicheroEntrada() : this(null) { }

        public string nombreFicheroEntrada { get; set; }

        public FicheroEntrada(string nombreFichero)
        {
            nombreFicheroEntrada = nombreFichero;
        }

        public virtual bool Existe()
        {
            return File.Exists(nombreFicheroEntrada);
        }

        public System.IO.StreamReader Abrir()
        {
            return new StreamReader(new FileStream(nombreFicheroEntrada, FileMode.Open, FileAccess.Read));
        }

        public bool RecorrerFichero(StreamReader contenidoFichero)
        {
            EsFicheroVacio(contenidoFichero);

            while (!contenidoFichero.EndOfStream)
            {
                try
                {
                    contenidoFichero.ReadLine();
                }
                catch
                {
                    throw new Exception("Error al leer registro");
                }
            }
            return true;
        }

        private static void EsFicheroVacio(StreamReader contenidoFichero)
        {
            if (contenidoFichero.EndOfStream) { throw new Exception("Fichero Vacio"); }
        }


    }
}
