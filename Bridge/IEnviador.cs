using System;

namespace Bridge
{
    interface IEnviador
    {
        void Enviar(IMensagem mensagem);
    }
}
