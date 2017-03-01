using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem msg1 = new MensagemAdministrativa("Administrador");
            IEnviador env1 = new EnviaPorEmail();
            msg1.enviador = env1;
            msg1.Envia();

            IMensagem msg2 = new MensagemDoCliente("Cliente");
            IEnviador env2 = new EnviaPorSms();
            msg2.enviador = env2;
            msg2.Envia();

            Console.ReadKey();
        }
    }
}
