using System;
namespace KataPeliculas
{
    public interface IEmail
    {
        void Enviar(string mensaje, string asunto);
    }
}
