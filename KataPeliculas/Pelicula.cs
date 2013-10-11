using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KataPeliculas
{
    public class Pelicula
    {
        public Pelicula(string texto)
        {
            string[] datos = texto.Split('|');
            ValidarIDDatos(datos[0]);
            ValidarTituloDatos(datos[1]);
            ValidarDirectorDatos(datos[2]);
            ValidarCantidadDatos(datos[3]);
            ValidarPrecioDatos(datos[4]);           
        }

        private void ValidarPrecioDatos(string precio)
        {
            try
            {
                Precio = float.Parse(precio);
            }
            catch
            {
                throw new Exception("Precio no valido");
            }
        }

        private void ValidarCantidadDatos(string cantidad)
        {
            try
            {

                Cantidad = int.Parse(cantidad);
            }
            catch
            {
                throw new Exception("Cantidad no numerico");
            }
        }

        private void ValidarDirectorDatos(string director)
        {
            if ((0 < director.Trim().Length) || (director.Trim().Length < 51))
            {
                Director = director;
            }
            else
            {
                throw new Exception("Director no valido");
            }
        }

        private void ValidarTituloDatos(string titulo)
        {
            if ((0 < titulo.Trim().Length) || (titulo.Trim().Length < 51))
            {
                Titulo = titulo;
            }
            else
            {
                throw new Exception("Titulo no valido");
            }
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
        public string Titulo { get; private set; }
        public string Director { get; private set; }
        public int Cantidad { get; private set; }
        public float Precio { get; private set; }      
    }



}
