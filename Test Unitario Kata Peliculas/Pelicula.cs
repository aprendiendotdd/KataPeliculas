using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Unitario_Kata_Peliculas
{
    public class Pelicula
    {

        public Pelicula(string texto)
        {
            string[] datos = texto.Split('|');
            ValidarIDDatos(datos[0]);
            
        }

        private void ValidarIDDatos(string iD)
        {
            try
            {
                ID = int.Parse(iD);
            }
            catch
            {
                throw new Exception("ID no numerico");
            }
        }

        public int ID { get; private set; }
    }
}
