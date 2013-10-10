using System;
using System.IO;
namespace Test_Unitario_Kata_Peliculas
{
    public interface IFicheroEntrada
    {
        bool Existe();

        System.IO.StreamReader Abrir();

        string nombreFicheroEntrada { get; set; }
        
    }
}
