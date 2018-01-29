using System;

namespace Bridges
{
    class MensagemAdministrativa : IMensagem
    {
        public string nome { get; set; }
        public IEnviador enviador { get; set; }

        public MensagemAdministrativa(String nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", nome);
        }
    }
}
