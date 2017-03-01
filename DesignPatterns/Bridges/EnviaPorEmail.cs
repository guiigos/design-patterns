using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridges
{
    class EnviaPorEmail : IEnviador 
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por e-mail!");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
