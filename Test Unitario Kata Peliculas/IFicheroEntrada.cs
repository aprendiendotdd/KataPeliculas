using System;
using System.IO;
namespace Test_Unitario_Kata_Peliculas
{
    public interface IFicheroEntrada
    {
        bool Existe();

        System.IO.StreamReader Abrir();

        bool RecorrerFichero(StreamReader streamReader);

        string nombreFicheroEntrada { get; set; }

        
    }
}
