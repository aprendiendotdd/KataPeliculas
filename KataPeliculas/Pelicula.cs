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
            bbddDataSet.tablaPeliculasDataTable table = new bbddDataSet.tablaPeliculasDataTable();
            registroPelicula = table.NewtablaPeliculasRow();
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
                registroPelicula.Precio = double.Parse(precio);
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

                registroPelicula.Cantidad = int.Parse(cantidad);
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
                registroPelicula.Director = director;
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
                registroPelicula.Titulo = titulo;
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
                registroPelicula.ID = int.Parse(iD);
            }
            catch
            {
                throw new Exception("ID no numerico");
            }
        }

        public bbddDataSet.tablaPeliculasRow registroPelicula;
      
    }



}
