using System;
namespace Test_Unitario_Kata_Peliculas
{
    public interface IFicheroEntrada
    {
        bool Existe(string nombreFichero);
        string nombreFicheroEntrada { get; set; }
    }
}
