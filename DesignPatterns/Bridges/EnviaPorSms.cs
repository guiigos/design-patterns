using System;

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
