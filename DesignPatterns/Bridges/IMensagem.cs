﻿namespace Bridges
{
    interface IMensagem
    {
        IEnviador enviador { get; set; }

        void Envia();
        string Formata();
    }
}
