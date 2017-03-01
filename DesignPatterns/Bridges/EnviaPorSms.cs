using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridges
{
    class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS!");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
