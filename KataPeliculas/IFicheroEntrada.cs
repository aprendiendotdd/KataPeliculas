using System;
using System.IO;
namespace KataPeliculas
{
    public interface IFicheroEntrada
    {
        bool Existe();

        System.IO.StreamReader Abrir();

        bool RecorrerFichero(StreamReader streamReader);

        string nombreFicheroEntrada { get; set; }

        
    }
}
