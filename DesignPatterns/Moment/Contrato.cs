using System;

namespace Memento
{
    class Contrato
    {
        public DateTime data { get; private set; }
        public String cliente { get; private set; }
        public TipoContrato tipo { get; private set; }

        public Contrato(DateTime data, String cliente, TipoContrato tipo)
        {
            this.data = data;
            this.cliente = cliente;
            this.tipo = tipo;
        }

        public void Avanca()
        {
            if (this.tipo == TipoContrato.Novo) this.tipo = TipoContrato.EmAndamento;
            else if (this.tipo == TipoContrato.EmAndamento) this.tipo = TipoContrato.Acertado;
            else if (this.tipo == TipoContrato.Acertado) this.tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.data, this.cliente, this.tipo));
        }
    }
}
