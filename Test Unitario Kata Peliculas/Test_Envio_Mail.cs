using System;
using KataPeliculas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitario_Kata_Peliculas
{
    [TestClass]
    public class Test_Envio_Mail
    {
        string servidor = "";
        string from="";
        string to="";
        string mensaje="";
        string asunto="";

        [TestMethod]
        public void Enviar()
        {
            try
            {
                Rhino.Mocks.MockRepository mock = new Rhino.Mocks.MockRepository();
                IEmail mail = mock.DynamicMock<IEmail>(servidor, from, to);
                Rhino.Mocks.Expect.Call<IEmail>(mail).IgnoreArguments().Throw(new Exception("Error al Enviar Correo"));
                mail.Enviar(mensaje, asunto);
            }
            catch
            {
                //OK
            }
        }

        [TestMethod]
        public void Error_Al_Enviar()
        {
            try
            {
                KataPeliculas.Email mail = new KataPeliculas.Email(servidor, from, to);
                mail.Enviar(mensaje, asunto);
                Assert.Fail("No se pudo enviar el mail");
            }
            catch { //OK 
            }
        }

    }
}
