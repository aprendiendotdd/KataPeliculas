using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace KataPeliculas
{
    public class Email : KataPeliculas.IEmail
    {
        private string servidor;
        private string from;
        private string to;

        public Email(string servidor, string from, string to)
        {
            this.servidor = servidor;
            this.from = from;
            this.to = to;
        }
        public void Enviar(string mensaje, string asunto)
        {
            try
            {
                SmtpClient smtp = new SmtpClient(servidor);
                smtp.Send(from, to, asunto, mensaje);
            }
            catch
            {
                throw new Exception("Error al enviar el mail");
            }
        }
    }
}
