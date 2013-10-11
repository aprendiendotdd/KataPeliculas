using System;
namespace KataPeliculas
{
    public interface IDbContexto
    {
        void Insertar(Pelicula pelicula);
        System.Data.Entity.DbSet<Pelicula> Peliculas { get; set; }
    }
}
