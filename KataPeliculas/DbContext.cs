using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPeliculas
{
    public class DbContexto : DbContext, KataPeliculas.IDbContexto
    {
        public DbSet<Pelicula> Peliculas{ get; set; }

        public void Insertar(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);            
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public int ObtenerCantidadPeliculasPorDirector(string director)
        {
            return Peliculas.Select(s => s.Director == director).Count();
        }
    }
}
