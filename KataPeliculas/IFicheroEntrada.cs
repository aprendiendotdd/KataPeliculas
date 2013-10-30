using System;
using System.IO;
namespace KataPeliculas
{
    public interface IFicheroEntrada
    {
        bool Existe();
        System.IO.StreamReader Abrir();
        void Cerrar(StreamReader contenidoFichero);
        string ObtenerRegistro(StreamReader streamReader);

        string nombreFicheroEntrada { get; set; }
    }
}
