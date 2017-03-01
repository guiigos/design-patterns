using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridges
{
    class MensagemDoCliente : IMensagem
    {
        public string nome { get; set; }
        public IEnviador enviador { get; set; }

        public MensagemDoCliente(String nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}
