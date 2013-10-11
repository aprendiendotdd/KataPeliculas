using System;
namespace KataPeliculas
{
    public interface IDbContexto
    {
        void Insertar(Pelicula pelicula);
        void Commit();
        int ObtenerCantidadPeliculasPorDirector(string directo);
        System.Data.Entity.DbSet<Pelicula> Peliculas { get; set; }
    }
}
